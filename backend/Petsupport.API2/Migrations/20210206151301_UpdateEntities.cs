using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Petsupport.API2.Migrations
{
    public partial class UpdateEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Longtitude",
                table: "Coordinate",
                newName: "Longitude");

            migrationBuilder.RenameColumn(
                name: "Lattiude",
                table: "Coordinate",
                newName: "Latitude");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "AzureId",
                value: new Guid("c20282b3-d810-4a05-8351-e4ce44634d06"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "AzureId",
                value: new Guid("4c7fcdde-1b8e-499d-a877-d26c5f26dddf"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "AzureId",
                value: new Guid("f6ffe603-5b0d-47e1-aa9b-d55d9fe0e194"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "AzureId",
                value: new Guid("3ba064d8-8cea-4c33-b53b-f520446bd620"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "AzureId",
                value: new Guid("e45adf0b-68de-464d-b227-bdd08940420a"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                column: "AzureId",
                value: new Guid("63809b33-526b-460f-829c-ca362efb28b6"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                column: "AzureId",
                value: new Guid("320938c9-a313-41e4-a541-9cd8831dc742"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                column: "AzureId",
                value: new Guid("0c63b807-ad7c-4dab-93c1-248df5031742"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                column: "AzureId",
                value: new Guid("8226b077-836b-42da-a8ca-b66677e9dcfc"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                column: "AzureId",
                value: new Guid("35caee83-0a89-4396-bd0e-ec33c28777b4"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11,
                column: "AzureId",
                value: new Guid("0db9dd82-a3a6-48b0-bab7-30596fca7b0f"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12,
                column: "AzureId",
                value: new Guid("03a2169e-12e2-4ef1-bf5c-566ac04e5732"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13,
                column: "AzureId",
                value: new Guid("708edaf7-e876-49d1-bdc3-73597deb4d37"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14,
                column: "AzureId",
                value: new Guid("4532af53-d380-4bf5-a7d4-93fb59b49053"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15,
                column: "AzureId",
                value: new Guid("5cd16919-52e5-40f2-8886-eb4dab807e23"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 16,
                column: "AzureId",
                value: new Guid("aa37a5b0-1341-4eaf-b27d-a5cdb40735d3"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 17,
                column: "AzureId",
                value: new Guid("85081ed4-c072-4dca-86db-d758c5502b48"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 18,
                column: "AzureId",
                value: new Guid("99d65b85-c13e-4e79-b81e-d7ffb5c8e16b"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 19,
                column: "AzureId",
                value: new Guid("c5cb8c42-3533-41dc-a28d-2a0fc4208c8b"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 20,
                column: "AzureId",
                value: new Guid("c7b7838f-65bf-4822-959b-dc66ae4da8ed"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 21,
                column: "AzureId",
                value: new Guid("77c60a39-c4c9-4d6d-8344-d34ac65324a1"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 22,
                column: "AzureId",
                value: new Guid("a10c2751-1b0f-4c90-8cdf-b9ede3ef0422"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 23,
                column: "AzureId",
                value: new Guid("74634a36-b7f2-4fef-acd5-0cfc18781a76"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 24,
                column: "AzureId",
                value: new Guid("038a94ed-11e2-4ea2-9cd8-951f7eead952"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 25,
                column: "AzureId",
                value: new Guid("6f6c8af2-2888-4273-b228-9e389f700a14"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 26,
                column: "AzureId",
                value: new Guid("0d0bb44b-1795-4711-97f3-99457456bd3e"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 27,
                column: "AzureId",
                value: new Guid("6f78a85b-a873-43d3-b517-b13463b2c3dd"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 28,
                column: "AzureId",
                value: new Guid("66aeff4b-c17d-4972-9855-34583df70303"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 29,
                column: "AzureId",
                value: new Guid("8358b748-3a1d-41a9-847a-40a562224c92"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 30,
                column: "AzureId",
                value: new Guid("508a619a-c2b2-49ed-9da9-ed56a8037294"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 31,
                column: "AzureId",
                value: new Guid("11a545dd-552b-4822-8927-d09f22de6e23"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 32,
                column: "AzureId",
                value: new Guid("bb12c5dc-9744-458a-b1fd-211437082eff"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 33,
                column: "AzureId",
                value: new Guid("5e40e154-1aaf-4211-9609-a5037b739d6f"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 34,
                column: "AzureId",
                value: new Guid("f312be01-def4-437f-9110-62a416506ac1"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 35,
                column: "AzureId",
                value: new Guid("70477295-9cd3-4792-85ac-b0397f018220"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 36,
                column: "AzureId",
                value: new Guid("a6f325eb-927b-43b0-ad8a-62135a0e4cdf"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 37,
                column: "AzureId",
                value: new Guid("a114d22a-a35c-422b-b4fc-19a4e19d3d62"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 38,
                column: "AzureId",
                value: new Guid("22d63a51-fa86-47f2-a2e0-198aa2f86064"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 39,
                column: "AzureId",
                value: new Guid("12ef1049-4264-4c9f-986a-2931f25c7e93"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 40,
                column: "AzureId",
                value: new Guid("19a007d3-6ecd-406b-81ea-3a9805f206d8"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 41,
                column: "AzureId",
                value: new Guid("bf3fb70a-7be6-4f9c-b93e-b32b10dc7973"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 42,
                column: "AzureId",
                value: new Guid("2416961a-d8d7-4f40-8810-adb9e05d3cf9"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 43,
                column: "AzureId",
                value: new Guid("4069b20b-97a9-42c4-b6b0-c4caa60f67e6"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 44,
                column: "AzureId",
                value: new Guid("6e2c3815-6590-452d-bde2-5bebe10a19a7"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 45,
                column: "AzureId",
                value: new Guid("a51e1599-e3a4-4160-a5cf-3475fd3bb081"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 46,
                column: "AzureId",
                value: new Guid("626748eb-87d1-4b59-8ac5-e4d6812ec679"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 47,
                column: "AzureId",
                value: new Guid("aa74fa7f-1309-4660-bb36-434b7cb4df09"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 48,
                column: "AzureId",
                value: new Guid("8f2520ee-87d8-4f04-b80b-1a5cd896b255"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 49,
                column: "AzureId",
                value: new Guid("b682dca0-0e39-4c38-a295-7a1eea57e4f8"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 50,
                column: "AzureId",
                value: new Guid("2186c2f8-c1a3-482e-a6cc-99cd332fb0e6"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 51,
                column: "AzureId",
                value: new Guid("8af709e4-6f88-4693-b53e-515f77f18c00"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 52,
                column: "AzureId",
                value: new Guid("a9dabd9b-c5f1-40f7-8c93-51502b80fccf"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 53,
                column: "AzureId",
                value: new Guid("a405a01d-7901-4f7a-92c1-a7cb0b241f64"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 54,
                column: "AzureId",
                value: new Guid("bab3b961-462d-4d8a-8bfe-237b36955a7b"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 55,
                column: "AzureId",
                value: new Guid("e1263d89-ee0f-4cd2-a59c-0f2b0a12cfdc"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 56,
                column: "AzureId",
                value: new Guid("93664e60-a22c-4ecb-9486-4dc1616be0e0"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 57,
                column: "AzureId",
                value: new Guid("cfb92d16-4820-4660-8aac-c7bc42a9bc30"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 58,
                column: "AzureId",
                value: new Guid("549c94bf-3f3c-45e6-b819-2a8f73875d5f"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 59,
                column: "AzureId",
                value: new Guid("13871144-deef-4bd7-a7cf-dec6ba0a5ef8"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 60,
                column: "AzureId",
                value: new Guid("29b366d2-6d2b-400b-8b88-be4030bfad75"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 61,
                column: "AzureId",
                value: new Guid("36d7ea93-d1ed-4718-9287-8f889d101c99"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 62,
                column: "AzureId",
                value: new Guid("7ec89bc2-7441-466e-b715-ce1d58b62819"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 63,
                column: "AzureId",
                value: new Guid("b2323665-ae42-4121-b83e-33fb7ac87f44"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 64,
                column: "AzureId",
                value: new Guid("1f23d970-a450-491b-926c-c0b669d3abdb"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 65,
                column: "AzureId",
                value: new Guid("e4564db1-2979-40de-ad2e-33a2d2f157ef"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 66,
                column: "AzureId",
                value: new Guid("90127066-131f-44b6-94ee-6829b32d61ef"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 67,
                column: "AzureId",
                value: new Guid("19358491-b691-43b0-a9a3-19b51d36aa3c"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 68,
                column: "AzureId",
                value: new Guid("aee6cb01-fc71-4685-a34f-ba8190fb3d32"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 69,
                column: "AzureId",
                value: new Guid("50952f74-fb87-48f1-9727-9218f72fb946"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 70,
                column: "AzureId",
                value: new Guid("646cdc69-92e4-4400-8123-46ed84a36d80"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 71,
                column: "AzureId",
                value: new Guid("d732116c-9c70-437d-97c6-d480b405655b"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 72,
                column: "AzureId",
                value: new Guid("8467a5f6-19dd-4abe-880c-5b7faaec7fa0"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 73,
                column: "AzureId",
                value: new Guid("dc8f6387-c89d-433e-9329-7ba6a72e57e4"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 74,
                column: "AzureId",
                value: new Guid("5f516ff8-c6af-45c1-b7ed-0049a2351b06"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 75,
                column: "AzureId",
                value: new Guid("2394e5fc-aad4-4240-9908-f133338366b3"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 76,
                column: "AzureId",
                value: new Guid("326947e5-5fc1-4e6a-a308-8b5e9138e809"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 77,
                column: "AzureId",
                value: new Guid("3f2f578a-aa03-44c7-9704-ba437cf21be5"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 78,
                column: "AzureId",
                value: new Guid("03da6239-b414-4c62-b0bc-9dae1fa5e825"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 79,
                column: "AzureId",
                value: new Guid("8c4ae326-e1b2-4a6a-8757-e6ad41274075"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 80,
                column: "AzureId",
                value: new Guid("cb2475e5-5371-485d-a5f8-32dd08d31cd9"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 81,
                column: "AzureId",
                value: new Guid("eb006383-85c4-4bd2-bbdd-b4671faeefcb"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 82,
                column: "AzureId",
                value: new Guid("a7acf39b-9162-4f17-bde9-121f99023d63"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 83,
                column: "AzureId",
                value: new Guid("2f899c79-636f-4c49-9bf3-51285e26ab13"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 84,
                column: "AzureId",
                value: new Guid("eea4b709-06ba-4f25-a7ba-53fc31d8b033"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 85,
                column: "AzureId",
                value: new Guid("56c57d8a-64be-4a5d-a14d-257d12f14f17"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 86,
                column: "AzureId",
                value: new Guid("50f48101-23fd-4f19-a25d-da3e2c029788"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 87,
                column: "AzureId",
                value: new Guid("00c33af0-ee1e-4d13-8322-63bf07a5b4f0"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 88,
                column: "AzureId",
                value: new Guid("13e8754a-fdc9-4b7f-8f7d-f1da39fdd32b"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 89,
                column: "AzureId",
                value: new Guid("595f033c-f2a9-4ac8-82b6-5b4ff10d1d7f"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 90,
                column: "AzureId",
                value: new Guid("0e28710b-0c31-44f5-bc90-84f737619bd7"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 91,
                column: "AzureId",
                value: new Guid("420efad6-a6c6-444b-8d31-c1b55d8813dd"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 92,
                column: "AzureId",
                value: new Guid("997e2d18-7cff-4675-9108-fd91e324ffed"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 93,
                column: "AzureId",
                value: new Guid("76586d8b-c41b-4c6c-8aad-d990f2f8f5ad"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 94,
                column: "AzureId",
                value: new Guid("6f6fe737-0b1f-42fd-b251-5a8ac4e225bb"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 95,
                column: "AzureId",
                value: new Guid("3790da98-c94b-447e-aafe-26d3d79899f0"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 96,
                column: "AzureId",
                value: new Guid("9e5365e9-f934-4b1e-9ead-c535e4bf3199"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 97,
                column: "AzureId",
                value: new Guid("40001d55-c25f-4092-830b-7256ac041cf5"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 98,
                column: "AzureId",
                value: new Guid("754381a8-8e02-4f2c-95cd-49676116ac7a"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 99,
                column: "AzureId",
                value: new Guid("ca83ac5e-b14f-4ab1-9ad8-3f40925ef08e"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 100,
                column: "AzureId",
                value: new Guid("dae75d08-0647-43ec-a0bd-6b297009019b"));

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 18, 35, 35, 912, DateTimeKind.Local).AddTicks(3690), new DateTime(2022, 1, 27, 16, 16, 15, 703, DateTimeKind.Local).AddTicks(3504), new Guid("855255c9-ba60-4841-9848-434311af9e1e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 14, 44, 324, DateTimeKind.Local).AddTicks(7180), new DateTime(2021, 7, 9, 15, 29, 17, 67, DateTimeKind.Local).AddTicks(6440), new Guid("42071762-bb00-4f0e-b4bb-33d31e1da30c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 39, 40, 737, DateTimeKind.Local).AddTicks(9238), new DateTime(2021, 10, 24, 11, 56, 58, 211, DateTimeKind.Local).AddTicks(6629), new Guid("72e370fe-c301-4841-8ff1-1823e2df111b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 52, 17, 567, DateTimeKind.Local).AddTicks(5399), new DateTime(2022, 1, 28, 5, 30, 18, 586, DateTimeKind.Local).AddTicks(1476), new Guid("da05b494-5c96-4528-b13b-4ad7c1e66989") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 41, 22, 358, DateTimeKind.Local).AddTicks(9717), new DateTime(2022, 1, 9, 8, 56, 43, 201, DateTimeKind.Local).AddTicks(6509), new Guid("8f19d633-28c1-4abc-b90c-f3ed3e85a222") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 6, 45, 72, DateTimeKind.Local).AddTicks(9910), new DateTime(2021, 5, 10, 16, 2, 4, 225, DateTimeKind.Local).AddTicks(761), new Guid("b5dba2a8-8991-4935-b62b-3f45b71528e4") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 4, 23, 20, 115, DateTimeKind.Local).AddTicks(18), new DateTime(2021, 4, 4, 11, 25, 56, 579, DateTimeKind.Local).AddTicks(3316), new Guid("d6a61aa6-4d59-4eaa-9368-da59a43c6133") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 10, 59, 52, 856, DateTimeKind.Local).AddTicks(3963), new DateTime(2021, 8, 5, 23, 27, 43, 709, DateTimeKind.Local).AddTicks(1146), new Guid("0ac1615e-5f50-402e-b85d-5af530d7a161") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 4, 35, 58, 569, DateTimeKind.Local).AddTicks(6116), new DateTime(2021, 6, 9, 22, 40, 28, 471, DateTimeKind.Local).AddTicks(9820), new Guid("d005f06b-4ed3-4fc5-9ba1-cc5e3aa37459") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 5, 10, 45, 928, DateTimeKind.Local).AddTicks(8981), new DateTime(2021, 6, 4, 21, 6, 32, 189, DateTimeKind.Local).AddTicks(1099), new Guid("41a4e052-0c50-4d62-a3a7-e572779cd7da") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 1, 22, 27, 602, DateTimeKind.Local).AddTicks(4186), new DateTime(2022, 1, 9, 12, 14, 41, 564, DateTimeKind.Local).AddTicks(4248), new Guid("348e3379-30b4-40eb-8bde-3a32add7f367") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 4, 36, 256, DateTimeKind.Local).AddTicks(3747), new DateTime(2021, 11, 19, 16, 45, 24, 261, DateTimeKind.Local).AddTicks(3412), new Guid("5d6795a8-a005-4827-b2cc-9c4faf784a7e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 30, 51, 933, DateTimeKind.Local).AddTicks(3820), new DateTime(2021, 3, 10, 7, 3, 18, 50, DateTimeKind.Local).AddTicks(1448), new Guid("d434dc9e-0a76-4808-81ae-887db8b0873a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 4, 22, 36, 840, DateTimeKind.Local).AddTicks(9783), new DateTime(2021, 8, 17, 12, 22, 12, 925, DateTimeKind.Local).AddTicks(4257), new Guid("c397fc9b-cae6-40e0-96e4-7c400e0224fd") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 17, 55, 23, 787, DateTimeKind.Local).AddTicks(3151), new DateTime(2021, 9, 20, 17, 34, 40, 804, DateTimeKind.Local).AddTicks(1169), new Guid("3013a150-96f2-4534-806c-08c03bec8dff") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 22, 8, 4, 634, DateTimeKind.Local).AddTicks(8656), new DateTime(2021, 12, 17, 0, 8, 18, 398, DateTimeKind.Local).AddTicks(4388), new Guid("7ae75ed4-2633-410a-b2fc-4ca744c50601") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 8, 26, 17, 225, DateTimeKind.Local).AddTicks(6661), new DateTime(2021, 5, 16, 13, 20, 52, 432, DateTimeKind.Local).AddTicks(4002), new Guid("b3e70e2a-d18f-4161-980c-f10ceb301df7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 3, 3, 6, 399, DateTimeKind.Local).AddTicks(5353), new DateTime(2021, 12, 28, 20, 10, 37, 805, DateTimeKind.Local).AddTicks(962), new Guid("55b7ae87-77f8-4632-8bf5-57275fe6b40a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 7, 2, 3, 477, DateTimeKind.Local).AddTicks(2597), new DateTime(2021, 5, 2, 2, 50, 56, 183, DateTimeKind.Local).AddTicks(2412), new Guid("9bbfc2c8-3d90-45b1-b945-d291e55d731e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 3, 52, 46, 847, DateTimeKind.Local).AddTicks(619), new DateTime(2021, 12, 8, 23, 46, 16, 810, DateTimeKind.Local).AddTicks(1184), new Guid("accb15f3-be11-4eda-aa0e-140adbe174ca") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 12, 6, 7, 494, DateTimeKind.Local).AddTicks(4783), new DateTime(2021, 11, 22, 13, 28, 24, 457, DateTimeKind.Local).AddTicks(8461), new Guid("e87be9f4-18fb-42c1-8026-ed6250ffa90e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 3, 28, 41, 900, DateTimeKind.Local).AddTicks(3019), new DateTime(2021, 6, 11, 8, 19, 23, 497, DateTimeKind.Local).AddTicks(5596), new Guid("46c910e9-7f9b-4329-b0d0-bd6232695eb9") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 18, 15, 410, DateTimeKind.Local).AddTicks(484), new DateTime(2021, 7, 2, 8, 8, 18, 855, DateTimeKind.Local).AddTicks(3204), new Guid("f731236a-f9dc-4993-8f20-ab132918927b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 38, 37, 104, DateTimeKind.Local).AddTicks(4460), new DateTime(2021, 12, 15, 14, 57, 7, 65, DateTimeKind.Local).AddTicks(7837), new Guid("b9d02e7e-062b-412e-81e4-f370b07c9a47") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 21, 35, 216, DateTimeKind.Local).AddTicks(3182), new DateTime(2021, 9, 30, 9, 40, 55, 861, DateTimeKind.Local).AddTicks(3792), new Guid("afc06f3d-f4b2-4101-b374-45f780cc9aff") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 32, 4, 859, DateTimeKind.Local).AddTicks(8973), new DateTime(2021, 12, 1, 14, 11, 31, 508, DateTimeKind.Local).AddTicks(8325), new Guid("76837772-2626-49dd-830d-17940ce76574") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 21, 59, 877, DateTimeKind.Local).AddTicks(39), new DateTime(2021, 2, 27, 10, 33, 54, 682, DateTimeKind.Local).AddTicks(9936), new Guid("890ab83c-907c-4e54-961c-d5cd298e7976") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 16, 39, 15, 855, DateTimeKind.Local).AddTicks(507), new DateTime(2021, 3, 2, 0, 12, 2, 317, DateTimeKind.Local).AddTicks(8116), new Guid("9efa4b09-c36b-47cc-b6de-3e13e95f75e8") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 57, 21, 149, DateTimeKind.Local).AddTicks(4394), new DateTime(2021, 2, 21, 18, 27, 34, 614, DateTimeKind.Local).AddTicks(9932), new Guid("96bc6f0e-e41d-4804-ae87-dcc5a7b69523") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 29, 37, 277, DateTimeKind.Local).AddTicks(7256), new DateTime(2021, 5, 13, 22, 38, 56, 792, DateTimeKind.Local).AddTicks(5992), new Guid("00cb4ad1-7544-42cd-bd67-8b8d9b80c5f4") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 19, 29, 32, 490, DateTimeKind.Local).AddTicks(7472), new DateTime(2022, 2, 2, 4, 54, 47, 32, DateTimeKind.Local).AddTicks(562), new Guid("881b72f8-06e2-4937-80f3-0c670066c581") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 57, 13, 906, DateTimeKind.Local).AddTicks(4925), new DateTime(2021, 9, 30, 6, 15, 41, 853, DateTimeKind.Local).AddTicks(319), new Guid("1670631f-b388-4e5a-bbe5-14440030561f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 41, 52, 543, DateTimeKind.Local).AddTicks(2182), new DateTime(2022, 2, 5, 2, 16, 6, 780, DateTimeKind.Local).AddTicks(8625), new Guid("01b56577-4fc0-4f89-8d12-8dc1c3f9237b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 2, 39, 683, DateTimeKind.Local).AddTicks(9353), new DateTime(2021, 11, 25, 9, 22, 52, 747, DateTimeKind.Local).AddTicks(7337), new Guid("96379929-cf68-4301-89b5-41f9250b6371") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 51, 34, 161, DateTimeKind.Local).AddTicks(2309), new DateTime(2021, 10, 20, 18, 9, 53, 945, DateTimeKind.Local).AddTicks(4277), new Guid("398bac89-9d22-4151-8f89-0cf417dd5bce") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 22, 24, 42, 569, DateTimeKind.Local).AddTicks(9294), new DateTime(2021, 4, 15, 11, 15, 22, 258, DateTimeKind.Local).AddTicks(3941), new Guid("237e008d-0a70-4f00-a9fd-fa213bf4cc16") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 10, 17, 316, DateTimeKind.Local).AddTicks(3511), new DateTime(2021, 9, 20, 15, 30, 44, 658, DateTimeKind.Local).AddTicks(2487), new Guid("524a7bda-d4a9-4c15-a747-004f8c5604df") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 8, 23, 56, 436, DateTimeKind.Local).AddTicks(5889), new DateTime(2022, 1, 19, 7, 53, 35, 108, DateTimeKind.Local).AddTicks(2675), new Guid("af82b184-acda-457b-b652-7adc50ac2f42") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 16, 30, 205, DateTimeKind.Local).AddTicks(2854), new DateTime(2021, 4, 16, 5, 58, 6, 531, DateTimeKind.Local).AddTicks(5090), new Guid("a9cef99e-a013-41d8-a980-2314e0801726") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 4, 57, 190, DateTimeKind.Local).AddTicks(6084), new DateTime(2021, 2, 17, 7, 31, 27, 394, DateTimeKind.Local).AddTicks(1245), new Guid("631a5850-a979-4e61-9b34-70e0f0b14d8e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 45, 56, 329, DateTimeKind.Local).AddTicks(6125), new DateTime(2021, 12, 14, 13, 32, 52, 16, DateTimeKind.Local).AddTicks(5955), new Guid("4085ad35-ed30-48da-9319-6abfd587c79c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 7, 44, 27, 382, DateTimeKind.Local).AddTicks(4519), new DateTime(2021, 6, 25, 13, 8, 16, 894, DateTimeKind.Local).AddTicks(1745), new Guid("486659d2-13ea-4ddf-92d2-fc1846cd38eb") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 3, 10, 6, 395, DateTimeKind.Local).AddTicks(7860), new DateTime(2021, 4, 25, 10, 46, 27, 77, DateTimeKind.Local).AddTicks(5822), new Guid("05c65931-e345-473f-9611-fb64ede549ba") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 8, 23, 52, 435, DateTimeKind.Local).AddTicks(7724), new DateTime(2021, 3, 9, 11, 37, 28, 399, DateTimeKind.Local).AddTicks(858), new Guid("bcb561f7-6474-4cd8-a121-79c23d6fe39c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 13, 42, 36, 956, DateTimeKind.Local).AddTicks(2040), new DateTime(2021, 8, 8, 18, 44, 9, 881, DateTimeKind.Local).AddTicks(497), new Guid("e3f61173-8b8d-42b4-be3c-a5409149b7d6") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 4, 17, 202, DateTimeKind.Local).AddTicks(4581), new DateTime(2021, 10, 20, 19, 6, 27, 511, DateTimeKind.Local).AddTicks(2340), new Guid("6436999c-b2f9-48e7-8c5c-49e977dc4214") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 5, 59, 203, DateTimeKind.Local).AddTicks(2583), new DateTime(2021, 6, 29, 16, 32, 50, 309, DateTimeKind.Local).AddTicks(7899), new Guid("b5d2e411-ae9a-42a4-9d45-e4b39464bd8e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 3, 6, 852, DateTimeKind.Local).AddTicks(6296), new DateTime(2021, 4, 20, 7, 53, 23, 265, DateTimeKind.Local).AddTicks(9765), new Guid("f15efd67-ed9b-4215-a523-57608af91c40") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 2, 50, 6, 802, DateTimeKind.Local).AddTicks(6277), new DateTime(2021, 10, 29, 23, 23, 8, 114, DateTimeKind.Local).AddTicks(3197), new Guid("6428aa67-42bd-4757-a518-439cd1578ab8") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 50, 58, 695, DateTimeKind.Local).AddTicks(692), new DateTime(2021, 5, 30, 17, 21, 42, 633, DateTimeKind.Local).AddTicks(4292), new Guid("51d12e22-9a4d-41bf-b31d-09e971bcd319") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 9, 18, 980, DateTimeKind.Local).AddTicks(7577), new DateTime(2021, 8, 17, 13, 59, 27, 129, DateTimeKind.Local).AddTicks(4340), new Guid("5a10889c-a0e4-4067-aba5-06f4fa6dc841") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 4, 9, 597, DateTimeKind.Local).AddTicks(3306), new DateTime(2021, 6, 16, 1, 24, 54, 880, DateTimeKind.Local).AddTicks(2495), new Guid("5bd95f5d-c5ad-487f-9f43-1cbdb79e720a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 23, 15, 173, DateTimeKind.Local).AddTicks(6713), new DateTime(2021, 10, 13, 1, 18, 52, 142, DateTimeKind.Local).AddTicks(5879), new Guid("66663aae-7b2c-4d60-b978-5329e464e296") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 3, 30, 58, DateTimeKind.Local).AddTicks(1062), new DateTime(2021, 8, 28, 13, 17, 6, 516, DateTimeKind.Local).AddTicks(8481), new Guid("c5c0d3fb-8536-46ab-896f-aa70d5ee0d49") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 3, 19, 12, 343, DateTimeKind.Local).AddTicks(3037), new DateTime(2021, 5, 8, 6, 14, 55, 613, DateTimeKind.Local).AddTicks(3402), new Guid("53eee580-c43f-4f29-9e52-473b06794341") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 5, 42, 59, 678, DateTimeKind.Local).AddTicks(9949), new DateTime(2021, 12, 15, 11, 37, 11, 713, DateTimeKind.Local).AddTicks(9660), new Guid("4d0285f9-943d-480d-9fa5-48b80e147c29") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 2, 10, 44, 936, DateTimeKind.Local).AddTicks(110), new DateTime(2021, 10, 6, 16, 57, 7, 260, DateTimeKind.Local).AddTicks(62), new Guid("1f65b887-6f3c-410a-aa7b-f90407e85c3b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 3, 42, 49, 632, DateTimeKind.Local).AddTicks(2864), new DateTime(2021, 11, 17, 13, 4, 56, 989, DateTimeKind.Local).AddTicks(5774), new Guid("36d34a3e-5ed6-43d0-aef3-223c7dac1b1d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 2, 43, 32, 57, DateTimeKind.Local).AddTicks(8727), new DateTime(2021, 11, 27, 17, 8, 33, 645, DateTimeKind.Local).AddTicks(5431), new Guid("9afe2c26-aa6d-415f-bb16-228a82ff17c3") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 17, 10, 411, DateTimeKind.Local).AddTicks(5675), new DateTime(2021, 9, 4, 18, 32, 41, 583, DateTimeKind.Local).AddTicks(565), new Guid("f9c7b48e-69db-410a-97ea-60b2794f5010") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 18, 53, 21, 427, DateTimeKind.Local).AddTicks(4123), new DateTime(2021, 3, 7, 1, 47, 46, 586, DateTimeKind.Local).AddTicks(4606), new Guid("d2df9add-ba01-4281-a9e3-e76a4a219763") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 8, 52, 23, 770, DateTimeKind.Local).AddTicks(2543), new DateTime(2021, 11, 27, 22, 7, 46, 379, DateTimeKind.Local).AddTicks(5436), new Guid("a7a6d080-a9bd-488b-be1d-ef3aecafbfa6") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 2, 3, 55, 398, DateTimeKind.Local).AddTicks(5064), new DateTime(2021, 3, 25, 21, 36, 26, 537, DateTimeKind.Local).AddTicks(1290), new Guid("f22c7e79-76c2-462f-8510-707d58deb438") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 13, 6, 48, 14, DateTimeKind.Local).AddTicks(8048), new DateTime(2021, 12, 6, 2, 52, 51, 758, DateTimeKind.Local).AddTicks(223), new Guid("e2c73a4f-53ac-4e54-8c0f-3441ac72bf5d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 53, 2, 349, DateTimeKind.Local).AddTicks(3914), new DateTime(2021, 12, 21, 10, 29, 52, 462, DateTimeKind.Local).AddTicks(2397), new Guid("bea6c9dc-7795-49d9-a664-dd9610d1eb1f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 35, 5, 346, DateTimeKind.Local).AddTicks(2514), new DateTime(2021, 9, 21, 17, 40, 57, 3, DateTimeKind.Local).AddTicks(9777), new Guid("e9b30943-8d5a-4eb1-850a-dfcaef3a5d06") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 27, 50, 697, DateTimeKind.Local).AddTicks(1503), new DateTime(2021, 4, 30, 7, 11, 36, 811, DateTimeKind.Local).AddTicks(5706), new Guid("8df299a2-e58d-472c-a7a8-b30021eea9fc") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 19, 44, 31, 560, DateTimeKind.Local).AddTicks(2578), new DateTime(2021, 11, 5, 5, 7, 21, 175, DateTimeKind.Local).AddTicks(1360), new Guid("9ad121ca-9bce-445f-ab91-f7312cc2128f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 8, 45, 19, 827, DateTimeKind.Local).AddTicks(2877), new DateTime(2021, 11, 30, 7, 4, 9, 166, DateTimeKind.Local).AddTicks(2686), new Guid("c4c6c5d2-a2e3-4c4c-942a-73528641790c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 35, 2, 773, DateTimeKind.Local).AddTicks(5405), new DateTime(2021, 7, 20, 16, 31, 53, 120, DateTimeKind.Local).AddTicks(5351), new Guid("7dc9910c-a465-40a9-8ec9-e9e247b70658") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 5, 8, 56, DateTimeKind.Local).AddTicks(5955), new DateTime(2021, 11, 20, 20, 49, 1, 641, DateTimeKind.Local).AddTicks(3049), new Guid("84d6c1cd-ed1a-425c-96b3-e51883ee5459") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 2, 1, 11, 18, DateTimeKind.Local).AddTicks(6864), new DateTime(2021, 7, 5, 19, 26, 47, 494, DateTimeKind.Local).AddTicks(8861), new Guid("3d389acc-3f78-4f74-8950-507a8586a0af") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 53, 40, 925, DateTimeKind.Local).AddTicks(4861), new DateTime(2021, 10, 3, 21, 55, 0, 572, DateTimeKind.Local).AddTicks(3578), new Guid("4fa42fed-cb56-44b3-bf61-76390769c5a8") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 20, 14, 787, DateTimeKind.Local).AddTicks(1984), new DateTime(2021, 4, 24, 13, 38, 18, 836, DateTimeKind.Local).AddTicks(7239), new Guid("c714272f-8569-4344-ad5e-4d7a659fee1f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 1, 28, 3, 329, DateTimeKind.Local).AddTicks(643), new DateTime(2021, 11, 7, 1, 9, 31, 190, DateTimeKind.Local).AddTicks(2570), new Guid("97347cf9-4846-4edb-a3ce-1bb4b0a650da") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 7, 18, 31, 820, DateTimeKind.Local).AddTicks(1089), new DateTime(2022, 1, 1, 7, 12, 35, 833, DateTimeKind.Local).AddTicks(9105), new Guid("34474a2f-3ce2-40e3-b786-1cbd9840bc64") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 10, 37, 24, 348, DateTimeKind.Local).AddTicks(9563), new DateTime(2021, 2, 16, 19, 11, 52, 26, DateTimeKind.Local).AddTicks(8476), new Guid("f61d6e73-6572-445c-95c0-653f6f30bd3f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 57, 42, 935, DateTimeKind.Local).AddTicks(4968), new DateTime(2021, 5, 21, 21, 57, 26, 169, DateTimeKind.Local).AddTicks(3690), new Guid("505efbd9-4997-4fbf-acd7-96d58107770b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 12, 19, 10, 345, DateTimeKind.Local).AddTicks(5783), new DateTime(2022, 1, 8, 8, 2, 40, 391, DateTimeKind.Local).AddTicks(7517), new Guid("f438d8fd-1356-408b-905b-740a2229061c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 32, 23, 192, DateTimeKind.Local).AddTicks(7916), new DateTime(2021, 8, 31, 4, 12, 32, 516, DateTimeKind.Local).AddTicks(7133), new Guid("56355fb0-e1ae-408e-aaa1-11ae7e10282a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 23, 12, 976, DateTimeKind.Local).AddTicks(9917), new DateTime(2021, 8, 31, 23, 31, 7, 406, DateTimeKind.Local).AddTicks(8236), new Guid("bc755beb-6552-448a-9ec2-bbc6c28b7e1b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 40, 5, 634, DateTimeKind.Local).AddTicks(7888), new DateTime(2021, 3, 30, 16, 21, 36, 895, DateTimeKind.Local).AddTicks(1165), new Guid("ef16ee8c-db7b-478e-ae2c-f10b89a2de01") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 4, 21, 31, 544, DateTimeKind.Local).AddTicks(6778), new DateTime(2021, 11, 7, 23, 58, 19, 167, DateTimeKind.Local).AddTicks(9694), new Guid("a6817c79-2d62-4ec5-8345-99d19b8d1392") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 18, 43, 28, 993, DateTimeKind.Local).AddTicks(4031), new DateTime(2021, 3, 24, 4, 3, 18, 604, DateTimeKind.Local).AddTicks(1478), new Guid("10519451-2137-4877-981c-b7c68b842b6c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 4, 42, 33, 160, DateTimeKind.Local).AddTicks(5820), new DateTime(2021, 10, 26, 23, 10, 53, 433, DateTimeKind.Local).AddTicks(3872), new Guid("f03a4e9d-c40f-412b-aebb-744e22c97737") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 22, 24, 926, DateTimeKind.Local).AddTicks(9893), new DateTime(2021, 3, 6, 10, 44, 23, 525, DateTimeKind.Local).AddTicks(9609), new Guid("432cdbc6-b82e-49bd-adee-cf2516e489bc") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 9, 5, 329, DateTimeKind.Local).AddTicks(7495), new DateTime(2022, 1, 22, 22, 13, 58, 238, DateTimeKind.Local).AddTicks(6125), new Guid("adfa8498-2629-42bb-9c75-a9237a492cf2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 47, 9, 855, DateTimeKind.Local).AddTicks(3662), new DateTime(2022, 1, 16, 12, 14, 46, 969, DateTimeKind.Local).AddTicks(7680), new Guid("5af97f4b-5e32-44b7-b152-d6b155b3f0b7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 50, 25, 425, DateTimeKind.Local).AddTicks(6911), new DateTime(2021, 12, 30, 20, 40, 5, 805, DateTimeKind.Local).AddTicks(4760), new Guid("d731bd3a-4e91-4ac4-9c4f-fcd19081caff") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 2, 48, 52, 775, DateTimeKind.Local).AddTicks(2009), new DateTime(2021, 3, 7, 10, 55, 16, 868, DateTimeKind.Local).AddTicks(8617), new Guid("58ddcb71-6d0d-4387-99de-63f8ff2a801f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 13, 37, 57, 327, DateTimeKind.Local).AddTicks(1863), new DateTime(2022, 1, 16, 3, 15, 47, 132, DateTimeKind.Local).AddTicks(4269), new Guid("426dde6c-38f8-482a-86b3-15de43b6c022") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 22, 25, 20, 309, DateTimeKind.Local).AddTicks(4342), new DateTime(2021, 12, 22, 5, 26, 49, 752, DateTimeKind.Local).AddTicks(8038), new Guid("494b0133-b161-4a8f-83a7-c8ee1a7f1f9d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 12, 17, 49, 219, DateTimeKind.Local).AddTicks(1998), new DateTime(2021, 2, 8, 8, 45, 42, 164, DateTimeKind.Local).AddTicks(9934), new Guid("4d39c27a-47b3-452d-b2d3-438bd16397c3") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 15, 25, 911, DateTimeKind.Local).AddTicks(9732), new DateTime(2021, 10, 4, 9, 49, 15, 529, DateTimeKind.Local).AddTicks(979), new Guid("2a0ec277-535a-4f61-b63b-bce6cdf7e297") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 18, 31, 51, 880, DateTimeKind.Local).AddTicks(4663), new DateTime(2021, 7, 26, 23, 53, 12, 405, DateTimeKind.Local).AddTicks(5105), new Guid("70ed025f-e83a-4598-9b04-3c02f8804be8") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 21, 21, 916, DateTimeKind.Local).AddTicks(8542), new DateTime(2021, 3, 9, 8, 10, 18, 959, DateTimeKind.Local).AddTicks(4688), new Guid("6950b92e-9c8b-451c-88aa-914e73dd2062") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 8, 48, 41, 534, DateTimeKind.Local).AddTicks(6772), new DateTime(2021, 10, 7, 12, 2, 4, 652, DateTimeKind.Local).AddTicks(7183), new Guid("03c74f74-0066-4b68-81b9-6e1cc55bb305") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 1, 1, 24, 123, DateTimeKind.Local).AddTicks(89), new DateTime(2022, 1, 3, 23, 58, 7, 834, DateTimeKind.Local).AddTicks(6474), new Guid("24547033-09d9-4a8a-93cf-e24d107c6506") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 4, 2, 26, 553, DateTimeKind.Local).AddTicks(605), new DateTime(2021, 4, 14, 4, 26, 51, 450, DateTimeKind.Local).AddTicks(461), new Guid("50e76f13-d037-487a-a928-cec5e42f8096") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 18, 22, 54, 358, DateTimeKind.Local).AddTicks(1503), new DateTime(2021, 4, 3, 2, 38, 38, 233, DateTimeKind.Local).AddTicks(8485), new Guid("100e253d-7e98-432a-900d-30bb664edfb1") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 19, 38, 15, 399, DateTimeKind.Local).AddTicks(9929), new DateTime(2021, 10, 8, 5, 2, 47, 488, DateTimeKind.Local).AddTicks(4241), new Guid("73161ca7-a7e5-432b-b8da-f24d9b760939") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 16, 45, 54, 7, DateTimeKind.Local).AddTicks(6847), new DateTime(2021, 8, 13, 8, 26, 42, 728, DateTimeKind.Local).AddTicks(8908), new Guid("c6c9a721-df0e-49d1-babb-33fa4ae0e826") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 36, 48, 653, DateTimeKind.Local).AddTicks(4424), new DateTime(2021, 7, 7, 10, 8, 38, 837, DateTimeKind.Local).AddTicks(6719), new Guid("b17f0c59-1e1a-40da-8d00-4abb9d52740c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 7, 52, 54, 767, DateTimeKind.Local).AddTicks(5049), new DateTime(2021, 8, 22, 5, 20, 29, 229, DateTimeKind.Local).AddTicks(578), new Guid("4219ce09-b094-4d11-b1cc-5dabe61bacf8") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 33, 23, 576, DateTimeKind.Local).AddTicks(841), new DateTime(2021, 7, 30, 17, 3, 6, 87, DateTimeKind.Local).AddTicks(1394), new Guid("e1c84363-1ee2-440e-b927-84a2bffc1c9a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 2, 43, 17, 287, DateTimeKind.Local).AddTicks(423), new DateTime(2021, 12, 4, 7, 53, 6, 127, DateTimeKind.Local).AddTicks(7258), new Guid("733bdb58-2a09-41ef-938f-7f40dc667232") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 42, 37, 347, DateTimeKind.Local).AddTicks(2985), new DateTime(2021, 10, 9, 12, 37, 5, 200, DateTimeKind.Local).AddTicks(3280), new Guid("6b7ad55b-b248-49bd-b0f9-0291011ae776") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 5, 54, 21, 719, DateTimeKind.Local).AddTicks(8468), new DateTime(2021, 3, 31, 1, 7, 28, 632, DateTimeKind.Local).AddTicks(6784), new Guid("d4cce82c-b571-4fc4-99b7-93f7c2d5fbaa") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 31, 41, 934, DateTimeKind.Local).AddTicks(1744), new DateTime(2021, 11, 3, 6, 46, 33, 810, DateTimeKind.Local).AddTicks(2183), new Guid("98ab1ec1-4fc1-4638-82ae-c2b2e5042ea1") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 27, 38, 716, DateTimeKind.Local).AddTicks(4973), new DateTime(2021, 7, 28, 7, 22, 9, 602, DateTimeKind.Local).AddTicks(1028), new Guid("22d6392d-a2f6-4f04-98c1-8d6058cc8dfb") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 19, 22, 922, DateTimeKind.Local).AddTicks(328), new DateTime(2021, 12, 28, 2, 8, 19, 218, DateTimeKind.Local).AddTicks(7552), new Guid("e1338ccc-56d2-40bc-8c8d-b65b8492b472") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 18, 16, 9, 896, DateTimeKind.Local).AddTicks(2541), new DateTime(2021, 4, 4, 10, 22, 4, 905, DateTimeKind.Local).AddTicks(49), new Guid("ce33bb6a-0a22-49e2-850e-1b32a2c24a32") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 10, 18, 58, 505, DateTimeKind.Local).AddTicks(301), new DateTime(2021, 5, 16, 16, 56, 3, 687, DateTimeKind.Local).AddTicks(7021), new Guid("f805b1ce-fb06-4572-ab1e-79681c62ccff") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 2, 51, 15, 47, DateTimeKind.Local).AddTicks(1557), new DateTime(2021, 10, 19, 23, 37, 31, 263, DateTimeKind.Local).AddTicks(2479), new Guid("c7709762-1ecd-4e93-b82c-3a5e54667b1e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 45, 24, 208, DateTimeKind.Local).AddTicks(7017), new DateTime(2021, 7, 4, 19, 32, 26, 432, DateTimeKind.Local).AddTicks(2515), new Guid("ede77e0b-f396-4f38-80c1-ff586082681d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 19, 35, 26, 158, DateTimeKind.Local).AddTicks(2713), new DateTime(2021, 5, 30, 0, 37, 35, 768, DateTimeKind.Local).AddTicks(1323), new Guid("f0e03974-67df-4daa-b91a-413b21912da2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 7, 14, 603, DateTimeKind.Local).AddTicks(796), new DateTime(2021, 12, 20, 2, 21, 21, 711, DateTimeKind.Local).AddTicks(853), new Guid("f2c162e8-fe67-4d07-b0f8-cb14d8c1b51c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 45, 24, 538, DateTimeKind.Local).AddTicks(9825), new DateTime(2021, 9, 26, 11, 35, 55, 381, DateTimeKind.Local).AddTicks(5319), new Guid("49ec332d-b6fa-40e0-b034-de7e72222d63") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 1, 43, 33, 465, DateTimeKind.Local).AddTicks(5166), new DateTime(2021, 4, 19, 12, 57, 58, 568, DateTimeKind.Local).AddTicks(392), new Guid("9f05f45b-5ac2-4c00-b475-6aa42e2ff217") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 3, 57, 890, DateTimeKind.Local).AddTicks(64), new DateTime(2021, 2, 14, 5, 19, 38, 259, DateTimeKind.Local).AddTicks(4245), new Guid("6add46ba-796c-4cac-918e-298dc34ad0c7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 50, 30, 873, DateTimeKind.Local).AddTicks(6045), new DateTime(2021, 10, 5, 21, 48, 14, 72, DateTimeKind.Local).AddTicks(8387), new Guid("5d294a3f-7870-469e-b2f5-3c3c0c901545") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 16, 31, 17, 932, DateTimeKind.Local).AddTicks(1331), new DateTime(2021, 10, 28, 0, 15, 14, 799, DateTimeKind.Local).AddTicks(7070), new Guid("c871ce49-9920-41bd-a3cf-cb21742e9d43") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 16, 17, 41, 265, DateTimeKind.Local).AddTicks(818), new DateTime(2021, 5, 31, 20, 43, 26, 852, DateTimeKind.Local).AddTicks(6298), new Guid("c780cda0-09e1-4de8-909e-46ec013620c5") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 4, 13, 19, 447, DateTimeKind.Local).AddTicks(6312), new DateTime(2021, 9, 9, 20, 26, 28, 398, DateTimeKind.Local).AddTicks(1847), new Guid("40c0b6d9-9be0-426a-89c7-559a2f8c6a2b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 43, 26, 683, DateTimeKind.Local).AddTicks(7846), new DateTime(2021, 9, 29, 17, 38, 50, 109, DateTimeKind.Local).AddTicks(9413), new Guid("c0cb7408-8bfa-432f-a49c-71e91a1e54a5") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 1, 20, 756, DateTimeKind.Local).AddTicks(4468), new DateTime(2021, 8, 2, 13, 8, 3, 91, DateTimeKind.Local).AddTicks(2619), new Guid("f04defab-0c0a-4ea5-8f33-24ed15401f00") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 19, 37, 50, 844, DateTimeKind.Local).AddTicks(3250), new DateTime(2021, 10, 31, 3, 2, 19, 836, DateTimeKind.Local).AddTicks(9213), new Guid("d79876c4-185a-4924-8be7-e4a578a7ecb9") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 16, 41, 530, DateTimeKind.Local).AddTicks(3898), new DateTime(2021, 2, 18, 15, 10, 48, 15, DateTimeKind.Local).AddTicks(6458), new Guid("4d315843-3994-421a-81ad-e42d7bd03288") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 3, 24, 48, 7, DateTimeKind.Local).AddTicks(4500), new DateTime(2022, 1, 20, 9, 12, 53, 875, DateTimeKind.Local).AddTicks(9097), new Guid("53822213-7016-4f5f-af58-011e549efba2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 22, 20, 42, 86, DateTimeKind.Local).AddTicks(1428), new DateTime(2021, 6, 8, 9, 50, 0, 783, DateTimeKind.Local).AddTicks(8198), new Guid("7c72ec0d-dac5-495a-8ad5-68d6084ff46d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 17, 35, 35, 637, DateTimeKind.Local).AddTicks(1066), new DateTime(2021, 11, 20, 16, 23, 47, 297, DateTimeKind.Local).AddTicks(7715), new Guid("314558c5-2522-4dd4-8e35-e9e0730bb298") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 40, 44, 779, DateTimeKind.Local).AddTicks(1961), new DateTime(2021, 3, 29, 7, 44, 21, 261, DateTimeKind.Local).AddTicks(6574), new Guid("975275f8-13af-4b6f-823a-1b050400fb9c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 18, 11, 37, 842, DateTimeKind.Local).AddTicks(3198), new DateTime(2021, 11, 17, 17, 34, 50, 212, DateTimeKind.Local).AddTicks(4926), new Guid("f0e88027-1b05-4a39-89fe-01cced60dd85") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 4, 6, 28, 558, DateTimeKind.Local).AddTicks(3236), new DateTime(2021, 4, 27, 5, 52, 3, 250, DateTimeKind.Local).AddTicks(3821), new Guid("f6c2fae5-ab77-45e1-8e9c-55d75360b41a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 7, 12, 0, 73, DateTimeKind.Local).AddTicks(9849), new DateTime(2021, 12, 26, 3, 5, 20, 918, DateTimeKind.Local).AddTicks(7253), new Guid("23106cce-4ccf-4075-a385-0e5b9677e786") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 18, 44, 44, 45, DateTimeKind.Local).AddTicks(9620), new DateTime(2021, 6, 7, 14, 15, 34, 623, DateTimeKind.Local).AddTicks(9159), new Guid("411d9123-86c3-4f25-8c47-cb0797803324") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 8, 21, 8, 125, DateTimeKind.Local).AddTicks(5088), new DateTime(2021, 4, 29, 3, 41, 35, 850, DateTimeKind.Local).AddTicks(6338), new Guid("d6b008bb-8578-4f0b-9368-23dbc9a2b54c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 40, 20, 125, DateTimeKind.Local).AddTicks(5788), new DateTime(2021, 7, 25, 14, 9, 3, 907, DateTimeKind.Local).AddTicks(1765), new Guid("d797b71e-aec1-4b82-b0b6-8f5dc7f7c42e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 22, 5, 0, 623, DateTimeKind.Local).AddTicks(9331), new DateTime(2021, 7, 19, 10, 44, 28, 564, DateTimeKind.Local).AddTicks(2397), new Guid("9c30483b-f5fd-48b3-8d38-5a62b85d03a9") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 13, 26, 40, 881, DateTimeKind.Local).AddTicks(9032), new DateTime(2021, 8, 30, 17, 5, 50, 124, DateTimeKind.Local).AddTicks(7301), new Guid("33dd3eb7-63fc-469e-84cf-8ef9f69339de") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 10, 20, 34, 90, DateTimeKind.Local).AddTicks(150), new DateTime(2021, 11, 27, 0, 45, 25, 633, DateTimeKind.Local).AddTicks(3212), new Guid("063a3a87-2baa-4183-8b2e-20f778622165") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 8, 41, 2, 885, DateTimeKind.Local).AddTicks(1141), new DateTime(2021, 8, 5, 20, 14, 31, 437, DateTimeKind.Local).AddTicks(4399), new Guid("3c3c9d9a-96ce-4b80-b6a1-20db708e2644") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 44, 10, 919, DateTimeKind.Local).AddTicks(4446), new DateTime(2021, 7, 23, 15, 30, 37, 461, DateTimeKind.Local).AddTicks(4405), new Guid("27ca3c6c-fe70-4755-ae02-0183fd762db7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 19, 5, 57, DateTimeKind.Local).AddTicks(4257), new DateTime(2021, 6, 20, 10, 39, 57, 87, DateTimeKind.Local).AddTicks(5235), new Guid("d8da1c4d-4fff-4b50-b53b-2416af7c2d71") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 31, 2, 123, DateTimeKind.Local).AddTicks(9084), new DateTime(2021, 10, 31, 11, 4, 40, 695, DateTimeKind.Local).AddTicks(3913), new Guid("f5fd8e80-f863-496a-95b9-e09010177c4c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 17, 26, 35, 258, DateTimeKind.Local).AddTicks(1832), new DateTime(2021, 7, 17, 17, 52, 14, 904, DateTimeKind.Local).AddTicks(3902), new Guid("0eaf0902-a9c9-429f-9423-7625c19e2a9a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 5, 39, 23, 479, DateTimeKind.Local).AddTicks(8345), new DateTime(2021, 4, 26, 2, 52, 21, 703, DateTimeKind.Local).AddTicks(6925), new Guid("6b3c0277-182f-4811-b5ee-c4d79f6f02bc") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 26, 19, 223, DateTimeKind.Local).AddTicks(9817), new DateTime(2021, 3, 27, 6, 3, 49, 768, DateTimeKind.Local).AddTicks(4933), new Guid("b7b9fe2e-be75-4353-8c9c-d4026c2a6f0d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 4, 42, 33, 171, DateTimeKind.Local).AddTicks(4889), new DateTime(2021, 5, 25, 23, 19, 15, 726, DateTimeKind.Local).AddTicks(7037), new Guid("f1053740-9332-4395-ace4-111aa274e908") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 37, 29, 398, DateTimeKind.Local).AddTicks(1915), new DateTime(2021, 5, 23, 15, 30, 29, 977, DateTimeKind.Local).AddTicks(7455), new Guid("cc7814c5-ca43-4207-b3b8-56ce5f39989a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 21, 58, 159, DateTimeKind.Local).AddTicks(9973), new DateTime(2021, 2, 8, 0, 26, 10, 529, DateTimeKind.Local).AddTicks(78), new Guid("0d7ed5b4-7e5c-4716-8d0a-13ecd1f3cb8d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 27, 47, 728, DateTimeKind.Local).AddTicks(8287), new DateTime(2021, 4, 8, 18, 44, 29, 176, DateTimeKind.Local).AddTicks(697), new Guid("d063012d-5edb-4632-8d6f-f68a7ccac959") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 5, 8, 19, 566, DateTimeKind.Local).AddTicks(5520), new DateTime(2021, 4, 16, 15, 10, 2, 629, DateTimeKind.Local).AddTicks(2050), new Guid("877c39d6-a20f-40da-af6a-c00bfa4822e1") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 7, 27, 21, 859, DateTimeKind.Local).AddTicks(7911), new DateTime(2021, 4, 23, 19, 5, 26, 152, DateTimeKind.Local).AddTicks(6854), new Guid("e183075d-30ec-4742-ad36-464247dbac6c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 22, 50, 51, 874, DateTimeKind.Local).AddTicks(207), new DateTime(2021, 8, 12, 7, 28, 24, 687, DateTimeKind.Local).AddTicks(5796), new Guid("3381d69f-9e0d-4f00-ae8c-381d66700fc8") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 17, 25, 50, 745, DateTimeKind.Local).AddTicks(322), new DateTime(2021, 2, 20, 11, 10, 51, 698, DateTimeKind.Local).AddTicks(4810), new Guid("8ae13ca9-34e4-4b4e-8100-11c5af495663") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 22, 24, 40, 759, DateTimeKind.Local).AddTicks(6823), new DateTime(2021, 8, 15, 9, 28, 19, 877, DateTimeKind.Local).AddTicks(1749), new Guid("a2309d94-6379-45d7-9387-75a2c8b44f44") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 25, 7, 497, DateTimeKind.Local).AddTicks(2735), new DateTime(2021, 3, 27, 7, 15, 0, 474, DateTimeKind.Local).AddTicks(6179), new Guid("fc879cac-bba4-4f09-8a6e-172cf38c72d0") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 24, 45, 453, DateTimeKind.Local).AddTicks(9541), new DateTime(2021, 7, 24, 17, 3, 48, 96, DateTimeKind.Local).AddTicks(5872), new Guid("eb77b6e1-4833-4a51-8930-3cab2434a516") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 49, 21, 241, DateTimeKind.Local).AddTicks(3806), new DateTime(2021, 2, 16, 3, 55, 48, 831, DateTimeKind.Local).AddTicks(7894), new Guid("4f7625f4-0ac1-41cf-a9d5-76b1e9e0d02c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 13, 23, 41, 353, DateTimeKind.Local).AddTicks(7473), new DateTime(2022, 1, 20, 12, 12, 49, 892, DateTimeKind.Local).AddTicks(8796), new Guid("e95be3e5-4f06-4415-b5c3-7ae49bf9f951") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 47, 55, 847, DateTimeKind.Local).AddTicks(1860), new DateTime(2021, 9, 8, 7, 2, 36, 884, DateTimeKind.Local).AddTicks(854), new Guid("0b3d7d52-3221-48b3-9726-57b46e4d208c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 22, 30, 47, 289, DateTimeKind.Local).AddTicks(3481), new DateTime(2021, 5, 4, 14, 10, 3, 620, DateTimeKind.Local).AddTicks(5896), new Guid("9a543902-9e10-4235-9987-cf576520f4fe") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 0, 55, 289, DateTimeKind.Local).AddTicks(2697), new DateTime(2021, 7, 15, 6, 51, 35, 398, DateTimeKind.Local).AddTicks(1679), new Guid("f0607087-e9e7-4f2f-9697-7cc281085a5e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 20, 14, 801, DateTimeKind.Local).AddTicks(4585), new DateTime(2021, 6, 12, 12, 13, 42, 667, DateTimeKind.Local).AddTicks(7292), new Guid("f2e68acf-cedb-4ee6-8e67-bda00e42f0de") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 12, 49, 19, DateTimeKind.Local).AddTicks(1639), new DateTime(2021, 10, 3, 14, 36, 49, 541, DateTimeKind.Local).AddTicks(2120), new Guid("f6ae2d69-1462-4f0b-b813-4a58577ae765") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 22, 33, 540, DateTimeKind.Local).AddTicks(2967), new DateTime(2021, 12, 28, 17, 20, 28, 475, DateTimeKind.Local).AddTicks(1710), new Guid("a62fc2cd-e2f7-4832-967b-051a0d8525d5") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 22, 8, 19, 9, DateTimeKind.Local).AddTicks(3916), new DateTime(2021, 6, 5, 7, 28, 24, 252, DateTimeKind.Local).AddTicks(773), new Guid("0fb37a3e-9abd-4bf2-a98d-33ef0c84df09") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 0, 25, 837, DateTimeKind.Local).AddTicks(4681), new DateTime(2021, 11, 21, 18, 33, 48, 807, DateTimeKind.Local).AddTicks(769), new Guid("ef3d50e7-a658-4b81-9850-290081601265") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 17, 37, 22, 121, DateTimeKind.Local).AddTicks(3552), new DateTime(2021, 3, 21, 5, 41, 15, 307, DateTimeKind.Local).AddTicks(8807), new Guid("a8c777c7-9e49-4031-8f78-5d76ff0524cb") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 8, 29, 56, 599, DateTimeKind.Local).AddTicks(3540), new DateTime(2021, 6, 8, 0, 54, 45, 605, DateTimeKind.Local).AddTicks(5363), new Guid("2530223e-1015-44aa-b9a4-6475393a9f5c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 57, 2, 402, DateTimeKind.Local).AddTicks(9467), new DateTime(2021, 3, 3, 17, 2, 2, 47, DateTimeKind.Local).AddTicks(863), new Guid("644dbf73-f21e-43f1-bf22-ddf8098af2e2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 16, 48, 49, 591, DateTimeKind.Local).AddTicks(7172), new DateTime(2022, 1, 6, 16, 6, 34, 538, DateTimeKind.Local).AddTicks(5190), new Guid("ce80713a-69c4-4814-bb84-f928c1c023cc") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 29, 48, 554, DateTimeKind.Local).AddTicks(9302), new DateTime(2021, 2, 27, 22, 47, 1, 471, DateTimeKind.Local).AddTicks(5815), new Guid("ddaed9d2-d4a4-458b-8630-9da6da66a47b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 4, 6, 51, 620, DateTimeKind.Local).AddTicks(3325), new DateTime(2021, 7, 23, 6, 8, 51, 459, DateTimeKind.Local).AddTicks(9336), new Guid("f385a89c-14d0-4ba4-9a62-120a827766fe") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 59, 48, 812, DateTimeKind.Local).AddTicks(3649), new DateTime(2021, 2, 13, 11, 35, 2, 969, DateTimeKind.Local).AddTicks(3130), new Guid("0a58a1f0-77ca-44d0-a7d1-77e4a1b5e09e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 12, 35, 11, 346, DateTimeKind.Local).AddTicks(1157), new DateTime(2022, 1, 26, 5, 48, 54, 18, DateTimeKind.Local).AddTicks(7839), new Guid("73aff4b2-1d0a-4128-9862-9391fcb1d70d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 7, 44, 54, 509, DateTimeKind.Local).AddTicks(1119), new DateTime(2021, 6, 10, 14, 41, 3, 18, DateTimeKind.Local).AddTicks(5945), new Guid("6c58dbcf-3f21-4881-aa9d-ac1cc958d83b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 27, 6, 198, DateTimeKind.Local).AddTicks(6575), new DateTime(2021, 10, 7, 15, 27, 34, 668, DateTimeKind.Local).AddTicks(5504), new Guid("af8a5063-42fe-4fad-9aba-0c06999348af") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 8, 18, 55, 774, DateTimeKind.Local).AddTicks(7249), new DateTime(2021, 5, 7, 1, 39, 50, 365, DateTimeKind.Local).AddTicks(1873), new Guid("2e53a8af-4ed3-4d37-9744-6302d7e6aaeb") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 17, 41, 21, 414, DateTimeKind.Local).AddTicks(1960), new DateTime(2022, 2, 3, 10, 21, 54, 86, DateTimeKind.Local).AddTicks(699), new Guid("904cb219-0a96-4db5-8e86-1cfa412ec007") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 3, 56, 24, 328, DateTimeKind.Local).AddTicks(1145), new DateTime(2022, 1, 5, 16, 46, 30, 381, DateTimeKind.Local).AddTicks(4357), new Guid("ce92eaea-15fa-40a9-88d8-82954aa5a4c2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 19, 58, 18, 532, DateTimeKind.Local).AddTicks(9823), new DateTime(2021, 7, 29, 14, 51, 23, 843, DateTimeKind.Local).AddTicks(3186), new Guid("633a7a0d-1f13-4aa0-a036-18507f3019b6") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 19, 36, 3, DateTimeKind.Local).AddTicks(2741), new DateTime(2021, 5, 14, 1, 21, 23, 463, DateTimeKind.Local).AddTicks(8201), new Guid("c9dc9351-abcd-4cdd-a84d-35a3c85a0aaa") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 13, 35, 40, 986, DateTimeKind.Local).AddTicks(1669), new DateTime(2021, 12, 10, 6, 19, 10, 706, DateTimeKind.Local).AddTicks(2457), new Guid("b8b195e4-58fe-4e9e-8ce5-e17a5a83e12b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 54, 39, 880, DateTimeKind.Local).AddTicks(2664), new DateTime(2021, 6, 18, 23, 18, 55, 758, DateTimeKind.Local).AddTicks(3885), new Guid("2b261771-69f3-4bb2-aecc-1aa5e3106b18") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 3, 16, 100, DateTimeKind.Local).AddTicks(1583), new DateTime(2021, 9, 28, 8, 52, 53, 700, DateTimeKind.Local).AddTicks(6398), new Guid("2aebb4df-e8d9-4786-ba6e-1ec3e5fcf245") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 43, 3, 844, DateTimeKind.Local).AddTicks(5002), new DateTime(2021, 9, 30, 7, 25, 11, 22, DateTimeKind.Local).AddTicks(8789), new Guid("0d8ec2be-b67a-40c5-bdc3-bc71e82585cb") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 54, 8, 423, DateTimeKind.Local).AddTicks(1389), new DateTime(2021, 9, 8, 0, 46, 44, 739, DateTimeKind.Local).AddTicks(4620), new Guid("008b3469-3765-468a-82b1-5ce819bd9b2b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 41, 55, 383, DateTimeKind.Local).AddTicks(2670), new DateTime(2021, 6, 13, 4, 22, 27, 215, DateTimeKind.Local).AddTicks(1485), new Guid("a218faf5-aa63-4946-becb-f43ef5fddcdb") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 10, 19, 13, 881, DateTimeKind.Local).AddTicks(5019), new DateTime(2021, 2, 8, 10, 13, 24, 908, DateTimeKind.Local).AddTicks(3805), new Guid("ee5287a7-87ca-451e-be9c-d1805a0a90bb") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 6, 54, 123, DateTimeKind.Local).AddTicks(7639), new DateTime(2021, 10, 20, 14, 14, 7, 131, DateTimeKind.Local).AddTicks(4590), new Guid("adc70103-72ef-4cea-a032-093f885f9e1e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 33, 24, 108, DateTimeKind.Local).AddTicks(5015), new DateTime(2021, 12, 6, 1, 19, 15, 495, DateTimeKind.Local).AddTicks(4972), new Guid("ff00b38b-b748-4833-a404-f20526c166b7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 10, 19, 14, 543, DateTimeKind.Local).AddTicks(5129), new DateTime(2022, 1, 9, 3, 56, 9, 410, DateTimeKind.Local).AddTicks(6823), new Guid("e1a3f4cd-a061-4541-8ffb-6f912e985ce1") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 44, 44, 244, DateTimeKind.Local).AddTicks(866), new DateTime(2022, 1, 2, 14, 41, 37, 145, DateTimeKind.Local).AddTicks(6422), new Guid("c17c9fd8-cf5f-4c79-a8f0-6ed9f7543dd3") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 13, 41, 5, 602, DateTimeKind.Local).AddTicks(7532), new DateTime(2021, 6, 23, 0, 12, 55, 403, DateTimeKind.Local).AddTicks(9878), new Guid("8e40a29d-c3d5-4559-8104-cf70fff332eb") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 10, 40, 16, 60, DateTimeKind.Local).AddTicks(6311), new DateTime(2021, 7, 27, 1, 27, 32, 954, DateTimeKind.Local).AddTicks(739), new Guid("5c03aeb3-64fa-479f-9d7f-3852c21d4fb0") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 3, 20, 46, 779, DateTimeKind.Local).AddTicks(5073), new DateTime(2021, 4, 21, 18, 55, 44, 566, DateTimeKind.Local).AddTicks(8292), new Guid("c43ceb7a-0fd7-4598-82dc-b9c05b2818b1") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 35, 24, 713, DateTimeKind.Local).AddTicks(5787), new DateTime(2021, 3, 10, 12, 12, 4, 34, DateTimeKind.Local).AddTicks(4618), new Guid("8002b550-d8df-4181-a4cd-1834077ae4ec") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 56, 6, 182, DateTimeKind.Local).AddTicks(1063), new DateTime(2022, 1, 22, 1, 0, 35, 236, DateTimeKind.Local).AddTicks(4015), new Guid("8150f6c4-dc8b-4c26-94ea-3f92cb0c97e6") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 18, 42, 19, 946, DateTimeKind.Local).AddTicks(1389), new DateTime(2021, 9, 30, 4, 9, 30, 952, DateTimeKind.Local).AddTicks(9197), new Guid("8dcbf45e-53c6-4e20-92b4-afcf89ef4f7b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 12, 33, 50, 239, DateTimeKind.Local).AddTicks(4637), new DateTime(2021, 4, 25, 4, 37, 4, 390, DateTimeKind.Local).AddTicks(3472), new Guid("ad15686f-e929-4b7c-a32f-68d5bfe1af12") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 10, 18, 32, 541, DateTimeKind.Local).AddTicks(6280), new DateTime(2021, 4, 16, 15, 45, 2, 165, DateTimeKind.Local).AddTicks(4181), new Guid("9c7bc448-c2f2-4157-a9de-db50c99d2d9e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 11, 27, 177, DateTimeKind.Local).AddTicks(8440), new DateTime(2021, 9, 2, 9, 58, 8, 688, DateTimeKind.Local).AddTicks(9215), new Guid("eb9bbe5d-5ea2-4352-91f1-841cd9c696c0") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 18, 0, 38, 852, DateTimeKind.Local).AddTicks(1251), new DateTime(2022, 1, 4, 15, 51, 57, 692, DateTimeKind.Local).AddTicks(1245), new Guid("9edea962-b84d-4e89-a14d-708b24e0e755") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 1, 20, 20, 984, DateTimeKind.Local).AddTicks(3662), new DateTime(2021, 8, 2, 11, 57, 29, 626, DateTimeKind.Local).AddTicks(9605), new Guid("2bcf8f8e-ba7d-45cd-8e13-5f185ce0a7ba") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 4, 31, 57, 369, DateTimeKind.Local).AddTicks(2204), new DateTime(2021, 11, 12, 13, 17, 47, 545, DateTimeKind.Local).AddTicks(3201), new Guid("08db842b-89ec-445b-9b2f-6f60bf8d130f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 16, 24, 56, 936, DateTimeKind.Local).AddTicks(1105), new DateTime(2021, 9, 9, 16, 28, 24, 779, DateTimeKind.Local).AddTicks(810), new Guid("277bd8e6-59c4-48c6-ab42-b1cde534b4e3") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 13, 14, 38, 914, DateTimeKind.Local).AddTicks(5530), new DateTime(2021, 4, 27, 19, 20, 40, 244, DateTimeKind.Local).AddTicks(8121), new Guid("7b8ef11e-5c15-494f-8e0b-c9886c3d330b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 13, 36, 33, 944, DateTimeKind.Local).AddTicks(685), new DateTime(2021, 3, 8, 19, 58, 56, 495, DateTimeKind.Local).AddTicks(2380), new Guid("81084253-4ee4-4408-8b5d-83413c3fc8d9") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 19, 12, 861, DateTimeKind.Local).AddTicks(2595), new DateTime(2021, 2, 14, 14, 36, 19, 404, DateTimeKind.Local).AddTicks(4072), new Guid("4d54fcef-bc2d-417d-8598-cbade5aac66f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 45, 0, 483, DateTimeKind.Local).AddTicks(6042), new DateTime(2021, 11, 16, 19, 13, 14, 218, DateTimeKind.Local).AddTicks(7009), new Guid("7a32ec93-a641-4ab6-88c9-10c7daac8e81") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 15, 22, 516, DateTimeKind.Local).AddTicks(6466), new DateTime(2021, 7, 14, 12, 39, 42, 953, DateTimeKind.Local).AddTicks(4505), new Guid("211f2156-c269-4688-a6ce-59bf6ac22ded") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 46, 55, 747, DateTimeKind.Local).AddTicks(5966), new DateTime(2021, 2, 17, 3, 52, 50, 448, DateTimeKind.Local).AddTicks(5036), new Guid("e141b537-10b9-4ab4-8a63-9f899e42258d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 5, 9, 18, 930, DateTimeKind.Local).AddTicks(3939), new DateTime(2021, 10, 9, 14, 31, 43, 393, DateTimeKind.Local).AddTicks(7287), new Guid("9401f283-00b4-4c4e-9a17-c015117b4008") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 18, 31, 37, 947, DateTimeKind.Local).AddTicks(1212), new DateTime(2021, 3, 20, 23, 1, 28, 476, DateTimeKind.Local).AddTicks(6923), new Guid("333f301c-e7b8-4eaf-aa74-a383ea8fa871") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 56, 14, 793, DateTimeKind.Local).AddTicks(5571), new DateTime(2021, 7, 15, 18, 44, 28, 695, DateTimeKind.Local).AddTicks(9242), new Guid("426ef0a7-e788-416d-93b8-9a5c301c9101") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 12, 6, 325, DateTimeKind.Local).AddTicks(6147), new DateTime(2021, 8, 5, 9, 43, 56, 728, DateTimeKind.Local).AddTicks(8718), new Guid("4f950b96-37cd-4b2e-bb90-be9518b4292a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 40, 24, 625, DateTimeKind.Local).AddTicks(2113), new DateTime(2022, 1, 20, 21, 50, 58, 665, DateTimeKind.Local).AddTicks(2105), new Guid("1431b56f-7746-43f9-9246-e60f06f0c2af") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 2, 33, 36, 141, DateTimeKind.Local).AddTicks(8572), new DateTime(2021, 10, 16, 1, 27, 16, 655, DateTimeKind.Local).AddTicks(4962), new Guid("5cc4be22-faaa-4af1-807f-c99a43e13369") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 8, 31, 508, DateTimeKind.Local).AddTicks(3967), new DateTime(2021, 5, 29, 20, 29, 43, 999, DateTimeKind.Local).AddTicks(8342), new Guid("836a2a43-3ce3-47d7-85bd-e81d9c3848d7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 4, 54, 19, 188, DateTimeKind.Local).AddTicks(8066), new DateTime(2021, 12, 9, 20, 5, 4, 151, DateTimeKind.Local).AddTicks(1364), new Guid("f50a0acb-bc37-4a5f-9d86-9f809834b5d4") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 7, 23, 6, 163, DateTimeKind.Local).AddTicks(4341), new DateTime(2021, 11, 5, 13, 34, 19, 935, DateTimeKind.Local).AddTicks(5705), new Guid("c82de367-e4fb-436f-8929-8d594123e170") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 36, 22, 498, DateTimeKind.Local).AddTicks(3429), new DateTime(2021, 5, 14, 19, 22, 0, 834, DateTimeKind.Local).AddTicks(9226), new Guid("60db355c-ac36-4722-96a0-b27fdff9704f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 10, 18, 0, 335, DateTimeKind.Local).AddTicks(5548), new DateTime(2021, 12, 23, 3, 22, 21, 497, DateTimeKind.Local).AddTicks(57), new Guid("62d9dc79-7ab4-40ec-81d5-844b97dea8ac") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 52, 27, 8, DateTimeKind.Local).AddTicks(6142), new DateTime(2021, 2, 16, 10, 9, 58, 783, DateTimeKind.Local).AddTicks(9300), new Guid("0f2c680c-97af-465f-a46f-6ac46dd1833b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 17, 0, 513, DateTimeKind.Local).AddTicks(5406), new DateTime(2022, 2, 2, 12, 35, 2, 474, DateTimeKind.Local).AddTicks(9531), new Guid("22a8bd16-67f9-4042-8686-de2e20fb6795") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 7, 20, 18, 358, DateTimeKind.Local).AddTicks(1890), new DateTime(2021, 6, 12, 20, 33, 39, 69, DateTimeKind.Local).AddTicks(4068), new Guid("4d5298af-9b86-48a0-aac9-2585f7ab80b5") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 40, 50, 109, DateTimeKind.Local).AddTicks(9830), new DateTime(2021, 10, 20, 11, 12, 57, 804, DateTimeKind.Local).AddTicks(2909), new Guid("89bed0de-9e18-49a0-a04e-0e7daf1dc5c2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 10, 18, 29, 869, DateTimeKind.Local).AddTicks(5513), new DateTime(2021, 10, 24, 15, 50, 33, 824, DateTimeKind.Local).AddTicks(2591), new Guid("163d2f3e-05d4-490b-9848-70502ad38963") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 10, 46, 469, DateTimeKind.Local).AddTicks(5715), new DateTime(2021, 2, 24, 1, 56, 52, 274, DateTimeKind.Local).AddTicks(5863), new Guid("ccd7deb2-5805-491f-9a0a-f2161f7fc981") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 22, 48, 18, 683, DateTimeKind.Local).AddTicks(8792), new DateTime(2021, 8, 13, 13, 27, 29, 455, DateTimeKind.Local).AddTicks(4372), new Guid("a530a731-225c-4c57-8db2-b59a2391fcac") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 1, 11, 46, 832, DateTimeKind.Local).AddTicks(4645), new DateTime(2021, 3, 11, 20, 19, 1, 566, DateTimeKind.Local).AddTicks(3170), new Guid("27af3a8d-cc72-4234-a3f9-e8fca08d02d6") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 5, 28, 312, DateTimeKind.Local).AddTicks(4577), new DateTime(2021, 8, 13, 8, 26, 45, 175, DateTimeKind.Local).AddTicks(7954), new Guid("efa9473d-e2b8-48e1-8f0c-d656c51100c1") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 5, 6, 37, 45, DateTimeKind.Local).AddTicks(1334), new DateTime(2021, 12, 1, 23, 43, 23, 754, DateTimeKind.Local).AddTicks(4606), new Guid("5a30b422-e2f9-4c92-a00c-c4fc423e1ddf") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 19, 23, 12, DateTimeKind.Local).AddTicks(4370), new DateTime(2021, 12, 2, 16, 49, 51, 733, DateTimeKind.Local).AddTicks(5282), new Guid("0aa912ee-9395-4e4a-a500-58ceb834bb68") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 49, 37, 389, DateTimeKind.Local).AddTicks(9792), new DateTime(2021, 9, 4, 18, 41, 39, 207, DateTimeKind.Local).AddTicks(2750), new Guid("cdd35ce6-aab8-4f1e-aca9-3e20fdad1018") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 39, 56, 756, DateTimeKind.Local).AddTicks(8135), new DateTime(2022, 1, 10, 6, 18, 28, 70, DateTimeKind.Local).AddTicks(2864), new Guid("871fc275-d71f-44b2-abe6-1ffed8fdc203") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 18, 0, 29, 522, DateTimeKind.Local).AddTicks(1275), new DateTime(2021, 5, 28, 7, 1, 56, 465, DateTimeKind.Local).AddTicks(2994), new Guid("ee10192d-b949-4f9e-a3ad-7a6612f2bd5a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 49, 38, 579, DateTimeKind.Local).AddTicks(4745), new DateTime(2021, 6, 10, 4, 55, 38, 678, DateTimeKind.Local).AddTicks(8277), new Guid("715bead1-2e68-4190-86c0-51496d7055a6") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 39, 0, 573, DateTimeKind.Local).AddTicks(5621), new DateTime(2022, 1, 28, 4, 25, 54, 144, DateTimeKind.Local).AddTicks(4742), new Guid("e5ac0871-e711-4430-8d79-66645696581d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 31, 44, 118, DateTimeKind.Local).AddTicks(8398), new DateTime(2021, 9, 21, 13, 52, 9, 601, DateTimeKind.Local).AddTicks(641), new Guid("d874b920-58f0-403f-bf17-bae2a1f8f829") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 5, 45, 15, 463, DateTimeKind.Local).AddTicks(5358), new DateTime(2021, 8, 7, 18, 14, 22, 460, DateTimeKind.Local).AddTicks(3594), new Guid("01c840e8-4e44-442f-8674-acc1eba23c38") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 26, 44, 581, DateTimeKind.Local).AddTicks(4191), new DateTime(2021, 9, 18, 18, 17, 29, 132, DateTimeKind.Local).AddTicks(7522), new Guid("57fb97b7-8003-4033-8cf2-6996738a14c4") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 39, 25, 78, DateTimeKind.Local).AddTicks(8626), new DateTime(2021, 3, 9, 21, 21, 28, 466, DateTimeKind.Local).AddTicks(6178), new Guid("68fa825f-8005-4bd7-8916-c4a36732d172") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 10, 22, 152, DateTimeKind.Local).AddTicks(1312), new DateTime(2021, 3, 28, 21, 31, 48, 780, DateTimeKind.Local).AddTicks(1564), new Guid("6ab7f8d8-69d2-4de1-86b9-705af0a3941f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 51, 52, 916, DateTimeKind.Local).AddTicks(2405), new DateTime(2021, 5, 30, 5, 47, 49, 869, DateTimeKind.Local).AddTicks(4265), new Guid("034258d8-6b81-4dfc-a11f-cd15f5154ee9") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 12, 6, 36, 837, DateTimeKind.Local).AddTicks(4281), new DateTime(2022, 2, 3, 8, 52, 35, 332, DateTimeKind.Local).AddTicks(5936), new Guid("8f9acd6d-5324-4fed-8f29-ad88bbb3fbf4") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 3, 6, 32, 845, DateTimeKind.Local).AddTicks(4199), new DateTime(2022, 1, 2, 3, 2, 44, 310, DateTimeKind.Local).AddTicks(7924), new Guid("ba065409-6d3b-405c-ae9a-edb4b19509d7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 44, 8, 533, DateTimeKind.Local).AddTicks(7991), new DateTime(2021, 12, 14, 14, 44, 35, 962, DateTimeKind.Local).AddTicks(8215), new Guid("1c1c2515-3738-4d7b-93d9-9410479c1dce") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 38, 33, 914, DateTimeKind.Local).AddTicks(1411), new DateTime(2021, 3, 16, 19, 1, 49, 330, DateTimeKind.Local).AddTicks(7938), new Guid("4e3ff5ba-babb-4a0e-a46d-a454afa68202") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 5, 12, 34, 878, DateTimeKind.Local).AddTicks(8438), new DateTime(2021, 12, 25, 23, 23, 57, 98, DateTimeKind.Local).AddTicks(3091), new Guid("db71d5d3-0c66-46f6-b801-0182eec478de") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 6, 48, 40, 753, DateTimeKind.Local).AddTicks(9249), new DateTime(2021, 11, 14, 5, 9, 53, 588, DateTimeKind.Local).AddTicks(3667), new Guid("70623dad-344e-4253-86cc-ac5e338b1cbf") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 50, 35, 340, DateTimeKind.Local).AddTicks(4475), new DateTime(2021, 5, 5, 18, 23, 19, 497, DateTimeKind.Local).AddTicks(3586), new Guid("f461761e-db8b-47ae-bdcd-77f3ba8be20b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 40, 13, 332, DateTimeKind.Local).AddTicks(9965), new DateTime(2021, 5, 13, 9, 37, 29, 90, DateTimeKind.Local).AddTicks(2563), new Guid("e7e99e56-2bdc-48f2-a2cd-a445aa6b3814") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 7, 37, 572, DateTimeKind.Local).AddTicks(3581), new DateTime(2022, 1, 7, 2, 2, 43, 127, DateTimeKind.Local).AddTicks(4674), new Guid("e3b1f6c6-0372-471a-8064-843727ee8d6c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 54, 3, 880, DateTimeKind.Local).AddTicks(9562), new DateTime(2021, 12, 19, 15, 26, 27, 347, DateTimeKind.Local).AddTicks(2037), new Guid("1b06669a-3585-4c62-bb0a-d6c39490f3bf") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 1, 46, 32, 142, DateTimeKind.Local).AddTicks(7899), new DateTime(2021, 3, 15, 18, 29, 56, 860, DateTimeKind.Local).AddTicks(5231), new Guid("d529326a-92ed-48d8-96e3-9ed49cb587a4") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 7, 27, 6, 826, DateTimeKind.Local).AddTicks(89), new DateTime(2021, 9, 4, 13, 52, 34, 456, DateTimeKind.Local).AddTicks(781), new Guid("5491875e-bed6-4473-8ea7-58cd57675313") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 1, 50, 58, 744, DateTimeKind.Local).AddTicks(8269), new DateTime(2021, 8, 28, 17, 44, 50, 242, DateTimeKind.Local).AddTicks(321), new Guid("6575e41f-ffe1-4fbb-8eaa-640324578569") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 23, 59, 24, 489, DateTimeKind.Local).AddTicks(6160), new DateTime(2021, 12, 18, 10, 6, 13, 764, DateTimeKind.Local).AddTicks(6487), new Guid("1f00d558-d8bf-4a27-ad49-77101a589ed6") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 39, 56, 542, DateTimeKind.Local).AddTicks(9370), new DateTime(2021, 9, 1, 22, 31, 49, 347, DateTimeKind.Local).AddTicks(2225), new Guid("5d14f2ee-9e96-4ebe-863a-05157d80dcab") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 55, 9, 630, DateTimeKind.Local).AddTicks(3806), new DateTime(2021, 4, 8, 2, 18, 33, 951, DateTimeKind.Local).AddTicks(3074), new Guid("5702266a-fe06-4449-9b39-19dc4bd7be0b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 18, 16, 23, 298, DateTimeKind.Local).AddTicks(9042), new DateTime(2021, 8, 31, 2, 42, 30, 36, DateTimeKind.Local).AddTicks(8448), new Guid("44b10b15-3e68-4456-9d7c-c11a4307eda2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 51, 37, 289, DateTimeKind.Local).AddTicks(7944), new DateTime(2021, 3, 31, 14, 52, 55, 919, DateTimeKind.Local).AddTicks(6673), new Guid("252f99ae-de95-4dd7-8473-a4ad41221976") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 49, 57, 321, DateTimeKind.Local).AddTicks(8181), new DateTime(2021, 8, 2, 20, 4, 6, 397, DateTimeKind.Local).AddTicks(6238), new Guid("28bcb600-8b3a-471d-a4e6-9ead0a7e1a3f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 7, 46, 7, 650, DateTimeKind.Local).AddTicks(6592), new DateTime(2021, 4, 24, 8, 41, 59, 658, DateTimeKind.Local).AddTicks(1894), new Guid("6af6fb4e-8536-4d07-bdff-721d94fc9e0e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 45, 47, 557, DateTimeKind.Local).AddTicks(3979), new DateTime(2021, 3, 20, 4, 20, 32, 988, DateTimeKind.Local).AddTicks(2663), new Guid("d2632d6a-f4a3-4c9a-9967-1c975ab74a42") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 10, 33, 4, 614, DateTimeKind.Local).AddTicks(4192), new DateTime(2021, 5, 11, 0, 48, 56, 54, DateTimeKind.Local).AddTicks(1168), new Guid("d61f2aeb-e85f-4fee-8d7b-a846f607bf4f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 10, 17, 55, 802, DateTimeKind.Local).AddTicks(5890), new DateTime(2021, 9, 8, 13, 23, 8, 672, DateTimeKind.Local).AddTicks(8766), new Guid("3cab4fc5-cd2b-48eb-bfa1-a7a901936f79") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 21, 53, 1, 858, DateTimeKind.Local).AddTicks(6476), new DateTime(2021, 12, 24, 4, 32, 23, 693, DateTimeKind.Local).AddTicks(5256), new Guid("8f1b4949-2537-426a-a2b3-bbb0010d82cd") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 55, 39, 329, DateTimeKind.Local).AddTicks(344), new DateTime(2021, 2, 6, 17, 15, 27, 456, DateTimeKind.Local).AddTicks(3339), new Guid("bc9d4739-d33c-4605-a269-9d79224d8520") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 20, 15, 781, DateTimeKind.Local).AddTicks(4036), new DateTime(2021, 6, 20, 8, 7, 35, 9, DateTimeKind.Local).AddTicks(2483), new Guid("c7ac84ff-ebc3-4cf8-a680-58e4bc7f9898") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 11, 25, 27, 969, DateTimeKind.Local).AddTicks(4449), new DateTime(2021, 11, 18, 11, 0, 27, 47, DateTimeKind.Local).AddTicks(4314), new Guid("2d3370df-3068-4b97-9399-f4baf48aabe7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 4, 40, 206, DateTimeKind.Local).AddTicks(9049), new DateTime(2021, 6, 2, 15, 31, 59, 765, DateTimeKind.Local).AddTicks(4363), new Guid("41afa10b-6dd0-4a5a-b2a5-f11b24997617") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 5, 53, 48, 687, DateTimeKind.Local).AddTicks(3281), new DateTime(2021, 3, 24, 5, 42, 54, 489, DateTimeKind.Local).AddTicks(1884), new Guid("9c9ed4c3-cf17-4221-9203-316e35e2bcf4") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 4, 58, 48, 240, DateTimeKind.Local).AddTicks(7886), new DateTime(2021, 3, 13, 11, 15, 0, 903, DateTimeKind.Local).AddTicks(1969), new Guid("b7e10050-73db-4404-bd32-01bec2188645") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 1, 19, 0, 563, DateTimeKind.Local).AddTicks(2596), new DateTime(2021, 4, 23, 0, 19, 9, 322, DateTimeKind.Local).AddTicks(3085), new Guid("ed973bf6-24fb-4407-8ab9-4ed7301c9d3c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 58, 2, 177, DateTimeKind.Local).AddTicks(7869), new DateTime(2021, 8, 2, 3, 49, 6, 902, DateTimeKind.Local).AddTicks(332), new Guid("89a9a208-c1ef-4b46-9cc3-1e6c0f016984") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 7, 11, 53, 307, DateTimeKind.Local).AddTicks(2002), new DateTime(2021, 2, 12, 10, 54, 4, 350, DateTimeKind.Local).AddTicks(78), new Guid("fd7c5484-edb2-45a2-9a2b-10c5544b259d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 2, 34, 45, 981, DateTimeKind.Local).AddTicks(2202), new DateTime(2021, 11, 17, 7, 31, 53, 598, DateTimeKind.Local).AddTicks(3920), new Guid("23cd60c2-5a92-4524-b98f-706991d3f76b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 22, 40, 51, 598, DateTimeKind.Local).AddTicks(6193), new DateTime(2021, 7, 26, 9, 15, 12, 512, DateTimeKind.Local).AddTicks(9742), new Guid("e2ed7ed9-d238-4a0e-a5f7-892ad0ce8f46") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 1, 8, 47, 159, DateTimeKind.Local).AddTicks(3846), new DateTime(2021, 8, 17, 20, 16, 25, 110, DateTimeKind.Local).AddTicks(5322), new Guid("b24fda31-f810-402f-acf6-d74155ea0887") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 3, 0, 57, 113, DateTimeKind.Local).AddTicks(6867), new DateTime(2021, 6, 2, 11, 48, 6, 914, DateTimeKind.Local).AddTicks(7016), new Guid("4bd8800b-7523-4fe6-a9e7-031d0abfcf82") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 19, 56, 33, 528, DateTimeKind.Local).AddTicks(27), new DateTime(2021, 12, 24, 4, 29, 41, 734, DateTimeKind.Local).AddTicks(649), new Guid("5df98559-4906-4980-a27c-e3fdd81d6758") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 13, 57, 23, 640, DateTimeKind.Local).AddTicks(9123), new DateTime(2021, 10, 5, 22, 10, 6, 260, DateTimeKind.Local).AddTicks(8243), new Guid("f56017d9-4c51-4bf2-87aa-18ba479a0417") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 22, 57, 46, 437, DateTimeKind.Local).AddTicks(2753), new DateTime(2021, 12, 15, 13, 49, 32, 794, DateTimeKind.Local).AddTicks(7575), new Guid("b6114495-5166-445e-b50d-7eced2278475") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 20, 26, 37, 431, DateTimeKind.Local).AddTicks(3572), new DateTime(2021, 2, 22, 12, 19, 22, 467, DateTimeKind.Local).AddTicks(8888), new Guid("08a67bde-1eb6-4149-9700-b88b4a675bfb") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 12, 7, 237, DateTimeKind.Local).AddTicks(7617), new DateTime(2022, 1, 4, 20, 38, 58, 596, DateTimeKind.Local).AddTicks(3214), new Guid("2a3e3a7b-4160-401e-9435-faf4c531b3c2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 5, 19, 43, 33, 683, DateTimeKind.Local).AddTicks(8162), new DateTime(2021, 4, 7, 6, 52, 33, 241, DateTimeKind.Local).AddTicks(3733), new Guid("dd4fe7ff-520f-4833-8948-771d87c2eab8") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 55, 25, 173, DateTimeKind.Local).AddTicks(5227), new DateTime(2021, 10, 5, 0, 49, 1, 100, DateTimeKind.Local).AddTicks(2647), new Guid("95d3d518-13fa-46e4-bcdd-8d1d4b36db49") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 7, 27, 45, 10, DateTimeKind.Local).AddTicks(9609), new DateTime(2021, 12, 5, 13, 39, 19, 464, DateTimeKind.Local).AddTicks(553), new Guid("45aa78d4-31a1-49f2-8ca2-0c1471ab6ae8") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 2, 49, 583, DateTimeKind.Local).AddTicks(2430), new DateTime(2021, 12, 6, 9, 39, 19, 424, DateTimeKind.Local).AddTicks(5741), new Guid("49ca4c75-82e4-4ef9-85ad-499444fbc414") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 10, 26, 22, 58, DateTimeKind.Local).AddTicks(5220), new DateTime(2021, 11, 28, 14, 3, 36, 547, DateTimeKind.Local).AddTicks(1946), new Guid("41527c45-6c92-4818-bd5c-3403ba81694c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 10, 14, 26, 141, DateTimeKind.Local).AddTicks(9975), new DateTime(2021, 9, 13, 9, 23, 51, 380, DateTimeKind.Local).AddTicks(5871), new Guid("e46fe72f-7844-4642-80b8-4766d200a3c6") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 0, 52, 46, 777, DateTimeKind.Local).AddTicks(1316), new DateTime(2021, 3, 25, 9, 54, 5, 425, DateTimeKind.Local).AddTicks(6046), new Guid("9d8184b1-d3fc-433d-b4d9-e08ac187c4ad") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 13, 54, 52, 26, DateTimeKind.Local).AddTicks(1779), new DateTime(2021, 6, 11, 21, 5, 43, 768, DateTimeKind.Local).AddTicks(2470), new Guid("5f547f1e-b9c4-47ab-96fd-d22cb97969e4") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 13, 11, 49, 417, DateTimeKind.Local).AddTicks(226), new DateTime(2021, 2, 20, 16, 32, 52, 507, DateTimeKind.Local).AddTicks(4624), new Guid("d3d35998-bd64-41ba-a6f9-636188d253a8") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 8, 29, 18, 498, DateTimeKind.Local).AddTicks(1959), new DateTime(2021, 11, 30, 13, 34, 47, 368, DateTimeKind.Local).AddTicks(2113), new Guid("98a2aa85-3b48-4e78-af1a-939febce57b2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 9, 58, 19, 841, DateTimeKind.Local).AddTicks(311), new DateTime(2021, 10, 27, 0, 1, 32, 391, DateTimeKind.Local).AddTicks(7447), new Guid("fb368cb8-a6b8-4378-9228-3ec87c7342d3") });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Longitude",
                table: "Coordinate",
                newName: "Longtitude");

            migrationBuilder.RenameColumn(
                name: "Latitude",
                table: "Coordinate",
                newName: "Lattiude");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "AzureId",
                value: new Guid("dc8242be-ba12-48f7-9309-4a46231c870f"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "AzureId",
                value: new Guid("2775ed7d-afc8-4a71-baa6-252113b84200"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "AzureId",
                value: new Guid("ece9b27e-95a8-4d52-9dc6-8ad9ab0c95a1"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "AzureId",
                value: new Guid("04ad9743-a9bd-46fc-9bc3-ecf00bb1845d"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "AzureId",
                value: new Guid("db72dd89-da4d-4f17-b9e7-6e9e4290f37d"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                column: "AzureId",
                value: new Guid("0ea53fdb-6cc9-407c-8e47-2d44da3ebeb4"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                column: "AzureId",
                value: new Guid("6d313f10-b14d-4fb3-90da-8bd1312a1644"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                column: "AzureId",
                value: new Guid("1ae2b213-293b-4cfb-9d4a-4c3340b9cdd6"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                column: "AzureId",
                value: new Guid("be40329d-189e-43af-898a-e21ab1efa7ee"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                column: "AzureId",
                value: new Guid("e164d5d0-d29f-4191-9059-6159d59fdf3d"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11,
                column: "AzureId",
                value: new Guid("55cf1d6a-1ead-4ce7-9c3c-88107f17542d"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12,
                column: "AzureId",
                value: new Guid("b8f2eef1-b98d-444d-9928-484d8afb04a7"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13,
                column: "AzureId",
                value: new Guid("08776428-a58d-431e-a308-b9886e66aff1"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14,
                column: "AzureId",
                value: new Guid("91757c82-2b8c-4ceb-a747-9d24078b87dd"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15,
                column: "AzureId",
                value: new Guid("c83402fb-107d-4f88-8d10-771307dd9a40"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 16,
                column: "AzureId",
                value: new Guid("cf9c9f24-a5d5-431b-9a51-a40633c5d6bf"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 17,
                column: "AzureId",
                value: new Guid("905516a7-84d2-42ec-8f75-483e8682d193"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 18,
                column: "AzureId",
                value: new Guid("936943ba-794a-4895-bafb-ecfbced67673"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 19,
                column: "AzureId",
                value: new Guid("6fd7fc9c-84da-4c65-ae4f-4442686da263"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 20,
                column: "AzureId",
                value: new Guid("800acd7b-0e72-4677-a40f-c8c246246e04"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 21,
                column: "AzureId",
                value: new Guid("9836386d-f4b4-4e5c-abb3-2f21054a6388"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 22,
                column: "AzureId",
                value: new Guid("e677f132-a058-42cc-a53b-1d97273fd36b"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 23,
                column: "AzureId",
                value: new Guid("087b0032-6286-4e70-9b0c-a402e3ccdca9"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 24,
                column: "AzureId",
                value: new Guid("b4a0aaee-ae4b-4352-bc92-84d43609e8df"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 25,
                column: "AzureId",
                value: new Guid("82d40cb9-1b27-424e-abc6-acdd101c3437"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 26,
                column: "AzureId",
                value: new Guid("e162b29a-35ec-4e78-86ed-dbbf2f6f8de5"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 27,
                column: "AzureId",
                value: new Guid("f9121e18-bbf6-4740-885a-e71c945e43e6"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 28,
                column: "AzureId",
                value: new Guid("5ae1461b-4c8d-4c41-ac70-595048fdd63e"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 29,
                column: "AzureId",
                value: new Guid("a3943ef3-6e75-4fcb-9e16-4b5e92b89855"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 30,
                column: "AzureId",
                value: new Guid("781a7c8c-1d03-43b5-ad7d-1052cbde5410"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 31,
                column: "AzureId",
                value: new Guid("9a97dc9e-dd3f-4812-b972-8569b6362bb3"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 32,
                column: "AzureId",
                value: new Guid("189ffe52-33cb-4bb3-ac50-67956968326a"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 33,
                column: "AzureId",
                value: new Guid("d8206dbb-9cff-4462-b1e8-a10ce3770b01"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 34,
                column: "AzureId",
                value: new Guid("c2741102-93b2-4958-902c-eca4feaa6f62"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 35,
                column: "AzureId",
                value: new Guid("8cbf65ba-6773-407e-a028-c04085e86b19"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 36,
                column: "AzureId",
                value: new Guid("00a2f8af-5250-4f34-8fec-dfdd24df2a6b"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 37,
                column: "AzureId",
                value: new Guid("2756e5c9-b8fe-4ba8-999f-1d7d42996d21"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 38,
                column: "AzureId",
                value: new Guid("70f59620-9f3b-49ca-a330-4394641a5914"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 39,
                column: "AzureId",
                value: new Guid("f1b6dac9-98a4-49bc-9829-444f3333969d"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 40,
                column: "AzureId",
                value: new Guid("6229e622-b8bf-4cb7-82a1-69f865693341"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 41,
                column: "AzureId",
                value: new Guid("1be1759d-9540-41e4-afa7-a6a12758d491"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 42,
                column: "AzureId",
                value: new Guid("3e6d38f4-cbd2-4b4b-af50-bf150f51a843"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 43,
                column: "AzureId",
                value: new Guid("ad638413-c0e2-4d43-9196-0a6e287f5df8"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 44,
                column: "AzureId",
                value: new Guid("2b2ef002-d1d0-4331-b20a-e768603ea7a1"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 45,
                column: "AzureId",
                value: new Guid("c7a6d50f-e58a-4c1b-bdaf-b4fe17c297f8"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 46,
                column: "AzureId",
                value: new Guid("16c82bfe-75ea-4837-9140-cf787e7cbedc"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 47,
                column: "AzureId",
                value: new Guid("f827d04b-de7f-4cca-9e22-d39ffeb543f4"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 48,
                column: "AzureId",
                value: new Guid("82142ca2-6730-46de-90c7-e9c145e4f4e7"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 49,
                column: "AzureId",
                value: new Guid("47116e29-fbae-484c-9ef7-8b8c2ac8342c"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 50,
                column: "AzureId",
                value: new Guid("381046c4-353a-4e88-8fcb-cd5d6ad8005d"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 51,
                column: "AzureId",
                value: new Guid("b28b3712-5299-4475-8f5c-83339070834f"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 52,
                column: "AzureId",
                value: new Guid("30ac28fb-d7a9-44c7-b7b3-34b463506336"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 53,
                column: "AzureId",
                value: new Guid("ff07a5fa-5cb9-4dc5-bfa2-1c038340501c"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 54,
                column: "AzureId",
                value: new Guid("d34497ec-df1d-4bc1-92b6-cf5467d32fd9"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 55,
                column: "AzureId",
                value: new Guid("b769c80e-3255-41bd-a06f-a5b139cf776c"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 56,
                column: "AzureId",
                value: new Guid("47317857-6b44-4138-a03a-68f82c7ced1f"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 57,
                column: "AzureId",
                value: new Guid("ca547e8d-7029-4c6d-8976-6feebc341c32"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 58,
                column: "AzureId",
                value: new Guid("9a9cbc30-cb31-4213-abcf-41e685d1ad2d"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 59,
                column: "AzureId",
                value: new Guid("a7042fb5-a04b-4339-b99c-07ca5de7080f"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 60,
                column: "AzureId",
                value: new Guid("e61bbe4c-9beb-4501-b489-7067164abb84"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 61,
                column: "AzureId",
                value: new Guid("a1d61f08-677f-42d5-8bbf-82da3fae3937"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 62,
                column: "AzureId",
                value: new Guid("e9a42d85-1cc7-444c-b2b1-611c8e210e88"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 63,
                column: "AzureId",
                value: new Guid("324a0250-cada-4690-96dc-a8e5979ee627"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 64,
                column: "AzureId",
                value: new Guid("987bb29e-c3a0-4e7f-b8a2-0ba8f80b8552"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 65,
                column: "AzureId",
                value: new Guid("e1adf400-1c3d-4550-b3d4-4372c7a1abdb"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 66,
                column: "AzureId",
                value: new Guid("a2a73299-e8c7-433d-988d-3932ca4cca5f"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 67,
                column: "AzureId",
                value: new Guid("9fed7402-4044-470b-8dfb-9bf6c83cef77"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 68,
                column: "AzureId",
                value: new Guid("f3a6ce21-7451-47c9-9702-e2ebd58c90da"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 69,
                column: "AzureId",
                value: new Guid("f53b8ee2-73b7-4b52-ae8e-5428ccc84edc"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 70,
                column: "AzureId",
                value: new Guid("c4050292-ea84-4e09-8546-8619ff45cd49"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 71,
                column: "AzureId",
                value: new Guid("5f004c6f-ccbc-4c9e-9b11-5e161b492641"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 72,
                column: "AzureId",
                value: new Guid("2650f96e-49d0-44b8-b78d-7f1cefa96045"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 73,
                column: "AzureId",
                value: new Guid("47fc7f73-7cd6-4c92-a3ef-26337ce29474"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 74,
                column: "AzureId",
                value: new Guid("1ba4a10b-f28d-4cd8-97ff-56627b4718de"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 75,
                column: "AzureId",
                value: new Guid("f909ebb6-b7f8-416d-b953-8a7961302d3b"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 76,
                column: "AzureId",
                value: new Guid("2bb1e7e2-6f93-4d36-867e-e609e85fd9d1"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 77,
                column: "AzureId",
                value: new Guid("6246bd24-c7c4-410b-bf49-62e89d4eedc0"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 78,
                column: "AzureId",
                value: new Guid("5c7c5760-d241-4169-afaa-b4d92b5be398"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 79,
                column: "AzureId",
                value: new Guid("73382fba-5d9b-4992-aa28-b1dc418a1386"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 80,
                column: "AzureId",
                value: new Guid("c90d3dce-c195-4067-b511-e5910dc674b8"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 81,
                column: "AzureId",
                value: new Guid("aea74360-9c9b-4e3a-a887-92f4b1cd275d"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 82,
                column: "AzureId",
                value: new Guid("777026d3-1de8-4d3a-9c84-2c2c1c9f5e0b"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 83,
                column: "AzureId",
                value: new Guid("cc380c3d-6362-4203-82d1-472aba4da588"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 84,
                column: "AzureId",
                value: new Guid("b61c6278-d99f-492f-a34a-d54ac5661cf4"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 85,
                column: "AzureId",
                value: new Guid("4eeaad10-aa30-446e-a32c-45644243d727"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 86,
                column: "AzureId",
                value: new Guid("34fb63e9-892e-4411-a8eb-f86542e31924"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 87,
                column: "AzureId",
                value: new Guid("7f21bdbb-fb5d-4785-8442-d8afd51e8b53"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 88,
                column: "AzureId",
                value: new Guid("83b8d1db-458c-4676-8bce-32356069694f"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 89,
                column: "AzureId",
                value: new Guid("994cc671-ca65-4890-b179-e20637906154"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 90,
                column: "AzureId",
                value: new Guid("9be21933-1ca8-4894-ab0d-630498ff4400"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 91,
                column: "AzureId",
                value: new Guid("a9021e7e-8dfe-4701-a66d-489ca16fb79a"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 92,
                column: "AzureId",
                value: new Guid("14c3733c-b7dd-4281-ac7c-f8973296fed1"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 93,
                column: "AzureId",
                value: new Guid("e171ae35-1178-45bb-bd4c-484379b07c1e"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 94,
                column: "AzureId",
                value: new Guid("dad3397c-2a02-4d63-a0a3-8d8d6ecb31f0"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 95,
                column: "AzureId",
                value: new Guid("e64648ad-35ef-4522-be8d-7421ca6a51c9"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 96,
                column: "AzureId",
                value: new Guid("99bd2041-4269-4ffb-9b2b-ce995358df73"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 97,
                column: "AzureId",
                value: new Guid("1618bf47-ce7a-416e-860b-29bf47eb8420"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 98,
                column: "AzureId",
                value: new Guid("4fd8c70f-bd67-4ad3-a9d5-02d9b46b4bed"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 99,
                column: "AzureId",
                value: new Guid("5015cde8-714e-4fcb-9587-328f049317b8"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 100,
                column: "AzureId",
                value: new Guid("09fb9bdc-9e90-494a-b64a-8cdfce73a18b"));

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 21, 30, 33, 563, DateTimeKind.Local).AddTicks(2610), new DateTime(2022, 1, 24, 19, 11, 13, 354, DateTimeKind.Local).AddTicks(1604), new Guid("ba54e44c-116d-4e30-ae8e-006ae36b99a0") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 9, 41, 976, DateTimeKind.Local).AddTicks(3360), new DateTime(2021, 7, 6, 18, 24, 14, 719, DateTimeKind.Local).AddTicks(2620), new Guid("955a0308-9ae3-4195-820b-c51d107eb58e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 34, 38, 381, DateTimeKind.Local).AddTicks(8308), new DateTime(2021, 10, 21, 14, 51, 55, 855, DateTimeKind.Local).AddTicks(5679), new Guid("08c63e18-2765-4001-a235-d418fece1a7d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 47, 15, 211, DateTimeKind.Local).AddTicks(3869), new DateTime(2022, 1, 25, 8, 25, 16, 229, DateTimeKind.Local).AddTicks(9956), new Guid("bcbf6ec9-d9f5-4a45-abe1-50048146b2c8") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 36, 20, 2, DateTimeKind.Local).AddTicks(8847), new DateTime(2022, 1, 6, 11, 51, 40, 845, DateTimeKind.Local).AddTicks(5629), new Guid("ea3869f8-27b7-47f8-8b69-b15e366ccccd") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 23, 1, 42, 716, DateTimeKind.Local).AddTicks(9360), new DateTime(2021, 5, 7, 18, 57, 1, 869, DateTimeKind.Local).AddTicks(201), new Guid("b0a16bc8-55ea-42c4-bc2a-1c94f619142f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 7, 18, 17, 759, DateTimeKind.Local).AddTicks(828), new DateTime(2021, 4, 1, 14, 20, 54, 223, DateTimeKind.Local).AddTicks(4126), new Guid("2975c11e-2d32-4fc9-8976-d5b2f3ff55be") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 54, 50, 500, DateTimeKind.Local).AddTicks(5443), new DateTime(2021, 8, 3, 2, 22, 41, 353, DateTimeKind.Local).AddTicks(2626), new Guid("9b20c647-a7cd-4f48-b236-1281be4f4742") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 7, 30, 56, 213, DateTimeKind.Local).AddTicks(8316), new DateTime(2021, 6, 7, 1, 35, 26, 116, DateTimeKind.Local).AddTicks(2020), new Guid("c13bae4e-4dab-4579-b1d0-034acc66accf") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 5, 43, 573, DateTimeKind.Local).AddTicks(1701), new DateTime(2021, 6, 2, 0, 1, 29, 833, DateTimeKind.Local).AddTicks(3819), new Guid("88cfa8e6-950a-4aef-86b4-80caa5234c2e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 4, 17, 25, 246, DateTimeKind.Local).AddTicks(7396), new DateTime(2022, 1, 6, 15, 9, 39, 208, DateTimeKind.Local).AddTicks(7448), new Guid("b29c9c92-7042-49c2-8c1c-cd388dbfc36e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 59, 33, 900, DateTimeKind.Local).AddTicks(7597), new DateTime(2021, 11, 16, 19, 40, 21, 905, DateTimeKind.Local).AddTicks(7262), new Guid("d737e3c6-5604-46f5-91d6-a755e109b1b7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 25, 49, 577, DateTimeKind.Local).AddTicks(8020), new DateTime(2021, 3, 7, 9, 58, 15, 694, DateTimeKind.Local).AddTicks(5648), new Guid("6fbe6ddf-78b8-4f7b-8349-2b128101e065") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 7, 17, 34, 485, DateTimeKind.Local).AddTicks(4433), new DateTime(2021, 8, 14, 15, 17, 10, 569, DateTimeKind.Local).AddTicks(8907), new Guid("df7c5d48-1255-4a7e-adf9-d7ed7e7e29d5") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 20, 50, 21, 431, DateTimeKind.Local).AddTicks(7821), new DateTime(2021, 9, 17, 20, 29, 38, 448, DateTimeKind.Local).AddTicks(5839), new Guid("721f174b-8212-4b20-a233-36d4881bbce5") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 1, 3, 2, 279, DateTimeKind.Local).AddTicks(3946), new DateTime(2021, 12, 14, 3, 3, 16, 42, DateTimeKind.Local).AddTicks(9668), new Guid("0d8b04f6-9593-4f34-a589-d291aa9d8132") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 11, 21, 14, 870, DateTimeKind.Local).AddTicks(2131), new DateTime(2021, 5, 13, 16, 15, 50, 76, DateTimeKind.Local).AddTicks(9462), new Guid("bd801747-0eb7-4928-bb69-462511935cb2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 5, 58, 4, 44, DateTimeKind.Local).AddTicks(1353), new DateTime(2021, 12, 25, 23, 5, 35, 449, DateTimeKind.Local).AddTicks(6962), new Guid("bfae6e4b-7ca2-48fe-a608-1d9a5151dcac") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 57, 1, 121, DateTimeKind.Local).AddTicks(9197), new DateTime(2021, 4, 29, 5, 45, 53, 827, DateTimeKind.Local).AddTicks(9012), new Guid("c4581f5b-c34f-445d-af9d-bbb4c5344a0f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 6, 47, 44, 491, DateTimeKind.Local).AddTicks(7379), new DateTime(2021, 12, 6, 2, 41, 14, 454, DateTimeKind.Local).AddTicks(7954), new Guid("915522a8-2b31-4d50-b67b-00f04c6c4f27") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 15, 1, 5, 139, DateTimeKind.Local).AddTicks(1663), new DateTime(2021, 11, 19, 16, 23, 22, 102, DateTimeKind.Local).AddTicks(5341), new Guid("9845ba4f-bdfd-49dd-be85-96a8fc4ae3f7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 6, 23, 39, 545, DateTimeKind.Local).AddTicks(209), new DateTime(2021, 6, 8, 11, 14, 21, 142, DateTimeKind.Local).AddTicks(2786), new Guid("0a7f1e26-1198-48e0-a380-bad829c49e10") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 13, 13, 54, DateTimeKind.Local).AddTicks(7954), new DateTime(2021, 6, 29, 11, 3, 16, 500, DateTimeKind.Local).AddTicks(684), new Guid("fc8fa735-c17e-4fda-a926-f8d6796fc2c0") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 2, 33, 34, 749, DateTimeKind.Local).AddTicks(2500), new DateTime(2021, 12, 12, 17, 52, 4, 710, DateTimeKind.Local).AddTicks(5877), new Guid("eadd31cc-0970-4bd9-bab2-99ac1b3202e1") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 16, 32, 861, DateTimeKind.Local).AddTicks(3722), new DateTime(2021, 9, 27, 12, 35, 53, 506, DateTimeKind.Local).AddTicks(4332), new Guid("534e4285-ce41-430e-bea4-0d73d07526bd") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 27, 2, 505, DateTimeKind.Local).AddTicks(753), new DateTime(2021, 11, 28, 17, 6, 29, 154, DateTimeKind.Local).AddTicks(115), new Guid("b9fc5fea-36cb-435d-b6bc-93a87366259d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 16, 57, 522, DateTimeKind.Local).AddTicks(2609), new DateTime(2021, 2, 24, 13, 28, 52, 328, DateTimeKind.Local).AddTicks(2506), new Guid("2e2bd9b0-4c12-4e66-bc13-0a1ddd88f14a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 19, 34, 13, 500, DateTimeKind.Local).AddTicks(3307), new DateTime(2021, 2, 27, 3, 6, 59, 963, DateTimeKind.Local).AddTicks(906), new Guid("f196f8f3-ac07-4387-846b-8a327b5a45f5") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 2, 52, 18, 794, DateTimeKind.Local).AddTicks(8414), new DateTime(2021, 2, 18, 21, 22, 32, 260, DateTimeKind.Local).AddTicks(3952), new Guid("5c92cb33-4bd6-403d-9254-4990a94d7ab0") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 24, 34, 923, DateTimeKind.Local).AddTicks(1866), new DateTime(2021, 5, 11, 1, 33, 54, 438, DateTimeKind.Local).AddTicks(612), new Guid("f3db0b70-ac40-4898-92ce-acbcf3a88469") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 22, 24, 30, 136, DateTimeKind.Local).AddTicks(2882), new DateTime(2022, 1, 30, 7, 49, 44, 677, DateTimeKind.Local).AddTicks(5972), new Guid("b15848c6-ff92-45eb-98bd-3b7583ca7e75") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 52, 11, 552, DateTimeKind.Local).AddTicks(2285), new DateTime(2021, 9, 27, 9, 10, 39, 498, DateTimeKind.Local).AddTicks(7669), new Guid("d4d0e9b3-0088-44ab-bfde-dab403cd5a7a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 23, 36, 50, 189, DateTimeKind.Local).AddTicks(592), new DateTime(2022, 2, 2, 5, 11, 4, 426, DateTimeKind.Local).AddTicks(7045), new Guid("5b068eeb-2dd5-4e11-af1b-94cf4309ece4") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 22, 57, 37, 329, DateTimeKind.Local).AddTicks(8083), new DateTime(2021, 11, 22, 12, 17, 50, 393, DateTimeKind.Local).AddTicks(6067), new Guid("6ea7892a-8e29-46cc-bded-a22a26b956ba") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 46, 31, 807, DateTimeKind.Local).AddTicks(1649), new DateTime(2021, 10, 17, 21, 4, 51, 591, DateTimeKind.Local).AddTicks(3617), new Guid("8118d7da-a0d5-43a5-a711-332fcf4d7a3d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 1, 19, 40, 215, DateTimeKind.Local).AddTicks(9984), new DateTime(2021, 4, 12, 14, 10, 19, 904, DateTimeKind.Local).AddTicks(4641), new Guid("c132174e-3c06-49ac-8b91-b68b1a260559") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 19, 5, 14, 962, DateTimeKind.Local).AddTicks(4951), new DateTime(2021, 9, 17, 18, 25, 42, 304, DateTimeKind.Local).AddTicks(3937), new Guid("2434d391-036f-4b1e-bf36-4783648c3000") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 11, 18, 54, 82, DateTimeKind.Local).AddTicks(7939), new DateTime(2022, 1, 16, 10, 48, 32, 754, DateTimeKind.Local).AddTicks(4725), new Guid("66c841f4-528e-4818-91b3-40cfde76030c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 11, 27, 851, DateTimeKind.Local).AddTicks(5634), new DateTime(2021, 4, 13, 8, 53, 4, 177, DateTimeKind.Local).AddTicks(7880), new Guid("fdf1f042-544d-4598-a5b7-43278281da94") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 59, 54, 837, DateTimeKind.Local).AddTicks(714), new DateTime(2021, 2, 14, 10, 26, 25, 40, DateTimeKind.Local).AddTicks(5885), new Guid("e80c5929-e254-49d7-bf73-1f8f5866692d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 40, 53, 976, DateTimeKind.Local).AddTicks(1715), new DateTime(2021, 12, 11, 16, 27, 49, 663, DateTimeKind.Local).AddTicks(1545), new Guid("99ee5cca-21c7-4996-baa0-e390c0f75d4e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 10, 39, 25, 29, DateTimeKind.Local).AddTicks(1549), new DateTime(2021, 6, 22, 16, 3, 14, 540, DateTimeKind.Local).AddTicks(8785), new Guid("6b271a5f-e33f-45d1-b887-38d355a62494") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 6, 5, 4, 42, DateTimeKind.Local).AddTicks(5390), new DateTime(2021, 4, 22, 13, 41, 24, 724, DateTimeKind.Local).AddTicks(3342), new Guid("bec7f93e-a2fb-4644-93d6-56dbc1ef6dca") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 11, 18, 50, 82, DateTimeKind.Local).AddTicks(6524), new DateTime(2021, 3, 6, 14, 32, 26, 45, DateTimeKind.Local).AddTicks(9668), new Guid("4ac4e28a-651c-454a-8fea-9babfc629ee3") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 37, 34, 603, DateTimeKind.Local).AddTicks(1970), new DateTime(2021, 8, 5, 21, 39, 7, 528, DateTimeKind.Local).AddTicks(437), new Guid("c6b338a0-ed98-490f-a62e-bc64a0d39e89") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 1, 59, 14, 849, DateTimeKind.Local).AddTicks(6061), new DateTime(2021, 10, 17, 22, 1, 25, 158, DateTimeKind.Local).AddTicks(3830), new Guid("4030c574-873b-43be-9816-588ae03b4081") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 19, 0, 56, 850, DateTimeKind.Local).AddTicks(5753), new DateTime(2021, 6, 26, 19, 27, 47, 957, DateTimeKind.Local).AddTicks(1079), new Guid("e2f8e8a3-5b89-4060-96d3-0b3e9afceadf") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 58, 4, 500, DateTimeKind.Local).AddTicks(1226), new DateTime(2021, 4, 17, 10, 48, 20, 913, DateTimeKind.Local).AddTicks(4715), new Guid("92971572-6a44-498e-bb9a-89bf8588a154") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 5, 45, 4, 450, DateTimeKind.Local).AddTicks(3577), new DateTime(2021, 10, 27, 2, 18, 5, 762, DateTimeKind.Local).AddTicks(507), new Guid("b482de70-fa9a-4aab-9287-6a7d46cafe06") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 45, 56, 343, DateTimeKind.Local).AddTicks(122), new DateTime(2021, 5, 27, 20, 16, 40, 281, DateTimeKind.Local).AddTicks(3732), new Guid("06fb8937-fbf0-457e-9890-ae83a9f38145") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 4, 16, 628, DateTimeKind.Local).AddTicks(7577), new DateTime(2021, 8, 14, 16, 54, 24, 777, DateTimeKind.Local).AddTicks(4340), new Guid("ae97779b-c304-4f3f-9a86-3f22b82c5564") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 59, 7, 245, DateTimeKind.Local).AddTicks(3646), new DateTime(2021, 6, 13, 4, 19, 52, 528, DateTimeKind.Local).AddTicks(2845), new Guid("2c0684c4-f350-44aa-89c8-1cb379b9c5d7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 18, 12, 821, DateTimeKind.Local).AddTicks(7143), new DateTime(2021, 10, 10, 4, 13, 49, 790, DateTimeKind.Local).AddTicks(6309), new Guid("0d9f24c9-22a7-47fe-85af-52688acea059") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 22, 58, 27, 706, DateTimeKind.Local).AddTicks(2212), new DateTime(2021, 8, 25, 16, 12, 4, 164, DateTimeKind.Local).AddTicks(9621), new Guid("166d7007-8b92-4d9f-87bc-22c53b3e2938") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 6, 14, 9, 991, DateTimeKind.Local).AddTicks(4597), new DateTime(2021, 5, 5, 9, 9, 53, 261, DateTimeKind.Local).AddTicks(4972), new Guid("97d84a4e-a400-4f74-aeca-bef85e387b17") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 37, 57, 327, DateTimeKind.Local).AddTicks(1819), new DateTime(2021, 12, 12, 14, 32, 9, 362, DateTimeKind.Local).AddTicks(1520), new Guid("a5f4f788-3374-4ae5-99fd-63d9ec5e5975") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 5, 5, 42, 584, DateTimeKind.Local).AddTicks(2390), new DateTime(2021, 10, 3, 19, 52, 4, 908, DateTimeKind.Local).AddTicks(2342), new Guid("8a405bed-3cd4-41ca-b7e6-5b2ceabbf93f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 6, 37, 47, 280, DateTimeKind.Local).AddTicks(5194), new DateTime(2021, 11, 14, 15, 59, 54, 637, DateTimeKind.Local).AddTicks(8114), new Guid("4024af0c-0d8d-4aba-8844-40e2bfbdd181") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 5, 38, 29, 706, DateTimeKind.Local).AddTicks(1167), new DateTime(2021, 11, 24, 20, 3, 31, 293, DateTimeKind.Local).AddTicks(7861), new Guid("b1cf8413-7960-41b5-a40f-de3523b5a4e8") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 12, 8, 59, DateTimeKind.Local).AddTicks(8645), new DateTime(2021, 9, 1, 21, 27, 39, 231, DateTimeKind.Local).AddTicks(3525), new Guid("06d75ef5-c563-4304-8aa4-598c7b6aeac0") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 21, 48, 19, 75, DateTimeKind.Local).AddTicks(7163), new DateTime(2021, 3, 4, 4, 42, 44, 234, DateTimeKind.Local).AddTicks(7646), new Guid("a01f5d9f-5d1a-47a3-8d61-6e086de3aac9") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 11, 47, 21, 418, DateTimeKind.Local).AddTicks(6353), new DateTime(2021, 11, 25, 1, 2, 44, 27, DateTimeKind.Local).AddTicks(9246), new Guid("b87b8579-1c87-4435-a28d-4a66faa4b6c8") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 4, 58, 53, 47, DateTimeKind.Local).AddTicks(64), new DateTime(2021, 3, 23, 0, 31, 24, 185, DateTimeKind.Local).AddTicks(6300), new Guid("af7ee69e-edf9-40c1-8012-3d9dc9a35d30") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 1, 45, 663, DateTimeKind.Local).AddTicks(3468), new DateTime(2021, 12, 3, 5, 47, 49, 406, DateTimeKind.Local).AddTicks(5643), new Guid("7a74dca6-e41d-434f-86e1-d2d04f789ce3") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 47, 59, 997, DateTimeKind.Local).AddTicks(9264), new DateTime(2021, 12, 18, 13, 24, 50, 110, DateTimeKind.Local).AddTicks(7747), new Guid("f117420b-7dd9-4081-98fd-da192c68f3df") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 30, 2, 994, DateTimeKind.Local).AddTicks(8124), new DateTime(2021, 9, 18, 20, 35, 54, 652, DateTimeKind.Local).AddTicks(5397), new Guid("6ed5217e-768f-4771-822f-fe43d76eb13c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 22, 48, 345, DateTimeKind.Local).AddTicks(7203), new DateTime(2021, 4, 27, 10, 6, 34, 460, DateTimeKind.Local).AddTicks(1396), new Guid("50e2cb1b-6022-4109-83d0-312af42ff2e0") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 22, 39, 29, 208, DateTimeKind.Local).AddTicks(8368), new DateTime(2021, 11, 2, 8, 2, 18, 823, DateTimeKind.Local).AddTicks(7140), new Guid("5ccb6741-d83f-4f46-bd27-39ba25c1f295") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 11, 40, 17, 475, DateTimeKind.Local).AddTicks(8667), new DateTime(2021, 11, 27, 9, 59, 6, 814, DateTimeKind.Local).AddTicks(8476), new Guid("7bcf0843-eb18-4034-9f60-e95c2618b933") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 30, 0, 422, DateTimeKind.Local).AddTicks(1275), new DateTime(2021, 7, 17, 19, 26, 50, 769, DateTimeKind.Local).AddTicks(1221), new Guid("0a916cb5-9ab2-4b2c-8681-8f00c3870e86") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 0, 5, 705, DateTimeKind.Local).AddTicks(1925), new DateTime(2021, 11, 17, 23, 43, 59, 289, DateTimeKind.Local).AddTicks(9009), new Guid("4ef482ef-46ea-460b-b849-1c5c9ff4bced") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 4, 56, 8, 667, DateTimeKind.Local).AddTicks(2894), new DateTime(2021, 7, 2, 22, 21, 45, 143, DateTimeKind.Local).AddTicks(4891), new Guid("2bac7f97-e3b3-4bdf-a87c-d20ee8591791") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 23, 48, 38, 574, DateTimeKind.Local).AddTicks(911), new DateTime(2021, 10, 1, 0, 49, 58, 220, DateTimeKind.Local).AddTicks(9628), new Guid("d70fb560-cc94-43c1-86f7-b6fed03153c7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 23, 15, 12, 435, DateTimeKind.Local).AddTicks(8104), new DateTime(2021, 4, 21, 16, 33, 16, 485, DateTimeKind.Local).AddTicks(3349), new Guid("7895393e-9da2-4f52-8557-b09a88869677") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 4, 23, 0, 977, DateTimeKind.Local).AddTicks(6773), new DateTime(2021, 11, 4, 4, 4, 28, 838, DateTimeKind.Local).AddTicks(8700), new Guid("3733b9f3-af5b-4d78-b536-d2f4bb514bed") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 10, 13, 29, 468, DateTimeKind.Local).AddTicks(7649), new DateTime(2021, 12, 29, 10, 7, 33, 482, DateTimeKind.Local).AddTicks(5655), new Guid("2fe2c0d9-a947-46b3-b188-2a137848a693") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 32, 21, 997, DateTimeKind.Local).AddTicks(8483), new DateTime(2021, 2, 13, 22, 6, 49, 675, DateTimeKind.Local).AddTicks(7396), new Guid("e91a5f8c-b996-498f-900f-53ad0cdee628") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 2, 52, 40, 584, DateTimeKind.Local).AddTicks(6318), new DateTime(2021, 5, 19, 0, 52, 23, 818, DateTimeKind.Local).AddTicks(5040), new Guid("34edcdcc-7a66-49e7-b7a8-c72ae04074fe") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 15, 14, 7, 994, DateTimeKind.Local).AddTicks(8383), new DateTime(2022, 1, 5, 10, 57, 38, 41, DateTimeKind.Local).AddTicks(117), new Guid("f20da4e7-6940-4006-ba15-c9bd0f1ec69f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 2, 27, 20, 842, DateTimeKind.Local).AddTicks(2066), new DateTime(2021, 8, 28, 7, 7, 30, 166, DateTimeKind.Local).AddTicks(1303), new Guid("be2eb458-73ad-4277-abd4-d2200105ed0e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 18, 10, 626, DateTimeKind.Local).AddTicks(5437), new DateTime(2021, 8, 29, 2, 26, 5, 56, DateTimeKind.Local).AddTicks(3756), new Guid("f503de4b-ff41-4a14-818f-78620d17dccd") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 35, 3, 284, DateTimeKind.Local).AddTicks(4838), new DateTime(2021, 3, 27, 19, 16, 34, 544, DateTimeKind.Local).AddTicks(8125), new Guid("c6350526-9b82-4ec1-aabe-4e5aaecf4e0c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 7, 16, 29, 194, DateTimeKind.Local).AddTicks(3998), new DateTime(2021, 11, 5, 2, 53, 16, 817, DateTimeKind.Local).AddTicks(6914), new Guid("169846d4-986a-4491-b65a-c9ba3bdf7772") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 21, 38, 26, 643, DateTimeKind.Local).AddTicks(1241), new DateTime(2021, 3, 21, 6, 58, 16, 253, DateTimeKind.Local).AddTicks(8678), new Guid("16d52260-fc67-48c1-96a0-4e1905a7fe04") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 7, 37, 30, 810, DateTimeKind.Local).AddTicks(3120), new DateTime(2021, 10, 24, 2, 5, 51, 83, DateTimeKind.Local).AddTicks(1182), new Guid("2d7c14bf-095c-4c19-aede-32391a535184") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 17, 22, 576, DateTimeKind.Local).AddTicks(6953), new DateTime(2021, 3, 3, 13, 39, 21, 175, DateTimeKind.Local).AddTicks(6669), new Guid("17d40f7b-6676-4ddb-810a-d5d71679e516") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 19, 4, 2, 979, DateTimeKind.Local).AddTicks(4715), new DateTime(2022, 1, 20, 1, 8, 55, 888, DateTimeKind.Local).AddTicks(3345), new Guid("e59e007f-5bbd-4395-b081-b70739bba314") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 42, 7, 505, DateTimeKind.Local).AddTicks(1002), new DateTime(2022, 1, 13, 15, 9, 44, 619, DateTimeKind.Local).AddTicks(5010), new Guid("672e6a2e-c2e5-4aba-b8a8-30ea814c11f2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 23, 45, 23, 75, DateTimeKind.Local).AddTicks(4871), new DateTime(2021, 12, 27, 23, 35, 3, 455, DateTimeKind.Local).AddTicks(2720), new Guid("05d1fcc2-6202-4273-b30a-251bfb84d821") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 5, 43, 50, 425, DateTimeKind.Local).AddTicks(499), new DateTime(2021, 3, 4, 13, 50, 14, 518, DateTimeKind.Local).AddTicks(7107), new Guid("466cbacf-8c9c-40db-8f7a-594885ac3a79") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 32, 54, 977, DateTimeKind.Local).AddTicks(1653), new DateTime(2022, 1, 13, 6, 10, 44, 782, DateTimeKind.Local).AddTicks(4069), new Guid("6aef7461-e8db-4484-85d2-01675a0f5584") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 1, 20, 17, 959, DateTimeKind.Local).AddTicks(4562), new DateTime(2021, 12, 19, 8, 21, 47, 402, DateTimeKind.Local).AddTicks(8258), new Guid("e8a73d99-5f0f-46fc-b432-d99132c05912") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 15, 12, 46, 869, DateTimeKind.Local).AddTicks(3348), new DateTime(2021, 2, 5, 11, 40, 39, 815, DateTimeKind.Local).AddTicks(1274), new Guid("1040d45d-defe-48b9-a83a-446f1cb1c013") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 23, 10, 23, 562, DateTimeKind.Local).AddTicks(1862), new DateTime(2021, 10, 1, 12, 44, 13, 179, DateTimeKind.Local).AddTicks(3109), new Guid("70170fe6-2f84-4a44-8a29-e0d7dfde7e89") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 21, 26, 49, 530, DateTimeKind.Local).AddTicks(7253), new DateTime(2021, 7, 24, 2, 48, 10, 55, DateTimeKind.Local).AddTicks(7685), new Guid("d006e473-2ef4-40d1-9522-c32c04b20631") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 16, 19, 567, DateTimeKind.Local).AddTicks(2342), new DateTime(2021, 3, 6, 11, 5, 16, 609, DateTimeKind.Local).AddTicks(8498), new Guid("e0fa4381-a286-4584-b62c-4287df168e42") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 11, 43, 39, 185, DateTimeKind.Local).AddTicks(1072), new DateTime(2021, 10, 4, 14, 57, 2, 303, DateTimeKind.Local).AddTicks(1473), new Guid("e3f5c07a-58ee-4e1b-a471-98a106d75d30") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 56, 21, 773, DateTimeKind.Local).AddTicks(4979), new DateTime(2022, 1, 1, 2, 53, 5, 485, DateTimeKind.Local).AddTicks(1364), new Guid("48017c80-815d-4c90-af9e-18393d01f82a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 6, 57, 24, 203, DateTimeKind.Local).AddTicks(6425), new DateTime(2021, 4, 11, 7, 21, 49, 100, DateTimeKind.Local).AddTicks(6281), new Guid("6e44b575-be7c-4edf-a084-569e16c7fa01") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 21, 17, 52, 8, DateTimeKind.Local).AddTicks(8893), new DateTime(2021, 3, 31, 5, 33, 35, 884, DateTimeKind.Local).AddTicks(5885), new Guid("70ab65ad-c191-41e8-9d91-692013306840") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 22, 33, 13, 50, DateTimeKind.Local).AddTicks(7989), new DateTime(2021, 10, 5, 7, 57, 45, 139, DateTimeKind.Local).AddTicks(2301), new Guid("f535be93-b52c-4a6e-8c24-4e8f3e6524ce") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 19, 40, 51, 658, DateTimeKind.Local).AddTicks(5347), new DateTime(2021, 8, 10, 11, 21, 40, 379, DateTimeKind.Local).AddTicks(7408), new Guid("628c16be-83c5-44fe-a08a-535139979981") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 31, 46, 304, DateTimeKind.Local).AddTicks(3894), new DateTime(2021, 7, 4, 13, 3, 36, 488, DateTimeKind.Local).AddTicks(6199), new Guid("02c3030a-a7e2-42f0-a0f9-17cde3917eb1") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 10, 47, 52, 429, DateTimeKind.Local).AddTicks(429), new DateTime(2021, 8, 19, 8, 15, 26, 890, DateTimeKind.Local).AddTicks(6018), new Guid("9d08495a-e449-40c8-8173-1406b45bf2d2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 28, 21, 237, DateTimeKind.Local).AddTicks(7651), new DateTime(2021, 7, 27, 19, 58, 3, 748, DateTimeKind.Local).AddTicks(8214), new Guid("f0fbef95-8773-45ef-bfd0-c0b30a6733c6") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 5, 38, 14, 948, DateTimeKind.Local).AddTicks(7203), new DateTime(2021, 12, 1, 10, 48, 3, 789, DateTimeKind.Local).AddTicks(4038), new Guid("7a24369a-7327-45ca-85ec-edd952d8da37") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 37, 35, 8, DateTimeKind.Local).AddTicks(9665), new DateTime(2021, 10, 6, 15, 32, 2, 861, DateTimeKind.Local).AddTicks(9960), new Guid("91b3920a-c517-4662-9bb6-8813d2a8bb65") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 49, 19, 381, DateTimeKind.Local).AddTicks(4998), new DateTime(2021, 3, 28, 4, 2, 26, 294, DateTimeKind.Local).AddTicks(3314), new Guid("bd7da61b-f544-4a32-a320-a179eb3fe1e2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 26, 39, 595, DateTimeKind.Local).AddTicks(8094), new DateTime(2021, 10, 31, 9, 41, 31, 471, DateTimeKind.Local).AddTicks(8523), new Guid("f10c7e64-0793-4dee-aff3-14b98ba4540c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 22, 36, 378, DateTimeKind.Local).AddTicks(1143), new DateTime(2021, 7, 25, 10, 17, 7, 263, DateTimeKind.Local).AddTicks(7208), new Guid("673ecb78-917b-4d73-a939-1124e21c2e31") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 14, 20, 583, DateTimeKind.Local).AddTicks(6268), new DateTime(2021, 12, 25, 5, 3, 16, 880, DateTimeKind.Local).AddTicks(3492), new Guid("b684c342-ebe5-4277-8d2e-eed4356345e9") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 21, 11, 7, 557, DateTimeKind.Local).AddTicks(8291), new DateTime(2021, 4, 1, 13, 17, 2, 566, DateTimeKind.Local).AddTicks(5799), new Guid("91ecd57d-c18a-46f0-a5da-c84a36937030") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 13, 56, 166, DateTimeKind.Local).AddTicks(5851), new DateTime(2021, 5, 13, 19, 51, 1, 349, DateTimeKind.Local).AddTicks(2571), new Guid("1e37afd3-8939-48f1-8e29-fa7fcd9d5a70") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 5, 46, 12, 708, DateTimeKind.Local).AddTicks(7287), new DateTime(2021, 10, 17, 2, 32, 28, 924, DateTimeKind.Local).AddTicks(8199), new Guid("394bd897-d8b0-4dda-9ceb-c92d85eced4f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 40, 21, 870, DateTimeKind.Local).AddTicks(2607), new DateTime(2021, 7, 1, 22, 27, 24, 93, DateTimeKind.Local).AddTicks(8105), new Guid("1c10256e-d2e3-42d5-b258-5bd3fecb059e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 22, 30, 23, 819, DateTimeKind.Local).AddTicks(8143), new DateTime(2021, 5, 27, 3, 32, 33, 429, DateTimeKind.Local).AddTicks(6753), new Guid("a8250a6a-e672-4959-a0c1-862bcb2b8de5") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 2, 12, 264, DateTimeKind.Local).AddTicks(6146), new DateTime(2021, 12, 17, 5, 16, 19, 372, DateTimeKind.Local).AddTicks(6193), new Guid("dd065f92-53bd-4129-8e7e-b113e43a84ab") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 40, 22, 200, DateTimeKind.Local).AddTicks(5105), new DateTime(2021, 9, 23, 14, 30, 53, 43, DateTimeKind.Local).AddTicks(589), new Guid("80484a4b-2d11-4630-8e06-3838a2132cc7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 4, 38, 31, 127, DateTimeKind.Local).AddTicks(356), new DateTime(2021, 4, 16, 15, 52, 56, 229, DateTimeKind.Local).AddTicks(5582), new Guid("4c1db289-dcdf-4003-997d-2903cb38ea8e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 58, 55, 551, DateTimeKind.Local).AddTicks(5154), new DateTime(2021, 2, 11, 8, 14, 35, 920, DateTimeKind.Local).AddTicks(9335), new Guid("3f9e561d-2999-4215-b142-74a4f25dfbd7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 45, 28, 535, DateTimeKind.Local).AddTicks(1045), new DateTime(2021, 10, 3, 0, 43, 11, 734, DateTimeKind.Local).AddTicks(3387), new Guid("dcdd33b8-4a3d-4fef-ab96-a661e2ed8381") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 19, 26, 15, 593, DateTimeKind.Local).AddTicks(6221), new DateTime(2021, 10, 25, 3, 10, 12, 461, DateTimeKind.Local).AddTicks(1950), new Guid("95716b5e-0d41-4a69-81d9-fb7d4c42666e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 19, 12, 38, 926, DateTimeKind.Local).AddTicks(5688), new DateTime(2021, 5, 28, 23, 38, 24, 514, DateTimeKind.Local).AddTicks(1168), new Guid("006e7174-0355-49ae-802e-7b57eb262c33") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 7, 8, 17, 109, DateTimeKind.Local).AddTicks(1162), new DateTime(2021, 9, 6, 23, 21, 26, 59, DateTimeKind.Local).AddTicks(6707), new Guid("332731a1-28b4-4e0b-9a09-743988a4c003") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 38, 24, 345, DateTimeKind.Local).AddTicks(2476), new DateTime(2021, 9, 26, 20, 33, 47, 771, DateTimeKind.Local).AddTicks(4033), new Guid("00472cd0-5056-4abf-8c6a-2c39db939e04") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 22, 56, 18, 417, DateTimeKind.Local).AddTicks(8898), new DateTime(2021, 7, 30, 16, 3, 0, 752, DateTimeKind.Local).AddTicks(7049), new Guid("7173af95-46a9-4793-9285-3cd2b13decc5") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 22, 32, 48, 505, DateTimeKind.Local).AddTicks(7560), new DateTime(2021, 10, 28, 5, 57, 17, 498, DateTimeKind.Local).AddTicks(3513), new Guid("aea79eb0-4cef-4f3b-95d0-73189845bf6b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 2, 11, 39, 191, DateTimeKind.Local).AddTicks(8078), new DateTime(2021, 2, 15, 18, 5, 45, 677, DateTimeKind.Local).AddTicks(628), new Guid("25552c7e-14df-41ae-85f2-ea64c71e4234") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 6, 19, 45, 668, DateTimeKind.Local).AddTicks(8540), new DateTime(2022, 1, 17, 12, 7, 51, 537, DateTimeKind.Local).AddTicks(3127), new Guid("d09c7728-f905-487e-a00a-f0e6f31a938a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 1, 15, 39, 747, DateTimeKind.Local).AddTicks(5348), new DateTime(2021, 6, 5, 12, 44, 58, 445, DateTimeKind.Local).AddTicks(2108), new Guid("c5ec43c5-855c-4492-b2d5-ca8ae0f79405") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 20, 30, 33, 298, DateTimeKind.Local).AddTicks(4876), new DateTime(2021, 11, 17, 19, 18, 44, 959, DateTimeKind.Local).AddTicks(1515), new Guid("46518459-9c00-4343-b492-bcd963d490db") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 35, 42, 440, DateTimeKind.Local).AddTicks(5761), new DateTime(2021, 3, 26, 10, 39, 18, 923, DateTimeKind.Local).AddTicks(364), new Guid("663195bb-00a0-4bfa-b723-e3a4cbc398c4") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 21, 6, 35, 503, DateTimeKind.Local).AddTicks(6678), new DateTime(2021, 11, 14, 20, 29, 47, 873, DateTimeKind.Local).AddTicks(8396), new Guid("4774e7dd-f6ba-4506-bade-d9b41642502b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 7, 1, 26, 219, DateTimeKind.Local).AddTicks(6476), new DateTime(2021, 4, 24, 8, 47, 0, 911, DateTimeKind.Local).AddTicks(7051), new Guid("574914bd-c906-481c-8e78-05d8fc032399") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 10, 6, 57, 735, DateTimeKind.Local).AddTicks(5049), new DateTime(2021, 12, 23, 6, 0, 18, 580, DateTimeKind.Local).AddTicks(2463), new Guid("fcda5406-88e7-4762-88cc-26c42fa067e9") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 21, 39, 41, 707, DateTimeKind.Local).AddTicks(6320), new DateTime(2021, 6, 4, 17, 10, 32, 285, DateTimeKind.Local).AddTicks(5859), new Guid("84bf8ccc-36e6-4de5-9fc2-83a58b66646c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 11, 16, 5, 787, DateTimeKind.Local).AddTicks(2978), new DateTime(2021, 4, 26, 6, 36, 33, 512, DateTimeKind.Local).AddTicks(4238), new Guid("18d7ce45-ee3b-4d92-9f7d-78e747bc06ff") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 35, 17, 787, DateTimeKind.Local).AddTicks(4698), new DateTime(2021, 7, 22, 17, 4, 1, 569, DateTimeKind.Local).AddTicks(685), new Guid("38155d26-38b8-4e3b-add4-9e3bed6b6875") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 59, 58, 285, DateTimeKind.Local).AddTicks(9131), new DateTime(2021, 7, 16, 13, 39, 26, 226, DateTimeKind.Local).AddTicks(2207), new Guid("2e5f98da-3c55-4ea9-b224-2dd8368c881f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 21, 38, 543, DateTimeKind.Local).AddTicks(8902), new DateTime(2021, 8, 27, 20, 0, 47, 786, DateTimeKind.Local).AddTicks(7171), new Guid("bc7bbcb6-5237-4a69-ba4f-aa3e26166f64") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 15, 31, 752, DateTimeKind.Local), new DateTime(2021, 11, 24, 3, 40, 23, 295, DateTimeKind.Local).AddTicks(3072), new Guid("db12449c-0e0c-44f1-a420-01401aa9658e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 11, 36, 0, 547, DateTimeKind.Local).AddTicks(991), new DateTime(2021, 8, 2, 23, 9, 29, 99, DateTimeKind.Local).AddTicks(4249), new Guid("cc75ecc2-74f2-467e-9b1b-14121cab42c2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 39, 8, 581, DateTimeKind.Local).AddTicks(4216), new DateTime(2021, 7, 20, 18, 25, 35, 123, DateTimeKind.Local).AddTicks(4175), new Guid("2ab161f7-a4d3-461f-8378-fd6f96983c27") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 14, 2, 719, DateTimeKind.Local).AddTicks(3937), new DateTime(2021, 6, 17, 13, 34, 54, 749, DateTimeKind.Local).AddTicks(4915), new Guid("393cb6ae-fc81-4fa1-a989-1ba1f6f451f0") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 25, 59, 785, DateTimeKind.Local).AddTicks(8574), new DateTime(2021, 10, 28, 13, 59, 38, 357, DateTimeKind.Local).AddTicks(3413), new Guid("f4cf07ba-3339-4052-b31a-70dfa18735ad") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 20, 21, 32, 920, DateTimeKind.Local).AddTicks(1722), new DateTime(2021, 7, 14, 20, 47, 12, 566, DateTimeKind.Local).AddTicks(3792), new Guid("e3d17cb6-f9df-40f5-bc75-8b0470755647") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 34, 21, 141, DateTimeKind.Local).AddTicks(8335), new DateTime(2021, 4, 23, 5, 47, 19, 365, DateTimeKind.Local).AddTicks(6915), new Guid("0fb543f0-ded4-45c3-8632-2f50d44b51a4") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 21, 16, 885, DateTimeKind.Local).AddTicks(9837), new DateTime(2021, 3, 24, 8, 58, 47, 430, DateTimeKind.Local).AddTicks(4943), new Guid("1be8ca73-eaa1-42d5-b41a-c0d477db79d8") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 7, 37, 30, 833, DateTimeKind.Local).AddTicks(4959), new DateTime(2021, 5, 23, 2, 14, 13, 388, DateTimeKind.Local).AddTicks(7107), new Guid("8482ba22-5c8a-4aa6-8f1c-ca735b9adb24") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 32, 27, 60, DateTimeKind.Local).AddTicks(2045), new DateTime(2021, 5, 20, 18, 25, 27, 639, DateTimeKind.Local).AddTicks(7585), new Guid("ef706935-1f18-45ac-b850-2ec348bc8d46") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 16, 55, 822, DateTimeKind.Local).AddTicks(103), new DateTime(2021, 2, 5, 3, 21, 8, 191, DateTimeKind.Local).AddTicks(208), new Guid("f5488df9-8812-4639-a110-cb11ea7d004f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 22, 45, 390, DateTimeKind.Local).AddTicks(8417), new DateTime(2021, 4, 5, 21, 39, 26, 838, DateTimeKind.Local).AddTicks(817), new Guid("14dfcdb4-985e-4a73-b128-2091190d6f4e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 3, 17, 228, DateTimeKind.Local).AddTicks(5720), new DateTime(2021, 4, 13, 18, 5, 0, 291, DateTimeKind.Local).AddTicks(2240), new Guid("5c6cf9bb-fa6d-43aa-88be-4c1d338b4fb5") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 10, 22, 19, 521, DateTimeKind.Local).AddTicks(8121), new DateTime(2021, 4, 20, 22, 0, 23, 814, DateTimeKind.Local).AddTicks(7064), new Guid("47e2be0f-4c18-4c8b-9f15-12249948b598") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 1, 45, 49, 536, DateTimeKind.Local).AddTicks(437), new DateTime(2021, 8, 9, 10, 23, 22, 349, DateTimeKind.Local).AddTicks(6026), new Guid("8a8fb9f5-e8e7-4e93-878c-4ea62950fb6c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 20, 20, 48, 407, DateTimeKind.Local).AddTicks(582), new DateTime(2021, 2, 17, 14, 5, 49, 360, DateTimeKind.Local).AddTicks(5070), new Guid("54949709-4101-4b71-982a-c838ac811f77") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 1, 19, 38, 421, DateTimeKind.Local).AddTicks(7113), new DateTime(2021, 8, 12, 12, 23, 17, 539, DateTimeKind.Local).AddTicks(2039), new Guid("eccb43b3-9022-4df4-b0e6-2f077421daf6") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 20, 5, 159, DateTimeKind.Local).AddTicks(3045), new DateTime(2021, 3, 24, 10, 9, 58, 136, DateTimeKind.Local).AddTicks(6489), new Guid("b1213274-e74c-428b-a9d7-008c7853315d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 19, 43, 115, DateTimeKind.Local).AddTicks(9901), new DateTime(2021, 7, 21, 19, 58, 45, 758, DateTimeKind.Local).AddTicks(6242), new Guid("909bd031-f164-4b17-bda5-ea904ed1a08d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 2, 44, 18, 903, DateTimeKind.Local).AddTicks(4186), new DateTime(2021, 2, 13, 6, 50, 46, 493, DateTimeKind.Local).AddTicks(8274), new Guid("1465f903-ed8b-4574-aea8-37c6bd4c8c2f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 18, 39, 15, DateTimeKind.Local).AddTicks(7883), new DateTime(2022, 1, 17, 15, 7, 47, 554, DateTimeKind.Local).AddTicks(9216), new Guid("0ac88a92-75ca-4e50-b046-daecbaf4f140") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 42, 53, 509, DateTimeKind.Local).AddTicks(2360), new DateTime(2021, 9, 5, 9, 57, 34, 546, DateTimeKind.Local).AddTicks(1354), new Guid("51d5cfd4-d066-4e47-ab1c-a7f1293d726e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 1, 25, 44, 951, DateTimeKind.Local).AddTicks(4021), new DateTime(2021, 5, 1, 17, 5, 1, 282, DateTimeKind.Local).AddTicks(6436), new Guid("18b1bbf5-b9af-454b-9188-18b61d8221c3") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 55, 52, 951, DateTimeKind.Local).AddTicks(3187), new DateTime(2021, 7, 12, 9, 46, 33, 60, DateTimeKind.Local).AddTicks(2169), new Guid("90b037dc-17f4-4ea4-9fe3-06c479b990d4") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 15, 12, 463, DateTimeKind.Local).AddTicks(5045), new DateTime(2021, 6, 9, 15, 8, 40, 329, DateTimeKind.Local).AddTicks(7742), new Guid("2298b5b2-1035-4059-8e92-a2899a66355b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 7, 46, 681, DateTimeKind.Local).AddTicks(2309), new DateTime(2021, 9, 30, 17, 31, 47, 203, DateTimeKind.Local).AddTicks(2790), new Guid("4d9d4e70-d65b-4581-874d-2fa4f4e4a73b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 17, 31, 202, DateTimeKind.Local).AddTicks(3747), new DateTime(2021, 12, 25, 20, 15, 26, 137, DateTimeKind.Local).AddTicks(2500), new Guid("204f6efb-cc5d-4914-b30c-f4b98ad47d4a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 1, 3, 16, 671, DateTimeKind.Local).AddTicks(4666), new DateTime(2021, 6, 2, 10, 23, 21, 914, DateTimeKind.Local).AddTicks(1523), new Guid("dd1645ec-2840-407e-a7c7-eaadf6b4c9c5") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 22, 55, 23, 499, DateTimeKind.Local).AddTicks(5301), new DateTime(2021, 11, 18, 21, 28, 46, 469, DateTimeKind.Local).AddTicks(1379), new Guid("07b00f8c-5339-4255-b429-7c2e07061862") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 20, 32, 19, 783, DateTimeKind.Local).AddTicks(4212), new DateTime(2021, 3, 18, 8, 36, 12, 969, DateTimeKind.Local).AddTicks(9467), new Guid("626570c4-fab4-4f47-86d9-478592b118dd") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 11, 24, 54, 261, DateTimeKind.Local).AddTicks(4290), new DateTime(2021, 6, 5, 3, 49, 43, 267, DateTimeKind.Local).AddTicks(6103), new Guid("81e17dc5-4d97-4c2b-b381-9dae9199005a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 52, 0, 65, DateTimeKind.Local).AddTicks(287), new DateTime(2021, 2, 28, 19, 56, 59, 709, DateTimeKind.Local).AddTicks(1683), new Guid("2b6d8608-b11e-4a9b-a08b-d945e34b1325") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 19, 43, 47, 253, DateTimeKind.Local).AddTicks(8682), new DateTime(2022, 1, 3, 19, 1, 32, 200, DateTimeKind.Local).AddTicks(6700), new Guid("7351a7fa-010c-4c6b-8c6c-18c873ae8050") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 24, 46, 217, DateTimeKind.Local).AddTicks(1022), new DateTime(2021, 2, 25, 1, 41, 59, 133, DateTimeKind.Local).AddTicks(7535), new Guid("1461d2d1-08f0-4da1-977f-0c16a6aa31f7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 7, 1, 49, 282, DateTimeKind.Local).AddTicks(5095), new DateTime(2021, 7, 20, 9, 3, 49, 122, DateTimeKind.Local).AddTicks(1116), new Guid("0ab7003d-ab3f-4dd6-9bf7-d8e4cb3aeed2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 23, 54, 46, 474, DateTimeKind.Local).AddTicks(5489), new DateTime(2021, 2, 10, 14, 30, 0, 631, DateTimeKind.Local).AddTicks(4970), new Guid("e024c04c-75c8-407e-b953-45004728cb30") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 15, 30, 9, 8, DateTimeKind.Local).AddTicks(3037), new DateTime(2022, 1, 23, 8, 43, 51, 680, DateTimeKind.Local).AddTicks(9719), new Guid("15c4bbd8-7e2e-4c47-9126-eb6e7ad9cf1d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 10, 39, 52, 171, DateTimeKind.Local).AddTicks(2939), new DateTime(2021, 6, 7, 17, 36, 0, 680, DateTimeKind.Local).AddTicks(7765), new Guid("4582202a-6c17-4565-a651-9acca841e4ed") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 22, 3, 860, DateTimeKind.Local).AddTicks(8455), new DateTime(2021, 10, 4, 18, 22, 32, 330, DateTimeKind.Local).AddTicks(7394), new Guid("739ae120-cd66-48eb-972f-54f9f5a9dc56") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 11, 13, 53, 436, DateTimeKind.Local).AddTicks(9289), new DateTime(2021, 5, 4, 4, 34, 48, 27, DateTimeKind.Local).AddTicks(3913), new Guid("e4888f66-11ec-4099-8ad3-204b7de4d57c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 20, 36, 19, 76, DateTimeKind.Local).AddTicks(5400), new DateTime(2022, 1, 31, 13, 16, 51, 748, DateTimeKind.Local).AddTicks(4139), new Guid("e6b8c8bf-b7a9-4f3f-b8b8-26efe2277ee0") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 6, 51, 21, 990, DateTimeKind.Local).AddTicks(4735), new DateTime(2022, 1, 2, 19, 41, 28, 43, DateTimeKind.Local).AddTicks(7947), new Guid("ba22a2cf-89da-434a-a5c5-babe4108721d") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 22, 53, 16, 195, DateTimeKind.Local).AddTicks(3523), new DateTime(2021, 7, 26, 17, 46, 21, 505, DateTimeKind.Local).AddTicks(6876), new Guid("6aae372e-cd8a-4d94-8de3-7628ae8d4693") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 14, 33, 665, DateTimeKind.Local).AddTicks(6561), new DateTime(2021, 5, 11, 4, 16, 21, 126, DateTimeKind.Local).AddTicks(2031), new Guid("4671428a-89eb-4973-9d85-db9bf9e6f624") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 30, 38, 648, DateTimeKind.Local).AddTicks(5649), new DateTime(2021, 12, 7, 9, 14, 8, 368, DateTimeKind.Local).AddTicks(6437), new Guid("461c448a-c559-46db-822d-c9872e5a338e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 49, 37, 542, DateTimeKind.Local).AddTicks(6724), new DateTime(2021, 6, 16, 2, 13, 53, 420, DateTimeKind.Local).AddTicks(7955), new Guid("82ece097-0b3f-4d69-b178-6fcae2deaae6") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 58, 13, 762, DateTimeKind.Local).AddTicks(5813), new DateTime(2021, 9, 25, 11, 47, 51, 363, DateTimeKind.Local).AddTicks(638), new Guid("926832f5-b7ce-4e14-adf3-4f04ccd7a0e7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 38, 1, 506, DateTimeKind.Local).AddTicks(9262), new DateTime(2021, 9, 27, 10, 20, 8, 685, DateTimeKind.Local).AddTicks(3049), new Guid("4f0703ec-d737-4fe7-ac8d-34e85d60b917") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 49, 6, 85, DateTimeKind.Local).AddTicks(5639), new DateTime(2021, 9, 5, 3, 41, 42, 401, DateTimeKind.Local).AddTicks(8870), new Guid("66328005-6124-4f50-b4af-2a1da6b383f2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 36, 53, 45, DateTimeKind.Local).AddTicks(6950), new DateTime(2021, 6, 10, 7, 17, 24, 877, DateTimeKind.Local).AddTicks(5765), new Guid("561a42cb-ebe9-48d1-be60-dc1856195dac") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 14, 11, 543, DateTimeKind.Local).AddTicks(9339), new DateTime(2021, 2, 5, 13, 8, 22, 570, DateTimeKind.Local).AddTicks(8125), new Guid("63ecad5d-d395-4627-ba65-fbdb99c24115") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 19, 1, 51, 786, DateTimeKind.Local).AddTicks(1829), new DateTime(2021, 10, 17, 17, 9, 4, 793, DateTimeKind.Local).AddTicks(8770), new Guid("cb445e59-4fc1-4ec5-b21d-631a5ea0e8d2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 28, 21, 770, DateTimeKind.Local).AddTicks(8925), new DateTime(2021, 12, 3, 4, 14, 13, 157, DateTimeKind.Local).AddTicks(8882), new Guid("fbe8f835-cd23-4ef7-b053-497c1ab2dadf") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 14, 12, 205, DateTimeKind.Local).AddTicks(9109), new DateTime(2022, 1, 6, 6, 51, 7, 73, DateTimeKind.Local).AddTicks(803), new Guid("b7099f4b-a449-4194-9632-176a3bc8c59c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 39, 41, 906, DateTimeKind.Local).AddTicks(4886), new DateTime(2021, 12, 30, 17, 36, 34, 808, DateTimeKind.Local).AddTicks(442), new Guid("e486256e-ce70-4746-b435-ade210a24e5b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 36, 3, 265, DateTimeKind.Local).AddTicks(1742), new DateTime(2021, 6, 20, 3, 7, 53, 66, DateTimeKind.Local).AddTicks(4078), new Guid("0b358bb8-6a64-4556-b80d-82bf4e139cd3") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 35, 13, 723, DateTimeKind.Local).AddTicks(661), new DateTime(2021, 7, 24, 4, 22, 30, 616, DateTimeKind.Local).AddTicks(5089), new Guid("0b32e2eb-88b1-4297-ac99-4739f3ebf5b0") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 6, 15, 44, 441, DateTimeKind.Local).AddTicks(9523), new DateTime(2021, 4, 18, 21, 50, 42, 229, DateTimeKind.Local).AddTicks(2742), new Guid("efee5b91-aa39-4bad-bd1e-e24fb5e17bac") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 30, 22, 376, DateTimeKind.Local).AddTicks(317), new DateTime(2021, 3, 7, 15, 7, 1, 696, DateTimeKind.Local).AddTicks(9158), new Guid("e412948c-e986-4129-8e40-e01f19897fa1") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 51, 3, 844, DateTimeKind.Local).AddTicks(5643), new DateTime(2022, 1, 19, 3, 55, 32, 898, DateTimeKind.Local).AddTicks(8595), new Guid("9d7a0f48-afdb-4031-9f38-f1bcc27ac723") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 21, 37, 17, 608, DateTimeKind.Local).AddTicks(6039), new DateTime(2021, 9, 27, 7, 4, 28, 615, DateTimeKind.Local).AddTicks(3847), new Guid("88d5a6cb-7b0a-4cef-a7a0-64547169d724") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 15, 28, 47, 901, DateTimeKind.Local).AddTicks(9347), new DateTime(2021, 4, 22, 7, 32, 2, 52, DateTimeKind.Local).AddTicks(8172), new Guid("8432e934-9769-460b-81a0-0fa69dd78b49") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 13, 30, 204, DateTimeKind.Local).AddTicks(1010), new DateTime(2021, 4, 13, 18, 39, 59, 827, DateTimeKind.Local).AddTicks(8901), new Guid("438b6de1-81db-4ddc-bc7b-2f410ebe0184") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 6, 24, 840, DateTimeKind.Local).AddTicks(3160), new DateTime(2021, 8, 30, 12, 53, 6, 351, DateTimeKind.Local).AddTicks(3935), new Guid("c1897e0d-fc8a-4f48-95f2-3593c9057381") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 20, 55, 36, 514, DateTimeKind.Local).AddTicks(6031), new DateTime(2022, 1, 1, 18, 46, 55, 354, DateTimeKind.Local).AddTicks(5895), new Guid("a60ae700-dc00-4605-bff1-09bdb367f9ff") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 4, 15, 18, 646, DateTimeKind.Local).AddTicks(8442), new DateTime(2021, 7, 30, 14, 52, 27, 289, DateTimeKind.Local).AddTicks(4385), new Guid("a7c008c1-c2d4-436b-abe3-f3574452ed33") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 7, 26, 55, 31, DateTimeKind.Local).AddTicks(7014), new DateTime(2021, 11, 9, 16, 12, 45, 207, DateTimeKind.Local).AddTicks(8021), new Guid("b1966333-3046-44bc-9c2e-b44404fb3321") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 19, 19, 54, 598, DateTimeKind.Local).AddTicks(6115), new DateTime(2021, 9, 6, 19, 23, 22, 441, DateTimeKind.Local).AddTicks(5820), new Guid("c25cfd5b-e318-4426-bf37-23ab0337a320") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 9, 36, 577, DateTimeKind.Local).AddTicks(1750), new DateTime(2021, 4, 24, 22, 15, 37, 907, DateTimeKind.Local).AddTicks(4341), new Guid("209c3cc0-af54-422a-a981-dd7b6f7869f1") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 31, 31, 606, DateTimeKind.Local).AddTicks(7255), new DateTime(2021, 3, 5, 22, 53, 54, 157, DateTimeKind.Local).AddTicks(8950), new Guid("b4f11734-42b0-424b-b17a-faddb6b21109") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 14, 10, 523, DateTimeKind.Local).AddTicks(9355), new DateTime(2021, 2, 11, 17, 31, 17, 67, DateTimeKind.Local).AddTicks(832), new Guid("26d1e340-005a-4399-bf67-0d62780bd5b0") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 39, 58, 146, DateTimeKind.Local).AddTicks(2962), new DateTime(2021, 11, 13, 22, 8, 11, 881, DateTimeKind.Local).AddTicks(3939), new Guid("3b4e3b88-6dd4-46e9-977f-0f7bff085855") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 10, 20, 179, DateTimeKind.Local).AddTicks(3346), new DateTime(2021, 7, 11, 15, 34, 40, 616, DateTimeKind.Local).AddTicks(1375), new Guid("bcac9dc4-2caa-4c36-bcc4-a56e3a10ea43") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 2, 41, 53, 410, DateTimeKind.Local).AddTicks(2856), new DateTime(2021, 2, 14, 6, 47, 48, 111, DateTimeKind.Local).AddTicks(1926), new Guid("05abc473-8e06-4eb2-8138-7985b0e677ca") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 4, 16, 593, DateTimeKind.Local).AddTicks(919), new DateTime(2021, 10, 6, 17, 26, 41, 56, DateTimeKind.Local).AddTicks(4257), new Guid("ed3fec2c-c77f-49d5-99dc-a9af6e189260") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 21, 26, 35, 609, DateTimeKind.Local).AddTicks(8312), new DateTime(2021, 3, 18, 1, 56, 26, 139, DateTimeKind.Local).AddTicks(4033), new Guid("fdfa9c8e-9007-43d2-909f-24ce2b533814") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 51, 12, 456, DateTimeKind.Local).AddTicks(2671), new DateTime(2021, 7, 12, 21, 39, 26, 358, DateTimeKind.Local).AddTicks(6342), new Guid("913df3b1-cd0b-4394-b0bf-601108ecf9d6") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 7, 3, 988, DateTimeKind.Local).AddTicks(3307), new DateTime(2021, 8, 2, 12, 38, 54, 391, DateTimeKind.Local).AddTicks(5878), new Guid("c015b482-1c48-492a-877f-6049a3659008") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 35, 22, 287, DateTimeKind.Local).AddTicks(9363), new DateTime(2022, 1, 18, 0, 45, 56, 327, DateTimeKind.Local).AddTicks(9355), new Guid("ddf25562-83ff-4020-92f9-afbf03b027d2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 5, 28, 33, 804, DateTimeKind.Local).AddTicks(5942), new DateTime(2021, 10, 13, 4, 22, 14, 318, DateTimeKind.Local).AddTicks(2322), new Guid("a05be60a-2de6-4f6d-b37b-1af0ad98c558") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 3, 29, 171, DateTimeKind.Local).AddTicks(1477), new DateTime(2021, 5, 26, 23, 24, 41, 662, DateTimeKind.Local).AddTicks(5842), new Guid("c57e0711-23bc-44b1-9cd7-8a5d2d26c2d5") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 7, 49, 16, 851, DateTimeKind.Local).AddTicks(5656), new DateTime(2021, 12, 6, 23, 0, 1, 813, DateTimeKind.Local).AddTicks(8954), new Guid("18e520bf-b0b6-4e70-8318-6e1974d67b82") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 10, 18, 3, 826, DateTimeKind.Local).AddTicks(2021), new DateTime(2021, 11, 2, 16, 29, 17, 598, DateTimeKind.Local).AddTicks(3385), new Guid("f295da2c-6972-41c2-8d3e-05b1e4b3be83") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 31, 20, 160, DateTimeKind.Local).AddTicks(8609), new DateTime(2021, 5, 11, 22, 16, 58, 497, DateTimeKind.Local).AddTicks(4396), new Guid("735b1b67-0f62-4b00-ab8e-565fc84c744f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 12, 57, 998, DateTimeKind.Local).AddTicks(388), new DateTime(2021, 12, 20, 6, 17, 19, 159, DateTimeKind.Local).AddTicks(4907), new Guid("fd1fa16a-1b38-4423-9af7-6e6b33bd6671") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 23, 47, 24, 670, DateTimeKind.Local).AddTicks(9272), new DateTime(2021, 2, 13, 13, 4, 56, 446, DateTimeKind.Local).AddTicks(2420), new Guid("4cc6a0f7-0b9a-44a1-826f-aa6576f75715") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 11, 58, 175, DateTimeKind.Local).AddTicks(5976), new DateTime(2022, 1, 30, 15, 30, 0, 137, DateTimeKind.Local).AddTicks(91), new Guid("4189562c-e4d8-4d85-8fa6-d8fc841b8686") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 10, 15, 16, 20, DateTimeKind.Local).AddTicks(1610), new DateTime(2021, 6, 9, 23, 28, 36, 731, DateTimeKind.Local).AddTicks(3778), new Guid("bb1986d5-fcfc-4db1-b22e-cdf5482ce21f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 35, 47, 771, DateTimeKind.Local).AddTicks(9070), new DateTime(2021, 10, 17, 14, 7, 55, 466, DateTimeKind.Local).AddTicks(2149), new Guid("8e7581f9-ec04-49cc-846c-66c813ccfb3f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 13, 27, 531, DateTimeKind.Local).AddTicks(2823), new DateTime(2021, 10, 21, 18, 45, 31, 485, DateTimeKind.Local).AddTicks(9881), new Guid("feace6ef-6575-482a-b562-4f49d1201f9c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 5, 44, 131, DateTimeKind.Local).AddTicks(2385), new DateTime(2021, 2, 21, 4, 51, 49, 936, DateTimeKind.Local).AddTicks(2543), new Guid("5eefd53e-80cf-4a47-a99d-44651d96bc46") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 1, 43, 16, 345, DateTimeKind.Local).AddTicks(4782), new DateTime(2021, 8, 10, 16, 22, 27, 117, DateTimeKind.Local).AddTicks(352), new Guid("0444e357-e0bb-4390-84cf-e91f71b33b86") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 4, 6, 44, 493, DateTimeKind.Local).AddTicks(8535), new DateTime(2021, 3, 8, 23, 13, 59, 227, DateTimeKind.Local).AddTicks(7050), new Guid("aa5f6c3b-1fc2-4d53-959e-0a2330fd9628") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 19, 0, 25, 973, DateTimeKind.Local).AddTicks(7137), new DateTime(2021, 8, 10, 11, 21, 42, 837, DateTimeKind.Local).AddTicks(504), new Guid("3b2518ce-3610-4622-aa9b-dad6c7a41d1e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 1, 34, 706, DateTimeKind.Local).AddTicks(2854), new DateTime(2021, 11, 29, 2, 38, 21, 415, DateTimeKind.Local).AddTicks(6126), new Guid("571d68c9-c340-4678-ac29-173f81b0de1e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 23, 14, 20, 673, DateTimeKind.Local).AddTicks(4750), new DateTime(2021, 11, 29, 19, 44, 49, 394, DateTimeKind.Local).AddTicks(5652), new Guid("b7e04d99-252f-4656-95c3-b40458f2860a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 44, 35, 50, DateTimeKind.Local).AddTicks(9252), new DateTime(2021, 9, 1, 21, 36, 36, 868, DateTimeKind.Local).AddTicks(2200), new Guid("0e674254-a0de-4566-913a-57fbe9edccca") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 34, 54, 417, DateTimeKind.Local).AddTicks(7235), new DateTime(2022, 1, 7, 9, 13, 25, 731, DateTimeKind.Local).AddTicks(1964), new Guid("0e0f6f2c-b796-4456-9517-3f7686a45c42") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 20, 55, 27, 182, DateTimeKind.Local).AddTicks(9785), new DateTime(2021, 5, 25, 9, 56, 54, 126, DateTimeKind.Local).AddTicks(1504), new Guid("48449ebf-2ae7-4b3c-87e1-ac5743279dd7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 44, 36, 240, DateTimeKind.Local).AddTicks(2185), new DateTime(2021, 6, 7, 7, 50, 36, 339, DateTimeKind.Local).AddTicks(5707), new Guid("a0590c9e-9c80-4f1f-b5e5-60caaf6f8f4f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 33, 58, 234, DateTimeKind.Local).AddTicks(1961), new DateTime(2022, 1, 25, 7, 20, 51, 805, DateTimeKind.Local).AddTicks(1072), new Guid("f3050083-f482-4568-97bc-4fd387002864") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 26, 41, 779, DateTimeKind.Local).AddTicks(4998), new DateTime(2021, 9, 18, 16, 47, 7, 261, DateTimeKind.Local).AddTicks(7251), new Guid("1f9f5134-d22c-4064-b328-90b01bbe9506") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 40, 13, 124, DateTimeKind.Local).AddTicks(678), new DateTime(2021, 8, 4, 21, 9, 20, 120, DateTimeKind.Local).AddTicks(8904), new Guid("a39ab949-353a-4397-ae99-6792e55d0148") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 2, 21, 42, 241, DateTimeKind.Local).AddTicks(8621), new DateTime(2021, 9, 15, 21, 12, 26, 793, DateTimeKind.Local).AddTicks(1942), new Guid("7d485cbe-7b3c-41db-b855-b3d65f824737") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 34, 22, 739, DateTimeKind.Local).AddTicks(2576), new DateTime(2021, 3, 7, 0, 16, 26, 127, DateTimeKind.Local).AddTicks(128), new Guid("fb1f17e2-9c02-4953-9aec-a7b49c5b3806") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 5, 19, 812, DateTimeKind.Local).AddTicks(6332), new DateTime(2021, 3, 26, 0, 26, 46, 440, DateTimeKind.Local).AddTicks(6584), new Guid("36809c58-3c06-4f31-abc4-fcb330e9a11a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 46, 50, 576, DateTimeKind.Local).AddTicks(8595), new DateTime(2021, 5, 27, 8, 42, 47, 530, DateTimeKind.Local).AddTicks(465), new Guid("0ff7bec1-ae54-4b00-96c3-2027d9ec118f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 15, 1, 34, 498, DateTimeKind.Local).AddTicks(1741), new DateTime(2022, 1, 31, 11, 47, 32, 993, DateTimeKind.Local).AddTicks(3416), new Guid("1595db01-98d0-4d9c-936f-992701d349c0") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 6, 1, 30, 506, DateTimeKind.Local).AddTicks(2769), new DateTime(2021, 12, 30, 5, 57, 41, 971, DateTimeKind.Local).AddTicks(6514), new Guid("43a4e57f-f829-47e7-ae02-afefd830d1b4") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 39, 6, 194, DateTimeKind.Local).AddTicks(7531), new DateTime(2021, 12, 11, 17, 39, 33, 623, DateTimeKind.Local).AddTicks(7755), new Guid("31f1a871-a3e8-4d56-92fd-ce1e548866b4") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 33, 31, 575, DateTimeKind.Local).AddTicks(1531), new DateTime(2021, 3, 13, 21, 56, 46, 991, DateTimeKind.Local).AddTicks(8058), new Guid("981f7b74-ecc8-45cd-802c-51d645f321d7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 7, 32, 539, DateTimeKind.Local).AddTicks(9418), new DateTime(2021, 12, 23, 2, 18, 54, 759, DateTimeKind.Local).AddTicks(4091), new Guid("3b59f829-3d3f-49a5-ba43-786d0e71387a") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 9, 43, 38, 415, DateTimeKind.Local).AddTicks(1219), new DateTime(2021, 11, 11, 8, 4, 51, 249, DateTimeKind.Local).AddTicks(5647), new Guid("86930a18-85db-4174-8d00-061d954dda01") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 2, 45, 33, 1, DateTimeKind.Local).AddTicks(7435), new DateTime(2021, 5, 2, 21, 18, 17, 158, DateTimeKind.Local).AddTicks(6546), new Guid("8ad1cc8f-2dbf-4f24-8280-3c00c6291156") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 35, 10, 994, DateTimeKind.Local).AddTicks(4025), new DateTime(2021, 5, 10, 12, 32, 26, 751, DateTimeKind.Local).AddTicks(6623), new Guid("7b688cb7-22d8-4a7e-96e9-0d04af82d7a7") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 17, 2, 35, 233, DateTimeKind.Local).AddTicks(8701), new DateTime(2022, 1, 4, 4, 57, 40, 788, DateTimeKind.Local).AddTicks(9804), new Guid("426d2044-f0d6-4c86-a41b-9c98b6549629") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 49, 1, 542, DateTimeKind.Local).AddTicks(5732), new DateTime(2021, 12, 16, 18, 21, 25, 8, DateTimeKind.Local).AddTicks(8217), new Guid("9e4afddd-de03-4b54-9d2e-fbf19af9eeed") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 4, 41, 29, 804, DateTimeKind.Local).AddTicks(5309), new DateTime(2021, 3, 12, 21, 24, 54, 522, DateTimeKind.Local).AddTicks(2641), new Guid("9d07943f-9be3-4ed8-b662-773fd6ff71bd") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 10, 22, 4, 487, DateTimeKind.Local).AddTicks(8649), new DateTime(2021, 9, 1, 16, 47, 32, 117, DateTimeKind.Local).AddTicks(9351), new Guid("99d47f46-a524-4d0b-8ef9-14dfef7f7a44") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 4, 45, 56, 406, DateTimeKind.Local).AddTicks(8429), new DateTime(2021, 8, 25, 20, 39, 47, 904, DateTimeKind.Local).AddTicks(501), new Guid("f1a4fc50-60e9-497e-83bc-7413b7a96f74") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 2, 54, 22, 151, DateTimeKind.Local).AddTicks(7740), new DateTime(2021, 12, 15, 13, 1, 11, 426, DateTimeKind.Local).AddTicks(8077), new Guid("8040a42a-b7f7-4d4a-acea-10cd12d82a9b") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 34, 54, 205, DateTimeKind.Local).AddTicks(2330), new DateTime(2021, 8, 30, 1, 26, 47, 9, DateTimeKind.Local).AddTicks(5185), new Guid("5e1088be-a4a9-4e7f-8d8e-6f5b502d4101") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 50, 7, 292, DateTimeKind.Local).AddTicks(7876), new DateTime(2021, 4, 5, 5, 13, 31, 613, DateTimeKind.Local).AddTicks(7154), new Guid("5aa6cc31-2a5c-4240-ac31-5c336d687725") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 21, 11, 20, 961, DateTimeKind.Local).AddTicks(4042), new DateTime(2021, 8, 28, 5, 37, 27, 699, DateTimeKind.Local).AddTicks(3448), new Guid("b6c6a501-7c20-4da6-b7e5-0d7fe33f9277") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 46, 34, 952, DateTimeKind.Local).AddTicks(4044), new DateTime(2021, 3, 28, 17, 47, 53, 582, DateTimeKind.Local).AddTicks(2773), new Guid("7597bfa3-d731-43ce-84bc-926315fa968e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 44, 54, 984, DateTimeKind.Local).AddTicks(5321), new DateTime(2021, 7, 30, 22, 59, 4, 60, DateTimeKind.Local).AddTicks(3388), new Guid("f1be6394-2330-4b91-944a-718d6a7edccd") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 10, 41, 5, 313, DateTimeKind.Local).AddTicks(4732), new DateTime(2021, 4, 21, 11, 36, 57, 321, DateTimeKind.Local).AddTicks(44), new Guid("4f3c1db0-4dd4-415e-b199-fc077eb015f9") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 40, 45, 220, DateTimeKind.Local).AddTicks(3149), new DateTime(2021, 3, 17, 7, 15, 30, 651, DateTimeKind.Local).AddTicks(1843), new Guid("0b13e1c0-b7fe-4366-974a-d1cc0fb10b47") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 28, 2, 277, DateTimeKind.Local).AddTicks(4242), new DateTime(2021, 5, 8, 3, 43, 53, 717, DateTimeKind.Local).AddTicks(1228), new Guid("3b6137b0-ec18-4a26-aeda-abf65a4fe123") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 12, 53, 465, DateTimeKind.Local).AddTicks(6950), new DateTime(2021, 9, 5, 16, 18, 6, 335, DateTimeKind.Local).AddTicks(9826), new Guid("7445e28a-7332-4173-b2ab-ac32c1b8911c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 0, 47, 59, 521, DateTimeKind.Local).AddTicks(8766), new DateTime(2021, 12, 21, 7, 27, 21, 356, DateTimeKind.Local).AddTicks(7556), new Guid("e3be3b46-a5ce-42fb-b81b-f712e3252936") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 23, 50, 36, 992, DateTimeKind.Local).AddTicks(3784), new DateTime(2021, 2, 3, 20, 10, 25, 119, DateTimeKind.Local).AddTicks(6789), new Guid("edf3259b-f24e-4474-aa8a-eafc97fcb258") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 23, 15, 13, 444, DateTimeKind.Local).AddTicks(8506), new DateTime(2021, 6, 17, 11, 2, 32, 672, DateTimeKind.Local).AddTicks(6963), new Guid("289d3b75-f44e-46e0-a7a4-81446d11f5eb") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 14, 20, 25, 632, DateTimeKind.Local).AddTicks(9889), new DateTime(2021, 11, 15, 13, 55, 24, 710, DateTimeKind.Local).AddTicks(9764), new Guid("b5b9694c-8eda-4d7f-bf6f-7e2970b5ffcf") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 59, 37, 870, DateTimeKind.Local).AddTicks(5609), new DateTime(2021, 5, 30, 18, 26, 57, 429, DateTimeKind.Local).AddTicks(943), new Guid("af9ecb1d-a7e6-431e-ae72-72de803d4c4c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 8, 48, 46, 351, DateTimeKind.Local).AddTicks(1071), new DateTime(2021, 3, 21, 8, 37, 52, 152, DateTimeKind.Local).AddTicks(9674), new Guid("9e000674-e9a0-42ab-a7e9-264d0633838f") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 7, 53, 45, 904, DateTimeKind.Local).AddTicks(6746), new DateTime(2021, 3, 10, 14, 9, 58, 567, DateTimeKind.Local).AddTicks(839), new Guid("6d3ae6d6-9dac-4ec9-9fb7-bea24dde0191") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 4, 13, 58, 227, DateTimeKind.Local).AddTicks(2476), new DateTime(2021, 4, 20, 3, 14, 6, 986, DateTimeKind.Local).AddTicks(2965), new Guid("e07e0116-f368-4092-b340-a3dea2416e8e") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 23, 52, 59, 841, DateTimeKind.Local).AddTicks(8839), new DateTime(2021, 7, 30, 6, 44, 4, 566, DateTimeKind.Local).AddTicks(1312), new Guid("0ecd06c9-4727-4c90-b47d-da167fe95229") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 10, 6, 50, 971, DateTimeKind.Local).AddTicks(4622), new DateTime(2021, 2, 9, 13, 49, 2, 14, DateTimeKind.Local).AddTicks(2708), new Guid("fee84e22-3a09-4350-8166-b901db751a79") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 5, 29, 43, 645, DateTimeKind.Local).AddTicks(6362), new DateTime(2021, 11, 14, 10, 26, 51, 262, DateTimeKind.Local).AddTicks(8100), new Guid("c50cfc71-4708-443e-90ca-0a5aa14a4211") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 1, 35, 49, 263, DateTimeKind.Local).AddTicks(1743), new DateTime(2021, 7, 23, 12, 10, 10, 177, DateTimeKind.Local).AddTicks(5312), new Guid("4f8baf41-4f9c-4bc9-b21a-4286c9fba175") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 4, 3, 44, 824, DateTimeKind.Local).AddTicks(816), new DateTime(2021, 8, 14, 23, 11, 22, 775, DateTimeKind.Local).AddTicks(2292), new Guid("89f2f6d1-26de-418d-bff2-784982ab65bb") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 5, 55, 54, 778, DateTimeKind.Local).AddTicks(5167), new DateTime(2021, 5, 30, 14, 43, 4, 579, DateTimeKind.Local).AddTicks(5326), new Guid("30cafdac-e075-49f6-b8eb-9f77e42994cc") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 22, 51, 31, 192, DateTimeKind.Local).AddTicks(9657), new DateTime(2021, 12, 21, 7, 24, 39, 399, DateTimeKind.Local).AddTicks(299), new Guid("a151bc24-4cc6-4418-a2ca-8fc903eb4f57") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 52, 21, 306, DateTimeKind.Local).AddTicks(193), new DateTime(2021, 10, 3, 1, 5, 3, 925, DateTimeKind.Local).AddTicks(9313), new Guid("b2a20e0e-5d30-43f1-a84c-2dc290a6ea06") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 1, 52, 44, 102, DateTimeKind.Local).AddTicks(4643), new DateTime(2021, 12, 12, 16, 44, 30, 459, DateTimeKind.Local).AddTicks(9455), new Guid("6864d541-6dbb-4d9f-98f1-64ee03e40744") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 23, 21, 35, 96, DateTimeKind.Local).AddTicks(6272), new DateTime(2021, 2, 19, 15, 14, 20, 133, DateTimeKind.Local).AddTicks(1608), new Guid("8775002b-802a-4db0-aeba-050c55fe8fa1") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 7, 4, 903, DateTimeKind.Local).AddTicks(1307), new DateTime(2022, 1, 1, 23, 33, 56, 261, DateTimeKind.Local).AddTicks(6914), new Guid("63f0b067-b9ba-4896-a2c0-29af26f128ef") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 2, 22, 38, 31, 349, DateTimeKind.Local).AddTicks(2472), new DateTime(2021, 4, 4, 9, 47, 30, 906, DateTimeKind.Local).AddTicks(8053), new Guid("e6d4148c-4cdd-49a4-9b2a-d74fdf048a40") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 18, 50, 22, 838, DateTimeKind.Local).AddTicks(9667), new DateTime(2021, 10, 2, 3, 43, 58, 765, DateTimeKind.Local).AddTicks(7087), new Guid("b57a20bc-cab0-49d7-8825-4fadc4faf786") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 10, 22, 42, 676, DateTimeKind.Local).AddTicks(4119), new DateTime(2021, 12, 2, 16, 34, 17, 129, DateTimeKind.Local).AddTicks(5063), new Guid("eb6d3035-3213-4732-bcb8-ab78d5cf2581") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 57, 47, 248, DateTimeKind.Local).AddTicks(7820), new DateTime(2021, 12, 3, 12, 34, 17, 90, DateTimeKind.Local).AddTicks(1151), new Guid("9002566d-a4d0-4595-9b9c-577730657233") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 21, 19, 724, DateTimeKind.Local).AddTicks(950), new DateTime(2021, 11, 25, 16, 58, 34, 212, DateTimeKind.Local).AddTicks(7666), new Guid("e75bb394-b8a2-4a3c-803f-4b5aec64a1a3") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 13, 9, 23, 807, DateTimeKind.Local).AddTicks(5625), new DateTime(2021, 9, 10, 12, 18, 49, 46, DateTimeKind.Local).AddTicks(1511), new Guid("b571a13f-156e-4354-aafc-3b051c9079f2") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 3, 47, 44, 442, DateTimeKind.Local).AddTicks(6926), new DateTime(2021, 3, 22, 12, 49, 3, 91, DateTimeKind.Local).AddTicks(1656), new Guid("e68d2445-d10c-45a3-b6e9-d491c36b9673") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 49, 49, 691, DateTimeKind.Local).AddTicks(7309), new DateTime(2021, 6, 9, 0, 0, 41, 433, DateTimeKind.Local).AddTicks(8000), new Guid("4ab327f5-d685-42e9-a820-048e4df0177c") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 16, 6, 47, 82, DateTimeKind.Local).AddTicks(5636), new DateTime(2021, 2, 17, 19, 27, 50, 173, DateTimeKind.Local).AddTicks(34), new Guid("1cf845b6-2eac-4668-bc19-8ff5de06c7d5") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 11, 24, 16, 163, DateTimeKind.Local).AddTicks(7219), new DateTime(2021, 11, 27, 16, 29, 45, 33, DateTimeKind.Local).AddTicks(7383), new Guid("7443b81b-5437-48e1-b622-ae49ea745139") });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 3, 12, 53, 17, 506, DateTimeKind.Local).AddTicks(5451), new DateTime(2021, 10, 24, 2, 56, 30, 57, DateTimeKind.Local).AddTicks(2587), new Guid("2c583d45-d133-414b-99eb-0ec768131c47") });
        }
    }
}
