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
                    await client.StartAsync(managedMqttClientOpts);
                    return client;
                };

            var serverOpts = new iSpindelServerOptions()
            {
                MqttClientFactory = managedMqttClientFactory,
                DbContext = () =>
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

            var server = new iSpindelServer(serverOpts);

            var bridgeOpts = new ControlBridgeOptions()
            {
                MqttClientFactory = managedMqttClientFactory,
                SpindelService = server,
                TopicBasePath = options.TopicControlBridgeBasePath,
                TopicRecordRequest = options.TopicRecordRequest,
                TopicServerStatusRequest = options.TopicServerStatusRequest
            };

            var mqttControlBridge = new ControlBridge(bridgeOpts);
            await mqttControlBridge.Init();

        }
    }
}
