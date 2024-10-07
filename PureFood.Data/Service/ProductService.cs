using AutoMapper;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content.Responses;
using PureFood.Core.Models.Requests;

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
            var category = await _repositoryManager.CategoryRepository.GetCategoryByName(requestProduct.CategoryName);
            if (category == null) { throw new Exception("Không tìm thấy danh mục."); }
            var supplier = await _repositoryManager.SupplierRepository.GetSupplierByName(requestProduct.SupplierName);
            if (supplier == null) { throw new Exception("Không tìm thấy nhà cung cấp."); }

            try
            {
                var newProduct = new Product()
                {
                    ProductId = Guid.NewGuid(),
                    ProductName = requestProduct.ProductName,
                    Slug = resultSlug,
                    Description = requestProduct.Description,
                    Price = requestProduct.Price,
                    Stock = requestProduct.Stock,
                    Weight = requestProduct.Weight,
                    Unit = requestProduct.Unit,
                    Origin = requestProduct.Origin,
                    Organic = requestProduct.Organic,
                    Status = false,
                    EntryDate = requestProduct.EntryDate,
                    ExpiryDate = requestProduct.ExpiryDate,
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now,
                    FoodName = requestProduct.FoodName,
                    CategoryId = category.CategoryId,
                    SupplierId = supplier.SupplierId,

                };
                // image
                foreach(var imageUrl in requestProduct.Images)
                {
                    var image = new Image
                    {
                        ImageId = Guid.NewGuid(),
                        ProductId = newProduct.ProductId,
                        Url = imageUrl,
                        CreatedAt = DateTime.Now,
                        UpdatedAt = DateTime.Now,
                    };
                    _repositoryManager.ImageRepository.Add(image);
                }
                _repositoryManager.ProductRepository.Add(newProduct);
                await _repositoryManager.SaveAsync();
                var result = _mapper.Map<CreateProductRequest>(newProduct);
                return result;
            }
            catch (Exception ex)
            {
                throw new Exception("Thêm thất bại" + ex.Message);
            }

        }

        public async Task<PageResult<ProductRespone>> GetAllProduct(
     int page,
     int limit,
     string? searchName,
     string? categoryName,
     double? minWeight,
     double? maxWeight,
     string? unit,
     decimal? minPrice,
     decimal? maxPrice,
     string? origin,
     bool? organic)
        {
            try
            {
                var listProduct = await _repositoryManager.ProductRepository.GetAllProductAsync(
                    page, limit, searchName, categoryName, minWeight, maxWeight, unit, minPrice, maxPrice, origin, organic);

                // Map the list of products to ProductRespone
                var productResponse = _mapper.Map<IEnumerable<ProductRespone>>(listProduct.Items).ToList();

                return new PageResult<ProductRespone>
                {
                    CurrentPage = page,
                    TotalItems = listProduct.TotalItems,
                    TotalPages = (int)Math.Ceiling(listProduct.TotalItems / (double)limit),
                    Items = productResponse // Ensure it's a list
                };
            }
            catch (Exception ex)
            {
                throw new Exception("Lỗi" + ex.Message);
            }
        }

        public async Task<ProductRespone> GetProductById(Guid productId)
        {
            var product = await _repositoryManager.ProductRepository.GetProductbyId(productId);
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
                // tim category bang ten
                var category = await _repositoryManager.CategoryRepository.GetCategoryByName(updateProductRequest.Category);
                if (category == null)
                {
                    throw new Exception("Không tìm thấy danh mục với tên: " + updateProductRequest.Category);
                }

                // tim supplier bang ten
                var supplier = await _repositoryManager.SupplierRepository.GetSupplierByName(updateProductRequest.Supplier);
                if (supplier == null)
                {
                    throw new Exception("Không tìm thấy nhà cung cấp với tên: " + updateProductRequest.Supplier);
                }
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
                product.CategoryId = category.CategoryId;
                product.SupplierId = supplier.SupplierId;
                product.UpdatedAt = DateTime.Now;

                _repositoryManager.ProductRepository.Update(product);
                await _repositoryManager.SaveAsync();
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Cập nhật sản phẩm thất bại" + ex.Message);
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
            }
            else
            {
                product.Status = false;
            }
            _repositoryManager.ProductRepository.Update(product);
            await _repositoryManager.SaveAsync();
            return true;
        }

        public async Task<PageResult<ProductRespone>> GetProductByCategoryName(int page, int limit, string categoryId)
        {
            var product = await _repositoryManager.ProductRepository.GetProductByCategoryName(page, limit, categoryId);
            if (product == null)
            {
                throw new Exception("Không tìm thấy danh mục.");
            }
            var result = _mapper.Map<IEnumerable<ProductRespone>>(product.Items);

            return new PageResult<ProductRespone>
            {
                CurrentPage = page,
                TotalItems = product.TotalItems,
                TotalPages = (int)Math.Ceiling(product.TotalItems / (double)limit),
                Items = result
            };
        }

        public async Task<PageResult<ProductRespone>> GetProductBySupplierName(int page, int limit, string supplierId)
        {
            var product = await _repositoryManager.ProductRepository.GetProductBySupplierName(page, limit, supplierId);
            if (product == null)
            {
                throw new Exception("Không tìm thấy nhà cung cấp.");
            }
            var result = _mapper.Map<IEnumerable<ProductRespone>>(product.Items);

            return new PageResult<ProductRespone>
            {
                CurrentPage = page,
                TotalItems = product.TotalItems,
                TotalPages = (int)Math.Ceiling(product.TotalItems / (double)limit),
                Items = result.ToList()
            };
        }
    }
}
