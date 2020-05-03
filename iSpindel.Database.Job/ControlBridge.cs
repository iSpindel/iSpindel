using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;

namespace iSpindel.Database.Job
{
    public class ControlBridge
    {
        private readonly ISpindelService server;
        private readonly IMqttClient mqttClient;

        public ControlBridge(ISpindelService server, IMqttClient mqttClient)
        {
            this.server = server;
            this.mqttClient = mqttClient;
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
            await mqttClient.SubscribeAsync("RecordRequest");
            await mqttClient.SubscribeAsync("ServerStatusRequest");
            mqttClient.UseApplicationMessageReceivedHandler(async e =>
            {
                if (e.ApplicationMessage.Topic == "RecordRequest")
                {
                    await handleStartStop(Encoding.UTF8.GetString(e.ApplicationMessage.Payload));
                }
                else if (e.ApplicationMessage.Topic == "ServerStatusRequest")
                {
                    await handleRecordStatus(Encoding.UTF8.GetString(e.ApplicationMessage.Payload));
                }
            });
        }

        private async Task handleRecordStatus(string payload)
        {
            var currentStatus = await server.GetStatusAsync();
            var message = new MqttApplicationMessageBuilder()
            .WithTopic("ServerStatus")
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
            // May handle this via MQTTnet.Extensions.Rpc, see https://github.com/chkr1011/MQTTnet/wiki/Client#rpc-calls
        }

        // TODO do a proper cleanup, probably via Disposable
        // TODO handle Reconnect => do this in a connection factory shared with iSpindelServer
    }
}