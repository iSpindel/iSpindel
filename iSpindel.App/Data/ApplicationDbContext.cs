using iSpindel.App.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Npgsql.EntityFrameworkCore.PostgreSQL.Migrations.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage;
using System.Text;

namespace iSpindel.App.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions<ApplicationDbContext> options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder builder) {
            base.OnModelCreating(builder);
            
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "EF1001:Internal EF Core API usage.", Justification = "Multiple contexts")]
    public class ApplicationHistoryRepository : NpgsqlHistoryRepository
    {
        public ApplicationHistoryRepository(HistoryRepositoryDependencies dependencies)
        : base(dependencies) {
        }

        protected override void ConfigureTable(EntityTypeBuilder<HistoryRow> history) {
            base.ConfigureTable(history);
            history.Property<string>("ContextKey").HasMaxLength(50);
            history.Property<DateTime>("Applied");
        }

        public override string GetInsertScript(HistoryRow row) {
            var stringTypeMapping = Dependencies.TypeMappingSource.GetMapping(typeof(string));
            var datetimeTypeMapping = Dependencies.TypeMappingSource.GetMapping(typeof(DateTime));

            return new StringBuilder().Append("INSERT INTO ")
                .Append(SqlGenerationHelper.DelimitIdentifier(TableName, TableSchema))
                .Append(" (")
                .Append(SqlGenerationHelper.DelimitIdentifier(MigrationIdColumnName))
                .Append(", ")
                .Append(SqlGenerationHelper.DelimitIdentifier(ProductVersionColumnName))
                .Append(", ")
                .Append(SqlGenerationHelper.DelimitIdentifier("ContextKey"))
                .Append(", ")
                .Append(SqlGenerationHelper.DelimitIdentifier("Applied"))
                .AppendLine(")")
                .Append("VALUES (")
                .Append(stringTypeMapping.GenerateSqlLiteral(row.MigrationId))
                .Append(", ")
                .Append(stringTypeMapping.GenerateSqlLiteral(row.ProductVersion))
                .Append(", ")
                .Append(stringTypeMapping.GenerateSqlLiteral("iSpindelContext"))
                .Append(", ")
                .Append(datetimeTypeMapping.GenerateSqlLiteral(DateTime.Now))
                .Append(")")
                .AppendLine(SqlGenerationHelper.StatementTerminator)
                .ToString();
        }
    }
}
