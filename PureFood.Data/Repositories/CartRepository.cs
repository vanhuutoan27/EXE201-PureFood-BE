using PureFood.Core.Domain.Content;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class CartRepository : RepositoryBase<Cart, Guid>, ICartRepository
    {
        public CartRepository(PureFoodDbContext context) : base(context)
        {

        }
    }
}
