using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PureFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class seedDataCategorySupplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CreatedAt", "CreatedBy", "Description", "UpdateAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), "Rau củ", new DateTime(2024, 9, 28, 15, 40, 23, 665, DateTimeKind.Local).AddTicks(8626), null, "Rau củ quả ngon lành", new DateTime(2024, 9, 28, 15, 40, 23, 665, DateTimeKind.Local).AddTicks(8637), null },
                    { new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), "Trái cây", new DateTime(2024, 9, 28, 15, 40, 23, 665, DateTimeKind.Local).AddTicks(8641), null, "Trái cây tươi mới", new DateTime(2024, 9, 28, 15, 40, 23, 665, DateTimeKind.Local).AddTicks(8642), null }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Address", "CreatedAt", "CreatedBy", "Description", "PhoneNumber", "SuplierName", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Quận 9, Thành phố Hồ Chí Minh", new DateTime(2024, 9, 28, 15, 40, 23, 665, DateTimeKind.Local).AddTicks(8743), null, "Chúng tôi cung cấp rau củ quả sạch, tươi ngon từ nông trại đến bàn ăn, đảm bảo an toàn sức khỏe cho gia đình bạn.", "0937056922", "PureFood", new DateTime(2024, 9, 28, 15, 40, 23, 665, DateTimeKind.Local).AddTicks(8744), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"));

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"));

            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"));
        }
    }
}
