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
            var result = await _serviceManager.OrderService.CreateOrder(request);
            if (result == null)
            {
                return new ResultModel
                {
                    Message = "Create order fail.",
                    Status = (int)HttpStatusCode.InternalServerError,
                    Success = false

                };
            }
            return new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Create order successfully."
            };
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAllResultModel(int page = 1, int limit = 10)
        {
            var result = await _serviceManager.OrderService.GetAllOrder(page, limit);
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

        [HttpPatch("{orderId}/status")]
        public async Task<ActionResult<ResultModel>> UpdateOrderStatus(Guid orderId, [FromBody] UpdateOrderRequest request)
        {
            var result = await _serviceManager.OrderService.ChangeStatusOrder(orderId, request);
            if (!result)
            {
                return new ResultModel
                {
                    Success = false,
                    Status = 400,
                    Message = "Updated fail.",
                };
            }
            return new ResultModel
            {
                Success = true,
                Status = 200,
                Message = "Updated successfully.",
            };
        }

    }
}
