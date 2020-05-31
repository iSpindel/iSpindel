using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using MQTTnet;
using MQTTnet.Client.Options;
using MQTTnet.Extensions.ManagedClient;
using Xunit;

namespace iSpindel.Database.Job.Test
{
    public class TestSpindelClient
    {
        private readonly iSpindelClientOptions _clientOpts;
        private readonly IConfigurationSection mqttOpts;

        public TestSpindelClient()
        {
            var configurationRoot = new ConfigurationBuilder()
                    .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                    .AddJsonFile("appsettings.json", false, false)
                    .AddJsonFile("appsettings.Production.json", true, false)
                    .Build();

            var mqttOpts = configurationRoot.GetSection("Mqtt");
            this.mqttOpts = mqttOpts;

            _clientOpts = BuildISpindelClientOpts(mqttOpts);

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
            Assert.NotNull(_clientOpts);
            Assert.NotNull(_clientOpts.TopicServerRequest);
            Assert.NotNull(_clientOpts.TopicBasePath);
            Assert.NotNull(_clientOpts.TopicServerResponse);
            var _iSpindelClient = new iSpindelClient(_clientOpts);

        }

        [Fact]
        public void TestStart()
        {

            var _iSpindelClient = new iSpindelClient(_clientOpts);
            var startTask = _iSpindelClient.StartAsync(-1);
            startTask.Wait();

            var status = startTask.Result;
            Assert.True(status);

        }

        [Fact(Skip = "Skipping Stop Test")]
        public void TestStop()
        {

            var _iSpindelClient = new iSpindelClient(_clientOpts);
            var stopTask = _iSpindelClient.StopAsync();
            stopTask.Wait();

            var status = stopTask.Result;
            Assert.True(status);
        }

        [Fact(Skip = "Skipping Status Test")]
        public void TestStatus()
        {

            var _iSpindelClient = new iSpindelClient(_clientOpts);
            var statusTask = _iSpindelClient.GetStatusAsync();
            statusTask.Wait();

            var status = statusTask.Result;
            Assert.Equal(StatusCode.IDLE, status);


        }

        private iSpindelClientOptions BuildISpindelClientOpts(IConfigurationSection options)
        {


            var mqttClientOpts = new MqttClientOptionsBuilder()
            .WithTcpServer(options.GetValue<string>("Host"), options.GetValue<int>("Port"))
            .WithCredentials(options.GetValue<string>("Username"), options.GetValue<string>("Password"))
            .Build();

            var managedMqttClientOpts = new ManagedMqttClientOptionsBuilder()
            .WithAutoReconnectDelay(TimeSpan.FromSeconds(30))
            .WithClientOptions(mqttClientOpts)
            .Build();

            Func<Task<IManagedMqttClient>> managedMqttClientFactory = async () =>
                {
                    var factory = new MqttFactory();
                    var client = factory.CreateManagedMqttClient();
                    Console.WriteLine($"Starting mqtt client");
                    await client.StartAsync(managedMqttClientOpts);
                    return client;
                };

            var iSpindelOpts = new iSpindelClientOptions()
            {
                MqttClientFactory = managedMqttClientFactory,
                TopicBasePath = options.GetValue<string>("Topics:iSpindelTopicBasePath"),
                TopicServerRequest = options.GetValue<string>("Topics:ServerRequest"),
                TopicServerResponse = options.GetValue<string>("Topics:ServerResponse")

            };

            return iSpindelOpts;

        }
    }
}
