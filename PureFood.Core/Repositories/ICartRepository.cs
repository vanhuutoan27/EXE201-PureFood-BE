using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.SeedWorks;

namespace PureFood.Core.Repositories
{
    public interface ICartRepository : IRepositoryBase<Cart, Guid>
    {
        Task<PaginatedResult<Cart>> GetAllCartByuserAsync(int page, int limit ,Guid userId);
        Task<Cart>GetCartByUser(Guid userId);
    }
}
