using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
    
        public DbSet<Climb> Climbs {get; set;}
        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Climb>()
                .Property(b => b.Rating)
                .HasColumnType("DECIMAL(2,1)");

            base.OnModelCreating(modelBuilder);
        }

        
    }
}