using PureFood.Core.Models;
using PureFood.Core.Models.Requests;
using PureFood.Core.Models.Respones;

namespace PureFood.Core.Services
{
    public interface IProductService
    {
        Task<CreateProductRequest> CreateProduct(CreateProductRequest requestProduct);
        Task<ProductRespone> GetProductById(Guid productId);
        Task<PageResult<ProductRespone>> GetAllProduct(int page, int limit, string? searchName, string? categoryName);
        Task<ProductRespone> GetProductBySlug(string slug);
        Task<bool> UpdateProduct(Guid productId, UpdateProductRequest updateProductRequest);
        Task<bool> DeleteProduct(Guid productId);
        Task<bool> ChangeStatusProduct(Guid productId);
    }
}
