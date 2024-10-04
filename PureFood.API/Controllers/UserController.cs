using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using PureFood.Core.Domain.Identity;
using PureFood.Core.Models.content;
using PureFood.Core.Models.content.Requests;
using PureFood.Core.SeedWorks;
using System.Net;
using System.Security.Claims;

namespace PureFood.API.Controllers
{
    [Route("api/v1/users")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IServiceManager _serviceManager;
        private readonly UserManager<AppUser> _userManager;

        private ResultModel _resultModel;

        public UserController(IServiceManager service, UserManager<AppUser> userManager)
        {
            _serviceManager = service;
            _userManager = userManager;

            _resultModel = new ResultModel();
        }

        [HttpGet]
        [Authorize]
        public async Task<ActionResult<ResultModel>> GetAll(int page = 1, int limit = 10, string search = null, bool? status = null)
        {
            var userEmail = User.FindFirst(ClaimTypes.Email)?.Value;
            var user = await _userManager.FindByEmailAsync(userEmail);
            var listusers = await _serviceManager.UserService.GetUsersAsync(page, limit, search, user.Id.ToString(), status);
            if (listusers == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "No users found.",
                    Status = (int)HttpStatusCode.NotFound
                };
            }
            _resultModel = new ResultModel
            {
                Success = true,
                Status = (int)HttpStatusCode.OK,
                Data = listusers,
                Message = "Users retrieved successfully."
            };

            return Ok(_resultModel);
        }

        [HttpGet("{userId:guid}")]
        public async Task<ActionResult<ResultModel>> GetUserById(Guid userId)
        {
            var user = await _serviceManager.UserService.GetUserById(userId);
            if (user == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "User not found.",
                    Status = (int)System.Net.HttpStatusCode.NotFound
                };
            }
            else
            {
                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)System.Net.HttpStatusCode.OK,
                    Data = user,
                    Message = "User retrieved successfully."
                };
            }
            return Ok(_resultModel);
        }

        [HttpGet("{username}")]
        [Authorize]
        public async Task<ActionResult<ResultModel>> GetUserByUsername(string username)
        {
            var user = await _serviceManager.UserService.GetUserName(username);
            if (user == null)
            {
                _resultModel = new ResultModel
                {
                    Success = false,
                    Message = "User not found.",
                    Status = (int)System.Net.HttpStatusCode.NotFound
                };
            }
            else
            {
                _resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)System.Net.HttpStatusCode.OK,
                    Data = user,
                    Message = "User found successfully."
                };
            }
            return Ok(_resultModel);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CreateUpdateUserRequest request)
        {
            // Kiểm tra nếu request là null
            if (request == null)
            {
                return BadRequest(new ResultModel
                {
                    Success = false,
                    Status = (int)System.Net.HttpStatusCode.BadRequest,
                    Message = "Request cannot be null."
                });
            }

            // Kiểm tra dữ liệu đầu vào có hợp lệ không
            if (!ModelState.IsValid)
            {
                return BadRequest(new ResultModel
                {
                    Success = false,
                    Status = (int)System.Net.HttpStatusCode.BadRequest,
                    Message = "Invalid data provided."
                });
            }

            // Kiểm tra số điện thoại đã tồn tại chưa
            var checkUserExisted = await _serviceManager.UserService.CheckPhoneNumerAsync(request.PhoneNumber);
            if (checkUserExisted)
            {
                return BadRequest(new ResultModel
                {
                    Status = (int)System.Net.HttpStatusCode.BadRequest,
                    Success = false,
                    Message = "Your Phone Number Existed."
                });
            }

            // Thêm user mới
            try
            {
                var result = await _serviceManager.UserService.AddUser(request);
            }
            catch (Exception ex)
            {
                // Chỉ trả về thông báo lỗi mà không cần quăng toàn bộ exception
                return BadRequest(new ResultModel { 

                Status = (int)System.Net.HttpStatusCode.OK,
                Success = true,
                Message = ex.Message

                 });
            }
            // if (result == null)
            // {
            //     return NotFound(new ResultModel
            //     {
            //         Success = false,
            //         Status = (int)System.Net.HttpStatusCode.NotFound,
            //         Message = "Failed to add user."
            //     });
            // }


            // Trả về kết quả thành công
            return Ok(new ResultModel
            {
                Status = (int)System.Net.HttpStatusCode.OK,
                Success = true,
                Message = "User added successfully."
            });
        }


        [HttpPut("admin/{userId}")]
        public async Task<ActionResult<ResultModel>> Update(Guid userId, UpdateUserRequest request)
        {
            var update = await _serviceManager.UserService.UpdateUser(userId, request);
            if (update == null)
            {
                //update fail
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)System.Net.HttpStatusCode.NotFound,
                    Message = "Failed to update user."
                });
            }
            // update success
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)System.Net.HttpStatusCode.OK,
                Message = "User updated successfully."
            });
        }

        [HttpPut("customer/{userId}")]
        public async Task<IActionResult> UpdateUserRoleCustomer(Guid userId, UpdateUserRoleCustomerRequest request)
        {
            var update = await _serviceManager.UserService.UpdateUserRoleCustomer(userId, request);
            if (update == null)
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)System.Net.HttpStatusCode.NotFound,
                    Message = "Failed to update."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)System.Net.HttpStatusCode.OK,
                Message = "User information updated successfully."
            });
        }

        [HttpPut("{userId}/password")]
        public async Task<ActionResult<ResultModel>> ChangePassword(Guid userId, string currentPassword, string newPassword)
        {

            var result = await _serviceManager.UserService.ChangePasswordbyId(userId, currentPassword, newPassword);
            if (result)
            {

                return Ok(_resultModel = new ResultModel
                {
                    Success = true,
                    Status = (int)System.Net.HttpStatusCode.OK,
                    Message = "Change password user successfully."
                });
            }
            else
            {
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)System.Net.HttpStatusCode.NotFound,
                    Message = "Failed to change password user."
                });
            }
        }

        [HttpPut("{userId}/avatar")]
        public async Task<ActionResult<ResultModel>> ChangeAvatar([FromBody] ChangeAvatarRequest request, Guid userId)
        {
            var result = await _serviceManager.UserService.ChangeAvatar(userId, request);
            if (!result)
            {
                return BadRequest(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)System.Net.HttpStatusCode.InternalServerError,
                    Message = "Failed to change avatar user."
                });
            }
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)System.Net.HttpStatusCode.OK,
                Message = "Change avatar user successfully."
            });
        }

        [HttpPatch("{userId}/status")]
        public async Task<ActionResult<ResultModel>> ChangeUserStatus(Guid userId)
        {
            // Gọi dịch vụ để tìm người dùng theo ID
            var update = await _serviceManager.UserService.ChangeStatusbyId(userId);

            if (!update)
            {
                //update fail
                return NotFound(_resultModel = new ResultModel
                {
                    Success = false,
                    Status = (int)System.Net.HttpStatusCode.NotFound,
                    Message = "Failed to update user."
                });
            }
            // update success
            return Ok(_resultModel = new ResultModel
            {
                Success = true,
                Status = (int)System.Net.HttpStatusCode.OK,
                Message = "User updated successfully."
            });

        }

    }
}