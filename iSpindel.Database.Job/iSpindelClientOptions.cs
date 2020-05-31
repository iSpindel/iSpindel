
using System;
using System.Threading.Tasks;
using MQTTnet.Extensions.ManagedClient;

namespace iSpindel.Database.Job
{
    public class iSpindelClientOptions
    {
        public Func<Task<IManagedMqttClient>> MqttClientFactory { get; set; }
        public string TopicBasePath { get; set; }
        public string TopicServerResponse { get; set; }
        public string TopicServerRequest { get; set; }

    }
}