using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Content;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;
using System.ComponentModel.Design;

namespace PureFood.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product, Guid>, IProductRepository
    {
        public ProductRepository(PureFoodDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<Product>> GetAllProductAsync(int page, int limit, string searchName, string categoryName)
        {
            searchName = searchName?.Trim();
            categoryName = categoryName?.Trim();
            if (string.IsNullOrEmpty(searchName) && string.IsNullOrEmpty(categoryName))
            {
                if (page > 0 && limit > 0)
                {
                    return await _context.Products.Skip((page - 1) * limit).Take(limit).ToListAsync();
                }
                return await _context.Products.ToListAsync();
            }
            else if (!(string.IsNullOrEmpty(searchName)) && (string.IsNullOrEmpty(categoryName)))
            {
                var listProduct = await _context.Products
                    .Where((s => s.ProductName.ToLower()
                    .Contains(searchName.ToLower())))
                    .Skip((page - 1) * limit).Take(limit).ToListAsync();
                return listProduct;
            }
            else if ((string.IsNullOrEmpty(searchName)) && !(string.IsNullOrEmpty(categoryName)))
            {
                return await _context.Products.Include(c => c.Category)
                    .Where(x => x.Category.CategoryName.ToLower()
                    .Contains(categoryName.ToLower()))
                    .Skip((page - 1) * limit).Take(limit).ToListAsync();
            }
            else
            {
                return await _context.Products
                    .Where(s => s.ProductName.ToLower().Contains(searchName.ToLower()) &&
                    s.Category.CategoryName.ToLower().Contains(categoryName.ToLower()))
                    .Skip((page - 1) * limit).Take(limit).ToListAsync();
            }
        }

        public Task<Product> GetProductBySlug(string slug)
        {
            return _context.Products.FirstOrDefaultAsync(s => s.Slug == slug);
        }

        public async Task<IEnumerable<Product>> GetProductBySupplierId(Guid supplierId)
        {
            return await _context.Products.Where(s => s.SupplierId == supplierId).ToListAsync();
        }

        public async Task<int> GetTotalProductCountAsync(string? searchName, string? categoryName)
        {
            if (!string.IsNullOrEmpty(searchName) && string.IsNullOrEmpty(categoryName))
            {
                return await _context.Products
                    .Where(s => s.ProductName.ToLower().Contains(searchName.ToLower().Trim())).CountAsync();
            }
            else if (string.IsNullOrEmpty(searchName) && !string.IsNullOrEmpty(categoryName))
            {
                return await _context.Products
                    .Where(s => s.Category.CategoryName.ToLower().Contains(categoryName.ToLower().Trim())).CountAsync();
            } 
            else if(!string.IsNullOrEmpty(searchName) && !string.IsNullOrEmpty(categoryName))
            {
                return await _context.Products
                    .Where(s => s.ProductName.ToLower().Contains(searchName.ToLower()) &&
                    s.Category.CategoryName.ToLower().Contains(categoryName.ToLower())).CountAsync();
            }
            return await _context.Products.CountAsync();
        }
    }
}
