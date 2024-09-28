using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PureFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class updateSeedDataCategorySupplier : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                columns: new[] { "CategoryName", "CreatedAt", "UpdateAt" },
                values: new object[] { "rau-cu", new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(44), new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"),
                columns: new[] { "CategoryName", "CreatedAt", "UpdateAt" },
                values: new object[] { "trai-cay", new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(60), new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(693), new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Address", "CreatedAt", "CreatedBy", "Description", "PhoneNumber", "SuplierName", "UpdatedAt", "UpdatedBy" },
                values: new object[] { new Guid("9b8bc0ba-e6af-4445-8509-390f404c1ea6"), "FPT Quận 9, Thành phố Hồ Chí Minh", new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(700), null, "Moncati cung cấp rau củ quả sạch, tươi ngon từ nông trại địa phương, cam kết mang đến sản phẩm an toàn và chất lượng cho sức khỏe gia đình bạn.", "0937056922", "Moncati", new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(700), null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("9b8bc0ba-e6af-4445-8509-390f404c1ea6"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                columns: new[] { "CategoryName", "CreatedAt", "UpdateAt" },
                values: new object[] { "Rau củ", new DateTime(2024, 9, 28, 15, 40, 23, 665, DateTimeKind.Local).AddTicks(8626), new DateTime(2024, 9, 28, 15, 40, 23, 665, DateTimeKind.Local).AddTicks(8637) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"),
                columns: new[] { "CategoryName", "CreatedAt", "UpdateAt" },
                values: new object[] { "Trái cây", new DateTime(2024, 9, 28, 15, 40, 23, 665, DateTimeKind.Local).AddTicks(8641), new DateTime(2024, 9, 28, 15, 40, 23, 665, DateTimeKind.Local).AddTicks(8642) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 15, 40, 23, 665, DateTimeKind.Local).AddTicks(8743), new DateTime(2024, 9, 28, 15, 40, 23, 665, DateTimeKind.Local).AddTicks(8744) });
        }
    }
}
