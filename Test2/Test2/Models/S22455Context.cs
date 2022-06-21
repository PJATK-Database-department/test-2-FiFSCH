using Microsoft.EntityFrameworkCore;

namespace Test2.Models
{
    public class S22455Context : DbContext
    {
        protected S22455Context()
        {
        }

        public S22455Context(DbContextOptions options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<ServiceTypeDictInspection>().HasKey(key=> new { key.IdServiceType, key.IdInspection});
        }
        public DbSet<Car> Car { get; set; }
        public DbSet<Mechanic> Mechanic { get; set; }
        public DbSet<Inspection> Inspection { get; set; }
        public DbSet<ServiceTypeDict> ServiceTypeDict { get; set; }
        public DbSet<ServiceTypeDictInspection> ServiceTypeDictInspection { get; set; }
    }
}
