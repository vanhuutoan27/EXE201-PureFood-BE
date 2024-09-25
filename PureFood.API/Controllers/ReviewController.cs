using Microsoft.AspNetCore.Mvc;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.Models;
using PureFood.Core.SeedWorks;
using System.Net;

namespace PureFood.API.Controllers
{
    [Route("api/v1/Review")]
    [ApiController]
    public class ReviewController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public ReviewController(IServiceManager service)
        {
            _serviceManager = service;
            _resultModel = new ResultModel();
        }

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10, string? search = null)
        {
            var brands = await _serviceManager.ReviewService.getAll(page, limit);
            if (brands == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "No Review found."
                };
                return NotFound(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = brands,
                Message = "Reviews retrieved successfully."
            };

            return Ok(_resultModel);
        }

        [HttpGet]
        [Route("{reviewId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReviewById(Guid reviewId)
        {


            var reviews = await _serviceManager.ReviewService.getReviewById(reviewId);

            if (reviews == null)
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
                    Data = reviews,
                    Message = "Review retrieved successfully."
                };

            return Ok(_resultModel);


        }
        [HttpGet]
        [Route("car/{productId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReviewsByProduct(Guid productId)
        {

            var reviews = await _serviceManager.ReviewService.getReviewByProductId(productId);

            if (reviews == null)
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
                    Data = reviews,
                    Message = "Review retrieved successfully."
                };

            return Ok(_resultModel);

        }

        [HttpGet]
        [Route("user/{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetReviewByUserId(Guid userId)
        {
            var reviews = await _serviceManager.ReviewService.getReviewByUserId(userId);

            if (reviews == null || !reviews.Any())
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Data = null,
                    Message = "Id does not exist!"
                };
            }
            else
            {
                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)HttpStatusCode.OK,
                    Data = reviews,
                    Message = "Review retrieved successfully."
                };
            }

            return Ok(_resultModel);
        }




        [HttpPost]
        [Route("add")]
        public async Task<ActionResult<ResultModel>> AddReview(CreateReviewRequest request)
        {
            var addReview = await _serviceManager.ReviewService.createReview(request);
            if (addReview == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = "Unable to add review. Please try again."
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,

                Message = "Review added successfully."
            };
            return Ok(_resultModel);
        }
        [HttpPut]
        [Route("{reviewId:guid}")]
        public async Task<ActionResult<ResultModel>> UdpdateReview(Guid reviewId, CreateReviewRequest request)
        {
            var updateReview = await _serviceManager.ReviewService.updateReview(reviewId, request);
            if (updateReview == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Review not found."
                };
                return BadRequest(_resultModel);
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,

                Message = "Review updated successfully."
            };
            return Ok(_resultModel);
        }
        [HttpDelete]
        [Route("{reviewId:guid}")]
        public async Task<ActionResult<ResultModel>> Delete(Guid reviewId)
        {
            var updateReview = await _serviceManager.ReviewService.deleteReview(reviewId);
            if (updateReview == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Review not found."

                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.NoContent,
                Message = "Review deleted successfully."
            };
            return Ok(_resultModel);
        }
        [HttpPatch]
        [Route("{reviewId}/flag")]
        public async Task<ActionResult<ResultModel>> ChangeFlag(Guid reviewId)
        {
            var flagChanged = await _serviceManager.ReviewService.ChangeFlagAsync(reviewId);

            if (!flagChanged)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Failed to flag review."
                };
                return NotFound(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Review flagged successfully."
            };

            return Ok(_resultModel);
        }


    }
}
