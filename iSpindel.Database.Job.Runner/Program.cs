using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MQTTnet;
using MQTTnet.Client.Options;
using Npgsql;

namespace iSpindel.Database.Job.Runner
{
    internal static class ConfigurationExtensions
    {
        public static T ValidateConfigString<T>(this IConfigurationRoot configurationRoot, string configKey, T defaultValue = default(T))
        {
            var configEntry = configurationRoot.GetValue<T>(configKey);

            if (
                (configEntry is string strEntry && String.IsNullOrWhiteSpace(strEntry)) ||
                (configEntry == null && defaultValue == null)
             )
            {
                throw new ArgumentException($"Config key {configKey} is empty or missing and has no default value");
            }

            if (configEntry == null)
            {
                return defaultValue;
            }

            return configEntry;
        }

    }

    internal static class StringExtensions {
        public static string ValidatePrefix(this string prefix) {
            return prefix.EndsWith("/") ? prefix : prefix + '/';
        }

    }

    internal class Program
    {

        static void Main(string[] args)
        {

            var factory = new MqttFactory();
            var mqttControlClient = factory.CreateMqttClient();
            var mqttDataClient = factory.CreateMqttClient();

            var configurationRoot = new ConfigurationBuilder()
                    .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                    .AddJsonFile("appsettings.json", false, false)
                    .AddJsonFile("appsettings.Production.json", true, false)
                    .Build();

            var runnerOptions = new RunnerOptions()
            {
                ConnectionString = configurationRoot.GetConnectionString("DefaultConnection"),
                MqttHost = configurationRoot.ValidateConfigString<string>("Mqtt:Host"),
                MqttPort = configurationRoot.ValidateConfigString<int?>("Mqtt:Port", 1833).Value,
                MqttUsername = configurationRoot.ValidateConfigString<string>("Mqtt:Credentials:Username"),
                MqttPassword = configurationRoot.ValidateConfigString<string>("Mqtt:Credentials:Password"),

                TopicControlBridgeBasePath = configurationRoot.ValidateConfigString<string>("Mqtt:Topics:ControlBridgeTopicBasePath", "spindelControl/").ValidatePrefix(),
                TopicISpindelBasePath = configurationRoot.ValidateConfigString<string>("Mqtt:Topics:iSpindelTopicBasePath").ValidatePrefix(),

                TopicRecordRequest = configurationRoot.ValidateConfigString<string>("Mqtt:Topics:RecordRequest", "RecordRequest"),
                TopicServerStatusRequest = configurationRoot.ValidateConfigString<string>("Mqtt:Topics:ServerStatusRequest", "ServerStatusRequest"),
                TopicISpindelTemperature = configurationRoot.ValidateConfigString<string>("Mqtt:Topics:iSpindelBattery"),
                TopicISpindelBattery = configurationRoot.ValidateConfigString<string>("Mqtt:Topics:iSpindelGravity"),
                TopicISpindelGravity = configurationRoot.ValidateConfigString<string>("Mqtt:Topics:iSpindelTemperature"),
            };

            var mqttClientOpts = new MqttClientOptionsBuilder()
            .WithTcpServer(runnerOptions.MqttHost, runnerOptions.MqttPort) // Port is optional
            .WithCredentials(runnerOptions.MqttUsername, runnerOptions.MqttPassword)
            .Build();

            var serverOpts = new iSpindelServerOptions()
            {
                MqttClient = mqttDataClient,
                MqttClientOptions = mqttClientOpts,
                DbContext = () =>
                {
                    var options = new DbContextOptions<iSpindelContext>();
                //.UseNpgsql(configurationRoot.GetConnectionString("DefaultConnection"));
                //.ReplaceService<IHistoryRepository, ApplicationHistoryRepository>();
                return new iSpindelContext(options);
                },
                SensorTopics = new Dictionary<string, string>() {
                    { "battery" , runnerOptions.TopicISpindelBasePath + runnerOptions.TopicISpindelBattery },
                    { "temperature" , runnerOptions.TopicISpindelBasePath + runnerOptions.TopicISpindelTemperature },
                    { "gravity" , runnerOptions.TopicISpindelBasePath + runnerOptions.TopicISpindelGravity }
                }
            };

            var server = new iSpindelServer(serverOpts);

            var bridgeOpts = new ControlBridgeOptions()
            {
                MqttClient = mqttControlClient,
                MqttClientOptions = mqttClientOpts,
                SpindelService = server,
                TopicBasePath = runnerOptions.TopicControlBridgeBasePath,
                TopicRecordRequest = runnerOptions.TopicRecordRequest,
                TopicServerStatusRequest = runnerOptions.TopicServerStatusRequest
            };
            var mqttControlBridge = new ControlBridge(runnerOptions.TopicControlBridgeBasePath, server, mqttControlClient);
            await mqttControlClient.ConnectAsync(mqttClientOpts, CancellationToken.None);

            while (true)
            {
                Console.WriteLine(Console.ReadLine());
            }
        }
    }

    public class RunnerOptions
    {
        public string ConnectionString { get; set; }
        public string MqttHost { get; set; }
        public int MqttPort { get; set; }
        public string MqttUsername { get; set; }
        public string MqttPassword { get; set; }
        public string TopicRecordRequest { get; set; }
        public string TopicServerStatusRequest { get; set; }
        public string TopicControlBridgeBasePath { get; set; }
        public string TopicISpindelBasePath { get; set; }
        public string TopicISpindelTemperature { get; set; }
        public string TopicISpindelBattery { get; set; }
        public string TopicISpindelGravity { get; set; }

    }

    public class Runner
    {

        public Runner(RunnerOptions options)
        {

        }

        public async Task Run()
        {

        }
    }
}
