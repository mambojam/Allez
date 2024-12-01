using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {
        }
    
        public DbSet<Block> Blocks { get; set; }
        public DbSet<Route> Routes { get; set; }

        public DbSet<Location> Locations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Location>()
                .HasMany(l => l.Blocks)
                .WithOne(l => l.Location)
                .HasForeignKey(l => l.LocationId)
                .IsRequired();

            modelBuilder.Entity<Location>()
                .HasMany(l => l.Routes)
                .WithOne(l => l.Location)
                .HasForeignKey(l => l.LocationId)
                .IsRequired();

            modelBuilder.Entity<Block>()
                .Property(b => b.Rating)
                .HasColumnType("DECIMAL(3,1)");
            
            modelBuilder.Entity<Route>()
                .Property(b => b.Rating)
                .HasColumnType("DECIMAL(3,1)");

            base.OnModelCreating(modelBuilder);
        }

        
    }
}