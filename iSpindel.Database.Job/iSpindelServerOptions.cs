using System;
using System.Threading.Tasks;
using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;

namespace iSpindel.Database.Job
{
    public class iSpindelServerOptions
    {
        public Func<Task<IManagedMqttClient>> MqttClientFactory { get; set; }
        public Func<iSpindelContext> DbContextFactory { get; set; }
        public string TopicBasePath { get; set; }
        public string TopicTemperature { get; set; }
        public string TopicBattery { get; set; }
        public string TopicGravity { get; set; }
    }
}
