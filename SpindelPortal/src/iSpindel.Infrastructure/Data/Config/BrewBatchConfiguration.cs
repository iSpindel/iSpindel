using iSpindel.Core.BrewBatchAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iSpindel.Infrastructure.Data.Config;
public class BrewBatchConfiguration : IEntityTypeConfiguration<BrewBatch>
{
  public void Configure(EntityTypeBuilder<BrewBatch> builder)
  {
    builder.Property(p => p.Name)
      .HasMaxLength(100)
      .IsRequired();
    builder.OwnsOne(p => p.RezeptSchritt);
    builder.OwnsOne(p => p.NachBrauenSchritt);
    builder.OwnsOne(p => p.NachAbfuellSchritt);
    builder.OwnsOne(p => p.NachGaerungSchritt);

    builder.Property(p => p.DataSeries).IsRequired();
    builder.HasOne(p => p.DataSeries);
  }
}
