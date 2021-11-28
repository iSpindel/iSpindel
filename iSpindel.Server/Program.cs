using iSpindel.Server.Services;
using Npgsql;

namespace iSpindel.Server
{
    public static class Program
    {

        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Additional configuration is required to successfully run gRPC on macOS.
            // For instructions on how to configure Kestrel and gRPC clients on macOS, visit https://go.microsoft.com/fwlink/?linkid=2099682

            // Add services to the container.
            builder.Services.AddGrpc();
            var configurationRoot = builder.Configuration;

            var runnerOptions = new RunnerOptions()
            {
                MqttHost = configurationRoot.GetSanitizedValue<string>("Mqtt:Host"),
                MqttPort = configurationRoot.GetSanitizedValue<int?>("Mqtt:Port", 1833).Value,
                MqttUsername = configurationRoot.GetSanitizedValue<string>("Mqtt:Credentials:Username"),
                MqttPassword = configurationRoot.GetSanitizedValue<string>("Mqtt:Credentials:Password"),

                TopicControlBridgeBasePath = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:ControlBridgeTopicBasePath", "spindelControl/").AppendTerminatorChar(),
                TopicISpindelBasePath = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelTopicBasePath").AppendTerminatorChar(),
                TopicServerRequest = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:ServerRequest", "Request"),
                TopicServerResponse = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:ServerResponse", "Response"),
                TopicISpindelTemperature = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelTemperature"),
                TopicISpindelBattery = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelBattery"),
                TopicISpindelGravity = configurationRoot.GetSanitizedValue<string>("Mqtt:Topics:iSpindelGravity"),
            };

            var connectionStringBuilder = new NpgsqlConnectionStringBuilder(configurationRoot.GetConnectionString("DefaultConnection"))
            {
                ApplicationName = "iSpindel.Database.Job.Runner"
            };
            if (!string.IsNullOrWhiteSpace(configurationRoot["Database:Username"]) && !string.IsNullOrWhiteSpace(configurationRoot["Database:Password"]))
            {
                connectionStringBuilder.Username = configurationRoot["Database:Username"];
                connectionStringBuilder.Password = configurationRoot["Database:Password"];
                connectionStringBuilder.IntegratedSecurity = false;
            }
            runnerOptions.ConnectionString = connectionStringBuilder.ConnectionString;
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            app.MapGrpcService<RecordingService>();
            app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

            app.Run();

        }
    }
}