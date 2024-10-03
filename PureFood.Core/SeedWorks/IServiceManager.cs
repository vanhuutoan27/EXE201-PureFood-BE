using PureFood.Core.Services;

namespace PureFood.Core.SeedWorks
{
    public interface IServiceManager
    {
        ICartItemService CartItemService { get; }
        ICartService CartService { get; }
        ICategoryService CategoryService { get; }
        IImageService ImageService { get; }
        IProductService ProductService { get; }
        IReviewService ReviewService { get; }
        ISupplierService SupplierService { get; }
        IUserService UserService { get; }
        IPromotionService PromotionService { get; }
        IOrderService OrderService { get; }

    }
}
