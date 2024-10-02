using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace PureFood.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedDataForImage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Images",
                columns: new[] { "ImageId", "CreatedAt", "CreatedBy", "ProductId", "UpdatedAt", "UpdatedBy", "Url" },
                values: new object[,]
                {
                    { new Guid("0058660f-548f-4a05-9985-35adf77fa17b"), null, null, new Guid("6404ba59-9c63-4192-889b-3448cd7c9ba0"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F11.1.jpg?alt=media&token=0269ab46-401e-4f16-b189-cad618ac7017" },
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
                    { new Guid("1b36b25f-9168-4506-8e13-fd62f83acfdc"), null, null, new Guid("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F4.2.jpg?alt=media&token=eaaa7cd4-3448-4d7f-bdef-09a4344cbf27" },
                    { new Guid("1d74d733-8b94-4043-b2e6-717bc76bd604"), null, null, new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F18.1.jpg?alt=media&token=b05ea5eb-c364-4017-9727-b29a9ba39139" },
                    { new Guid("23b8737c-f1db-4148-96c4-2858e8be478b"), null, null, new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F5.1.jpg?alt=media&token=98b82bfa-dc94-4960-b091-fe1307b9ee56" },
                    { new Guid("23f35439-253a-49be-9beb-486c8be37c90"), null, null, new Guid("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F15.2.jpg?alt=media&token=47cd5fb6-5261-43ed-9471-6583899e2933" },
                    { new Guid("2416f0a9-bc9e-4ced-a425-af1481ca8c0b"), null, null, new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F18.2.jpg?alt=media&token=f41c8267-27a0-46a1-ac00-183aa7bc303e" },
                    { new Guid("250b5b32-9197-45dd-a85d-f21d5c922737"), null, null, new Guid("a69cd06b-8762-49cc-9228-1fc88956fb3c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F19.1.jpg?alt=media&token=ecfdf322-bb3d-4959-ac7d-36ee2ca2ca98" },
                    { new Guid("29f8c2c4-222c-4c41-adda-5d74e281e6dd"), null, null, new Guid("7a684d3b-8e9f-4f06-a767-d59c1953f249"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F12.2.jpg?alt=media&token=cdc9fd2b-3d64-4242-bc3a-353f5558d8d1" },
                    { new Guid("2ab8bf12-fe94-4d7a-b5b2-577bca108581"), null, null, new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F1.1.jpg?alt=media&token=8aa2db36-a902-45d3-bd89-577a7e1051b9" },
                    { new Guid("2d5909b6-458b-4b15-b6d8-87f5c2698a80"), null, null, new Guid("30cfb1b3-da69-4a84-b94c-07ffe79597e0"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F3.2.jpg?alt=media&token=768cda30-028d-4750-9b40-fc47b06852f6" },
                    { new Guid("2edd5830-ac8d-4281-9a28-cfc1dd3f159e"), null, null, new Guid("a5c11a08-497c-4846-b922-bb8a95078dd1"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F7.1.jpg?alt=media&token=b06321a1-6c26-41f9-b707-0b3fddb44fe7" },
                    { new Guid("3305f179-86ef-45c5-b323-f058e1cef81d"), null, null, new Guid("2adef94c-fa06-4369-89ab-34e71052368e"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F14.2.jpg?alt=media&token=10434244-5b92-4216-9e1a-8929b8a1c1f4" },
                    { new Guid("3416a262-1421-4199-b15d-7c425d68f0ae"), null, null, new Guid("7a684d3b-8e9f-4f06-a767-d59c1953f249"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F12.3.jpg?alt=media&token=f86f1e73-dbdd-4358-8308-d3143655ae2f" },
                    { new Guid("38998549-11cb-4574-ba9c-9c8c91c59c31"), null, null, new Guid("25134650-be13-43de-bc40-22a9ea54b543"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F8.1.jpg?alt=media&token=1f0a016a-894a-4000-88e3-747adf1142df" },
                    { new Guid("3c38777b-ee15-4059-9cd0-b063d5d37a5e"), null, null, new Guid("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F6.2.jpg?alt=media&token=6d2437c5-a574-4bc8-9a4a-08c954f66940" },
                    { new Guid("3d460368-b879-4cda-991a-5e5c3db5f40e"), null, null, new Guid("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F4.3.jpg?alt=media&token=c2db8a67-158e-4d73-80aa-bcdcca6f1ad9" },
                    { new Guid("3e68861e-8ca4-4821-b145-de55067335d4"), null, null, new Guid("ba9968e6-4ad4-406c-9268-28acd686f73c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F17.2.jpg?alt=media&token=f2f3d557-46fd-4f54-82b3-17077ab6cca5" },
                    { new Guid("427880a9-3a3e-40c9-96d9-6c64dc6a2b84"), null, null, new Guid("8212e748-fe88-40af-894e-708a376f4fa7"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F10.2.jpg?alt=media&token=662ba6e6-79ae-4326-9e3b-1f266b06141e" },
                    { new Guid("43f77651-ab4f-4af9-8f58-be8d2790aa15"), null, null, new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F20.1.jpg?alt=media&token=2db339d6-5004-4dce-ab54-9b2377bff2a6" },
                    { new Guid("4c1a249c-a716-4ba3-9647-167c0a2e2d13"), null, null, new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F5.4.jpg?alt=media&token=36b36199-cec7-4421-bb43-1be5d9f90560" },
                    { new Guid("52b1b4ac-f0c1-406e-b30f-7b1981327327"), null, null, new Guid("ba9968e6-4ad4-406c-9268-28acd686f73c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F17.3.jpg?alt=media&token=0646948b-03c0-4417-8327-be728a121e63" },
                    { new Guid("56391da7-a3f5-4c8e-a5f6-f57abcf7f3e6"), null, null, new Guid("8212e748-fe88-40af-894e-708a376f4fa7"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F10.3.jpg?alt=media&token=5f1f19a4-1480-4ffe-8c54-c498342ff817" },
                    { new Guid("5873d292-a96f-44dc-8eb0-0340fb107c34"), null, null, new Guid("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F6.3.jpg?alt=media&token=00501803-2f9e-4d22-9e64-94211c171309" },
                    { new Guid("5ac66b04-463e-4fff-a379-a2d5068f516c"), null, null, new Guid("25134650-be13-43de-bc40-22a9ea54b543"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F8.2.jpg?alt=media&token=0a7802f0-17c9-4e8f-a6f8-38278ad0213d" },
                    { new Guid("5bedca84-0826-4525-8961-3a4b5f3d4488"), null, null, new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F1.2.jpg?alt=media&token=5ed9e2ad-a0ab-4144-bb83-b7a0bc943f79" },
                    { new Guid("64fcbca1-fdf4-4e9a-b841-29086da16f36"), null, null, new Guid("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F9.2.jpg?alt=media&token=6648b26a-153e-4bab-a22a-3c58693db145" },
                    { new Guid("68f9bd1e-fd66-45fb-8c7c-41cb7c3a69e9"), null, null, new Guid("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F13.1.jpg?alt=media&token=38cb92b8-6399-40df-9865-ee7eeae02616" },
                    { new Guid("6ce3b5dc-20ab-48d0-bef1-d8320ffdf317"), null, null, new Guid("6eeb6843-acf8-4760-b1b3-7ff01e5d3e8f"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F6.5.jpg?alt=media&token=aa7aa923-c490-40fe-82e5-3f6d1103ea6e" },
                    { new Guid("6e35ff78-1205-4164-bf2e-2d91af27f405"), null, null, new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F20.2.jpg?alt=media&token=516e44b7-6f8b-4db7-a610-0a3eeb063745" },
                    { new Guid("6f86b276-f7d6-4b4c-82a0-b5f0afba76ed"), null, null, new Guid("25134650-be13-43de-bc40-22a9ea54b543"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F8.3.jpg?alt=media&token=9d08e1b6-3feb-4f64-a517-f2550b86d674" },
                    { new Guid("7108b731-0a30-4be6-a1c1-ae5e72ba0d3a"), null, null, new Guid("2adef94c-fa06-4369-89ab-34e71052368e"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F14.3.jpg?alt=media&token=e0274537-66f5-43dd-8fea-58da0741f760" },
                    { new Guid("7124f9ce-7b64-4771-8486-f0cbb389468f"), null, null, new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F5.2.jpg?alt=media&token=4ed5345b-9f3f-4205-a477-8883ccdd5a54" },
                    { new Guid("7417048d-2ac0-456a-b53f-1841f7ab3f56"), null, null, new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F1.3.jpg?alt=media&token=85f219cc-ca82-4f76-8813-4b2d01396a54" },
                    { new Guid("74a5cdda-708a-4be2-8507-5f2f00c42883"), null, null, new Guid("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F13.5.jpg?alt=media&token=5c80780a-68ac-44ec-b369-80b5b92f9ef5" },
                    { new Guid("7ade8654-3f80-45f2-8da9-3dda1e276ec4"), null, null, new Guid("a5c11a08-497c-4846-b922-bb8a95078dd1"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F7.2.jpg?alt=media&token=7ea8139c-2195-4b99-9b0a-ffc1c34f35ab" },
                    { new Guid("80974c62-29d2-4db0-a32e-83ca74cb3383"), null, null, new Guid("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F9.3.jpg?alt=media&token=71642a0b-ade9-45c7-9a4e-0d3bf8aefb08" },
                    { new Guid("81d44c50-ade1-4913-899d-8ab35f14fe1c"), null, null, new Guid("6b821109-b650-4fa6-be2a-36dc8d5fbb4d"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F15.4.jpg?alt=media&token=639dec84-1a77-4acf-ac8d-bbe45c7c0ec1" },
                    { new Guid("870d103c-6a41-4037-8512-a50552570ae5"), null, null, new Guid("fc727800-963c-4305-93a0-3b27dfb1d734"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F16.2.jpeg?alt=media&token=373fbcd2-ae1f-4edb-951d-050edf0fddce" },
                    { new Guid("87b04ea4-acbb-48c0-9154-41b58c4c454c"), null, null, new Guid("25134650-be13-43de-bc40-22a9ea54b543"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F8.4.jpg?alt=media&token=de43b4c1-b3a3-4d88-a61c-3f72ea8ca7dd" },
                    { new Guid("905e459e-99e7-44f7-98a0-cf42c77229f4"), null, null, new Guid("a5c11a08-497c-4846-b922-bb8a95078dd1"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F7.3.jpg?alt=media&token=7c6000f6-66b6-4020-83f3-089812857d31" },
                    { new Guid("9856e332-caf4-406e-9ac4-647eaa797a74"), null, null, new Guid("6404ba59-9c63-4192-889b-3448cd7c9ba0"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F11.2.jpg?alt=media&token=0721c18d-3b51-4266-89ac-c5c7442bc59c" },
                    { new Guid("9a6b98af-6603-4ad6-ae62-b82389c5d8bd"), null, null, new Guid("d3fd8b9e-ff11-4c14-a453-edfd58f05135"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F5.3.jpg?alt=media&token=9bd2b6a8-8d07-4172-892c-c06b26c661dc" },
                    { new Guid("9b59ee88-21f1-44ac-ad0a-d843ed7802c5"), null, null, new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F18.3.jpg?alt=media&token=d61ca12f-1e94-4b50-a420-a4a83e0ccfc1" },
                    { new Guid("9f082e52-10db-4508-adf9-58f12b3e8c82"), null, null, new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F2.1.jpg?alt=media&token=9ebd04cb-02b4-4662-8618-53791f069691" },
                    { new Guid("adc3f002-d829-4d0f-9311-5695c3b024cf"), null, null, new Guid("30cfb1b3-da69-4a84-b94c-07ffe79597e0"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F3.3.jpg?alt=media&token=a6782085-e680-4bd7-98be-4bbbf1755a51" },
                    { new Guid("afd40e26-3e41-421d-8b74-fd35ff43cade"), null, null, new Guid("a69cd06b-8762-49cc-9228-1fc88956fb3c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F19.2.jpg?alt=media&token=5aec55ad-ad90-448b-9ae6-38c2181a7a28" },
                    { new Guid("b68030d5-8fa1-4df6-8193-b92a6f21d14b"), null, null, new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F2.2.jpg?alt=media&token=75e12cd9-1e2f-4b83-be28-629f06529e91" },
                    { new Guid("bf6af744-6d8f-4ca1-8720-0554a9d11fcb"), null, null, new Guid("e4cdecb7-84f2-4c28-be13-76b4f771b6f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F4.4.jpg?alt=media&token=455b20e2-a6c7-4889-90ef-28f547b08790" },
                    { new Guid("c1c1bc06-7d76-4f4b-987d-d4c3efbf5901"), null, null, new Guid("8b23df0f-ed33-48c5-9bfa-b2f15a6e6d0f"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F9.4.jpg?alt=media&token=0883a03b-33db-45b2-8973-f240e16e9b1b" },
                    { new Guid("cc0959cf-1c87-4fa5-9554-39e298e71f17"), null, null, new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F2.3.jpg?alt=media&token=ffc5cba6-f45f-43d4-a2ae-d181efc60d32" },
                    { new Guid("d5e6cb4e-20c7-4e82-bee8-4142ac208b7a"), null, null, new Guid("487ca896-ab72-4735-bee9-1b6a42ec3be6"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F2.4.jpg?alt=media&token=b0fa6d72-c3f6-4eb1-a260-00a9e002b6a5" },
                    { new Guid("dc1d2736-c849-4d4c-9817-6f19031c0b16"), null, null, new Guid("a69cd06b-8762-49cc-9228-1fc88956fb3c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F19.3.jpg?alt=media&token=404b341d-64f9-4ca5-a5d5-cae220042c5e" },
                    { new Guid("df705ccd-c062-45df-ac5e-49bedb874971"), null, null, new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F20.3.jpg?alt=media&token=ecdffbec-29d1-4f1d-9ddf-616f92a3b15d" },
                    { new Guid("e7556fef-42a8-4494-bdd5-bc39a7cce1aa"), null, null, new Guid("576aa3a9-49ff-486c-8efc-a0548ee90ee7"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F18.4.jpg?alt=media&token=f9bddef4-1395-485e-9513-445289e0ef74" },
                    { new Guid("ea3b8e36-f677-441e-8c0d-82cb5856fa85"), null, null, new Guid("0e758eaa-331b-409a-b09a-335cdb16a1f5"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F1.4.jpg?alt=media&token=7cdbdbd1-c9d2-44ea-9472-24a8ad85fc18" },
                    { new Guid("eb5ee868-c10f-4afe-8606-91f1752e8b26"), null, null, new Guid("fc727800-963c-4305-93a0-3b27dfb1d734"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F16.3.jpeg?alt=media&token=973e8efd-51e9-483d-9d87-2498bf0c3240" },
                    { new Guid("ebc736a8-05df-41d8-872a-368749bb14b6"), null, null, new Guid("30cfb1b3-da69-4a84-b94c-07ffe79597e0"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F3.4.jpg?alt=media&token=9b436fa5-ff2a-4bd9-99d1-50cad660d704" },
                    { new Guid("ed53b62e-1a70-4a11-bba8-efe527a63f47"), null, null, new Guid("ba9968e6-4ad4-406c-9268-28acd686f73c"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F17.4.jpg?alt=media&token=7e88e4c0-3b8e-4749-aa0a-f69d53e24f69" },
                    { new Guid("fb4ca598-f62a-419e-a94d-7f03d30944fb"), null, null, new Guid("74bc7dde-d01e-46ca-8fa6-e7cb7a70bb31"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F13.4.jpg?alt=media&token=eb410528-7cac-4971-a0b1-02da1096b227" },
                    { new Guid("fd927a8e-a6f5-4d22-b593-e9aec49d6fd7"), null, null, new Guid("b39c0722-44aa-49e5-8ff9-b9ad9a9594fc"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F20.4.jpg?alt=media&token=0fb153d2-b1b5-4ae7-a823-f802cd9bc952" },
                    { new Guid("fe6aeb73-17cc-4d83-91fe-7b009ceb0091"), null, null, new Guid("fc727800-963c-4305-93a0-3b27dfb1d734"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F16.4.jpeg?alt=media&token=0ad2cedb-da0e-45d0-85f2-e01def24e449" },
                    { new Guid("fe925dc4-bbd5-4d5d-a13b-1f3a6ee6628e"), null, null, new Guid("6404ba59-9c63-4192-889b-3448cd7c9ba0"), null, null, "https://firebasestorage.googleapis.com/v0/b/diamoondb-1412.appspot.com/o/PureFood%2FProductEx%2F11.3.jpg?alt=media&token=9b3e318d-63e3-47ec-968f-8bd053f1fc15" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0058660f-548f-4a05-9985-35adf77fa17b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("07902c5d-0e3b-4cff-9d74-69ef534d2d94"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("09a63769-85fe-4b22-972c-36d809084a5e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0c4ba54d-a39a-4c1b-bbb8-c909362fe973"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0e853075-8de3-40ab-afa6-5c7246118a47"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("0fc41889-3ff8-452b-8b98-e36f80d04360"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("113eea99-b426-447c-a608-aaa3f7be7267"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("141b88f2-1fe6-44f9-b9ed-b5230e0948bf"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("147470fc-0bbd-4e6d-ada8-b616ebffc343"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1594b568-5855-417d-86cb-96c61c6de1b3"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("160e7955-47f7-464a-b819-79c47f106b4d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1b36b25f-9168-4506-8e13-fd62f83acfdc"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("1d74d733-8b94-4043-b2e6-717bc76bd604"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("23b8737c-f1db-4148-96c4-2858e8be478b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("23f35439-253a-49be-9beb-486c8be37c90"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2416f0a9-bc9e-4ced-a425-af1481ca8c0b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("250b5b32-9197-45dd-a85d-f21d5c922737"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("29f8c2c4-222c-4c41-adda-5d74e281e6dd"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2ab8bf12-fe94-4d7a-b5b2-577bca108581"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2d5909b6-458b-4b15-b6d8-87f5c2698a80"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("2edd5830-ac8d-4281-9a28-cfc1dd3f159e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3305f179-86ef-45c5-b323-f058e1cef81d"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3416a262-1421-4199-b15d-7c425d68f0ae"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("38998549-11cb-4574-ba9c-9c8c91c59c31"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3c38777b-ee15-4059-9cd0-b063d5d37a5e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3d460368-b879-4cda-991a-5e5c3db5f40e"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("3e68861e-8ca4-4821-b145-de55067335d4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("427880a9-3a3e-40c9-96d9-6c64dc6a2b84"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("43f77651-ab4f-4af9-8f58-be8d2790aa15"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("4c1a249c-a716-4ba3-9647-167c0a2e2d13"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("52b1b4ac-f0c1-406e-b30f-7b1981327327"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("56391da7-a3f5-4c8e-a5f6-f57abcf7f3e6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5873d292-a96f-44dc-8eb0-0340fb107c34"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5ac66b04-463e-4fff-a379-a2d5068f516c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("5bedca84-0826-4525-8961-3a4b5f3d4488"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("64fcbca1-fdf4-4e9a-b841-29086da16f36"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("68f9bd1e-fd66-45fb-8c7c-41cb7c3a69e9"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6ce3b5dc-20ab-48d0-bef1-d8320ffdf317"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6e35ff78-1205-4164-bf2e-2d91af27f405"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("6f86b276-f7d6-4b4c-82a0-b5f0afba76ed"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("7108b731-0a30-4be6-a1c1-ae5e72ba0d3a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("7124f9ce-7b64-4771-8486-f0cbb389468f"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("7417048d-2ac0-456a-b53f-1841f7ab3f56"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("74a5cdda-708a-4be2-8507-5f2f00c42883"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("7ade8654-3f80-45f2-8da9-3dda1e276ec4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("80974c62-29d2-4db0-a32e-83ca74cb3383"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("81d44c50-ade1-4913-899d-8ab35f14fe1c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("870d103c-6a41-4037-8512-a50552570ae5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("87b04ea4-acbb-48c0-9154-41b58c4c454c"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("905e459e-99e7-44f7-98a0-cf42c77229f4"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("9856e332-caf4-406e-9ac4-647eaa797a74"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("9a6b98af-6603-4ad6-ae62-b82389c5d8bd"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("9b59ee88-21f1-44ac-ad0a-d843ed7802c5"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("9f082e52-10db-4508-adf9-58f12b3e8c82"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("adc3f002-d829-4d0f-9311-5695c3b024cf"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("afd40e26-3e41-421d-8b74-fd35ff43cade"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("b68030d5-8fa1-4df6-8193-b92a6f21d14b"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("bf6af744-6d8f-4ca1-8720-0554a9d11fcb"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("c1c1bc06-7d76-4f4b-987d-d4c3efbf5901"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("cc0959cf-1c87-4fa5-9554-39e298e71f17"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("d5e6cb4e-20c7-4e82-bee8-4142ac208b7a"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("dc1d2736-c849-4d4c-9817-6f19031c0b16"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("df705ccd-c062-45df-ac5e-49bedb874971"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("e7556fef-42a8-4494-bdd5-bc39a7cce1aa"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ea3b8e36-f677-441e-8c0d-82cb5856fa85"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("eb5ee868-c10f-4afe-8606-91f1752e8b26"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ebc736a8-05df-41d8-872a-368749bb14b6"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("ed53b62e-1a70-4a11-bba8-efe527a63f47"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("fb4ca598-f62a-419e-a94d-7f03d30944fb"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("fd927a8e-a6f5-4d22-b593-e9aec49d6fd7"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("fe6aeb73-17cc-4d83-91fe-7b009ceb0091"));

            migrationBuilder.DeleteData(
                table: "Images",
                keyColumn: "ImageId",
                keyValue: new Guid("fe925dc4-bbd5-4d5d-a13b-1f3a6ee6628e"));
        }
    }
}
