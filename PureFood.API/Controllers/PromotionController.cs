using Microsoft.AspNetCore.Mvc;
using PureFood.Core.Models;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.SeedWorks;
using System.Net;

namespace PureFood.API.Controllers
{
    [Route("api/v1/promotions")]
    [ApiController]
    public class PromotionController : ControllerBase
    {

        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public PromotionController(IServiceManager service)
        {
            _serviceManager = service;
            _resultModel = new ResultModel();
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10)
        {
            var promotions = await _serviceManager.PromotionService.getAll(page, limit);
            if (promotions == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No promotions found."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = promotions,
                Message = "promotions retrieved successfully."
            };

            return Ok(_resultModel);
        }

        [HttpGet]
        [Route("{promotionId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReviewById(Guid promotionId)
        {


            var getPromotion = await _serviceManager.PromotionService.getPromotionById(promotionId);

            if (getPromotion == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null,
                    Message = "Id does not exist!."

                };
            }
            else
                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Data = getPromotion,
                    Message = "promotion retrieved successfully."
                };

            return Ok(_resultModel);


        }


        [HttpPost]
        //[Route("")]
        public async Task<ActionResult<ResultModel>> AddPromotion(CreatePromotionRequest request)
        {
            var promotion = await _serviceManager.PromotionService.createPromotion(request);
            if (promotion == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = "Unable to add promotion. Please try again."
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,

                Message = "promotion added successfully."
            };
            return Ok(_resultModel);
        }
        [HttpPut]
        [Route("{promotionId:guid}")]
        public async Task<ActionResult<ResultModel>> UdpdatePromotion(Guid promotionId, CreatePromotionRequest request)
        {
            var getPromotion = await _serviceManager.PromotionService.updatePromotion(promotionId, request);
            if (getPromotion == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "promotion not found."
                };
                return BadRequest(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,

                Message = "promotion updated successfully."
            };
            return Ok(_resultModel);
        }
        [HttpDelete]
        [Route("{promotionId:guid}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid promotionId)
        {
            var getPromotion = await _serviceManager.PromotionService.deletePromotion(promotionId);
            if (getPromotion == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Promotion not found."

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "Promotion deleted successfully."
            };
            return Ok(_resultModel);
        }
    }
}
