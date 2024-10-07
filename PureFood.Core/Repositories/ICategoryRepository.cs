using PureFood.Core.Domain.Content;
using PureFood.Core.SeedWorks;

namespace PureFood.Core.Repositories
{
    public interface ICategoryRepository : IRepositoryBase<Category, Guid>
    {
        Task<IEnumerable<Category>> getAll();
        Task<Category> findById(Guid id);
        Task<Category> GetCategoryByName(string name);
    }
}
