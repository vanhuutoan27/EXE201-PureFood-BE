using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.Respones;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class CartItemRepository : RepositoryBase<CartItem, Guid>, ICartItemRepository
    {
        public CartItemRepository(PureFoodDbContext context) : base(context)
        {

        }

        public async Task<PaginatedResult<CartItem>> GetAllCartItemByUserAsync(int page, int limit , Guid userId)
        {
           IQueryable<CartItem> query = _context.CartItems.Include(c => c.Cart)
           .Include(p => p.Product).Where(c => c.Cart.UserId == userId);
                  int totalItems = await query.CountAsync();

            // Apply pagination
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            var carts = await query.ToListAsync();
            return new PaginatedResult<CartItem>
            {
                Items = carts,
                TotalCount = totalItems,
            };                      

        }
    }
}
