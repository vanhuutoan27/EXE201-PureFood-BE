using PureFood.Core.Domain.Content;
using PureFood.Core.Models;
using PureFood.Core.SeedWorks;

namespace PureFood.Core.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product, Guid>
    {
        Task<PageResult<Product>> GetAllProductAsync(int page, int limit, string? searchName, string? categoryName,
            double? minWeight, double? maxWeight, string? unit, decimal? minPrice, decimal? maxPrice, string? origin, bool? organic);
        Task<int> GetTotalProductCountAsync(string searchName, string categoryName);
        Task<Product> GetProductBySlug(string slug);
        Task<IEnumerable<Product>> GetProductByCategoryid(Guid categoryId);
    }
}
