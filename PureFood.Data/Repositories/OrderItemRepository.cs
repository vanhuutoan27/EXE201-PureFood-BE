using PureFood.Core.Domain.Content;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class OrderItemRepository : RepositoryBase<OrderItem, Guid>, IOrderItemRepository
    {
        public OrderItemRepository(PureFoodDbContext context) : base(context)
        {

        }
    }
}
