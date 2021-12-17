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

        public Func<Task<IMqttClient>> CreateClient(string ClientId)
        {
            var mqttOpts = new MqttClientOptionsBuilder()
                        .WithClientId(ClientId)
                        .WithTcpServer(_mqttOptions.Value.Host, _mqttOptions.Value.Port)
                        .WithCredentials(_mqttOptions.Value.Username, _mqttOptions.Value.Passwort)
                        .Build();

            return async () =>
            {
                var factory = new MqttFactory();
                var client = factory.CreateMqttClient();
                await client.ConnectAsync(mqttOpts, CancellationToken.None);
                return client;
            };
        }

        public Func<Task<IManagedMqttClient>> CreateManagedClient(IMqttClientOptions ClientOpts)
        {
            var mqttOpts = new ManagedMqttClientOptionsBuilder()
            .WithAutoReconnectDelay(TimeSpan.FromSeconds(10))
            .WithClientOptions(ClientOpts)
            .Build();

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
