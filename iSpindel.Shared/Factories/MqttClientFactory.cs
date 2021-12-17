using Microsoft.Extensions.Options;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using System;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Extensions.ManagedClient;
using iSpindel.Shared.Options;
using System.Threading;

namespace iSpindel.Shared.Factories
{
    public class MqttClientFactory : IMqttClientFactory
    {
        private readonly IOptions<MqttOptions> _mqttOptions;

        public MqttClientFactory(IOptions<MqttOptions> mqttOptions)
        {
            this._mqttOptions = mqttOptions;
        }
        private IMqttClientOptions BuildClientOpts(string clientId)
        {
            return new MqttClientOptionsBuilder()
                        .WithClientId(clientId)
                        .WithTcpServer(_mqttOptions.Value.Host, _mqttOptions.Value.Port)
                        .WithCredentials(_mqttOptions.Value.Username, _mqttOptions.Value.Passwort)
                        .Build();
        }

        private ManagedMqttClientOptions BuildManagedClientOpts(IMqttClientOptions clientOpts)
        {
            return new ManagedMqttClientOptionsBuilder()
            .WithAutoReconnectDelay(TimeSpan.FromSeconds(10))
            .WithClientOptions(clientOpts)
            .Build();
        }

        public Func<Task<IMqttClient>> CreateClient(string clientId)
        {
            var mqttOpts = BuildClientOpts(clientId);
            return async () =>
            {
                var factory = new MqttFactory();
                var client = factory.CreateMqttClient();
                await client.ConnectAsync(mqttOpts, CancellationToken.None);
                return client;
            };
        }

        public (IManagedMqttClient client, ManagedMqttClientOptions options) CreateManagedClient(string clientId)
        {
            var mqttClientOpts = BuildClientOpts(clientId);
            var mqttOpts = BuildManagedClientOpts(mqttClientOpts);
            var factory = new MqttFactory();
            return (factory.CreateManagedMqttClient(), mqttOpts);
        }
        public Func<Task<IManagedMqttClient>> CreateManagedClient(IMqttClientOptions clientOpts)
        {
            var mqttOpts = BuildManagedClientOpts(clientOpts);

            return async () =>
                            {
                                var factory = new MqttFactory();
                                var client = factory.CreateManagedMqttClient();
                                //await mqttClient.SubscribeAsync(new TopicFilterBuilder().WithTopic("my/topic").Build());
                                Console.WriteLine($"Starting mqtt client");
                                await client.StartAsync(mqttOpts);
                                return client;
                            };
        }
    }
}
