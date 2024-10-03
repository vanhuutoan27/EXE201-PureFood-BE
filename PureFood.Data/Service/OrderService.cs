using AutoMapper;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.SeedWorks;
using PureFood.Core.Services;

namespace PureFood.Data.Service
{
    public class OrderService : IOrderService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public OrderService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<bool> ChangeStatusOrder(Guid orderId, UpdateOrderRequest request)
        {
            var order = await _repositoryManager.OrderRepository.GetByIdAsync(orderId);
            if (order == null) { return false; }
            order.OrderStatus = request.OrderStatus;
            _repositoryManager.OrderRepository.Update(order);
            await _repositoryManager.SaveAsync();

            return true;
        }

        public async Task<OrderResponse> CreateOrder(CreateOrderRequest request)
        {
            var order = new Order
            {
                UserId = request.UserId,
                FullName = request.FullName,
                PhoneNumber = request.PhoneNumber,
                Email = request.Email,
                Address = request.Address,
                Commune = request.Commune,
                District = request.District,
                Province = request.Province,
                PaymentMethod = request.PaymentMethod,
                OrderStatus = "Pending",
                CreateAt = DateTime.Now,
                UpdatedAt = DateTime.Now,
                TotalAmount = request.totalAmount
            };
            _repositoryManager.OrderRepository.Add(order);

            //add OrderItem
            foreach (var i in request.orderSummary)
            {
                var orderItem = new OrderItem
                {
                    ProductId = i.ProductId,
                    OrderId = order.OrderId,
                    Quantity = i.Quantity,
                };
                _repositoryManager.OrderItemRepository.Add(orderItem);

            }
            await _repositoryManager.SaveAsync();

            return _mapper.Map<OrderResponse>(order);
        }

        public async Task<PageResult<OrderResponse>> GetAllOrder(int page, int limit)
        {
            var orderList = await _repositoryManager.OrderRepository.GetAllOrders(page, limit);

            var orderResponse = new List<OrderResponse>();

            foreach (var o in orderList.Items)
            {
                var orderItemList = o.OrderItems.Select(item => new OrderItemResponse
                {
                    ProductId = item.ProductId,
                    ProductName = item.Product.ProductName,
                    Quantity = item.Quantity,
                    Price = item.Product.Price,
                    Image = item.Product?.Images?.Select(i => i.Url).FirstOrDefault()

                }).ToList();

                orderResponse.Add(new OrderResponse
                {
                    OrderId = o.OrderId,
                    UserId = o.UserId,
                    FullName = o.FullName,
                    PhoneNumber = o.PhoneNumber,
                    Email = o.Email,
                    Address = o.Address,
                    Commune = o.Commune,
                    District = o.District,
                    Province = o.Province,
                    PaymentMethod = o.PaymentMethod,
                    OrderStatus = o.OrderStatus,
                    orderSummary = orderItemList,
                    TotalAmount = o.TotalAmount,
                    CreateAt = o.CreateAt,
                    UpdatedAt = o.UpdatedAt,

                });


            }
            return new PageResult<OrderResponse>
            {
                CurrentPage = page,
                TotalItems = orderList.TotalItems,
                TotalPages = (int)Math.Ceiling(orderList.TotalItems / (double)limit),
                Items = orderResponse
            };
        }

        public async Task<OrderResponse> GetOrderById(Guid OrderId)
        {
            var result = await _repositoryManager.OrderRepository.GetOrderById(OrderId);
            var orderRes = new OrderResponse
            {
                OrderId = result.OrderId,
                UserId = result.UserId,
                FullName = result.FullName,
                PhoneNumber = result.PhoneNumber,
                Email = result.Email,
                Address = result.Address,
                Commune = result.Commune,
                District = result.District,
                Province = result.Province,
                PaymentMethod = result.PaymentMethod,
                OrderStatus = result.OrderStatus,
                CreateAt = result.CreateAt,
                UpdatedAt = result.UpdatedAt,
                orderSummary = result.OrderItems?.Select(oi => new OrderItemResponse
                {
                    ProductId = oi.ProductId,
                    ProductName = oi.Product.ProductName,
                    Quantity = oi.Quantity,
                    Price = oi.Product.Price,
                    Image = oi.Product?.Images?.OrderBy(i => i.ImageId).Select(i => i.Url).FirstOrDefault()
                }).ToList(),
                TotalAmount = result.TotalAmount,


            };
            return orderRes;
        }
    }
}
