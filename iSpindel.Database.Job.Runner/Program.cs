using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace iSpindel.Database.Job.Runner
{

    internal class Program
    {

        static async Task Main(string[] args)
        {

            var configurationRoot = new ConfigurationBuilder()
                    .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                    .AddJsonFile("appsettings.json", false, false)
                    .AddJsonFile("appsettings.Production.json", true, false)
                    .Build();

            var runnerOptions = new RunnerOptions()
            {
                ConnectionString = configurationRoot.GetConnectionString("DefaultConnection"),
                MqttHost = configurationRoot.GetSanitizedValue<string>("Mqtt:Host"),
                MqttPort = configurationRoot.GetSanitizedValue<int?>("Mqtt:Port", 1833).Value,
                MqttUsername = configurationRoot.GetSanitizedValue<string>("Mqtt:Credentials:Username"),
                MqttPassword = configurationRoot.GetSanitizedValue<string>("Mqtt:Credentials:Password"),

                TopicControlBridgeBasePath = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:ControlBridgeTopicBasePath", "spindelControl/").AppendTerminatorChar(),
                TopicISpindelBasePath = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelTopicBasePath").AppendTerminatorChar(),
                TopicRecordRequest = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:RecordRequest", "RecordRequest"),
                TopicServerStatusRequest = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:ServerStatusRequest", "ServerStatusRequest"),
                TopicISpindelTemperature = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelBattery"),
                TopicISpindelBattery = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelGravity"),
                TopicISpindelGravity = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelTemperature"),
            };

            var runner = new Runner(runnerOptions);

            await runner.Run();

        }
    }
}