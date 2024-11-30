using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence.Repositories
{
    public class BlockRepository : IBaseRepository<Block>
    {
        private readonly DataContext _context;
        public BlockRepository(DataContext context)
        {
            _context = context;
        }
        public async Task<Block> Get(Guid id)
        {
            return await _context.Blocks.FindAsync(id);
        }
        public async Task<List<Block>> GetAll()
        {
            return await _context.Blocks.ToListAsync();
        }
        public async Task Create(Block block)
        {
            await _context.Blocks.AddAsync(block);
            await _context.SaveChangesAsync();
        }
        
        public async Task Delete(Guid id)
        {
            var block = await _context.Blocks.FindAsync(id);
            _context.Blocks.Remove(block);
            await _context.SaveChangesAsync();
        }

        public async Task Edit(Block block)
        {
            _context.Blocks.Update(block);
            await _context.SaveChangesAsync();
        }
    }
}