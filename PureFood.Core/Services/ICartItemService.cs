

using PureFood.Core.Models.content.Responses;
using PureFood.Core.Models.Requests;


namespace PureFood.Core.Services
{
    public interface ICartItemService
    {
        Task<bool>DeleteCartItem(Guid cartItemId);
        Task<bool>UpdateCartItem(UpdateCartItemRequest request , Guid cartItemId);
       Task<PageResult<CartItemResponee>> GetAllCartItemByUser(int page, int limit, Guid UserId);
    }
}
