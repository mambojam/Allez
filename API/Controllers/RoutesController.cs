
using Application.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  
    public class RoutesController : BaseApiController
    {
        private readonly IBaseService<Domain.Route> _routeService;

        public RoutesController(IBaseService<Domain.Route> routeService)
        {
            _routeService = routeService;
        }
    

        [HttpGet("{id}")]
        public async Task<Domain.Route> Get(Guid id)
        {
            return await _routeService.GetAsync(id);
        }
        [HttpGet]
        public async Task<List<Domain.Route>> GetAll(Guid id)
        {
            return await _routeService.GetAllAsync();
        }
        [HttpPost]
        public async Task Create(Domain.Route route)
        {
            await _routeService.CreateAsync(route);
        }
        [HttpPut("{id}")]
        public async Task Edit(Guid id, Domain.Route route)
        {
            await _routeService.EditAsync(id, route);
        }
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _routeService.DeleteAsync(id);
        }
        
    }
}

    