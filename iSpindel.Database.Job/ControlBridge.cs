using System;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Extensions.ManagedClient;

namespace iSpindel.Database.Job
{
    public class ControlBridge //: IDisposable
    {
        private readonly ControlBridgeOptions options;
        private readonly ISpindelService server;
        private IManagedMqttClient mqttClient;
        private readonly string topicServerResponse;
        private readonly string topicServerRequest;

        public ControlBridge(ControlBridgeOptions options)
        {
            this.options = options;
            this.topicServerResponse = options.TopicBasePath + options.ServerResponse;
            this.topicServerRequest = options.TopicBasePath + options.ServerRequest;
            this.server = options.SpindelService;
        }

        public async Task Init()
        {
            this.mqttClient = await options.MqttClientFactory();
            mqttClient.UseConnectedHandler(this.VerifyConnection);
        }

        private async Task VerifyConnection(MqttClientConnectedEventArgs connectArgs)
        {
            if (connectArgs.AuthenticateResult.ResultCode != MqttClientConnectResultCode.Success)
            {
                return;
            }
            await subscribeToControlTopics();
        }

        private async Task subscribeToControlTopics()
        {
            await mqttClient.SubscribeAsync(this.topicServerRequest);
            mqttClient.UseApplicationMessageReceivedHandler(async e =>
            {
                if (e.ApplicationMessage.Topic == this.topicServerResponse)
                {
                    await handleMessage(Encoding.UTF8.GetString(e.ApplicationMessage.Payload));
                }
            });
        }

        private async Task handleMessage(string payload)
        {
            if (payload.Equals("Stop"))
            {
                var rc = await server.StopAsync();
                await sendRpcReply(rc ? "Stop Successful" : "Stop Failed");
            }
            else if (payload.Contains("Start"))
            {
                var rc = false;
                string stringId;
                try { stringId = payload.Split('|').Last(); }
                catch (Exception)
                {
                    // If no number is supplied, record to default sequence
                    stringId = "-1";
                }

                if (Int32.TryParse(stringId, out var id))
                { rc = await server.StartAsync(id); }
                await sendRpcReply(rc ? "Start Successful" : "Start Failed");
            }
            else if (payload.Equals("Status"))
            {
                var currentStatus = await server.GetStatusAsync();
                await sendRpcReply("Status " + currentStatus.ToString());
            }

        }

        private async Task sendRpcReply(string payload)
        {

            var message = new MqttApplicationMessageBuilder()
            .WithTopic(this.topicServerResponse)
            .WithPayload(payload)
            .Build();

            await mqttClient.PublishAsync(message, CancellationToken.None);

        }

        /*
                public void Dispose()
                {
                    throw new NotImplementedException();
                }

                // TODO do a proper cleanup, probably via Disposable
                */
    }
}