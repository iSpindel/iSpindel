using System;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Npgsql.EntityFrameworkCore.PostgreSQL.Migrations.Internal;

namespace iSpindel.Database
{
	public class iSpindelContext : DbContext
	{

		protected iSpindelContext() : base() {
			this.ChangeTracker.LazyLoadingEnabled = false;
		}

		public iSpindelContext(DbContextOptions<iSpindelContext> options) : base(options) {
			this.ChangeTracker.LazyLoadingEnabled = false;
		}

		public virtual DbSet<DataPoint> DataPoints { get; set; }
		public virtual DbSet<DataSeries> DataSeries { get; set; }

		// When Context gets used
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
			base.OnConfiguring(optionsBuilder);
			if (!optionsBuilder.IsConfigured) {
				optionsBuilder.UseNpgsql("Host=localhost;Database=iSpindel");
			}
		}

		// Initial Data
		protected override void OnModelCreating(ModelBuilder modelBuilder) {
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<DataSeries>(e => {
				e.HasData(new DataSeries() { Id = -1, Name = "Default Data Series", Description = "This is the default Data Series for iSpindel Projects." });
			});
			modelBuilder.Entity<DataPoint>(e => {
				e.HasData(new DataPoint[]{
					new DataPoint(){Id = 1, DataSeriesId = -1, Temperature = 24, Battery = 100, Gravity = 5, RecordTime = new DateTime(2020,05,01,23,00,00)},
					new DataPoint(){Id = 2, DataSeriesId = -1, Temperature = 25, Battery = 100, Gravity = 5, RecordTime = new DateTime(2020,05,01,23,05,00)},
					new DataPoint(){Id = 3, DataSeriesId = -1, Temperature = 25, Battery = 95, Gravity = 7, RecordTime = new DateTime(2020,05,01,23,10,00)},
					new DataPoint(){Id = 4, DataSeriesId = -1, Temperature = 26, Battery = 95, Gravity = 7, RecordTime = new DateTime(2020,05,01,23,15,00)},
					new DataPoint(){Id = 5, DataSeriesId = -1, Temperature = 26, Battery = 90, Gravity = 9, RecordTime = new DateTime(2020,05,01,23,20,00)},
					new DataPoint(){Id = 6, DataSeriesId = -1, Temperature = 26, Battery = 90, Gravity = 9, RecordTime = new DateTime(2020,05,01,23,25,00)},
					new DataPoint(){Id = 7, DataSeriesId = -1, Temperature = 23, Battery = 90, Gravity = 15, RecordTime = new DateTime(2020,05,01,23,30,00)},
					new DataPoint(){Id = 8, DataSeriesId = -1, Temperature = 22, Battery = 90, Gravity = 15, RecordTime = new DateTime(2020,05,01,23,35,00)},
					new DataPoint(){Id = 9, DataSeriesId = -1, Temperature = 21, Battery = 85, Gravity = 25, RecordTime = new DateTime(2020,05,01,23,40,00)},
					new DataPoint(){Id = 10, DataSeriesId = -1, Temperature = 24, Battery = 80, Gravity = 25, RecordTime = new DateTime(2020,05,01,23,45,00)},
				});
			});
		}
	}

	[System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "EF1001:Internal EF Core API usage.", Justification = "Multiple contexts")]
	public class iSpindelHistoryRepository : NpgsqlHistoryRepository
	{
		public iSpindelHistoryRepository(HistoryRepositoryDependencies dependencies)
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