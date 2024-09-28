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
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.HasData(new List<Supplier>()
            {
                new Supplier
                {
                    SupplierId = Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    SuplierName = "PureFood",
                    Address = "Quận 9, Thành phố Hồ Chí Minh",
                    Description = "Chúng tôi cung cấp rau củ quả sạch, tươi ngon từ nông trại đến bàn ăn, đảm bảo an toàn sức khỏe cho gia đình bạn.",
                    PhoneNumber = "0937056922",
                    CreatedAt = DateTime.Now,
                    UpdatedAt = DateTime.Now
                }
            });
        }
    }
}
