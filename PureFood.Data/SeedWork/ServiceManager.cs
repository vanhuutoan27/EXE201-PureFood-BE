using AutoMapper;
using Microsoft.AspNetCore.Identity;
using PureFood.Core.Domain.Identity;
using PureFood.Core.SeedWorks;
using PureFood.Core.Services;
using PureFood.Data.Service;

namespace PureFood.Data.SeedWork
{
    public class ServiceManager : IServiceManager
    {
        private readonly Lazy<ICartItemService> _cartItemService;
        private readonly Lazy<ICartService> _cartService;
        private readonly Lazy<ICategoryService> _categoryService;
        private readonly Lazy<IImageService> _imageService;
        private readonly Lazy<IProductService> _productService;
        private readonly Lazy<IReviewService> _reviewService;
        private readonly Lazy<ISupplierService> _supplierService;
        private readonly Lazy<IUserService> _userService;
        private readonly Lazy<IPromotionService> _promotionService;
        private readonly Lazy<IOrderService> _orderService;
        private readonly Lazy<IPaymentService> _paymentService;

        public ServiceManager(IRepositoryManager repositoryManager, IMapper mapper, UserManager<AppUser> userManager)
        {
            _cartItemService = new Lazy<ICartItemService>(() => new CartItemService(repositoryManager, mapper));
            _cartService = new Lazy<ICartService>(() => new CartService(repositoryManager, mapper));
            _categoryService = new Lazy<ICategoryService>(() => new CategoryService(repositoryManager, mapper));
            _imageService = new Lazy<IImageService>(() => new ImageService(repositoryManager, mapper));
            _productService = new Lazy<IProductService>(() => new ProductService(repositoryManager, mapper));
            _reviewService = new Lazy<IReviewService>(() => new ReviewService(repositoryManager, mapper));
            _supplierService = new Lazy<ISupplierService>(() => new SupplierService(repositoryManager, mapper));
            _userService = new Lazy<IUserService>(() => new UserService(userManager, repositoryManager, mapper));
            _promotionService = new Lazy<IPromotionService>(() => new PromotionService(repositoryManager, mapper));
            _orderService = new Lazy<IOrderService>(() => new OrderService(repositoryManager, mapper));
            _paymentService = new Lazy<IPaymentService>(() => new PaymentService(repositoryManager , mapper ));

        }
        public ICartItemService CartItemService => _cartItemService.Value;

        public ICartService CartService => _cartService.Value;

        public ICategoryService CategoryService => _categoryService.Value;

        public IImageService ImageService => _imageService.Value;

        public IProductService ProductService => _productService.Value;

        public IReviewService ReviewService => _reviewService.Value;

        public ISupplierService SupplierService => _supplierService.Value;

        public IUserService UserService => _userService.Value;

        public IPromotionService PromotionService => _promotionService.Value;

        public IOrderService OrderService => _orderService.Value;

        public IPaymentService PaymentService => _paymentService.Value;
    }
}
