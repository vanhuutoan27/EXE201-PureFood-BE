using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PureFood.Core.Domain.Content;

namespace PureFood.Data.Configurations
{
    public class ImageConfigurration : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new List<Image>()
            {
                new Image
                {
                    ImageId = Guid.Parse("2ab8bf12-fe94-4d7a-b5b2-577bca108581"),
                    ProductId = Guid.Parse("0E758EAA-331B-409A-B09A-335CDB16A1F5"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F1.1.jpg?alt=media&token=8aa2db36-a902-45d3-bd89-577a7e1051b9"
                },
                new Image
                {
                    ImageId = Guid.Parse("5bedca84-0826-4525-8961-3a4b5f3d4488"),
                    ProductId = Guid.Parse("0E758EAA-331B-409A-B09A-335CDB16A1F5"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F1.2.jpg?alt=media&token=5ed9e2ad-a0ab-4144-bb83-b7a0bc943f79"
                },
                new Image
                {
                    ImageId = Guid.Parse("7417048d-2ac0-456a-b53f-1841f7ab3f56"),
                    ProductId = Guid.Parse("0E758EAA-331B-409A-B09A-335CDB16A1F5"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F1.3.jpg?alt=media&token=85f219cc-ca82-4f76-8813-4b2d01396a54"
                },
                new Image
                {
                    ImageId = Guid.Parse("ea3b8e36-f677-441e-8c0d-82cb5856fa85"),
                    ProductId = Guid.Parse("0E758EAA-331B-409A-B09A-335CDB16A1F5"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F1.4.jpg?alt=media&token=7cdbdbd1-c9d2-44ea-9472-24a8ad85fc18"
                },
                //product 2
                new Image
                {
                    ImageId = Guid.Parse("9f082e52-10db-4508-adf9-58f12b3e8c82"),
                    ProductId = Guid.Parse("487ca896-ab72-4735-bee9-1b6a42ec3be6"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F2.1.jpg?alt=media&token=9ebd04cb-02b4-4662-8618-53791f069691"
                },
                new Image
                {
                    ImageId = Guid.Parse("b68030d5-8fa1-4df6-8193-b92a6f21d14b"),
                    ProductId = Guid.Parse("487ca896-ab72-4735-bee9-1b6a42ec3be6"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F2.2.jpg?alt=media&token=75e12cd9-1e2f-4b83-be28-629f06529e91"
                },
                new Image
                {
                    ImageId = Guid.Parse("cc0959cf-1c87-4fa5-9554-39e298e71f17"),
                    ProductId = Guid.Parse("487ca896-ab72-4735-bee9-1b6a42ec3be6"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F2.3.jpg?alt=media&token=ffc5cba6-f45f-43d4-a2ae-d181efc60d32"
                },
                new Image
                {
                    ImageId = Guid.Parse("d5e6cb4e-20c7-4e82-bee8-4142ac208b7a"),
                    ProductId = Guid.Parse("487ca896-ab72-4735-bee9-1b6a42ec3be6"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F2.4.jpg?alt=media&token=b0fa6d72-c3f6-4eb1-a260-00a9e002b6a5"
                },
                //product 3
                new Image
                {
                    ImageId = Guid.Parse("141b88f2-1fe6-44f9-b9ed-b5230e0948bf"),
                    ProductId = Guid.Parse("30cfb1b3-da69-4a84-b94c-07ffe79597e0"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F3.1.jpg?alt=media&token=d0673683-e125-4784-b417-7d91f36b5487"
                },
                new Image
                {
                    ImageId = Guid.Parse("2d5909b6-458b-4b15-b6d8-87f5c2698a80"),
                    ProductId = Guid.Parse("30cfb1b3-da69-4a84-b94c-07ffe79597e0"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F3.2.jpg?alt=media&token=768cda30-028d-4750-9b40-fc47b06852f6"
                },
                new Image
                {
                    ImageId = Guid.Parse("adc3f002-d829-4d0f-9311-5695c3b024cf"),
                    ProductId = Guid.Parse("30cfb1b3-da69-4a84-b94c-07ffe79597e0"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F3.3.jpg?alt=media&token=a6782085-e680-4bd7-98be-4bbbf1755a51"
                },
                new Image
                {
                    ImageId = Guid.Parse("ebc736a8-05df-41d8-872a-368749bb14b6"),
                    ProductId = Guid.Parse("30cfb1b3-da69-4a84-b94c-07ffe79597e0"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F3.4.jpg?alt=media&token=9b436fa5-ff2a-4bd9-99d1-50cad660d704"
                },
                //product 4
                new Image
                {
                    ImageId = Guid.Parse("07902c5d-0e3b-4cff-9d74-69ef534d2d94"),
                    ProductId = Guid.Parse("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F4.1.jpg?alt=media&token=b769455f-31cb-453f-97ee-b8f4da757cbc"
                },
                new Image
                {
                    ImageId = Guid.Parse("1b36b25f-9168-4506-8e13-fd62f83acfdc"),
                    ProductId = Guid.Parse("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F4.2.jpg?alt=media&token=eaaa7cd4-3448-4d7f-bdef-09a4344cbf27"
                },
                new Image
                {
                    ImageId = Guid.Parse("3d460368-b879-4cda-991a-5e5c3db5f40e"),
                    ProductId = Guid.Parse("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F4.3.jpg?alt=media&token=c2db8a67-158e-4d73-80aa-bcdcca6f1ad9"
                },
                new Image
                {
                    ImageId = Guid.Parse("bf6af744-6d8f-4ca1-8720-0554a9d11fcb"),
                    ProductId = Guid.Parse("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F4.4.jpg?alt=media&token=455b20e2-a6c7-4889-90ef-28f547b08790"
                },
                //product 5 
                new Image
                {
                    ImageId = Guid.Parse("23b8737c-f1db-4148-96c4-2858e8be478b"),
                    ProductId = Guid.Parse("d3fd8b9e-ff11-4c14-a453-edfd58f05135"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F5.1.jpg?alt=media&token=98b82bfa-dc94-4960-b091-fe1307b9ee56"
                },
                 new Image
                {
                    ImageId = Guid.Parse("7124f9ce-7b64-4771-8486-f0cbb389468f"),
                    ProductId = Guid.Parse("d3fd8b9e-ff11-4c14-a453-edfd58f05135"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F5.2.jpg?alt=media&token=4ed5345b-9f3f-4205-a477-8883ccdd5a54"
                },
                new Image
                {
                    ImageId = Guid.Parse("9a6b98af-6603-4ad6-ae62-b82389c5d8bd"),
                    ProductId = Guid.Parse("d3fd8b9e-ff11-4c14-a453-edfd58f05135"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F5.3.jpg?alt=media&token=9bd2b6a8-8d07-4172-892c-c06b26c661dc"
                },
                new Image
                {
                    ImageId = Guid.Parse("4c1a249c-a716-4ba3-9647-167c0a2e2d13"),
                    ProductId = Guid.Parse("d3fd8b9e-ff11-4c14-a453-edfd58f05135"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F5.4.jpg?alt=media&token=36b36199-cec7-4421-bb43-1be5d9f90560"
                },
                //product 6
                new Image
                {
                    ImageId = Guid.Parse("147470fc-0bbd-4e6d-ada8-b616ebffc343"),
                    ProductId = Guid.Parse("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F6.1.jpg?alt=media&token=62b793d8-c754-461d-ae9c-17ae7986bc06"
                },
                new Image
                {
                    ImageId = Guid.Parse("3c38777b-ee15-4059-9cd0-b063d5d37a5e"),
                    ProductId = Guid.Parse("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F6.2.jpg?alt=media&token=6d2437c5-a574-4bc8-9a4a-08c954f66940"
                },
                new Image
                {
                    ImageId = Guid.Parse("5873d292-a96f-44dc-8eb0-0340fb107c34"),
                    ProductId = Guid.Parse("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F6.3.jpg?alt=media&token=00501803-2f9e-4d22-9e64-94211c171309"
                },
                new Image
                {
                    ImageId = Guid.Parse("6ce3b5dc-20ab-48d0-bef1-d8320ffdf317"),
                    ProductId = Guid.Parse("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F6.5.jpg?alt=media&token=aa7aa923-c490-40fe-82e5-3f6d1103ea6e"
                },
                //Product 7
                new Image
                {
                    ImageId = Guid.Parse("2edd5830-ac8d-4281-9a28-cfc1dd3f159e"),
                    ProductId = Guid.Parse("a5c11a08-497c-4846-b922-bb8a95078dd1"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F7.1.jpg?alt=media&token=b06321a1-6c26-41f9-b707-0b3fddb44fe7"
                },
                new Image
                {
                    ImageId = Guid.Parse("7ade8654-3f80-45f2-8da9-3dda1e276ec4"),
                    ProductId = Guid.Parse("a5c11a08-497c-4846-b922-bb8a95078dd1"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F7.2.jpg?alt=media&token=7ea8139c-2195-4b99-9b0a-ffc1c34f35ab"
                },
                new Image
                {
                    ImageId = Guid.Parse("905e459e-99e7-44f7-98a0-cf42c77229f4"),
                    ProductId = Guid.Parse("a5c11a08-497c-4846-b922-bb8a95078dd1"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F7.3.jpg?alt=media&token=7c6000f6-66b6-4020-83f3-089812857d31"
                },
                //pro 8
                new Image
                {
                    ImageId = Guid.Parse("38998549-11cb-4574-ba9c-9c8c91c59c31"),
                    ProductId = Guid.Parse("25134650-be13-43de-bc40-22a9ea54b543"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F8.1.jpg?alt=media&token=1f0a016a-894a-4000-88e3-747adf1142df"
                },
                new Image
                {
                    ImageId = Guid.Parse("5ac66b04-463e-4fff-a379-a2d5068f516c"),
                    ProductId = Guid.Parse("25134650-be13-43de-bc40-22a9ea54b543"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F8.2.jpg?alt=media&token=0a7802f0-17c9-4e8f-a6f8-38278ad0213d"
                },
                new Image
                {
                    ImageId = Guid.Parse("6f86b276-f7d6-4b4c-82a0-b5f0afba76ed"),
                    ProductId = Guid.Parse("25134650-be13-43de-bc40-22a9ea54b543"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F8.3.jpg?alt=media&token=9d08e1b6-3feb-4f64-a517-f2550b86d674"
                },
                new Image
                {
                    ImageId = Guid.Parse("87b04ea4-acbb-48c0-9154-41b58c4c454c"),
                    ProductId = Guid.Parse("25134650-be13-43de-bc40-22a9ea54b543"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F8.4.jpg?alt=media&token=de43b4c1-b3a3-4d88-a61c-3f72ea8ca7dd"
                },
                //pro 9
                new Image
                {
                    ImageId = Guid.Parse("160e7955-47f7-464a-b819-79c47f106b4d"),
                    ProductId = Guid.Parse("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F9.1.jpg?alt=media&token=621021f6-6356-458b-bc10-07d85a6096cd"
                },
                new Image
                {
                    ImageId = Guid.Parse("64fcbca1-fdf4-4e9a-b841-29086da16f36"),
                    ProductId = Guid.Parse("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F9.2.jpg?alt=media&token=6648b26a-153e-4bab-a22a-3c58693db145"
                },
                new Image
                {
                    ImageId = Guid.Parse("80974c62-29d2-4db0-a32e-83ca74cb3383"),
                    ProductId = Guid.Parse("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F9.3.jpg?alt=media&token=71642a0b-ade9-45c7-9a4e-0d3bf8aefb08"
                },
                new Image
                {
                    ImageId = Guid.Parse("c1c1bc06-7d76-4f4b-987d-d4c3efbf5901"),
                    ProductId = Guid.Parse("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F9.4.jpg?alt=media&token=0883a03b-33db-45b2-8973-f240e16e9b1b"
                },
                //pro 10
                new Image
                {
                    ImageId = Guid.Parse("1594b568-5855-417d-86cb-96c61c6de1b3"),
                    ProductId = Guid.Parse("8212e748-fe88-40af-894e-708a376f4fa7"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F10.1.jpg?alt=media&token=84e0916e-a3bf-402b-b584-59a96d2ae1b3"
                },
                new Image
                {
                    ImageId = Guid.Parse("427880a9-3a3e-40c9-96d9-6c64dc6a2b84"),
                    ProductId = Guid.Parse("8212e748-fe88-40af-894e-708a376f4fa7"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F10.2.jpg?alt=media&token=662ba6e6-79ae-4326-9e3b-1f266b06141e"
                },
                new Image
                {
                    ImageId = Guid.Parse("56391da7-a3f5-4c8e-a5f6-f57abcf7f3e6"),
                    ProductId = Guid.Parse("8212e748-fe88-40af-894e-708a376f4fa7"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F10.3.jpg?alt=media&token=5f1f19a4-1480-4ffe-8c54-c498342ff817"
                },
                //pro 11
                new Image
                {
                    ImageId = Guid.Parse("0058660f-548f-4a05-9985-35adf77fa17b"),
                    ProductId = Guid.Parse("6404ba59-9c63-4192-889b-3448cd7c9ba0"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F11.1.jpg?alt=media&token=0269ab46-401e-4f16-b189-cad618ac7017"
                },
                new Image
                {
                    ImageId = Guid.Parse("9856e332-caf4-406e-9ac4-647eaa797a74"),
                    ProductId = Guid.Parse("6404ba59-9c63-4192-889b-3448cd7c9ba0"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F11.2.jpg?alt=media&token=0721c18d-3b51-4266-89ac-c5c7442bc59c"
                },
                new Image
                {
                    ImageId = Guid.Parse("fe925dc4-bbd5-4d5d-a13b-1f3a6ee6628e"),
                    ProductId = Guid.Parse("6404ba59-9c63-4192-889b-3448cd7c9ba0"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F11.3.jpg?alt=media&token=9b3e318d-63e3-47ec-968f-8bd053f1fc15"
                },

                //pro 12
                new Image
                {
                    ImageId = Guid.Parse("0c4ba54d-a39a-4c1b-bbb8-c909362fe973"),
                    ProductId = Guid.Parse("7a684d3b-8e9f-4f06-a767-d59c1953f249"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F12.1.jpg?alt=media&token=e7794ede-ec4e-411e-a5f3-23bf37bd8c76"
                },
                new Image
                {
                    ImageId = Guid.Parse("29f8c2c4-222c-4c41-adda-5d74e281e6dd"),
                    ProductId = Guid.Parse("7a684d3b-8e9f-4f06-a767-d59c1953f249"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F12.2.jpg?alt=media&token=cdc9fd2b-3d64-4242-bc3a-353f5558d8d1"
                },
                new Image
                {
                    ImageId = Guid.Parse("3416a262-1421-4199-b15d-7c425d68f0ae"),
                    ProductId = Guid.Parse("7a684d3b-8e9f-4f06-a767-d59c1953f249"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F12.3.jpg?alt=media&token=f86f1e73-dbdd-4358-8308-d3143655ae2f"
                },

                //pro 13
                new Image
                {
                    ImageId = Guid.Parse("68f9bd1e-fd66-45fb-8c7c-41cb7c3a69e9"),
                    ProductId = Guid.Parse("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F13.1.jpg?alt=media&token=38cb92b8-6399-40df-9865-ee7eeae02616"
                },
                new Image
                {
                    ImageId = Guid.Parse("74a5cdda-708a-4be2-8507-5f2f00c42883"),
                    ProductId = Guid.Parse("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F13.5.jpg?alt=media&token=5c80780a-68ac-44ec-b369-80b5b92f9ef5"
                },
                new Image
                {
                    ImageId = Guid.Parse("fb4ca598-f62a-419e-a94d-7f03d30944fb"),
                    ProductId = Guid.Parse("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F13.4.jpg?alt=media&token=eb410528-7cac-4971-a0b1-02da1096b227"
                },
                //pro 14
                new Image
                {
                    ImageId = Guid.Parse("113eea99-b426-447c-a608-aaa3f7be7267"),
                    ProductId = Guid.Parse("2adef94c-fa06-4369-89ab-34e71052368e"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F14.1.jpg?alt=media&token=45bdde25-32ac-4807-9342-6c11487c11a4"
                },
                new Image
                {
                    ImageId = Guid.Parse("3305f179-86ef-45c5-b323-f058e1cef81d"),
                    ProductId = Guid.Parse("2adef94c-fa06-4369-89ab-34e71052368e"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F14.2.jpg?alt=media&token=10434244-5b92-4216-9e1a-8929b8a1c1f4"
                },
                new Image
                {
                    ImageId = Guid.Parse("7108b731-0a30-4be6-a1c1-ae5e72ba0d3a"),
                    ProductId = Guid.Parse("2adef94c-fa06-4369-89ab-34e71052368e"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F14.3.jpg?alt=media&token=e0274537-66f5-43dd-8fea-58da0741f760"
                },

                //pro 15
                new Image
                {
                    ImageId = Guid.Parse("0fc41889-3ff8-452b-8b98-e36f80d04360"),
                    ProductId = Guid.Parse("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F15.1.jpg?alt=media&token=be4b11c9-8d18-4095-a526-3502120db66a"
                },
                new Image
                {
                    ImageId = Guid.Parse("23f35439-253a-49be-9beb-486c8be37c90"),
                    ProductId = Guid.Parse("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F15.2.jpg?alt=media&token=47cd5fb6-5261-43ed-9471-6583899e2933"
                },
                new Image
                {
                    ImageId = Guid.Parse("81d44c50-ade1-4913-899d-8ab35f14fe1c"),
                    ProductId = Guid.Parse("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F15.4.jpg?alt=media&token=639dec84-1a77-4acf-ac8d-bbe45c7c0ec1"
                },
                //pro 16
                new Image
                {
                    ImageId = Guid.Parse("09a63769-85fe-4b22-972c-36d809084a5e"),
                    ProductId = Guid.Parse("fc727800-963c-4305-93a0-3b27dfb1d734"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F16.1.jpeg?alt=media&token=240f0de8-7539-4c58-8009-275016b88a46"
                },
                new Image
                {
                    ImageId = Guid.Parse("870d103c-6a41-4037-8512-a50552570ae5"),
                    ProductId = Guid.Parse("fc727800-963c-4305-93a0-3b27dfb1d734"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F16.2.jpeg?alt=media&token=373fbcd2-ae1f-4edb-951d-050edf0fddce"
                },
                new Image
                {
                    ImageId = Guid.Parse("eb5ee868-c10f-4afe-8606-91f1752e8b26"),
                    ProductId = Guid.Parse("fc727800-963c-4305-93a0-3b27dfb1d734"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F16.3.jpeg?alt=media&token=973e8efd-51e9-483d-9d87-2498bf0c3240"
                },
                new Image
                {
                    ImageId = Guid.Parse("fe6aeb73-17cc-4d83-91fe-7b009ceb0091"),
                    ProductId = Guid.Parse("fc727800-963c-4305-93a0-3b27dfb1d734"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F16.4.jpeg?alt=media&token=0ad2cedb-da0e-45d0-85f2-e01def24e449"
                },
                //pro 17
                new Image
                {
                    ImageId = Guid.Parse("0e853075-8de3-40ab-afa6-5c7246118a47"),
                    ProductId = Guid.Parse("ba9968e6-4ad4-406c-9268-28acd686f73c"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F17.1.jpg?alt=media&token=1db77c6c-68a5-4908-9391-c88f44688ae8"
                },
                new Image
                {
                    ImageId = Guid.Parse("3e68861e-8ca4-4821-b145-de55067335d4"),
                    ProductId = Guid.Parse("ba9968e6-4ad4-406c-9268-28acd686f73c"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F17.2.jpg?alt=media&token=f2f3d557-46fd-4f54-82b3-17077ab6cca5"
                },
                new Image
                {
                    ImageId = Guid.Parse("52b1b4ac-f0c1-406e-b30f-7b1981327327"),
                    ProductId = Guid.Parse("ba9968e6-4ad4-406c-9268-28acd686f73c"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F17.3.jpg?alt=media&token=0646948b-03c0-4417-8327-be728a121e63"
                },
                new Image
                {
                    ImageId = Guid.Parse("ed53b62e-1a70-4a11-bba8-efe527a63f47"),
                    ProductId = Guid.Parse("ba9968e6-4ad4-406c-9268-28acd686f73c"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F17.4.jpg?alt=media&token=7e88e4c0-3b8e-4749-aa0a-f69d53e24f69"
                },
                // pro 18
                new Image
                {
                    ImageId = Guid.Parse("1d74d733-8b94-4043-b2e6-717bc76bd604"),
                    ProductId = Guid.Parse("576aa3a9-49ff-486c-8efc-a0548ee90ee7"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F18.1.jpg?alt=media&token=b05ea5eb-c364-4017-9727-b29a9ba39139"
                },
                new Image
                {
                    ImageId = Guid.Parse("2416f0a9-bc9e-4ced-a425-af1481ca8c0b"),
                    ProductId = Guid.Parse("576aa3a9-49ff-486c-8efc-a0548ee90ee7"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F18.2.jpg?alt=media&token=f41c8267-27a0-46a1-ac00-183aa7bc303e"
                },
                new Image
                {
                    ImageId = Guid.Parse("9b59ee88-21f1-44ac-ad0a-d843ed7802c5"),
                    ProductId = Guid.Parse("576aa3a9-49ff-486c-8efc-a0548ee90ee7"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F18.3.jpg?alt=media&token=d61ca12f-1e94-4b50-a420-a4a83e0ccfc1"
                },
                new Image
                {
                    ImageId = Guid.Parse("e7556fef-42a8-4494-bdd5-bc39a7cce1aa"),
                    ProductId = Guid.Parse("576aa3a9-49ff-486c-8efc-a0548ee90ee7"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F18.4.jpg?alt=media&token=f9bddef4-1395-485e-9513-445289e0ef74"
                },
                //pro 19
                new Image
                {
                    ImageId = Guid.Parse("250b5b32-9197-45dd-a85d-f21d5c922737"),
                    ProductId = Guid.Parse("a69cd06b-8762-49cc-9228-1fc88956fb3c"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F19.1.jpg?alt=media&token=ecfdf322-bb3d-4959-ac7d-36ee2ca2ca98"
                },
                new Image
                {
                    ImageId = Guid.Parse("afd40e26-3e41-421d-8b74-fd35ff43cade"),
                    ProductId = Guid.Parse("a69cd06b-8762-49cc-9228-1fc88956fb3c"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F19.2.jpg?alt=media&token=5aec55ad-ad90-448b-9ae6-38c2181a7a28"
                },
                new Image
                {
                    ImageId = Guid.Parse("dc1d2736-c849-4d4c-9817-6f19031c0b16"),
                    ProductId = Guid.Parse("a69cd06b-8762-49cc-9228-1fc88956fb3c"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F19.3.jpg?alt=media&token=404b341d-64f9-4ca5-a5d5-cae220042c5e"
                },
                //pro 20
                new Image
                {
                    ImageId = Guid.Parse("43f77651-ab4f-4af9-8f58-be8d2790aa15"),
                    ProductId = Guid.Parse("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F20.1.jpg?alt=media&token=2db339d6-5004-4dce-ab54-9b2377bff2a6"
                },
                new Image
                {
                    ImageId = Guid.Parse("6e35ff78-1205-4164-bf2e-2d91af27f405"),
                    ProductId = Guid.Parse("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F20.2.jpg?alt=media&token=516e44b7-6f8b-4db7-a610-0a3eeb063745"
                },
                new Image
                {
                    ImageId = Guid.Parse("df705ccd-c062-45df-ac5e-49bedb874971"),
                    ProductId = Guid.Parse("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F20.3.jpg?alt=media&token=ecdffbec-29d1-4f1d-9ddf-616f92a3b15d"
                },
                new Image
                {
                    ImageId = Guid.Parse("fd927a8e-a6f5-4d22-b593-e9aec49d6fd7"),
                    ProductId = Guid.Parse("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F20.4.jpg?alt=media&token=0fb153d2-b1b5-4ae7-a823-f802cd9bc952"
                },
                // product 21
                new Image
                {
                    ImageId = Guid.Parse("c967abff-64b4-4f94-8c17-e77030c079ef"),
                    ProductId = Guid.Parse("557ff79b-b169-409f-aada-9c921c0a69d2"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F21.1.jpg?alt=media&token=34a71077-247f-4055-b904-e83ff313149b"
                },
                new Image
                {
                    ImageId = Guid.Parse("a4c1308e-4825-429b-8a92-b39872aeb632"),
                    ProductId = Guid.Parse("557ff79b-b169-409f-aada-9c921c0a69d2"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F21.2.jpg?alt=media&token=1c808bf8-28b8-45cb-bbcc-9e76e190d756"
                },
                new Image
                {
                    ImageId = Guid.Parse("5cbbc62b-f328-4789-8c4b-bcac23488f9a"),
                    ProductId = Guid.Parse("557ff79b-b169-409f-aada-9c921c0a69d2"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F21.3.jpg?alt=media&token=5064bef3-b49e-4e6b-b7cc-fdc0f0b9d2c0"
                },
                new Image
                {
                    ImageId = Guid.Parse("c86a9368-330f-45e0-b8c1-ce6fc0bd69a5"),
                    ProductId = Guid.Parse("557ff79b-b169-409f-aada-9c921c0a69d2"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F21.4.jpg?alt=media&token=715716b8-f6e2-43ad-a99d-dcd4af118f65"
                },
                // product 22
                new Image
                {
                    ImageId = Guid.Parse("804570c3-50c4-49f4-8ea4-942e5e2a2e4c"),
                    ProductId = Guid.Parse("ca15b94b-bebb-4d86-bcbd-29993bf68183"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F22.1.jpg?alt=media&token=30359a88-5ef4-421a-b325-882162b89d55"
                },
                new Image
                {
                    ImageId = Guid.Parse("2d0634bd-8b5c-4e60-88dc-a2136994ada6"),
                    ProductId = Guid.Parse("ca15b94b-bebb-4d86-bcbd-29993bf68183"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F22.2.jpg?alt=media&token=8c77d9ef-ceae-4d97-a280-8b9cf664f667"
                },
                new Image
                {
                    ImageId = Guid.Parse("26fcf3ed-6285-4844-88d1-905b5697dc29"),
                    ProductId = Guid.Parse("ca15b94b-bebb-4d86-bcbd-29993bf68183"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F22.3.jpg?alt=media&token=a1bd9ef9-fa13-459c-a702-6b621c6ef679"
                },
                // product 23
                new Image
                {
                    ImageId = Guid.Parse("d2d09122-d518-4a57-9dbe-f34c5486f54e"),
                    ProductId = Guid.Parse("a9249592-6bb8-4996-ad0b-0f3cd3c0b335"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F23.1.jpg?alt=media&token=89866b0d-5eec-4f5a-8c9b-9eaa2459926b"
                },
                new Image
                {
                    ImageId = Guid.Parse("ef6eac44-2380-4ff0-aa3c-22388b440b2e"),
                    ProductId = Guid.Parse("a9249592-6bb8-4996-ad0b-0f3cd3c0b335"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F23.2.jpg?alt=media&token=f79a61d0-2bdb-4b50-a006-044fe1478ec9"
                },
                new Image
                {
                    ImageId = Guid.Parse("ba1c8207-42ac-41c3-a4b8-c5cf7e1e0b84"),
                    ProductId = Guid.Parse("a9249592-6bb8-4996-ad0b-0f3cd3c0b335"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F23.3.jpg?alt=media&token=0eea1393-015c-4899-85c7-229a48b5c95c"
                },
                new Image
                {
                    ImageId = Guid.Parse("20e00706-46c4-4377-ada6-63e4da568ba1"),
                    ProductId = Guid.Parse("a9249592-6bb8-4996-ad0b-0f3cd3c0b335"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F23.4.jpg?alt=media&token=57094db9-01f0-41ab-9b32-f528a469fe59"
                },
                // product 24
                new Image
                {
                    ImageId = Guid.Parse("18e60ffc-12b9-4dc1-8b59-4512b6d5767e"),
                    ProductId = Guid.Parse("5c70e6fd-c1bd-48f3-b9d8-0b4c2907916c"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F24.1.jpg?alt=media&token=0b13c635-589d-4d9d-bc42-30a7d542666e"
                },
                new Image
                {
                    ImageId = Guid.Parse("20e53d51-ee14-4c74-8ce6-55bf97de4d4b"),
                    ProductId = Guid.Parse("5c70e6fd-c1bd-48f3-b9d8-0b4c2907916c"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F24.2.jpg?alt=media&token=ae894c3f-27a4-46ca-a926-383d2a60e06e"
                },
                new Image
                {
                    ImageId = Guid.Parse("37f28f35-fc0b-4501-890d-06419d282d21"),
                    ProductId = Guid.Parse("5c70e6fd-c1bd-48f3-b9d8-0b4c2907916c"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F24.3.jpg?alt=media&token=29836c7e-983f-4d60-ab37-562d09fe7c81"
                },
                // product 25
                new Image
                {
                    ImageId = Guid.Parse("9b1cbb0b-d8b3-4d81-ab32-d877eac08181"),
                    ProductId = Guid.Parse("6287df0b-b4ff-49e1-9b50-25cbc88a93a2"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F25.1.jpg?alt=media&token=9e2cffd4-db3e-4fe8-b41e-86d8adef2851"
                },
                new Image
                {
                    ImageId = Guid.Parse("8c2ca84e-490d-4275-b4f7-a6b3648d90b4"),
                    ProductId = Guid.Parse("6287df0b-b4ff-49e1-9b50-25cbc88a93a2"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F25.2.jpg?alt=media&token=3304d126-2853-4e16-9bb4-34ed6caeb36b"
                },
                new Image
                {
                    ImageId = Guid.Parse("7a68e2f2-6e50-4cf4-b5a5-e9d57a64c090"),
                    ProductId = Guid.Parse("6287df0b-b4ff-49e1-9b50-25cbc88a93a2"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F25.3.jpg?alt=media&token=ca1d9049-39df-4d89-8cc9-2eff45d87792"
                },
                // product 26
                new Image
                {
                    ImageId = Guid.Parse("8f2ee0a0-9020-4d31-9023-6a989d4a6c27"),
                    ProductId = Guid.Parse("88d089ad-0259-4b91-aba6-be6cf69a3117"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F26.1.jpg?alt=media&token=bb335379-6993-423e-8705-b454bc238c36"
                },
                new Image
                {
                    ImageId = Guid.Parse("2680dadb-277e-49d1-8476-9bb9b57639b2"),
                    ProductId = Guid.Parse("88d089ad-0259-4b91-aba6-be6cf69a3117"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F26.2.jpg?alt=media&token=4a91fffc-d70b-4c73-9df0-fe6b82dc1a97"
                },
                new Image
                {
                    ImageId = Guid.Parse("8343259c-e9e4-487d-b99e-d87ffc722876"),
                    ProductId = Guid.Parse("88d089ad-0259-4b91-aba6-be6cf69a3117"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F26.3.jpg?alt=media&token=a689a7fb-a271-42fa-a98f-532fbca1c71b"
                },
                // product 27
                new Image
                {
                    ImageId = Guid.Parse("e8c72f17-ee56-4417-adbd-c03780914cf3"),
                    ProductId = Guid.Parse("ec4b9041-b1f3-4852-82f5-ca357250ab3b"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F27.1.jpg?alt=media&token=d954ccd7-d969-463f-a80a-4da254da10ec"
                },
                new Image
                {
                    ImageId = Guid.Parse("7c3a7376-0d8a-42d8-86ba-00f3fea43b77"),
                    ProductId = Guid.Parse("ec4b9041-b1f3-4852-82f5-ca357250ab3b"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F27.3.jpg?alt=media&token=3f7ebe66-c153-4b50-bc7d-405100655377"
                },
                new Image
                {
                    ImageId = Guid.Parse("4be2e1cb-8502-4cd9-92f2-50fce7150af9"),
                    ProductId = Guid.Parse("ec4b9041-b1f3-4852-82f5-ca357250ab3b"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F27.5.jpg?alt=media&token=d547bde3-c871-4788-a63a-3d25c1b44b2f"
                },
                new Image
                {
                    ImageId = Guid.Parse("5b12c8f3-3a8e-436c-9c03-a6bdfa7d9e26"),
                    ProductId = Guid.Parse("ec4b9041-b1f3-4852-82f5-ca357250ab3b"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F27.6.jpg?alt=media&token=244e0070-c373-4833-a87c-25d11cb513a1"
                },
                // product 28
                new Image
                {
                    ImageId = Guid.Parse("35ea08b1-191b-4fb6-b6e1-8acf76f5785d"),
                    ProductId = Guid.Parse("e4ebe279-a787-406a-bab5-7ae8f99748e4"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F28.1.jpg?alt=media&token=3eb98a98-2398-4d0b-93a3-89b67bdd2e84"
                },
                new Image
                {
                    ImageId = Guid.Parse("faefcbb4-37d7-4175-ba5e-610b09283a2c"),
                    ProductId = Guid.Parse("e4ebe279-a787-406a-bab5-7ae8f99748e4"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F28.2.jpg?alt=media&token=89c90c2d-8d09-417f-9391-dad2c97b25ee"
                },
                new Image
                {
                    ImageId = Guid.Parse("57e82ced-a474-4685-9cfb-ad4dad660e3b"),
                    ProductId = Guid.Parse("e4ebe279-a787-406a-bab5-7ae8f99748e4"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F28.3.jpg?alt=media&token=66352262-c0aa-4b17-b4b2-e018a2c6aa34"
                },
                new Image
                {
                    ImageId = Guid.Parse("78451019-0a26-4c82-a556-8ebdab944d35"),
                    ProductId = Guid.Parse("e4ebe279-a787-406a-bab5-7ae8f99748e4"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F28.4.jpg?alt=media&token=6eb34cbd-e2da-445e-9f49-24a06fca8432"
                },
                // product 29
                new Image
                {
                    ImageId = Guid.Parse("8fe30c3d-845e-4ff3-b31d-2d58438c9f48"),
                    ProductId = Guid.Parse("fc8f443e-8f0e-46bf-8061-0a14074c8313"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F29.2.jpg?alt=media&token=63890240-9346-48a8-a9be-94a51eaa0d99"
                },
                new Image
                {
                    ImageId = Guid.Parse("9104c42b-bf99-4135-a8f6-631038505d77"),
                    ProductId = Guid.Parse("fc8f443e-8f0e-46bf-8061-0a14074c8313"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F29.3.jpg?alt=media&token=f29aab3f-c366-4aba-bd48-01ed611fad13"
                },
                new Image
                {
                    ImageId = Guid.Parse("87274e3d-fe6a-43a9-abb2-e6ab21e2a619"),
                    ProductId = Guid.Parse("fc8f443e-8f0e-46bf-8061-0a14074c8313"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F29.4.jpg?alt=media&token=de9a1f46-7c46-47e0-aa5f-33e10b2c8314"
                },
                // product 30
                new Image
                {
                    ImageId = Guid.Parse("7ac6747c-4efd-41fb-88fe-f123808aa245"),
                    ProductId = Guid.Parse("4e31b4e9-0eab-4bbe-b11b-ca52b02b60d5"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F30.1.jpg?alt=media&token=824933bd-8ef6-4449-9eca-5e7427231c1b"
                },
                new Image
                {
                    ImageId = Guid.Parse("fcdf373d-62f8-4bc2-a6cb-fb57e984ce1b"),
                    ProductId = Guid.Parse("4e31b4e9-0eab-4bbe-b11b-ca52b02b60d5"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F30.2.jpg?alt=media&token=9c7bc3be-28d5-4219-9b04-756058aafc25"
                },
                new Image
                {
                    ImageId = Guid.Parse("021754a2-9862-48bd-88eb-55ae9574f6b5"),
                    ProductId = Guid.Parse("4e31b4e9-0eab-4bbe-b11b-ca52b02b60d5"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F30.3.jpg?alt=media&token=c17f2e96-bc02-4cb0-84e2-8a005f35df14"
                },
                new Image
                {
                    ImageId = Guid.Parse("8178c865-b35f-42a1-97e2-dbe31e72d5f2"),
                    ProductId = Guid.Parse("4e31b4e9-0eab-4bbe-b11b-ca52b02b60d5"),
                    Url = "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F30.4.jpg?alt=media&token=a2489348-e804-4c69-a530-42b4a78646dc"
                },
            });
        }
    }
}
