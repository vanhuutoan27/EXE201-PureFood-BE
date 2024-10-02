using AutoMapper;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Identity;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.SeedWorks;
using PureFood.Core.Services;


namespace PureFood.Data.Service
{
    public class UserService : IUserService
    {

        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        private readonly UserManager<AppUser> _userManager;

        private readonly Dictionary<string, int> _roleHierarchy = new Dictionary<string, int>
    {
        { "Admin", 3 },
        // { "Manager", 2 },
        { "Customer", 1 }
    };
        public UserService(UserManager<AppUser> userManager, IRepositoryManager repositoryManager, IMapper mapper)
        {
            _userManager = userManager;
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<UserReponse> AddUser(CreateUpdateUserRequest User)
        {
            // var userModel = _mapper.Map<AppUser>(User);

            // check phone existed
            // var phoneExisted = CheckPhoneNumerAsync(User.PhoneNumber);

            var newUserRequest = new AppUser()
            {
                Id = Guid.NewGuid(),
                FullName = User.FullName,
                UserName = User.Email,
                Status = false,
                Email = User.Email,
                PhoneNumber = User.PhoneNumber,
                LockoutEnabled = false,
                EmailConfirmed = true,
                UpdatedAt = DateTime.Now,
                CreatedAt = DateTime.Now,
            };

            var result = await _userManager.CreateAsync(newUserRequest, "123As@");
            newUserRequest = await _userManager.FindByEmailAsync(User.Email);
            if (!result.Succeeded)
            {
                var errorMessages = string.Join("; ", result.Errors.Select(e => e.Description));
                throw new Exception($"Failed to create user: {errorMessages}");
            }
            await _userManager.AddToRoleAsync(newUserRequest, User.Role);
            var UserResponse = _mapper.Map<UserReponse>(newUserRequest);
            return UserResponse;
        }

        public async Task<bool> ChangeAvatar(Guid userId, ChangeAvatarRequest request)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null) throw new Exception("Not Found User");
            user.Avatar = request.Avatar;
            var identiyResult = await _userManager.UpdateAsync(user);
            return identiyResult.Succeeded;
        }

        public async Task<bool> ChangePasswordbyId(Guid id, string currentPassword, string newPassword)
        {
            var user = await _userManager.FindByIdAsync(id.ToString());
            if (currentPassword == newPassword)
            {
                throw new Exception("Current password is equal with new password");
            }
            if (user == null)
            {
                throw new Exception("User not found.");
            }
            var isPasswordValid = await _userManager.CheckPasswordAsync(user, currentPassword);
            if (!isPasswordValid)
            {
                throw new Exception("Current password is incorrect.");
            }

            var result = await _userManager.ChangePasswordAsync(user, currentPassword, newPassword);
            if (!result.Succeeded)
            {
                throw new Exception("Fail to change password");
            }
            return true;

        }

        public async Task<bool> ChangeStatusbyId(Guid id)
        {
            var getUser = await _repositoryManager.UserRepository.GetUserbyId(id);
            if (getUser == null)
            {
                throw new Exception("User not found.");
            }

            if (getUser.Status)
            {
                getUser.Status = false;
            }
            else
            {
                getUser.Status = true;
            }
            var result = await _userManager.UpdateAsync(getUser);
            return result.Succeeded;
        }

        public async Task<UserReponse> GetUserById(Guid id)
        {
            var getUser = await _repositoryManager.UserRepository.GetUserbyId(id);
            if (getUser == null)
            {
                throw new Exception("User not found.");

            }
            var userResponse = _mapper.Map<UserReponse>(getUser);
            var roles = await _userManager.GetRolesAsync(getUser);
            userResponse.Role = roles.FirstOrDefault();
            return userResponse;
        }

        public async Task<UserReponse> GetUserName(string name)
        {
            var getUsers = await _repositoryManager.UserRepository.GetUserName(name);
            if (getUsers == null)
            {
                throw new Exception("User not found.");
            }
            var user = _mapper.Map<UserReponse>(getUsers);
            var roles = await _userManager.GetRolesAsync(getUsers);
            user.Role = roles.FirstOrDefault();
            return user;
        }

        public async Task<PageResult<UserReponse>> GetUsersAsync(int page, int limit, string search, string currentUserId, bool? status)
        {
            // Kiểm tra currentUserId có null không
            var currentUser = await _userManager.FindByIdAsync(currentUserId);
            if (currentUser == null)
            {
                throw new ArgumentNullException(nameof(currentUser), "Current user cannot be null.");
            }

            // Lấy role của người dùng hiện tại
            var currentUserRoles = (await _userManager.GetRolesAsync(currentUser)).FirstOrDefault();

            // Truy vấn danh sách người dùng từ repository
            var listUser = await _repositoryManager.UserRepository.GetUsersAsync(page, limit, search, status);

            var filteredUsers = new List<AppUser>();

            foreach (var user in listUser)
            {
                if (currentUser.Id == user.Id) continue;  // Bỏ qua chính người dùng hiện tại

                var userRoles = (await _userManager.GetRolesAsync(user)).FirstOrDefault();

                // Chỉ thêm người dùng vào danh sách nếu người dùng hiện tại có quyền xem
                if (CanViewUser(currentUserRoles, userRoles))
                {
                    filteredUsers.Add(user);
                }
            }

            var totalItems = filteredUsers.Count();

            var listUserReponse = _mapper.Map<IEnumerable<UserReponse>>(filteredUsers).ToList();

            // Thêm role vào từng người dùng
            for (int i = 0; i < filteredUsers.Count(); i++)
            {
                var roles = await _userManager.GetRolesAsync(filteredUsers[i]);
                listUserReponse[i].Role = roles.FirstOrDefault();
            }

            // Trả về kết quả phân trang
            return new PageResult<UserReponse>
            {
                CurrentPage = page,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit),
                TotalItems = totalItems,
                Items = listUserReponse
            };
        }

        /* private bool CanViewUser(string currentUserRole, string targetUserRole)
         {
             // Nếu người dùng hiện tại có vai trò ngang bằng hoặc thấp hơn so với người dùng mục tiêu, từ chối truy cập
             if (string.Compare(currentUserRole, targetUserRole, StringComparison.Ordinal) >= 0)
             {
                 return false;
             }

             // Nếu vai trò của người dùng mục tiêu thấp hơn vai trò của người dùng hiện tại, cho phép xem
             return true;
         }*/
        public bool CanViewUser(string currentUserRole, string targetUserRole)
        {
            if (!_roleHierarchy.TryGetValue(currentUserRole, out var currentUserLevel) ||
                !_roleHierarchy.TryGetValue(targetUserRole, out var targetUserLevel))
            {
                return false;
            }

            return currentUserLevel > targetUserLevel;
        }

        public async Task<bool> RemoveUser(Guid id)
        {
            if (id == null) throw new Exception("User not found.");
            var user = await _userManager.FindByIdAsync(id.ToString());

            if (user == null) throw new Exception("User not found.");

            user.LockoutEnabled = true;

            user.Status = false;

            var result = await _userManager.UpdateAsync(user);

            return result.Succeeded;


        }

        public async Task<UserReponse> UpdateUser(Guid id, UpdateUserRequest User)
        {
            var UserToEdit = await _userManager.FindByIdAsync(id.ToString());
            if (UserToEdit == null) throw new Exception("User not found.");
            var roles = await _userManager.GetRolesAsync(UserToEdit);

            // Neu Roles thay doi
            if (roles.FirstOrDefault() != User.Role)
            {
                await _repositoryManager.UserRepository.RemoveUserFromRoleAsync(UserToEdit.Id, roles.ToArray());
                var addedResult = await _userManager.AddToRoleAsync(UserToEdit, User.Role);
                if (addedResult.Succeeded)
                {
                    Console.WriteLine("Alice đã được thêm vào role 'Manager' thành công.");
                }
                else
                {
                    // Nếu có lỗi, hiển thị các lỗi
                    foreach (var error in addedResult.Errors)
                    {
                        Console.WriteLine($"Lỗi: {error.Description}");
                    }
                }
            }

            if (UserToEdit.Email != User.Email)
                UserToEdit.Email = User.Email;

            if (UserToEdit.FullName != User.FullName)
            {
                UserToEdit.FullName = User.FullName;
            }

            if (UserToEdit.PhoneNumber != User.PhoneNumber)
                UserToEdit.PhoneNumber = User.PhoneNumber;

            var result = await _userManager.UpdateAsync(UserToEdit);
            if (!result.Succeeded)
            {
                foreach (var error in result.Errors)
                    throw new Exception($"{error.Description}");
            }
            UserToEdit.UpdatedAt = DateTime.Now;
            var UserReponse = _mapper.Map<UserReponse>(UserToEdit);

            return UserReponse;

        }

        public async Task<bool> CheckPhoneNumerAsync(string phoneNumber)
        {
            var user = await _repositoryManager.UserRepository.GetUserByPhoneAsync(phoneNumber);
            return user != null;
        }

        public async Task<bool> UpdateUserRoleCustomer(Guid userId, UpdateUserRoleCustomerRequest updateCustomer)
        {
            var user = await _userManager.FindByIdAsync(userId.ToString());
            if (user == null)
            {
                throw new Exception("User not found");
            }
            // kiem tra role cua nguoi dung
            var roleUser = await _userManager.GetRolesAsync(user);
            if (!roleUser.Contains("Customer"))
            {
                throw new Exception("Only customers can update profile.");
            }

            // check email exist
            var existingEmail = await _userManager.FindByEmailAsync(updateCustomer.Email);
            if (existingEmail != null && existingEmail.Id != user.Id)
            {
                throw new Exception("Email already exists.");
            }
            // check phone exist
            var existingPhone = await _userManager.Users.FirstOrDefaultAsync(u => u.PhoneNumber == updateCustomer.PhoneNumber);
            if (existingPhone != null && existingPhone.PhoneNumber != user.PhoneNumber)
            {
                throw new Exception("Phone number already exists.");
            }
            user.FullName = updateCustomer.FullName;
            user.Email = updateCustomer.Email;
            user.NormalizedEmail = updateCustomer.Email.ToUpper();
            user.PhoneNumber = updateCustomer.PhoneNumber;
            user.Dob = updateCustomer.Dob;
            user.Gender = updateCustomer.Gender;

            await _userManager.UpdateAsync(user);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<AppUser> GetUserByEmail(string email)
        {
            return await _repositoryManager.UserRepository.GetUserByEmail(email);
        }
    }
}
