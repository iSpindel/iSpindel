using Microsoft.EntityFrameworkCore;
using Npgsql.EntityFrameworkCore.PostgreSQL;

namespace iSpindel.Database
{
	public class iSpindelContext : DbContext
	{

		protected iSpindelContext() : base() {
		}

		public iSpindelContext(DbContextOptions<iSpindelContext> options) : base(options) {
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
		}
	}
}