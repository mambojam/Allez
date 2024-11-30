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
    }
}