using System;
using System.Threading.Tasks;
using MQTTnet.Client;

namespace iSpindel.Database.Job
{
    public class ControlBridgeOptions
    {
        public Func<Task<IMqttClient>> MqttClientFactory { get; set; }
        public string TopicBasePath { get; set; }
        public ISpindelService SpindelService { get; set; }
        public string TopicRecordRequest { get; set; }
        public string TopicServerStatusRequest { get; set; }
    }
}