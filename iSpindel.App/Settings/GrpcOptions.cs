namespace iSpindel.App.Settings
{
    public class GrpcOptions
    {
        public const string Position = "Grpc";
        public string Host { get; set; }
        public int Port { get; set; }
        public string Protocol { get; set; }
    }
}