namespace iSpindel.App
{
    public class MqttConnectionSettings
    {
        public string Host { get; set; }
        public int Port { get; set; }
        public string ServerResponse { get; set; }
        public string ServerRequest { get; set; }
        public string iSpindelTopicBasePath { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
    }
}