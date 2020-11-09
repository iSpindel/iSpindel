namespace iSpindel.App
{
    public class MqttConnectionSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string ClientId { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }

        public string TopicServerResponse { get; set; }
        public string TopicServerRequest { get; set; }
        public string TopicControlBridgeBasePath { get; set; }
    }
}