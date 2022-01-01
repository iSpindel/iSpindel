using iSpindel.Database;
using iSpindel.Shared.Options;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Npgsql;

namespace iSpindel.Shared.Factories
{
    /*public class DbContextFactory : IDbContextFactory
    {
        private readonly IOptions<DbOptions> _dbOptions;

        public DbContextFactory(IOptions<DbOptions> dbOptions)
        {
            this._dbOptions = dbOptions;
        }

        public iSpindelContext CreateContext()
        {
            var connectionStringBuilder = new NpgsqlConnectionStringBuilder(_dbOptions.Value.DefaultConnection
                )
            {
                ApplicationName = "iSpindel.Database.Job.Runner"
            };
            var connString = connectionStringBuilder.ConnectionString;
            var optionsBuilder = new DbContextOptionsBuilder<iSpindelContext>()
            .UseNpgsql(connString);
            return new iSpindelContext(optionsBuilder.Options);
        }
    }*/
}
