using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Exceptions;
using MQTTnet.Extensions.ManagedClient;
using MQTTnet.Extensions.Rpc;
using MQTTnet.Protocol;

namespace iSpindel.Database.Job
{
    public class MqttRpcService
    {
        private readonly ConcurrentDictionary<string, TaskCompletionSource<byte[]>> waitingCalls = new ConcurrentDictionary<string, TaskCompletionSource<byte[]>>();

        protected readonly string topicServerResponse;
        private readonly IMqttClient mqttClient;
        protected readonly string topicServerRequest;
        private readonly TimeSpan timeout = TimeSpan.FromSeconds(30);
        private const MqttQualityOfServiceLevel qos = MqttQualityOfServiceLevel.AtMostOnce;
        private readonly CancellationToken cancellationToken = CancellationToken.None;
        private readonly RpcAwareApplicationMessageReceivedHandler applicationMessageReceivedHandler;

        public MqttRpcService(string topicServerRequest, string topicServerResponse, IMqttClient mqttClient)
        {
            this.topicServerRequest = topicServerRequest;
            this.topicServerResponse = topicServerResponse;
            this.mqttClient = mqttClient;
            applicationMessageReceivedHandler = new RpcAwareApplicationMessageReceivedHandler(
                mqttClient.ApplicationMessageReceivedHandler,
                HandleApplicationMessageReceivedAsync);

            mqttClient.ApplicationMessageReceivedHandler = applicationMessageReceivedHandler;
        }
        public async Task<byte[]> ExecuteAsyncRpcRequest(string payload)
        {
            var requestMessage = new MqttApplicationMessageBuilder()
                .WithTopic(topicServerRequest)
                .WithPayload(payload)
                .WithQualityOfServiceLevel(qos)
                .Build();

            try
            {
                var tcs = new TaskCompletionSource<byte[]>();
                if (!waitingCalls.TryAdd(topicServerResponse, tcs))
                {
                    throw new InvalidOperationException();
                }

                await mqttClient.SubscribeAsync(topicServerResponse).ConfigureAwait(false);
                await mqttClient.PublishAsync(requestMessage).ConfigureAwait(false);

                using (var timeoutCts = new CancellationTokenSource(timeout))
                using (var linkedCts = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, timeoutCts.Token))
                {
                    linkedCts.Token.Register(() =>
                    {
                        if (!tcs.Task.IsCompleted && !tcs.Task.IsFaulted && !tcs.Task.IsCanceled)
                        {
                            tcs.TrySetCanceled();
                        }
                    });

                    try
                    {
                        var result = await tcs.Task.ConfigureAwait(false);
                        timeoutCts.Cancel(false);
                        return result;
                    }
                    catch (OperationCanceledException exception)
                    {
                        if (timeoutCts.IsCancellationRequested && !cancellationToken.IsCancellationRequested)
                        {
                            throw new MqttCommunicationTimedOutException(exception);
                        }
                        else
                        {
                            throw;
                        }
                    }
                }
            }
            finally
            {
                waitingCalls.TryRemove(topicServerResponse, out _);
                if(mqttClient.IsConnected)
                    await mqttClient.UnsubscribeAsync(topicServerResponse).ConfigureAwait(false);
            }

        }

        private Task HandleApplicationMessageReceivedAsync(MqttApplicationMessageReceivedEventArgs eventArgs)
        {
            if (!waitingCalls.TryRemove(eventArgs.ApplicationMessage.Topic, out var tcs))
            {
                return Task.FromResult(0);
            }

            tcs.TrySetResult(eventArgs.ApplicationMessage.Payload);

            return Task.FromResult(0);
        }

        public void Dispose()
        {
            mqttClient.ApplicationMessageReceivedHandler = applicationMessageReceivedHandler.OriginalHandler;

            foreach (var tcs in waitingCalls)
            {
                tcs.Value.TrySetCanceled();
            }

            waitingCalls.Clear();
        }
    }
}