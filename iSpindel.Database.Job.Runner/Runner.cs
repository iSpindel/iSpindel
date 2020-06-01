using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using MQTTnet.Extensions.ManagedClient;

namespace iSpindel.Database.Job.Runner
{
    public class Runner
    {
        private RunnerOptions options;

        public ISpindelService Server { get; set; }
        public ControlBridge ControlBridge { get; set; }

        public Runner(RunnerOptions options)
        {
            this.options = options;
        }

        public async Task Run()
        {
            var mqttClientOptsBridge = BuildClientOpts("iSpindel-ControlBridge");
            var mqttClientOptsServer = BuildClientOpts("iSpindel-Server");

            var managedMqttClientOptsBridge = BuildManagedClientOpts(mqttClientOptsBridge);
            var managedMqttClientOptsServer = BuildManagedClientOpts(mqttClientOptsServer);

            //var BridgeFactory = BuildClientFactory(mqttClientOptsBridge);
            //var ServerFactory = BuildClientFactory(mqttClientOptsServer);

            var BridgeManagedFactory = BuildManagedClientFactory(managedMqttClientOptsBridge);
            var ServerManagedFactory = BuildManagedClientFactory(managedMqttClientOptsServer);



            var serverOpts = new iSpindelServerOptions()
            {
                MqttClientFactory = ServerManagedFactory,
                DbContextFactory = () =>
                {
                    var optionsBuilder = new DbContextOptionsBuilder<iSpindelContext>()
                    .UseNpgsql(options.ConnectionString);
                    return new iSpindelContext(optionsBuilder.Options);
                },
                TopicBasePath = options.TopicISpindelBasePath,
                TopicTemperature = options.TopicISpindelTemperature,
                TopicBattery = options.TopicISpindelBattery,
                TopicGravity = options.TopicISpindelGravity,
            };

            this.Server = new iSpindelServer(serverOpts);

            var bridgeOpts = new ControlBridgeOptions()
            {
                MqttClientFactory = BridgeManagedFactory,
                SpindelService = this.Server,
                TopicBasePath = options.TopicControlBridgeBasePath,
                ServerResponse = options.TopicServerResponse,
                ServerRequest = options.TopicServerRequest
            };

            this.ControlBridge = new ControlBridge(bridgeOpts);
            await this.ControlBridge.Init();

        }

        private IMqttClientOptions BuildClientOpts(string ClientId)
        {
            return new MqttClientOptionsBuilder()
                        .WithClientId(ClientId)
                        .WithTcpServer(options.MqttHost, options.MqttPort)
                        .WithCredentials(options.MqttUsername, options.MqttPassword)
                        .Build();
        }

        private ManagedMqttClientOptions BuildManagedClientOpts(IMqttClientOptions ClientOpts)
        {
            return new ManagedMqttClientOptionsBuilder()
            .WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
            .WithClientOptions(ClientOpts)
            .Build();
        }

        private Func<Task<IMqttClient>> BuildClientFactory(IMqttClientOptions ClientOpts)
        {
            return async () =>
                            {
                                var factory = new MqttFactory();
                                var client = factory.CreateMqttClient();
                                await client.ConnectAsync(ClientOpts, CancellationToken.None);
                                return client;
                            };

        }

        private Func<Task<IManagedMqttClient>> BuildManagedClientFactory(ManagedMqttClientOptions ClientOpts)
        {
            return async () =>
                            {
                                var factory = new MqttFactory();
                                var client = factory.CreateManagedMqttClient();
                                //await mqttClient.SubscribeAsync(new TopicFilterBuilder().WithTopic("my/topic").Build());
                                Console.WriteLine($"Starting mqtt client");
                                await client.StartAsync(ClientOpts);
                                return client;
                            };
        }
    }
}
