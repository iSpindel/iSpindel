namespace iSpindel.Shared.Options
{
    public class SpindelServerOptions
    {
        public const string SpindelServerPosition = "SpindelServer";
        public string TopicBasePath { get; set; }
        public string TopicTemperature { get; set; }
        public string TopicBattery { get; set; }
        public string TopicGravity { get; set; }
    }
    /*
                                        TopicISpindelBasePath = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelTopicBasePath").AppendTerminatorChar(),
                                        TopicISpindelTemperature = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelTemperature"),
                                        TopicISpindelBattery = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelBattery"),
                                        TopicISpindelGravity = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelGravity"),
    */
}
