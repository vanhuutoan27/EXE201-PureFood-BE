using AutoMapper;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models;
using PureFood.Core.Models.Requests;
using PureFood.Core.Models.Respones;
using PureFood.Core.SeedWorks;
using PureFood.Core.Services;
using System.Text;

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

        // method
        private string GenerateRandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            var random = new Random();
            return new string(Enumerable.Repeat(chars, length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        private string GenerateSlug(string productName)
        {
            // Looai bo dau tieng Viet, thay khoang trang thanh dau -
            var slug = productName.ToLower()
                                  .Replace(" ", "-")
                                  .Normalize(NormalizationForm.FormD)
                                  .Where(c => char.IsLetterOrDigit(c) || c == '-')
                                  .ToArray();

            return new string(slug);
        }
            public async Task<CreateProductRequest> CreateProduct(CreateProductRequest requestProduct)
        {
            // tao 6 ky tu ngau nhien
            var randomSuffix = GenerateRandomString(6).ToLower();
            // tao slug
            var slug = GenerateSlug(requestProduct.ProductName);
            var resultSlug = $"{slug}-{randomSuffix}";
            try
            {
                var createProduct = _mapper.Map<Product>(requestProduct);
                var newProduct = new Product()
                {
                    ProductId = Guid.NewGuid(),
                    ProductName = createProduct.ProductName,
                    Slug = resultSlug,
                    Description = createProduct.Description,
                    Price = createProduct.Price,
                    Stock = createProduct.Stock,
                    Weight = createProduct.Weight,
                    Unit = createProduct.Unit,
                    Origin = createProduct.Origin,
                    Organic = createProduct.Organic,
                    Status = false,
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

        public async Task<PageResult<ProductRespone>> GetAllProduct(int page, int limit, string? searchName, string? categoryName,
            double? minWeight, double? maxWeight, string? unit, decimal? minPrice, decimal? maxPrice, string? origin, bool? organic)
        {
            try
            {
                var listProduct = await _repositoryManager.ProductRepository.GetAllProductAsync(page, limit, searchName, categoryName, 
                    minWeight, maxWeight, unit, minPrice, maxPrice, origin, organic);
                var productRespone = new List<ProductRespone>();
                foreach (var product in listProduct.Items)
                {
                    productRespone.Add(new ProductRespone
                    {
                        ProductId = product.ProductId,
                        ProductName = product.ProductName,
                        Slug = product.Slug,
                        Description = product.Description,
                        Price = product.Price,
                        Stock = product.Stock,
                        Weight = product.Weight,
                        Unit = product.Unit,
                        Origin = product.Origin,
                        Organic = product.Organic,
                        Status = product.Status,
                        EntryDate = product.EntryDate,
                        ExpiryDate = product.ExpiryDate,
                        Category = product.Category.CategoryName,
                        Supplier = product.Supplier.SuplierName,
                        CreatedAt = product.CreatedAt,
                        UpdateAt = product.UpdateAt,
                        CreatedBy = product.CreatedBy,
                        UpdatedBy = product.UpdatedBy,
                    });
                }

                return new PageResult<ProductRespone>
                {
                    CurrentPage = page,
                    TotalItems = listProduct.TotalItems,
                    TotalPages = (int)Math.Ceiling(listProduct.TotalItems / (double)limit),
                    Items = productRespone
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

        public async Task<ProductRespone> GetProductBySlug(string slug)
        {
            var product = await _repositoryManager.ProductRepository.GetProductBySlug(slug);
            var result = _mapper.Map<ProductRespone>(product);
            return result;
        }

        public async Task<bool> UpdateProduct(Guid productId, UpdateProductRequest updateProductRequest)
        {
            try
            {
                var product = await _repositoryManager.ProductRepository.GetByIdAsync(productId);
                product.ProductName = updateProductRequest.ProductName;
                product.Description = updateProductRequest.Description;
                product.Price = updateProductRequest.Price;
                product.Stock = updateProductRequest.Stock;
                product.Weight = updateProductRequest.Weight;
                product.Unit = updateProductRequest.Unit;
                product.Origin = updateProductRequest.Origin;
                product.Organic = updateProductRequest.Organic;
                product.EntryDate = updateProductRequest.EntryDate;
                product.ExpiryDate = updateProductRequest.ExpiryDate;
                product.CategoryId = updateProductRequest.CategoryId;
                product.SupplierId = updateProductRequest.SupplierId;
                product.UpdateAt = DateTime.Now;

                _repositoryManager.ProductRepository.Update(product);
                await _repositoryManager.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Update product !" + ex.Message);
            }
            
        }

        public async Task<bool> DeleteProduct(Guid productId)
        {
            var product = await _repositoryManager.ProductRepository.GetByIdAsync(productId);
            _repositoryManager.ProductRepository.Remove(product);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<bool> ChangeStatusProduct(Guid productId)
        {
            var product = await _repositoryManager.ProductRepository.GetByIdAsync(productId);
            if (product.Status == false)
            {
                product.Status = true;
            } else
            {
                product.Status = false;
            }
            _repositoryManager.ProductRepository.Update(product);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<IEnumerable<ProductRespone>> GetProductByCategoryId(Guid categoryId)
        {
            var product = await _repositoryManager.ProductRepository.GetProductByCategoryid(categoryId);
            var result = _mapper.Map<IEnumerable<ProductRespone>>(product);
            return result;
        }
    }
}
