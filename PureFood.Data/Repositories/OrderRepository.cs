using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content;
using PureFood.Core.Repositories;
using PureFood.Core.SeedWorks.Enums;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class OrderRepository : RepositoryBase<Order, Guid>, IOrderRepository
    {
        public OrderRepository(PureFoodDbContext context) : base(context)
        {

        }

        public async Task<PageResult<Order>> GetAllOrders(int page, int limit, string orderStatus)
        {
            IQueryable<Order> query = _context.Orders.Include(o => o.OrderItems).ThenInclude(oi => oi.Product).ThenInclude(p => p.Images).AsQueryable();

            if (!string.IsNullOrEmpty(orderStatus))
            {
                if (orderStatus.ToLower() == "new")
                {
                    query = query.Where(o => o.Status == OrderStatus.Pending || o.Status == OrderStatus.Processing);
                }
                else if (orderStatus.ToLower() == "processing")
                {
                    query = query.Where(o => o.Status == OrderStatus.Shipping || o.Status == OrderStatus.Completed || o.Status == OrderStatus.Cancelled);
                }
                else
                {
                    return null;
                }
            }

            // get total count
            int totalItems = await query.CountAsync();


            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            return new PageResult<Order>
            {
                TotalItems = totalItems,
                Items = query.ToList()
            };
        }

        public async Task<PageResult<Order>> GetAllOrdersByUserId(Guid userId, int page, int limit)
        {
            IQueryable<Order> query = _context.Orders.Where(o => o.UserId == userId).Include(o => o.OrderItems).ThenInclude(oi => oi.Product).ThenInclude(p => p.Images).AsQueryable();

            int totalItems = await query.CountAsync();


            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            return new PageResult<Order>
            {
                TotalItems = totalItems,
                Items = query.ToList()
            };
        }

        public async Task<Order> GetOrderById(Guid id)
        {
            return await _context.Orders.Include(o => o.OrderItems).ThenInclude(oi => oi.Product).ThenInclude(p => p.Images)
                .FirstOrDefaultAsync(o => o.OrderId == id);
        }
    }
}
