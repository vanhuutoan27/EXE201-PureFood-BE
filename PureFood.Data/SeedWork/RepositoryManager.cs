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
        private readonly Lazy<IPromotionRepository> _productRepository;
        private readonly Lazy<IReviewRepository> _reviewRepository;
        private readonly Lazy<ISupplierRepository> _supplierRepository;
        private readonly Lazy<IUserRepository> _userRepository;
        private readonly Lazy<IPromotionRepository> _promotionRepository;


        public RepositoryManager(PureFoodDbContext dbContext)
        {
            _dbContext = dbContext;
            _cartItemRepository = new Lazy<ICartItemRepository>(() => new CartItemRepository(dbContext));
            _cartRepository = new Lazy<ICartRepository>(() => new CartRepository(dbContext));
            _categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(dbContext));
            _imageRepository = new Lazy<IImageRepository>(() => new ImageRepository(dbContext));
            _productRepository = new Lazy<IPromotionRepository>(() => new ProductRepository(dbContext));
            _reviewRepository = new Lazy<IReviewRepository>(() => new ReviewRepository(dbContext));
            _supplierRepository = new Lazy<ISupplierRepository>(() => new SupplierRepository(dbContext));
            _userRepository = new Lazy<IUserRepository>(() => new UserRepository(dbContext));
            _promotionRepository = new Lazy<IPromotionRepository>(() => new PromotionRepository(dbContext));



        }
        public ICartItemRepository CartItemRepository => _cartItemRepository.Value;

        public ICartRepository CartRepository => _cartRepository.Value;

        public ICategoryRepository CategoryRepository => _categoryRepository.Value;

        public IImageRepository ImageRepository => _imageRepository.Value;

        public IPromotionRepository ProductRepository => _productRepository.Value;

        public IReviewRepository ReviewRepository => _reviewRepository.Value;

        public ISupplierRepository SupplierRepository => _supplierRepository.Value;

        public IUserRepository UserRepository => _userRepository.Value;
        public IPromotionRepository PromotionRepository => _promotionRepository.Value;


        public async Task SaveAsync()
        {
            await _dbContext.SaveChangesAsync();
        }
    }
}
