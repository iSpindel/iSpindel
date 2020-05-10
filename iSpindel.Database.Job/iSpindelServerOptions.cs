using System;
using System.Threading.Tasks;
using MQTTnet.Client;

namespace iSpindel.Database.Job
{
    public class iSpindelServerOptions
    {
        public Func<Task<IMqttClient>> MqttClientFactory { get; set; }
        public Func<iSpindelContext> DbContext { get; set; }
        public string TopicBasePath { get; set; }
        public string TopicTemperature { get; set; }
        public string TopicBattery { get; set; }
        public string TopicGravity { get; set; }
    }
}
