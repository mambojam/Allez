using Application.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class LocationsController : BaseApiController
    {
       
        private readonly IBaseService<Location> _locationService;
        public LocationsController(IBaseService<Location> locationService)
        {
            _locationService = locationService;
        }
            [HttpGet("{id}")]
            public async Task<Location> Get(Guid id)
            {
                return await _locationService.GetAsync(id);
            }
            [HttpGet]
            public async Task<List<Location>> GetAll(Guid id)
            {
                return await _locationService.GetAllAsync();
            }
            [HttpPost]
            public async Task Create(Location location)
            {
                await _locationService.CreateAsync(location);
            }
            [HttpPut("{id}")]
            public async Task Edit(Guid id, Location location)
            {
                await _locationService.EditAsync(id, location);
            }
            [HttpDelete("{id}")]
            public async Task Delete(Guid id)
            {
                await _locationService.DeleteAsync(id);
            }
            
        }
    }

        
        