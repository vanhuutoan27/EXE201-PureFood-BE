using PureFood.Core.Domain.Content;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class SupplierRepository : RepositoryBase<Supplier, Guid>, ISupplierRepository
    {
        public SupplierRepository(PureFoodDbContext context) : base(context)
        {
        }
    }
}
