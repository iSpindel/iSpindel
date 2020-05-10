using System;
using System.Linq;
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
                TopicISpindelTemperature = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelTemperature"),
                TopicISpindelBattery = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelBattery"),
                TopicISpindelGravity = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelGravity"),
            };

            var runner = new Runner(runnerOptions);

            await runner.Run();
            Console.WriteLine("Started cli runner");
            while (true)
            {
                var input = Console.ReadLine();
                if (input.StartsWith("start"))
                {
                    var idStr = input.Split(' ').Skip(1).FirstOrDefault();
                    var id = -1;
                    if (Int32.TryParse(idStr, out var readId))
                    {
                        id = readId;
                    }
                    Console.WriteLine($"Starting recording with id {id}");
                    await runner.Server.StartAsync(id);
                    Console.WriteLine($"Started recording with id {id}");
                }
                else if (input.StartsWith("stop"))
                {
                    var currentId = (runner.Server as iSpindelServer).CurrentId?.ToString() ?? "none";
                    Console.WriteLine($"Stopping recording {currentId}");
                    await runner.Server.StopAsync();
                    Console.WriteLine("Stopped recording");
                }
                else if (input.StartsWith("status"))
                {
                    var status = await runner.Server.GetStatusAsync();
                    Console.WriteLine($"Server status is {status}");
                }
            }
        }
    }
}