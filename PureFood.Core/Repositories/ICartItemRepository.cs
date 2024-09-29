using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.SeedWorks;

namespace PureFood.Core.Repositories
{
    public interface ICartItemRepository : IRepositoryBase<CartItem, Guid>
    {
        Task <PaginatedResult<CartItem>>GetAllCartItemByUserAsync(int page , int limit , Guid userId);
    }
}
