using PureFood.Core.Models.content.Responses;
using PureFood.Core.Models.Requests;

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
