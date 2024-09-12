using PureFood.Core.Domain.Identity;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class UserRepository : RepositoryBase<AppUser, Guid>, IUserRepository
    {
        public UserRepository(PureFoodDbContext context) : base(context)
        {
        }
    }
}
