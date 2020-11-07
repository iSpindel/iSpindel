namespace iSpindel.App.Settings
{
    public static class AppSettingsProvider
    {
        public static MQTTHostSettings MQTTHostSettings;
        public static ClientSettings ClientSettings;
    }

    public class MQTTHostSettings
    {
        public string Host { set; get; }
        public int Port { set; get; }
    }

     public class ClientSettings
    {
        public string Id { set; get; }
        public string UserName { set; get; }
        public string Password { set; get; }
    }
}