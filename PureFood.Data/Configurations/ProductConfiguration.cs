using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PureFood.Core.Domain.Content;

namespace PureFood.Data.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(new List<Product>()
            {
                new Product()
                {
                    ProductId = Guid.Parse("0E758EAA-331B-409A-B09A-335CDB16A1F5"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Rau muống",
                    Slug = "rau-muong-400-gr-zk7dwx",
                    Description = "<p>Rau muống tươi ngon, giàu chất xơ, sản phẩm sạch từ nông trại, có nhiều giá trị dinh dưỡng.</p><br>   <ul><br>      " +
                    "<li>Giàu chất xơ, tốt cho hệ tiêu hóa</li><br>      <li>Giàu vitamin A và C</li><br>      <li>Không thuốc bảo vệ thực vật</li><br>     " +
                    " <li>Thích hợp chế biến các món xào, nấu canh</li><br>      <li>Được trồng tại các nông trại xanh</li><br>    </ul>",
                    Price = 8000,
                    FoodName = "Water spinach",
                    Stock = 100,
                    Weight = 400,
                    Unit = "Gr",
                    Origin = "Long An",
                    Organic = true,
                    Status = true
                },
                new Product()
                {
                    ProductId = Guid.Parse("487ca896-ab72-4735-bee9-1b6a42ec3be6"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Bắp cải",
                    Slug = "bap-cai-500-gr-rkwi1a",
                    Description = "<p>Bắp cải tươi ngon, giòn ngọt, sản phẩm hữu cơ giàu vitamin và chất xơ.</p><br><ul><br>  <li>Giàu vitamin K và C, tốt cho sức khỏe xương và hệ miễn dịch</li><br>  <li>Hàm lượng chất chống oxy hóa cao</li><br> <li>Không sử dụng thuốc trừ sâu</li><br>  <li>Thích hợp chế biến món luộc, xào và salad</li><br>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>",
                    Price = 12500,
                    Stock = 100,
                    FoodName = "Cabbage",
                    Weight = 500,
                    Unit = "Gr",
                    Origin = "Lâm Đồng",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("30cfb1b3-da69-4a84-b94c-07ffe79597e0"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Giá sống",
                    Slug = "gia-song-200-gr-fb1ihn",
                    Description = "<p>Giá sống tươi mát, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu chất xơ và vitamin E</li><br>  <li>Tốt cho hệ tiêu hóa và làn da</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Dùng trong các món gỏi, xào, và phở</li><br>  <li>Được trồng tại các nông trại xanh</li><br></ul>",
                    Price = 6800,
                    Stock = 100,
                    FoodName = "Bean sprouts",
                    Weight = 200,
                    Unit = "Gr",
                    Origin = "Tiền Giang",
                    Organic = true,
                    Status = true
                },
                new Product()
                {
                    ProductId = Guid.Parse("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Giá sống",
                    Slug = "nam-kim-cham-150-gr-edwynx",
                    Description = "<p>Nấm kim châm tươi ngon, giàu protein và vitamin, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu protein, tốt cho sức khỏe tổng thể</li><br>  <li>Chứa nhiều vitamin B và chất chống oxy hóa</li><br>  <li>Không chứa chất hóa học</li><br>  <li>Thích hợp dùng trong lẩu, xào, và món súp</li><br> <li>Trồng tại các nông trại sạch</li><br></ul>",
                    Price = 11000,
                    Stock = 100,
                    FoodName = "Enoki mushrooms",
                    Weight = 150,
                    Unit = "Gr",
                    Origin = "Tp.Hồ Chí Minh",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("d3fd8b9e-ff11-4c14-a453-edfd58f05135"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Cà rốt",
                    Slug = "ca-rot-500-gr-xhj7ec",
                    Description = "<p>Cà rốt tươi ngon, ngọt lành, giàu vitamin A và chất chống oxy hóa.</p><br><ul><br>  <li>Giàu vitamin A, tốt cho mắt</li><br>  <li>Hàm lượng chất chống oxy hóa cao</li><br>  <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp cho món nước ép, nấu canh và xào</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>",
                    Price = 11500,
                    Stock = 100,
                    FoodName = "Carrot",
                    Weight = 500,
                    Unit = "Gr",
                    Origin = "Lâm Đồng",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Củ dền",
                    Slug = "cu-den-500-gr-wxels8",
                    Description = "<p>Củ dền tươi, giàu vitamin và khoáng chất, thích hợp cho các món ăn bổ dưỡng.</p><br><ul><br>  <li>Giàu folate và chất sắt, tốt cho máu</li><br>  <li>Chứa nhiều chất chống oxy hóa</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp cho nước ép, nấu canh và salad</li><br>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>",
                    Price = 22500,
                    FoodName = "Beetroot",
                    Stock = 100,
                    Weight = 500,
                    Unit = "Gr",
                    Origin = "Lâm Đồng",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("a5c11a08-497c-4846-b922-bb8a95078dd1"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Hành tím",
                    Slug = "hanh-tim-200-gr-aw4230",
                    Description = "<p>Hành tím tươi, vị thơm nồng, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu vitamin C và chất xơ</li><br>  <li>Có tính kháng viêm tự nhiên</li><br> <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp làm gia vị trong nhiều món ăn</li><br>  <li>Được trồng tại nông trại sạch</li><br></ul>",
                    Price = 15000,
                    FoodName = "Red onion",
                    Stock = 100,
                    Weight = 200,
                    Unit = "Gr",
                    Origin = "Sóc Trăng",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("25134650-be13-43de-bc40-22a9ea54b543"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Hành tây",
                    Slug = "hanh-tay-500-gr-xowt5w",
                    Description = "<p>Hành tây tươi, giòn ngọt, giàu vitamin và khoáng chất, thích hợp cho nhiều món ăn.</p><br><ul><br>  <li>Giàu vitamin C và chất chống oxy hóa</li>\r\n  <li>Có tác dụng kháng viêm, tốt cho sức khỏe</li><br>  <li>Không thuốc trừ sâu</li><br>  <li>Thích hợp nấu canh, xào và làm salad</li><br>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>",
                    Price = 8750,
                    FoodName = "Onion",
                    Stock = 100,
                    Weight = 500,
                    Unit = "Gr",
                    Origin = "Lâm Đồng",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Tỏi cô đơn",
                    Slug = "toi-co-don-200-gr-9rmr8t",
                    Description = "<p>Tỏi tươi, vị cay nồng, giàu chất chống oxy hóa, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu chất chống oxy hóa và kháng khuẩn</li><br>  <li>Giúp tăng cường hệ miễn dịch</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp làm gia vị trong các món ăn</li><br>  <li>Trồng tại các nông trại sạch</li><br></ul>",
                    Price = 32000,
                    FoodName = "Garlic",
                    Stock = 100,
                    Weight = 200,
                    Unit = "Gr",
                    Origin = "Kiên Giang",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("8212e748-fe88-40af-894e-708a376f4fa7"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Khoai môn",
                    Slug = "khoai-mon-500-gr-8q8nq9",
                    Description = "<p>Khoai môn tươi ngon, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul>\r\n  <li>Giàu chất xơ và vitamin B6</li><br>  <li>Tốt cho hệ tiêu hóa và tim mạch</li><br>  <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp cho các món nấu, chiên, và hầm</li><br>  <li>Được trồng tại các nông trại hữu cơ</li><br></ul>",
                    Price = 26000,
                    FoodName = "Taro",
                    Stock = 100,
                    Weight = 500,
                    Unit = "Gr",
                    Origin = "Bạc Liêu",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("6404ba59-9c63-4192-889b-3448cd7c9ba0"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Khoai tây",
                    Slug = "khoai-tay-1-kg-0sls2y",
                    Description = "<p>Khoai tây tươi, giàu dinh dưỡng, thích hợp cho nhiều món ăn.</p><br><ul><br>  <li>Giàu vitamin C và chất xơ</li><br>  <li>Hàm lượng chất chống oxy hóa cao</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp cho các món chiên, nướng, và hầm</li><br>  <li>Được trồng tại nông trại sạch</li><br></ul>",
                    Price = 30000,
                    FoodName = "Potato",
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Lâm Đồng",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("7a684d3b-8e9f-4f06-a767-d59c1953f249"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Khoai lang",
                    Slug = "khoai-lang-1-kg-hu8kgx",
                    Description = "<p>Khoai lang ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul>\r\n  <li>Giàu vitamin A và chất xơ</li>\r\n  <li>Tốt cho hệ tiêu hóa và sức khỏe mắt</li>\r\n  <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp nướng, luộc và làm súp</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>",
                    Price = 34000,
                    FoodName = "Sweet potato",
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Vĩnh Long",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Gừng",
                    Slug = "gung-50-gr-vc4465",
                    Description = "<p>Gừng tươi, thơm nồng, giàu chất chống oxy hóa, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu chất chống viêm và kháng khuẩn</li><br>  <li>Giúp tăng cường hệ miễn dịch và hỗ trợ tiêu hóa</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp làm gia vị cho nhiều món ăn</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>",
                    Price = 4250,
                    FoodName = "Ginger",
                    Stock = 100,
                    Weight = 50,
                    Unit = "Kg",
                    Origin = "Lâm Đồng",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("2adef94c-fa06-4369-89ab-34e71052368e"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Củ cải trắng",
                    Slug = "cu-cai-trang-500-gr-8irui7",
                    Description = "<p>Củ cải trắng tươi ngon, giòn ngọt, giàu vitamin và khoáng chất.</p><br><ul><br>  <li>Giàu vitamin C, tốt cho sức khỏe tổng thể</li><br>  <li>Chứa nhiều chất chống oxy hóa</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp làm nộm, nấu canh và xào</li><br>  <li>Trồng tại các nông trại sạch</li><br></ul>",
                    Price = 10450,
                    FoodName = "Daikon radish",
                    Stock = 100,
                    Weight = 500,
                    Unit = "Gr",
                    Origin = "Lâm Đồng",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Củ sắn",
                    Slug = "cu-san-500-gr-uv72km",
                    Description = "<p>Củ sắn tươi, ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu vitamin C và chất xơ</li><br>  <li>Tốt cho hệ tiêu hóa</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp nấu canh, xào và làm salad</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>",
                    Price = 11500,
                    FoodName = "Jicama",
                    Stock = 100,
                    Weight = 500,
                    Unit = "Gr",
                    Origin = "Tây Ninh",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("fc727800-963c-4305-93a0-3b27dfb1d734"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Bơ Booth",
                    Slug = "bo-booth-1-kg-n0390m",
                    Description = "<p>Bơ Booth tươi ngon, giàu dinh dưỡng, chứa nhiều chất béo lành mạnh.</p><br><ul><br>  <li>Giàu chất béo không bão hòa, tốt cho tim mạch</li><br>  <li>Chứa nhiều vitamin E và chất xơ</li><br>  <li>Không hóa chất bảo quản</li><br>  <li>Thích hợp làm sinh tố, salad và ăn trực tiếp</li><br>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>",
                    Price = 26000,
                    FoodName = "Avocado",
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Lâm Đồng",
                    Organic = true,
                    Status = true

                },

                new Product()
                {
                    ProductId = Guid.Parse("ba9968e6-4ad4-406c-9268-28acd686f73c"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Hành lá",
                    Slug = "hanh-la-100-gr-hx03dw",
                    Description = "<p>Hành lá tươi, xanh non, giàu vitamin và khoáng chất, sản phẩm sạch từ nông trại.</p><br><ul><br> <li>Giàu vitamin A và C</li><br>  <li>Tốt cho sức khỏe mắt và hệ miễn dịch</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp làm gia vị cho nhiều món ăn</li><br> <li>Trồng tại các nông trại xanh</li><br></ul>",
                    Price = 7900,
                    FoodName = "Green onion",
                    Stock = 100,
                    Weight = 100,
                    Unit = "Kg",
                    Origin = "TP. Hồ Chí Minh",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("576aa3a9-49ff-486c-8efc-a0548ee90ee7"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Dưa hấu",
                    Slug = "dua-hau-2-kg-im862u",
                    Description = "<p>Dưa hấu ngọt mát, tươi ngon, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu nước, giúp giải khát hiệu quả</li><br>  <li>Chứa nhiều vitamin A và C</li><br> <li>Không hóa chất bảo quản</li><br>  <li>Thích hợp ăn trực tiếp và làm nước ép</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li><br></ul>",
                    Price = 35400,
                    Stock = 100,
                    FoodName = "Watermelon",

                    Weight = 2,
                    Unit = "Kg",
                    Origin = "Long An",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("a69cd06b-8762-49cc-9228-1fc88956fb3c"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Melon",
                    Slug = "dua-luoi-1-kg-vhw1l0",
                    Description = "<p>Dưa lưới tươi ngon, ngọt mát, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu vitamin A và C, tốt cho sức khỏe</li><br>  <li>Chứa nhiều nước, giúp giải khát</li><br>  <li>Không dùng hóa chất bảo quản</li><br>  <li>Thích hợp ăn trực tiếp và làm sinh tố</li><br>  <li>Trồng tại các nông trại xanh</li><br></ul>",
                    Price = 38000,
                    FoodName = "Melon",
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Tiền Giang",
                    Organic = true,
                    Status = true

                },
                new Product()
                {
                    ProductId = Guid.Parse("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Dưa gang",
                    Slug = "dua-gang-1-kg-t0055v",
                    Description = "<p>Dưa gang tươi mát, ngọt lành, giàu vitamin và khoáng chất.</p>\r\n<ul>\r\n  <li>Giàu nước và vitamin C</li>\r\n  <li>Giúp giải nhiệt, tốt cho hệ tiêu hóa</li>\r\n  <li>Không hóa chất bảo quản</li>\r\n  <li>Thích hợp ăn trực tiếp và làm nước ép</li>\r\n  <li>Trồng tại các nông trại sạch</li>\r\n</ul>",
                    Price = 9000,
                    FoodName = "Winter melon",

                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Long An",
                    Organic = true,
                    Status = true

                },


            });


        }
    }
}
