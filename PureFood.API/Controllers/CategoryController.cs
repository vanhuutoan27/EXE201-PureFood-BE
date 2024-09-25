using Microsoft.AspNetCore.Mvc;
using PureFood.Core.Models;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.SeedWorks;
using System.Net;

namespace PureFood.API.Controllers
{
    [Route("api/v1/Category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public CategoryController(IServiceManager service)
        {
            _serviceManager = service;
            _resultModel = new ResultModel();
        }

        [HttpGet("getAll")]
        public async Task<ActionResult<ResultModel>> GetAll()
        {

            var categoryList = await _serviceManager.CategoryService.getAll();
            if (categoryList == null)
            {
                _resultModel.Success = false;
                _resultModel.Status = (int)HttpStatusCode.InternalServerError;
                _resultModel.Message = "No category  found.";
                return _resultModel;
            }
            _resultModel.Success = true;
            _resultModel.Status = (int)HttpStatusCode.OK;
            _resultModel.Data = categoryList;
            _resultModel.Message = " category retrieved successfully.";
            return _resultModel;
        }

        [HttpGet("get-category-by-id/{id}")]
        public async Task<ActionResult<ResultModel>> GetById(Guid id)
        {

            var getCategory = await _serviceManager.CategoryService.getById(id);
            if (getCategory == null)
            {
                _resultModel.Success = false;
                _resultModel.Status = (int)HttpStatusCode.InternalServerError;
                _resultModel.Message = "No category  found.";
                return _resultModel;
            }
            _resultModel.Success = true;
            _resultModel.Status = (int)HttpStatusCode.OK;
            _resultModel.Data = getCategory;
            _resultModel.Message = " category retrieved successfully.";
            return _resultModel;
        }

        [HttpPut]
        [Route("Add")]
        public async Task<ActionResult<ResultModel>> AddCategory( CreateCategoryRequest request)
        {
            var updateSuccess = await _serviceManager.CategoryService.createCategory( request);

            if (!updateSuccess)
            {
                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Success = false,
                    Message = "Failed to create categpry."
                };
                return BadRequest(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Category create successfully.",
            };

            return Ok(_resultModel);
        }

            [HttpPatch]
          [Route("Update/{id}")]

        public async Task<ActionResult<ResultModel>> UpdateCategory(Guid id, CreateCategoryRequest request)
        {
            var updateSuccess = await _serviceManager.CategoryService.updateCategory(id, request);

            if (!updateSuccess)
            {
                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Success = false,
                    Message = "Failed to update categpry."
                };
                return BadRequest(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Category updated successfully.",
            };

            return Ok(_resultModel);
        }

        [HttpDelete]
        [Route("Delete/{id}")]
        public async Task<ActionResult<ResultModel>> DeleteCategory(Guid id)
        {
            var Category = await _serviceManager.CategoryService.deleteCategory(id);
            if (Category == null)
            {
                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Success = false,
                    Message = "Failed to delete category ."

                };
                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.OK,
                    Success = true,
                    Message = "Category deleted successfully.",
                };

            }
            return Ok(_resultModel);
        }

    }
}
