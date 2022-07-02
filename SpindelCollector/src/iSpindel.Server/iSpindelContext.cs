using iSpindel.Core.BrewBatchAggregate;
using iSpindel.Server.Aggregates;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Npgsql.EntityFrameworkCore.PostgreSQL.Migrations.Internal;
using System;
using System.Linq;
using System.Text;

namespace iSpindel.Database;

public class iSpindelContext : DbContext
{

  public iSpindelContext() : base()
  {
    ChangeTracker.LazyLoadingEnabled = false;
  }

  public iSpindelContext(DbContextOptions<iSpindelContext> options) : base(options)
  {
    ChangeTracker.LazyLoadingEnabled = false;
  }

  public DbSet<DataPoint> DataPoints => Set<DataPoint>();
  public DbSet<DataSeries> DataSeries => Set<DataSeries>();
  public DbSet<SpindelDevice> SpindelDevices => Set<SpindelDevice>();

  protected override void OnModelCreating(ModelBuilder modelBuilder)
  {
    base.OnModelCreating(modelBuilder);
    modelBuilder.Entity<DataSeries>()
      .HasMany(p => p.DataPoints).WithOne(p => p.DataSeries);
    modelBuilder.Entity<DataSeries>()
      .HasOne(p => p.iSpindelInUse);
  }

  // When Context gets used
  protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
  {
    base.OnConfiguring(optionsBuilder);
    if (!optionsBuilder.IsConfigured)
    {
      optionsBuilder.UseNpgsql("Host=localhost;Database=iSpindel");
    }
  }
}
