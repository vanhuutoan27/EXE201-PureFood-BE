
using PureFood.Core.Models.content.Responses;
using PureFood.Core.Models.Requests;


namespace PureFood.Core.Services
{
    public interface ICartService
    {
        Task<CreateCartRequest> CreateCartAsync(CreateCartRequest request);
        Task<PageResult<CartResponse>> GetAllCartsByUser(Guid user, int itemPage, int itemLimit);
        Task<bool> DeleteCartByUserId(Guid userId);
    }
}


