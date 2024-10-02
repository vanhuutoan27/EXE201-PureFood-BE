using Microsoft.AspNetCore.Mvc;
using PureFood.Core.Models.content;
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
                _resultModel.Message = "Không tìm thấy danh mục.";
                return _resultModel;
            }
            _resultModel.Success = true;
            _resultModel.Status = (int)HttpStatusCode.OK;
            _resultModel.Data = categoryList;
            _resultModel.Message = "Lấy danh mục thành công.";
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
                _resultModel.Message = "Không tìm thấy danh mục.";
                return _resultModel;
            }
            _resultModel.Success = true;
            _resultModel.Status = (int)HttpStatusCode.OK;
            _resultModel.Data = getCategory;
            _resultModel.Message = "Lấy danh mục thành công.";
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
                    Message = "Tạo danh mục không thành công."
                };
                return BadRequest(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Tạo danh mục thành công.",
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
                    Message = "Cập nhật danh mục không thành công."
                };
                return BadRequest(_resultModel);
            }

            _resultModel = new ResultModel
            {
                Status = (int)HttpStatusCode.OK,
                Success = true,
                Message = "Cập nhật danh mục thành công.",
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
                    Message = "Xóa danh mục không thành công."

                };
                _resultModel = new ResultModel
                {
                    Status = (int)HttpStatusCode.OK,
                    Success = true,
                    Message = "Xóa danh mục thành công.",
                };

            }
            return Ok(_resultModel);
        }
    }
}
