namespace iSpindel.Server
{
    public class RunnerOptions
    {
        public string ConnectionString { get; set; }
        public string MqttHost { get; set; }
        public int MqttPort { get; set; }
        public string MqttUsername { get; set; }
        public string MqttPassword { get; set; }
        public string TopicServerRequest { get; set; }
        public string TopicServerResponse { get; set; }
        public string TopicControlBridgeBasePath { get; set; }
        public string TopicISpindelBasePath { get; set; }
        public string TopicISpindelTemperature { get; set; }
        public string TopicISpindelBattery { get; set; }
        public string TopicISpindelGravity { get; set; }

    }
}
