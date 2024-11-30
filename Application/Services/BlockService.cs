using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain;
using Persistence;

namespace Application.Services
{
    public class BlockService : IBaseService<Block>
    {
        private readonly IBaseRepository<Block> _blockRepository;
        public BlockService(IBaseRepository<Block> repo)
        {
            _blockRepository = repo;
        }

        public async Task<List<Block>> GetAllAsync()
        {
            return await _blockRepository.GetAll();
        }

        public async Task<Block> GetAsync(Guid id)
        {
            return await _blockRepository.Get(id);
        }
        public async Task CreateAsync(Block block)
        {
            await _blockRepository.Create(block);
        }

        public async Task DeleteAsync(Guid id)
        {
            await _blockRepository.Delete(id);
        }

        public async Task EditAsync(Guid id, Block block)
        {
            try {
                var b = await _blockRepository.Get(id);
                await _blockRepository.Edit(block);
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        
    }
}