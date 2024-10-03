using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PureFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class InitialDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AppRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppRoleClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserClaims", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AppUserLogins",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserLogins", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "AppUserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserRoles", x => new { x.RoleId, x.UserId });
                });

            migrationBuilder.CreateTable(
                name: "AppUserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AppUserTokens", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.CategoryId);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Commune = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Province = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TotalAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    OrderStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.OrderId);
                });

            migrationBuilder.CreateTable(
                name: "Promotions",
                columns: table => new
                {
                    PromotionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PromotionName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiscountPercentage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Promotions", x => x.PromotionId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DisplayName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.SupplierId);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FullName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenExpiryTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Avatar = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VipStartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VipExpireDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    LastLoginDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Supplier = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Slug = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    Weight = table.Column<double>(type: "float", nullable: false),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Organic = table.Column<bool>(type: "bit", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    FoodName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EntryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SupplierId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Products_Categories_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "Categories",
                        principalColumn: "CategoryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "SupplierId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Carts",
                columns: table => new
                {
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Carts", x => x.CartId);
                    table.ForeignKey(
                        name: "FK_Carts_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                columns: table => new
                {
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                    table.ForeignKey(
                        name: "FK_Images_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
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

            migrationBuilder.CreateTable(
                name: "Reviews",
                columns: table => new
                {
                    ReviewId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    flag = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UpdatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reviews", x => x.ReviewId);
                    table.ForeignKey(
                        name: "FK_Reviews_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CartItems",
                columns: table => new
                {
                    CartItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CartId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CartItems", x => x.CartItemId);
                    table.ForeignKey(
                        name: "FK_CartItems_Carts_CartId",
                        column: x => x.CartId,
                        principalTable: "Carts",
                        principalColumn: "CartId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CartItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "CreatedAt", "CreatedBy", "Description", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), "rau-cu", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Rau củ quả ngon lành", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), "trai-cay", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Trái cây tươi mới", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "DisplayName", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), null, "Khách Hàng", "Customer", "CUSTOMER" },
                    { new Guid("c0278115-8549-4fad-890a-44f8e8fcc022"), null, "Quản Lý", "Manager", "MANAGER" }
                });

            migrationBuilder.InsertData(
                table: "Suppliers",
                columns: new[] { "SupplierId", "Address", "CreatedAt", "CreatedBy", "Description", "PhoneNumber", "SupplierName", "UpdatedAt", "UpdatedBy" },
                values: new object[,]
                {
                    { new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Quận 9, Thành phố Hồ Chí Minh", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Chúng tôi cung cấp rau củ quả sạch, tươi ngon từ nông trại đến bàn ăn, đảm bảo an toàn sức khỏe cho gia đình bạn.", "0937056922", "PureFood", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null },
                    { new Guid("9b8bc0ba-e6af-4445-8509-390f404c1ea6"), "FPT Quận 9, Thành phố Hồ Chí Minh", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Moncati cung cấp rau củ quả sạch, tươi ngon từ nông trại địa phương, cam kết mang đến sản phẩm an toàn và chất lượng cho sức khỏe gia đình bạn.", "0792766979", "Moncati", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "CreatedAt", "CreatedBy", "Description", "EntryDate", "ExpiryDate", "FoodName", "Organic", "Origin", "Price", "ProductName", "Slug", "Status", "Stock", "SupplierId", "Unit", "UpdatedAt", "UpdatedBy", "Weight" },
                values: new object[,]
                {
                    { new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Rau muống tươi ngon, giàu chất xơ, sản phẩm sạch từ nông trại, có nhiều giá trị dinh dưỡng.</p><br>   <ul><br>      <li>Giàu chất xơ, tốt cho hệ tiêu hóa</li><br>      <li>Giàu vitamin A và C</li><br>      <li>Không thuốc bảo vệ thực vật</li><br>      <li>Thích hợp chế biến các món xào, nấu canh</li><br>      <li>Được trồng tại các nông trại xanh</li><br>    </ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Water spinach", true, "Tỉnh Long An", 8000m, "Rau muống", "rau-muong-400-gr-zk7dwx", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 400.0 },
                    { new Guid("25134650-be13-43de-bc40-22a9ea54b543"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Hành tây tươi, giòn ngọt, giàu vitamin và khoáng chất, thích hợp cho nhiều món ăn.</p><br><ul><br>  <li>Giàu vitamin C và chất chống oxy hóa</li>\r\n  <li>Có tác dụng kháng viêm, tốt cho sức khỏe</li><br>  <li>Không thuốc trừ sâu</li><br>  <li>Thích hợp nấu canh, xào và làm salad</li><br>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Onion", true, "Tỉnh Lâm Đồng", 8750m, "Hành tây", "hanh-tay-500-gr-xowt5w", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500.0 },
                    { new Guid("2adef94c-fa06-4369-89ab-34e71052368e"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Củ cải trắng tươi ngon, giòn ngọt, giàu vitamin và khoáng chất.</p><br><ul><br>  <li>Giàu vitamin C, tốt cho sức khỏe tổng thể</li><br>  <li>Chứa nhiều chất chống oxy hóa</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp làm nộm, nấu canh và xào</li><br>  <li>Trồng tại các nông trại sạch</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daikon radish", true, "Tỉnh Lâm Đồng", 10450m, "Củ cải trắng", "cu-cai-trang-500-gr-8irui7", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500.0 },
                    { new Guid("30cfb1b3-da69-4a84-b94c-07ffe79597e0"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Giá sống tươi mát, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu chất xơ và vitamin E</li><br>  <li>Tốt cho hệ tiêu hóa và làn da</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Dùng trong các món gỏi, xào, và phở</li><br>  <li>Được trồng tại các nông trại xanh</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Bean sprouts", true, "Tỉnh Tiền Giang", 6800m, "Giá sống", "gia-song-200-gr-fb1ihn", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 200.0 },
                    { new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Bắp cải tươi ngon, giòn ngọt, sản phẩm hữu cơ giàu vitamin và chất xơ.</p><br><ul><br>  <li>Giàu vitamin K và C, tốt cho sức khỏe xương và hệ miễn dịch</li><br>  <li>Hàm lượng chất chống oxy hóa cao</li><br> <li>Không sử dụng thuốc trừ sâu</li><br>  <li>Thích hợp chế biến món luộc, xào và salad</li><br>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Cabbage", true, "Tỉnh Lâm Đồng", 12500m, "Bắp cải", "bap-cai-500-gr-rkwi1a", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500.0 },
                    { new Guid("4e31b4e9-0eab-4bbe-b11b-ca52b02b60d5"), new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "\"<p>Ổi nữ hoàng tươi ngon, giòn ngọt, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu vitamin C và chất chống oxy hóa</li>\r\n  <li>Hương vị ngọt mát, thịt quả giòn</li>\r\n  <li>Không dùng thuốc bảo vệ thực vật</li>\r\n  <li>Thích hợp ăn trực tiếp và làm sinh tố</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li>\r\n</ul>\r\n\"", new DateTime(2024, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Guava", true, "Tỉnh Tiền Giang", 23300m, "Ổi nữ hoàng", "oi-nu-hoang-1-kg-0mbfz5", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.0 },
                    { new Guid("557ff79b-b169-409f-aada-9c921c0a69d2"), new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "\"<p>Chuối già Nam Mỹ tươi ngon, giàu dinh dưỡng, sản phẩm nhập khẩu chất lượng cao.</p>\r\n<ul>\r\n  <li>Giàu kali, tốt cho hệ tim mạch</li>\r\n  <li>Chứa nhiều chất xơ, tốt cho hệ tiêu hóa</li>\r\n  <li>Không hóa chất bảo quản</li>\r\n  <li>Thích hợp ăn trực tiếp, làm sinh tố và bánh</li>\r\n  <li>Nhập khẩu từ các trang trại sạch tại Nam Mỹ</li>\r\n</ul>\"", new DateTime(2024, 11, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Banana", true, "Tỉnh Đồng Nai", 22540m, "Chuối già Nam Mỹ", "chuoi-gia-nam-my-1-kg-2ukdtl", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.0 },
                    { new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"), new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Dưa hấu ngọt mát, tươi ngon, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu nước, giúp giải khát hiệu quả</li><br>  <li>Chứa nhiều vitamin A và C</li><br> <li>Không hóa chất bảo quản</li><br>  <li>Thích hợp ăn trực tiếp và làm nước ép</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Watermelon", true, "Tỉnh Long An", 35400m, "Dưa hấu", "dua-hau-2-kg-im862u", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 2.0 },
                    { new Guid("5c70e6fd-c1bd-48f3-b9d8-0b4c2907916c"), new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "\"<p>Chuối cau tươi ngon, ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu kali và chất xơ, tốt cho hệ tiêu hóa</li>\r\n  <li>Chứa nhiều vitamin C và B6</li>\r\n  <li>Không hóa chất bảo quản</li>\r\n  <li>Thích hợp ăn trực tiếp, làm sinh tố và món tráng miệng</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li>\r\n</ul>\r\n\"", new DateTime(2024, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Banana", true, "Tỉnh Đồng Nai", 24600m, "Chuối cau", "chuoi-cau-1-kg-oa64o3", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.0 },
                    { new Guid("6287df0b-b4ff-49e1-9b50-25cbc88a93a2"), new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "\"<p>Dừa xiêm tươi mát, ngọt lành, giàu nước và khoáng chất, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu nước và điện giải, giúp giải nhiệt</li>\r\n  <li>Chứa nhiều khoáng chất có lợi cho sức khỏe</li>\r\n  <li>Không hóa chất bảo quản</li>\r\n  <li>Thích hợp uống trực tiếp, làm nước giải khát</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li>\r\n</ul>\r\n\"", new DateTime(2024, 11, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coconut", true, "Tỉnh Bến Tre", 32000m, "Dừa xiêm", "dua-xiem-1-kg-m5hs6q", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.0 },
                    { new Guid("6404ba59-9c63-4192-889b-3448cd7c9ba0"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Khoai tây tươi, giàu dinh dưỡng, thích hợp cho nhiều món ăn.</p><br><ul><br>  <li>Giàu vitamin C và chất xơ</li><br>  <li>Hàm lượng chất chống oxy hóa cao</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp cho các món chiên, nướng, và hầm</li><br>  <li>Được trồng tại nông trại sạch</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Potato", true, "Tỉnh Lâm Đồng", 30000m, "Khoai tây", "khoai-tay-1-kg-0sls2y", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.0 },
                    { new Guid("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Củ sắn tươi, ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu vitamin C và chất xơ</li><br>  <li>Tốt cho hệ tiêu hóa</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp nấu canh, xào và làm salad</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jicama", true, "Thành phố Tây Ninh", 11500m, "Củ sắn", "cu-san-500-gr-uv72km", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500.0 },
                    { new Guid("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Củ dền tươi, giàu vitamin và khoáng chất, thích hợp cho các món ăn bổ dưỡng.</p><br><ul><br>  <li>Giàu folate và chất sắt, tốt cho máu</li><br>  <li>Chứa nhiều chất chống oxy hóa</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp cho nước ép, nấu canh và salad</li><br>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beetroot", true, "Tỉnh Lâm Đồng", 22500m, "Củ dền", "cu-den-500-gr-wxels8", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500.0 },
                    { new Guid("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Gừng tươi, thơm nồng, giàu chất chống oxy hóa, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu chất chống viêm và kháng khuẩn</li><br>  <li>Giúp tăng cường hệ miễn dịch và hỗ trợ tiêu hóa</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp làm gia vị cho nhiều món ăn</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ginger", true, "Tỉnh Lâm Đồng", 4250m, "Gừng", "gung-50-gr-vc4465", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 50.0 },
                    { new Guid("7a684d3b-8e9f-4f06-a767-d59c1953f249"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Khoai lang ngọt lành, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul>\r\n  <li>Giàu vitamin A và chất xơ</li>\r\n  <li>Tốt cho hệ tiêu hóa và sức khỏe mắt</li>\r\n  <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp nướng, luộc và làm súp</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sweet potato", true, "Thành phố Vĩnh Long", 34000m, "Khoai lang", "khoai-lang-1-kg-hu8kgx", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.0 },
                    { new Guid("8212e748-fe88-40af-894e-708a376f4fa7"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Khoai môn tươi ngon, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul>\r\n  <li>Giàu chất xơ và vitamin B6</li><br>  <li>Tốt cho hệ tiêu hóa và tim mạch</li><br>  <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp cho các món nấu, chiên, và hầm</li><br>  <li>Được trồng tại các nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Taro", true, "Thành phố Bạc Liêu", 26000m, "Khoai môn", "khoai-mon-500-gr-8q8nq9", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500.0 },
                    { new Guid("88d089ad-0259-4b91-aba6-be6cf69a3117"), new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "\"<p>Lựu ngọt tươi ngon, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu vitamin C và chất chống oxy hóa</li>\r\n  <li>Tốt cho sức khỏe tim mạch và hệ miễn dịch</li>\r\n  <li>Không thuốc bảo vệ thực vật</li>\r\n  <li>Thích hợp ăn trực tiếp, làm nước ép và salad</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li>\r\n</ul>\r\n\"", new DateTime(2024, 11, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pomegranate", true, "Tỉnh Tiền Giang", 53000m, "Lựu ngọt", "luu-ngot-1-kg-ft8zwd", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.0 },
                    { new Guid("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Tỏi tươi, vị cay nồng, giàu chất chống oxy hóa, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu chất chống oxy hóa và kháng khuẩn</li><br>  <li>Giúp tăng cường hệ miễn dịch</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp làm gia vị trong các món ăn</li><br>  <li>Trồng tại các nông trại sạch</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Garlic", true, "Tỉnh Kiên Giang", 32000m, "Tỏi cô đơn", "toi-co-don-200-gr-9rmr8t", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 200.0 },
                    { new Guid("a5c11a08-497c-4846-b922-bb8a95078dd1"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Hành tím tươi, vị thơm nồng, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu vitamin C và chất xơ</li><br>  <li>Có tính kháng viêm tự nhiên</li><br> <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp làm gia vị trong nhiều món ăn</li><br>  <li>Được trồng tại nông trại sạch</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Red onion", true, "Tỉnh Sóc Trăng", 15000m, "Hành tím", "hanh-tim-200-gr-aw4230", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 200.0 },
                    { new Guid("a69cd06b-8762-49cc-9228-1fc88956fb3c"), new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Dưa lưới tươi ngon, ngọt mát, giàu dinh dưỡng, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu vitamin A và C, tốt cho sức khỏe</li><br>  <li>Chứa nhiều nước, giúp giải khát</li><br>  <li>Không dùng hóa chất bảo quản</li><br>  <li>Thích hợp ăn trực tiếp và làm sinh tố</li><br>  <li>Trồng tại các nông trại xanh</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Melon", true, "Tỉnh Tiền Giang", 38000m, "Dưa lưới", "dua-luoi-1-kg-vhw1l0", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.0 },
                    { new Guid("a9249592-6bb8-4996-ad0b-0f3cd3c0b335"), new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "\"<p>Táo Gala mini tươi ngon, giòn ngọt, sản phẩm nhập khẩu chất lượng cao.</p>\r\n<ul>\r\n  <li>Giàu chất chống oxy hóa và vitamin C</li>\r\n  <li>Hương vị ngọt thơm, giòn tan</li>\r\n  <li>Không hóa chất bảo quản</li>\r\n  <li>Thích hợp ăn trực tiếp, làm salad và nước ép</li>\r\n  <li>Nhập khẩu từ các trang trại hữu cơ</li>\r\n</ul>\"", new DateTime(2024, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Apple", true, "Tỉnh Lâm Đồng", 44000m, "Táo Gala mini nhập khẩu", "tao-gala-mini-nhap-khau-1-kg-1dyi04", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.0 },
                    { new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"), new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Dưa gang tươi mát, ngọt lành, giàu vitamin và khoáng chất.</p>\r\n<ul>\r\n  <li>Giàu nước và vitamin C</li>\r\n  <li>Giúp giải nhiệt, tốt cho hệ tiêu hóa</li>\r\n  <li>Không hóa chất bảo quản</li>\r\n  <li>Thích hợp ăn trực tiếp và làm nước ép</li>\r\n  <li>Trồng tại các nông trại sạch</li>\r\n</ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Winter melon", true, "Tỉnh Long An", 9000m, "Dưa gang", "dua-gang-1-kg-t0055v", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.0 },
                    { new Guid("ba9968e6-4ad4-406c-9268-28acd686f73c"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Hành lá tươi, xanh non, giàu vitamin và khoáng chất, sản phẩm sạch từ nông trại.</p><br><ul><br> <li>Giàu vitamin A và C</li><br>  <li>Tốt cho sức khỏe mắt và hệ miễn dịch</li><br>  <li>Không thuốc bảo vệ thực vật</li><br>  <li>Thích hợp làm gia vị cho nhiều món ăn</li><br> <li>Trồng tại các nông trại xanh</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Green onion", true, "Thành phố Hồ Chí Minh", 7900m, "Hành lá", "hanh-la-100-gr-hx03dw", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 100.0 },
                    { new Guid("ca15b94b-bebb-4d86-bcbd-29993bf68183"), new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "\"<p>Xoài tứ quý tươi ngon, ngọt thơm, giàu vitamin và khoáng chất.</p>\r\n<ul>\r\n  <li>Giàu vitamin C và chất chống oxy hóa</li>\r\n  <li>Hương vị ngọt thơm, thịt quả vàng ươm</li>\r\n  <li>Không thuốc bảo vệ thực vật</li>\r\n  <li>Thích hợp ăn trực tiếp, làm sinh tố và salad</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li>\r\n</ul>\r\n\"", new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Mango", true, "Tỉnh Đồng Tháp", 37400m, "Xoài tứ quý", "xoai-tu-quy-1-kg-4lsic0", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.0 },
                    { new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Cà rốt tươi ngon, ngọt lành, giàu vitamin A và chất chống oxy hóa.</p><br><ul><br>  <li>Giàu vitamin A, tốt cho mắt</li><br>  <li>Hàm lượng chất chống oxy hóa cao</li><br>  <li>Không dùng hóa chất bảo vệ thực vật</li><br>  <li>Thích hợp cho món nước ép, nấu canh và xào</li><br>  <li>Được trồng tại nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carrot", true, "Tỉnh Lâm Đồng", 11500m, "Cà rốt", "ca-rot-500-gr-xhj7ec", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 500.0 },
                    { new Guid("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"), new Guid("2d482271-9605-4d43-9ca8-d479d6ef9687"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Nấm kim châm tươi ngon, giàu protein và vitamin, sản phẩm sạch từ nông trại.</p><br><ul><br>  <li>Giàu protein, tốt cho sức khỏe tổng thể</li><br>  <li>Chứa nhiều vitamin B và chất chống oxy hóa</li><br>  <li>Không chứa chất hóa học</li><br>  <li>Thích hợp dùng trong lẩu, xào, và món súp</li><br> <li>Trồng tại các nông trại sạch</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Enoki mushrooms", true, "Thành phố Hồ Chí Minh", 11000m, "Nấm kim châm", "nam-kim-cham-150-gr-edwynx", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 150.0 },
                    { new Guid("e4ebe279-a787-406a-bab5-7ae8f99748e4"), new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "\"<p>Cam sành tươi ngon, mọng nước, giàu vitamin C, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu vitamin C, tốt cho sức khỏe tổng thể</li>\r\n  <li>Hương vị ngọt mát, nhiều nước</li>\r\n  <li>Không thuốc bảo vệ thực vật</li>\r\n  <li>Thích hợp ăn trực tiếp và làm nước ép</li>\r\n  <li>Trồng tại các nông trại hữu cơ</li>\r\n</ul>\r\n\"", new DateTime(2024, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orange", true, "Tỉnh Vĩnh Long", 17900m, "Cam sành", "cam-sanh-1-kg-3tqshu", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.0 },
                    { new Guid("ec4b9041-b1f3-4852-82f5-ca357250ab3b"), new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "\"<p>Kiwi xanh tươi ngon, giàu vitamin và chất xơ, sản phẩm nhập khẩu chất lượng cao.</p>\r\n<ul>\r\n  <li>Giàu vitamin C và chất xơ, tốt cho hệ miễn dịch</li>\r\n  <li>Chứa nhiều chất chống oxy hóa</li>\r\n  <li>Không hóa chất bảo quản</li>\r\n  <li>Thích hợp ăn trực tiếp, làm salad và sinh tố</li>\r\n  <li>Nhập khẩu từ các trang trại hữu cơ</li>\r\n</ul>\r\n\"", new DateTime(2024, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Green kiwi", true, "Tỉnh Lâm Đồng", 39000m, "Kiwi xanh", "kiwi-xanh-250-gr-6kodf3", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Gr", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 250.0 },
                    { new Guid("fc727800-963c-4305-93a0-3b27dfb1d734"), new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "<p>Bơ Booth tươi ngon, giàu dinh dưỡng, chứa nhiều chất béo lành mạnh.</p><br><ul><br>  <li>Giàu chất béo không bão hòa, tốt cho tim mạch</li><br>  <li>Chứa nhiều vitamin E và chất xơ</li><br>  <li>Không hóa chất bảo quản</li><br>  <li>Thích hợp làm sinh tố, salad và ăn trực tiếp</li><br>  <li>Trồng tại các nông trại hữu cơ</li><br></ul>", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Avocado", true, "Tỉnh Lâm Đồng", 26000m, "Bơ Booth", "bo-booth-1-kg-n0390m", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.0 },
                    { new Guid("fc8f443e-8f0e-46bf-8061-0a14074c8313"), new Guid("6b5f6458-3791-4303-8ee7-e20707e4cf3e"), new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "\"<p>Cam vàng ngọt thơm, giàu vitamin và khoáng chất, sản phẩm sạch từ nông trại.</p>\r\n<ul>\r\n  <li>Giàu vitamin C, tốt cho hệ miễn dịch</li>\r\n  <li>Chứa nhiều chất chống oxy hóa</li>\r\n  <li>Không dùng hóa chất bảo quản</li>\r\n  <li>Thích hợp làm nước ép, ăn trực tiếp và salad</li>\r\n  <li>Trồng tại các nông trại xanh</li>\r\n</ul>\r\n\"", new DateTime(2024, 11, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 12, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Orange", true, "Tỉnh Đồng Nai", 65000m, "Cam vàng", "cam-vang-1-kg-gwctdn", true, 100, new Guid("5a0b659d-884a-446a-8b77-9b84ed6e2bf2"), "Kg", new DateTime(2024, 10, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 1.0 }
                });

            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "CreatedAt", "CreatedBy", "ProductId", "UpdatedAt", "UpdatedBy", "Url" },
                values: new object[,]
                {
                    { new Guid("0058660f-548f-4a05-9985-35adf77fa17b"), null, null, new Guid("6404ba59-9c63-4192-889b-3448cd7c9ba0"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F11.1.jpg?alt=media&token=0269ab46-401e-4f16-b189-cad618ac7017" },
                    { new Guid("021754a2-9862-48bd-88eb-55ae9574f6b5"), null, null, new Guid("4e31b4e9-0eab-4bbe-b11b-ca52b02b60d5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F30.3.jpg?alt=media&token=c17f2e96-bc02-4cb0-84e2-8a005f35df14" },
                    { new Guid("07902c5d-0e3b-4cff-9d74-69ef534d2d94"), null, null, new Guid("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F4.1.jpg?alt=media&token=b769455f-31cb-453f-97ee-b8f4da757cbc" },
                    { new Guid("09a63769-85fe-4b22-972c-36d809084a5e"), null, null, new Guid("fc727800-963c-4305-93a0-3b27dfb1d734"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F16.1.jpeg?alt=media&token=240f0de8-7539-4c58-8009-275016b88a46" },
                    { new Guid("0c4ba54d-a39a-4c1b-bbb8-c909362fe973"), null, null, new Guid("7a684d3b-8e9f-4f06-a767-d59c1953f249"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F12.1.jpg?alt=media&token=e7794ede-ec4e-411e-a5f3-23bf37bd8c76" },
                    { new Guid("0e853075-8de3-40ab-afa6-5c7246118a47"), null, null, new Guid("ba9968e6-4ad4-406c-9268-28acd686f73c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F17.1.jpg?alt=media&token=1db77c6c-68a5-4908-9391-c88f44688ae8" },
                    { new Guid("0fc41889-3ff8-452b-8b98-e36f80d04360"), null, null, new Guid("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F15.1.jpg?alt=media&token=be4b11c9-8d18-4095-a526-3502120db66a" },
                    { new Guid("113eea99-b426-447c-a608-aaa3f7be7267"), null, null, new Guid("2adef94c-fa06-4369-89ab-34e71052368e"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F14.1.jpg?alt=media&token=45bdde25-32ac-4807-9342-6c11487c11a4" },
                    { new Guid("141b88f2-1fe6-44f9-b9ed-b5230e0948bf"), null, null, new Guid("30cfb1b3-da69-4a84-b94c-07ffe79597e0"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F3.1.jpg?alt=media&token=d0673683-e125-4784-b417-7d91f36b5487" },
                    { new Guid("147470fc-0bbd-4e6d-ada8-b616ebffc343"), null, null, new Guid("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F6.1.jpg?alt=media&token=62b793d8-c754-461d-ae9c-17ae7986bc06" },
                    { new Guid("1594b568-5855-417d-86cb-96c61c6de1b3"), null, null, new Guid("8212e748-fe88-40af-894e-708a376f4fa7"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F10.1.jpg?alt=media&token=84e0916e-a3bf-402b-b584-59a96d2ae1b3" },
                    { new Guid("160e7955-47f7-464a-b819-79c47f106b4d"), null, null, new Guid("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F9.1.jpg?alt=media&token=621021f6-6356-458b-bc10-07d85a6096cd" },
                    { new Guid("18e60ffc-12b9-4dc1-8b59-4512b6d5767e"), null, null, new Guid("5c70e6fd-c1bd-48f3-b9d8-0b4c2907916c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F24.1.jpg?alt=media&token=0b13c635-589d-4d9d-bc42-30a7d542666e" },
                    { new Guid("1b36b25f-9168-4506-8e13-fd62f83acfdc"), null, null, new Guid("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F4.2.jpg?alt=media&token=eaaa7cd4-3448-4d7f-bdef-09a4344cbf27" },
                    { new Guid("1d74d733-8b94-4043-b2e6-717bc76bd604"), null, null, new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F18.1.jpg?alt=media&token=b05ea5eb-c364-4017-9727-b29a9ba39139" },
                    { new Guid("20e00706-46c4-4377-ada6-63e4da568ba1"), null, null, new Guid("a9249592-6bb8-4996-ad0b-0f3cd3c0b335"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F23.4.jpg?alt=media&token=57094db9-01f0-41ab-9b32-f528a469fe59" },
                    { new Guid("20e53d51-ee14-4c74-8ce6-55bf97de4d4b"), null, null, new Guid("5c70e6fd-c1bd-48f3-b9d8-0b4c2907916c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F24.2.jpg?alt=media&token=ae894c3f-27a4-46ca-a926-383d2a60e06e" },
                    { new Guid("23b8737c-f1db-4148-96c4-2858e8be478b"), null, null, new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F5.1.jpg?alt=media&token=98b82bfa-dc94-4960-b091-fe1307b9ee56" },
                    { new Guid("23f35439-253a-49be-9beb-486c8be37c90"), null, null, new Guid("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F15.2.jpg?alt=media&token=47cd5fb6-5261-43ed-9471-6583899e2933" },
                    { new Guid("2416f0a9-bc9e-4ced-a425-af1481ca8c0b"), null, null, new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F18.2.jpg?alt=media&token=f41c8267-27a0-46a1-ac00-183aa7bc303e" },
                    { new Guid("250b5b32-9197-45dd-a85d-f21d5c922737"), null, null, new Guid("a69cd06b-8762-49cc-9228-1fc88956fb3c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F19.1.jpg?alt=media&token=ecfdf322-bb3d-4959-ac7d-36ee2ca2ca98" },
                    { new Guid("2680dadb-277e-49d1-8476-9bb9b57639b2"), null, null, new Guid("88d089ad-0259-4b91-aba6-be6cf69a3117"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F26.2.jpg?alt=media&token=4a91fffc-d70b-4c73-9df0-fe6b82dc1a97" },
                    { new Guid("26fcf3ed-6285-4844-88d1-905b5697dc29"), null, null, new Guid("ca15b94b-bebb-4d86-bcbd-29993bf68183"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F22.3.jpg?alt=media&token=a1bd9ef9-fa13-459c-a702-6b621c6ef679" },
                    { new Guid("29f8c2c4-222c-4c41-adda-5d74e281e6dd"), null, null, new Guid("7a684d3b-8e9f-4f06-a767-d59c1953f249"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F12.2.jpg?alt=media&token=cdc9fd2b-3d64-4242-bc3a-353f5558d8d1" },
                    { new Guid("2ab8bf12-fe94-4d7a-b5b2-577bca108581"), null, null, new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F1.1.jpg?alt=media&token=8aa2db36-a902-45d3-bd89-577a7e1051b9" },
                    { new Guid("2d0634bd-8b5c-4e60-88dc-a2136994ada6"), null, null, new Guid("ca15b94b-bebb-4d86-bcbd-29993bf68183"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F22.2.jpg?alt=media&token=8c77d9ef-ceae-4d97-a280-8b9cf664f667" },
                    { new Guid("2d5909b6-458b-4b15-b6d8-87f5c2698a80"), null, null, new Guid("30cfb1b3-da69-4a84-b94c-07ffe79597e0"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F3.2.jpg?alt=media&token=768cda30-028d-4750-9b40-fc47b06852f6" },
                    { new Guid("2edd5830-ac8d-4281-9a28-cfc1dd3f159e"), null, null, new Guid("a5c11a08-497c-4846-b922-bb8a95078dd1"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F7.1.jpg?alt=media&token=b06321a1-6c26-41f9-b707-0b3fddb44fe7" },
                    { new Guid("3305f179-86ef-45c5-b323-f058e1cef81d"), null, null, new Guid("2adef94c-fa06-4369-89ab-34e71052368e"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F14.2.jpg?alt=media&token=10434244-5b92-4216-9e1a-8929b8a1c1f4" },
                    { new Guid("3416a262-1421-4199-b15d-7c425d68f0ae"), null, null, new Guid("7a684d3b-8e9f-4f06-a767-d59c1953f249"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F12.3.jpg?alt=media&token=f86f1e73-dbdd-4358-8308-d3143655ae2f" },
                    { new Guid("35ea08b1-191b-4fb6-b6e1-8acf76f5785d"), null, null, new Guid("e4ebe279-a787-406a-bab5-7ae8f99748e4"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F28.1.jpg?alt=media&token=3eb98a98-2398-4d0b-93a3-89b67bdd2e84" },
                    { new Guid("37f28f35-fc0b-4501-890d-06419d282d21"), null, null, new Guid("5c70e6fd-c1bd-48f3-b9d8-0b4c2907916c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F24.3.jpg?alt=media&token=29836c7e-983f-4d60-ab37-562d09fe7c81" },
                    { new Guid("38998549-11cb-4574-ba9c-9c8c91c59c31"), null, null, new Guid("25134650-be13-43de-bc40-22a9ea54b543"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F8.1.jpg?alt=media&token=1f0a016a-894a-4000-88e3-747adf1142df" },
                    { new Guid("3c38777b-ee15-4059-9cd0-b063d5d37a5e"), null, null, new Guid("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F6.2.jpg?alt=media&token=6d2437c5-a574-4bc8-9a4a-08c954f66940" },
                    { new Guid("3d460368-b879-4cda-991a-5e5c3db5f40e"), null, null, new Guid("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F4.3.jpg?alt=media&token=c2db8a67-158e-4d73-80aa-bcdcca6f1ad9" },
                    { new Guid("3e68861e-8ca4-4821-b145-de55067335d4"), null, null, new Guid("ba9968e6-4ad4-406c-9268-28acd686f73c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F17.2.jpg?alt=media&token=f2f3d557-46fd-4f54-82b3-17077ab6cca5" },
                    { new Guid("427880a9-3a3e-40c9-96d9-6c64dc6a2b84"), null, null, new Guid("8212e748-fe88-40af-894e-708a376f4fa7"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F10.2.jpg?alt=media&token=662ba6e6-79ae-4326-9e3b-1f266b06141e" },
                    { new Guid("43f77651-ab4f-4af9-8f58-be8d2790aa15"), null, null, new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F20.1.jpg?alt=media&token=2db339d6-5004-4dce-ab54-9b2377bff2a6" },
                    { new Guid("4be2e1cb-8502-4cd9-92f2-50fce7150af9"), null, null, new Guid("ec4b9041-b1f3-4852-82f5-ca357250ab3b"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F27.5.jpg?alt=media&token=d547bde3-c871-4788-a63a-3d25c1b44b2f" },
                    { new Guid("4c1a249c-a716-4ba3-9647-167c0a2e2d13"), null, null, new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F5.4.jpg?alt=media&token=36b36199-cec7-4421-bb43-1be5d9f90560" },
                    { new Guid("52b1b4ac-f0c1-406e-b30f-7b1981327327"), null, null, new Guid("ba9968e6-4ad4-406c-9268-28acd686f73c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F17.3.jpg?alt=media&token=0646948b-03c0-4417-8327-be728a121e63" },
                    { new Guid("56391da7-a3f5-4c8e-a5f6-f57abcf7f3e6"), null, null, new Guid("8212e748-fe88-40af-894e-708a376f4fa7"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F10.3.jpg?alt=media&token=5f1f19a4-1480-4ffe-8c54-c498342ff817" },
                    { new Guid("57e82ced-a474-4685-9cfb-ad4dad660e3b"), null, null, new Guid("e4ebe279-a787-406a-bab5-7ae8f99748e4"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F28.3.jpg?alt=media&token=66352262-c0aa-4b17-b4b2-e018a2c6aa34" },
                    { new Guid("5873d292-a96f-44dc-8eb0-0340fb107c34"), null, null, new Guid("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F6.3.jpg?alt=media&token=00501803-2f9e-4d22-9e64-94211c171309" },
                    { new Guid("5ac66b04-463e-4fff-a379-a2d5068f516c"), null, null, new Guid("25134650-be13-43de-bc40-22a9ea54b543"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F8.2.jpg?alt=media&token=0a7802f0-17c9-4e8f-a6f8-38278ad0213d" },
                    { new Guid("5b12c8f3-3a8e-436c-9c03-a6bdfa7d9e26"), null, null, new Guid("ec4b9041-b1f3-4852-82f5-ca357250ab3b"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F27.6.jpg?alt=media&token=244e0070-c373-4833-a87c-25d11cb513a1" },
                    { new Guid("5bedca84-0826-4525-8961-3a4b5f3d4488"), null, null, new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F1.2.jpg?alt=media&token=5ed9e2ad-a0ab-4144-bb83-b7a0bc943f79" },
                    { new Guid("5cbbc62b-f328-4789-8c4b-bcac23488f9a"), null, null, new Guid("557ff79b-b169-409f-aada-9c921c0a69d2"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F21.3.jpg?alt=media&token=5064bef3-b49e-4e6b-b7cc-fdc0f0b9d2c0" },
                    { new Guid("64fcbca1-fdf4-4e9a-b841-29086da16f36"), null, null, new Guid("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F9.2.jpg?alt=media&token=6648b26a-153e-4bab-a22a-3c58693db145" },
                    { new Guid("68f9bd1e-fd66-45fb-8c7c-41cb7c3a69e9"), null, null, new Guid("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F13.1.jpg?alt=media&token=38cb92b8-6399-40df-9865-ee7eeae02616" },
                    { new Guid("6ce3b5dc-20ab-48d0-bef1-d8320ffdf317"), null, null, new Guid("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F6.5.jpg?alt=media&token=aa7aa923-c490-40fe-82e5-3f6d1103ea6e" },
                    { new Guid("6e35ff78-1205-4164-bf2e-2d91af27f405"), null, null, new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F20.2.jpg?alt=media&token=516e44b7-6f8b-4db7-a610-0a3eeb063745" },
                    { new Guid("6f86b276-f7d6-4b4c-82a0-b5f0afba76ed"), null, null, new Guid("25134650-be13-43de-bc40-22a9ea54b543"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F8.3.jpg?alt=media&token=9d08e1b6-3feb-4f64-a517-f2550b86d674" },
                    { new Guid("7108b731-0a30-4be6-a1c1-ae5e72ba0d3a"), null, null, new Guid("2adef94c-fa06-4369-89ab-34e71052368e"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F14.3.jpg?alt=media&token=e0274537-66f5-43dd-8fea-58da0741f760" },
                    { new Guid("7124f9ce-7b64-4771-8486-f0cbb389468f"), null, null, new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F5.2.jpg?alt=media&token=4ed5345b-9f3f-4205-a477-8883ccdd5a54" },
                    { new Guid("7417048d-2ac0-456a-b53f-1841f7ab3f56"), null, null, new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F1.3.jpg?alt=media&token=85f219cc-ca82-4f76-8813-4b2d01396a54" },
                    { new Guid("74a5cdda-708a-4be2-8507-5f2f00c42883"), null, null, new Guid("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F13.5.jpg?alt=media&token=5c80780a-68ac-44ec-b369-80b5b92f9ef5" },
                    { new Guid("78451019-0a26-4c82-a556-8ebdab944d35"), null, null, new Guid("e4ebe279-a787-406a-bab5-7ae8f99748e4"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F28.4.jpg?alt=media&token=6eb34cbd-e2da-445e-9f49-24a06fca8432" },
                    { new Guid("7a68e2f2-6e50-4cf4-b5a5-e9d57a64c090"), null, null, new Guid("6287df0b-b4ff-49e1-9b50-25cbc88a93a2"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F25.3.jpg?alt=media&token=ca1d9049-39df-4d89-8cc9-2eff45d87792" },
                    { new Guid("7ac6747c-4efd-41fb-88fe-f123808aa245"), null, null, new Guid("4e31b4e9-0eab-4bbe-b11b-ca52b02b60d5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F30.1.jpg?alt=media&token=824933bd-8ef6-4449-9eca-5e7427231c1b" },
                    { new Guid("7ade8654-3f80-45f2-8da9-3dda1e276ec4"), null, null, new Guid("a5c11a08-497c-4846-b922-bb8a95078dd1"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F7.2.jpg?alt=media&token=7ea8139c-2195-4b99-9b0a-ffc1c34f35ab" },
                    { new Guid("7c3a7376-0d8a-42d8-86ba-00f3fea43b77"), null, null, new Guid("ec4b9041-b1f3-4852-82f5-ca357250ab3b"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F27.3.jpg?alt=media&token=3f7ebe66-c153-4b50-bc7d-405100655377" },
                    { new Guid("804570c3-50c4-49f4-8ea4-942e5e2a2e4c"), null, null, new Guid("ca15b94b-bebb-4d86-bcbd-29993bf68183"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F22.1.jpg?alt=media&token=30359a88-5ef4-421a-b325-882162b89d55" },
                    { new Guid("80974c62-29d2-4db0-a32e-83ca74cb3383"), null, null, new Guid("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F9.3.jpg?alt=media&token=71642a0b-ade9-45c7-9a4e-0d3bf8aefb08" },
                    { new Guid("8178c865-b35f-42a1-97e2-dbe31e72d5f2"), null, null, new Guid("4e31b4e9-0eab-4bbe-b11b-ca52b02b60d5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F30.4.jpg?alt=media&token=a2489348-e804-4c69-a530-42b4a78646dc" },
                    { new Guid("81d44c50-ade1-4913-899d-8ab35f14fe1c"), null, null, new Guid("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F15.4.jpg?alt=media&token=639dec84-1a77-4acf-ac8d-bbe45c7c0ec1" },
                    { new Guid("8343259c-e9e4-487d-b99e-d87ffc722876"), null, null, new Guid("88d089ad-0259-4b91-aba6-be6cf69a3117"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F26.3.jpg?alt=media&token=a689a7fb-a271-42fa-a98f-532fbca1c71b" },
                    { new Guid("870d103c-6a41-4037-8512-a50552570ae5"), null, null, new Guid("fc727800-963c-4305-93a0-3b27dfb1d734"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F16.2.jpeg?alt=media&token=373fbcd2-ae1f-4edb-951d-050edf0fddce" },
                    { new Guid("87274e3d-fe6a-43a9-abb2-e6ab21e2a619"), null, null, new Guid("fc8f443e-8f0e-46bf-8061-0a14074c8313"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F29.4.jpg?alt=media&token=de9a1f46-7c46-47e0-aa5f-33e10b2c8314" },
                    { new Guid("87b04ea4-acbb-48c0-9154-41b58c4c454c"), null, null, new Guid("25134650-be13-43de-bc40-22a9ea54b543"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F8.4.jpg?alt=media&token=de43b4c1-b3a3-4d88-a61c-3f72ea8ca7dd" },
                    { new Guid("8c2ca84e-490d-4275-b4f7-a6b3648d90b4"), null, null, new Guid("6287df0b-b4ff-49e1-9b50-25cbc88a93a2"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F25.2.jpg?alt=media&token=3304d126-2853-4e16-9bb4-34ed6caeb36b" },
                    { new Guid("8f2ee0a0-9020-4d31-9023-6a989d4a6c27"), null, null, new Guid("88d089ad-0259-4b91-aba6-be6cf69a3117"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F26.1.jpg?alt=media&token=bb335379-6993-423e-8705-b454bc238c36" },
                    { new Guid("8fe30c3d-845e-4ff3-b31d-2d58438c9f48"), null, null, new Guid("fc8f443e-8f0e-46bf-8061-0a14074c8313"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F29.2.jpg?alt=media&token=63890240-9346-48a8-a9be-94a51eaa0d99" },
                    { new Guid("905e459e-99e7-44f7-98a0-cf42c77229f4"), null, null, new Guid("a5c11a08-497c-4846-b922-bb8a95078dd1"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F7.3.jpg?alt=media&token=7c6000f6-66b6-4020-83f3-089812857d31" },
                    { new Guid("9104c42b-bf99-4135-a8f6-631038505d77"), null, null, new Guid("fc8f443e-8f0e-46bf-8061-0a14074c8313"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F29.3.jpg?alt=media&token=f29aab3f-c366-4aba-bd48-01ed611fad13" },
                    { new Guid("9856e332-caf4-406e-9ac4-647eaa797a74"), null, null, new Guid("6404ba59-9c63-4192-889b-3448cd7c9ba0"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F11.2.jpg?alt=media&token=0721c18d-3b51-4266-89ac-c5c7442bc59c" },
                    { new Guid("9a6b98af-6603-4ad6-ae62-b82389c5d8bd"), null, null, new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F5.3.jpg?alt=media&token=9bd2b6a8-8d07-4172-892c-c06b26c661dc" },
                    { new Guid("9b1cbb0b-d8b3-4d81-ab32-d877eac08181"), null, null, new Guid("6287df0b-b4ff-49e1-9b50-25cbc88a93a2"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F25.1.jpg?alt=media&token=9e2cffd4-db3e-4fe8-b41e-86d8adef2851" },
                    { new Guid("9b59ee88-21f1-44ac-ad0a-d843ed7802c5"), null, null, new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F18.3.jpg?alt=media&token=d61ca12f-1e94-4b50-a420-a4a83e0ccfc1" },
                    { new Guid("9f082e52-10db-4508-adf9-58f12b3e8c82"), null, null, new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F2.1.jpg?alt=media&token=9ebd04cb-02b4-4662-8618-53791f069691" },
                    { new Guid("a4c1308e-4825-429b-8a92-b39872aeb632"), null, null, new Guid("557ff79b-b169-409f-aada-9c921c0a69d2"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F21.2.jpg?alt=media&token=1c808bf8-28b8-45cb-bbcc-9e76e190d756" },
                    { new Guid("adc3f002-d829-4d0f-9311-5695c3b024cf"), null, null, new Guid("30cfb1b3-da69-4a84-b94c-07ffe79597e0"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F3.3.jpg?alt=media&token=a6782085-e680-4bd7-98be-4bbbf1755a51" },
                    { new Guid("afd40e26-3e41-421d-8b74-fd35ff43cade"), null, null, new Guid("a69cd06b-8762-49cc-9228-1fc88956fb3c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F19.2.jpg?alt=media&token=5aec55ad-ad90-448b-9ae6-38c2181a7a28" },
                    { new Guid("b68030d5-8fa1-4df6-8193-b92a6f21d14b"), null, null, new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F2.2.jpg?alt=media&token=75e12cd9-1e2f-4b83-be28-629f06529e91" },
                    { new Guid("ba1c8207-42ac-41c3-a4b8-c5cf7e1e0b84"), null, null, new Guid("a9249592-6bb8-4996-ad0b-0f3cd3c0b335"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F23.3.jpg?alt=media&token=0eea1393-015c-4899-85c7-229a48b5c95c" },
                    { new Guid("bf6af744-6d8f-4ca1-8720-0554a9d11fcb"), null, null, new Guid("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F4.4.jpg?alt=media&token=455b20e2-a6c7-4889-90ef-28f547b08790" },
                    { new Guid("c1c1bc06-7d76-4f4b-987d-d4c3efbf5901"), null, null, new Guid("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F9.4.jpg?alt=media&token=0883a03b-33db-45b2-8973-f240e16e9b1b" },
                    { new Guid("c86a9368-330f-45e0-b8c1-ce6fc0bd69a5"), null, null, new Guid("557ff79b-b169-409f-aada-9c921c0a69d2"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F21.4.jpg?alt=media&token=715716b8-f6e2-43ad-a99d-dcd4af118f65" },
                    { new Guid("c967abff-64b4-4f94-8c17-e77030c079ef"), null, null, new Guid("557ff79b-b169-409f-aada-9c921c0a69d2"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F21.1.jpg?alt=media&token=34a71077-247f-4055-b904-e83ff313149b" },
                    { new Guid("cc0959cf-1c87-4fa5-9554-39e298e71f17"), null, null, new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F2.3.jpg?alt=media&token=ffc5cba6-f45f-43d4-a2ae-d181efc60d32" },
                    { new Guid("d2d09122-d518-4a57-9dbe-f34c5486f54e"), null, null, new Guid("a9249592-6bb8-4996-ad0b-0f3cd3c0b335"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F23.1.jpg?alt=media&token=89866b0d-5eec-4f5a-8c9b-9eaa2459926b" },
                    { new Guid("d5e6cb4e-20c7-4e82-bee8-4142ac208b7a"), null, null, new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F2.4.jpg?alt=media&token=b0fa6d72-c3f6-4eb1-a260-00a9e002b6a5" },
                    { new Guid("dc1d2736-c849-4d4c-9817-6f19031c0b16"), null, null, new Guid("a69cd06b-8762-49cc-9228-1fc88956fb3c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F19.3.jpg?alt=media&token=404b341d-64f9-4ca5-a5d5-cae220042c5e" },
                    { new Guid("df705ccd-c062-45df-ac5e-49bedb874971"), null, null, new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F20.3.jpg?alt=media&token=ecdffbec-29d1-4f1d-9ddf-616f92a3b15d" },
                    { new Guid("e7556fef-42a8-4494-bdd5-bc39a7cce1aa"), null, null, new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F18.4.jpg?alt=media&token=f9bddef4-1395-485e-9513-445289e0ef74" },
                    { new Guid("e8c72f17-ee56-4417-adbd-c03780914cf3"), null, null, new Guid("ec4b9041-b1f3-4852-82f5-ca357250ab3b"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F27.1.jpg?alt=media&token=d954ccd7-d969-463f-a80a-4da254da10ec" },
                    { new Guid("ea3b8e36-f677-441e-8c0d-82cb5856fa85"), null, null, new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F1.4.jpg?alt=media&token=7cdbdbd1-c9d2-44ea-9472-24a8ad85fc18" },
                    { new Guid("eb5ee868-c10f-4afe-8606-91f1752e8b26"), null, null, new Guid("fc727800-963c-4305-93a0-3b27dfb1d734"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F16.3.jpeg?alt=media&token=973e8efd-51e9-483d-9d87-2498bf0c3240" },
                    { new Guid("ebc736a8-05df-41d8-872a-368749bb14b6"), null, null, new Guid("30cfb1b3-da69-4a84-b94c-07ffe79597e0"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F3.4.jpg?alt=media&token=9b436fa5-ff2a-4bd9-99d1-50cad660d704" },
                    { new Guid("ed53b62e-1a70-4a11-bba8-efe527a63f47"), null, null, new Guid("ba9968e6-4ad4-406c-9268-28acd686f73c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F17.4.jpg?alt=media&token=7e88e4c0-3b8e-4749-aa0a-f69d53e24f69" },
                    { new Guid("ef6eac44-2380-4ff0-aa3c-22388b440b2e"), null, null, new Guid("a9249592-6bb8-4996-ad0b-0f3cd3c0b335"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F23.2.jpg?alt=media&token=f79a61d0-2bdb-4b50-a006-044fe1478ec9" },
                    { new Guid("faefcbb4-37d7-4175-ba5e-610b09283a2c"), null, null, new Guid("e4ebe279-a787-406a-bab5-7ae8f99748e4"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F28.2.jpg?alt=media&token=89c90c2d-8d09-417f-9391-dad2c97b25ee" },
                    { new Guid("fb4ca598-f62a-419e-a94d-7f03d30944fb"), null, null, new Guid("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F13.4.jpg?alt=media&token=eb410528-7cac-4971-a0b1-02da1096b227" },
                    { new Guid("fcdf373d-62f8-4bc2-a6cb-fb57e984ce1b"), null, null, new Guid("4e31b4e9-0eab-4bbe-b11b-ca52b02b60d5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F30.2.jpg?alt=media&token=9c7bc3be-28d5-4219-9b04-756058aafc25" },
                    { new Guid("fd927a8e-a6f5-4d22-b593-e9aec49d6fd7"), null, null, new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F20.4.jpg?alt=media&token=0fb153d2-b1b5-4ae7-a823-f802cd9bc952" },
                    { new Guid("fe6aeb73-17cc-4d83-91fe-7b009ceb0091"), null, null, new Guid("fc727800-963c-4305-93a0-3b27dfb1d734"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F16.4.jpeg?alt=media&token=0ad2cedb-da0e-45d0-85f2-e01def24e449" },
                    { new Guid("fe925dc4-bbd5-4d5d-a13b-1f3a6ee6628e"), null, null, new Guid("6404ba59-9c63-4192-889b-3448cd7c9ba0"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F11.3.jpg?alt=media&token=9b3e318d-63e3-47ec-968f-8bd053f1fc15" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_CartId",
                table: "CartItems",
                column: "CartId");

            migrationBuilder.CreateIndex(
                name: "IX_CartItems_ProductId",
                table: "CartItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Carts_UserId",
                table: "Carts",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_ProductId",
                table: "Images",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_OrderId",
                table: "OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderItems_ProductId",
                table: "OrderItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_CategoryId",
                table: "Products",
                column: "CategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Reviews_ProductId",
                table: "Reviews",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AppRoleClaims");

            migrationBuilder.DropTable(
                name: "AppUserClaims");

            migrationBuilder.DropTable(
                name: "AppUserLogins");

            migrationBuilder.DropTable(
                name: "AppUserRoles");

            migrationBuilder.DropTable(
                name: "AppUserTokens");

            migrationBuilder.DropTable(
                name: "CartItems");

            migrationBuilder.DropTable(
                name: "Images");

            migrationBuilder.DropTable(
                name: "OrderItems");

            migrationBuilder.DropTable(
                name: "Promotions");

            migrationBuilder.DropTable(
                name: "Reviews");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Carts");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Suppliers");
        }
    }
}
