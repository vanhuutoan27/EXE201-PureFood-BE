using Microsoft.AspNetCore.Mvc;
using PureFood.Core.Models.content;
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
                    Message = "Không tìm thấy khuyến mãi."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = promotions,
                Message = "Lấy khuyến mãi thành công."
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
                    Message = "ID không tồn tại."
                };
            }
            else
                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Data = getPromotion,
                    Message = "Lấy khuyến mãi thành công."
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
                    Message = "Không thể thêm khuyến mãi."
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Thêm khuyến mãi thành công."
            };
            return Ok(_resultModel);
        }
        [HttpPut]
        [Route("{promotionId:guid}")]
        public async Task<ActionResult<ResultModel>> UpdatePromotion(Guid promotionId, UpdatePromotionRequest request)
        {
            var getPromotion = await _serviceManager.PromotionService.updatePromotion(promotionId, request);
            if (getPromotion == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy khuyến mãi."
                };
                return BadRequest(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật khuyến mãi thành công."
            };
            return Ok(_resultModel);
        }
        [HttpPatch("{promotionId}")]
        public async Task<ActionResult<ResultModel>> ChangeStatusPromotion(Guid promotionId)
        {
            var updatePromotion = await _serviceManager.PromotionService.ChangeStatus(promotionId);
            if(!updatePromotion)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status= (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy khuyến mãi."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật trạng thái thành công."
            });
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
                    Message = "Không tìm thấy khuyến mãi."

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "Xóa khuyến mãi thành công."
            };
            return Ok(_resultModel);
        }
    }
}
