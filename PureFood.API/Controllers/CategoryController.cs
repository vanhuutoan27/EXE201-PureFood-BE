using Microsoft.AspNetCore.Mvc;
using PureFood.Core.Models;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.SeedWorks;
using System.Net;

namespace PureFood.API.Controllers
{
    [Route("api/v1/categories")]
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

        [HttpGet]
        public async Task<ActionResult<ResultModel>> GetAll()
        {

            var categoryList = await _serviceManager.CategoryService.getAll();
            if (categoryList == null)
            {
                _resultModel.Success = false;
                _resultModel.Status = (int)HttpStatusCode.InternalServerError;
                _resultModel.Message = "No categories found.";
                return _resultModel;
            }
            _resultModel.Success = true;
            _resultModel.Status = (int)HttpStatusCode.OK;
            _resultModel.Data = categoryList;
            _resultModel.Message = "Categories retrieved successfully.";
            return _resultModel;
        }

        [HttpGet("{categoryId}")]
        public async Task<ActionResult<ResultModel>> GetById(Guid categoryId)
        {

            var getCategory = await _serviceManager.CategoryService.getById(categoryId);
            if (getCategory == null)
            {
                _resultModel.Success = false;
                _resultModel.Status = (int)HttpStatusCode.InternalServerError;
                _resultModel.Message = "No category found.";
                return _resultModel;
            }
            _resultModel.Success = true;
            _resultModel.Status = (int)HttpStatusCode.OK;
            _resultModel.Data = getCategory;
            _resultModel.Message = "Category retrieved successfully.";
            return _resultModel;
        }

        [HttpPost]
        public async Task<ActionResult<ResultModel>> AddCategory(CreateCategoryRequest request)
        {
            var updateSuccess = await _serviceManager.CategoryService.createCategory(request);

            if (!updateSuccess)
            {
                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Success = false,
                    Message = "Failed to create category."
                };
                return BadRequest(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Category created successfully.",
            };

            return Ok(_resultModel);
        }

        [HttpPut]
        [Route("{categoryId}")]
        public async Task<ActionResult<ResultModel>> UpdateCategory(Guid categoryId, CreateCategoryRequest request)
        {
            var updateSuccess = await _serviceManager.CategoryService.updateCategory(categoryId, request);

            if (!updateSuccess)
            {
                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Success = false,
                    Message = "Failed to update category."
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
        [Route("{categoryId}")]
        public async Task<ActionResult<ResultModel>> DeleteCategory(Guid categoryId)
        {
            var Category = await _serviceManager.CategoryService.deleteCategory(categoryId);
            if (Category == null)
            {
                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.BadRequest,
                    Success = false,
                    Message = "Failed to delete category."

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
