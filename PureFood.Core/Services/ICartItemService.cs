

using PureFood.Core.Models.content.Responses;
using PureFood.Core.Models.Requests;


namespace PureFood.Core.Services
{
    public interface ICartItemService
    {
        Task<bool> DeleteCartItem(Guid cartItemId);
        Task<bool> UpdateCartItem(Guid cartItemId, int Quantity);
        Task<PageResult<CartItemResponee>> GetAllCartItemByUser(Guid UserId, int page, int limit);
    }
}
