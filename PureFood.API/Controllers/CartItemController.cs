using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PureFood.Core.Models.content;
using PureFood.Core.Models.Requests;
using PureFood.Core.SeedWorks;

namespace PureFood.API.Controllers
{
    [ApiController]
    [Route("api/v1/cart-items")]
    public class CartItemController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public CartItemController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            _resultModel = new ResultModel();
        }
        [HttpDelete("{cartItemId}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid cartItemId)
        {

            if (cartItemId == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "CartItem not found."
                };
                return _resultModel;
            }
            var delete = await _serviceManager.CartItemService.DeleteCartItem(cartItemId);
            return _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "CartItem deleted successfully.",
            };
        }
        [HttpPatch("{cartItemId}")]
        public async Task<ActionResult<ResultModel>> UpdateCartItem(UpdateCartItemRequest request, Guid cartItemId)
        {
            if (cartItemId == Guid.Empty)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cart Item not found."
                };
                return NotFound(_resultModel);
            }

            var result = await _serviceManager.CartItemService.UpdateCartItem(request, cartItemId);

            if (!result)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.InternalServerError,
                    Message = "Failed to Up Cart Item."
                };
                return StatusCode((int)HttpStatusCode.InternalServerError, _resultModel);
            }

            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Update Cart Item successfully.",
                Data = result
            };

            return Ok(_resultModel);
        }
        
        [HttpGet]
        [Route("{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetCartbyUserId(int page = 1, int limit = 10 ,Guid userId = default)
        {
            var query = await _serviceManager.CartItemService.GetAllCartItemByUser(page , limit ,userId);
            if (query == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Cart Item not found."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cart Item retrieved successfully.",
                Data = query
            });
        }
    }
}