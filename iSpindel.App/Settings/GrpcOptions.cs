namespace iSpindel.App.Settings
{
    public class GrpcOptions
    {
        public const string Position = "Grpc";
        public string Hostname { get; internal set; }
        public int Port { get; internal set; }
        public string Protocol { get; internal set; }
    }
}