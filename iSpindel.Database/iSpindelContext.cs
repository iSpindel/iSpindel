using Microsoft.EntityFrameworkCore;

namespace iSpindel.Database {
    public class iSpindelContext : DbContext
    {
        public virtual DbSet<DataPoint> DataPoints { get; set; }
        public virtual DbSet<DataSeries> DataSeries { get; set; }

        // When Context gets used
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            base.OnConfiguring(optionsBuilder);
        }

        // Initial Data
        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);
        }
    }
}