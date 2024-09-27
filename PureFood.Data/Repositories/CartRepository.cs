using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.Respones;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class CartRepository : RepositoryBase<Cart, Guid>, ICartRepository
    {
        public CartRepository(PureFoodDbContext context) : base(context)
        {

        }

        public async Task<PaginatedResult<Cart>> GetAllCartByuserAsync(int page, int limit , Guid userId)
        {
            IQueryable<Cart> query = _context.Carts.Include(cartItem => cartItem.CartItems).ThenInclude(p =>p.Product)
            .Include(u =>u.User).Where(c => c.UserId == userId);
            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            var carts = await query.ToListAsync();
            return new PaginatedResult<Cart>
            {
                Items = carts,
                TotalCount = totalItems,
            };
        }

        public async Task<Cart> GetCartByUser(Guid userId)
        {
           return await _context.Carts.FirstOrDefaultAsync(c => c.UserId == userId);
        }
    }
}
