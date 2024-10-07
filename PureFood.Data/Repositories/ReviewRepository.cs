using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Content;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class ReviewRepository : RepositoryBase<Review, Guid>, IReviewRepository
    {
        public ReviewRepository(PureFoodDbContext context) : base(context)
        {
        }

        public async Task<int> CountUserReviewsForProduct(Guid userId, Guid productId)
        {
            return await _context.Reviews.Where( x => x.UserId == userId &&  x.ProductId == productId ).CountAsync();
        }

        public async Task<IEnumerable<Review>> GetAllReviewAsync(int page, int limit)
        {
            IQueryable<Review> query = _context.Reviews.Include(r => r.User).AsQueryable();

            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }
            return await query.ToListAsync();

        }

        public async Task<IEnumerable<Review>> GetReviewByProductId(Guid productId)
        {
            var reviewRepository = await _context.Reviews.Include(r => r.User).AsQueryable().Include(p => p.Product).Where(p => p.ProductId == productId).ToListAsync();
            return reviewRepository;

        }

        public async Task<IEnumerable<Review>> GetReviewByUserId(Guid userId)
        {
            return await _context.Reviews.Include(r => r.User).AsQueryable().Where(p => p.UserId == userId).ToListAsync();
        }

        /*public async Task<IEnumerable<Review>> GetReviewByUserId(Guid userId)
        {
            var reviewRepository = await _context.Reviews.AsQueryable().Include(p => p.User)
        }*/
    }
}
