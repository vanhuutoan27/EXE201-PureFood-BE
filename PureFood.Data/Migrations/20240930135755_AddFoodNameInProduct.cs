using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PureFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddFoodNameInProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FoodName",
                table: "Products",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FoodName",
                table: "Products");

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(44), new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(55) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"),
                columns: new[] { "CreatedAt", "UpdateAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(60), new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(60) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(693), new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(696) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("9b8bc0ba-e6af-4445-8509-390f404c1ea6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(700), new DateTime(2024, 9, 28, 16, 44, 6, 108, DateTimeKind.Local).AddTicks(700) });
        }
    }
}
