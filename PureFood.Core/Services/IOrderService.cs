using PureFood.Core.Models.content.Requests;
using PureFood.Core.Models.content.Responses;

namespace PureFood.Core.Services
{
    public interface IOrderService
    {
        Task<OrderResponse> CreateOrder(CreateOrderRequest request);
        Task<PageResult<OrderResponse>> GetAllOrder(int page, int limit);
        Task<OrderResponse> GetOrderById(Guid OrderId);
        Task<bool> ChangeStatusOrder(Guid orderId, UpdateOrderRequest request);
        Task<bool> DeleteOrder(Guid orderId);
    }
}
