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
            var mqttClientOpts = new MqttClientOptionsBuilder()
            .WithTcpServer(options.MqttHost, options.MqttPort)
            .WithCredentials(options.MqttUsername, options.MqttPassword)
            .Build();

            var managedMqttClientOpts = new ManagedMqttClientOptionsBuilder()
            .WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
            .WithClientOptions(mqttClientOpts)
            .Build();

            Func<Task<IMqttClient>> mqttClientFactory = async () =>
                {
                    var factory = new MqttFactory();
                    var client = factory.CreateMqttClient();
                    await client.ConnectAsync(mqttClientOpts, CancellationToken.None);
                    return client;
                };

            Func<Task<IManagedMqttClient>> managedMqttClientFactory = async () =>
                {
                    var factory = new MqttFactory();
                    var client = factory.CreateManagedMqttClient();
                    //await mqttClient.SubscribeAsync(new TopicFilterBuilder().WithTopic("my/topic").Build());
                    Console.WriteLine($"Starting mqtt client");
                    await client.StartAsync(managedMqttClientOpts);
                    return client;
                };

            var serverOpts = new iSpindelServerOptions()
            {
                MqttClientFactory = managedMqttClientFactory,
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
                MqttClientFactory = managedMqttClientFactory,
                SpindelService = this.Server,
                TopicBasePath = options.TopicControlBridgeBasePath,
                TopicRecordRequest = options.TopicRecordRequest,
                TopicServerStatusRequest = options.TopicServerStatusRequest
            };

            //this.ControlBridge = new ControlBridge(bridgeOpts);
            //await this.ControlBridge.Init();

        }
    }
}
