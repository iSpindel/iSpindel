using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;

namespace iSpindel.Database.Job
{
    public class ControlBridge : IDisposable
    {
        private readonly ISpindelService server;
        private readonly IMqttClient mqttClient;
        private readonly string topicPrefix;
        private readonly string topicRecordRequest;
        private readonly string topicServerStatusRequest;

        public ControlBridge(string topicPrefix, ISpindelService server, IMqttClient mqttClient)
        {
            this.server = server;
            this.mqttClient = mqttClient;
            this.topicPrefix = topicPrefix.EndsWith("/") ? topicPrefix : topicPrefix + '/';
            this.topicRecordRequest = topicPrefix + "RecordRequest";
            this.topicServerStatusRequest = topicPrefix + "ServerStatusRequest";
            mqttClient.UseConnectedHandler(this.Init);
        }

        public async Task Init(MqttClientConnectedEventArgs connectArgs)
        {
            if (connectArgs.AuthenticateResult.ResultCode != MqttClientConnectResultCode.Success)
            {
                return;
            }

            await subscribeToControlTopics();
        }

        private async Task subscribeToControlTopics()
        {
            await mqttClient.SubscribeAsync(this.topicRecordRequest);
            await mqttClient.SubscribeAsync(this.topicServerStatusRequest);
            mqttClient.UseApplicationMessageReceivedHandler(async e =>
            {
                if (e.ApplicationMessage.Topic == this.topicRecordRequest)
                {
                    await handleStartStop(Encoding.UTF8.GetString(e.ApplicationMessage.Payload));
                }
                else if (e.ApplicationMessage.Topic == this.topicServerStatusRequest)
                {
                    await handleRecordStatus(Encoding.UTF8.GetString(e.ApplicationMessage.Payload));
                }
            });
        }

        private async Task handleRecordStatus(string payload)
        {
            var currentStatus = await server.GetStatusAsync();
            var message = new MqttApplicationMessageBuilder()
            .WithTopic(this.topicServerStatusRequest)
            .WithPayload(currentStatus.ToString())
            .Build();

            await mqttClient.PublishAsync(message, CancellationToken.None);
        }

        private async Task handleStartStop(string payload)
        {
            bool rc;
            if (payload.Equals("stop"))
            {
                rc = await server.StopAsync();
            }
            else
            {
                if (Int32.TryParse(payload, out var id))
                {
                    rc = await server.StartAsync(id);
                }
            }
            // TODO do something with the return code
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        // TODO do a proper cleanup, probably via Disposable
        // TODO handle Reconnect => do this in a connection factory shared with iSpindelServer
    }
}