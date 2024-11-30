using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class RouteRepository : IBaseRepository<Route>
    {
        private readonly DataContext _context;
        public RouteRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Route> Get(Guid id)
        {
            return await _context.Routes.FindAsync(id);
        }
        public async Task<List<Route>> GetAll()
        {
            return await _context.Routes.ToListAsync();
        }
        public async Task Create(Route route)
        {
            await _context.Routes.AddAsync(route);
            await _context.SaveChangesAsync();
        }
        public async Task Edit(Route route)
        {
            _context.Routes.Update(route);
            await _context.SaveChangesAsync();
        }
        public async Task Delete(Guid id)
        {
            var route = await _context.Routes.FindAsync(id);
            _context.Routes.Remove(route);
            await _context.SaveChangesAsync();
        }

       
    }
}