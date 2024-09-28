using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PureFood.Core.Models;
using PureFood.Core.Models.Requests;
using PureFood.Core.SeedWorks;
using System.Net;

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
                    Message = "Invalid data."
                });
            }
            var result = await _serviceManager.ProductService.CreateProduct(createProductRequest);
            if (result == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)HttpStatusCode.NotFound,
                    Message = "Failed to create product."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Product created successfully."
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
                    Message = "Product not found."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = product,
                Message = "Product retrieved successfully."
            });
        }

        [HttpGet]
        public async Task<IActionResult> GetAllProduct(int page = 1, int limit = 10, string searchName = null, string categoryName = null)
        {
            var listProduct = await _serviceManager.ProductService.GetAllProduct(page, limit, searchName, categoryName);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listProduct,
                Message = "Products retrieved successfully."
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
                    Message = "Product not found"
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = product,
                Message = "Product retrieved successfully."
            });
        }

        [HttpGet("category/{categoryId}")]
        public async Task<IActionResult> GetProductByCategoryId(Guid categoryId)
        {
            var product = await _serviceManager.ProductService.GetProductByCategoryId(categoryId);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status= (int)HttpStatusCode.OK,
                Data = product,
                Message = "Products retrieved successfully."
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
                    Message = "Product not found"
                });
            }
            await _serviceManager.ProductService.UpdateProduct(productId, updateRequest);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Product updated successfully."
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
                    Message = "Product not found"
                });
            }
            await _serviceManager.ProductService.DeleteProduct(productId);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Product deleted successfully."
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
                    Message = "Product not found"
                });
            }
            await _serviceManager.ProductService.ChangeStatusProduct(productId);
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Message = "Product status updated successfully."
            });
        }
    }
}
