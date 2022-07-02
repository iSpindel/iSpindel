using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iSpindel.Core.BrewBatchAggregate;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace iSpindel.Infrastructure.Data.Config;
internal class BrewBatchConfiguration : IEntityTypeConfiguration<BrewBatch>
{
  public void Configure(EntityTypeBuilder<BrewBatch> builder)
  {
    builder.OwnsOne(p => p.RezeptSchritt);
    builder.OwnsOne(p => p.NachBrauenSchritt);
    builder.OwnsOne(p => p.NachAbfuellSchritt);
    builder.OwnsOne(p => p.NachGaerungSchritt);
  }
}
