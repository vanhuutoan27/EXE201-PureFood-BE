using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Identity;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class UserRepository : RepositoryBase<AppUser, Guid>, IUserRepository
    {
        public UserRepository(PureFoodDbContext context) : base(context)
        {
        }

        public async Task<AppUser> GetUserByEmail(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }

        public async Task<AppUser> GetUserbyId(Guid id)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserId == id);
        }

        public async Task<AppUser> GetUserByPhoneAsync(string phone)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.PhoneNumber == phone);
        }

        public async Task<AppUser> GetUserName(string name)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.UserName == name);
        }

        public async Task<IEnumerable<AppUser>> GetUsersAsync(int page, int limit, string search, bool? status)
        {
            IQueryable<AppUser> query = _context.Users;

            // Tìm kiếm theo từ khóa
            if (!string.IsNullOrEmpty(search))
            {
                search = search.ToLower();
                query = query.Where(s => (s.UserName.ToLower().Contains(search) ||
                                          s.Email.ToLower().Contains(search) ||
                                          s.FullName.ToLower().Contains(search)) &&
                                          (!status.HasValue || s.Status == status.Value));
            }

            // Lọc theo status nếu có giá trị
            if (status.HasValue)
            {
                query = query.Where(s => s.Status == status.Value);
            }

            // Phân trang
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            // Trả về danh sách người dùng
            return await query.ToListAsync();
        }


        public async Task RemoveUserFromRoleAsync(Guid userId, string[] roles)
        {
            if (roles.Length == 0 || roles == null)
            {
                return;
            }
            foreach (var role in roles)
            {
                var roledb = await _context.Roles.FirstOrDefaultAsync(r => r.Name == role);
                if (roledb == null)
                {
                    return;
                }
                var userRole = await _context.UserRoles.FirstOrDefaultAsync(ur => ur.UserId == userId && ur.RoleId == roledb.Id);
                if (userRole == null)
                {
                    return;
                }
                _context.UserRoles.Remove(userRole);
            }
        }


    }
}
