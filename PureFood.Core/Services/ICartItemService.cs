using PureFood.Core.Domain.Content;
using PureFood.Core.Models;
using PureFood.Core.Models.Requests;
using PureFood.Core.Models.Respones;

namespace PureFood.Core.Services
{
    public interface ICartItemService
    {
        Task<bool>DeleteCartItem(Guid cartItemId);
        Task<bool>UpdateCartItem(UpdateCartItemRequest request , Guid cartItemId);
       Task<PageResult<CartItemResponee>> GetAllCartItemByUser(int page, int limit, Guid UserId);
    }
}
