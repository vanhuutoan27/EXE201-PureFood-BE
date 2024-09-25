using PureFood.Core.Repositories;

namespace PureFood.Core.SeedWorks
{
    public interface IRepositoryManager
    {
        ICartItemRepository CartItemRepository { get; }
        ICartRepository CartRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IImageRepository ImageRepository { get; }
        IProductRepository ProductRepository { get; }
        IReviewRepository ReviewRepository { get; }
        ISupplierRepository SupplierRepository { get; }
        IUserRepository UserRepository { get; }
        Task SaveAsync();
    }
}
