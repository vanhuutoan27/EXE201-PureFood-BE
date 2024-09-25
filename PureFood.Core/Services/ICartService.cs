using PureFood.Core.Models;
using PureFood.Core.Models.Requests;
using PureFood.Core.Models.Respones;

namespace PureFood.Core.Services
{
    public interface ICartService
    {
       Task<CreateCartRequest> CreateCartAsync(CreateCartRequest request);
      Task<PageResult<CartResponse>> GetAllCartsByUser(Guid user, int itemPage, int itemLimit);
    }
}
