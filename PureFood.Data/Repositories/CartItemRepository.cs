using PureFood.Core.Domain.Content;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class CartItemRepository : RepositoryBase<CartItem, Guid>, ICartItemRepository
    {
        public CartItemRepository(PureFoodDbContext context) : base(context)
        {

        }
    }
}
