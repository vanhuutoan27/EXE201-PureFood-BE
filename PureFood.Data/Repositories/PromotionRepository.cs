using PureFood.Core.Domain.Content;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureFood.Data.Repositories
{
    public class PromotionRepository : RepositoryBase<Product, Guid>, IProductRepository
    {
        public PromotionRepository(PureFoodDbContext context) : base(context)
        {
        }
    }
}
