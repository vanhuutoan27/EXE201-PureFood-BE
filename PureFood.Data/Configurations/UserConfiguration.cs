using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PureFood.Core.Domain.Identity;

namespace PureFood.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            var hasher = new PasswordHasher<AppUser>();

            builder.HasData(new List<AppUser>()
            {
               new AppUser
                 {
                Id = Guid.Parse("5B07199C-5EBA-40EB-86BA-73C2D021A765"), // Ensure to use a unique ID for each seeded user
                UserName = "minhhoang01",
                NormalizedUserName = "MINHHOANG01",
                Email = "tranhoathi@gmail.com",
                NormalizedEmail = "TRANHOATHI@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Trần Hoa Thị",
                PhoneNumber = "0981234567"

                },
               new AppUser
                 {
                Id =  Guid.Parse("B9488156-B13D-4118-BE15-006B79F94A77"), // Ensure to use a unique ID for each seeded user
                UserName = "tungphamquoc03",
                NormalizedUserName = "TUNGPHAMQUOC03",
                Email = "letungphamquoc@gmail.com",
                NormalizedEmail = "LETUNGPHAMQUOC@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Lê Tùng Phạm Quốc",
                PhoneNumber = "0982345678"
                },
                 new AppUser
                 {
                Id = Guid.Parse("954c2b9c-24a8-4f16-bd18-7faa595b4332"), // Ensure to use a unique ID for each seeded user
                UserName = "tungphamquoc03",
                NormalizedUserName = "TUNGPHAMQUOC03",
                Email = "letungphamquoc@gmail.com",
                NormalizedEmail = "LETUNGPHAMQUOC@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Lê Tùng Phạm Quốc",
                PhoneNumber = "0982345678"
                },
                //4
                   new AppUser
                 {
                Id = Guid.Parse("69fa2bb9-1772-4631-a3c8-ca9ad6cf8c5a"), // Ensure to use a unique ID for each seeded user
                UserName = "thaohong04",
                NormalizedUserName = "THAOHONG04",
                Email = "phamthaohong@gmail.com",
                NormalizedEmail = "PHAMTHAOHONG@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Phạm Thảo Hồng",
                PhoneNumber = "0984567890"
                },
                //5
                   new AppUser
                 {
                Id = Guid.Parse("1e31f456-ae49-4cd8-84e6-3ba44ef02741"), // Ensure to use a unique ID for each seeded user
                UserName = "viettuan05",
                NormalizedUserName = "VIETTUAN05",
                Email = "doviettuan@gmail.com",
                NormalizedEmail = "DOVIETTUAN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Đỗ Việt Tuấn",
                PhoneNumber = "0985678901"
                },
                //6
                   new AppUser
                 {
                Id = Guid.Parse("37405a14-450c-4832-8c8a-4d2795a669cf"), // Ensure to use a unique ID for each seeded user
                UserName = "anhtuan06",
                NormalizedUserName = "ANHTUAN06",
                Email = "voanhtuan@gmail.com",
                NormalizedEmail = "VOANHTUAN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Võ Anh Tuấn",
                PhoneNumber = "0986789012"
                },
                //7 
                  new AppUser
                 {
                Id = Guid.Parse("93b7c022-30e4-4778-b685-ba9f57806e90"), // Ensure to use a unique ID for each seeded user
                UserName = "nhungkim07",
                NormalizedUserName = "NHUNGKIM07",
                Email = "trannhungkim@gmail.com",
                NormalizedEmail = "TRANNHUNGKIM@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Trần Nhung Kim",
                PhoneNumber = "0987890123"
                },
                  //8
                       new AppUser
                 {
                Id = Guid.Parse("c5a1e207-7693-4d66-a0e4-032ae6bea9bc"), // Ensure to use a unique ID for each seeded user
                UserName = "quangminh08",
                NormalizedUserName = "QUANGMINH08",
                Email = "nguyenquangminh@gmail.com",
                NormalizedEmail = "NGUYENQUANGMINH@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Nguyễn Quang Minh",
                PhoneNumber = "0988901234"
                },
                //9
                 new AppUser
                 {
                Id = Guid.Parse("ceee02c2-122d-4346-b07b-559ad92e2d98"), // Ensure to use a unique ID for each seeded user
                UserName = "hanhthuy09",
                NormalizedUserName = "HANHTHUY09",
                Email = "phamhanhthuy@gmail.com",
                NormalizedEmail = "PHAMHANHTHUY@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Phạm Hạnh Thúy",
                PhoneNumber = "0989012345"
                },
                 //10
                   new AppUser
                 {
                Id = Guid.Parse("453f0a92-6b94-43f9-99db-401a7ea21554"), // Ensure to use a unique ID for each seeded user
                UserName = "trungdinh10",
                NormalizedUserName = "TRUNGDINH10",
                Email = "nguyentrungdinh@gmail.com",
                NormalizedEmail = "NGUYENTRUNGDINH@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Nguyễn Trung Đình",
                PhoneNumber = "0970123456"
                },
                //11
                   new AppUser
                 {
                Id = Guid.Parse("400b82a8-1e71-40ec-8d22-c55de7a2d73a"), // Ensure to use a unique ID for each seeded user
                UserName = "honghoa11",
                NormalizedUserName = "HONGHOA11",
                Email = "vohonghoa@gmail.com",
                NormalizedEmail = "VOHONGHOA@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Võ Hồng Hoa",
                PhoneNumber = "0971234567"
                },
                //12
                 new AppUser
                 {
                Id = Guid.Parse("9b34361d-a77c-4fdf-aca3-bd0959662c67"), // Ensure to use a unique ID for each seeded user
                UserName = "honglan12",
                NormalizedUserName = "HONGLAN12",
                Email = "dohonglan@gmail.com",
                NormalizedEmail = "DOHONGLAN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Đỗ Hồng Lan",
                PhoneNumber = "0972345678"
                },
                //13
                 new AppUser
                 {
                Id = Guid.Parse("9cdb97c4-bb7d-4c5a-9fd6-12d3cdc37b75"), // Ensure to use a unique ID for each seeded user
                UserName = "khangbao13",
                NormalizedUserName = "KHANGBAO13",
                Email = "phamkhangbao@gmail.com",
                NormalizedEmail = "PHAMKHANGBAO@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Phạm Khang Bảo",
                PhoneNumber = "0973456789"
                },
                 //14
                 new AppUser
                 {
                Id = Guid.Parse("83521853-7cca-445d-8e74-b04fbfd0efc1"), // Ensure to use a unique ID for each seeded user
                UserName = "hongnga14",
                NormalizedUserName = "HONGNGA14",
                Email = "tranthihongnga@gmail.com",
                NormalizedEmail = "TRANTHIHONGNGA@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Trần Thị Hồng Nga",
                PhoneNumber = "0974567890"
                },
                //15
                 new AppUser
                 {
                Id = Guid.Parse("854b3c85-0392-440e-b87a-e3da3c3c4859"), // Ensure to use a unique ID for each seeded user
                UserName = "thanhphuc15",
                NormalizedUserName = "THANHPHUC15",
                Email = "nguyenthanhphuc@gmail.com",
                NormalizedEmail = "NGUYENTHANHPHUC@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Nguyễn Thành Phúc",
                PhoneNumber = "0975678901"
                },
                 //16
                  new AppUser
                 {
                Id = Guid.Parse("3b3f2afd-8beb-40fb-8215-b27d8c4e58d2"), // Ensure to use a unique ID for each seeded user
                UserName = "hongyen16",
                NormalizedUserName = "HONGYEN16",
                Email = "vothihongyen@gmail.com",
                NormalizedEmail = "VOTHIHONGYEN@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Võ Thị Hồng Yến",
                PhoneNumber = "0976789012"
                },
                //17
                  new AppUser
                 {
                Id = Guid.Parse("87cc052b-db3b-441d-8c1c-dd38de9b54b9"), // Ensure to use a unique ID for each seeded user
                UserName = "minhchau17",
                NormalizedUserName = "MINHCHAU17",
                Email = "vominhchau@gmail.com",
                NormalizedEmail = "VOMINHCHAU@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Võ Minh Châu",
                PhoneNumber = "0977890123"
                },
                //18
                 new AppUser
                 {
                Id = Guid.Parse("1c86023b-f752-45f7-9b81-d1578f3c8656"), // Ensure to use a unique ID for each seeded user
                UserName = "huubao18",
                NormalizedUserName = "HUUBAO18",
                Email = "tranhuubao@gmail.com",
                NormalizedEmail = "TRANHUUBAO@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Trần Hữu Bảo",
                PhoneNumber = "0978901234"
                },
                //19
                new AppUser
                 {
                Id = Guid.Parse("a8bcae5d-ff12-4735-a792-f6b3cafe9b0b"), // Ensure to use a unique ID for each seeded user
                UserName = "thithuy19",
                NormalizedUserName = "THITHUY19",
                Email = "nguyenthithuy@gmail.com",
                NormalizedEmail = "NGUYENTHITHUY@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Nguyễn Thị Thủy",
                PhoneNumber = "0979012345"
                },
                //20
                new AppUser
                 {
                Id = Guid.Parse("45378137-f980-4b34-85c7-cf4295f76c06"), // Ensure to use a unique ID for each seeded user
                UserName = "linhchi20",
                NormalizedUserName = "LINHCHI20",
                Email = "phamlinhchi@gmail.com",
                NormalizedEmail = "PHAMLINHCHI@GMAIL.COM",
                EmailConfirmed = true,
                PasswordHash = hasher.HashPassword(null, "Admin@123"),
                SecurityStamp = Guid.NewGuid().ToString("D"),
                FullName = "Phạm Linh Chi",
                PhoneNumber = "0960123456"
                },
            });
        }
    }
}
