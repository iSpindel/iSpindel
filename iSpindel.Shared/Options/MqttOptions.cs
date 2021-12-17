namespace iSpindel.Shared.Options
{
    public class MqttOptions
    {
        public const string MqttPosition = "Mqtt";
        public string Host { get; set; }
        public int Port { get; set; } = 1883;
        public string Username { get; set; }
        public string Passwort { get; set; }
    }
    /*
                                        MqttHost = configurationRoot.GetSanitizedValue<string>("Mqtt:Host"),
                                        MqttPort = configurationRoot.GetSanitizedValue<int?>("Mqtt:Port", 1833).Value,
                                        MqttUsername = configurationRoot.GetSanitizedValue<string>("Mqtt:Credentials:Username"),
                                        MqttPassword = configurationRoot.GetSanitizedValue<string>("Mqtt:Credentials:Password"),
    */
}
