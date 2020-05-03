using System;
using System.Threading;
using System.Threading.Tasks;
using MQTTnet;
using MQTTnet.Client.Options;

namespace iSpindel.Database.Job.Runner
{
    class Program
    {
        static async Task Main(string[] args)
        {

            var factory = new MqttFactory();
            var mqttControlClient = factory.CreateMqttClient();
            var mqttDataClient = factory.CreateMqttClient();

            var mqttClientOpts = new MqttClientOptionsBuilder()
            .WithTcpServer("broker.hivemq.com", 1883) // Port is optional
            .Build();


            var server = new iSpindelServer(mqttDataClient, mqttClientOpts);
            var mqttControlBridge = new ControlBridge(server, mqttControlClient);
            await mqttControlClient.ConnectAsync(mqttClientOpts, CancellationToken.None);

            while (true)
            {
                Console.WriteLine(Console.ReadLine());
            }
        }
    }
}
