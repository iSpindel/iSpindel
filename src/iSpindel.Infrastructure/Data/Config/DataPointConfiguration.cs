using iSpindel.Core.BrewBatchAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iSpindel.Infrastructure.Data.Config;
public class DataPointConfiguration : IEntityTypeConfiguration<DataPoint>
{
  public void Configure(EntityTypeBuilder<DataPoint> builder)
  {
    builder.HasOne(p => p.DataSeries);
  }
}
