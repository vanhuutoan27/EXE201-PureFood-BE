using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Content;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureFood.Data.Repositories
{
    public class PromotionRepository : RepositoryBase<Promotion, Guid>, IPromotionRepository
    {
        public PromotionRepository(PureFoodDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Promotion>> GetAllSupplierAsync(int page, int limit)
        {
            IQueryable<Promotion> query = _context.Promotions.AsQueryable();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            query = _context.Promotions;
            return await query.ToListAsync();
        }
    }
}
