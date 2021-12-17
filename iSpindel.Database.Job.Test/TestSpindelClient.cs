using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MQTTnet;
using MQTTnet.Client.Options;
using MQTTnet.Extensions.ManagedClient;
using iSpindel.Database.Job.Runner;
using Xunit;
using System.Threading;

namespace iSpindel.Database.Job.Test
{
    public class TestSpindelClient
    {
        private readonly IConfigurationSection mqttOpts;
        private RunnerOptions runnerOptions;
        private Runner.Runner runner;

        public TestSpindelClient()
        {
            var configurationRoot = new ConfigurationBuilder()
                    .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                    .AddJsonFile("appsettings.json", false, false)
                    .AddJsonFile("appsettings.Production.json", true, false)
                    .Build();

            var mqttOpts = configurationRoot.GetSection("Mqtt");
            this.mqttOpts = mqttOpts;

            runner = InitializeRunner(configurationRoot);
        }

        [Fact]
        public void TestConfigFile()
        {
            Assert.Equal(1883, mqttOpts.GetValue<int>("Port"));
            Assert.NotNull(mqttOpts.GetValue<string>("Topics:iSpindelTopicBasePath"));
            Assert.NotNull(mqttOpts.GetValue<string>("Topics:ServerRequest"));
            Assert.NotNull(mqttOpts.GetValue<string>("Topics:ServerResponse"));
        }


        [Fact]
        public void TestCreateClient()
        {
            var _iSpindelClient = BuildSpindelClient(runner);
            Assert.IsType<iSpindelClientGrpc>(_iSpindelClient);
        }


        [Fact]
        public void TestStart()
        {

            var _iSpindelClient = BuildSpindelClient(runner);
            var startTask = _iSpindelClient.StartAsync(-1);
            startTask.Wait();

            var status = startTask.Result;
            Assert.True(status);

        }

        [Fact]
        public void TestStop()
        {

            var _iSpindelClient = BuildSpindelClient(runner);
            var stopTask = _iSpindelClient.StopAsync();
            stopTask.Wait();

            var status = stopTask.Result;
            Assert.True(status);
        }

        [Fact]
        public void TestStatus()
        {

            var _iSpindelClient = BuildSpindelClient(runner);
            var statusTask = _iSpindelClient.GetStatusAsync();
            statusTask.Wait();

            var status = statusTask.Result;
            Assert.Equal(StatusCode.IDLE, status);

        }

        private Runner.Runner InitializeRunner(IConfigurationRoot configurationRoot)
        {
            runnerOptions = new RunnerOptions()
            {
                ConnectionString = configurationRoot.GetConnectionString("DefaultConnection"),
                MqttHost = configurationRoot.GetSanitizedValue<string>("Mqtt:Host"),
                MqttPort = configurationRoot.GetSanitizedValue<int?>("Mqtt:Port", 1833).Value,
                MqttUsername = configurationRoot.GetSanitizedValue<string>("Mqtt:Credentials:Username"),
                MqttPassword = configurationRoot.GetSanitizedValue<string>("Mqtt:Credentials:Password"),

                TopicControlBridgeBasePath = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:ControlBridgeTopicBasePath", "spindelControl/").AppendTerminatorChar(),
                TopicISpindelBasePath = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelTopicBasePath").AppendTerminatorChar(),
                TopicServerRequest = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:ServerRequest", "Request"),
                TopicServerResponse = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:ServerResponse", "Response"),
                TopicISpindelTemperature = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelTemperature"),
                TopicISpindelBattery = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelBattery"),
                TopicISpindelGravity = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelGravity"),
            };

            return new Runner.Runner(runnerOptions);
        }
        private iSpindelClientGrpc BuildSpindelClient(Runner.Runner runner)
        {
            var mqttClientOpts = runner.BuildClientOpts("XUnit-Client");

            Func<Task<MQTTnet.Client.IMqttClient>> mqttClientFactory = async () =>
            {
                var factory = new MqttFactory();
                var client = factory.CreateMqttClient();
                var authResult = await client.ConnectAsync(mqttClientOpts, CancellationToken.None);
                Console.Write(authResult.ResponseInformation);
                return client;
            };

            var iSpindelOpts = new iSpindelClientOptions()
            {
                MqttClientFactory = mqttClientFactory,
                TopicBasePath = runnerOptions.TopicISpindelBasePath,
                TopicServerRequest = runnerOptions.TopicServerRequest,
                TopicServerResponse = runnerOptions.TopicServerResponse
            };

            var _iSpindelClient = new iSpindelClient(iSpindelOpts);

            return _iSpindelClient;


        }
    }
}
