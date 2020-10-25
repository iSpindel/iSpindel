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
            Console.WriteLine($"Response Topic: {this.topicServerResponse}");
            Console.WriteLine($"Request Topic: {this.topicServerRequest}");
        }

        public async Task Init()
        {
            this.mqttClient = await options.MqttClientFactory();
            Console.WriteLine("Verifying Connection");
            mqttClient.UseConnectedHandler(this.VerifyConnection);
            await subscribeToControlTopics();
        }

        private void VerifyConnection(MqttClientConnectedEventArgs connectArgs)
        {
            if (connectArgs.AuthenticateResult.ResultCode != MqttClientConnectResultCode.Success)
            {
                Console.WriteLine("Connection Failed");
                return;
            }
            Console.WriteLine("Connection Successfull");
            return;
        }

        private async Task subscribeToControlTopics()
        {
            await mqttClient.SubscribeAsync(this.topicServerRequest);
            mqttClient.UseApplicationMessageReceivedHandler(async e =>
            {
                Console.WriteLine($"Received Message on Topic {e.ApplicationMessage.Topic} with Payload {Encoding.UTF8.GetString(e.ApplicationMessage.Payload)}");
                if (e.ApplicationMessage.Topic == this.topicServerRequest)
                {
                    await handleMessage(Encoding.UTF8.GetString(e.ApplicationMessage.Payload));
                }
            });
            Console.WriteLine($"Subscribed to Topic {this.topicServerRequest}");
        }

        private async Task handleMessage(string payload)
        {
            if (payload.Equals("Stop"))
            {
                Console.WriteLine("Stop signal received");
                var rc = await server.StopAsync();
                Console.WriteLine($"Stop returned {rc.ToString()}");
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
                Console.WriteLine($"Start signal received with ID {stringId}");

                if (Int32.TryParse(stringId, out var id))
                { rc = await server.StartAsync(id); }

                Console.WriteLine($"Start returned {rc}");

                await sendRpcReply(rc ? "Start Successful" : "Start Failed");
            }
            else if (payload.Equals("Status"))
            {
                Console.WriteLine("Status signal received");
                var currentStatus = await server.GetStatusAsync();
                Console.WriteLine($"Status: {currentStatus}");
                await sendRpcReply(currentStatus.ToString());
            }

        }

        private async Task sendRpcReply(string payload)
        {

            var message = new MqttApplicationMessageBuilder()
            .WithTopic(this.topicServerResponse)
            .WithPayload(payload)
            .Build();

            Console.WriteLine($"Publishing Message {payload} to topic {this.topicServerResponse}");
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