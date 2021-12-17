namespace iSpindel.Shared.Options
{
    public class DbOptions
    {
        public const string DbPosition = "Db:ConnectionStrings:DefaultConnection";
        public string ConnectionString { get; set; }
    }
}
