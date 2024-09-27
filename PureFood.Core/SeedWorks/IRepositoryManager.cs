using PureFood.Core.Repositories;

namespace PureFood.Core.SeedWorks
{
    public interface IRepositoryManager
    {
        ICartItemRepository CartItemRepository { get; }
        ICartRepository CartRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IImageRepository ImageRepository { get; }
        IPromotionRepository ProductRepository { get; }
        IReviewRepository ReviewRepository { get; }
        ISupplierRepository SupplierRepository { get; }
        IUserRepository UserRepository { get; }

        IPromotionRepository PromotionRepository { get; }
        Task SaveAsync();
    }
}
