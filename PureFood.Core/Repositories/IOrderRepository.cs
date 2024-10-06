using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content;
using PureFood.Core.SeedWorks;

namespace PureFood.Core.Repositories
{
    public interface IOrderRepository : IRepositoryBase<Order, Guid>
    {
        public Task<PageResult<Order>> GetAllOrders(int page, int limit, string orderStatus);
        public Task<Order> GetOrderById(Guid id);
        public Task<PageResult<Order>> GetAllOrdersByUserId(Guid userId, int page, int limit);
    }
}
