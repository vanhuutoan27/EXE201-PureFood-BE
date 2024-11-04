using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace PureFood.Data.Configurations
{
    public class UserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<Guid>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<Guid>> builder)
        {
            builder.HasData(
            new IdentityUserRole<Guid> { UserId = Guid.Parse("5B07199C-5EBA-40EB-86BA-73C2D021A765"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("B9488156-B13D-4118-BE15-006B79F94A77"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("954c2b9c-24a8-4f16-bd18-7faa595b4332"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("69fa2bb9-1772-4631-a3c8-ca9ad6cf8c5a"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("1e31f456-ae49-4cd8-84e6-3ba44ef02741"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("37405a14-450c-4832-8c8a-4d2795a669cf"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("93b7c022-30e4-4778-b685-ba9f57806e90"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("c5a1e207-7693-4d66-a0e4-032ae6bea9bc"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("ceee02c2-122d-4346-b07b-559ad92e2d98"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("453f0a92-6b94-43f9-99db-401a7ea21554"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("400b82a8-1e71-40ec-8d22-c55de7a2d73a"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("9b34361d-a77c-4fdf-aca3-bd0959662c67"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("9cdb97c4-bb7d-4c5a-9fd6-12d3cdc37b75"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("83521853-7cca-445d-8e74-b04fbfd0efc1"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("854b3c85-0392-440e-b87a-e3da3c3c4859"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("3b3f2afd-8beb-40fb-8215-b27d8c4e58d2"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("87cc052b-db3b-441d-8c1c-dd38de9b54b9"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("1c86023b-f752-45f7-9b81-d1578f3c8656"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("a8bcae5d-ff12-4735-a792-f6b3cafe9b0b"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") },
            new IdentityUserRole<Guid> { UserId = Guid.Parse("45378137-f980-4b34-85c7-cf4295f76c06"), RoleId = Guid.Parse("322488F9-7AA9-49B0-B2B8-FD98B7B260FC") }




            );
        }
    }
}
