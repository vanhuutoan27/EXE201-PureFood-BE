using Microsoft.EntityFrameworkCore;
using PureFood.Core.Domain.Content;
using PureFood.Core.Models.content;
using PureFood.Core.Repositories;
using PureFood.Data.SeedWork;

namespace PureFood.Data.Repositories
{
    public class ProductRepository : RepositoryBase<Product, Guid>, IProductRepository
    {
        public ProductRepository(PureFoodDbContext context) : base(context)
        {
        }

        //public async Task<IEnumerable<Product>> GetAllProductAsync(int page, int limit, string searchName, string categoryName)
        //{
        //    searchName = searchName?.Trim();
        //    categoryName = categoryName?.Trim();
        //    if (string.IsNullOrEmpty(searchName) && string.IsNullOrEmpty(categoryName))
        //    {
        //        if (page > 0 && limit > 0)
        //        {
        //            return await _context.Products.Skip((page - 1) * limit).Take(limit).ToListAsync();
        //        }
        //        return await _context.Products.ToListAsync();
        //    }
        //    else if (!(string.IsNullOrEmpty(searchName)) && (string.IsNullOrEmpty(categoryName)))
        //    {
        //        var listProduct = await _context.Products
        //            .Where((s => s.ProductName.ToLower()
        //            .Contains(searchName.ToLower())))
        //            .Skip((page - 1) * limit).Take(limit).ToListAsync();
        //        return listProduct;
        //    }
        //    else if ((string.IsNullOrEmpty(searchName)) && !(string.IsNullOrEmpty(categoryName)))
        //    {
        //        return await _context.Products.Include(c => c.Category)
        //            .Where(x => x.Category.CategoryName.ToLower()
        //            .Contains(categoryName.ToLower()))
        //            .Skip((page - 1) * limit).Take(limit).ToListAsync();
        //    }
        //    else
        //    {
        //        return await _context.Products
        //            .Where(s => s.ProductName.ToLower().Contains(searchName.ToLower()) &&
        //            s.Category.CategoryName.ToLower().Contains(categoryName.ToLower()))
        //            .Skip((page - 1) * limit).Take(limit).ToListAsync();
        //    }
        //}

        public async Task<PageResult<Product>> GetAllProductAsync(
            int page, int limit, string? searchName, string? categoryName,
            double? minWeight, double? maxWeight, string? unit, decimal? minPrice,
            decimal? maxPrice, string? origin, bool? organic)
        {
            searchName = searchName?.Trim();
            categoryName = categoryName?.Trim();
            unit = unit?.Trim();
            origin = origin?.Trim();

            IQueryable<Product> query = _context.Products.Include(c => c.Category).Include(s => s.Supplier).Include(p => p.Images);

            // filter weight
            if (minWeight.HasValue)
            {
                query = query.Where(c => c.Weight >= minWeight.Value);
            }
            if (maxWeight.HasValue)
            {
                query = query.Where(c => c.Weight <= maxWeight.Value);
            }

            // filter price
            if (minPrice.HasValue)
            {
                query = query.Where(c => c.Price >= minPrice.Value);
            }
            if (maxPrice.HasValue)
            {
                query = query.Where(c => c.Price <= maxPrice.Value);
            }

            // searchName
            if (!string.IsNullOrEmpty(searchName))
            {
                query = query.Where(s => s.ProductName.ToLower().Contains(searchName.ToLower()));
            }

            // categoryName
            if (!string.IsNullOrEmpty(categoryName))
            {
                query = query.Where(s => s.Category.CategoryName.ToLower().Contains(categoryName.ToLower()));
            }

            // filter unit
            if (!string.IsNullOrEmpty(unit))
            {
                query = query.Where(u => u.Unit.ToLower().Contains(unit.ToLower()));
            }

            // filter origin
            if (!string.IsNullOrEmpty(origin))
            {
                query = query.Where(o => o.Origin.ToLower().Contains(origin.ToLower()));
            }

            // filter organic
            if (organic.HasValue)
            {
                query = query.Where(o => o.Organic == organic.Value);
            }

            // get total count
            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            var products = await query.ToListAsync();
            return new PageResult<Product>
            {
                Items = products,
                TotalItems = totalItems,
            };
        }

        public async Task<PageResult<Product>> GetProductByCategoryName(int page, int limit,string categoryName)
        {

                IQueryable<Product> query =  _context.Products.Include(c => c.Category).Include(s => s.Supplier).Include(p => p.Images).Where(c => c.Category.CategoryName == categoryName);

            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            // Execute the query and get the products
            var products = await query.ToListAsync();

            return new PageResult<Product>
            {
                Items = products,
                TotalItems = totalItems,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit), // Calculate total pages
                CurrentPage = page // Set current page
            };
        }

        public async Task<Product> GetProductbyId(Guid id)
        {
            return await _context.Products.Include(p => p.Images).Include(p => p.Category).Include(p => p.Supplier).FirstOrDefaultAsync(p => p.ProductId == id);
        }

        public async Task<Product> GetProductBySlug(string slug)
        {
            return await _context.Products.Include(p => p.Images).Include(p => p.Category).Include(p => p.Supplier).FirstOrDefaultAsync(p => p.Slug == slug);

        }

        public async Task<PageResult<Product>> GetProductBySupplierName(int page, int limit,string supplierName)
        {
            // return await _context.Products.Where(s => s.Supplier.SupplierName == supplierName).ToListAsync();
            IQueryable<Product> query = _context.Products.Include(c => c.Category).Include(s => s.Supplier).Include(p => p.Images).Where(s => s.Supplier.SupplierName == supplierName);

            int totalItems = await query.CountAsync();
            if (page > 0 && limit > 0)
            {
                query = query.Skip((page - 1) * limit).Take(limit);
            }

            // Execute the query and get the products
            var products = await query.ToListAsync();

            return new PageResult<Product>
            {
                Items = products,
                TotalItems = totalItems,
                TotalPages = (int)Math.Ceiling(totalItems / (double)limit), // Calculate total pages
                CurrentPage = page // Set current page
            };
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
            else if (!string.IsNullOrEmpty(searchName) && !string.IsNullOrEmpty(categoryName))
            {
                return await _context.Products
                    .Where(s => s.ProductName.ToLower().Contains(searchName.ToLower()) &&
                    s.Category.CategoryName.ToLower().Contains(categoryName.ToLower())).CountAsync();
            }
            return await _context.Products.CountAsync();
        }
    }
}
