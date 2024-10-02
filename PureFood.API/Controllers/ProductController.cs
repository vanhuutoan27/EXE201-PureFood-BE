using Microsoft.AspNetCore.Mvc;
using PureFood.Core.Models.content;
using PureFood.Core.Models.Requests;
using PureFood.Core.SeedWorks;
using System.Net;
using System.Reflection.Metadata.Ecma335;

namespace PureFood.API.Controllers
{
    [Route("api/v1/products")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private ResultModel _resultModel;
        public ProductController(IServiceManager serviceManager)
        {
            _serviceManager = serviceManager;
            _resultModel = new ResultModel();
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateProductRequest createProductRequest)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.BadRequest,
                    Message = "Dữ liệu không hợp lệ."
                });
            }
            var result = await _serviceManager.ProductService.CreateProduct(createProductRequest);
            if (result == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Tạo sản phẩm không thành công."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Tạo sản phẩm thành công."
            });
        }

        [HttpGet("{productId:guid}")]
        public async Task<IActionResult> GetById(Guid productId)
        {
            var product = await _serviceManager.ProductService.GetProductById(productId);
            if (product == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy sản phẩm."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = product,
                Message = "Lấy sản phẩm thành công."
            });
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct(int page = 1, int limit = 10, string? search = null, string? category = null,
            double? minWeight = null, double? maxWeight = null, string? unit = null, decimal? minPrice = null, decimal? maxPrice = null, string? origin = null, bool? organic = null)
        {
            var listProduct = await _serviceManager.ProductService.GetAllProduct(page, limit, search, category, minWeight, maxWeight, unit, minPrice, maxPrice,
                origin, organic);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listProduct,
                Message = "Lấy sản phẩm thành công."
            });
        }

        [HttpGet("{slug}")]
        public async Task<IActionResult> GetBySlug(string slug)
        {
            var product = await _serviceManager.ProductService.GetProductBySlug(slug);
            if (product is null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy sản phẩm."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = product,
                Message = "Lấy sản phẩm thành công."
            });
        }
        [HttpGet("supplier/{supplierName}")]
        public async Task<IActionResult> GetProductBySupplier(string supplierName, int page = 1, int limit = 10)
        {
            // kiem tra supplier

            var product = await _serviceManager.ProductService.GetProductBySupplierName(page, limit, supplierName);
            if (product == null)
            {
                return NotFound(product);
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = product,
                Message = "Lấy sản phẩm thành công."
            });
        }

        [HttpGet("category/{categoryName}")]
        public async Task<IActionResult> GetProductByCategory(string categoryName, int page = 1, int limit = 10)
        {
            // kiem tra category
            var product = await _serviceManager.ProductService.GetProductByCategoryName(page, limit, categoryName);
            if (product == null)
            {
                return NotFound(product);
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = product,
                Message = "Lấy sản phẩm thành công."
            });
        }
        [HttpPut("{productId}")]
        public async Task<IActionResult> UpdateProduct(Guid productId, [FromBody] UpdateProductRequest updateRequest)
        {
            var product = await _serviceManager.ProductService.GetProductById(productId);
            if (product is null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy sản phẩm."
                });
            }
            await _serviceManager.ProductService.UpdateProduct(productId, updateRequest);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật sản phẩm thành công."
            });
        }

        [HttpDelete]
        [Route("{productId}")]
        public async Task<IActionResult> DeleteProduct(Guid productId)
        {
            var product = await _serviceManager.ProductService.GetProductById(productId);
            if (product is null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy sản phẩm."
                });
            }
            await _serviceManager.ProductService.DeleteProduct(productId);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Xóa sản phẩm thành công."
            });
        }

        [HttpPatch("{productId}/status")]
        public async Task<IActionResult> ChangeStatusProduct(Guid productId)
        {
            var product = await _serviceManager.ProductService.GetProductById(productId);
            if (product is null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Không tìm thấy sản phẩm."
                });
            }
            await _serviceManager.ProductService.ChangeStatusProduct(productId);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Cập nhật trạng thái sản phẩm thành công."
            });
        }
    }
}
