using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Content;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class SupplierRepository : RepositoryBase<Supplier, Guid>, ISupplierRepository
    {
        public SupplierRepository(PureFoodDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Supplier>> GetAllSupplierAsync(int page, int limit)
        {
            IQueryable<Supplier> query = _context.Suppliers.AsQueryable();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            query = _context.Suppliers;
            return await query.ToListAsync();
        }

        public async Task<Supplier> GetSupplierByName(string name)
        {
            return await _context.Suppliers.FirstOrDefaultAsync(s => s.SupplierName.ToLower() == name);
        }
    }
}
