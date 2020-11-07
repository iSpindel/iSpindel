using System;
using System.Linq;
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

        public iSpindelContext() : base()
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public iSpindelContext(DbContextOptions<iSpindelContext> options) : base(options)
        {
            this.ChangeTracker.LazyLoadingEnabled = false;
        }

        public virtual DbSet<DataPoint> DataPoints { get; set; }
        public virtual DbSet<DataSeries> DataSeries { get; set; }
        public virtual DbSet<BeerCharacteristics> BeerCharacteristics { get; set; }

        // When Context gets used
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Database=iSpindel");
            }
        }

        // Initial Data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<DataSeries>(e =>
            {
                var currentTime = new DateTime(2020,05,01,23,50,00);

                e.HasData(new DataSeries() { Id = -1, Name = "Default Data Series", Description = "This is the default Data Series for iSpindel Projects.", Start = new DateTime(2020, 5, 1, 23, 0, 0, 0)});
                e.HasData(new DataSeries() { Id = 1, Name = "Test Series 1", Description = "This is the first test dataset", Start = new DateTime(2020,05,01,23,00,00), End = new DateTime(2020,05,01,23,45,00)});
                e.HasData(new DataSeries() { Id = 2, Name = "Test Series 2", Description = "This is the second test dataset", Start = currentTime, End = currentTime.AddMinutes( 20 * 20.0)  });
                e.HasData(new DataSeries() { Id = 3, Name = "Test Series 3", Description = "This is the third test dataset", Start = currentTime });
            });
            modelBuilder.Entity<DataPoint>(e =>
            {
                int dataPointIndex = 1;
                e.HasData(new DataPoint[]{
                    new DataPoint(){Id = dataPointIndex++, DataSeriesId = 1, Temperature = 24, Battery = 100, Gravity =  5, RecordTime = new DateTime(2020,05,01,23,00,00)},
                    new DataPoint(){Id = dataPointIndex++, DataSeriesId = 1, Temperature = 25, Battery = 100, Gravity =  5, RecordTime = new DateTime(2020,05,01,23,05,00)},
                    new DataPoint(){Id = dataPointIndex++, DataSeriesId = 1, Temperature = 25, Battery =  95, Gravity =  7, RecordTime = new DateTime(2020,05,01,23,10,00)},
                    new DataPoint(){Id = dataPointIndex++, DataSeriesId = 1, Temperature = 26, Battery =  95, Gravity =  7, RecordTime = new DateTime(2020,05,01,23,15,00)},
                    new DataPoint(){Id = dataPointIndex++, DataSeriesId = 1, Temperature = 26, Battery =  90, Gravity =  9, RecordTime = new DateTime(2020,05,01,23,20,00)},
                    new DataPoint(){Id = dataPointIndex++, DataSeriesId = 1, Temperature = 26, Battery =  90, Gravity =  9, RecordTime = new DateTime(2020,05,01,23,25,00)},
                    new DataPoint(){Id = dataPointIndex++, DataSeriesId = 1, Temperature = 23, Battery =  90, Gravity = 15, RecordTime = new DateTime(2020,05,01,23,30,00)},
                    new DataPoint(){Id = dataPointIndex++, DataSeriesId = 1, Temperature = 22, Battery =  90, Gravity = 15, RecordTime = new DateTime(2020,05,01,23,35,00)},
                    new DataPoint(){Id = dataPointIndex++, DataSeriesId = 1, Temperature = 21, Battery =  85, Gravity = 25, RecordTime = new DateTime(2020,05,01,23,40,00)},
                    new DataPoint(){Id = dataPointIndex++, DataSeriesId = 1, Temperature = 24, Battery =  80, Gravity = 25, RecordTime = new DateTime(2020,05,01,23,45,00)},
                });
                e.HasData(Enumerable.Range(0,  20).Select(i => generator(ref dataPointIndex, i,  20, 2)));
                e.HasData(Enumerable.Range(0, 800).Select(i => generator(ref dataPointIndex, i, 800, 3)));
            });
        }

        private DataPoint generator(ref int dataPointIndex, int index, int max, int seriesId)
        {
            var currentTime = new DateTime(2020,05,01,23,50,00);
            var tRatio = (double)index / (double)max;
            return new DataPoint()
            {
                Id = dataPointIndex++,
                DataSeriesId = seriesId,
                Battery = 4.2 - 1.0 * tRatio,
                Gravity = 10.0 * tRatio,
                Temperature = 20.0 + Math.Sin(Math.PI * 2.0 * tRatio) * 5.0,
                RecordTime = currentTime.AddMinutes(dataPointIndex * 20.0)
            };
        }
    }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Usage", "EF1001:Internal EF Core API usage.", Justification = "Multiple contexts")]
    public class iSpindelHistoryRepository : NpgsqlHistoryRepository
    {
        public iSpindelHistoryRepository(HistoryRepositoryDependencies dependencies)
        : base(dependencies)
        {
        }

        protected override void ConfigureTable(EntityTypeBuilder<HistoryRow> history)
        {
            base.ConfigureTable(history);
            history.Property<string>("ContextKey").HasMaxLength(50);
            history.Property<DateTime>("Applied");
        }

        public override string GetInsertScript(HistoryRow row)
        {
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