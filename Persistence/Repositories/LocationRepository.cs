using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class LocationRepository : IBaseRepository<Location>
    {
        private readonly DataContext _context;
        public LocationRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Location> Get(Guid id)
        {
            return await _context.Locations.FindAsync(id);
        }
        public async Task<List<Location>> GetAll()
        {
            return await _context.Locations.ToListAsync();
        }
        public async Task Create(Location location)
        {
            await _context.Locations.AddAsync(location);
            await _context.SaveChangesAsync();
        }
        
        public async Task Delete(Guid id)
        {
            var location = await _context.Locations.FindAsync(id);
            _context.Locations.Remove(location);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Location location)
        {
            _context.Locations.Update(location);
            await _context.SaveChangesAsync();
        }
    }
}