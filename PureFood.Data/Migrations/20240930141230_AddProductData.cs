using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PureFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddProductData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 30, 21, 12, 29, 884, DateTimeKind.Local).AddTicks(9035), new DateTime(2024, 9, 30, 21, 12, 29, 884, DateTimeKind.Local).AddTicks(9048) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"),
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 30, 21, 12, 29, 884, DateTimeKind.Local).AddTicks(9057), new DateTime(2024, 9, 30, 21, 12, 29, 884, DateTimeKind.Local).AddTicks(9058) });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CreatedAt", "CreatedBy", "Description", "EntryDate", "ExpiryDate", "FoodName", "Organic", "Origin", "Price", "ProductName", "Slug", "Status", "Stock", "SupplierId", "Unit", "UpdateAt", "UpdatedBy", "Weight" },
                values: new object[,]
                {
                    { new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Rau muống tươi ngon, giàu chất xơ, sản phẩm sạch từ nông trại, có nhiều giá trị dinh dưỡng.</p><br>   <ul><br>      <li>Giàu chất xơ, tốt cho hệ tiêu hóa</li><br>      <li>Giàu vitamin A và C</li><br>      <li>Không thuốc bảo vệ thực vật</li><br>      <li>Thích hợp chế biến các món xào, nấu canh</li><br>      <li>Được trồng tại các nông trại xanh</li><br>    </ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Water spinach", true, "Long An", 8000m, "Rau muống", "rau-muong-400-gr-zk7dwx", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", null, null, 400.0 },
                    { new Guid("25134650-be13-43de-bc40-22a9ea54b543"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Hành tây tươi, giòn ngọt, giàu vitamin và khoáng chất, thích hợp cho nhiều món ăn.</p><br><ul><br>  <li>Giàu vitamin C và chất chống oxy hóa</li>\r\n  <li>Có tác dụng kháng viêm, tốt cho sức khỏe</li><br>  <li>Không thuốc trừ sâu</li><br>  <li>Thích hợp nấu canh, xào và làm salad</li><br>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onion", true, "Lâm Đồng", 8750m, "Hành tây", "hanh-tay-500-gr-xowt5w", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", null, null, 500.0 },
                    { new Guid("2adef94c-fa06-4369-89ab-34e71052368e"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Củ cải trắng tươi ngon, giòn ngọt, giàu vitamin và khoáng chất.</p><br><ul><br>  <li>Giàu vitamin C, tốt cho sức khỏe tổng thể</li><br>  <li>Chứa nhiều chất chống oxy hóa</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp làm nộm, nấu canh và xào</li><br>  <li>Trồng tại các nông trại sạch</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daikon radish", true, "Lâm Đồng", 10450m, "Củ cải trắng", "cu-cai-trang-500-gr-8irui7", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", null, null, 500.0 },
                    { new Guid("30cfb1b3-da69-4a84-b94c-07ffe79597e0"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Giá sống tươi mát, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu chất xơ và vitamin E</li><br>  <li>Tốt cho hệ tiêu hóa và làn da</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Dùng trong các món gỏi, xào, và phở</li><br>  <li>Được trồng tại các nông trại xanh</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bean sprouts", true, "Tiền Giang", 6800m, "Giá sống", "gia-song-200-gr-fb1ihn", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", null, null, 200.0 },
                    { new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Bắp cải tươi ngon, giòn ngọt, sản phẩm hữu cơ giàu vitamin và chất xơ.</p><br><ul><br>  <li>Giàu vitamin K và C, tốt cho sức khỏe xương và hệ miễn dịch</li><br>  <li>Hàm lượng chất chống oxy hóa cao</li><br> <li>Không sử dụng thuốc trừ sâu</li><br>  <li>Thích hợp chế biến món luộc, xào và salad</li><br>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cabbage", true, "Lâm Đồng", 12500m, "Bắp cải", "bap-cai-500-gr-rkwi1a", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", null, null, 500.0 },
                    { new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Dưa hấu ngọt mát, tươi ngon, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu nước, giúp giải khát hiệu quả</li><br>  <li>Chứa nhiều vitamin A và C</li><br> <li>Không hóa chất bảo quản</li><br>  <li>Thích hợp ăn trực tiếp và làm nước ép</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watermelon", true, "Long An", 35400m, "Dưa hấu", "dua-hau-2-kg-im862u", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", null, null, 2.0 },
                    { new Guid("6404ba59-9c63-4192-889b-3448cd7c9ba0"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Khoai tây tươi, giàu dinh dưỡng, thích hợp cho nhiều món ăn.</p><br><ul><br>  <li>Giàu vitamin C và chất xơ</li><br>  <li>Hàm lượng chất chống oxy hóa cao</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp cho các món chiên, nướng, và hầm</li><br>  <li>Được trồng tại nông trại sạch</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potato", true, "Lâm Đồng", 30000m, "Khoai tây", "khoai-tay-1-kg-0sls2y", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", null, null, 1.0 },
                    { new Guid("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Củ sắn tươi, ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu vitamin C và chất xơ</li><br>  <li>Tốt cho hệ tiêu hóa</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp nấu canh, xào và làm salad</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jicama", true, "Tây Ninh", 11500m, "Củ sắn", "cu-san-500-gr-uv72km", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", null, null, 500.0 },
                    { new Guid("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Củ dền tươi, giàu vitamin và khoáng chất, thích hợp cho các món ăn bổ dưỡng.</p><br><ul><br>  <li>Giàu folate và chất sắt, tốt cho máu</li><br>  <li>Chứa nhiều chất chống oxy hóa</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp cho nước ép, nấu canh và salad</li><br>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beetroot", true, "Lâm Đồng", 22500m, "Củ dền", "cu-den-500-gr-wxels8", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", null, null, 500.0 },
                    { new Guid("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Gừng tươi, thơm nồng, giàu chất chống oxy hóa, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu chất chống viêm và kháng khuẩn</li><br>  <li>Giúp tăng cường hệ miễn dịch và hỗ trợ tiêu hóa</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp làm gia vị cho nhiều món ăn</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ginger", true, "Lâm Đồng", 4250m, "Gừng", "gung-50-gr-vc4465", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", null, null, 50.0 },
                    { new Guid("7a684d3b-8e9f-4f06-a767-d59c1953f249"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Khoai lang ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul>\r\n  <li>Giàu vitamin A và chất xơ</li>\r\n  <li>Tốt cho hệ tiêu hóa và sức khỏe mắt</li>\r\n  <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp nướng, luộc và làm súp</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sweet potato", true, "Vĩnh Long", 34000m, "Khoai lang", "khoai-lang-1-kg-hu8kgx", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", null, null, 1.0 },
                    { new Guid("8212e748-fe88-40af-894e-708a376f4fa7"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Khoai môn tươi ngon, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul>\r\n  <li>Giàu chất xơ và vitamin B6</li><br>  <li>Tốt cho hệ tiêu hóa và tim mạch</li><br>  <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp cho các món nấu, chiên, và hầm</li><br>  <li>Được trồng tại các nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taro", true, "Bạc Liêu", 26000m, "Khoai môn", "khoai-mon-500-gr-8q8nq9", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", null, null, 500.0 },
                    { new Guid("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Tỏi tươi, vị cay nồng, giàu chất chống oxy hóa, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu chất chống oxy hóa và kháng khuẩn</li><br>  <li>Giúp tăng cường hệ miễn dịch</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp làm gia vị trong các món ăn</li><br>  <li>Trồng tại các nông trại sạch</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garlic", true, "Kiên Giang", 32000m, "Tỏi cô đơn", "toi-co-don-200-gr-9rmr8t", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", null, null, 200.0 },
                    { new Guid("a5c11a08-497c-4846-b922-bb8a95078dd1"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Hành tím tươi, vị thơm nồng, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu vitamin C và chất xơ</li><br>  <li>Có tính kháng viêm tự nhiên</li><br> <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp làm gia vị trong nhiều món ăn</li><br>  <li>Được trồng tại nông trại sạch</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red onion", true, "Sóc Trăng", 15000m, "Hành tím", "hanh-tim-200-gr-aw4230", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", null, null, 200.0 },
                    { new Guid("a69cd06b-8762-49cc-9228-1fc88956fb3c"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Dưa lưới tươi ngon, ngọt mát, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu vitamin A và C, tốt cho sức khỏe</li><br>  <li>Chứa nhiều nước, giúp giải khát</li><br>  <li>Không dùng hóa chất bảo quản</li><br>  <li>Thích hợp ăn trực tiếp và làm sinh tố</li><br>  <li>Trồng tại các nông trại xanh</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melon", true, "Tiền Giang", 38000m, "Melon", "dua-luoi-1-kg-vhw1l0", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", null, null, 1.0 },
                    { new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Dưa gang tươi mát, ngọt lành, giàu vitamin và khoáng chất.</p>\r\n<ul>\r\n  <li>Giàu nước và vitamin C</li>\r\n  <li>Giúp giải nhiệt, tốt cho hệ tiêu hóa</li>\r\n  <li>Không hóa chất bảo quản</li>\r\n  <li>Thích hợp ăn trực tiếp và làm nước ép</li>\r\n  <li>Trồng tại các nông trại sạch</li>\r\n</ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Winter melon", true, "Long An", 9000m, "Dưa gang", "dua-gang-1-kg-t0055v", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", null, null, 1.0 },
                    { new Guid("ba9968e6-4ad4-406c-9268-28acd686f73c"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Hành lá tươi, xanh non, giàu vitamin và khoáng chất, sản phẩm sạch từ nông trại.</p><br><ul><br> <li>Giàu vitamin A và C</li><br>  <li>Tốt cho sức khỏe mắt và hệ miễn dịch</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp làm gia vị cho nhiều món ăn</li><br> <li>Trồng tại các nông trại xanh</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Green onion", true, "TP. Hồ Chí Minh", 7900m, "Hành lá", "hanh-la-100-gr-hx03dw", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", null, null, 100.0 },
                    { new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Cà rốt tươi ngon, ngọt lành, giàu vitamin A và chất chống oxy hóa.</p><br><ul><br>  <li>Giàu vitamin A, tốt cho mắt</li><br>  <li>Hàm lượng chất chống oxy hóa cao</li><br>  <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp cho món nước ép, nấu canh và xào</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carrot", true, "Lâm Đồng", 11500m, "Cà rốt", "ca-rot-500-gr-xhj7ec", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", null, null, 500.0 },
                    { new Guid("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Nấm kim châm tươi ngon, giàu protein và vitamin, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu protein, tốt cho sức khỏe tổng thể</li><br>  <li>Chứa nhiều vitamin B và chất chống oxy hóa</li><br>  <li>Không chứa chất hóa học</li><br>  <li>Thích hợp dùng trong lẩu, xào, và món súp</li><br> <li>Trồng tại các nông trại sạch</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enoki mushrooms", true, "Tp.Hồ Chí Minh", 11000m, "Giá sống", "nam-kim-cham-150-gr-edwynx", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", null, null, 150.0 },
                    { new Guid("fc727800-963c-4305-93a0-3b27dfb1d734"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), null, null, "<p>Bơ Booth tươi ngon, giàu dinh dưỡng, chứa nhiều chất béo lành mạnh.</p><br><ul><br>  <li>Giàu chất béo không bão hòa, tốt cho tim mạch</li><br>  <li>Chứa nhiều vitamin E và chất xơ</li><br>  <li>Không hóa chất bảo quản</li><br>  <li>Thích hợp làm sinh tố, salad và ăn trực tiếp</li><br>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avocado", true, "Lâm Đồng", 26000m, "Bơ Booth", "bo-booth-1-kg-n0390m", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", null, null, 1.0 }
                });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 21, 12, 29, 884, DateTimeKind.Local).AddTicks(9216), new DateTime(2024, 9, 30, 21, 12, 29, 884, DateTimeKind.Local).AddTicks(9216) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("9b8bc0ba-e6af-4445-8509-390f404c1ea6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 21, 12, 29, 884, DateTimeKind.Local).AddTicks(9221), new DateTime(2024, 9, 30, 21, 12, 29, 884, DateTimeKind.Local).AddTicks(9221) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("25134650-be13-43de-bc40-22a9ea54b543"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2adef94c-fa06-4369-89ab-34e71052368e"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("30cfb1b3-da69-4a84-b94c-07ffe79597e0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6404ba59-9c63-4192-889b-3448cd7c9ba0"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7a684d3b-8e9f-4f06-a767-d59c1953f249"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8212e748-fe88-40af-894e-708a376f4fa7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a5c11a08-497c-4846-b922-bb8a95078dd1"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a69cd06b-8762-49cc-9228-1fc88956fb3c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ba9968e6-4ad4-406c-9268-28acd686f73c"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc727800-963c-4305-93a0-3b27dfb1d734"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 30, 20, 57, 55, 38, DateTimeKind.Local).AddTicks(1796), new DateTime(2024, 9, 30, 20, 57, 55, 38, DateTimeKind.Local).AddTicks(1988) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"),
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 30, 20, 57, 55, 38, DateTimeKind.Local).AddTicks(1991), new DateTime(2024, 9, 30, 20, 57, 55, 38, DateTimeKind.Local).AddTicks(1992) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 20, 57, 55, 38, DateTimeKind.Local).AddTicks(2092), new DateTime(2024, 9, 30, 20, 57, 55, 38, DateTimeKind.Local).AddTicks(2092) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("9b8bc0ba-e6af-4445-8509-390f404c1ea6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 30, 20, 57, 55, 38, DateTimeKind.Local).AddTicks(2100), new DateTime(2024, 9, 30, 20, 57, 55, 38, DateTimeKind.Local).AddTicks(2101) });
        }
    }
}
