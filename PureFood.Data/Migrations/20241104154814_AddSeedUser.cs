using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PureFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AppUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("1c86023b-f752-45f7-9b81-d1578f3c8656") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("1e31f456-ae49-4cd8-84e6-3ba44ef02741") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("37405a14-450c-4832-8c8a-4d2795a669cf") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("3b3f2afd-8beb-40fb-8215-b27d8c4e58d2") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("400b82a8-1e71-40ec-8d22-c55de7a2d73a") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("45378137-f980-4b34-85c7-cf4295f76c06") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("453f0a92-6b94-43f9-99db-401a7ea21554") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("5b07199c-5eba-40eb-86ba-73c2d021a765") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("69fa2bb9-1772-4631-a3c8-ca9ad6cf8c5a") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("83521853-7cca-445d-8e74-b04fbfd0efc1") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("854b3c85-0392-440e-b87a-e3da3c3c4859") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("87cc052b-db3b-441d-8c1c-dd38de9b54b9") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("93b7c022-30e4-4778-b685-ba9f57806e90") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("954c2b9c-24a8-4f16-bd18-7faa595b4332") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("9b34361d-a77c-4fdf-aca3-bd0959662c67") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("9cdb97c4-bb7d-4c5a-9fd6-12d3cdc37b75") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("a8bcae5d-ff12-4735-a792-f6b3cafe9b0b") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("b9488156-b13d-4118-be15-006b79f94a77") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("c5a1e207-7693-4d66-a0e4-032ae6bea9bc") },
                    { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("ceee02c2-122d-4346-b07b-559ad92e2d98") }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"),
                column: "Description",
                value: "<h4>Rau muống tươi ngon, giàu chất xơ, sản phẩm sạch từ nông trại, có nhiều giá trị dinh dưỡng.</h4> <ul> <li>Giàu chất xơ, tốt cho hệ tiêu hóa</li> <li>Giàu vitamin A và C</li> <li>Không thuốc bảo vệ thực vật</li> <li>Thích hợp chế biến các món xào, nấu canh</li> <li>Được trồng tại các nông trại xanh</li> </ul>");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "Avatar", "ConcurrencyStamp", "CreatedAt", "CreatedBy", "Dob", "Email", "EmailConfirmed", "FullName", "Gender", "LastLoginDate", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RefreshToken", "RefreshTokenExpiryTime", "SecurityStamp", "Status", "Supplier", "TwoFactorEnabled", "UpdatedAt", "UpdatedBy", "UserName", "VipExpireDate", "VipStartDate" },
                values: new object[,]
                {
                    { new Guid("1c86023b-f752-45f7-9b81-d1578f3c8656"), 0, null, null, "6226ebad-720e-46f4-a71e-3f6f9d15b142", null, null, null, "tranhuubao@gmail.com", true, "Trần Hữu Bảo", null, null, false, null, "TRANHUUBAO@GMAIL.COM", "HUUBAO18", "AQAAAAIAAYagAAAAEPDY5wnqkp6fgOaaP/3UdjQsBdwCmpT4mdg1wwF6K4VrOUu54GwWYBW8v7xuQC2AjQ==", "0978901234", false, null, null, "3ac3566d-bad7-4928-8c6f-aad269377ee7", false, false, false, null, null, "huubao18", null, null },
                    { new Guid("1e31f456-ae49-4cd8-84e6-3ba44ef02741"), 0, null, null, "dd1435d5-8f07-4907-b932-d7a5eb0201ce", null, null, null, "doviettuan@gmail.com", true, "Đỗ Việt Tuấn", null, null, false, null, "DOVIETTUAN@GMAIL.COM", "VIETTUAN05", "AQAAAAIAAYagAAAAEDy9vSyTSPp5vWplWiW+VA7Ic97SYr+zFZwvbCLsL5QBNJS3zS9kB+N15ZWDF5kx/A==", "0985678901", false, null, null, "16296e37-6cef-4751-99c0-30102aed411f", false, false, false, null, null, "viettuan05", null, null },
                    { new Guid("37405a14-450c-4832-8c8a-4d2795a669cf"), 0, null, null, "abe8485d-7f93-4abf-913e-3bab77069a02", null, null, null, "voanhtuan@gmail.com", true, "Võ Anh Tuấn", null, null, false, null, "VOANHTUAN@GMAIL.COM", "ANHTUAN06", "AQAAAAIAAYagAAAAEI+RbngvWniGvTns7Sy72bF5NGIS6CFHuTDO5uX6+Kuh5Z2sJrRl5gTlQ9va3ltOLw==", "0986789012", false, null, null, "78d67bb3-138d-4692-a2fd-358dc419deb0", false, false, false, null, null, "anhtuan06", null, null },
                    { new Guid("3b3f2afd-8beb-40fb-8215-b27d8c4e58d2"), 0, null, null, "46bd9efb-5acc-45fe-87d4-1f6299af2973", null, null, null, "vothihongyen@gmail.com", true, "Võ Thị Hồng Yến", null, null, false, null, "VOTHIHONGYEN@GMAIL.COM", "HONGYEN16", "AQAAAAIAAYagAAAAEKhWVNVPrOwczdmBq+a1ZKErz3YK/eGg7HgVucgvtzue5kwAClOXYvhicrCkHaQ4Eg==", "0976789012", false, null, null, "40975f71-ce39-4ec8-a333-5cd3f2510fc4", false, false, false, null, null, "hongyen16", null, null },
                    { new Guid("400b82a8-1e71-40ec-8d22-c55de7a2d73a"), 0, null, null, "42ca502d-f17e-45fd-8b12-d1bf73d162b1", null, null, null, "vohonghoa@gmail.com", true, "Võ Hồng Hoa", null, null, false, null, "VOHONGHOA@GMAIL.COM", "HONGHOA11", "AQAAAAIAAYagAAAAEJNESVbeHNrfENIwHSeZKgxYO8MdY4vW4oee/Bg+Gk0YSf0YvV77UlWxQ4Xn9UVXPg==", "0971234567", false, null, null, "a63a890f-48f1-4ebf-b2d7-c3f07038d2a2", false, false, false, null, null, "honghoa11", null, null },
                    { new Guid("45378137-f980-4b34-85c7-cf4295f76c06"), 0, null, null, "02ca4e47-3465-408f-8987-a704d78777fb", null, null, null, "phamlinhchi@gmail.com", true, "Phạm Linh Chi", null, null, false, null, "PHAMLINHCHI@GMAIL.COM", "LINHCHI20", "AQAAAAIAAYagAAAAEIXoyP+bd+xr+XvDtJERdOtySCxbmF3xrWvBywhh+Kxn8OyNqto+9Vkhi5AQcLhtsQ==", "0960123456", false, null, null, "7673baaf-7c7d-4a80-9169-8bda614ef9b7", false, false, false, null, null, "linhchi20", null, null },
                    { new Guid("453f0a92-6b94-43f9-99db-401a7ea21554"), 0, null, null, "3c47ab2d-5691-40f3-ae13-c197695dfdd0", null, null, null, "nguyentrungdinh@gmail.com", true, "Nguyễn Trung Đình", null, null, false, null, "NGUYENTRUNGDINH@GMAIL.COM", "TRUNGDINH10", "AQAAAAIAAYagAAAAEEl9V1Eo0dte9o47fOketoxRT9ruZ6rF3Vy0jSbcFvJMuENZdrppS579I6hBzesrEQ==", "0970123456", false, null, null, "7a17dd72-ee10-494a-bfad-7b85b48f42cd", false, false, false, null, null, "trungdinh10", null, null },
                    { new Guid("5b07199c-5eba-40eb-86ba-73c2d021a765"), 0, null, null, "fb5201be-2239-4ed9-97a1-f29998ec13b7", null, null, null, "tranhoathi@gmail.com", true, "Trần Hoa Thị", null, null, false, null, "TRANHOATHI@GMAIL.COM", "MINHHOANG01", "AQAAAAIAAYagAAAAEPmGeTXNT5r4LW4eeIlZZtS8FNRxm1cDrf7+fb6rc0eKw/ZoXiYAZxUat0pFbLBe+g==", "0981234567", false, null, null, "94d2c9de-4d34-4643-9f45-fa4f566241c6", false, false, false, null, null, "minhhoang01", null, null },
                    { new Guid("69fa2bb9-1772-4631-a3c8-ca9ad6cf8c5a"), 0, null, null, "4994867a-2538-494c-b221-c90faeb98368", null, null, null, "phamthaohong@gmail.com", true, "Phạm Thảo Hồng", null, null, false, null, "PHAMTHAOHONG@GMAIL.COM", "THAOHONG04", "AQAAAAIAAYagAAAAEBzyPLBPFy0BVZQWVBwjhBcHt+31csmcHcRVG+wVVoE2haVKVwDfyr1+2rtQQXr58A==", "0984567890", false, null, null, "056e3db8-993e-4cd0-b72a-b6ce966dc7db", false, false, false, null, null, "thaohong04", null, null },
                    { new Guid("83521853-7cca-445d-8e74-b04fbfd0efc1"), 0, null, null, "2fac6e64-7053-4dd0-b4dd-ee02feb308e4", null, null, null, "tranthihongnga@gmail.com", true, "Trần Thị Hồng Nga", null, null, false, null, "TRANTHIHONGNGA@GMAIL.COM", "HONGNGA14", "AQAAAAIAAYagAAAAEDwTILkxHM4cmUL9hIhMewXLAF1/LMZBoTUmKd//dNm5S1RZyeKCFl+9VnBdPsT81A==", "0974567890", false, null, null, "a8ed5825-6766-4288-9f95-8491d046ecdc", false, false, false, null, null, "hongnga14", null, null },
                    { new Guid("854b3c85-0392-440e-b87a-e3da3c3c4859"), 0, null, null, "189a9ede-4b99-4112-afef-bb49fdd3e0c9", null, null, null, "nguyenthanhphuc@gmail.com", true, "Nguyễn Thành Phúc", null, null, false, null, "NGUYENTHANHPHUC@GMAIL.COM", "THANHPHUC15", "AQAAAAIAAYagAAAAEA+STFJ/AbTWEv3GTZ+OudeB44ptsf+nTEp2JMoFcbpbBbr+iekmX9RJ01UNYfYdKA==", "0975678901", false, null, null, "298a20e6-617d-4661-ac7a-165593dfeab6", false, false, false, null, null, "thanhphuc15", null, null },
                    { new Guid("87cc052b-db3b-441d-8c1c-dd38de9b54b9"), 0, null, null, "52c29dbb-3509-400f-9a0f-c10b9c8841a4", null, null, null, "vominhchau@gmail.com", true, "Võ Minh Châu", null, null, false, null, "VOMINHCHAU@GMAIL.COM", "MINHCHAU17", "AQAAAAIAAYagAAAAEPr+BP2I4ApXkL4eEgdtNp+Tlu/SED60tNtTPnOtvSxh9uS2emAnArmD9cZ/+huUsQ==", "0977890123", false, null, null, "73784e85-5f7b-4295-b2f8-f459b4fafbb2", false, false, false, null, null, "minhchau17", null, null },
                    { new Guid("93b7c022-30e4-4778-b685-ba9f57806e90"), 0, null, null, "ded12451-74ac-45e4-b4bd-f1fa754a1585", null, null, null, "trannhungkim@gmail.com", true, "Trần Nhung Kim", null, null, false, null, "TRANNHUNGKIM@GMAIL.COM", "NHUNGKIM07", "AQAAAAIAAYagAAAAEJ+fH5H+oMGl2vUfpJxcXAUzamAy5NT1N1Ij1gdm5Ke6grzoyACwjyvQFV/64mhtGg==", "0987890123", false, null, null, "f0900613-bb2e-4e71-8629-e53afedfddaf", false, false, false, null, null, "nhungkim07", null, null },
                    { new Guid("954c2b9c-24a8-4f16-bd18-7faa595b4332"), 0, null, null, "1e277344-31ee-4865-9e07-c2cf45896b1f", null, null, null, "letungphamquoc@gmail.com", true, "Lê Tùng Phạm Quốc", null, null, false, null, "LETUNGPHAMQUOC@GMAIL.COM", "TUNGPHAMQUOC03", "AQAAAAIAAYagAAAAENLIP+7WHyvxENpbAzbaUVfSi+QnXFrhOPx13w/ADzRUBxOJ3+nB3AzIxCK3Ljj4lA==", "0982345678", false, null, null, "115f5b27-ecdc-4161-b5be-b93f8c78b0fc", false, false, false, null, null, "tungphamquoc03", null, null },
                    { new Guid("9b34361d-a77c-4fdf-aca3-bd0959662c67"), 0, null, null, "3ad2d57b-7ec6-41c6-bf66-a3cb2f24af75", null, null, null, "dohonglan@gmail.com", true, "Đỗ Hồng Lan", null, null, false, null, "DOHONGLAN@GMAIL.COM", "HONGLAN12", "AQAAAAIAAYagAAAAEHlNCO2AkmYSlDCFuW8YKw+ASVo7zXB8FKjd7DjoiBeC1kWKCKMyixZ9m5Fdq5zdgQ==", "0972345678", false, null, null, "ce52ca53-2f48-4b81-a727-fcb14cd8af25", false, false, false, null, null, "honglan12", null, null },
                    { new Guid("9cdb97c4-bb7d-4c5a-9fd6-12d3cdc37b75"), 0, null, null, "cd1c6542-027c-46bb-90f3-a65c9e853fec", null, null, null, "phamkhangbao@gmail.com", true, "Phạm Khang Bảo", null, null, false, null, "PHAMKHANGBAO@GMAIL.COM", "KHANGBAO13", "AQAAAAIAAYagAAAAENdU+G7ROWlB0d2h133G1AdKsif8smYKVWbDAroOq8cmlQ/mCanIuvXFgIsukIkQAQ==", "0973456789", false, null, null, "ff836796-19f8-418b-b5fb-d9170f1b8bc7", false, false, false, null, null, "khangbao13", null, null },
                    { new Guid("a8bcae5d-ff12-4735-a792-f6b3cafe9b0b"), 0, null, null, "2b027b47-7391-4937-8247-697eb93437bb", null, null, null, "nguyenthithuy@gmail.com", true, "Nguyễn Thị Thủy", null, null, false, null, "NGUYENTHITHUY@GMAIL.COM", "THITHUY19", "AQAAAAIAAYagAAAAEPavELG6w+gSpHTSuxqGflsru/CeNKktOqevXzbPG+LQl8CzS76hkE7EzlckyyeFwg==", "0979012345", false, null, null, "cd37acc1-069b-4b0a-a07d-5d15a26e6ef0", false, false, false, null, null, "thithuy19", null, null },
                    { new Guid("b9488156-b13d-4118-be15-006b79f94a77"), 0, null, null, "2ff56bf2-cb7a-44c8-81ed-41bdb25a6e3c", null, null, null, "letungphamquoc@gmail.com", true, "Lê Tùng Phạm Quốc", null, null, false, null, "LETUNGPHAMQUOC@GMAIL.COM", "TUNGPHAMQUOC03", "AQAAAAIAAYagAAAAEMdJIx024gtB+sdCloJ2zp7AxxfsXDS29+PLrgZ6zDWDSOX8oETOt1xAxum3iggt+w==", "0982345678", false, null, null, "a3fe8adf-3ac2-4ec4-8c6f-2c5beb535171", false, false, false, null, null, "tungphamquoc03", null, null },
                    { new Guid("c5a1e207-7693-4d66-a0e4-032ae6bea9bc"), 0, null, null, "69d87f2d-fbe4-4a1b-a888-c4dbc93cf24a", null, null, null, "nguyenquangminh@gmail.com", true, "Nguyễn Quang Minh", null, null, false, null, "NGUYENQUANGMINH@GMAIL.COM", "QUANGMINH08", "AQAAAAIAAYagAAAAEJT9gvVHbRPBohyfSu6gEfZysUPNfQbi9zg0LGLssej2O9C5R+Aw2C+6TcOf5EjjzA==", "0988901234", false, null, null, "72d5ad78-0347-43b7-b30e-215c880ef087", false, false, false, null, null, "quangminh08", null, null },
                    { new Guid("ceee02c2-122d-4346-b07b-559ad92e2d98"), 0, null, null, "63020a4b-cc68-4a9d-ae2a-e751c4ed6350", null, null, null, "phamhanhthuy@gmail.com", true, "Phạm Hạnh Thúy", null, null, false, null, "PHAMHANHTHUY@GMAIL.COM", "HANHTHUY09", "AQAAAAIAAYagAAAAENY/pgkib0cM3HQsubqCDNBGFX7Lxwc8DQZ6QY5wNsdjwT3J6l+0vQPeeS4Y+soRxw==", "0989012345", false, null, null, "f3fe21ea-f9a2-4572-9448-dc83d47b579b", false, false, false, null, null, "hanhthuy09", null, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("1c86023b-f752-45f7-9b81-d1578f3c8656") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("1e31f456-ae49-4cd8-84e6-3ba44ef02741") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("37405a14-450c-4832-8c8a-4d2795a669cf") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("3b3f2afd-8beb-40fb-8215-b27d8c4e58d2") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("400b82a8-1e71-40ec-8d22-c55de7a2d73a") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("45378137-f980-4b34-85c7-cf4295f76c06") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("453f0a92-6b94-43f9-99db-401a7ea21554") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("5b07199c-5eba-40eb-86ba-73c2d021a765") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("69fa2bb9-1772-4631-a3c8-ca9ad6cf8c5a") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("83521853-7cca-445d-8e74-b04fbfd0efc1") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("854b3c85-0392-440e-b87a-e3da3c3c4859") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("87cc052b-db3b-441d-8c1c-dd38de9b54b9") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("93b7c022-30e4-4778-b685-ba9f57806e90") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("954c2b9c-24a8-4f16-bd18-7faa595b4332") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("9b34361d-a77c-4fdf-aca3-bd0959662c67") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("9cdb97c4-bb7d-4c5a-9fd6-12d3cdc37b75") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("a8bcae5d-ff12-4735-a792-f6b3cafe9b0b") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("b9488156-b13d-4118-be15-006b79f94a77") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("c5a1e207-7693-4d66-a0e4-032ae6bea9bc") });

            migrationBuilder.DeleteData(
                table: "AppUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("322488f9-7aa9-49b0-b2b8-fd98b7b260fc"), new Guid("ceee02c2-122d-4346-b07b-559ad92e2d98") });

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1c86023b-f752-45f7-9b81-d1578f3c8656"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("1e31f456-ae49-4cd8-84e6-3ba44ef02741"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("37405a14-450c-4832-8c8a-4d2795a669cf"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("3b3f2afd-8beb-40fb-8215-b27d8c4e58d2"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("400b82a8-1e71-40ec-8d22-c55de7a2d73a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("45378137-f980-4b34-85c7-cf4295f76c06"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("453f0a92-6b94-43f9-99db-401a7ea21554"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("5b07199c-5eba-40eb-86ba-73c2d021a765"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69fa2bb9-1772-4631-a3c8-ca9ad6cf8c5a"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("83521853-7cca-445d-8e74-b04fbfd0efc1"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("854b3c85-0392-440e-b87a-e3da3c3c4859"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("87cc052b-db3b-441d-8c1c-dd38de9b54b9"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("93b7c022-30e4-4778-b685-ba9f57806e90"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("954c2b9c-24a8-4f16-bd18-7faa595b4332"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9b34361d-a77c-4fdf-aca3-bd0959662c67"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("9cdb97c4-bb7d-4c5a-9fd6-12d3cdc37b75"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("a8bcae5d-ff12-4735-a792-f6b3cafe9b0b"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("b9488156-b13d-4118-be15-006b79f94a77"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("c5a1e207-7693-4d66-a0e4-032ae6bea9bc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("ceee02c2-122d-4346-b07b-559ad92e2d98"));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"),
                column: "Description",
                value: "<p>Rau muống tươi ngon, giàu chất xơ, sản phẩm sạch từ nông trại, có nhiều giá trị dinh dưỡng.</p> <ul> <li>Giàu chất xơ, tốt cho hệ tiêu hóa</li> <li>Giàu vitamin A và C</li> <li>Không thuốc bảo vệ thực vật</li> <li>Thích hợp chế biến các món xào, nấu canh</li> <li>Được trồng tại các nông trại xanh</li> </ul>");
        }
    }
}
