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
                    FoodName = "Water spinach",
                    Slug = "rau-muong-400-gr-zk7dwx",
                    Description = "<p>Rau muống tươi ngon, giàu chất xơ, sản phẩm sạch từ nông trại, có nhiều giá trị dinh dưỡng.</p> <ul> <li>Giàu chất xơ, tốt cho hệ tiêu hóa</li> <li>Giàu vitamin A và C</li> <li>Không thuốc bảo vệ thực vật</li> <li>Thích hợp chế biến các món xào, nấu canh</li> <li>Được trồng tại các nông trại xanh</li> </ul>",
                    Price = 8000,
                    Stock = 100,
                    Weight = 400,
                    Unit = "Gr",
                    Origin = "Tỉnh Long An",
                    Organic = true,
                    EntryDate = new DateTime(2024, 10, 19), // 19th October 2024
                    ExpiryDate = new DateTime(2024, 11, 15) // 15th November 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("487ca896-ab72-4735-bee9-1b6a42ec3be6"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Bắp cải",
                    FoodName = "Cabbage",
                    Slug = "bap-cai-500-gr-rkwi1a",
                    Description = "<h4>Bắp cải tươi ngon, giòn ngọt, sản phẩm hữu cơ giàu vitamin và chất xơ.</h4> <ul> <li>Giàu vitamin K và C, tốt cho sức khỏe xương và hệ miễn dịch</li> <li>Hàm lượng chất chống oxy hóa cao</li> <li>Không sử dụng thuốc trừ sâu</li> <li>Thích hợp chế biến món luộc, xào và salad</li> <li>Trồng tại các nông trại hữu cơ</li> </ul>",
                    Price = 12500,
                    Stock = 100,
                    Weight = 500,
                    Unit = "Gr",
                    Origin = "Tỉnh Lâm Đồng",
                    Organic = true,
                    EntryDate = new DateTime(2024, 10, 20), // 20th October 2024
                    ExpiryDate = new DateTime(2024, 11, 16) // 16th November 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),

                },

                new Product()
                {
                    ProductId = Guid.Parse("30cfb1b3-da69-4a84-b94c-07ffe79597e0"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Giá sống",
                    FoodName = "Bean sprouts",
                    Slug = "gia-song-200-gr-fb1ihn",
                    Description = "<h4>Giá sống tươi mát, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</h4><ul> <li>Giàu chất xơ và vitamin E</li> <li>Tốt cho hệ tiêu hóa và làn da</li> <li>Không thuốc bảo vệ thực vật</li> <li>Dùng trong các món gỏi, xào, và phở</li> <li>Được trồng tại các nông trại xanh</li> </ul>",
                    Price = 6800,
                    Stock = 100,
                    Weight = 200,
                    Unit = "Gr",
                    Origin = "Tỉnh Tiền Giang",
                    Organic = true,
                    EntryDate = new DateTime(2024, 10, 21), // 21st October 2024
                    ExpiryDate = new DateTime(2024, 11, 17) // 17th November 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Nấm kim châm",
                    FoodName = "Enoki mushrooms",
                    Slug = "nam-kim-cham-150-gr-edwynx",
                    Description = "<h4>Nấm kim châm tươi ngon, giàu protein và vitamin, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu protein, tốt cho sức khỏe tổng thể</li> <li>Chứa nhiều vitamin B và chất chống oxy hóa</li> <li>Không chứa chất hóa học</li> <li>Thích hợp dùng trong lẩu, xào, và món súp</li> <li>Trồng tại các nông trại sạch</li> </ul>",
                    Price = 11000,
                    Stock = 100,
                    Weight = 150,
                    Unit = "Gr",
                    Origin = "Thành phố Hồ Chí Minh",
                    Organic = true,
                    EntryDate = new DateTime(2024, 10, 22), // 22nd October 2024
                    ExpiryDate = new DateTime(2024, 11, 18)
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("d3fd8b9e-ff11-4c14-a453-edfd58f05135"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Cà rốt",
                    FoodName = "Carrot",
                    Slug = "ca-rot-500-gr-xhj7ec",
                    Description = "<h4>Cà rốt tươi ngon, ngọt lành, giàu vitamin A và chất chống oxy hóa.</h4> <ul> <li>Giàu vitamin A, tốt cho mắt</li>  <li>Hàm lượng chất chống oxy hóa cao</li> <li>Không dùng hóa chất bảo vệ thực vật</li> <li>Thích hợp cho món nước ép, nấu canh và xào</li> <li>Được trồng tại nông trại hữu cơ</li> </ul>",
                    Price = 11500,
                    Stock = 100,
                    Weight = 500,
                    Unit = "Gr",
                    Origin = "Tỉnh Lâm Đồng",
                    Organic = true,
                    EntryDate = new DateTime(2024, 10, 23), // 23rd October 2024
                    ExpiryDate = new DateTime(2024, 11, 19) // 19th November 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Củ dền",
                    FoodName = "Beetroot",
                    Slug = "cu-den-500-gr-wxels8",
                    Description = "<h4>Củ dền tươi, giàu vitamin và khoáng chất, thích hợp cho các món ăn bổ dưỡng.</h4> <ul> <li>Giàu folate và chất sắt, tốt cho máu</li> <li>Chứa nhiều chất chống oxy hóa</li> <li>Không thuốc bảo vệ thực vật</li> <li>Thích hợp cho nước ép, nấu canh và salad</li> <li>Trồng tại các nông trại hữu cơ</li> </ul>",
                    Price = 22500,
                    Stock = 100,
                    Weight = 500,
                    Unit = "Gr",
                    Origin = "Tỉnh Lâm Đồng",
                    Organic = true,
                    EntryDate = new DateTime(2024, 10, 24), // 24th October 2024
                    ExpiryDate = new DateTime(2024, 11, 20) // 20th November 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("a5c11a08-497c-4846-b922-bb8a95078dd1"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Hành tím",
                    FoodName = "Red onion",
                    Slug = "hanh-tim-200-gr-aw4230",
                    Description = "<h4>Hành tím tươi, vị thơm nồng, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu vitamin C và chất xơ</li>  <li>Có tính kháng viêm tự nhiên</li> <li>Không dùng hóa chất bảo vệ thực vật</li> <li>Thích hợp làm gia vị trong nhiều món ăn</li>  <li>Được trồng tại nông trại sạch</li> </ul>",
                    Price = 15000,
                    Stock = 100,
                    Weight = 200,
                    Unit = "Gr",
                    Origin = "Tỉnh Sóc Trăng",
                    Organic = true,
                    EntryDate = new DateTime(2024, 10, 25), // 25th October 2024
                    ExpiryDate = new DateTime(2024, 11, 21) // 21st November 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("25134650-be13-43de-bc40-22a9ea54b543"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Hành tây",
                    FoodName = "Onion",
                    Slug = "hanh-tay-500-gr-xowt5w",
                    Description = "<h4>Hành tây tươi, giòn ngọt, giàu vitamin và khoáng chất, thích hợp cho nhiều món ăn.</h4> <ul> <li>Giàu vitamin C và chất chống oxy hóa</li> <li>Có tác dụng kháng viêm, tốt cho sức khỏe</li> <li>Không thuốc trừ sâu</li> <li>Thích hợp nấu canh, xào và làm salad</li> <li>Trồng tại các nông trại hữu cơ</li> </ul>",
                    Price = 8750,
                    Stock = 100,
                    Weight = 500,
                    Unit = "Gr",
                    Origin = "Tỉnh Lâm Đồng",
                    Organic = true,
                    EntryDate = new DateTime(2024, 10, 26), // 26th October 2024
                    ExpiryDate = new DateTime(2024, 11, 22) // 22nd November 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Tỏi cô đơn",
                    FoodName = "Garlic",
                    Slug = "toi-co-don-200-gr-9rmr8t",
                    Description = "<h4>Tỏi tươi, vị cay nồng, giàu chất chống oxy hóa, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu chất chống oxy hóa và kháng khuẩn</li> <li>Giúp tăng cường hệ miễn dịch</li> <li>Không thuốc bảo vệ thực vật</li> <li>Thích hợp làm gia vị trong các món ăn</li> <li>Trồng tại các nông trại sạch</li> </ul>",
                    Price = 32000,
                    Stock = 100,
                    Weight = 200,
                    Unit = "Gr",
                    Origin = "Tỉnh Kiên Giang",
                    Organic = true,
                    EntryDate = new DateTime(2024, 10, 27), // 27th October 2024
                    ExpiryDate = new DateTime(2024, 11, 23) // 23rd November 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("8212e748-fe88-40af-894e-708a376f4fa7"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Khoai môn",
                    FoodName = "Taro",
                    Slug = "khoai-mon-500-gr-8q8nq9",
                    Description = "<h4>Khoai môn tươi ngon, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu chất xơ và vitamin B6</li> <li>Tốt cho hệ tiêu hóa và tim mạch</li> <li>Không dùng hóa chất bảo vệ thực vật</li> <li>Thích hợp cho các món nấu, chiên, và hầm</li> <li>Được trồng tại các nông trại hữu cơ</li> </ul>",
                    Price = 26000,
                    Stock = 100,
                    Weight = 500,
                    Unit = "Gr",
                    Origin = "Thành phố Bạc Liêu",
                    Organic = true,
                    EntryDate = new DateTime(2024, 10, 28), // 28th October 2024
                    ExpiryDate = new DateTime(2024, 11, 24) // 24th November 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("6404ba59-9c63-4192-889b-3448cd7c9ba0"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Khoai tây",
                    FoodName = "Potato",
                    Slug = "khoai-tay-1-kg-0sls2y",
                    Description = "<h4>Khoai tây tươi, giàu dinh dưỡng, thích hợp cho nhiều món ăn.</h4> <ul> <li>Giàu vitamin C và chất xơ</li> <li>Hàm lượng chất chống oxy hóa cao</li> <li>Không thuốc bảo vệ thực vật</li> <li>Thích hợp cho các món chiên, nướng, và hầm</li> <li>Được trồng tại nông trại sạch</li> </ul>",
                    Price = 30000,
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Tỉnh Lâm Đồng",
                    Organic = true,
                    EntryDate = new DateTime(2024, 10, 29), // 29th October 2024
                    ExpiryDate = new DateTime(2024, 11, 25) // 25th November 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("7a684d3b-8e9f-4f06-a767-d59c1953f249"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Khoai lang",
                    FoodName = "Sweet potato",
                    Slug = "khoai-lang-1-kg-hu8kgx",
                    Description = "<h4>Khoai lang ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu vitamin A và chất xơ</li> <li>Tốt cho hệ tiêu hóa và sức khỏe mắt</li> <li>Không dùng hóa chất bảo vệ thực vật</li> <li>Thích hợp nướng, luộc và làm súp</li> <li>Được trồng tại nông trại hữu cơ</li></ul>",
                    Price = 34000,
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Thành phố Vĩnh Long",
                    Organic = true,
                    EntryDate = new DateTime(2024, 10, 30), // 30th October 2024
                    ExpiryDate = new DateTime(2024, 11, 26) // 26th November 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Gừng",
                    FoodName = "Ginger",
                    Slug = "gung-50-gr-vc4465",
                    Description = "<h4>Gừng tươi, thơm nồng, giàu chất chống oxy hóa, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu chất chống viêm và kháng khuẩn</li> <li>Giúp tăng cường hệ miễn dịch và hỗ trợ tiêu hóa</li> <li>Không thuốc bảo vệ thực vật</li> <li>Thích hợp làm gia vị cho nhiều món ăn</li> <li>Được trồng tại nông trại hữu cơ</li> </ul>",
                    Price = 4250,
                    Stock = 100,
                    Weight = 50,
                    Unit = "Kg",
                    Origin = "Tỉnh Lâm Đồng",
                    Organic = true,
                    EntryDate = new DateTime(2024, 10, 31), // 31st October 2024
                    ExpiryDate = new DateTime(2024, 11, 27) // 27th November 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("2adef94c-fa06-4369-89ab-34e71052368e"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Củ cải trắng",
                    FoodName = "Daikon radish",
                    Slug = "cu-cai-trang-500-gr-8irui7",
                    Description = "<h4>Củ cải trắng tươi ngon, giòn ngọt, giàu vitamin và khoáng chất.</h4> <ul> <li>Giàu vitamin C, tốt cho sức khỏe tổng thể</li> <li>Chứa nhiều chất chống oxy hóa</li> <li>Không thuốc bảo vệ thực vật</li> <li>Thích hợp làm nộm, nấu canh và xào</li> <li>Trồng tại các nông trại sạch</li> </ul>",
                    Price = 10450,
                    Stock = 100,
                    Weight = 500,
                    Unit = "Gr",
                    Origin = "Tỉnh Lâm Đồng",
                    Organic = true,
                    Status = true,
                    EntryDate = new DateTime(2024, 11, 1), // 1st November 2024
                    ExpiryDate = new DateTime(2024, 11, 28) // 28th November 2024
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Củ sắn",
                    FoodName = "Jicama",
                    Slug = "cu-san-500-gr-uv72km",
                    Description = "<h4>Củ sắn tươi, ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu vitamin C và chất xơ</li>  <li>Tốt cho hệ tiêu hóa</li> <li>Không thuốc bảo vệ thực vật</li> <li>Thích hợp nấu canh, xào và làm salad</li> <li>Được trồng tại nông trại hữu cơ</li> </ul>",
                    Price = 11500,
                    Stock = 100,
                    Weight = 500,
                    Unit = "Gr",
                    Origin = "Thành phố Tây Ninh",
                    Organic = true,
                    EntryDate = new DateTime(2024, 11, 2), // 2nd November 2024
                    ExpiryDate = new DateTime(2024, 11, 29) // 29th November 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("fc727800-963c-4305-93a0-3b27dfb1d734"),
                    CategoryId = Guid.Parse("6b5f6458-3791-4303-8ee7-e20707e4cf3e"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Bơ Booth",
                    FoodName = "Avocado",
                    Slug = "bo-booth-1-kg-n0390m",
                    Description = "<h4>Bơ Booth tươi ngon, giàu dinh dưỡng, chứa nhiều chất béo lành mạnh.</h4> <ul> <li>Giàu chất béo không bão hòa, tốt cho tim mạch</li> <li>Chứa nhiều vitamin E và chất xơ</li> <li>Không hóa chất bảo quản</li> <li>Thích hợp làm sinh tố, salad và ăn trực tiếp</li> <li>Trồng tại các nông trại hữu cơ</li> </ul>",
                    Price = 26000,
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Tỉnh Lâm Đồng",
                    Organic = true,
                    EntryDate = new DateTime(2024, 11, 3), // 3rd November 2024
                    ExpiryDate = new DateTime(2024, 11, 30) // 30th November 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("ba9968e6-4ad4-406c-9268-28acd686f73c"),
                    CategoryId = Guid.Parse("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Hành lá",
                    FoodName = "Green onion",
                    Slug = "hanh-la-100-gr-hx03dw",
                    Description = "<h4>Hành lá tươi, xanh non, giàu vitamin và khoáng chất, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu vitamin A và C</li>  <li>Tốt cho sức khỏe mắt và hệ miễn dịch</li> <li>Không thuốc bảo vệ thực vật</li> <li>Thích hợp làm gia vị cho nhiều món ăn</li> <li>Trồng tại các nông trại xanh</li> </ul>",
                    Price = 7900,
                    Stock = 100,
                    Weight = 100,
                    Unit = "Kg",
                    Origin = "Thành phố Hồ Chí Minh",
                    Organic = true,
                    EntryDate = new DateTime(2024, 11, 4), // 4th November 2024
                    ExpiryDate = new DateTime(2024, 12, 1) // 1st December 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("576aa3a9-49ff-486c-8efc-a0548ee90ee7"),
                    CategoryId = Guid.Parse("6b5f6458-3791-4303-8ee7-e20707e4cf3e"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Dưa hấu",
                    FoodName = "Watermelon",
                    Slug = "dua-hau-2-kg-im862u",
                    Description = "<h4>Dưa hấu ngọt mát, tươi ngon, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu nước, giúp giải khát hiệu quả</li> <li>Chứa nhiều vitamin A và C</li> <li>Không hóa chất bảo quản</li> <li>Thích hợp ăn trực tiếp và làm nước ép</li> <li>Trồng tại các nông trại hữu cơ</li> </ul>",
                    Price = 35400,
                    Stock = 100,
                    Weight = 2,
                    Unit = "Kg",
                    Origin = "Tỉnh Long An",
                    Organic = true,
                    EntryDate = new DateTime(2024, 11, 5), // 5th November 2024
                    ExpiryDate = new DateTime(2024, 12, 2) // 2nd December 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("a69cd06b-8762-49cc-9228-1fc88956fb3c"),
                    CategoryId = Guid.Parse("6b5f6458-3791-4303-8ee7-e20707e4cf3e"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Dưa lưới",
                    FoodName = "Melon",
                    Slug = "dua-luoi-1-kg-vhw1l0",
                    Description = "<h4>Dưa lưới tươi ngon, ngọt mát, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu vitamin A và C, tốt cho sức khỏe</li> <li>Chứa nhiều nước, giúp giải khát</li> <li>Không dùng hóa chất bảo quản</li> <li>Thích hợp ăn trực tiếp và làm sinh tố</li> <li>Trồng tại các nông trại xanh</li> </ul>",
                    Price = 38000,
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Tỉnh Tiền Giang",
                    Organic = true,
                    EntryDate = new DateTime(2024, 11, 6), // 6th November 2024
                    ExpiryDate = new DateTime(2024, 12, 3) // 3rd December 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                new Product()
                {
                    ProductId = Guid.Parse("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"),
                    CategoryId = Guid.Parse("6b5f6458-3791-4303-8ee7-e20707e4cf3e"),
                    SupplierId =  Guid.Parse("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                    ProductName = "Dưa gang",
                    FoodName = "Winter melon",
                    Slug = "dua-gang-1-kg-t0055v",
                    Description = "<h4>Dưa gang tươi mát, ngọt lành, giàu vitamin và khoáng chất.</h4> <ul> <li>Giàu nước và vitamin C</li> <li>Giúp giải nhiệt, tốt cho hệ tiêu hóa</li> <li>Không hóa chất bảo quản</li> <li>Thích hợp ăn trực tiếp và làm nước ép</li> <li>Trồng tại các nông trại sạch</li> </ul>",
                    Price = 9000,
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Tỉnh Long An",
                    Organic = true,
                    EntryDate = new DateTime(2024, 11, 7), // 7th November 2024
                    ExpiryDate = new DateTime(2024, 12, 4) // 4th December 2024
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },
                
                // product 21
                new Product()
                {
                    ProductId = Guid.Parse("557ff79b-b169-409f-aada-9c921c0a69d2"),
                    CategoryId = Guid.Parse("6B5F6458-3791-4303-8EE7-E20707E4CF3E"),
                    SupplierId =  Guid.Parse("5A0B659D-884A-446A-8B77-9B84ED6E2BF2"),
                    ProductName = "Chuối già Nam Mỹ",
                    FoodName = "Banana",
                    Slug = "chuoi-gia-nam-my-1-kg-2ukdtl",
                    Description = "<h4>Chuối già Nam Mỹ tươi ngon, giàu dinh dưỡng, sản phẩm nhập khẩu chất lượng cao.</h4> <ul> <li>Giàu kali, tốt cho hệ tim mạch</li> <li>Chứa nhiều chất xơ, tốt cho hệ tiêu hóa</li> <li>Không hóa chất bảo quản</li> <li>Thích hợp ăn trực tiếp, làm sinh tố và bánh</li> <li>Nhập khẩu từ các trang trại sạch tại Nam Mỹ</li> </ul>",
                    Price = 22540,
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Tỉnh Đồng Nai",
                    Organic = true,
                    EntryDate = DateTime.Parse("2024-11-8"),
                    ExpiryDate = DateTime.Parse("2024-12-5"),
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                // product 22
                new Product()
                {
                    ProductId = Guid.Parse("ca15b94b-bebb-4d86-bcbd-29993bf68183"),
                    CategoryId = Guid.Parse("6B5F6458-3791-4303-8EE7-E20707E4CF3E"),
                    SupplierId =  Guid.Parse("5A0B659D-884A-446A-8B77-9B84ED6E2BF2"),
                    ProductName = "Xoài tứ quý",
                    FoodName = "Mango",
                    Slug = "xoai-tu-quy-1-kg-4lsic0",
                    Description = "<h4>Xoài tứ quý tươi ngon, ngọt thơm, giàu vitamin và khoáng chất.</h4> <ul> <li>Giàu vitamin C và chất chống oxy hóa</li>  <li>Hương vị ngọt thơm, thịt quả vàng ươm</li> <li>Không thuốc bảo vệ thực vật</li> <li>Thích hợp ăn trực tiếp, làm sinh tố và salad</li>  <li>Trồng tại các nông trại hữu cơ</li> </ul>",
                    Price = 37400,
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Tỉnh Đồng Tháp",
                    Organic = true,
                    EntryDate = DateTime.Parse("2024-11-9"),
                    ExpiryDate = DateTime.Parse("2024-12-6"),
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                // product 23
                new Product()
                {
                    ProductId = Guid.Parse("a9249592-6bb8-4996-ad0b-0f3cd3c0b335"),
                    CategoryId = Guid.Parse("6B5F6458-3791-4303-8EE7-E20707E4CF3E"),
                    SupplierId =  Guid.Parse("5A0B659D-884A-446A-8B77-9B84ED6E2BF2"),
                    ProductName = "Táo Gala mini nhập khẩu",
                    FoodName = "Apple",
                    Slug = "tao-gala-mini-nhap-khau-1-kg-1dyi04",
                    Description = "<h4>Táo Gala mini tươi ngon, giòn ngọt, sản phẩm nhập khẩu chất lượng cao.</h4> <ul> <li>Giàu chất chống oxy hóa và vitamin C</li> <li>Hương vị ngọt thơm, giòn tan</li> <li>Không hóa chất bảo quản</li> <li>Thích hợp ăn trực tiếp, làm salad và nước ép</li>  <li>Nhập khẩu từ các trang trại hữu cơ</li> </ul>",
                    Price = 44000,
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Tỉnh Lâm Đồng",
                    Organic = true,
                    EntryDate = DateTime.Parse("2024-11-10"),
                    ExpiryDate = DateTime.Parse("2024-12-7"),
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                // product 24
                new Product()
                {
                    ProductId = Guid.Parse("5c70e6fd-c1bd-48f3-b9d8-0b4c2907916c"),
                    CategoryId = Guid.Parse("6B5F6458-3791-4303-8EE7-E20707E4CF3E"),
                    SupplierId =  Guid.Parse("5A0B659D-884A-446A-8B77-9B84ED6E2BF2"),
                    ProductName = "Chuối cau",
                    FoodName = "Banana",
                    Slug = "chuoi-cau-1-kg-oa64o3",
                    Description = "<h4>Chuối cau tươi ngon, ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu kali và chất xơ, tốt cho hệ tiêu hóa</li> <li>Chứa nhiều vitamin C và B6</li> <li>Không hóa chất bảo quản</li> <li>Thích hợp ăn trực tiếp, làm sinh tố và món tráng miệng</li> <li>Trồng tại các nông trại hữu cơ</li> </ul>",
                    Price = 24600,
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Tỉnh Đồng Nai",
                    Organic = true,
                    EntryDate = DateTime.Parse("2024-11-11"),
                    ExpiryDate = DateTime.Parse("2024-12-8"),
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                // product 25
                new Product()
                {
                    ProductId = Guid.Parse("6287df0b-b4ff-49e1-9b50-25cbc88a93a2"),
                    CategoryId = Guid.Parse("6B5F6458-3791-4303-8EE7-E20707E4CF3E"),
                    SupplierId =  Guid.Parse("5A0B659D-884A-446A-8B77-9B84ED6E2BF2"),
                    ProductName = "Dừa xiêm",
                    FoodName = "Coconut",
                    Slug = "dua-xiem-1-kg-m5hs6q",
                    Description = "<h4>Dừa xiêm tươi mát, ngọt lành, giàu nước và khoáng chất, sản phẩm sạch từ nông trại.</h4><ul> <li>Giàu nước và điện giải, giúp giải nhiệt</li> <li>Chứa nhiều khoáng chất có lợi cho sức khỏe</li> <li>Không hóa chất bảo quản</li> <li>Thích hợp uống trực tiếp, làm nước giải khát</li> <li>Trồng tại các nông trại hữu cơ</li></ul>",
                    Price = 32000,
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Tỉnh Bến Tre",
                    Organic = true,
                    EntryDate = DateTime.Parse("2024-11-12"),
                    ExpiryDate = DateTime.Parse("2024-12-9"),
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                // product 26
                new Product()
                {
                    ProductId = Guid.Parse("88d089ad-0259-4b91-aba6-be6cf69a3117"),
                    CategoryId = Guid.Parse("6B5F6458-3791-4303-8EE7-E20707E4CF3E"),
                    SupplierId =  Guid.Parse("5A0B659D-884A-446A-8B77-9B84ED6E2BF2"),
                    ProductName = "Lựu ngọt",
                    FoodName = "Pomegranate",
                    Slug = "luu-ngot-1-kg-ft8zwd",
                    Description = "<h4>Lựu ngọt tươi ngon, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu vitamin C và chất chống oxy hóa</li> <li>Tốt cho sức khỏe tim mạch và hệ miễn dịch</li> <li>Không thuốc bảo vệ thực vật</li> <li>Thích hợp ăn trực tiếp, làm nước ép và salad</li> <li>Trồng tại các nông trại hữu cơ</li> </ul>",
                    Price = 53000,
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Tỉnh Tiền Giang",
                    Organic = true,
                    EntryDate = DateTime.Parse("2024-11-13"),
                    ExpiryDate = DateTime.Parse("2024-12-10"),
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                // product 27
                new Product()
                {
                    ProductId = Guid.Parse("ec4b9041-b1f3-4852-82f5-ca357250ab3b"),
                    CategoryId = Guid.Parse("6B5F6458-3791-4303-8EE7-E20707E4CF3E"),
                    SupplierId =  Guid.Parse("5A0B659D-884A-446A-8B77-9B84ED6E2BF2"),
                    ProductName = "Kiwi xanh",
                    FoodName = "Green kiwi",
                    Slug = "kiwi-xanh-250-gr-6kodf3",
                    Description = "<h4>Kiwi xanh tươi ngon, giàu vitamin và chất xơ, sản phẩm nhập khẩu chất lượng cao.</h4> <ul> <li>Giàu vitamin C và chất xơ, tốt cho hệ miễn dịch</li> <li>Chứa nhiều chất chống oxy hóa</li> <li>Không hóa chất bảo quản</li> <li>Thích hợp ăn trực tiếp, làm salad và sinh tố</li> <li>Nhập khẩu từ các trang trại hữu cơ</li> </ul>",
                    Price = 39000,
                    Stock = 100,
                    Weight = 250,
                    Unit = "Gr",
                    Origin = "Tỉnh Lâm Đồng",
                    Organic = true,
                    EntryDate = DateTime.Parse("2024-11-14"),
                    ExpiryDate = DateTime.Parse("2024-12-11"),
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                // product 28
                new Product()
                {
                    ProductId = Guid.Parse("e4ebe279-a787-406a-bab5-7ae8f99748e4"),
                    CategoryId = Guid.Parse("6B5F6458-3791-4303-8EE7-E20707E4CF3E"),
                    SupplierId =  Guid.Parse("5A0B659D-884A-446A-8B77-9B84ED6E2BF2"),
                    ProductName = "Cam sành",
                    FoodName = "Orange",
                    Slug = "cam-sanh-1-kg-3tqshu",
                    Description = "<h4>Cam sành tươi ngon, mọng nước, giàu vitamin C, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu vitamin C, tốt cho sức khỏe tổng thể</li> <li>Hương vị ngọt mát, nhiều nước</li> <li>Không thuốc bảo vệ thực vật</li> <li>Thích hợp ăn trực tiếp và làm nước ép</li> <li>Trồng tại các nông trại hữu cơ</li> </ul>",
                    Price = 17900,
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Tỉnh Vĩnh Long",
                    Organic = true,
                    EntryDate = DateTime.Parse("2024-11-15"),
                    ExpiryDate = DateTime.Parse("2024-12-12"),
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },

                // product 29
                new Product()
                {
                    ProductId = Guid.Parse("fc8f443e-8f0e-46bf-8061-0a14074c8313"),
                    CategoryId = Guid.Parse("6B5F6458-3791-4303-8EE7-E20707E4CF3E"),
                    SupplierId =  Guid.Parse("5A0B659D-884A-446A-8B77-9B84ED6E2BF2"),
                    ProductName = "Cam vàng",
                    FoodName = "Orange",
                    Slug = "cam-vang-1-kg-gwctdn",
                    Description = "<h4>Cam vàng ngọt thơm, giàu vitamin và khoáng chất, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu vitamin C, tốt cho hệ miễn dịch</li> <li>Chứa nhiều chất chống oxy hóa</li> <li>Không dùng hóa chất bảo quản</li> <li>Thích hợp làm nước ép, ăn trực tiếp và salad</li> <li>Trồng tại các nông trại xanh</li> </ul>",
                    Price = 65000,
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Tỉnh Đồng Nai",
                    Organic = true,
                    EntryDate = DateTime.Parse("2024-11-16"),
                    ExpiryDate = DateTime.Parse("2024-12-13"),
                    Status = true,
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },
                
                // product 30
                new Product()
                {
                    ProductId = Guid.Parse("4e31b4e9-0eab-4bbe-b11b-ca52b02b60d5"),
                    CategoryId = Guid.Parse("6B5F6458-3791-4303-8EE7-E20707E4CF3E"),
                    SupplierId =  Guid.Parse("5A0B659D-884A-446A-8B77-9B84ED6E2BF2"),
                    ProductName = "Ổi nữ hoàng",
                    FoodName = "Guava",
                    Slug = "oi-nu-hoang-1-kg-0mbfz5",
                    Description = "<h4>Ổi nữ hoàng tươi ngon, giòn ngọt, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</h4> <ul> <li>Giàu vitamin C và chất chống oxy hóa</li> <li>Hương vị ngọt mát, thịt quả giòn</li> <li>Không dùng thuốc bảo vệ thực vật</li> <li>Thích hợp ăn trực tiếp và làm sinh tố</li> <li>Trồng tại các nông trại hữu cơ</li> </ul>",
                    Price = 23300,
                    Stock = 100,
                    Weight = 1,
                    Unit = "Kg",
                    Origin = "Tỉnh Tiền Giang",
                    Organic = true,
                    Status = true,
                    EntryDate = DateTime.Parse("2024-11-17"),
                    ExpiryDate = DateTime.Parse("2024-12-14"),
                    CreatedAt = DateTime.Parse("2024-10-02"),
                    UpdatedAt = DateTime.Parse("2024-10-02"),
                },
            });
        }
    }
}
