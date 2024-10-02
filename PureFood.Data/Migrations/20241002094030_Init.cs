using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PureFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Users");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commune = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "OrderItems",
                columns: table => new
                {
                    OrderItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderItems", x => x.OrderItemId);
                    table.ForeignKey(
                        name: "FK_OrderItems_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tỉnh Long An", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("25134650-be13-43de-bc40-22a9ea54b543"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tỉnh Lâm Đồng", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2adef94c-fa06-4369-89ab-34e71052368e"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tỉnh Lâm Đồng", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("30cfb1b3-da69-4a84-b94c-07ffe79597e0"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tỉnh Tiền Giang", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tỉnh Lâm Đồng", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"),
                columns: new[] { "CreatedAt", "FoodName", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melon", "Tỉnh Long An", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6404ba59-9c63-4192-889b-3448cd7c9ba0"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tỉnh Lâm Đồng", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thành phố Tây Ninh", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tỉnh Lâm Đồng", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tỉnh Lâm Đồng", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7a684d3b-8e9f-4f06-a767-d59c1953f249"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thành phố Vĩnh Long", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8212e748-fe88-40af-894e-708a376f4fa7"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thành phố Bạc Liêu", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tỉnh Kiên Giang", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a5c11a08-497c-4846-b922-bb8a95078dd1"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tỉnh Sóc Trăng", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a69cd06b-8762-49cc-9228-1fc88956fb3c"),
                columns: new[] { "CreatedAt", "Origin", "ProductName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tỉnh Tiền Giang", "Dưa lưới", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tỉnh Long An", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ba9968e6-4ad4-406c-9268-28acd686f73c"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thành phố Hồ Chí Minh", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tỉnh Lâm Đồng", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"),
                columns: new[] { "CreatedAt", "Origin", "ProductName", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thành phố Hồ Chí Minh", "Nấm kim châm", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc727800-963c-4305-93a0-3b27dfb1d734"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tỉnh Lâm Đồng", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"),
                column: "DisplayName",
                value: "Quản Lý");

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"),
                columns: new[] { "CreatedAt", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Suppliers",
                keyColumn: "SupplierId",
                keyValue: new Guid("9b8bc0ba-e6af-4445-8509-390f404c1ea6"),
                columns: new[] { "CreatedAt", "PhoneNumber", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), "0792766979", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Users",
                table: "Users");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Users",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Users",
                table: "Users",
                column: "UserId");

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Long An", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("25134650-be13-43de-bc40-22a9ea54b543"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Lâm Đồng", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("2adef94c-fa06-4369-89ab-34e71052368e"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Lâm Đồng", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("30cfb1b3-da69-4a84-b94c-07ffe79597e0"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Tiền Giang", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Lâm Đồng", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"),
                columns: new[] { "CreatedAt", "FoodName", "Origin", "UpdatedAt" },
                values: new object[] { null, "Watermelon", "Long An", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6404ba59-9c63-4192-889b-3448cd7c9ba0"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Lâm Đồng", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Tây Ninh", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Lâm Đồng", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Lâm Đồng", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("7a684d3b-8e9f-4f06-a767-d59c1953f249"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Vĩnh Long", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8212e748-fe88-40af-894e-708a376f4fa7"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Bạc Liêu", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Kiên Giang", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a5c11a08-497c-4846-b922-bb8a95078dd1"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Sóc Trăng", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("a69cd06b-8762-49cc-9228-1fc88956fb3c"),
                columns: new[] { "CreatedAt", "Origin", "ProductName", "UpdatedAt" },
                values: new object[] { null, "Tiền Giang", "Melon", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Long An", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("ba9968e6-4ad4-406c-9268-28acd686f73c"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "TP. Hồ Chí Minh", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Lâm Đồng", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"),
                columns: new[] { "CreatedAt", "Origin", "ProductName", "UpdatedAt" },
                values: new object[] { null, "Tp.Hồ Chí Minh", "Giá sống", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("fc727800-963c-4305-93a0-3b27dfb1d734"),
                columns: new[] { "CreatedAt", "Origin", "UpdatedAt" },
                values: new object[] { null, "Lâm Đồng", null });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"),
                column: "DisplayName",
                value: "Quản Lí");

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
                columns: new[] { "CreatedAt", "PhoneNumber", "UpdatedAt" },
                values: new object[] { new DateTime(2024, 10, 1, 13, 14, 28, 908, DateTimeKind.Local).AddTicks(8830), "0937056922", new DateTime(2024, 10, 1, 13, 14, 28, 908, DateTimeKind.Local).AddTicks(8830) });

            migrationBuilder.AddForeignKey(
                name: "FK_Carts_Users_UserId",
                table: "Carts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
