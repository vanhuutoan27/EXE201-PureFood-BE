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

        public async Task<bool> ChangeStatusOrder(Guid orderId)
        {
            var order = await _repositoryManager.OrderRepository.GetByIdAsync(orderId);
            if (order == null)
            {
                return false;
            }
            // thay doi status khi goi toi
            switch (order.OrderStatus)
            {
                case "Pending":
                    order.OrderStatus = "Processing";
                    break;
                case "Processing":
                    order.OrderStatus = "Shipping";
                    break;
                case "Shipping":
                    order.OrderStatus = "Completed";
                    break;
                case "Completed":
                    throw new Exception("Không thể cập nhật trạng thái.");
                default:
                    throw new Exception("Trạng thái không hợp lệ.");
            }
            _repositoryManager.OrderRepository.Update(order);
            await _repositoryManager.SaveAsync();

            return true;
        }

        public async Task<bool> ChangeStatusOrderToCancel(Guid orderId)
        {
            var order = await _repositoryManager.OrderRepository.GetByIdAsync(orderId);
            if (order == null)
            {
                return false;
            }
            if (order.OrderStatus == "Pending" || order.OrderStatus == "Processing")
            {
                order.OrderStatus = "Cancelled";
            }
            else
            {
                throw new Exception("Không thể hủy đơn hàng.");
            }
            order.UpdatedAt = DateTime.Now;
            _repositoryManager.OrderRepository.Update(order);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<OrderResponse> CreateOrder(CreateOrderRequest request)
        {
            try
            {
                decimal discount = 0;
                // lay ma giam gia
                var promotion = await _repositoryManager.PromotionRepository.GetPromotionByDiscountCode(request.DiscountCode);
                if (!string.IsNullOrEmpty(request.DiscountCode))
                {
                    if (promotion == null)
                    {
                        throw new Exception("Mã giảm giá không hợp lệ hoặc đã hết hạn.");
                    }
                    if (promotion.Stock <= 0)
                    {
                        throw new Exception("Mã giảm giá không còn nữa");
                    }
                    // tinh toan giam gia
                    discount = (request.totalAmount * promotion.DiscountPercentage) / 100;

                    // giam Stock di 1
                    promotion.Stock -= 1;
                    _repositoryManager.PromotionRepository.Update(promotion);

                }

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
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    TotalAmount = request.totalAmount - discount,
                    PromotionId = promotion?.PromotionId
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
            catch (Exception ex)
            {
                throw new Exception("Lỗi tạo đơn hàng!" + ex.Message);
            }
        }


        public async Task<bool> DeleteOrder(Guid orderId)
        {
            var order = await _repositoryManager.OrderRepository.GetOrderById(orderId);
            if (order == null)
            {
                return false;
            }
            _repositoryManager.OrderRepository.Remove(order);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<PageResult<OrderResponse>> GetAllOrder(int page, int limit, string orderStatus)
        {
            var orderList = await _repositoryManager.OrderRepository.GetAllOrders(page, limit, orderStatus);
            //if (orderList == null) { throw new Exception("Không tìm thấy hóa đơn"); }
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
                    DiscountCode = o.Promotion?.DiscountCode,
                    OrderStatus = o.OrderStatus,
                    orderSummary = orderItemList,
                    TotalAmount = o.TotalAmount,
                    createdAt = o.CreatedAt,
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

        public async Task<PageResult<OrderResponse>> GetAllOrderByUserId(Guid userId, int page, int limit)
        {
            var result = await _repositoryManager.OrderRepository.GetAllOrdersByUserId(userId, page, limit);
            var orderResponse = result.Items.Select(o =>
            {
                var orderItemList = o.OrderItems.Select(item => new OrderItemResponse
                {
                    ProductId = item.ProductId,
                    ProductName = item.Product.ProductName,
                    Quantity = item.Quantity,
                    Price = item.Product.Price,
                    Image = item.Product?.Images?.Select(i => i.Url).FirstOrDefault()
                }).ToList();

                return new OrderResponse
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
                    DiscountCode = o.Promotion?.DiscountCode,
                    createdAt = o.CreatedAt,
                    UpdatedAt = o.UpdatedAt
                };
            }).ToList();


            return new PageResult<OrderResponse>
            {
                CurrentPage = page,
                TotalItems = result.TotalItems,
                TotalPages = (int)Math.Ceiling(result.TotalItems / (double)limit),
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
                createdAt = result.CreatedAt,
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
                DiscountCode = result.Promotion?.DiscountCode,


            };
            return orderRes;
        }
    }
}
