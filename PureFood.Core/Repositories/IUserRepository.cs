using PureFood.Core.Domain.Identity;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.SeedWorks;

namespace PureFood.Core.Repositories
{
    public interface IUserRepository : IRepositoryBase<AppUser, Guid>
    {
       Task<IEnumerable<AppUser>> GetUsersAsync(int page, int limit, string search, bool? status);

       Task<AppUser> GetUserByPhoneAsync(string phone);
       Task<AppUser> GetUserbyId(Guid id);
       Task<AppUser>GetUserName(string name);
       Task RemoveUserFromRoleAsync(Guid userId, string[] roles);
       Task<AppUser>GetUserByEmail(string email);
    }
}
