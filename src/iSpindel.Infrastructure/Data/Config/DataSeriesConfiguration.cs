using iSpindel.Core.BrewBatchAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iSpindel.Infrastructure.Data.Config;
public class DataSeriesConfiguration : IEntityTypeConfiguration<DataSeries>
{
  public void Configure(EntityTypeBuilder<DataSeries> builder)
  {
    builder.HasMany(p => p.DataPoints);
    builder.HasOne(p => p.iSpindelInUse);
  }
}
