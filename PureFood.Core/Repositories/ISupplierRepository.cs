using PureFood.Core.Domain.Content;
using PureFood.Core.SeedWorks;

namespace PureFood.Core.Repositories
{
    public interface ISupplierRepository : IRepositoryBase<Supplier, Guid>
    {
        Task<IEnumerable<Supplier>> GetAllSupplierAsync(int page, int limit);

    }
}
