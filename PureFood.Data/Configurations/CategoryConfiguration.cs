using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PureFood.Core.Domain.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PureFood.Data.Configurations
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new List<Category>()
            {
                new Category
                {
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    CategoryName = "Rau củ",
                    Description = "Rau củ quả ngon lành",
                    CreatedAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                },
                new Category
                {
                    CategoryId = Guid.Parse("6b5f6458-3791-4303-8ee7-e20707e4cf3e"),
                    CategoryName = "Trái cây",
                    Description = "Trái cây tươi mới",
                    CreatedAt = DateTime.Now,
                    UpdateAt = DateTime.Now,
                }
            });
        }
    }
}
