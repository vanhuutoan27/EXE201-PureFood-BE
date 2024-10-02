using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content;
using PureFood.Core.SeedWorks;

namespace PureFood.Core.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product, Guid>
    {
        Task<PageResult<Product>> GetAllProductAsync(int page, int limit, string? searchName, string? categoryName,
            double? minWeight, double? maxWeight, string? unit, decimal? minPrice, decimal? maxPrice, string? origin, bool? organic);
        Task<int> GetTotalProductCountAsync(string searchName, string categoryName);
        Task<Product> GetProductbyId(Guid id);
        
        Task<Product> GetProductBySlug(string slug);
        Task<IEnumerable<Product>> GetProductBySupplierName(string supplierName);
        Task<IEnumerable<Product>> GetProductByCategoryName(string categoryName);
    }
}
