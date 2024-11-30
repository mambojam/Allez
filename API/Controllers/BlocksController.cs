
using Application.Services;
using Domain;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  
    public class BlocksController : BaseApiController
    {
        private readonly BlockService _blockService;

        public BlocksController(BlockService service)
        {
            _blockService = service;
        }

        [HttpGet("{id}")]
        public async Task<Block> Get(Guid id)
        {
            return await _blockService.GetAsync(id);
        }
        [HttpGet]
        public async Task<List<Block>> GetAll(Guid id)
        {
            return await _blockService.GetAllAsync();
        }
        [HttpPost]
        public async Task Create(Block block)
        {
            await _blockService.CreateAsync(block);
        }
        [HttpPut("{id}")]
        public async Task Edit(Guid id, Block block)
        {
            await _blockService.EditAsync(id, block);
        }
        [HttpDelete("{id}")]
        public async Task Delete(Guid id)
        {
            await _blockService.DeleteAsync(id);
        }
        
    }
}