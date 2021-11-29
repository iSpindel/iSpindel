using FluentValidation;
namespace iSpindel.Server
{
    public class RunnerOptions
    {
        public const string RunnerOpts = "RunnerOpts";
        public string ConnectionString { get; set; }
        public string MqttHost { get; set; }
        public int MqttPort { get; set; } = 1883;
        public string MqttUsername { get; set; }
        public string MqttPassword { get; set; }
        public string TopicServerRequest { get; set; } = "Request";
        public string TopicServerResponse { get; set; } = "Response";
        public string TopicControlBridgeBasePath { get; set; } = "spindelControl/";
        public string TopicISpindelBasePath { get; set; }
        public string TopicISpindelTemperature { get; set; }
        public string TopicISpindelBattery { get; set; }
        public string TopicISpindelGravity { get; set; }

    }

    public class RunnerOptionsValidator : AbstractValidator<RunnerOptions>
    {
        public RunnerOptionsValidator()
        {
            RuleFor(x => x.MqttHost).NotEmpty();
            RuleFor(x => x.TopicControlBridgeBasePath).NotEmpty();
            RuleFor(x => x.TopicISpindelBasePath).NotEmpty();
        }
    }

}
