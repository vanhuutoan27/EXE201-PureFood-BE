﻿using PureFood.Core.Models.content.Responses;
﻿using PureFood.Core.Domain.Content;
using PureFood.Core.Models;
using PureFood.Core.Models.Requests;

namespace PureFood.Core.Services
{
    public interface IProductService
    {
        Task<CreateProductRequest> CreateProduct(CreateProductRequest requestProduct);
        Task<ProductRespone> GetProductById(Guid productId);
        Task<PageResult<ProductRespone>> GetAllProduct(int page, int limit, string? searchName, string? categoryName,
            double? minWeight, double? maxWeight, string? unit, decimal? minPrice, decimal? maxPrice, string? origin, bool? organic);
        Task<ProductRespone> GetProductBySlug(string slug);
        Task<bool> UpdateProduct(Guid productId, UpdateProductRequest updateProductRequest);
        Task<bool> DeleteProduct(Guid productId);
        Task<bool> ChangeStatusProduct(Guid productId);
        Task<PageResult<ProductRespone>> GetProductByCategoryName(int page, int limit, string categoryName);
        Task<PageResult<ProductRespone>> GetProductBySupplierName(int page, int limit, string supplierName);
    }
}
