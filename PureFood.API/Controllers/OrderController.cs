using Microsoft.AspNetCore.Mvc;
using PureFood.Core.Models.content;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.SeedWorks;
using System.Net;

namespace PureFood.API.Controllers
{
    [Route("api/v1/orders")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;

        public OrderController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> CreateOrder([FromBody] CreateOrderRequest request)
        {
            try
            {
                var result = await _serviceManager.OrderService.CreateOrder(request);
                if (result == null)
                {
                    return new ResultModel
                    {
                        Success = false,
                        Status = (int)HttpStatusCode.BadRequest,
                        Message = "Đặt hàng thất bại.",
                    };
                }
                return new ResultModel
                {
                    Success = true,
                    Status = 200,
                    Message = "Đặt hàng thành công.",
                    Data = result.OrderId
                };
            }
            catch (Exception ex)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = 500,
                    Message = ex.Message
                };
            }
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllResultModel(int page = 1, int limit = 10, string orderStatus = null)
        {
            var result = await _serviceManager.OrderService.GetAllOrder(page, limit, orderStatus);
            return new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Order retrieved successfully.",
                Data = result
            };
        }
        [HttpGet]
        [Route("{orderId:guid}")]

        public async Task<ActionResult<ResultModel>> GetOrderById(Guid orderId)
        {
            var result = await _serviceManager.OrderService.GetOrderById(orderId);
            return new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Order retrieved successfully.",
                Data = result
            };
        }
        [HttpGet("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetOrderByUserId(Guid userId, int page = 1, int limit = 10)
        {
            var result = await _serviceManager.OrderService.GetAllOrderByUserId(userId, page, limit);

            return new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Order retrieved successfully.",
                Data = result
            };
        }

        [HttpPatch("{orderId}/status")]
        public async Task<ActionResult<ResultModel>> UpdateOrderStatus(Guid orderId)
        {
            var result = await _serviceManager.OrderService.ChangeStatusOrder(orderId);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = 400,
                    Message = "Cập nhật trạng thái thất bại.",
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Cập nhật trạng thái thành công.",
            };
        }
        [HttpPatch("{orderId}/cancel")]
        public async Task<ActionResult<ResultModel>> UpdateStatusOrderToCancel(Guid orderId)
        {
            var updateStatusOrder = await _serviceManager.OrderService.ChangeStatusOrderToCancel(orderId);
            if (!updateStatusOrder)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = 400,
                    Message = "Không tìm thấy đơn hàng.",
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "Hủy đơn hàng thành công"
            };
        }
        [HttpDelete("{orderId}")]
        public async Task<ActionResult<ResultModel>> DeleteOrder(Guid orderId)
        {
            var result = await _serviceManager.OrderService.DeleteOrder(orderId);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = 400,
                    Message = "Deleted fail.",
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Deleted successfully.",
            };
        }

    }
}
