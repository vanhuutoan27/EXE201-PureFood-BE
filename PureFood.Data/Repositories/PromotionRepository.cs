using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Content;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class PromotionRepository : RepositoryBase<Promotion, Guid>, IPromotionRepository
    {
        public PromotionRepository(PureFoodDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Promotion>> GetAllPromotionAsync(int page, int limit)
        {
            IQueryable<Promotion> query = _context.Promotions.AsQueryable();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1)).Take(limit);
            }
            return await query.ToListAsync();
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

        public IEnumerable<Promotion> GetExpiredPromotions()
        {
            return _context.Promotions.Where(p => p.Status == true && p.EndDate < DateTime.Now).ToList();
        }

        public async Task<Promotion> GetPromotionByDiscountCode(string discountCode)
        {
            return await _context.Promotions
                .Where(p => p.DiscountCode.ToLower() == discountCode.ToLower().Trim() && p.Status == true && p.EndDate > DateTime.Now).FirstOrDefaultAsync();
        }
    }
}
