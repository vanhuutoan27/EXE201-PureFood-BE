using AutoMapper;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models;
using PureFood.Core.Models.Requests;
using PureFood.Core.Models.Respones;
using PureFood.Core.SeedWorks;
using PureFood.Core.Services;

namespace PureFood.Data.Service
{
    public class ProductService : IProductService
    {
        private readonly IRepositoryManager _repositoryManager;
        private readonly IMapper _mapper;
        public ProductService(IRepositoryManager repositoryManager, IMapper mapper)
        {
            _repositoryManager = repositoryManager;
            _mapper = mapper;
        }

        public async Task<CreateProductRequest> CreateProduct(CreateProductRequest requestProduct)
        {
            try
            {
                var createProduct = _mapper.Map<Product>(requestProduct);
                var newProduct = new Product()
                {
                    ProductId = Guid.NewGuid(),
                    ProductName = createProduct.ProductName,
                    Description = createProduct.Description,
                    Price = createProduct.Price,
                    Stock = createProduct.Stock,
                    Weight = createProduct.Weight,
                    Unit = createProduct.Unit,
                    Origin = createProduct.Origin,
                    Organic = createProduct.Organic,
                    Status = createProduct.Status,
                    EntryDate = createProduct.EntryDate,
                    ExpiryDate = createProduct.ExpiryDate,
                    CreatedAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                    CategoryId = createProduct.CategoryId,
                    SupplierId = createProduct.SupplierId
                };
                _repositoryManager.ProductRepository.Add(newProduct);
                await _repositoryManager.SaveAsync();
                var result = _mapper.Map<CreateProductRequest>(requestProduct);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Add Error!" + ex.Message);
            }
            
        }

        public async Task<PageResult<ProductRespone>> GetAllProduct(int page, int limit, string? searchName, string? categoryName)
        {
            try
            {
                var listProduct = await _repositoryManager.ProductRepository.GetAllProductAsync(page, limit, searchName, categoryName);
                var listResult = _mapper.Map<IEnumerable<ProductRespone>>(listProduct);
                var totalProduct = await _repositoryManager.ProductRepository.GetTotalProductCountAsync(searchName, categoryName);
                return new PageResult<ProductRespone>
                {
                    CurrentPage = page,
                    TotalItems = totalProduct,
                    TotalPages = (int)Math.Ceiling(totalProduct / (double)limit),
                    Items = listResult
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Error!" + ex.Message);
            }       
        }

        public async Task<ProductRespone> GetProductById(Guid productId)
        {
            var product = await _repositoryManager.ProductRepository.GetByIdAsync(productId);
            return _mapper.Map<ProductRespone>(product);
        }
    }
}
