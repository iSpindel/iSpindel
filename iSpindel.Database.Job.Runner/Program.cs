using System;
using System.Linq;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Npgsql;

namespace iSpindel.Database.Job.Runner
{

    internal class Program
    {

        static async Task Main(string[] args)
        {

            var configurationRoot = new ConfigurationBuilder()
                    .SetBasePath(Path.Combine(Directory.GetCurrentDirectory()))
                    .AddJsonFile("appsettings.json", false, false)
                    .AddJsonFile("appsettings.Development.json", true, false)
                    .AddJsonFile("appsettings.Production.json", true, false)
                    .Build();

            var runnerOptions = new RunnerOptions()
            {
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

            var connectionStringBuilder = new NpgsqlConnectionStringBuilder(configurationRoot.GetConnectionString("DefaultConnection"))
            {
                ApplicationName = "iSpindel.Database.Job.Runner"
            };
            if (!string.IsNullOrWhiteSpace(configurationRoot["Database:Username"]) && !string.IsNullOrWhiteSpace(configurationRoot["Database:Password"]))
            {
                connectionStringBuilder.Username = configurationRoot["Database:Username"];
                connectionStringBuilder.Password = configurationRoot["Database:Password"];
                connectionStringBuilder.IntegratedSecurity = false;
            }
            runnerOptions.ConnectionString = connectionStringBuilder.ConnectionString;

            var runner = new Runner(runnerOptions);

            await runner.Run();
            Console.WriteLine("Started cli runner in version 0.2.0");
            Console.WriteLine($"DB-Connection:{runnerOptions.ConnectionString}");
            Console.WriteLine($"MQTT-Host:{runnerOptions.MqttHost}:{runnerOptions.MqttPort}");
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
                else if (input.StartsWith("id"))
                {
                    var id = await runner.Server.GetRecordingIdAsync();
                    Console.WriteLine($"Server recording id is {id}");
                }
            }
        }
    }
}