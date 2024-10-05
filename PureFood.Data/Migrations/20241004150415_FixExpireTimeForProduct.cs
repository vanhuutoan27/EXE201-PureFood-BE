using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PureFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class FixExpireTimeForProduct : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 10, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("25134650-be13-43de-bc40-22a9ea54b543"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 10, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 22, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2adef94c-fa06-4369-89ab-34e71052368e"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("30cfb1b3-da69-4a84-b94c-07ffe79597e0"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 10, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6404ba59-9c63-4192-889b-3448cd7c9ba0"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 25, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 11, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 29, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 10, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7a684d3b-8e9f-4f06-a767-d59c1953f249"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8212e748-fe88-40af-894e-708a376f4fa7"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 10, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 23, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a5c11a08-497c-4846-b922-bb8a95078dd1"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a69cd06b-8762-49cc-9228-1fc88956fb3c"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 3, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 4, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ba9968e6-4ad4-406c-9268-28acd686f73c"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 11, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 10, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 10, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc727800-963c-4305-93a0-3b27dfb1d734"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(2024, 11, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("25134650-be13-43de-bc40-22a9ea54b543"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2adef94c-fa06-4369-89ab-34e71052368e"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("30cfb1b3-da69-4a84-b94c-07ffe79597e0"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6404ba59-9c63-4192-889b-3448cd7c9ba0"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7a684d3b-8e9f-4f06-a767-d59c1953f249"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8212e748-fe88-40af-894e-708a376f4fa7"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a5c11a08-497c-4846-b922-bb8a95078dd1"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a69cd06b-8762-49cc-9228-1fc88956fb3c"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ba9968e6-4ad4-406c-9268-28acd686f73c"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc727800-963c-4305-93a0-3b27dfb1d734"),
                columns: new[] { "EntryDate", "ExpiryDate" },
                values: new object[] { new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
