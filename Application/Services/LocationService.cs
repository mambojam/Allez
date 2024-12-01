using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Persistence;

namespace Application.Services
{
    public class LocationService : IBaseService<Location>
    {
        private readonly IBaseRepository<Location> _locationRepository;
        public LocationService(IBaseRepository<Location> repo)
        {
            _locationRepository = repo;
        }

        public async Task<List<Location>> GetAllAsync()
        {
            return await _locationRepository.GetAll();
        }

        public async Task<Location> GetAsync(Guid id)
        {
            return await _locationRepository.Get(id);
        }
        public async Task CreateAsync(Location location)
        {
            await _locationRepository.Create(location);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _locationRepository.Delete(id);
        }

        public async Task EditAsync(Guid id, Location location)
        {
            try {
                var b = await _locationRepository.Get(id);
                await _locationRepository.Edit(location);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        
    }
}