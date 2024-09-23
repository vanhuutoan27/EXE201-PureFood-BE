using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Content;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class CategoryRepository : RepositoryBase<Category, Guid>, ICategoryRepository
    {
        public CategoryRepository(PureFoodDbContext context) : base(context)
        {
        }

        public async Task<Category> findById(Guid id)
        {
            return await _context.Categories.FindAsync(id);
        }

        public async Task<IEnumerable< Category>> getAll()
        {
            return await _context.Categories.ToListAsync(); 
        }
    }
}
