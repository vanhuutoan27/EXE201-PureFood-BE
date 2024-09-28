using PureFood.Core.Domain.Content;
using PureFood.Core.SeedWorks;

namespace PureFood.Core.Repositories
{
    public interface IProductRepository : IRepositoryBase<Product, Guid>
    {
        Task<IEnumerable<Product>> GetAllProductAsync(int page, int limit, string? searchName, string? categoryName);
        Task<int> GetTotalProductCountAsync(string searchName, string categoryName);
        Task<Product> GetProductBySlug(string slug);
        Task<IEnumerable<Product>> GetProductBySupplierId(Guid supplierId);
        Task<IEnumerable<Product>> GetProductByCategoryid(Guid categoryId);
    }
}
