using PureFood.Core.Domain.Content;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class PromotionRepository(PureFoodDbContext context) : RepositoryBase<Promotion, Guid>(context), IPromotionRepository
    {

    }
}
