using System;
using System.Threading.Tasks;
using MQTTnet.Extensions.ManagedClient;

namespace iSpindel.Database.Job
{
    public class ControlBridgeOptions
    {
        public Func<Task<IManagedMqttClient>> MqttClientFactory { get; set; }
        public string TopicBasePath { get; set; }
        public ISpindelService SpindelService { get; set; }
        public string ServerResponse { get; set; }
        public string ServerRequest { get; set; }
    }
}