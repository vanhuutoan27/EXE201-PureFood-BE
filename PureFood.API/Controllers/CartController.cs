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
    [Route("api/v1/carts")]
    [ApiController]

    public class CartController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public CartController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            _resultModel = new ResultModel();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateCartRequest request)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = "Invalid data."
                });
            }
            var result = await _serviceManager.CartService.CreateCartAsync(request);
            if (result == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Failed to add cart."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cart added successfully."
            });
        }
        // [HttpGet]
        // [Route("{userId:guid}")]
        // public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10, Guid userId = default)
        // {
        //     // Ensure userId is passed
        //     if (userId == Guid.Empty)
        //     {
        //         _resultModel = new ResultModel
        //         {
        //             Success = false,
        //             Message = "UserId is required.",
        //             Status = (int)HttpStatusCode.BadRequest
        //         };
        //         return BadRequest(_resultModel);
        //     }

        //     // Fetch carts with paginated cart items
        //     var carts = await _serviceManager.CartService.GetAllCartsByUser(userId, page , limit);

        //     if (carts == null )
        //     {
        //         _resultModel = new ResultModel
        //         {
        //             Success = false,
        //             Message = "No carts found.",
        //             Status = (int)HttpStatusCode.NotFound
        //         };
        //         return NotFound(_resultModel);
        //     }

        //     _resultModel = new ResultModel
        //     {
        //         Success = true,
        //         Status = (int)HttpStatusCode.OK,
        //         Data = carts,
        //         Message = "Carts retrieved successfully."
        //     };

        //     return Ok(_resultModel);
        // }

    }

}