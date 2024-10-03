using PureFood.Core.Repositories;
using PureFood.Core.SeedWorks;
using PureFood.Data.Repositories;

namespace PureFood.Data.SeedWork
{
    public class RepositoryManager : IRepositoryManager
    {
        private readonly PureFoodDbContext _dbContext;
        private readonly Lazy<ICartItemRepository> _cartItemRepository;
        private readonly Lazy<ICartRepository> _cartRepository;
        private readonly Lazy<ICategoryRepository> _categoryRepository;
        private readonly Lazy<IImageRepository> _imageRepository;
        private readonly Lazy<IProductRepository> _productRepository;
        private readonly Lazy<IReviewRepository> _reviewRepository;
        private readonly Lazy<ISupplierRepository> _supplierRepository;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IPromotionRepository> _promotionRepository;
        private readonly Lazy<IOrderRepository> _orderRepository;
        private readonly Lazy<IOrderItemRepository> _orderItemRepository;


        public RepositoryManager(PureFoodDbContext dbContext)
        {
            _dbContext = dbContext;
            _cartItemRepository = new Lazy<ICartItemRepository>(() => new CartItemRepository(dbContext));
            _cartRepository = new Lazy<ICartRepository>(() => new CartRepository(dbContext));
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(dbContext));
            _imageRepository = new Lazy<IImageRepository>(() => new ImageRepository(dbContext));
            _productRepository = new Lazy<IProductRepository>(() => new ProductRepository(dbContext));
            _reviewRepository = new Lazy<IReviewRepository>(() => new ReviewRepository(dbContext));
            _supplierRepository = new Lazy<ISupplierRepository>(() => new SupplierRepository(dbContext));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(dbContext));
            _promotionRepository = new Lazy<IPromotionRepository>(() => new PromotionRepository(dbContext));
            _orderRepository = new Lazy<IOrderRepository>(() => new OrderRepository(dbContext));
            _orderItemRepository = new Lazy<IOrderItemRepository>(() => new OrderItemRepository(dbContext));


        }
        public ICartItemRepository CartItemRepository => _cartItemRepository.Value;

        public ICartRepository CartRepository => _cartRepository.Value;

        public ICategoryRepository CategoryRepository => _categoryRepository.Value;

        public IImageRepository ImageRepository => _imageRepository.Value;

        public IProductRepository ProductRepository => _productRepository.Value;

        public IReviewRepository ReviewRepository => _reviewRepository.Value;

        public ISupplierRepository SupplierRepository => _supplierRepository.Value;

        public IUserRepository UserRepository => _userRepository.Value;
        public IPromotionRepository PromotionRepository => _promotionRepository.Value;

        public IOrderRepository OrderRepository => _orderRepository.Value;

        public IOrderItemRepository OrderItemRepository => _orderItemRepository.Value;

        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
