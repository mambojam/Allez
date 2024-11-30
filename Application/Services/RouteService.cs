using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Persistence;

namespace Application.Services
{
    public class RouteService : IBaseService<Route>
    {
        private readonly IBaseRepository<Route> _routeRepository;
        public RouteService(IBaseRepository<Route> repo)
        {
            _routeRepository = repo;
        }

        public async Task<List<Route>> GetAllAsync()
        {
            return await _routeRepository.GetAll();
        }

        public async Task<Route> GetAsync(Guid id)
        {
            return await _routeRepository.Get(id);
        }
        public async Task CreateAsync(Route route)
        {
            await _routeRepository.Create(route);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _routeRepository.Delete(id);
        }

        public async Task EditAsync(Guid id, Route route)
        {
            try {
                var b = await _routeRepository.Get(id);
                await _routeRepository.Edit(route);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        
    }
}