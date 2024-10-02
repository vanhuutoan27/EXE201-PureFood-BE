using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PureFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRoleseedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 14, 28, 908, DateTimeKind.Local).AddTicks(8725), new DateTime(2024, 10, 1, 13, 14, 28, 908, DateTimeKind.Local).AddTicks(8738) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 14, 28, 908, DateTimeKind.Local).AddTicks(8741), new DateTime(2024, 10, 1, 13, 14, 28, 908, DateTimeKind.Local).AddTicks(8742) });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), null, "Khách Hàng", "Customer", "CUSTOMER" },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), null, "Quản Lí", "Manager", "MANAGER" }
                });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 14, 28, 908, DateTimeKind.Local).AddTicks(8824), new DateTime(2024, 10, 1, 13, 14, 28, 908, DateTimeKind.Local).AddTicks(8826) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("9b8bc0ba-e6af-4445-8509-390f404c1ea6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 14, 28, 908, DateTimeKind.Local).AddTicks(8830), new DateTime(2024, 10, 1, 13, 14, 28, 908, DateTimeKind.Local).AddTicks(8830) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"));

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 11, 36, 638, DateTimeKind.Local).AddTicks(2382), new DateTime(2024, 10, 1, 13, 11, 36, 638, DateTimeKind.Local).AddTicks(2398) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 11, 36, 638, DateTimeKind.Local).AddTicks(2402), new DateTime(2024, 10, 1, 13, 11, 36, 638, DateTimeKind.Local).AddTicks(2402) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 11, 36, 638, DateTimeKind.Local).AddTicks(2505), new DateTime(2024, 10, 1, 13, 11, 36, 638, DateTimeKind.Local).AddTicks(2507) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("9b8bc0ba-e6af-4445-8509-390f404c1ea6"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 11, 36, 638, DateTimeKind.Local).AddTicks(2512), new DateTime(2024, 10, 1, 13, 11, 36, 638, DateTimeKind.Local).AddTicks(2513) });
        }
    }
}
