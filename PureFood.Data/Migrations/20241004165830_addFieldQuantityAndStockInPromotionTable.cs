using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PureFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class addFieldQuantityAndStockInPromotionTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<decimal>(
                name: "Quantity",
                table: "Promotions",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Stock",
                table: "Promotions",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("25134650-be13-43de-bc40-22a9ea54b543"),
                column: "Description",
                value: "<p>Hành tây tươi, giòn ngọt, giàu vitamin và khoáng chất, thích hợp cho nhiều món ăn.</p><br><ul><br>  <li>Giàu vitamin C và chất chống oxy hóa</li>  <li>Có tác dụng kháng viêm, tốt cho sức khỏe</li><br>  <li>Không thuốc trừ sâu</li><br>  <li>Thích hợp nấu canh, xào và làm salad</li><br>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4e31b4e9-0eab-4bbe-b11b-ca52b02b60d5"),
                column: "Description",
                value: "<p>Ổi nữ hoàng tươi ngon, giòn ngọt, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><ul>  <li>Giàu vitamin C và chất chống oxy hóa</li>  <li>Hương vị ngọt mát, thịt quả giòn</li>  <li>Không dùng thuốc bảo vệ thực vật</li>  <li>Thích hợp ăn trực tiếp và làm sinh tố</li>  <li>Trồng tại các nông trại hữu cơ</li></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("557ff79b-b169-409f-aada-9c921c0a69d2"),
                column: "Description",
                value: "<p>Chuối già Nam Mỹ tươi ngon, giàu dinh dưỡng, sản phẩm nhập khẩu chất lượng cao.</p><ul>  <li>Giàu kali, tốt cho hệ tim mạch</li>  <li>Chứa nhiều chất xơ, tốt cho hệ tiêu hóa</li>  <li>Không hóa chất bảo quản</li>  <li>Thích hợp ăn trực tiếp, làm sinh tố và bánh</li>  <li>Nhập khẩu từ các trang trại sạch tại Nam Mỹ</li></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"),
                column: "Description",
                value: "<p>Dưa hấu ngọt mát, tươi ngon, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu nước, giúp giải khát hiệu quả</li><br>  <li>Chứa nhiều vitamin A và C</li><br> <li>Không hóa chất bảo quản</li><br>  <li>Thích hợp ăn trực tiếp và làm nước ép</li>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5c70e6fd-c1bd-48f3-b9d8-0b4c2907916c"),
                column: "Description",
                value: "<p>Chuối cau tươi ngon, ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><ul>  <li>Giàu kali và chất xơ, tốt cho hệ tiêu hóa</li>  <li>Chứa nhiều vitamin C và B6</li>  <li>Không hóa chất bảo quản</li>  <li>Thích hợp ăn trực tiếp, làm sinh tố và món tráng miệng</li>  <li>Trồng tại các nông trại hữu cơ</li></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6287df0b-b4ff-49e1-9b50-25cbc88a93a2"),
                column: "Description",
                value: "<p>Dừa xiêm tươi mát, ngọt lành, giàu nước và khoáng chất, sản phẩm sạch từ nông trại.</p><ul>  <li>Giàu nước và điện giải, giúp giải nhiệt</li>  <li>Chứa nhiều khoáng chất có lợi cho sức khỏe</li>  <li>Không hóa chất bảo quản</li>  <li>Thích hợp uống trực tiếp, làm nước giải khát</li>  <li>Trồng tại các nông trại hữu cơ</li></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"),
                column: "Description",
                value: "<p>Củ sắn tươi, ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><ul>  <li>Giàu vitamin C và chất xơ</li><br>  <li>Tốt cho hệ tiêu hóa</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp nấu canh, xào và làm salad</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7a684d3b-8e9f-4f06-a767-d59c1953f249"),
                column: "Description",
                value: "<p>Khoai lang ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul>  <li>Giàu vitamin A và chất xơ</li>  <li>Tốt cho hệ tiêu hóa và sức khỏe mắt</li>  <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp nướng, luộc và làm súp</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8212e748-fe88-40af-894e-708a376f4fa7"),
                column: "Description",
                value: "<p>Khoai môn tươi ngon, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul>  <li>Giàu chất xơ và vitamin B6</li><br>  <li>Tốt cho hệ tiêu hóa và tim mạch</li><br>  <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp cho các món nấu, chiên, và hầm</li><br>  <li>Được trồng tại các nông trại hữu cơ</li><br></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("88d089ad-0259-4b91-aba6-be6cf69a3117"),
                column: "Description",
                value: "<p>Lựu ngọt tươi ngon, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><ul>  <li>Giàu vitamin C và chất chống oxy hóa</li>  <li>Tốt cho sức khỏe tim mạch và hệ miễn dịch</li>  <li>Không thuốc bảo vệ thực vật</li>  <li>Thích hợp ăn trực tiếp, làm nước ép và salad</li>  <li>Trồng tại các nông trại hữu cơ</li></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a9249592-6bb8-4996-ad0b-0f3cd3c0b335"),
                column: "Description",
                value: "<p>Táo Gala mini tươi ngon, giòn ngọt, sản phẩm nhập khẩu chất lượng cao.</p><ul>  <li>Giàu chất chống oxy hóa và vitamin C</li>  <li>Hương vị ngọt thơm, giòn tan</li>  <li>Không hóa chất bảo quản</li>  <li>Thích hợp ăn trực tiếp, làm salad và nước ép</li>  <li>Nhập khẩu từ các trang trại hữu cơ</li></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"),
                column: "Description",
                value: "<p>Dưa gang tươi mát, ngọt lành, giàu vitamin và khoáng chất.</p><ul>  <li>Giàu nước và vitamin C</li>  <li>Giúp giải nhiệt, tốt cho hệ tiêu hóa</li>  <li>Không hóa chất bảo quản</li>  <li>Thích hợp ăn trực tiếp và làm nước ép</li>  <li>Trồng tại các nông trại sạch</li></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ca15b94b-bebb-4d86-bcbd-29993bf68183"),
                column: "Description",
                value: "<p>Xoài tứ quý tươi ngon, ngọt thơm, giàu vitamin và khoáng chất.</p><ul>  <li>Giàu vitamin C và chất chống oxy hóa</li>  <li>Hương vị ngọt thơm, thịt quả vàng ươm</li>  <li>Không thuốc bảo vệ thực vật</li>  <li>Thích hợp ăn trực tiếp, làm sinh tố và salad</li>  <li>Trồng tại các nông trại hữu cơ</li></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e4ebe279-a787-406a-bab5-7ae8f99748e4"),
                column: "Description",
                value: "<p>Cam sành tươi ngon, mọng nước, giàu vitamin C, sản phẩm sạch từ nông trại.</p><ul>  <li>Giàu vitamin C, tốt cho sức khỏe tổng thể</li>  <li>Hương vị ngọt mát, nhiều nước</li>  <li>Không thuốc bảo vệ thực vật</li>  <li>Thích hợp ăn trực tiếp và làm nước ép</li>  <li>Trồng tại các nông trại hữu cơ</li></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ec4b9041-b1f3-4852-82f5-ca357250ab3b"),
                column: "Description",
                value: "<p>Kiwi xanh tươi ngon, giàu vitamin và chất xơ, sản phẩm nhập khẩu chất lượng cao.</p><ul>  <li>Giàu vitamin C và chất xơ, tốt cho hệ miễn dịch</li>  <li>Chứa nhiều chất chống oxy hóa</li>  <li>Không hóa chất bảo quản</li>  <li>Thích hợp ăn trực tiếp, làm salad và sinh tố</li>  <li>Nhập khẩu từ các trang trại hữu cơ</li></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc8f443e-8f0e-46bf-8061-0a14074c8313"),
                column: "Description",
                value: "<p>Cam vàng ngọt thơm, giàu vitamin và khoáng chất, sản phẩm sạch từ nông trại.</p><ul>  <li>Giàu vitamin C, tốt cho hệ miễn dịch</li>  <li>Chứa nhiều chất chống oxy hóa</li>  <li>Không dùng hóa chất bảo quản</li>  <li>Thích hợp làm nước ép, ăn trực tiếp và salad</li>  <li>Trồng tại các nông trại xanh</li></ul>");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Quantity",
                table: "Promotions");

            migrationBuilder.DropColumn(
                name: "Stock",
                table: "Promotions");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("25134650-be13-43de-bc40-22a9ea54b543"),
                column: "Description",
                value: "<p>Hành tây tươi, giòn ngọt, giàu vitamin và khoáng chất, thích hợp cho nhiều món ăn.</p><br><ul><br>  <li>Giàu vitamin C và chất chống oxy hóa</li>\r\n  <li>Có tác dụng kháng viêm, tốt cho sức khỏe</li><br>  <li>Không thuốc trừ sâu</li><br>  <li>Thích hợp nấu canh, xào và làm salad</li><br>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("4e31b4e9-0eab-4bbe-b11b-ca52b02b60d5"),
                column: "Description",
                value: "\"<p>Ổi nữ hoàng tươi ngon, giòn ngọt, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu vitamin C và chất chống oxy hóa</li>\r\n  <li>Hương vị ngọt mát, thịt quả giòn</li>\r\n  <li>Không dùng thuốc bảo vệ thực vật</li>\r\n  <li>Thích hợp ăn trực tiếp và làm sinh tố</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li>\r\n</ul>\r\n\"");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("557ff79b-b169-409f-aada-9c921c0a69d2"),
                column: "Description",
                value: "\"<p>Chuối già Nam Mỹ tươi ngon, giàu dinh dưỡng, sản phẩm nhập khẩu chất lượng cao.</p>\r\n<ul>\r\n  <li>Giàu kali, tốt cho hệ tim mạch</li>\r\n  <li>Chứa nhiều chất xơ, tốt cho hệ tiêu hóa</li>\r\n  <li>Không hóa chất bảo quản</li>\r\n  <li>Thích hợp ăn trực tiếp, làm sinh tố và bánh</li>\r\n  <li>Nhập khẩu từ các trang trại sạch tại Nam Mỹ</li>\r\n</ul>\"");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"),
                column: "Description",
                value: "<p>Dưa hấu ngọt mát, tươi ngon, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu nước, giúp giải khát hiệu quả</li><br>  <li>Chứa nhiều vitamin A và C</li><br> <li>Không hóa chất bảo quản</li><br>  <li>Thích hợp ăn trực tiếp và làm nước ép</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li><br></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("5c70e6fd-c1bd-48f3-b9d8-0b4c2907916c"),
                column: "Description",
                value: "\"<p>Chuối cau tươi ngon, ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu kali và chất xơ, tốt cho hệ tiêu hóa</li>\r\n  <li>Chứa nhiều vitamin C và B6</li>\r\n  <li>Không hóa chất bảo quản</li>\r\n  <li>Thích hợp ăn trực tiếp, làm sinh tố và món tráng miệng</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li>\r\n</ul>\r\n\"");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6287df0b-b4ff-49e1-9b50-25cbc88a93a2"),
                column: "Description",
                value: "\"<p>Dừa xiêm tươi mát, ngọt lành, giàu nước và khoáng chất, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu nước và điện giải, giúp giải nhiệt</li>\r\n  <li>Chứa nhiều khoáng chất có lợi cho sức khỏe</li>\r\n  <li>Không hóa chất bảo quản</li>\r\n  <li>Thích hợp uống trực tiếp, làm nước giải khát</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li>\r\n</ul>\r\n\"");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"),
                column: "Description",
                value: "<p>Củ sắn tươi, ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu vitamin C và chất xơ</li><br>  <li>Tốt cho hệ tiêu hóa</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp nấu canh, xào và làm salad</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7a684d3b-8e9f-4f06-a767-d59c1953f249"),
                column: "Description",
                value: "<p>Khoai lang ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul>\r\n  <li>Giàu vitamin A và chất xơ</li>\r\n  <li>Tốt cho hệ tiêu hóa và sức khỏe mắt</li>\r\n  <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp nướng, luộc và làm súp</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8212e748-fe88-40af-894e-708a376f4fa7"),
                column: "Description",
                value: "<p>Khoai môn tươi ngon, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul>\r\n  <li>Giàu chất xơ và vitamin B6</li><br>  <li>Tốt cho hệ tiêu hóa và tim mạch</li><br>  <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp cho các món nấu, chiên, và hầm</li><br>  <li>Được trồng tại các nông trại hữu cơ</li><br></ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("88d089ad-0259-4b91-aba6-be6cf69a3117"),
                column: "Description",
                value: "\"<p>Lựu ngọt tươi ngon, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu vitamin C và chất chống oxy hóa</li>\r\n  <li>Tốt cho sức khỏe tim mạch và hệ miễn dịch</li>\r\n  <li>Không thuốc bảo vệ thực vật</li>\r\n  <li>Thích hợp ăn trực tiếp, làm nước ép và salad</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li>\r\n</ul>\r\n\"");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a9249592-6bb8-4996-ad0b-0f3cd3c0b335"),
                column: "Description",
                value: "\"<p>Táo Gala mini tươi ngon, giòn ngọt, sản phẩm nhập khẩu chất lượng cao.</p>\r\n<ul>\r\n  <li>Giàu chất chống oxy hóa và vitamin C</li>\r\n  <li>Hương vị ngọt thơm, giòn tan</li>\r\n  <li>Không hóa chất bảo quản</li>\r\n  <li>Thích hợp ăn trực tiếp, làm salad và nước ép</li>\r\n  <li>Nhập khẩu từ các trang trại hữu cơ</li>\r\n</ul>\"");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"),
                column: "Description",
                value: "<p>Dưa gang tươi mát, ngọt lành, giàu vitamin và khoáng chất.</p>\r\n<ul>\r\n  <li>Giàu nước và vitamin C</li>\r\n  <li>Giúp giải nhiệt, tốt cho hệ tiêu hóa</li>\r\n  <li>Không hóa chất bảo quản</li>\r\n  <li>Thích hợp ăn trực tiếp và làm nước ép</li>\r\n  <li>Trồng tại các nông trại sạch</li>\r\n</ul>");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ca15b94b-bebb-4d86-bcbd-29993bf68183"),
                column: "Description",
                value: "\"<p>Xoài tứ quý tươi ngon, ngọt thơm, giàu vitamin và khoáng chất.</p>\r\n<ul>\r\n  <li>Giàu vitamin C và chất chống oxy hóa</li>\r\n  <li>Hương vị ngọt thơm, thịt quả vàng ươm</li>\r\n  <li>Không thuốc bảo vệ thực vật</li>\r\n  <li>Thích hợp ăn trực tiếp, làm sinh tố và salad</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li>\r\n</ul>\r\n\"");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e4ebe279-a787-406a-bab5-7ae8f99748e4"),
                column: "Description",
                value: "\"<p>Cam sành tươi ngon, mọng nước, giàu vitamin C, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu vitamin C, tốt cho sức khỏe tổng thể</li>\r\n  <li>Hương vị ngọt mát, nhiều nước</li>\r\n  <li>Không thuốc bảo vệ thực vật</li>\r\n  <li>Thích hợp ăn trực tiếp và làm nước ép</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li>\r\n</ul>\r\n\"");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ec4b9041-b1f3-4852-82f5-ca357250ab3b"),
                column: "Description",
                value: "\"<p>Kiwi xanh tươi ngon, giàu vitamin và chất xơ, sản phẩm nhập khẩu chất lượng cao.</p>\r\n<ul>\r\n  <li>Giàu vitamin C và chất xơ, tốt cho hệ miễn dịch</li>\r\n  <li>Chứa nhiều chất chống oxy hóa</li>\r\n  <li>Không hóa chất bảo quản</li>\r\n  <li>Thích hợp ăn trực tiếp, làm salad và sinh tố</li>\r\n  <li>Nhập khẩu từ các trang trại hữu cơ</li>\r\n</ul>\r\n\"");

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc8f443e-8f0e-46bf-8061-0a14074c8313"),
                column: "Description",
                value: "\"<p>Cam vàng ngọt thơm, giàu vitamin và khoáng chất, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu vitamin C, tốt cho hệ miễn dịch</li>\r\n  <li>Chứa nhiều chất chống oxy hóa</li>\r\n  <li>Không dùng hóa chất bảo quản</li>\r\n  <li>Thích hợp làm nước ép, ăn trực tiếp và salad</li>\r\n  <li>Trồng tại các nông trại xanh</li>\r\n</ul>\r\n\"");
        }
    }
}
