using PureFood.Core.Domain.Content;
using PureFood.Core.Repositories;
using PureFood.Core.Services;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product, Guid> , IProductRepository
    {
        public ProductRepository(PureFoodDbContext context) : base(context)
        {
        }
    }
}
