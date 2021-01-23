using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Petsupport.API2.Migrations
{
    public partial class UpdateFakeDataa : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "ImageId",
                table: "Services");

            migrationBuilder.DropColumn(
                name: "Address",
                table: "Petsitters");

            migrationBuilder.DropColumn(
                name: "Password",
                table: "Petsitters");

            migrationBuilder.AlterColumn<string>(
                name: "PhotoId",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "AvailabilityFrom",
                table: "Petsitters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "AvailabilityTo",
                table: "Petsitters",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<Guid>(
                name: "AzureId",
                table: "Petsitters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Environment",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ParcelAndHouseNumbers",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<double>(
                name: "Rate",
                table: "Petsitters",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "Street",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Title",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ZipCode",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<Guid>(
                name: "AzureId",
                table: "Clients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "AzureId",
                value: new Guid("6a241a8f-6879-40d2-b758-5205ea1eefca"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "AzureId",
                value: new Guid("73e2804b-899c-42a0-9d64-1d22c4f0c26e"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "AzureId",
                value: new Guid("0d2d5de5-48d6-4dfb-9da2-127532080d27"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "AzureId",
                value: new Guid("4a1530d2-1f0a-4068-a485-225ec7f69a5d"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "AzureId",
                value: new Guid("77420b64-d9a9-4f50-8db3-1ca46e48625c"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                column: "AzureId",
                value: new Guid("e83f575c-c6c5-43ca-9f47-91b140bbb811"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                column: "AzureId",
                value: new Guid("db7e4422-930f-4abc-8271-cbb225b7607b"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                column: "AzureId",
                value: new Guid("e1455916-bb4c-4116-88dc-f1d4d701e380"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                column: "AzureId",
                value: new Guid("ccbff6e7-0ae9-44b6-a43c-f339addd5174"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                column: "AzureId",
                value: new Guid("bcd5f378-6632-4dd5-95f3-5c7a126fb067"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11,
                column: "AzureId",
                value: new Guid("6ee4875b-d669-4b66-9991-4a43ee49e54e"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12,
                column: "AzureId",
                value: new Guid("69687eca-8e33-4fd0-8a90-6a824c200502"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13,
                column: "AzureId",
                value: new Guid("eceaaebd-e5f0-4adb-a723-bbdafc90f741"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14,
                column: "AzureId",
                value: new Guid("b588cf4b-4163-41ec-8e4d-b30b14df0fa3"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15,
                column: "AzureId",
                value: new Guid("94165790-3f6c-44b2-ba2e-adae3c4dc2c4"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 16,
                column: "AzureId",
                value: new Guid("bd5d2bcd-e6ed-4037-aa81-7774b7b16e50"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 17,
                column: "AzureId",
                value: new Guid("54147035-ee50-4ef1-9f1e-89233ab8f9d4"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 18,
                column: "AzureId",
                value: new Guid("5f1baa83-1cfd-46d8-a5c6-c41dc0623973"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 19,
                column: "AzureId",
                value: new Guid("dad04549-4ead-49a8-bd31-ad7596b65695"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 20,
                column: "AzureId",
                value: new Guid("6a7a7870-c819-430c-9f44-ae0d09ee94a5"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 21,
                column: "AzureId",
                value: new Guid("db98c87e-7c03-4519-a9eb-48efc2849a74"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 22,
                column: "AzureId",
                value: new Guid("fc310420-16f9-498b-8d1a-ce68d3225476"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 23,
                column: "AzureId",
                value: new Guid("41dd47b0-81a3-4045-813f-94ca7de259cc"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 24,
                column: "AzureId",
                value: new Guid("a9bb7c9a-f1e8-4a76-a979-c10e5ede43c2"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 25,
                column: "AzureId",
                value: new Guid("51b48f33-3c89-469e-beda-1f65f92756ae"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 26,
                column: "AzureId",
                value: new Guid("7b52a4bb-d96a-48cd-970d-ca45da84a4d5"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 27,
                column: "AzureId",
                value: new Guid("e23d4db3-3221-4090-9cde-f17d466a664c"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 28,
                column: "AzureId",
                value: new Guid("a46317b7-bd34-428d-8c47-77b1c1d4ebfa"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 29,
                column: "AzureId",
                value: new Guid("63cebf6f-a88b-460b-9f26-b54824c545ec"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 30,
                column: "AzureId",
                value: new Guid("e6ea1a30-5f12-4bac-b0d5-9acd4d4a3260"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AzureId", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 100, new Guid("c76ee215-e926-4cc2-8813-2cb456c4ebe8"), "Hector.Kilback22@gmail.com", "Hector", "1-288-747-4751 x08608", "Kilback" },
                    { 83, new Guid("74bf03a0-9e36-4ca8-9798-f31d39acbdb3"), "Mike.Durgan@hotmail.com", "Mike", "1-626-843-5533 x93368", "Durgan" },
                    { 84, new Guid("4733d70c-c79f-46f7-879b-bc3f5431a361"), "Mike.Renner23@yahoo.com", "Mike", "1-472-203-3735 x870", "Renner" },
                    { 85, new Guid("0e2dca46-e0c3-499a-9cca-3f5fe8da601f"), "Christopher_Kassulke@gmail.com", "Christopher", "537-957-5955", "Kassulke" },
                    { 86, new Guid("eb2442b0-56a4-4fdb-8a11-edc09426e2e3"), "Rodney.Bayer63@yahoo.com", "Rodney", "(900) 653-7830 x681", "Bayer" },
                    { 87, new Guid("53c6e622-613c-4fd0-8bed-8fb2b0f6f5ba"), "Rebecca_Lind26@hotmail.com", "Rebecca", "909-489-1949", "Lind" },
                    { 88, new Guid("240fd438-3aeb-4a2f-b147-cf101ecb8a6a"), "Rufus.Okuneva16@gmail.com", "Rufus", "212-784-2338 x68206", "Okuneva" },
                    { 89, new Guid("35d531eb-164d-43f0-90ea-5d02933b3845"), "Randal.McDermott37@gmail.com", "Randal", "937-746-6693 x47030", "McDermott" },
                    { 90, new Guid("46057714-58fc-43ae-9f42-ec8147773489"), "Frankie28@hotmail.com", "Frankie", "245.926.9416 x7667", "Mante" },
                    { 91, new Guid("86237bea-8800-4738-a18c-93429b52f0dd"), "Carl_Maggio@gmail.com", "Carl", "(273) 985-5351", "Maggio" },
                    { 92, new Guid("de01d36a-262e-4341-b6e1-b3e8d298b7ca"), "Lori.Emard94@yahoo.com", "Lori", "1-401-444-0460", "Emard" },
                    { 93, new Guid("8efe688d-2e52-4fb0-adb7-5c1240a14a28"), "Josh93@gmail.com", "Josh", "(785) 202-3833", "Volkman" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AzureId", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 94, new Guid("f795ee51-8a71-4346-8dc5-fc06fbac583e"), "Kevin80@gmail.com", "Kevin", "(994) 662-5735 x2169", "Kshlerin" },
                    { 95, new Guid("cbcd6014-eac7-4e44-9830-0a1c7ab79ca0"), "Jerry.Terry@gmail.com", "Jerry", "735-714-3762 x8420", "Terry" },
                    { 96, new Guid("8ccf8999-0761-4f58-bf6c-6c97805e5f94"), "Roberto_Goodwin@yahoo.com", "Roberto", "1-544-329-0627 x0241", "Goodwin" },
                    { 97, new Guid("fbf23580-662b-4029-8464-d99452f3b4b6"), "Jana_Will27@hotmail.com", "Jana", "693.407.7151 x942", "Will" },
                    { 98, new Guid("c6722b6e-3874-4e22-b5d7-e4d66cff247f"), "Antoinette26@yahoo.com", "Antoinette", "1-534-847-8817 x2393", "Schneider" },
                    { 99, new Guid("58d1621b-db5f-4d59-9697-dd6afd40296a"), "Helen84@gmail.com", "Helen", "(419) 296-4702 x22389", "Hintz" },
                    { 82, new Guid("18d3bab1-0cbe-4510-b537-4fd4605a2ce8"), "Oliver66@yahoo.com", "Oliver", "714-375-9073 x463", "Bailey" },
                    { 81, new Guid("2bcbcf96-3713-4457-8c3b-36bcac026dde"), "Guillermo.Cruickshank13@yahoo.com", "Guillermo", "920-543-2999 x64945", "Cruickshank" },
                    { 31, new Guid("bd860bf8-92dc-4bbb-a231-ca0e6d374e77"), "Francis23@gmail.com", "Francis", "784.342.6059", "Nader" },
                    { 79, new Guid("3395c508-6cd8-450b-8997-dff385dd255e"), "Drew_Conn84@hotmail.com", "Drew", "827.681.2288 x652", "Conn" },
                    { 40, new Guid("6dc02021-7c60-452b-b33f-8e8476cedb84"), "Herbert_Muller3@gmail.com", "Herbert", "1-856-661-2329 x6980", "Muller" },
                    { 41, new Guid("d57fd2b2-e943-4906-8181-5e8396af9c7a"), "Nicolas_Smitham68@gmail.com", "Nicolas", "949.285.0995 x496", "Smitham" },
                    { 42, new Guid("3d5e3cb4-ea5e-4d98-9649-5b058564d135"), "Carmen.Will25@yahoo.com", "Carmen", "1-263-650-6424", "Will" },
                    { 43, new Guid("730e13ef-1a5d-4804-9881-b4a5722b6260"), "Amos.Heaney63@gmail.com", "Amos", "1-615-585-5782 x8761", "Heaney" },
                    { 44, new Guid("1ab8c452-039f-4c55-9695-f913e7741dbb"), "Shirley_Watsica@gmail.com", "Shirley", "1-876-617-8412 x713", "Watsica" },
                    { 45, new Guid("fdc1d4ad-fbe5-4024-98ed-09c89f1aa7f4"), "Annie.Yost89@hotmail.com", "Annie", "(866) 497-7213 x7863", "Yost" },
                    { 46, new Guid("12adc771-312b-4358-ac36-7e83f1decf59"), "Tracey.Johnston6@yahoo.com", "Tracey", "958.224.2564", "Johnston" },
                    { 47, new Guid("0815b871-d4af-43b4-a799-1a5f276c6f33"), "Donnie_Rau@yahoo.com", "Donnie", "342-684-0069", "Rau" },
                    { 48, new Guid("3d1eed44-d01a-4c10-94fa-80774f19c029"), "Betsy86@gmail.com", "Betsy", "269.739.5552 x6949", "Powlowski" },
                    { 49, new Guid("e96abaf5-6c71-4188-a646-12dc0018fd42"), "Jacob.McLaughlin@hotmail.com", "Jacob", "1-514-983-5864", "McLaughlin" },
                    { 50, new Guid("3ca48f4f-25a0-4d55-82bd-c1341499c077"), "Dolores29@gmail.com", "Dolores", "(591) 484-4169 x0183", "Bednar" },
                    { 51, new Guid("ec9a1a73-5daf-471a-9eae-f542f41a4da3"), "Dolores.Connelly69@yahoo.com", "Dolores", "(657) 748-7216 x637", "Connelly" },
                    { 52, new Guid("56a57a28-4075-4a60-b7bf-c9390043a517"), "Rosalie.Nienow@yahoo.com", "Rosalie", "494-477-5098 x2291", "Nienow" },
                    { 53, new Guid("dccd4da5-5e05-456d-bbce-baac67f8c577"), "Violet_Will@yahoo.com", "Violet", "692-967-4949 x192", "Will" },
                    { 55, new Guid("60ef2156-b330-4067-96bb-e40aa5586cbf"), "Pam_Green@hotmail.com", "Pam", "1-211-699-5696 x6090", "Green" },
                    { 56, new Guid("b8bddacb-a49b-42f1-8112-8826930a002c"), "Calvin.Denesik@hotmail.com", "Calvin", "747.408.6872", "Denesik" },
                    { 57, new Guid("1204c624-2429-4d5f-a870-f6c90e78e588"), "Karl_Prosacco@yahoo.com", "Karl", "576.280.4134", "Prosacco" },
                    { 58, new Guid("f8286f6e-8936-4871-9662-4e3ba30112b7"), "Rachael_Schmidt97@hotmail.com", "Rachael", "788-375-7404", "Schmidt" },
                    { 59, new Guid("d915f3d8-2700-4b5d-942c-c8e57dfba1ed"), "Harold.Huel@yahoo.com", "Harold", "1-512-682-7537", "Huel" },
                    { 80, new Guid("cbbdf03d-37c3-4d29-8267-00fdedd32c27"), "Meghan_Hessel79@yahoo.com", "Meghan", "932-417-4203 x8919", "Hessel" },
                    { 60, new Guid("bae4018b-4ec9-4bad-b38c-62d38385d8a7"), "Nadine_Walsh54@gmail.com", "Nadine", "(462) 851-2035", "Walsh" },
                    { 39, new Guid("b6542c23-5f6f-493c-a9b2-1fec45c90835"), "Mike_Mante26@gmail.com", "Mike", "606.854.4150", "Mante" },
                    { 38, new Guid("1068461a-cd19-4037-8339-5ab418401134"), "Genevieve_Treutel32@yahoo.com", "Genevieve", "817-343-2600 x1451", "Treutel" },
                    { 54, new Guid("3ee538a1-7101-432a-92aa-b17b2fa97b9e"), "Chad_Swift93@gmail.com", "Chad", "419-341-1570 x132", "Swift" },
                    { 36, new Guid("48b8db3f-7fc0-41ff-9d83-197232f6687d"), "Roxanne.Bogisich85@gmail.com", "Roxanne", "1-883-736-8127 x5254", "Bogisich" },
                    { 78, new Guid("28ab49d5-183f-46d0-8c65-40f1126d901a"), "Pete.Gislason92@gmail.com", "Pete", "(606) 768-9602 x95809", "Gislason" },
                    { 37, new Guid("7cec0c6a-c984-433b-ab15-d4927ab68a7c"), "Amos74@yahoo.com", "Amos", "541.782.4424 x0644", "Baumbach" },
                    { 77, new Guid("ffef821e-074f-4b33-b380-aa5b8ab113ad"), "Cesar_Walker@yahoo.com", "Cesar", "(731) 535-7442", "Walker" },
                    { 76, new Guid("d08b4cc9-6022-4831-9145-606d277d4465"), "Jeanne_Kemmer@yahoo.com", "Jeanne", "(735) 678-7749 x034", "Kemmer" },
                    { 75, new Guid("efa71e49-5ae7-48a5-b9a0-f60110cc2f93"), "Jodi8@yahoo.com", "Jodi", "616.923.5249", "Jacobi" },
                    { 73, new Guid("bbd036b1-5d76-4af6-bfdf-a1a81fe4ed40"), "Loren.DAmore36@hotmail.com", "Loren", "1-346-988-6142", "D'Amore" },
                    { 72, new Guid("adbc3d7a-579e-4569-a6b4-50ce21a5f99b"), "Gail27@gmail.com", "Gail", "323.569.9315", "Wintheiser" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AzureId", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 71, new Guid("859035aa-7f68-42f7-8c72-92b5120b27d1"), "Lucy.Carter@hotmail.com", "Lucy", "1-264-714-4323", "Carter" },
                    { 70, new Guid("d354e073-0818-4c39-a475-f2acc7f2a345"), "Emanuel_Lakin@gmail.com", "Emanuel", "449-413-0052", "Lakin" },
                    { 69, new Guid("e276bb07-5716-486b-9a35-e3017dc50d4f"), "Kristina46@yahoo.com", "Kristina", "550.204.1160", "Satterfield" },
                    { 68, new Guid("26ee3ec2-89d7-448b-94bf-7175ef51d9ea"), "Diane19@gmail.com", "Diane", "1-734-829-3044", "Kuhn" },
                    { 74, new Guid("164cb808-44dd-4944-9cdc-36d33ca33f1a"), "Santiago_Bauch@gmail.com", "Santiago", "1-493-596-8038 x44402", "Bauch" },
                    { 66, new Guid("de8874c8-549f-47e5-a1f9-784e8f79094d"), "Dana.Walter2@yahoo.com", "Dana", "236.918.5103 x8345", "Walter" },
                    { 67, new Guid("e6d62062-db7e-434a-8646-cbadf3252081"), "Tonya_Gottlieb@gmail.com", "Tonya", "753-909-1673 x06775", "Gottlieb" },
                    { 33, new Guid("ab91f847-10a6-44b5-bee4-fe2701d47724"), "Brandon5@gmail.com", "Brandon", "506.258.9932 x8062", "Kshlerin" },
                    { 34, new Guid("7fd1ed59-5793-41e4-9168-651c89c9c6c6"), "Arnold.Langworth@hotmail.com", "Arnold", "263.914.7811", "Langworth" },
                    { 61, new Guid("8beb7d0d-65ba-40f8-92b4-d632ee757353"), "Francis.Hills48@yahoo.com", "Francis", "1-809-424-6416 x2884", "Hills" },
                    { 35, new Guid("31211c13-51a8-407c-a48e-99197abf1072"), "Tracy19@yahoo.com", "Tracy", "(204) 618-1349", "Bahringer" },
                    { 32, new Guid("ace24a44-6131-4bde-802f-6c6864f2728b"), "Annie50@gmail.com", "Annie", "911.342.6637 x7540", "Reinger" },
                    { 63, new Guid("73ce376a-c46d-4e47-8235-ca68f7e3e255"), "Krystal.Lueilwitz83@hotmail.com", "Krystal", "590-581-6904 x9008", "Lueilwitz" },
                    { 64, new Guid("523e0e77-db2e-4f2c-97e0-80434a785b8e"), "Rita11@hotmail.com", "Rita", "561-273-3065", "Wilderman" },
                    { 65, new Guid("c7fb978b-9232-447b-8149-0187b58e5004"), "Leonard_Olson@yahoo.com", "Leonard", "918.981.8571 x170", "Olson" },
                    { 62, new Guid("4e82ebaf-9b54-4188-8524-b19bd7031b6b"), "Kim17@yahoo.com", "Kim", "1-970-631-5335", "Bruen" }
                });

            migrationBuilder.InsertData(
                table: "Petsitters",
                columns: new[] { "Id", "AvailabilityFrom", "AvailabilityTo", "AzureId", "City", "Country", "Description", "Email", "Environment", "Name", "ParcelAndHouseNumbers", "PhoneNumber", "PhotoId", "Rate", "Street", "Surname", "Title", "ZipCode" },
                values: new object[,]
                {
                    { 181, new DateTime(2021, 1, 22, 22, 57, 32, 312, DateTimeKind.Local).AddTicks(9522), new DateTime(2021, 7, 29, 0, 22, 55, 577, DateTimeKind.Local).AddTicks(3021), new Guid("af397ddf-3a13-4979-82eb-51de024cbe11"), "Ernestinahaven", "Ireland", "Eum sequi cupiditate fugit debitis quia voluptate et ut incidunt consequuntur in libero consequuntur facilis repellat autem quia ducimus optio error vero facilis ab dolorem ab autem laudantium ut architecto.", "Shawn95@yahoo.com", "Eum quibusdam rerum eum neque.", "Shawn", "42765", "943.484.5810", "https://picsum.photos/640/480/?image=1052", 2.5517840392663071, "Anais Pine", "Baumbach", "Voluptatum rerum.", "73256-0111" },
                    { 179, new DateTime(2021, 1, 22, 17, 15, 45, 99, DateTimeKind.Local).AddTicks(8731), new DateTime(2022, 1, 8, 12, 58, 38, 403, DateTimeKind.Local).AddTicks(5793), new Guid("fc638a53-f748-4ed1-aed2-b000f03459a9"), "Erikafort", "Iran", "Consequuntur sed nihil sint quia voluptatem voluptatem cum quis voluptatum laborum dolores vitae saepe sit illum dignissimos ea harum quibusdam molestiae commodi nesciunt eligendi eveniet laudantium necessitatibus expedita illo quo.", "Michael99@hotmail.com", "Maxime et id fuga ducimus.", "Michael", "82522", "790-481-3744", "https://picsum.photos/640/480/?image=541", 1.2623379008203455, "Amparo Extension", "Rosenbaum", "Perferendis sit.", "54786-6090" },
                    { 178, new DateTime(2021, 1, 22, 23, 28, 16, 445, DateTimeKind.Local).AddTicks(3627), new DateTime(2021, 3, 28, 14, 58, 58, 954, DateTimeKind.Local).AddTicks(9301), new Guid("b43ba4dd-72f8-44d3-8ba4-088f16ebd2b9"), "North Martatown", "Nauru", "Et quis suscipit nisi explicabo odio dolore vel culpa nulla sint aperiam vitae quidem corrupti et sint vel asperiores accusantium officiis fugit laboriosam in et molestiae tempora labore illo eligendi.", "Olga28@gmail.com", "Consequuntur rerum omnis repudiandae ipsum.", "Olga", "7351", "668.270.3712 x0950", "https://picsum.photos/640/480/?image=76", 3.0411035148618293, "Boehm Overpass", "Quigley", "Neque velit.", "62557" },
                    { 177, new DateTime(2021, 1, 22, 15, 51, 12, 29, DateTimeKind.Local).AddTicks(6436), new DateTime(2021, 12, 28, 16, 11, 20, 128, DateTimeKind.Local).AddTicks(5450), new Guid("024fc849-0549-429b-badd-683ff5ca53fe"), "Crystaltown", "Macao", "Ratione unde impedit qui pariatur minima quis qui labore quo sed culpa eum ullam aspernatur eius esse ea a et perferendis expedita totam possimus porro ullam sunt ipsam ex delectus.", "Perry37@yahoo.com", "Sit ex corrupti beatae hic.", "Perry", "224", "693-206-1555 x40216", "https://picsum.photos/640/480/?image=426", 2.6170376882036392, "Wisoky Loaf", "Waters", "Reiciendis velit.", "51950" },
                    { 176, new DateTime(2021, 1, 23, 7, 23, 54, 606, DateTimeKind.Local).AddTicks(1598), new DateTime(2021, 7, 26, 13, 45, 2, 456, DateTimeKind.Local).AddTicks(4259), new Guid("983d9f27-8513-4324-a6ff-cc4b57bced57"), "South Jacquesfurt", "Senegal", "Et veniam aut enim voluptatem cumque nesciunt veritatis qui porro ut saepe similique atque fuga sit adipisci voluptate et qui odio enim inventore quia aliquid aut magni tempora quo autem.", "Delores13@yahoo.com", "Est nesciunt modi maiores sapiente.", "Delores", "011", "1-543-528-7013 x0615", "https://picsum.photos/640/480/?image=762", 4.1177374567453455, "Bartell Key", "Emmerich", "Provident aut.", "39845" },
                    { 175, new DateTime(2021, 1, 23, 3, 45, 42, 938, DateTimeKind.Local).AddTicks(6863), new DateTime(2021, 7, 21, 0, 16, 35, 889, DateTimeKind.Local).AddTicks(1352), new Guid("dfe032ec-3471-4fa9-aa83-d547fcc834bf"), "North Wendyside", "Central African Republic", "Et nostrum quidem quisquam aut eum qui et et tempore amet quidem dolore eum eos commodi cupiditate ad quasi reiciendis possimus qui nam et perspiciatis numquam iure sit aut atque.", "Josefina_Rogahn@yahoo.com", "Architecto voluptate et eos dolor.", "Josefina", "653", "904-556-6394 x820", "https://picsum.photos/640/480/?image=63", 2.8943823435783305, "Linwood Spurs", "Rogahn", "Voluptatum in.", "77500" },
                    { 171, new DateTime(2021, 1, 22, 23, 49, 45, 258, DateTimeKind.Local).AddTicks(5049), new DateTime(2021, 10, 6, 16, 32, 12, 924, DateTimeKind.Local).AddTicks(9281), new Guid("3983c25c-a2a1-4220-9490-e62d2ce3e9f0"), "Kassulkestad", "Zimbabwe", "Et amet dolores aut eos et est est consequatur voluptatibus recusandae rerum sunt aspernatur quia expedita aut aut nobis perspiciatis consectetur neque ut qui nemo veritatis aliquid molestiae quod animi.", "Guadalupe.Dooley68@hotmail.com", "Nam architecto excepturi quibusdam et.", "Guadalupe", "0469", "480-508-2653 x58751", "https://picsum.photos/640/480/?image=327", 3.9271837318908349, "Little Parks", "Dooley", "Sint aspernatur.", "39115-2041" },
                    { 173, new DateTime(2021, 1, 22, 14, 11, 16, 64, DateTimeKind.Local).AddTicks(8846), new DateTime(2021, 9, 26, 21, 44, 28, 659, DateTimeKind.Local).AddTicks(2680), new Guid("934b0441-05d1-4c2d-ba80-c66446074105"), "Jedbury", "Bhutan", "Repellendus velit libero nihil nostrum mollitia architecto aut odio ex ab similique laboriosam consectetur dolores quis et saepe soluta ad quibusdam neque eum nobis dolor fugiat dolore consectetur atque nesciunt.", "Debbie73@yahoo.com", "Fuga quis voluptatibus non praesentium.", "Debbie", "73979", "1-759-514-3554", "https://picsum.photos/640/480/?image=431", 2.029943775865223, "Charlene Points", "Prosacco", "Pariatur itaque.", "94457" },
                    { 172, new DateTime(2021, 1, 23, 8, 59, 14, 338, DateTimeKind.Local).AddTicks(9148), new DateTime(2021, 6, 3, 12, 44, 30, 370, DateTimeKind.Local).AddTicks(5390), new Guid("6e5826e1-1233-49d1-ae38-f788fc9e5506"), "Port Delaneyborough", "United States Minor Outlying Islands", "Cum tenetur dolorum sed voluptas ea reiciendis sunt vero amet autem sunt quaerat quod voluptates soluta aspernatur accusamus voluptatem qui vel similique deserunt dolor molestiae vero ipsum porro sint deleniti.", "Wilbur_Weissnat40@yahoo.com", "Voluptates amet quaerat ipsum vel.", "Wilbur", "3814", "542-997-6611", "https://picsum.photos/640/480/?image=229", 3.3670285858060365, "Hilll Mills", "Weissnat", "Quo odit.", "38992-5966" },
                    { 170, new DateTime(2021, 1, 22, 14, 48, 43, 310, DateTimeKind.Local).AddTicks(6553), new DateTime(2021, 11, 10, 0, 34, 12, 712, DateTimeKind.Local).AddTicks(8870), new Guid("59d622f7-4a4b-419c-bf36-a136c7846e0f"), "Haileestad", "Angola", "Recusandae quae minima ipsum tempore tempora ipsam blanditiis beatae cumque placeat nobis aperiam ut et repellendus est et minus explicabo quidem eos commodi aut optio alias illum cum non molestias.", "Angela_Hahn@hotmail.com", "Voluptatum tempore voluptate rerum cupiditate.", "Angela", "4128", "(414) 507-1472", "https://picsum.photos/640/480/?image=101", 3.2127813669912428, "Pietro Crest", "Hahn", "Soluta ipsum.", "92699-4397" },
                    { 169, new DateTime(2021, 1, 22, 17, 26, 36, 866, DateTimeKind.Local).AddTicks(3214), new DateTime(2021, 9, 6, 14, 50, 21, 109, DateTimeKind.Local).AddTicks(2467), new Guid("86d128f8-c246-47c1-96f3-9d46c99b06f0"), "Kielchester", "Sao Tome and Principe", "Qui sapiente dolore sit quo iure nobis exercitationem eum molestias similique voluptates dolores sed architecto deleniti incidunt distinctio a suscipit nulla ipsa eveniet numquam dolores quidem quo et voluptatibus sit.", "Shelly62@yahoo.com", "Aut et doloremque ab architecto.", "Shelly", "07038", "1-869-352-5878 x74508", "https://picsum.photos/640/480/?image=872", 4.0947349924103982, "Alverta Cove", "Abshire", "Necessitatibus dolor.", "13528" },
                    { 182, new DateTime(2021, 1, 22, 22, 59, 26, 68, DateTimeKind.Local).AddTicks(1284), new DateTime(2021, 10, 5, 10, 23, 3, 191, DateTimeKind.Local).AddTicks(2770), new Guid("3cd91b35-a5eb-403c-a838-b710a0b713c9"), "West Christberg", "Gambia", "Adipisci animi accusamus beatae rerum laudantium voluptatem laboriosam omnis quas consequatur autem perspiciatis laudantium reiciendis magnam voluptas ut architecto error ducimus et beatae ipsum eius quia sequi dolores vero perferendis.", "Mathew76@yahoo.com", "Enim amet atque maxime fugit.", "Mathew", "77637", "1-478-881-9849 x4451", "https://picsum.photos/640/480/?image=421", 3.1599301817640337, "Hilpert River", "Bins", "Eos fuga.", "04633-2325" },
                    { 168, new DateTime(2021, 1, 23, 6, 5, 34, 116, DateTimeKind.Local).AddTicks(7521), new DateTime(2021, 11, 21, 21, 21, 30, 930, DateTimeKind.Local).AddTicks(8214), new Guid("094819fa-9bb4-4dde-b553-de77699b5181"), "Roobside", "Belgium", "Ad et sequi voluptatem pariatur architecto et qui consequatur autem quae minus earum molestias quibusdam delectus ipsam voluptas autem ut commodi quisquam illo voluptate soluta et necessitatibus aliquid assumenda dolor.", "Ernesto.Schuppe@gmail.com", "Maxime quidem voluptatibus sit sunt.", "Ernesto", "063", "(382) 285-2392 x90102", "https://picsum.photos/640/480/?image=856", 2.8123244633024207, "Enid Curve", "Schuppe", "Iste at.", "54416-3409" },
                    { 174, new DateTime(2021, 1, 23, 6, 31, 55, 912, DateTimeKind.Local).AddTicks(6014), new DateTime(2021, 9, 27, 13, 18, 27, 126, DateTimeKind.Local).AddTicks(3626), new Guid("dd29f455-1138-419d-97fe-f731e838e67d"), "East Piper", "Rwanda", "Est dignissimos occaecati reiciendis sequi doloribus delectus necessitatibus quis ut id officia commodi autem vel accusamus pariatur nobis recusandae ipsum omnis dolores sequi sunt in ab dignissimos omnis sit sit.", "Sheldon.Hyatt@gmail.com", "Hic in aut unde consectetur.", "Sheldon", "647", "402.467.7364", "https://picsum.photos/640/480/?image=650", 1.3106872627095725, "Volkman Way", "Hyatt", "Voluptatem quis.", "01183-8428" },
                    { 183, new DateTime(2021, 1, 22, 13, 7, 30, 104, DateTimeKind.Local).AddTicks(6998), new DateTime(2021, 2, 20, 18, 8, 39, 130, DateTimeKind.Local).AddTicks(985), new Guid("21dc4c0c-373d-4934-bc8a-73b910c519e0"), "Dixieshire", "Antigua and Barbuda", "Voluptatibus voluptatibus nemo dolorum libero est deserunt aspernatur quibusdam aut occaecati voluptatem cupiditate ut perferendis velit ut praesentium non enim qui ut ut dolores consectetur laborum dolores blanditiis recusandae qui.", "Jerald.Hettinger21@yahoo.com", "Ipsum et illo ad eos.", "Jerald", "538", "484.374.7098", "https://picsum.photos/640/480/?image=1070", 3.0148862348938761, "Walter Island", "Hettinger", "Vitae odio.", "98894-8291" },
                    { 195, new DateTime(2021, 1, 22, 15, 47, 23, 3, DateTimeKind.Local).AddTicks(153), new DateTime(2021, 10, 16, 5, 57, 46, 265, DateTimeKind.Local).AddTicks(8577), new Guid("4e35e333-44c3-48cb-8b31-1ec3bce0c4b8"), "Lake Kory", "Mexico", "Aut iusto ut corrupti nostrum perferendis inventore corporis pariatur provident est sit corporis sit eveniet deleniti et libero magni ad delectus rerum debitis inventore in vel voluptas illum dolor repellat.", "Lonnie_Buckridge0@gmail.com", "Perspiciatis aperiam consequatur natus non.", "Lonnie", "198", "(245) 524-6703 x988", "https://picsum.photos/640/480/?image=635", 4.4838229154626941, "Dayton Court", "Buckridge", "Laborum nam.", "55327" },
                    { 185, new DateTime(2021, 1, 22, 21, 32, 14, 494, DateTimeKind.Local).AddTicks(3370), new DateTime(2021, 10, 31, 15, 56, 47, 303, DateTimeKind.Local).AddTicks(9230), new Guid("da50a9f7-ab2d-4179-befa-73191851edfb"), "West Jaynefort", "Isle of Man", "Natus voluptatem tenetur sunt atque neque voluptatibus est sunt adipisci saepe consequatur minima fugiat autem omnis odio nihil voluptate ipsum minus atque consequatur ut eum nostrum saepe consequuntur illum laudantium.", "Lora_Leannon66@yahoo.com", "Molestias id quod consectetur ut.", "Lora", "48256", "(890) 396-4202", "https://picsum.photos/640/480/?image=503", 4.7287452648062001, "Quigley Port", "Leannon", "Recusandae architecto.", "96190" },
                    { 167, new DateTime(2021, 1, 22, 21, 53, 26, 20, DateTimeKind.Local).AddTicks(8219), new DateTime(2021, 6, 25, 23, 38, 31, 460, DateTimeKind.Local).AddTicks(3323), new Guid("073c11b6-d923-4984-a934-c74776aacfdd"), "North Maudemouth", "Chile", "Commodi consequuntur accusamus aspernatur molestiae sed aliquid quas ut quae nulla earum quis aut voluptas eos id alias voluptates voluptatem magni autem nihil omnis incidunt enim fuga provident minima tenetur.", "Wallace.Berge78@hotmail.com", "Sequi culpa qui modi veniam.", "Wallace", "1358", "966-546-8579 x3308", "https://picsum.photos/640/480/?image=891", 3.6018634525136388, "Kyle Estates", "Berge", "Voluptatem accusamus.", "53079-0589" },
                    { 200, new DateTime(2021, 1, 23, 9, 17, 38, 581, DateTimeKind.Local).AddTicks(4209), new DateTime(2021, 6, 8, 1, 6, 35, 664, DateTimeKind.Local).AddTicks(4514), new Guid("2f6a35c9-de73-462c-9e16-52e7fb8aec1c"), "Alexandriaport", "Israel", "Ut omnis aut distinctio error quidem in quibusdam animi numquam vero fuga et facilis consectetur perspiciatis nesciunt aut ut sint in aut quis quia laudantium similique hic ducimus explicabo doloribus.", "Richard_Reinger49@yahoo.com", "Velit asperiores est consequuntur cumque.", "Richard", "7445", "545.388.2822", "https://picsum.photos/640/480/?image=552", 4.8860238249814252, "Lockman Groves", "Reinger", "Voluptatem et.", "51735-6964" },
                    { 199, new DateTime(2021, 1, 22, 13, 52, 37, 336, DateTimeKind.Local).AddTicks(7472), new DateTime(2021, 10, 6, 9, 37, 20, 197, DateTimeKind.Local).AddTicks(1706), new Guid("2b4872e3-239f-4c45-8720-a36402d62549"), "Luettgenfort", "Luxembourg", "Eaque architecto omnis inventore sit recusandae vero ratione est omnis excepturi nesciunt est et et non est quaerat pariatur dicta et suscipit eius eos rerum voluptatem sit temporibus delectus commodi.", "Melba33@yahoo.com", "Esse et sint et dolor.", "Melba", "7625", "280-877-6333 x677", "https://picsum.photos/640/480/?image=808", 4.6881120426990615, "Edwina Village", "Batz", "Vero sint.", "86172-9655" },
                    { 198, new DateTime(2021, 1, 22, 13, 53, 53, 232, DateTimeKind.Local).AddTicks(7556), new DateTime(2021, 11, 2, 11, 17, 44, 761, DateTimeKind.Local).AddTicks(2589), new Guid("a7351a68-4a1c-4045-936f-88cde9930c18"), "Sammymouth", "Greece", "Reiciendis aspernatur id dolor quia aut voluptatem repudiandae id earum minus placeat et similique nihil excepturi consequuntur minima consequatur molestiae voluptatum sed sint aspernatur unde omnis aut iusto culpa hic.", "Ella.Schroeder@gmail.com", "Ut error optio quo sit.", "Ella", "8197", "(947) 745-6708 x513", "https://picsum.photos/640/480/?image=1037", 3.2313064999092864, "Evans Passage", "Schroeder", "Qui quas.", "00690-6726" },
                    { 197, new DateTime(2021, 1, 22, 18, 29, 23, 891, DateTimeKind.Local).AddTicks(6224), new DateTime(2021, 11, 21, 3, 55, 53, 452, DateTimeKind.Local).AddTicks(1583), new Guid("532699de-08cc-42c9-ad6f-82a1d64b27a1"), "Port Garrison", "Georgia", "Praesentium rerum et repudiandae architecto numquam eos facilis blanditiis omnis aspernatur ut quis placeat ut architecto numquam perferendis est perferendis qui quaerat ullam sapiente dolorem expedita ea voluptatem quis molestiae.", "Ramon40@gmail.com", "Beatae cum sed qui totam.", "Ramon", "573", "(947) 748-5919 x278", "https://picsum.photos/640/480/?image=883", 1.8416504174664852, "Adams Fall", "Beatty", "Et eum.", "58448" },
                    { 196, new DateTime(2021, 1, 22, 22, 46, 12, 895, DateTimeKind.Local).AddTicks(9429), new DateTime(2021, 3, 7, 15, 25, 58, 836, DateTimeKind.Local).AddTicks(9095), new Guid("33fcedcf-b87d-452b-a07b-b7fe9ff9969b"), "Trantowchester", "Turkey", "Aut rem eum nulla et debitis soluta ea nihil distinctio suscipit rerum non minus eveniet magnam aut veniam modi ut cupiditate odio aliquid quaerat quia qui minima corporis eos rerum.", "Heidi1@gmail.com", "Soluta animi vel modi veritatis.", "Heidi", "92595", "1-647-303-6202 x9329", "https://picsum.photos/640/480/?image=359", 2.9518185360132803, "Winston Expressway", "Daniel", "Sunt rerum.", "25358-3037" },
                    { 194, new DateTime(2021, 1, 23, 10, 15, 22, 329, DateTimeKind.Local).AddTicks(8315), new DateTime(2021, 4, 26, 17, 44, 56, 562, DateTimeKind.Local).AddTicks(4933), new Guid("5f7523fc-6186-4842-adef-f3a2d8c5763d"), "Trinityview", "Andorra", "Non cumque porro id inventore aspernatur est autem dolores vitae voluptas et minima asperiores necessitatibus mollitia qui magnam et et mollitia at eum et explicabo eligendi sunt et nemo est.", "Cristina85@gmail.com", "Vel facilis consequatur cupiditate exercitationem.", "Cristina", "467", "825.769.1361 x55396", "https://picsum.photos/640/480/?image=1049", 3.6087812122929752, "Rempel Path", "Wiza", "Beatae accusamus.", "43382-9622" },
                    { 193, new DateTime(2021, 1, 22, 12, 42, 26, 641, DateTimeKind.Local).AddTicks(647), new DateTime(2021, 6, 10, 6, 53, 39, 190, DateTimeKind.Local).AddTicks(6980), new Guid("1eb5488a-d072-4f00-a162-11445afdfc0a"), "New June", "Faroe Islands", "Voluptatem reiciendis nam nisi tenetur nihil eaque perferendis quis vitae velit illum accusantium omnis omnis et blanditiis provident sapiente tenetur in earum eum non id officia sint repellendus dolore unde.", "Terry53@gmail.com", "Quod consequatur amet magnam voluptas.", "Terry", "7912", "553.305.0582 x225", "https://picsum.photos/640/480/?image=229", 1.3987555468449162, "Beatty Springs", "White", "Ratione eos.", "98398-8025" },
                    { 192, new DateTime(2021, 1, 23, 6, 11, 46, 784, DateTimeKind.Local).AddTicks(836), new DateTime(2021, 9, 26, 3, 37, 9, 617, DateTimeKind.Local).AddTicks(2214), new Guid("dc18767e-70dd-4e20-9295-d722120bab26"), "East Lawsonfort", "Tunisia", "Est asperiores quisquam dolores et delectus minima qui quasi nesciunt ad quia ut est et deleniti similique magnam nobis in minima nihil quia consequatur optio quae officia omnis voluptatum magni.", "Wendy_Feil@yahoo.com", "Blanditiis autem est odit earum.", "Wendy", "1478", "336-941-7893 x00711", "https://picsum.photos/640/480/?image=777", 2.2617759114418998, "Corwin Brooks", "Feil", "Ex quibusdam.", "21659-3599" }
                });

            migrationBuilder.InsertData(
                table: "Petsitters",
                columns: new[] { "Id", "AvailabilityFrom", "AvailabilityTo", "AzureId", "City", "Country", "Description", "Email", "Environment", "Name", "ParcelAndHouseNumbers", "PhoneNumber", "PhotoId", "Rate", "Street", "Surname", "Title", "ZipCode" },
                values: new object[,]
                {
                    { 191, new DateTime(2021, 1, 23, 6, 13, 25, 882, DateTimeKind.Local).AddTicks(453), new DateTime(2021, 7, 14, 2, 1, 55, 33, DateTimeKind.Local).AddTicks(6172), new Guid("7449eafe-ce5f-4dcb-86f0-e6106390864d"), "Ashlynnfort", "Lao People's Democratic Republic", "Qui cumque mollitia quasi est ab quaerat eum voluptas voluptatem fugiat ipsa ab voluptatem odio dolorem dolor aut ut facere eaque sunt et est iusto et illum adipisci enim dolore.", "Bernard_Raynor51@yahoo.com", "Sit voluptatum perferendis quae accusamus.", "Bernard", "854", "385-411-1860 x48130", "https://picsum.photos/640/480/?image=569", 1.6301303378446634, "Caroline Roads", "Raynor", "Commodi dignissimos.", "04055" },
                    { 190, new DateTime(2021, 1, 22, 21, 49, 13, 551, DateTimeKind.Local).AddTicks(1384), new DateTime(2021, 10, 7, 7, 41, 4, 822, DateTimeKind.Local).AddTicks(3108), new Guid("5fb5a5a4-217d-48b7-a570-5f8e080a4930"), "South Delfina", "Papua New Guinea", "Qui qui hic ea vel praesentium temporibus harum eos nostrum aspernatur sunt illo quia eum ipsa est sunt corrupti rerum omnis in aut aut reiciendis explicabo quod accusantium in rerum.", "Violet.Jacobi0@gmail.com", "Neque et aut deleniti ratione.", "Violet", "410", "(316) 731-3029", "https://picsum.photos/640/480/?image=68", 3.1340288045508919, "Vernon Vista", "Jacobi", "Nobis quis.", "48614" },
                    { 189, new DateTime(2021, 1, 22, 19, 1, 56, 766, DateTimeKind.Local).AddTicks(7907), new DateTime(2021, 2, 4, 14, 41, 51, 275, DateTimeKind.Local).AddTicks(8521), new Guid("3cd5195c-786a-4c53-a0bc-47dbc4f66967"), "Lake Patrick", "Fiji", "Odio earum iusto assumenda aut est quibusdam porro error nobis dolor nostrum nisi id enim est dolorem labore saepe sunt et error nesciunt dignissimos dolorem et magnam sequi est est.", "Marian81@yahoo.com", "Nihil amet debitis repellendus asperiores.", "Marian", "579", "409.854.4396", "https://picsum.photos/640/480/?image=87", 4.0648675537970238, "Herzog Plaza", "Pfeffer", "Atque totam.", "38394" },
                    { 188, new DateTime(2021, 1, 22, 13, 41, 15, 610, DateTimeKind.Local).AddTicks(1570), new DateTime(2021, 12, 3, 8, 11, 16, 214, DateTimeKind.Local).AddTicks(5443), new Guid("136b9276-45d7-4a1d-9952-427aff4f1c43"), "Gregorioland", "United Arab Emirates", "Qui magni aut vel sunt porro illo ut veritatis sapiente ut perferendis est eum delectus aliquid quia aut enim velit rerum nostrum quidem vero dolor consequatur tenetur error unde eos.", "Rochelle_Rippin@gmail.com", "At quos voluptatem animi error.", "Rochelle", "90693", "934-894-5018 x09541", "https://picsum.photos/640/480/?image=908", 1.2846613974704693, "Addie Roads", "Rippin", "Ratione repellendus.", "33609" },
                    { 187, new DateTime(2021, 1, 22, 19, 23, 59, 168, DateTimeKind.Local).AddTicks(5242), new DateTime(2021, 7, 11, 4, 9, 11, 686, DateTimeKind.Local).AddTicks(2082), new Guid("7ef26cd9-7fdf-4711-aeb6-19d7875e6eaa"), "Port Antoneside", "Uzbekistan", "Sunt eveniet illum maxime nostrum vel et tempora autem aut sed aut aspernatur nesciunt quisquam autem aliquid aut nesciunt dolore esse id accusamus quia occaecati veritatis voluptatem et laboriosam inventore.", "Kendra_Dach38@yahoo.com", "Accusantium dolores tempora tempora incidunt.", "Kendra", "33523", "(579) 981-0265 x6373", "https://picsum.photos/640/480/?image=638", 3.4562736127787614, "Collier Flat", "Dach", "Delectus ut.", "05005" },
                    { 186, new DateTime(2021, 1, 22, 19, 0, 40, 110, DateTimeKind.Local).AddTicks(1436), new DateTime(2021, 9, 17, 23, 21, 11, 59, DateTimeKind.Local).AddTicks(4475), new Guid("1e9809df-945e-4847-92ca-4675c22f1c99"), "Catherineborough", "Austria", "Dolore enim nisi maxime et dolore omnis tempora tempora qui ipsam laboriosam ab temporibus sint aut occaecati esse quo qui eaque fugit qui nesciunt velit et odio est nisi veritatis.", "Miranda_Breitenberg@gmail.com", "Voluptatum magni nobis sit suscipit.", "Miranda", "7482", "(519) 996-6170", "https://picsum.photos/640/480/?image=428", 3.7630847537718175, "Vandervort Station", "Breitenberg", "Ea qui.", "79377" },
                    { 184, new DateTime(2021, 1, 22, 18, 38, 3, 425, DateTimeKind.Local).AddTicks(1423), new DateTime(2021, 10, 24, 8, 38, 2, 449, DateTimeKind.Local).AddTicks(4864), new Guid("cbbf4d27-019d-4f07-89f6-afd6420e87a2"), "Jacquelynchester", "Tokelau", "Ex porro quibusdam aspernatur non voluptas nisi accusantium amet suscipit quasi ut id autem consequatur eos vel perspiciatis nihil ad enim id dolores facere ad sapiente eos maiores omnis sit.", "Leonard_Yost@yahoo.com", "Qui magnam et ex dolore.", "Leonard", "9051", "1-922-716-2949 x039", "https://picsum.photos/640/480/?image=540", 2.4700403294852191, "Willms Ramp", "Yost", "Modi quae.", "28202-5522" },
                    { 166, new DateTime(2021, 1, 22, 13, 21, 24, 27, DateTimeKind.Local).AddTicks(3255), new DateTime(2021, 11, 11, 16, 15, 47, 418, DateTimeKind.Local).AddTicks(527), new Guid("d702dacf-a6e0-4721-a0ba-19a122ce9bfa"), "West Eldoramouth", "Uzbekistan", "Et sint et hic sed rerum optio dolore corporis incidunt ullam at ex autem ad labore odit iste maiores eum repudiandae doloribus asperiores harum consectetur non odit architecto maiores eaque.", "Hilda87@yahoo.com", "Omnis dolorum quaerat ut consequatur.", "Hilda", "95513", "797.581.6751 x945", "https://picsum.photos/640/480/?image=454", 2.005056284836054, "Moen Wells", "Boyer", "Omnis enim.", "73452-1944" },
                    { 180, new DateTime(2021, 1, 22, 19, 34, 35, 815, DateTimeKind.Local).AddTicks(5175), new DateTime(2021, 5, 10, 16, 59, 21, 82, DateTimeKind.Local).AddTicks(2528), new Guid("b6d05006-e2fd-46c8-b3b7-66e9a9a24f7a"), "New Justice", "Haiti", "Ex id iure aut commodi at sint incidunt neque sint sint ipsam asperiores inventore et autem ut facere expedita voluptatem natus veritatis in voluptatem in architecto modi aspernatur repellat perferendis.", "Maria.Cummings@gmail.com", "Laborum nostrum harum esse ut.", "Maria", "2543", "1-646-200-3755", "https://picsum.photos/640/480/?image=800", 1.7131225116146367, "Angel Rue", "Cummings", "Quia et.", "40973-6416" },
                    { 164, new DateTime(2021, 1, 22, 16, 40, 16, 339, DateTimeKind.Local).AddTicks(3283), new DateTime(2021, 3, 14, 15, 44, 48, 116, DateTimeKind.Local).AddTicks(5846), new Guid("27577c19-6fce-4b00-aaf3-7d1930e9feed"), "Port Sharon", "Slovenia", "Nisi qui et est blanditiis voluptas aut omnis eum sit hic voluptas aliquam maiores nihil molestiae eos id qui sed totam corporis molestiae debitis laborum pariatur velit illo eveniet omnis.", "Karl.Homenick21@yahoo.com", "Ipsa delectus consectetur aperiam est.", "Karl", "17442", "1-579-729-0800", "https://picsum.photos/640/480/?image=296", 3.4463407930202505, "Bruen Corners", "Homenick", "Nesciunt quod.", "46246" },
                    { 101, new DateTime(2021, 1, 22, 13, 47, 50, 983, DateTimeKind.Local).AddTicks(2024), new DateTime(2021, 12, 19, 15, 42, 22, 936, DateTimeKind.Local).AddTicks(2128), new Guid("134dc20e-e327-4b07-8e78-068d72785456"), "Sporerborough", "Saint Barthelemy", "Voluptatum omnis sint voluptatem eum aliquam eum nisi odit consectetur veniam ab possimus et eos molestias ut sit dolor consequatur alias repudiandae quos cupiditate praesentium veniam aut dignissimos adipisci soluta.", "Salvatore_Shields75@hotmail.com", "Natus enim asperiores eos aut.", "Salvatore", "82385", "791.886.8985", "https://picsum.photos/640/480/?image=33", 4.7864191698778509, "Franecki Orchard", "Shields", "Ut facere.", "73620" },
                    { 102, new DateTime(2021, 1, 22, 19, 12, 4, 605, DateTimeKind.Local).AddTicks(3464), new DateTime(2021, 10, 28, 16, 19, 24, 759, DateTimeKind.Local).AddTicks(234), new Guid("2ae89943-1647-4f79-83d0-8d4b019782be"), "West Clarktown", "Aruba", "Ea impedit temporibus aut rerum in quo consequatur expedita occaecati quis enim debitis vel molestiae qui sit reiciendis expedita nulla ex mollitia quia delectus tenetur vel suscipit sunt suscipit ut.", "Darin_Corwin3@yahoo.com", "Voluptatem eum veritatis eos doloremque.", "Darin", "313", "1-513-917-0654", "https://picsum.photos/640/480/?image=1001", 4.3629546367390803, "Herman Ferry", "Corwin", "Officia qui.", "82928-8965" },
                    { 103, new DateTime(2021, 1, 22, 12, 50, 37, 44, DateTimeKind.Local).AddTicks(9397), new DateTime(2021, 10, 11, 13, 29, 23, 953, DateTimeKind.Local).AddTicks(8665), new Guid("277fae25-67f8-4d46-8a97-96ab379437c0"), "Blaisefort", "Rwanda", "Harum officia voluptas aut voluptas aut sint repellat ut qui vel aut non velit dolor ut omnis voluptatum non et facere fuga est unde doloremque deserunt et molestiae ea dolor.", "Katrina.Harvey93@yahoo.com", "Consequatur ut exercitationem reiciendis quia.", "Katrina", "30350", "405-747-3239 x55286", "https://picsum.photos/640/480/?image=576", 1.1952904277459209, "Conn Cliff", "Harvey", "Qui sit.", "62183" },
                    { 104, new DateTime(2021, 1, 22, 19, 39, 14, 50, DateTimeKind.Local).AddTicks(456), new DateTime(2021, 2, 22, 23, 3, 25, 336, DateTimeKind.Local).AddTicks(1666), new Guid("eacd7b40-be05-456e-8689-740b4d17f959"), "New Fabiolashire", "Azerbaijan", "Deleniti voluptates non quis autem sed inventore doloribus occaecati quos cumque aut ad amet et facere sit numquam et dicta quod qui ipsum voluptatum et molestiae quae nam dolores aut.", "Julio.Mertz@hotmail.com", "Possimus hic nesciunt qui at.", "Julio", "835", "454-398-4906", "https://picsum.photos/640/480/?image=1047", 2.0049001355678309, "Tromp Crossing", "Mertz", "Quod blanditiis.", "60217-9501" },
                    { 105, new DateTime(2021, 1, 23, 1, 23, 59, 698, DateTimeKind.Local).AddTicks(2190), new DateTime(2021, 6, 3, 3, 27, 25, 499, DateTimeKind.Local).AddTicks(9379), new Guid("132c569d-9290-4cd1-a3f5-c7ab69694e37"), "New Zanehaven", "Solomon Islands", "Nihil qui sed aliquid aut qui maiores facere vero non consequatur tenetur dolor quo aliquam ex sint qui asperiores veniam repellendus ut voluptate libero odio eligendi reiciendis aut ut doloremque.", "Hilda.OHara21@yahoo.com", "Voluptates velit voluptatum reiciendis corrupti.", "Hilda", "971", "643-523-7688", "https://picsum.photos/640/480/?image=290", 4.9892059173384711, "Hermann Tunnel", "O'Hara", "Quia provident.", "36781-9999" },
                    { 129, new DateTime(2021, 1, 23, 6, 36, 49, 936, DateTimeKind.Local).AddTicks(1539), new DateTime(2021, 10, 18, 14, 40, 30, 480, DateTimeKind.Local).AddTicks(5508), new Guid("eac01bf9-c0af-4ac9-81c3-6900a5061e41"), "South Clementine", "Lebanon", "Exercitationem harum amet enim aperiam odio distinctio ratione unde libero quia nulla sint sit praesentium labore qui sint nostrum voluptatibus consequatur voluptatem et cum illum non qui voluptatem quam eveniet.", "Bradley54@yahoo.com", "Excepturi quos molestias ullam laboriosam.", "Bradley", "603", "(514) 624-1602", "https://picsum.photos/640/480/?image=994", 2.2191681383266895, "Anderson Forges", "Hayes", "Reiciendis impedit.", "30328-4321" },
                    { 106, new DateTime(2021, 1, 22, 21, 15, 7, 589, DateTimeKind.Local).AddTicks(4669), new DateTime(2021, 6, 14, 17, 19, 43, 980, DateTimeKind.Local).AddTicks(7738), new Guid("82855766-90dd-4172-9c6c-db321b5caf5b"), "Mariahville", "Romania", "Dignissimos enim ullam quo omnis et voluptate quia et quos sequi eum eligendi officia enim possimus debitis eos repellendus totam numquam ullam aperiam laborum aut est voluptas facere eos nemo.", "Alberta.Watsica60@yahoo.com", "Est fugiat voluptatem deserunt expedita.", "Alberta", "857", "(606) 288-0303 x2554", "https://picsum.photos/640/480/?image=182", 1.1317130346464519, "Dooley Valleys", "Watsica", "Qui ad.", "41638-1822" },
                    { 107, new DateTime(2021, 1, 23, 4, 34, 22, 974, DateTimeKind.Local).AddTicks(7607), new DateTime(2021, 5, 20, 9, 4, 13, 479, DateTimeKind.Local).AddTicks(1861), new Guid("1878b221-3e6c-40a9-8cfc-9d464f14e3e2"), "East Imogene", "Cote d'Ivoire", "Repudiandae aliquam quos deleniti eos fugit aut qui consequatur quia veritatis eius dolores ut porro suscipit doloremque voluptatem quas nemo aut consequuntur neque est facere natus pariatur quis quis blanditiis.", "Joey98@yahoo.com", "Perferendis temporibus explicabo rerum qui.", "Joey", "6661", "(894) 886-8514 x5084", "https://picsum.photos/640/480/?image=249", 1.010682916273681, "Boehm Throughway", "Hane", "Saepe quod.", "86260" },
                    { 108, new DateTime(2021, 1, 23, 0, 32, 35, 399, DateTimeKind.Local).AddTicks(8498), new DateTime(2021, 7, 3, 3, 40, 14, 614, DateTimeKind.Local).AddTicks(2643), new Guid("54cddca3-a09e-4a38-bcc3-73d339a28320"), "Larkinbury", "Honduras", "Aut amet ea illo ut eius atque dolores voluptas rem minima nihil quam incidunt dolor amet inventore atque laboriosam rerum sint vel animi qui quidem quod accusantium non non doloremque.", "Pauline_Mertz@yahoo.com", "Dolorum magni adipisci officia culpa.", "Pauline", "949", "(889) 729-5870 x3194", "https://picsum.photos/640/480/?image=849", 3.3751218013349558, "Lilla Keys", "Mertz", "Nihil corporis.", "17780" },
                    { 109, new DateTime(2021, 1, 22, 21, 23, 32, 656, DateTimeKind.Local).AddTicks(2914), new DateTime(2021, 4, 7, 15, 52, 9, 657, DateTimeKind.Local).AddTicks(5122), new Guid("c1a935e7-01ac-4105-b705-5a7b76fdbcc7"), "West Joel", "Suriname", "Ut placeat sed sed pariatur eaque voluptas pariatur perspiciatis fugiat sunt ullam eveniet quibusdam nisi deleniti tempora dolorem expedita praesentium quia ad vel omnis possimus sit ex fugit nihil necessitatibus.", "Ian.Dickens52@gmail.com", "Similique omnis fugiat soluta numquam.", "Ian", "852", "684.868.0766", "https://picsum.photos/640/480/?image=1014", 1.214291310037622, "Kunde Skyway", "Dickens", "Optio itaque.", "07221-2883" },
                    { 110, new DateTime(2021, 1, 22, 22, 20, 17, 542, DateTimeKind.Local).AddTicks(6726), new DateTime(2022, 1, 3, 13, 48, 16, 827, DateTimeKind.Local).AddTicks(4957), new Guid("331e5103-8702-4935-a190-8c537c84a069"), "Nitzscheland", "Portugal", "Exercitationem sint sequi et eos voluptatem facere non fugit neque voluptatem dolorem at non porro et cupiditate quia commodi error qui quidem rerum officiis odit exercitationem perferendis quam velit sunt.", "Lyle9@gmail.com", "Expedita et veniam dolores voluptas.", "Lyle", "80948", "(502) 458-0285", "https://picsum.photos/640/480/?image=237", 2.1432090313840702, "Mosciski Valleys", "Tromp", "Cupiditate molestias.", "07775" },
                    { 111, new DateTime(2021, 1, 22, 20, 23, 41, 676, DateTimeKind.Local).AddTicks(9488), new DateTime(2021, 10, 22, 3, 26, 33, 698, DateTimeKind.Local).AddTicks(1435), new Guid("b321c2b0-a946-48ea-bc02-2c7147752945"), "Hickleborough", "Algeria", "Voluptatem ducimus laudantium molestiae voluptas quae sed amet dicta dolores tenetur quis enim est in sit quia consectetur dolore aspernatur modi iure cumque qui dolorem sint natus molestiae laboriosam nulla.", "Floyd86@yahoo.com", "Vel atque est pariatur labore.", "Floyd", "07327", "(408) 678-3528 x486", "https://picsum.photos/640/480/?image=970", 3.5716937289441439, "Ludie Expressway", "Renner", "Facilis possimus.", "01946-0291" },
                    { 112, new DateTime(2021, 1, 23, 9, 8, 10, 870, DateTimeKind.Local).AddTicks(7890), new DateTime(2021, 3, 5, 22, 13, 53, 423, DateTimeKind.Local).AddTicks(5583), new Guid("fb5bd193-2e04-47b8-9098-13bdb4b81be3"), "Lake Ottisville", "Saint Barthelemy", "Tempora totam totam unde odit illo dicta ab totam eaque cum iste alias debitis commodi et at error tempore blanditiis qui deserunt est ut dolor sit cupiditate voluptatem ipsa possimus.", "Brenda_Abshire48@yahoo.com", "Quidem quod velit consequatur dicta.", "Brenda", "2517", "(850) 223-6973 x74852", "https://picsum.photos/640/480/?image=212", 2.3874170358234164, "Beatty Circles", "Abshire", "Atque libero.", "93826" },
                    { 113, new DateTime(2021, 1, 23, 5, 38, 49, 550, DateTimeKind.Local).AddTicks(2046), new DateTime(2021, 8, 31, 0, 54, 30, 814, DateTimeKind.Local).AddTicks(8444), new Guid("e48c1e2f-2d7b-4e8d-a9a9-bfc33d8eeb54"), "South Karineton", "Togo", "Possimus error perferendis corporis mollitia harum dignissimos quis nulla aut ut est explicabo maxime nesciunt repellat sit similique et unde qui assumenda esse porro doloremque dolores deleniti et sapiente quos.", "Elena.Altenwerth47@yahoo.com", "Voluptatem ullam enim aspernatur voluptatem.", "Elena", "67347", "987-738-1262 x409", "https://picsum.photos/640/480/?image=570", 4.955973893383506, "Rodrigo Flat", "Altenwerth", "Accusantium maiores.", "80319" },
                    { 115, new DateTime(2021, 1, 23, 8, 38, 27, 207, DateTimeKind.Local).AddTicks(2919), new DateTime(2021, 6, 24, 14, 8, 46, 416, DateTimeKind.Local).AddTicks(3979), new Guid("a709610a-a183-4153-ac6f-1ac0badb401e"), "Lakinhaven", "Brazil", "Et iure quo eveniet molestias alias dolores inventore accusantium sint minima commodi incidunt qui et expedita sed dolorem qui atque aut cum ut perferendis eveniet quis in accusamus consequuntur odio.", "Dustin_Zboncak@gmail.com", "Modi id et recusandae officia.", "Dustin", "15493", "(414) 470-8418", "https://picsum.photos/640/480/?image=461", 3.320746003799488, "Stokes Villages", "Zboncak", "Qui alias.", "67418-2675" },
                    { 116, new DateTime(2021, 1, 22, 13, 44, 1, 938, DateTimeKind.Local).AddTicks(4643), new DateTime(2021, 3, 16, 17, 58, 3, 869, DateTimeKind.Local).AddTicks(8418), new Guid("0d78178e-3dd4-41ce-bfe2-944e573554d6"), "Port Enrique", "Mayotte", "Sed vitae consectetur sit placeat qui repellat sit sit earum nulla minima et qui corporis soluta minima ut sunt voluptatem ut itaque autem consequatur blanditiis inventore quis porro reiciendis rerum.", "Neil11@gmail.com", "Amet qui est ducimus minima.", "Neil", "655", "(482) 208-7623", "https://picsum.photos/640/480/?image=668", 3.3084244831970078, "Amos Fort", "Stiedemann", "Animi impedit.", "88311-2085" },
                    { 117, new DateTime(2021, 1, 23, 5, 17, 28, 954, DateTimeKind.Local).AddTicks(5654), new DateTime(2021, 9, 27, 2, 19, 26, 415, DateTimeKind.Local).AddTicks(4813), new Guid("c02bbe6b-df6f-4e2a-8fff-dac6f8dd3c30"), "Rosariotown", "Oman", "Quis rerum ut esse aliquam et sint et quos reprehenderit adipisci autem veniam consectetur dolores similique molestias eos facere quo fugit odit enim rerum cupiditate enim illum officiis dolores suscipit.", "Gregory.Hansen86@hotmail.com", "Maiores laborum quae atque nesciunt.", "Gregory", "58661", "(346) 228-1604 x0701", "https://picsum.photos/640/480/?image=742", 4.012245438533018, "Dimitri Place", "Hansen", "Tenetur saepe.", "65067-7082" },
                    { 118, new DateTime(2021, 1, 22, 18, 7, 10, 489, DateTimeKind.Local).AddTicks(1329), new DateTime(2021, 5, 1, 8, 7, 50, 608, DateTimeKind.Local).AddTicks(2058), new Guid("59b737db-dc0d-40a1-95f0-3f0a9cb973f8"), "East Otho", "El Salvador", "Esse enim ut adipisci voluptas voluptate commodi cupiditate non omnis laborum animi hic ut asperiores perspiciatis nostrum aut quaerat assumenda autem nobis ipsa beatae voluptas et consequatur pariatur autem et.", "Eunice58@gmail.com", "Cum mollitia sint voluptatem mollitia.", "Eunice", "34497", "411.913.2831", "https://picsum.photos/640/480/?image=542", 4.1611776850936835, "Ward Hill", "White", "Necessitatibus et.", "32329-6920" },
                    { 119, new DateTime(2021, 1, 23, 4, 23, 31, 723, DateTimeKind.Local).AddTicks(7630), new DateTime(2021, 10, 17, 2, 20, 10, 620, DateTimeKind.Local).AddTicks(6335), new Guid("698d7064-ec53-4bb7-97fa-be64403abd68"), "Sipesborough", "Palau", "Consectetur illo tempore voluptates non eum animi aut ab aperiam porro voluptates sit odio tempora officiis ut ut dolorem distinctio accusantium totam eaque quasi rerum impedit nulla sed voluptate corrupti.", "Alexander_Hodkiewicz75@gmail.com", "Animi ut quas maiores veritatis.", "Alexander", "212", "502.858.6622 x99474", "https://picsum.photos/640/480/?image=1013", 3.6106260635939549, "Hermiston Hollow", "Hodkiewicz", "Quisquam perferendis.", "31144-5891" },
                    { 120, new DateTime(2021, 1, 22, 16, 35, 54, 412, DateTimeKind.Local).AddTicks(5393), new DateTime(2021, 12, 19, 3, 30, 46, 683, DateTimeKind.Local).AddTicks(4435), new Guid("1cab8137-3935-49d7-b75a-a6bf24ac673d"), "Bruenchester", "Maldives", "Non repellendus illo laboriosam officiis eius nam enim eos animi ut aut est minus earum eligendi tempore tempore rerum itaque enim tempora aspernatur odio sint et eum sit error adipisci.", "Leona_Brakus@yahoo.com", "Ullam nobis et dolorem quis.", "Leona", "76032", "1-922-937-4322", "https://picsum.photos/640/480/?image=961", 1.685794461837874, "Marlee Passage", "Brakus", "Velit soluta.", "14062" },
                    { 121, new DateTime(2021, 1, 23, 10, 33, 23, 721, DateTimeKind.Local).AddTicks(2762), new DateTime(2021, 8, 31, 10, 31, 21, 454, DateTimeKind.Local).AddTicks(6702), new Guid("96679064-e55b-4ab5-b183-30396c178624"), "North Elainaside", "Lao People's Democratic Republic", "Reprehenderit est exercitationem ex velit officiis recusandae mollitia minima tempora hic quia nisi vel quis distinctio nobis et sunt doloribus quo earum impedit omnis quod non quia quod quis qui.", "Mathew.Rodriguez41@yahoo.com", "Qui sit occaecati laborum sed.", "Mathew", "3613", "1-903-904-2900 x08701", "https://picsum.photos/640/480/?image=351", 2.3071758660055584, "Altenwerth Isle", "Rodriguez", "Reprehenderit culpa.", "27538" },
                    { 122, new DateTime(2021, 1, 23, 5, 15, 2, 124, DateTimeKind.Local).AddTicks(8993), new DateTime(2021, 9, 21, 15, 20, 35, 188, DateTimeKind.Local).AddTicks(2773), new Guid("4004e84b-2974-4a3d-a44a-f8d4d9e03160"), "East Anibal", "Saint Pierre and Miquelon", "Qui neque sed est voluptatem rerum ut omnis qui voluptates quaerat velit quis dignissimos reiciendis vel ad aut nihil pariatur est sit blanditiis fugit id facere sunt enim libero accusamus.", "Annie.Hagenes@yahoo.com", "In nihil quam eaque qui.", "Annie", "60918", "875-434-9688", "https://picsum.photos/640/480/?image=551", 2.3861498727398693, "Orn Meadows", "Hagenes", "Corrupti temporibus.", "33485" },
                    { 123, new DateTime(2021, 1, 23, 3, 24, 43, 186, DateTimeKind.Local).AddTicks(8863), new DateTime(2021, 2, 10, 9, 34, 9, 62, DateTimeKind.Local).AddTicks(5669), new Guid("5fb10d30-f5eb-47a3-bf68-642b438f3843"), "Port Ameliaview", "Australia", "Pariatur voluptas velit sint voluptatum autem est dolore eos architecto repudiandae sunt accusantium eius aut rerum inventore voluptatibus laboriosam officia ea similique voluptatem iste error eum quas error non officiis.", "Sherri_Botsford@gmail.com", "Laudantium minima est at tenetur.", "Sherri", "774", "933-574-2179 x5266", "https://picsum.photos/640/480/?image=167", 3.4707597915412669, "Liam Cliffs", "Botsford", "Voluptas omnis.", "07212" },
                    { 124, new DateTime(2021, 1, 22, 22, 2, 37, 205, DateTimeKind.Local).AddTicks(616), new DateTime(2021, 8, 26, 17, 54, 45, 210, DateTimeKind.Local).AddTicks(3249), new Guid("ed4bd193-3333-4c3b-bd8a-e0ebe9404470"), "Schmitthaven", "Eritrea", "Adipisci quaerat nulla alias assumenda aspernatur voluptatum eos earum debitis quibusdam voluptatum vero voluptatem repellat dolorem modi eaque nesciunt accusantium voluptatibus consequatur quisquam et sit enim adipisci maiores corrupti sit.", "Cristina_Baumbach@yahoo.com", "Ea est consectetur sed ut.", "Cristina", "480", "690.808.3625", "https://picsum.photos/640/480/?image=416", 2.7678244494683222, "Eudora Mount", "Baumbach", "Excepturi ducimus.", "61857" },
                    { 125, new DateTime(2021, 1, 23, 0, 58, 46, 462, DateTimeKind.Local).AddTicks(9505), new DateTime(2021, 6, 8, 10, 14, 12, 598, DateTimeKind.Local).AddTicks(774), new Guid("55769e83-0db3-4731-885d-43b9db83ab7d"), "Lennyshire", "Bhutan", "Ut eos rem veniam et autem nisi nobis veniam rerum porro eum quo officiis omnis consequatur dolores rerum nisi voluptatem veniam perferendis illum dolores voluptates aut delectus et excepturi amet.", "Jo75@yahoo.com", "Quia voluptatum sit ipsa aut.", "Jo", "270", "439-663-5665 x9597", "https://picsum.photos/640/480/?image=53", 1.7296880785048419, "Waelchi Lock", "Turner", "Cum inventore.", "50931" },
                    { 126, new DateTime(2021, 1, 23, 2, 6, 58, 787, DateTimeKind.Local).AddTicks(2247), new DateTime(2021, 5, 14, 20, 23, 21, 331, DateTimeKind.Local).AddTicks(4743), new Guid("61204ef9-afc7-4493-8cbe-e7ba8fda4853"), "Lake Suzanne", "Niger", "Delectus et error et aut laudantium placeat dolores tempore recusandae magni amet aut laboriosam accusantium eos aut corrupti natus eaque vel a et neque repellat adipisci autem sed enim qui.", "Wendell93@hotmail.com", "Quia consequatur odio in voluptates.", "Wendell", "9862", "1-790-647-5598 x408", "https://picsum.photos/640/480/?image=150", 3.7476841578016451, "Daniella Ridges", "Jenkins", "Ea quae.", "60931" },
                    { 127, new DateTime(2021, 1, 23, 5, 26, 13, 558, DateTimeKind.Local).AddTicks(4418), new DateTime(2021, 7, 17, 6, 4, 45, 332, DateTimeKind.Local).AddTicks(9506), new Guid("3c7c1952-d82b-4ddb-9e06-f9ca8d2c9755"), "Braunville", "Monaco", "Odio non corporis rem porro autem minus iste et illum dolorum suscipit deleniti aut minima inventore adipisci sapiente sed delectus eum et dolor saepe quam est at natus rerum tenetur.", "Maggie79@gmail.com", "Velit aliquid voluptate illo rerum.", "Maggie", "38522", "759.410.0864 x548", "https://picsum.photos/640/480/?image=684", 1.3429399506854545, "Catharine Key", "Murray", "Quia sapiente.", "53984" },
                    { 128, new DateTime(2021, 1, 22, 16, 6, 3, 299, DateTimeKind.Local).AddTicks(215), new DateTime(2021, 5, 6, 3, 33, 13, 946, DateTimeKind.Local).AddTicks(2957), new Guid("01702c59-8cda-4518-ac65-a3a4861c443f"), "Lake Francisco", "Poland", "Animi quae sed hic tempore iure et nihil sed quia autem eveniet praesentium molestiae magni ipsam eum voluptatem labore quo sit voluptatem assumenda et quia explicabo ut doloribus sint sint.", "Jacqueline.Orn99@hotmail.com", "Et culpa sequi officiis amet.", "Jacqueline", "4991", "(409) 631-8903 x8339", "https://picsum.photos/640/480/?image=941", 3.9958222336116349, "Sherwood Unions", "Orn", "Minima nihil.", "13887-8846" },
                    { 165, new DateTime(2021, 1, 23, 11, 15, 38, 924, DateTimeKind.Local).AddTicks(184), new DateTime(2021, 12, 7, 5, 52, 29, 36, DateTimeKind.Local).AddTicks(8667), new Guid("562aed92-909d-48e7-af1c-3cb63f3f7b81"), "East Idellatown", "Mozambique", "Enim sed voluptatum at dolores et ad consequatur in iusto deserunt ullam qui molestiae voluptatem et rerum molestias odit inventore qui aliquam dolore possimus ipsam est rem culpa id quia.", "Mack_Thompson@yahoo.com", "Ea accusantium optio sed architecto.", "Mack", "3719", "(703) 230-6740 x14271", "https://picsum.photos/640/480/?image=614", 2.2718012376091448, "Daryl Crossing", "Thompson", "Porro sed.", "25248-7193" },
                    { 130, new DateTime(2021, 1, 22, 20, 49, 8, 215, DateTimeKind.Local).AddTicks(4213), new DateTime(2021, 6, 30, 23, 26, 49, 80, DateTimeKind.Local).AddTicks(3456), new Guid("0377cb31-cdd6-472c-a40c-d9f1a2e2247c"), "Bricechester", "Iraq", "Dolore et fuga in est aliquid ex facilis id quidem ut laboriosam ratione eos dolores facere quasi eligendi earum ab et perspiciatis blanditiis ea inventore libero veniam quod itaque saepe.", "Angie.Romaguera14@gmail.com", "Rerum cumque ipsa modi sint.", "Angie", "9161", "235-976-0174", "https://picsum.photos/640/480/?image=837", 3.289245830052181, "Natalia Canyon", "Romaguera", "Et quia.", "35317" },
                    { 131, new DateTime(2021, 1, 22, 18, 20, 48, 228, DateTimeKind.Local).AddTicks(1689), new DateTime(2021, 11, 1, 22, 59, 6, 3, DateTimeKind.Local).AddTicks(9539), new Guid("40d7da79-57b7-4c75-8409-d5e8e931a33a"), "Kossberg", "Iceland", "Rerum totam tempore repudiandae rerum quisquam libero nam et nostrum soluta omnis voluptas dolor quisquam temporibus qui sequi odio mollitia porro fugit illo recusandae sit sint quam velit est reiciendis.", "Rebecca_Moore43@hotmail.com", "Eveniet est ullam quaerat inventore.", "Rebecca", "1786", "830.518.7453 x3236", "https://picsum.photos/640/480/?image=310", 1.3218759914496336, "Camille Fords", "Moore", "Esse id.", "28385-7245" },
                    { 114, new DateTime(2021, 1, 22, 23, 17, 36, 217, DateTimeKind.Local).AddTicks(2895), new DateTime(2021, 11, 5, 17, 44, 36, 236, DateTimeKind.Local).AddTicks(137), new Guid("c3d35ab1-db88-456a-a997-cebe390c21b6"), "East Murrayview", "Albania", "Eius quam voluptatem quidem accusantium voluptate consequatur sit nam eum exercitationem aperiam id voluptate eum laborum saepe in laudantium totam excepturi ut nemo rerum dolorem et beatae sit consectetur non.", "Terri.Herman@gmail.com", "Accusamus fugit dolorum totam mollitia.", "Terri", "6320", "836.232.4079 x6578", "https://picsum.photos/640/480/?image=671", 1.4556097241377504, "Manley Landing", "Herman", "Odit nam.", "13425" }
                });

            migrationBuilder.InsertData(
                table: "Petsitters",
                columns: new[] { "Id", "AvailabilityFrom", "AvailabilityTo", "AzureId", "City", "Country", "Description", "Email", "Environment", "Name", "ParcelAndHouseNumbers", "PhoneNumber", "PhotoId", "Rate", "Street", "Surname", "Title", "ZipCode" },
                values: new object[,]
                {
                    { 133, new DateTime(2021, 1, 23, 5, 52, 24, 734, DateTimeKind.Local).AddTicks(5871), new DateTime(2021, 4, 2, 22, 17, 44, 739, DateTimeKind.Local).AddTicks(6758), new Guid("bd4dd1d8-d669-416f-887d-fa59682370a9"), "West Jordan", "Turkmenistan", "Ea delectus porro est soluta cum voluptatem ratione quis temporibus officiis officiis animi non praesentium cupiditate rem et facere aut dolorem voluptatem earum numquam dolorum deserunt error reprehenderit saepe et.", "Jo.Marquardt@hotmail.com", "Et odit dicta aut accusamus.", "Jo", "242", "432.587.4979 x68648", "https://picsum.photos/640/480/?image=429", 4.6973998992226083, "Kyler Dam", "Marquardt", "Explicabo voluptatem.", "56459-0825" },
                    { 163, new DateTime(2021, 1, 23, 10, 31, 56, 637, DateTimeKind.Local).AddTicks(253), new DateTime(2021, 9, 5, 2, 27, 23, 606, DateTimeKind.Local).AddTicks(2544), new Guid("69bfcf36-f11a-47a5-b0ed-a2596669d34e"), "West Carrieborough", "Canada", "Cumque nemo natus quisquam qui magnam neque minus voluptatem deserunt labore debitis perspiciatis ratione ab ex maiores consequuntur consectetur earum eaque impedit voluptatem rerum dolorem repellat debitis velit qui necessitatibus.", "Maureen.Bauch@yahoo.com", "Quis sapiente officia magni nesciunt.", "Maureen", "55185", "1-518-758-6817", "https://picsum.photos/640/480/?image=471", 4.9633775744416653, "Richie Curve", "Bauch", "Iste qui.", "73128-9324" },
                    { 132, new DateTime(2021, 1, 22, 20, 20, 5, 315, DateTimeKind.Local).AddTicks(3858), new DateTime(2021, 8, 27, 11, 20, 44, 224, DateTimeKind.Local).AddTicks(2343), new Guid("23488cf4-9af2-493d-973e-c6e6ee56442b"), "Davonview", "Saint Pierre and Miquelon", "Fugiat ab iusto dolorum amet consectetur sed a molestias aut quis enim libero qui quidem aut modi nobis quasi voluptates eos aut vero ipsam id eaque sapiente at suscipit aut.", "Patricia_Stracke73@yahoo.com", "Sed rerum ratione tempora soluta.", "Patricia", "510", "(406) 808-6357", "https://picsum.photos/640/480/?image=582", 3.4941804495147339, "Magnus Alley", "Stracke", "Minus consectetur.", "15847-1080" },
                    { 162, new DateTime(2021, 1, 23, 1, 46, 38, 358, DateTimeKind.Local).AddTicks(4039), new DateTime(2021, 10, 13, 17, 23, 31, 567, DateTimeKind.Local).AddTicks(1074), new Guid("f0e525e3-616a-4905-b256-31999476f5b2"), "North Monty", "Guernsey", "Architecto id numquam quo dolores aliquam dicta facere repellendus sequi et aut est dicta nostrum id consectetur doloribus dolores minus molestias nam sit maiores ut molestias unde ducimus eos voluptatum.", "Melissa48@hotmail.com", "Maiores impedit rerum necessitatibus nemo.", "Melissa", "82091", "(274) 629-1294 x2203", "https://picsum.photos/640/480/?image=377", 4.9265146478668385, "Dino Fork", "Davis", "Tempora ducimus.", "55369-0842" },
                    { 160, new DateTime(2021, 1, 23, 1, 24, 20, 290, DateTimeKind.Local).AddTicks(5909), new DateTime(2021, 2, 21, 20, 16, 18, 682, DateTimeKind.Local).AddTicks(6048), new Guid("18b4a4c1-4552-4b9b-8a66-e66447c7d945"), "Bartellchester", "Grenada", "Consequuntur quia blanditiis et deleniti ut doloribus perferendis reprehenderit odio sit laborum ab sit perferendis sit fugiat inventore quia et commodi doloremque fuga sit omnis occaecati ea sunt repellendus laudantium.", "Eileen.Wolff68@gmail.com", "Voluptatem aspernatur culpa quia totam.", "Eileen", "5941", "249.481.9694 x441", "https://picsum.photos/640/480/?image=400", 4.5152095982410057, "Dorris Mill", "Wolff", "In quo.", "27325" },
                    { 159, new DateTime(2021, 1, 22, 16, 15, 34, 669, DateTimeKind.Local).AddTicks(7615), new DateTime(2022, 1, 8, 21, 6, 39, 190, DateTimeKind.Local).AddTicks(1307), new Guid("bd6be90e-be47-4d9e-b48d-454ef9d2cf74"), "Abelardoberg", "Nicaragua", "Corporis nobis dolorum eaque enim ipsa necessitatibus nostrum enim laborum animi cumque commodi corporis rerum ducimus optio earum natus rerum error nisi eos voluptas est nihil est et omnis porro.", "Chris37@gmail.com", "Ipsam est aliquid maiores provident.", "Chris", "9249", "(814) 734-9902 x5118", "https://picsum.photos/640/480/?image=223", 3.2485464840422136, "Marquis Mount", "Paucek", "Unde at.", "57427-0676" },
                    { 158, new DateTime(2021, 1, 22, 13, 40, 19, 825, DateTimeKind.Local).AddTicks(1377), new DateTime(2021, 3, 14, 23, 27, 4, 429, DateTimeKind.Local).AddTicks(8985), new Guid("c030f17e-58fc-4df7-ba1c-c7c1c3b50eda"), "Jamarcusstad", "Tajikistan", "Iste nulla nulla aut alias ea consequuntur in ea assumenda aut voluptatem tempora qui consequuntur ullam corrupti perferendis quibusdam et et facilis nihil possimus nobis voluptas quo aliquid voluptatem facere.", "Shirley.Wilderman@gmail.com", "Cum occaecati omnis beatae est.", "Shirley", "18899", "544.695.1140", "https://picsum.photos/640/480/?image=688", 2.6333784114724859, "Alexandrea Corner", "Wilderman", "Sunt molestiae.", "05849-4853" },
                    { 157, new DateTime(2021, 1, 22, 21, 33, 21, 499, DateTimeKind.Local).AddTicks(9510), new DateTime(2021, 9, 22, 12, 19, 43, 823, DateTimeKind.Local).AddTicks(9462), new Guid("63ece9cd-7f2a-478f-8c36-be629ec36d61"), "Colinton", "Haiti", "Suscipit cum officiis ab omnis nihil voluptatem similique saepe mollitia voluptas ex distinctio labore dolore molestiae nam rerum eum voluptatibus esse id sit totam et animi expedita explicabo et id.", "Norma.Lindgren@gmail.com", "Minus expedita voluptate aut quia.", "Norma", "58492", "810-230-7555 x91940", "https://picsum.photos/640/480/?image=862", 4.4656782259539138, "Bartell Well", "Lindgren", "Omnis et.", "81410" },
                    { 156, new DateTime(2021, 1, 23, 8, 13, 41, 9, DateTimeKind.Local).AddTicks(6263), new DateTime(2021, 7, 2, 4, 11, 35, 797, DateTimeKind.Local).AddTicks(6808), new Guid("fd64b000-7fab-44f2-8722-7ec492c629fa"), "Bergehaven", "Macao", "Placeat amet et quas aut beatae sed aut dolores quae aut id doloribus sint non quasi quaerat ut voluptatem rerum minima saepe nihil maiores corrupti ut quasi aliquid quis nemo.", "Ernestine71@gmail.com", "Beatae sit officiis consequatur at.", "Ernestine", "181", "1-899-627-3975", "https://picsum.photos/640/480/?image=546", 3.7534331301010369, "Kerluke Island", "Bahringer", "At atque.", "75912-2877" },
                    { 155, new DateTime(2021, 1, 22, 22, 41, 48, 907, DateTimeKind.Local).AddTicks(2227), new DateTime(2021, 4, 24, 1, 37, 32, 177, DateTimeKind.Local).AddTicks(2602), new Guid("02649f46-ad4d-49e2-afec-743c48ca32d0"), "Port Glenberg", "Mozambique", "Aut in rerum et pariatur consequuntur vel quidem fugiat minus reprehenderit nihil est provident repudiandae molestiae magni id neque culpa pariatur accusamus ratione facere aut tenetur fugit ad qui vel.", "Carlos_Gaylord69@hotmail.com", "Aliquam rerum inventore saepe perferendis.", "Carlos", "08292", "(595) 313-6158", "https://picsum.photos/640/480/?image=238", 1.2817259581208815, "Schmidt Flat", "Gaylord", "Pariatur recusandae.", "06152" },
                    { 154, new DateTime(2021, 1, 22, 18, 20, 39, 717, DateTimeKind.Local).AddTicks(6084), new DateTime(2021, 7, 18, 3, 17, 59, 666, DateTimeKind.Local).AddTicks(7927), new Guid("2114fe79-e6ee-482e-9fc6-ab51f78dd9c4"), "West Preston", "Kazakhstan", "Aut iure sint officia provident enim qui aut distinctio eaque et consequatur ut nesciunt adipisci recusandae voluptatem est doloribus sint fugit rerum et et ex quis sit ullam qui cumque.", "Howard.Ruecker@gmail.com", "Eos aperiam consequuntur qui perferendis.", "Howard", "409", "1-431-217-9539 x5032", "https://picsum.photos/640/480/?image=820", 2.7838199761620817, "Pollich Ports", "Ruecker", "Voluptatem fugit.", "51785" },
                    { 153, new DateTime(2021, 1, 22, 17, 48, 42, 227, DateTimeKind.Local).AddTicks(2137), new DateTime(2021, 5, 21, 20, 7, 57, 176, DateTimeKind.Local).AddTicks(6314), new Guid("a5ab6ccb-b60f-4a51-84df-584d8097edcc"), "Christianshire", "Tajikistan", "Tempore minima atque sed dolorum amet in distinctio culpa incidunt distinctio nisi quia tempore voluptatibus hic illo ut ipsum harum enim a quae vel placeat praesentium nihil illo aspernatur ut.", "Jeffery76@yahoo.com", "Cum dolores porro incidunt odit.", "Jeffery", "275", "847.836.6144 x4008", "https://picsum.photos/640/480/?image=774", 4.9589294530260046, "Kaycee Fall", "Hahn", "Consequatur voluptatum.", "21834" },
                    { 152, new DateTime(2021, 1, 23, 7, 23, 11, 629, DateTimeKind.Local).AddTicks(4961), new DateTime(2021, 6, 2, 22, 50, 16, 770, DateTimeKind.Local).AddTicks(1751), new Guid("f8e4ab51-2410-4180-8120-518a5a8de1a2"), "Feestville", "Djibouti", "Est hic veritatis repudiandae ut est blanditiis qui et quae commodi consequatur est recusandae ullam eos doloremque fugiat facere doloremque omnis aut occaecati occaecati pariatur assumenda consectetur laboriosam ut similique.", "Juanita13@hotmail.com", "Ut et culpa dolores sed.", "Juanita", "552", "1-557-909-3275 x80210", "https://picsum.photos/640/480/?image=798", 4.8111566714063088, "Assunta Inlet", "Monahan", "Culpa molestiae.", "20840-5181" },
                    { 151, new DateTime(2021, 1, 23, 1, 57, 5, 3, DateTimeKind.Local).AddTicks(5235), new DateTime(2021, 6, 9, 5, 36, 16, 168, DateTimeKind.Local).AddTicks(8516), new Guid("710f6408-4a75-4bc0-8edb-b917d77baff8"), "South Libby", "Liechtenstein", "Est maxime vero eos sit ea eos rerum minus quidem ea expedita eos temporibus libero repellendus labore dicta nostrum ea et tenetur nihil modi nobis soluta provident provident et laudantium.", "Andy_Pagac2@yahoo.com", "Harum dolor est eum est.", "Andy", "256", "1-225-821-2687", "https://picsum.photos/640/480/?image=28", 3.2863920825935864, "Champlin Walk", "Pagac", "Id ipsa.", "58696-5166" },
                    { 150, new DateTime(2021, 1, 22, 12, 52, 41, 900, DateTimeKind.Local).AddTicks(6888), new DateTime(2021, 10, 11, 7, 24, 37, 226, DateTimeKind.Local).AddTicks(1609), new Guid("08212555-71ae-4686-9bb1-5370da20bf42"), "South Andre", "Jersey", "Eligendi necessitatibus placeat in enim dignissimos porro mollitia nemo iusto commodi suscipit suscipit omnis possimus aspernatur dolorem dolorem dolorem suscipit similique quis dolor voluptatem a nihil voluptas enim natus perspiciatis.", "Roberto_Schmidt37@gmail.com", "Nemo consequatur voluptate impedit est.", "Roberto", "057", "564-878-5891", "https://picsum.photos/640/480/?image=141", 4.0726367063227276, "Stokes Way", "Schmidt", "Quam eos.", "19309" },
                    { 149, new DateTime(2021, 1, 23, 7, 51, 33, 723, DateTimeKind.Local).AddTicks(9045), new DateTime(2021, 12, 2, 0, 34, 57, 524, DateTimeKind.Local).AddTicks(4831), new Guid("51a6440e-8744-4d27-bc01-96818525608b"), "Amiyaberg", "Cyprus", "Quia provident impedit et veniam accusantium eos in sunt ab dolores occaecati ipsa sed pariatur velit est itaque iste est maiores aut et cum doloremque illum et inventore repudiandae cum.", "Kenneth84@hotmail.com", "At voluptatem debitis doloremque debitis.", "Kenneth", "5705", "(297) 504-5613 x0907", "https://picsum.photos/640/480/?image=659", 1.2565654685052883, "Nolan Trace", "Boyle", "Dolorem suscipit.", "71185" },
                    { 161, new DateTime(2021, 1, 23, 7, 15, 15, 115, DateTimeKind.Local).AddTicks(5932), new DateTime(2021, 7, 29, 7, 6, 48, 579, DateTimeKind.Local).AddTicks(144), new Guid("27ff9b01-841b-4ce3-88db-d4666bd683b8"), "Jastside", "Western Sahara", "Dicta ipsa nemo fugit vero consequuntur accusantium quis ut quis saepe deserunt dignissimos autem et impedit at nobis non voluptate voluptatem et provident et quae ut quae voluptas iste non.", "Mercedes_Johnson@hotmail.com", "Necessitatibus beatae amet vel eligendi.", "Mercedes", "72761", "502-304-5338", "https://picsum.photos/640/480/?image=382", 3.5052638531221376, "Keira Tunnel", "Johnson", "Molestias et.", "64265-6008" },
                    { 148, new DateTime(2021, 1, 23, 10, 30, 48, 183, DateTimeKind.Local).AddTicks(9652), new DateTime(2021, 12, 5, 19, 10, 16, 889, DateTimeKind.Local).AddTicks(5126), new Guid("f2cc8aa8-f2b2-4763-bd23-8877ffd410fc"), "Micheltown", "China", "Optio non nulla sunt natus ullam impedit ab velit error nisi sint magni possimus omnis possimus eos dolorem modi rerum sed quam illo quos voluptatem non sed dolore consequuntur quidem.", "Kenneth_Barrows@gmail.com", "Omnis repellat ad officiis ex.", "Kenneth", "428", "644-679-5016", "https://picsum.photos/640/480/?image=553", 2.0560222049504624, "Stokes Course", "Barrows", "Dolor itaque.", "94882" },
                    { 136, new DateTime(2021, 1, 22, 16, 51, 28, 217, DateTimeKind.Local).AddTicks(8182), new DateTime(2021, 9, 15, 7, 23, 0, 769, DateTimeKind.Local).AddTicks(5319), new Guid("195dea0e-e069-4130-9567-9268133789d1"), "South Trycia", "Paraguay", "Et omnis ad est et culpa vel eius qui est rerum architecto quod minus culpa non voluptatem molestiae non accusamus doloribus vitae officiis neque dolore accusamus reiciendis ut sequi magnam.", "Trevor_Glover93@gmail.com", "Qui earum sunt ut aut.", "Trevor", "061", "394.557.9036 x402", "https://picsum.photos/640/480/?image=570", 2.377514325723757, "Skiles Ford", "Glover", "Commodi vero.", "27054" },
                    { 134, new DateTime(2021, 1, 23, 1, 47, 26, 669, DateTimeKind.Local).AddTicks(1047), new DateTime(2021, 2, 14, 2, 25, 11, 669, DateTimeKind.Local).AddTicks(4948), new Guid("749a569f-dc41-442a-9597-76d09545095c"), "Lynchport", "Slovakia (Slovak Republic)", "Inventore fugiat voluptates eos qui perspiciatis voluptas aliquam voluptas minus dolor est vero voluptas ut cupiditate minus dolorem inventore dolorem veniam sit facere at veritatis odio soluta magni et dolores.", "Lyle84@yahoo.com", "Error est vitae illo et.", "Lyle", "0773", "1-770-465-5604 x313", "https://picsum.photos/640/480/?image=840", 3.6413949591300425, "VonRueden Divide", "Huels", "Iure exercitationem.", "44184" },
                    { 137, new DateTime(2021, 1, 22, 20, 14, 56, 760, DateTimeKind.Local).AddTicks(4805), new DateTime(2021, 7, 26, 7, 37, 44, 17, DateTimeKind.Local).AddTicks(8736), new Guid("977e44d9-4525-45bb-9ee1-641c24af3c2f"), "Wiegandside", "Saint Barthelemy", "Iste ut doloribus a officiis omnis distinctio voluptas maxime cupiditate ea sunt laudantium facilis debitis similique alias provident velit odit sed repudiandae qui dolore exercitationem ea optio aliquam aspernatur eos.", "Sherman_Mills21@hotmail.com", "Rem at voluptate nam aut.", "Sherman", "81396", "626.898.1074 x20361", "https://picsum.photos/640/480/?image=59", 3.7345247802951023, "Heaney Crossing", "Mills", "Maxime distinctio.", "01123-2716" },
                    { 138, new DateTime(2021, 1, 23, 4, 9, 37, 446, DateTimeKind.Local).AddTicks(7510), new DateTime(2021, 11, 3, 2, 31, 23, 197, DateTimeKind.Local).AddTicks(8520), new Guid("1908134f-8ad6-4608-a176-db69f89c9c03"), "Dickiside", "Cote d'Ivoire", "Provident et maxime nobis nobis qui sit earum incidunt nihil sunt non odit delectus enim quo ut voluptatem rerum quos praesentium recusandae minus doloribus beatae veniam labore quasi eum quaerat.", "Wendell_Mueller23@yahoo.com", "Possimus id ea culpa aut.", "Wendell", "562", "(912) 349-8081", "https://picsum.photos/640/480/?image=101", 4.2239374160878072, "White Station", "Mueller", "Mollitia aut.", "51821-3416" },
                    { 139, new DateTime(2021, 1, 22, 13, 12, 15, 62, DateTimeKind.Local).AddTicks(8706), new DateTime(2021, 5, 31, 22, 53, 46, 774, DateTimeKind.Local).AddTicks(1765), new Guid("f3b371b9-60b7-4ba3-8570-7b02dcca8d55"), "Aliviaburgh", "Kazakhstan", "Ab quod qui quod et soluta explicabo officia perspiciatis praesentium aut nemo natus temporibus rerum reiciendis possimus voluptate blanditiis repellendus ullam cumque ipsam ut vel harum ab saepe nisi voluptas.", "Abel_Harris23@hotmail.com", "Ea ad harum velit dolore.", "Abel", "7021", "1-418-608-6658 x081", "https://picsum.photos/640/480/?image=213", 3.9916275474203879, "Jerad Mount", "Harris", "Molestiae dolores.", "03103-2955" },
                    { 135, new DateTime(2021, 1, 23, 10, 26, 9, 593, DateTimeKind.Local).AddTicks(7393), new DateTime(2021, 10, 28, 16, 42, 57, 413, DateTimeKind.Local).AddTicks(8738), new Guid("194bb457-8350-4116-be9d-12c0c7227961"), "Aliyahmouth", "Slovakia (Slovak Republic)", "Est sit vitae labore sed vero nobis non voluptatem non dolores expedita officiis iure dignissimos et suscipit voluptatum vitae voluptate rerum eligendi veniam dolorum sit totam modi quam consectetur sunt.", "Jody45@gmail.com", "Sunt a quae praesentium modi.", "Jody", "9809", "1-492-233-9623 x9075", "https://picsum.photos/640/480/?image=52", 4.05898627781262, "Schimmel Cove", "Ratke", "Veritatis pariatur.", "78038" },
                    { 140, new DateTime(2021, 1, 23, 10, 47, 39, 426, DateTimeKind.Local).AddTicks(7099), new DateTime(2021, 12, 13, 23, 40, 12, 215, DateTimeKind.Local).AddTicks(8275), new Guid("d242820b-70cb-4835-90da-7801f92397a1"), "Littleport", "United Kingdom", "Molestiae reiciendis quia reiciendis non et error cupiditate fugiat quis at aspernatur accusamus molestiae accusantium id sequi aspernatur officia sed et reprehenderit sunt aut corrupti sint et at dolores aut.", "Esther.Heller32@hotmail.com", "Aut dolor impedit reprehenderit tenetur.", "Esther", "65067", "1-882-466-6436", "https://picsum.photos/640/480/?image=967", 2.6212118387321066, "Esther Rest", "Heller", "In corrupti.", "88693-8982" },
                    { 142, new DateTime(2021, 1, 23, 2, 18, 43, 988, DateTimeKind.Local).AddTicks(9406), new DateTime(2021, 9, 26, 10, 16, 32, 631, DateTimeKind.Local).AddTicks(819), new Guid("25de7275-7c90-44b2-883f-06bfc0c67d59"), "Thompsonshire", "Indonesia", "Itaque quaerat minus quis unde quia aperiam sed quia ipsam esse enim sint eos nisi omnis quo sit velit iusto similique qui facilis consequatur in labore porro odit animi quia.", "Bethany_Rogahn24@yahoo.com", "Est rerum enim ea non.", "Bethany", "430", "1-569-302-6323 x07254", "https://picsum.photos/640/480/?image=529", 3.157618082201862, "Verla Crossroad", "Rogahn", "Atque et.", "42066-3733" },
                    { 143, new DateTime(2021, 1, 23, 4, 17, 41, 806, DateTimeKind.Local).AddTicks(6762), new DateTime(2021, 8, 6, 23, 18, 39, 583, DateTimeKind.Local).AddTicks(470), new Guid("96744c42-da8c-42f7-8cfc-6896615d4394"), "Howeborough", "Anguilla", "Asperiores aliquam blanditiis velit nisi maxime facilis a blanditiis perspiciatis excepturi totam reiciendis in et aliquam voluptatibus provident quos quos fugit est quisquam nihil officiis et et modi nobis et.", "Kristie.Shanahan@gmail.com", "Voluptas earum quam enim a.", "Kristie", "60722", "830-276-3328 x044", "https://picsum.photos/640/480/?image=299", 4.7208686041277224, "White Islands", "Shanahan", "Doloremque voluptas.", "15695-4047" },
                    { 144, new DateTime(2021, 1, 22, 19, 52, 17, 427, DateTimeKind.Local).AddTicks(9324), new DateTime(2021, 10, 1, 13, 47, 57, 69, DateTimeKind.Local).AddTicks(6090), new Guid("1d7794e4-7e4e-42b0-958b-da4837e69006"), "Loriton", "Hungary", "Quo eos quis sit pariatur fugit qui est illum hic corrupti assumenda officia quia vel quo aperiam enim porro aut unde rerum eum vitae est sint temporibus sint inventore voluptas.", "Luke.Bode54@gmail.com", "Dolore asperiores hic nemo sed.", "Luke", "275", "1-388-461-4813", "https://picsum.photos/640/480/?image=751", 1.0815046932927821, "Fern Brooks", "Bode", "Rerum amet.", "29594" },
                    { 145, new DateTime(2021, 1, 22, 13, 8, 27, 886, DateTimeKind.Local).AddTicks(4707), new DateTime(2021, 12, 3, 1, 30, 48, 532, DateTimeKind.Local).AddTicks(1275), new Guid("be25951e-1885-4a91-9b6b-ad47dd061521"), "Lake Shaynaton", "Montenegro", "Est quas facere delectus non aspernatur earum possimus totam quidem ut natus molestiae debitis architecto sunt occaecati aliquam sunt eos ipsum et excepturi tempore magnam dolor incidunt voluptates fugit molestias.", "Lorena_Hand76@gmail.com", "Mollitia aut doloribus vitae porro.", "Lorena", "373", "(946) 585-6438", "https://picsum.photos/640/480/?image=693", 1.6874331239086731, "Beier Path", "Hand", "Voluptate vero.", "21656" },
                    { 146, new DateTime(2021, 1, 22, 17, 55, 21, 82, DateTimeKind.Local).AddTicks(6120), new DateTime(2021, 10, 26, 8, 37, 18, 439, DateTimeKind.Local).AddTicks(5077), new Guid("7ddc23f0-9890-4d2a-95d3-a0547f943863"), "Brandoside", "Timor-Leste", "Fugit est est sed est molestiae ut fuga et possimus inventore veniam similique et qui sed sint voluptates voluptatibus laudantium id soluta et asperiores alias eligendi architecto itaque labore placeat.", "Dewey.Bartoletti@yahoo.com", "Quia et ducimus optio sed.", "Dewey", "5815", "1-387-525-5663 x957", "https://picsum.photos/640/480/?image=191", 1.7265965886072241, "Judy Springs", "Bartoletti", "Est quasi.", "56487" },
                    { 147, new DateTime(2021, 1, 22, 15, 50, 10, 894, DateTimeKind.Local).AddTicks(5532), new DateTime(2021, 7, 17, 20, 10, 7, 844, DateTimeKind.Local).AddTicks(1209), new Guid("56c4e0fc-1db2-4dfe-8e46-1667073c4d3e"), "East Clotildeberg", "Bhutan", "Temporibus est sit accusamus voluptatem sed aut eum et architecto voluptatem est cumque aperiam rerum qui inventore mollitia minima cupiditate delectus commodi quisquam asperiores ea nihil ea quibusdam aliquid est.", "Hope39@gmail.com", "Ut suscipit totam qui dolores.", "Hope", "29492", "(522) 357-3582 x00040", "https://picsum.photos/640/480/?image=1015", 3.9249097811639819, "Lindgren Mews", "Jast", "Nihil molestiae.", "48367" },
                    { 141, new DateTime(2021, 1, 22, 12, 43, 17, 585, DateTimeKind.Local).AddTicks(3213), new DateTime(2021, 4, 30, 5, 45, 54, 63, DateTimeKind.Local).AddTicks(8567), new Guid("75260bc3-d982-4e2f-bd7f-f4ffb9d4d787"), "North Maureenport", "Peru", "Quasi nesciunt quis et aut officiis eum doloribus sunt ea est voluptatibus culpa eveniet saepe placeat sint nisi aut architecto autem aut voluptatum suscipit a adipisci qui aspernatur velit expedita.", "Toby74@hotmail.com", "Distinctio repudiandae voluptatum quis culpa.", "Toby", "370", "468.215.2806 x600", "https://picsum.photos/640/480/?image=610", 1.0282894447577602, "Jalon Motorway", "Lueilwitz", "Nobis aperiam.", "01323-8723" }
                });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 1, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                column: "Unit",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                column: "Unit",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 4, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 2, 1 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                column: "Unit",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                column: "Name",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 3, 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                column: "Name",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 4, 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                column: "Name",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 4, 1 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22,
                column: "Name",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 0, 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 1, 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 3, 1 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27,
                column: "Unit",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 2, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29,
                column: "Name",
                value: 4);

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Name", "Unit" },
                values: new object[] { 3, 0 });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Name", "Unit" },
                values: new object[,]
                {
                    { 97, 3, 1 },
                    { 100, 0, 0 },
                    { 99, 3, 2 },
                    { 98, 0, 1 },
                    { 96, 3, 0 },
                    { 78, 3, 1 },
                    { 94, 0, 0 },
                    { 59, 4, 0 },
                    { 58, 1, 2 },
                    { 57, 0, 1 },
                    { 56, 1, 1 },
                    { 55, 0, 2 },
                    { 54, 1, 0 },
                    { 53, 2, 2 },
                    { 52, 0, 0 },
                    { 51, 2, 0 },
                    { 50, 4, 1 },
                    { 49, 2, 1 },
                    { 48, 2, 2 },
                    { 47, 0, 2 },
                    { 60, 1, 2 },
                    { 46, 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Name", "Unit" },
                values: new object[,]
                {
                    { 44, 1, 1 },
                    { 43, 4, 2 },
                    { 42, 0, 2 },
                    { 41, 4, 0 },
                    { 40, 4, 0 },
                    { 39, 4, 1 },
                    { 38, 2, 1 },
                    { 37, 1, 1 },
                    { 35, 3, 0 },
                    { 34, 2, 2 },
                    { 33, 2, 0 },
                    { 32, 4, 0 },
                    { 31, 0, 2 },
                    { 45, 0, 1 },
                    { 61, 4, 2 },
                    { 62, 4, 0 },
                    { 63, 1, 1 },
                    { 93, 3, 1 },
                    { 92, 4, 0 },
                    { 91, 0, 0 },
                    { 90, 4, 2 },
                    { 89, 2, 2 },
                    { 88, 0, 2 },
                    { 87, 3, 0 },
                    { 86, 2, 0 },
                    { 85, 3, 1 },
                    { 84, 0, 2 },
                    { 83, 0, 2 },
                    { 82, 1, 1 },
                    { 81, 0, 2 },
                    { 80, 0, 2 },
                    { 79, 0, 2 },
                    { 77, 1, 0 },
                    { 76, 0, 1 },
                    { 75, 2, 2 },
                    { 74, 2, 1 },
                    { 73, 1, 0 },
                    { 72, 2, 0 },
                    { 71, 2, 0 },
                    { 70, 1, 0 },
                    { 69, 1, 2 },
                    { 68, 3, 2 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Name", "Unit" },
                values: new object[,]
                {
                    { 67, 2, 1 },
                    { 66, 4, 1 },
                    { 65, 4, 1 },
                    { 64, 4, 1 },
                    { 95, 4, 0 },
                    { 36, 1, 2 }
                });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 34, 139, "Nisi rerum ipsam non aliquid officiis enim laudantium sint ea. Quas minus quae praesentium enim quisquam perferendis eligendi eaque et. Exercitationem commodi error dolorem ullam est eos blanditiis. Explicabo necessitatibus et ut rerum tempore qui. Natus sint assumenda. Doloribus quam officiis cupiditate voluptatum explicabo est esse.\n\nEst veniam est nisi hic consequatur non sunt. Animi laudantium illum dolorem laborum dolorem ratione excepturi. Dolores recusandae dolores occaecati vero alias nemo. Est ullam dolorem excepturi numquam eaque eius praesentium dolorem dolorum.\n\nEst numquam omnis doloribus vero dolorem consectetur. Mollitia quaerat optio sit. Ab veniam et et sed nihil est.\n\nSoluta tempora placeat. Iure nihil animi consequatur. Quia recusandae repudiandae accusamus sint eum." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 67, 115, "Dolores aliquid et id dolores non neque possimus temporibus. Sapiente velit cupiditate error quisquam sed voluptas labore nihil dolor. Sunt incidunt vel quos qui tempore sit commodi ab. Sed minus officiis ut et. Dolorum aliquam eius modi.\n\nVoluptate atque consequatur velit ut ratione vel illo et. Voluptates quae error quia dolorum fugit aspernatur quaerat voluptatibus reprehenderit. Animi molestiae laudantium est nam quasi nostrum impedit. Corrupti iste explicabo omnis qui sit atque maiores quia aperiam. Asperiores qui in dolorem dolorem suscipit provident et quas sequi.\n\nMinima architecto consequatur illo. Voluptas soluta beatae sunt ut sint rem. Tenetur aut ullam quis harum. Recusandae rerum voluptate. Voluptatem pariatur rerum qui sit ut distinctio sed. Non ipsam illum nobis perferendis ad earum eius facilis.\n\nEst provident odit rem officiis non incidunt laboriosam officiis ipsa. Exercitationem accusamus voluptas. Quia et earum aliquid ut molestiae qui dicta. Aperiam dolores sed quis perferendis eligendi saepe nostrum doloribus sint. Dolorum maxime dolorem. Et nemo quia sit temporibus quas voluptatem rerum ea ex." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 4, 107, "Quam laudantium quas dignissimos neque. Quod velit rerum quia dolor voluptatem. Corporis ex incidunt aperiam laudantium id repellat omnis. Odit vel ullam odio.\n\nOmnis non rerum expedita. Alias sunt illo deserunt dolor culpa qui. Iure commodi repellat voluptatem.\n\nPorro deserunt consequuntur quia id exercitationem minima quod amet. Eligendi qui est nihil omnis. Perferendis vel cupiditate provident qui minus corporis rerum. Aut aut autem neque accusamus aut distinctio expedita nam. Mollitia harum est laboriosam ea.\n\nIure optio ut aperiam vero. Et id ut dolorum fuga. Ipsa maiores nostrum. Laudantium quisquam quis corrupti in ipsam." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 3, 125, "Consequuntur a perferendis. Eaque neque adipisci totam nisi id. Dolorem accusantium impedit eos nihil occaecati quos eaque. Fuga enim nemo ratione ratione dolorum architecto.\n\nQuasi blanditiis officiis unde quibusdam dolor optio quisquam. Culpa praesentium repudiandae in rerum est placeat quidem optio in. Sequi autem facere asperiores itaque. Vel est accusamus quaerat quam sunt. Dolor ad voluptatem et minima. Provident odio cumque culpa.\n\nQuidem quae tempore dolorum in molestias et. Et provident ad cumque aut est. Commodi quae at nobis neque. Error autem consequatur ut rerum. Laudantium quae voluptates qui numquam. Quam ullam iure qui doloremque rem placeat dolores deserunt.\n\nRepellat ducimus maiores libero. Dolorem reprehenderit nulla eveniet placeat sed quasi magnam corporis. Sint voluptatem praesentium. Deserunt vitae inventore eos laudantium enim. Modi sit eum recusandae libero omnis quisquam perspiciatis consequatur explicabo. Est deserunt debitis sint id voluptatem explicabo numquam tempora eos." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 96, 184, "Aperiam qui aliquam dolorem itaque qui cupiditate. Ut rerum autem laudantium sapiente. Nihil aliquid impedit. Maiores et laudantium et sunt architecto voluptatum quod assumenda dolore. Fugiat eum et. Suscipit harum quidem laudantium vel et.\n\nVoluptas eligendi non eos qui. Perferendis temporibus officiis et ut. Laboriosam dolores ipsum similique dolor est velit illum ad ad. Error enim aperiam. Ducimus temporibus necessitatibus voluptas molestias deleniti et dolores.\n\nItaque suscipit eum facere blanditiis non ea deleniti. Dicta sed laudantium. Veniam est incidunt.\n\nIllo fuga consequatur. Odit qui similique alias maiores aut qui atque aspernatur. Repellat molestiae et ex vel veritatis illum veritatis nam vitae. Rerum molestiae voluptatibus porro. Quidem ad repellendus qui beatae unde ad." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 23, 111, "Blanditiis tempora corporis dicta. Doloribus sed totam ratione eaque suscipit esse. Minima asperiores sapiente quis et nesciunt ullam qui. Vel laudantium sed cumque a. Ducimus est dolores quia nesciunt officiis commodi quo ea asperiores.\n\nModi sint similique similique corporis vero sequi eos dicta qui. Quos quasi ex animi dolorem nulla quo delectus sint aperiam. Sit et ut non quaerat. Repudiandae sequi animi nostrum sit sed beatae quasi porro. Neque quaerat perspiciatis explicabo eum et expedita facilis illo.\n\nAdipisci doloribus cupiditate accusantium soluta. Recusandae dolores quasi nam sunt animi qui hic recusandae voluptatibus. Rem et minima provident qui aperiam cum impedit. Earum praesentium sequi voluptas quaerat. Blanditiis corrupti porro neque. Voluptatem laboriosam minima.\n\nFacilis voluptatem architecto expedita voluptatem ratione eveniet. A ipsum amet occaecati quod maxime a pariatur voluptatem nemo. Voluptatum nisi incidunt ea recusandae ratione voluptates incidunt assumenda et." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 14, 144, "A consequatur aut animi. Modi quibusdam natus. Aut dicta ut recusandae maxime. Sed incidunt earum aperiam exercitationem nam incidunt velit maxime qui. Labore repudiandae magni aut cupiditate eaque animi.\n\nItaque architecto dolore enim dicta consectetur sint et aliquid. Sapiente non neque quaerat error. Quos aspernatur nostrum rem est qui eos praesentium. Maiores aut et corporis ea ab consequatur.\n\nEaque consequuntur maiores tempore rerum odit placeat dolorem veritatis molestiae. Corporis architecto expedita error. Doloremque itaque nemo voluptates illo. Itaque repellendus id aut nemo atque voluptas. Ut mollitia distinctio velit eius iusto eligendi qui sequi amet.\n\nSit quo veniam ut voluptates modi et. Voluptas aut inventore. Voluptates dolores consectetur velit itaque nulla quibusdam ut. Quasi nesciunt qui facilis officiis iusto. Id non repellendus quia." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 50, 119, "Quas quas consectetur vitae. Omnis nam nesciunt sed sit nostrum est. Quos rerum nemo iure.\n\nQuaerat iste cumque officia. Temporibus id in. Quia recusandae blanditiis. Veniam ut optio et et porro.\n\nVoluptate repellat quae fuga qui quo rerum aut. Deleniti minus qui suscipit hic. Aut repudiandae nesciunt exercitationem aut ea perspiciatis fugiat. Natus officiis odio ad quibusdam qui et. Vel sint pariatur iste expedita sapiente ducimus architecto.\n\nAutem nulla sed qui beatae. Nemo necessitatibus occaecati dolores quam. Minima eos dolorem dignissimos et impedit enim laborum enim. Dolorem inventore sint illum aspernatur odit voluptatem hic impedit eius. Architecto facere maiores. Fugiat quibusdam odit delectus et non." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 26, 116, "Doloribus reprehenderit numquam eveniet. Aut labore aut sint voluptatem qui vel quaerat. Velit quod sunt repellendus.\n\nQuia aut dolor ipsa incidunt repudiandae dolorem facilis. Rerum libero aut officiis culpa aut. Itaque ab aut esse temporibus aspernatur quo delectus.\n\nSed officiis assumenda. Ea quis illo corporis. Aut numquam ipsum. Qui quidem mollitia similique ut ex suscipit earum.\n\nAtque aut occaecati. Dolor tenetur aut enim non dolor non vel nostrum. Et officia exercitationem facere similique omnis incidunt quas voluptas. Voluptatem omnis consectetur non et laborum. Vitae vero facere quis ea quo natus enim aliquid et." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 1, 161, "Dignissimos ut quisquam voluptas eum inventore. Quis consequuntur saepe reiciendis ipsa eos nam. Omnis culpa voluptate. Vero magni occaecati ut officia aut placeat.\n\nNumquam harum dolorum et autem molestiae. Et totam sed deleniti omnis laboriosam impedit minus. Nemo ipsam cumque eveniet ut deserunt laboriosam sed ea. Voluptas molestiae aut dolores dignissimos quidem quia. Nesciunt quos enim.\n\nNumquam a sunt nostrum vel molestiae quae occaecati. Repellendus soluta minima error ab quo. Fuga nostrum quam aspernatur. Mollitia omnis fuga suscipit possimus voluptas tempora ut unde.\n\nEum est atque itaque optio ullam sapiente. Ex aut et qui consequuntur. Debitis officia corrupti saepe sed velit pariatur vel qui." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 18, 162, "Dolorum vitae illum quis officiis perspiciatis sunt qui sint error. Sint quia sit ratione maxime fugiat est quidem et deleniti. Aliquam quod laboriosam perferendis ipsa quod qui eum et possimus. Nisi laboriosam consectetur ut est aperiam mollitia aperiam. Sapiente accusantium qui vel non et. Quidem doloribus non ut ducimus voluptatum maxime eum.\n\nEos et aliquid repellat sunt optio qui voluptas reiciendis asperiores. Quia odit expedita ipsa totam architecto repudiandae incidunt nesciunt sapiente. Dolor eaque vel quo recusandae numquam corporis accusamus deserunt.\n\nOmnis quia aspernatur nobis voluptate officiis. Dignissimos laborum ut officiis placeat. Aut ad et voluptatibus in eum. Sint maiores inventore quia enim sit magnam.\n\nLaudantium aut in mollitia quod sit atque earum dolor libero. Ut quo ut. Corporis nostrum eum a distinctio quo quia. Voluptas omnis perspiciatis autem fugit omnis. Modi fuga error sint ratione. Voluptatum sequi est." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 80, 156, "Qui autem optio sed. Quos sit voluptatem et nostrum aut non qui. Quidem fugiat adipisci sed consequatur neque velit ducimus. Laboriosam velit sed ducimus dolorem eos. Voluptate et sequi quia id ut veritatis nisi.\n\nPossimus aliquid nihil suscipit praesentium corporis alias. Voluptas voluptatem quos perferendis nihil qui. Veniam autem ex consequatur iusto quae adipisci rerum aut.\n\nInventore voluptatem et nam. At vel maxime ea inventore accusantium vitae aut saepe. Ut maiores illum sed. Dignissimos possimus suscipit blanditiis mollitia impedit. Quisquam culpa error totam voluptatem. Modi dolore voluptatibus similique dolor unde.\n\nSoluta doloribus qui quaerat exercitationem voluptatum aut ut. Quia et eveniet. Autem corporis est qui quasi veritatis. Distinctio dolorem voluptas deserunt nihil harum distinctio. Numquam in aut enim similique possimus voluptas voluptas." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 20, 161, "Tempora atque quas ex. Quam a molestiae rerum exercitationem fugit. Atque sed aut. Voluptatem eos omnis nam illum praesentium sit.\n\nAutem sit minus doloremque sed vitae. Assumenda eum quis quia distinctio. Consectetur quis cum incidunt nihil et. Optio repellendus ducimus repellendus magnam. Totam facilis quidem esse assumenda laudantium eum.\n\nDicta modi in voluptate non eos laboriosam. Eum quibusdam at libero rerum voluptatem maiores qui. Aspernatur reprehenderit nihil aut rerum hic dolor et et. Dolores velit occaecati impedit fugiat non qui. Qui eum ullam impedit. Ea magni et maiores qui rerum.\n\nEst fugiat sit consequatur iusto magnam. Sed ad dolorum corrupti mollitia magnam sed. Enim sunt voluptatem eos. Veritatis sed facere blanditiis iure. Nisi debitis ut delectus eum aut explicabo tempora corrupti culpa." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 35, 151, "Maiores repellat dolor non vel. Quia sequi necessitatibus. Eveniet autem consequatur nesciunt voluptatem. Beatae natus reiciendis.\n\nQuisquam recusandae enim ut excepturi et voluptatem porro distinctio consequatur. Fuga vero autem et ex perspiciatis facilis ad. Consectetur maiores sapiente quasi aut neque itaque voluptates autem. Earum commodi recusandae autem ut veritatis accusamus.\n\nEt voluptatem iusto incidunt dolores. Facere tenetur repellendus magnam. Provident sint cumque libero quo minus aut et tempora. Natus fugit nisi sequi accusamus. Est atque odit consequatur corrupti similique. Distinctio facilis possimus possimus laudantium.\n\nNon sequi expedita et aut. Nam ut distinctio. Sunt et placeat tenetur illo eaque sunt. Et assumenda veritatis. Cum dolore enim delectus in ipsa. A reiciendis molestias." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 98, 133, "Blanditiis est sit nulla porro nihil. Sunt sint vero illum reprehenderit id est nam cum. Voluptatem adipisci quod voluptatum velit ut consequatur dignissimos dolorum.\n\nIste culpa nemo omnis vel facilis qui consequatur. Repellendus ab rerum est aut sit velit ratione amet iusto. Exercitationem ullam tempore ipsum omnis qui.\n\nVel quia ea. Sit sed perferendis. Unde eaque in sapiente voluptatem. Dolor ab aut omnis sunt. Beatae recusandae eos quaerat amet. Voluptate quaerat et eos alias quam quo sed maiores.\n\nTenetur praesentium non dicta asperiores eos. Laborum voluptatum reprehenderit. Sint fuga et modi corporis iste delectus dignissimos ipsam ratione. Ex quo possimus et velit eaque sequi magnam corrupti enim. Libero voluptatem explicabo." });

            migrationBuilder.InsertData(
                table: "BookingMessages",
                columns: new[] { "Id", "ClientId", "PetsitterId", "Text" },
                values: new object[,]
                {
                    { 48, 21, 178, "Repellendus et ab excepturi ipsum est. Assumenda quam temporibus. Officia et fuga beatae et omnis qui quia sunt. Consequatur repudiandae natus quis quaerat quo voluptas. Nemo qui nulla assumenda nobis nihil possimus atque odio et. Quia corrupti fugit.\n\nAut et et voluptas voluptatem ea quae. Sit nulla esse. Corrupti modi repudiandae vel possimus eos aut.\n\nQui non sint quia eum fugit eos veritatis dolore illo. Optio ut atque reprehenderit suscipit. Facere rerum explicabo voluptas qui voluptas quis. Asperiores numquam tenetur et. Fuga alias sunt expedita voluptatibus recusandae culpa.\n\nDolore amet sit itaque autem dolorem qui occaecati quod. Voluptatum adipisci aut dolorem omnis ipsum labore. Et dicta iure. Voluptates illum soluta et dolore quia enim et blanditiis possimus." },
                    { 20, 48, 130, "Id voluptatem est itaque eligendi consequatur. Dolor corrupti et et in labore. Corrupti at repellendus eos. Laborum debitis corporis fuga dolores quod et labore ipsa ut.\n\nNemo ut sint quia aperiam voluptatibus explicabo facere. Quasi eligendi fugiat numquam temporibus. Repellat perspiciatis nesciunt. Quos odio quos impedit et ullam. Sequi adipisci saepe sunt ea non non nulla.\n\nQuisquam perferendis blanditiis accusamus eligendi. Soluta perspiciatis amet. Velit impedit distinctio et optio aut. Et numquam illum iste sit dolorem suscipit. Eveniet vero qui quo deleniti ut consequatur dolor est.\n\nNihil non et sit consequatur dolorem ipsam. Quis dignissimos sed sunt debitis voluptatum rerum eos harum. Facere nihil consectetur sed ipsa autem magnam tenetur eum. Similique ipsa provident necessitatibus cupiditate dolorem dolor quae." },
                    { 29, 28, 131, "Temporibus porro molestiae et sed similique. Quidem iure velit eos earum aut. Sapiente hic tempore hic qui velit ipsum dignissimos ducimus. Fuga dolorem est soluta quo ea soluta. Omnis placeat et sint nostrum eum.\n\nCorrupti autem mollitia sed reprehenderit ullam sed incidunt. Mollitia repudiandae aliquid aut qui exercitationem ut. Vel dolorum eaque autem dolor. Accusantium sint id dolorem voluptatem non ipsa expedita nostrum perspiciatis.\n\nAutem nulla voluptas modi quia quae perspiciatis nesciunt. Ducimus voluptas occaecati. Blanditiis natus est voluptatum omnis commodi. Nihil accusamus similique animi et dolores vero corporis deleniti itaque. Consequatur sed nobis sint et earum deserunt.\n\nDolore fuga vel culpa consectetur eius repellendus consequatur quis qui. Non dolor placeat consequatur. Minima est similique consectetur amet et cum. Dolorem occaecati ipsam eligendi." },
                    { 33, 57, 127, "Nulla culpa occaecati eveniet molestias dolorum minima delectus. Amet non vitae qui molestiae temporibus laudantium. Aut porro et blanditiis sequi. Laboriosam et eius.\n\nNobis velit rerum voluptas deserunt pariatur odio nam. Sequi facere et est. Cum et amet ipsum beatae itaque qui eveniet. Sequi nulla ducimus amet eligendi. Dolor aspernatur quis aperiam mollitia veniam sequi.\n\nCorrupti exercitationem maiores quia enim ipsum. Quis enim omnis voluptatum blanditiis. Harum eos facilis veniam. Et corrupti sint ratione distinctio placeat nesciunt aut inventore. Qui illo esse cupiditate quasi id.\n\nTenetur enim qui quia autem iste quia nihil numquam. Accusantium laudantium voluptatem. Ipsam quos dicta veritatis non nisi. Ut delectus laboriosam fugit eveniet necessitatibus eius ut. Iure esse tenetur ex eligendi aut sed saepe eligendi commodi." },
                    { 17, 39, 172, "Qui amet laborum libero quia tempora mollitia consequatur. Ad aut tempora quidem aut excepturi debitis omnis. Ut et corrupti aut aliquid. Autem sunt voluptas esse ut nihil sed. Itaque mollitia mollitia et adipisci maxime et voluptas quia.\n\nProvident sit assumenda cum quaerat et repellat sed commodi. Omnis ut perferendis fugiat aspernatur exercitationem quidem eveniet sit. Enim sequi aut quis eaque molestias officia nobis doloremque. Est deleniti dolores voluptatibus qui dolor. Eveniet et quia ut necessitatibus possimus rerum. Commodi culpa dicta explicabo.\n\nEt eos voluptatem omnis autem. Deleniti quidem facere et enim. Recusandae beatae exercitationem quod doloremque perferendis sint. Quod fugiat consequatur accusamus eum qui veritatis consequuntur.\n\nEt officia qui qui voluptates laboriosam nisi et dignissimos vero. Quaerat ipsam occaecati distinctio. Dolorem accusamus et dolorum unde architecto. Omnis unde aperiam magni. Ipsum reiciendis quaerat ex sapiente." },
                    { 37, 93, 101, "Nesciunt adipisci aut est quis laboriosam ipsum asperiores autem deserunt. Tempora et laborum illo natus sed ducimus aut. Dolore quo cumque officiis quo iusto quidem sint. Qui repellat rerum est consequatur assumenda.\n\nEt molestiae est nesciunt dolorem laboriosam repellendus delectus. Quia et accusamus repellat quas iste. Facilis est voluptatem quos aut necessitatibus at nihil aliquam. Laboriosam mollitia quisquam et autem nulla nihil. Ea sit velit in quam et sint et molestiae.\n\nQuae voluptatum hic odio. Vitae voluptatem ducimus eos. Voluptates in maiores et corporis repellat consectetur dolore.\n\nEt ducimus ipsum aspernatur sed voluptate. Ut qui in. Laudantium et similique quia. Reprehenderit sequi mollitia. Voluptatum qui veniam adipisci quos odio. Tempore sed et qui distinctio occaecati." },
                    { 28, 91, 137, "Repudiandae voluptatem ut autem et. Est quis natus. Veniam et voluptates sit fuga. Voluptas exercitationem iure dolores. Eaque expedita maxime ea reiciendis qui.\n\nPariatur consequatur aliquam aliquam provident blanditiis eligendi rem molestias. Aut pariatur voluptatem autem sit repudiandae cupiditate laboriosam rem. Hic id quasi occaecati ratione quo debitis consequatur nesciunt perferendis. Nihil et et impedit delectus doloremque.\n\nQui non id aliquam dolores esse. Et dolore rem eum quo quidem aut minima. Fugit ullam minus aut eligendi culpa voluptas ipsam quos ut. Aliquid deserunt vitae numquam rerum vero sapiente. Et non deleniti in odit et voluptate et.\n\nDolor illum enim eius non. Libero ullam iste nobis voluptatem id nihil. Ratione eos exercitationem quo dolorem aliquam rerum reiciendis cum. Non eligendi quidem quisquam fuga. Quis hic et voluptatibus ipsam provident labore. Et atque perspiciatis qui." },
                    { 19, 29, 171, "Quae sequi corrupti quia voluptatum iste dolores. Ad ut aliquam perferendis. Voluptatem dolorem vel.\n\nConsectetur atque earum facilis voluptatem voluptatem excepturi dolorum eius voluptate. Sit hic recusandae natus ex doloribus. Hic sit corrupti. Quia voluptas error enim rerum. Velit illum quis perspiciatis. Minus aspernatur id sunt ea magni.\n\nVero laboriosam qui qui explicabo in quia qui. Neque dolores eos voluptas atque illum nemo aspernatur. Facere dolorum nisi.\n\nAperiam sint eligendi eius fugiat tenetur. Officia eveniet est ex harum aperiam ducimus fugit totam. Voluptatem porro impedit expedita ut soluta est dolore minima." },
                    { 32, 36, 135, "Ut minus nesciunt minima tenetur minima soluta. Qui in non eligendi enim. Et est accusantium dolorum modi eaque ut enim. Vero eaque aliquid quae fugit natus possimus eum enim. Et recusandae vero corporis qui tempora corporis labore cum.\n\nExcepturi quod quia a. Et numquam est dolores iste sed incidunt. Ullam et id ut error dolor quidem adipisci eius rerum. Id et eum in. Et quibusdam nostrum est tempore ut.\n\nSunt unde magni. Expedita quia magnam provident cumque non consequatur. Fuga quasi cum saepe. Recusandae exercitationem vero beatae modi et quae quidem sit numquam.\n\nBlanditiis aliquam tenetur rerum. Qui perferendis est explicabo sed ipsa harum. Aperiam eos autem quis assumenda pariatur sed in. Id illo odio hic et ab vitae et voluptas sapiente. Quis dolore tempore illo quaerat ab. Distinctio et aut in magnam modi consequatur amet commodi libero." },
                    { 44, 43, 137, "Voluptates voluptatem est est aperiam aperiam quidem. Sit vel molestiae dolore atque aut fugiat. Dolor ut corrupti ducimus earum modi deleniti ea qui. Sit non tempore excepturi at voluptate et quis. Aut non occaecati.\n\nNostrum fugit voluptas assumenda minima architecto. Nisi velit consequatur atque qui earum non et est. Sit repellat nemo perferendis aut non tempore cupiditate sint.\n\nQuibusdam tenetur dolorum distinctio. Illo nesciunt dolorem saepe impedit beatae et voluptates cum. Et accusantium blanditiis.\n\nDistinctio ipsam eaque debitis cupiditate voluptas quam dolor amet. Dolore omnis eveniet fuga perspiciatis praesentium consectetur dolorem. Necessitatibus illo et quibusdam dolores magnam nisi. Laboriosam repellat veritatis facilis et ab." },
                    { 41, 58, 162, "Eveniet magni corrupti. Et asperiores aut incidunt voluptas sint voluptatem laborum. Incidunt est aperiam accusamus optio.\n\nQuas facere consequatur. Quaerat doloremque dolor quis est qui. Eum dolor natus labore eos ea. Reiciendis voluptate placeat voluptates voluptatem repellendus itaque doloribus omnis omnis. Vel consequatur et saepe beatae excepturi qui quia explicabo autem.\n\nAnimi qui cumque quae. Eum aut doloribus voluptates tempore accusamus. Ad nostrum mollitia iusto modi qui enim ut. Et ut omnis.\n\nNihil quae aspernatur quod voluptatem dolorum molestias adipisci voluptatem quia. Quod ducimus nesciunt a temporibus doloremque impedit. Quia dolorum temporibus sint nihil ut. Odit sed quia ipsum voluptatem molestiae dolores iste. Possimus necessitatibus ipsum voluptate." },
                    { 27, 60, 157, "Distinctio amet ad non eos qui praesentium voluptatem dolor. Eius illo voluptas et fugit temporibus aut. Beatae ipsam ea tenetur corporis consequatur ipsam quidem rerum et. Possimus repudiandae vel cum tempore.\n\nQuisquam mollitia iusto eius iste eos voluptatem. Neque iusto a delectus et dolore et est cupiditate. Voluptate nihil aut. Laborum tempora quaerat aut quo quam.\n\nVel et assumenda officia et quia. Vero omnis dolores harum iusto est. Cum sint eius et saepe modi nostrum laborum voluptatem deserunt. Quaerat voluptatibus quia sapiente placeat ratione eveniet ad. Inventore nemo velit nulla sit expedita et libero corporis.\n\nDucimus vel minus. Nisi officia est non consequatur fugit voluptas. Quia earum aut tempora labore saepe. Aliquid id neque. Dolorem consequatur porro autem aut ut voluptatibus dolorum enim aliquid. Velit dignissimos dolore et dolorum nesciunt et." },
                    { 16, 29, 157, "Facere facilis impedit. Velit maxime veniam quasi omnis fugit. Sunt perspiciatis voluptate ut.\n\nIllum sit error. Et blanditiis tempora et est blanditiis. Sint consequuntur quod enim aut autem natus et sed sint.\n\nVoluptatem laboriosam voluptatem. Explicabo repudiandae assumenda. Et aut doloribus maxime a occaecati dolorum nobis. Atque non quisquam quis.\n\nEst quis rerum est. Nulla id quo amet. Voluptatem esse aut aut velit magni doloribus. Et occaecati aut eos repellat enim commodi facere debitis enim." },
                    { 30, 6, 154, "Laudantium quis soluta beatae illo maiores velit iusto ut ab. Dicta possimus sunt harum blanditiis soluta voluptate modi numquam voluptatem. Aut consequatur hic. Possimus tempore ut sunt enim enim est exercitationem. Aut quasi molestiae.\n\nIpsam dolores voluptas eos enim. Quam minus necessitatibus eos perferendis magni quo. Et ea error tempore magni quam. Quod provident quaerat omnis.\n\nLaudantium accusantium dolorem eum possimus tenetur. Ut rerum voluptatem libero optio ex eius accusantium repellendus eaque. Qui rem adipisci. Nihil et qui autem aperiam veritatis. Animi qui ea est adipisci a nihil.\n\nQuaerat quia voluptates deserunt reiciendis explicabo. Reiciendis omnis sed quia tenetur dolores sit quidem voluptatem sed. Quia qui maiores." },
                    { 43, 25, 153, "Sed maxime labore laudantium officia dolorum laboriosam voluptatibus minus. Minima sit rerum dignissimos ea fuga. Nostrum id quis provident nisi soluta aperiam illo. Voluptatem quod eius omnis sunt natus voluptatem sequi.\n\nLibero suscipit harum accusamus. Ut exercitationem est accusamus veniam consequatur dicta occaecati. Aperiam incidunt facilis rerum aliquam est.\n\nVelit repudiandae ea mollitia. Aut nisi quisquam aperiam qui nihil sequi tenetur autem. Minus fuga error ab doloremque dolorem est enim.\n\nQuo qui vero sint. Ut et sit totam. Porro excepturi ratione quia voluptatem corporis ratione dolore quidem nam." },
                    { 45, 54, 133, "Quod dolores voluptatibus quidem reiciendis rerum ut laudantium voluptatem possimus. Magni et cum sed rerum. Et vero occaecati ut fuga dolor dignissimos. Sit quia perferendis.\n\nSunt dicta veritatis unde ducimus est deserunt aliquam. Neque natus tempore. Officia fugit non nisi iure dignissimos sit rem occaecati soluta.\n\nFugit a sed. Quibusdam sint modi veniam est sit velit. Aut incidunt excepturi. Quia est eligendi a incidunt. Deserunt voluptas accusamus quo id similique asperiores labore. Voluptate aspernatur sed.\n\nIllo optio minima est laboriosam iure voluptas ea. Eos et nesciunt recusandae necessitatibus ratione autem maiores consequatur dolor. Commodi quia est a omnis et. Consequatur magni temporibus ut similique." },
                    { 23, 56, 127, "Cum sapiente qui. Voluptate blanditiis rerum repudiandae veniam repudiandae qui ducimus sunt eos. Cum aut ducimus velit itaque aut sit accusantium dolorem. Sunt consectetur sed ratione ut culpa pariatur omnis.\n\nNon qui qui eum deleniti occaecati accusamus assumenda rerum eveniet. Harum vel eius suscipit eveniet vel ea unde qui. Recusandae sunt quaerat fugiat voluptatem voluptate voluptas maxime. Debitis libero aut non voluptatem. Distinctio et porro esse aut. Beatae non at itaque autem.\n\nRerum assumenda corrupti incidunt nulla enim deserunt dolorem aut. Numquam fugit aut accusantium laborum sit sed. Id tenetur illo labore placeat rerum dolores. Voluptate vero rerum.\n\nNecessitatibus dicta tenetur odit similique reprehenderit odio quaerat itaque libero. Dolor sint et corporis repellat tempora. Voluptates id voluptate assumenda commodi omnis. Sit nulla explicabo et et id." },
                    { 22, 65, 126, "Et dicta consequuntur facilis fuga. Unde incidunt sed quidem. Expedita qui labore aut natus. Qui voluptatum omnis optio eligendi quam. Voluptatibus enim officia eveniet quisquam asperiores. Dicta consequatur ut deserunt eius modi ex et dolores.\n\nInventore animi repudiandae ducimus ipsam. Voluptatem aspernatur incidunt et ipsum odit et odit. Est nam ex fuga est molestias non qui. Pariatur eum est autem.\n\nVoluptatem reiciendis ea. Quidem qui corrupti provident tenetur. In dolorum omnis rerum sint cumque quis atque omnis. Eligendi necessitatibus officiis facere pariatur nulla.\n\nAnimi corrupti beatae cupiditate omnis dolores quo adipisci. Minima rem pariatur ut dolores ea possimus architecto. Qui officiis exercitationem ratione perspiciatis neque et nulla voluptate voluptatem. Est corrupti autem. Temporibus recusandae laudantium. Illo eos fuga ut est tenetur consequatur perferendis nihil." },
                    { 38, 49, 182, "Pariatur et porro perferendis ab. Natus iusto ducimus hic esse cumque aliquam id. Est corrupti itaque. Neque aut est explicabo voluptatibus. Ratione voluptatem nulla sed earum illum.\n\nId ut dolore debitis ea nihil assumenda. Possimus ipsa quos aut aut et saepe eligendi. Doloremque accusamus modi.\n\nEt consequatur id dolorum ut. Quo ut molestias magni voluptas. Sint et repellendus. Vitae sint corrupti odio numquam error id ut nihil.\n\nSequi non voluptates rerum et ipsum. Ullam odio qui dolor cupiditate praesentium. Vero sed ea. Debitis ut eum et labore hic ex id." },
                    { 39, 12, 200, "Voluptas velit dolorum rerum. Autem mollitia amet praesentium et fugit voluptas. Et corporis asperiores accusantium et. Doloremque et veniam perspiciatis itaque. Dolore quis sapiente officia magni quia quis.\n\nAutem culpa ut in. Atque itaque quia modi a incidunt. Natus laborum facilis. Impedit error omnis est delectus. Expedita soluta nostrum ipsam dicta harum.\n\nPlaceat eum ratione fugit magnam. Sunt qui maiores officiis sunt quasi veritatis officia. Non est cum ipsam modi nihil est cupiditate. Enim eveniet et modi veniam dolores qui nemo in saepe. Ea et ducimus commodi.\n\nAliquam culpa necessitatibus natus saepe. Quasi reiciendis voluptas fuga velit ipsam. Voluptates qui corporis quia nulla. Quibusdam accusamus ipsum at deleniti. Quos dolorem vel ullam est et ipsam reprehenderit hic. Doloremque quidem voluptate autem." },
                    { 34, 24, 198, "Rerum deserunt ipsam. Id et odio. Quia laboriosam ratione. Nemo dolore veritatis eveniet nam a beatae ut. Laborum excepturi autem optio corporis nostrum adipisci consequatur.\n\nQui cumque vero reprehenderit occaecati. Aut deleniti nihil excepturi vel quia laborum. Ut nihil a fugiat.\n\nSit nesciunt ut ducimus suscipit vitae cupiditate enim. Et dolore rerum ipsa ut facere. Qui at ut. Dolor voluptatum et facere veniam. Eveniet qui est mollitia suscipit ea. Totam aliquid labore iusto voluptate inventore odio.\n\nQuae autem ut quod dolorem facilis blanditiis. Aliquam aut exercitationem rem repudiandae ut quas excepturi neque non. Earum officia quo exercitationem." },
                    { 31, 93, 197, "Veniam soluta nemo consequatur neque. Voluptatem quisquam natus illum delectus. Id qui est nisi quam sit eum. Dolorum odit ea est ut asperiores et eum deleniti. Exercitationem aliquam ipsa voluptatem eligendi esse. Aut et earum rerum ut itaque commodi.\n\nMollitia qui quo labore similique rerum sunt. Nihil dolor minima. Totam dolorem laboriosam itaque labore et cupiditate. Occaecati laboriosam possimus adipisci possimus ducimus ea necessitatibus. Eum ipsum eaque illo hic qui laboriosam libero et et.\n\nDoloremque natus sint eos. Quas ducimus id. Asperiores accusamus voluptas a et aliquam eum occaecati atque quia. Sed ipsa voluptatem consequatur labore provident sint.\n\nUt repellat qui ipsum omnis quos dolor labore inventore facere. A veniam voluptatem reprehenderit corporis velit aspernatur rerum qui excepturi. Possimus et consequatur a. Labore molestias eveniet rem maiores cum id soluta repellat est. Ea sunt rem officia laudantium minus sit qui. Sit non nihil eaque iusto harum et corrupti sed labore." },
                    { 50, 15, 193, "Magnam quis consectetur tenetur dignissimos eos id eum quisquam. Ratione recusandae sint totam rerum laborum necessitatibus harum. Labore iure est sit rem possimus fugit. Fugiat maxime praesentium dolor eos doloremque distinctio. Nisi in est quis incidunt suscipit corporis impedit consequuntur. Molestias quia tempora incidunt veniam.\n\nAnimi maxime deleniti error consectetur. Velit voluptas provident et dicta quaerat cupiditate quis. Quaerat soluta ut aperiam et quaerat enim ut dicta reiciendis. Numquam dolore autem. Id praesentium est rerum quaerat quis. Modi sequi at ducimus.\n\nEt numquam ducimus id ut id et perspiciatis. Dolore est aperiam nostrum nulla reprehenderit officia dolores. Hic sed sequi ullam fuga est quidem.\n\nArchitecto praesentium iure dolor autem numquam laborum. Accusamus non qui et rerum est. Repudiandae numquam alias at delectus odio temporibus harum sit." },
                    { 49, 99, 112, "Placeat est ab quia esse voluptatum rem iusto assumenda quis. Quo voluptatem atque maxime voluptas hic ex. Ut minima velit aliquam ea sint. Quia et veritatis porro architecto consequuntur totam rerum. Deserunt ipsa molestias libero voluptates molestiae.\n\nNemo sint velit. Eum facere et. Voluptas id aliquid harum unde reprehenderit est sed porro. Tempora quis ab exercitationem iure.\n\nVeritatis sequi et odio est rem. Aut ratione rerum dignissimos molestias animi autem corrupti ducimus voluptates. Occaecati sed aut officiis velit. Corporis hic rerum velit aut.\n\nNon eaque porro. Animi vel consequatur architecto dolores et eum ea dignissimos. Optio fugit saepe quod." },
                    { 21, 89, 127, "Cumque asperiores ab eum commodi voluptas. Ut voluptas eaque id eum sit sunt laboriosam officia. Consequatur beatae vero suscipit est quaerat.\n\nFacilis error impedit exercitationem deserunt mollitia placeat repellendus consequatur alias. Et expedita molestiae atque. Mollitia et non.\n\nOfficiis tenetur dolorem deserunt. Quaerat aut voluptatem ab explicabo id aut. Quisquam sed qui earum dolore dignissimos. Mollitia est sunt ratione occaecati eum culpa deserunt possimus quod.\n\nEarum voluptas est laborum rerum nihil aperiam laboriosam. Harum voluptatem voluptates praesentium quaerat sit impedit veniam tenetur et. Dicta ipsam omnis tempora eum soluta quasi. Soluta non qui nemo ut alias et impedit. Officia quaerat ut numquam odit quae sapiente sit distinctio est." },
                    { 36, 48, 113, "Ea quo tempora voluptate. Ex quis laborum voluptatibus quo. Porro et at molestiae dolore omnis minima. Omnis enim pariatur ut quia enim quia quidem et quos. Accusamus ut facere rem rerum cum deserunt reiciendis. Ducimus laborum magnam ea et quae.\n\nOdio consectetur ea rerum pariatur deserunt neque non. Itaque illo aspernatur consectetur quisquam ducimus sed. Voluptas beatae sapiente dolor ut.\n\nEt qui iusto dolorem inventore ducimus repellat consequuntur. Atque adipisci qui sunt consequatur. Hic officia perspiciatis. Quod ut debitis ut qui. Dolores et veritatis ut.\n\nRem dignissimos placeat quo accusantium nesciunt repellat. Odit earum molestiae dolorem nihil cupiditate porro doloremque voluptas. Magni autem quidem quidem aut fugit et iste nihil." },
                    { 26, 58, 114, "Aliquam qui autem veritatis deserunt consequatur. Porro dolores libero eveniet nam voluptatem facere doloremque et non. Eius vitae rerum.\n\nVelit dolore deserunt. Et consequatur quos iste aperiam. Velit ut ut culpa.\n\nIncidunt qui est dignissimos et culpa. Voluptatem vitae nihil tempore magnam odit. Aut id ab illo vel.\n\nPlaceat ipsa quo consequatur aut eos laudantium id dolor veritatis. Consequatur id maiores et fugit omnis voluptatem fugiat. Sit dolor odio sit labore qui cum consectetur aut. Sint sed nisi molestiae atque velit inventore iusto a porro. Cupiditate ullam commodi perferendis aut et quis vel quos quis. Unde aperiam libero." }
                });

            migrationBuilder.InsertData(
                table: "BookingMessages",
                columns: new[] { "Id", "ClientId", "PetsitterId", "Text" },
                values: new object[,]
                {
                    { 47, 34, 192, "Dolor consequatur non facere asperiores. Vel fugiat consequatur provident. Enim dolorem repudiandae.\n\nNostrum aut sint facilis porro ratione quidem maxime quasi rerum. Amet sint velit minima. Harum praesentium vitae aliquam quaerat. Ut occaecati qui tenetur.\n\nRerum ipsum porro quia quas quia labore aut. Velit ut doloremque minus amet nobis. Maiores adipisci repudiandae est magnam. Quidem nihil fugiat aut eligendi sed ut in.\n\nEum reiciendis quibusdam eveniet et itaque soluta maxime a. Et eius sint ab. Architecto quos amet provident hic eaque impedit. Aliquam provident aut autem qui atque. Nulla sit repudiandae." },
                    { 40, 86, 148, "Molestias voluptatibus doloribus sed maiores veritatis aut. Animi aut consequuntur voluptate dicta qui voluptate omnis. Magnam est cum nesciunt eum aspernatur.\n\nQuod fugit libero voluptas totam debitis. Fuga et nisi dolores autem nostrum sit ipsam velit eos. Corporis voluptatem perspiciatis beatae ullam tempora harum aut. Neque error ea quia. Et dolor et hic et voluptatibus dolores magni sit dolor. Eum repudiandae maiores aut quasi quis.\n\nMaxime autem distinctio aut nam. Odio dolores dolores et dolor inventore exercitationem modi est. Excepturi earum consequatur voluptas aut molestias quia vitae. Facilis sint enim est eos sequi temporibus dicta veritatis.\n\nVoluptate eveniet in. Doloribus nulla quidem voluptatum. Quisquam eos neque corporis quaerat animi. Consequatur quo esse labore." },
                    { 24, 48, 119, "Accusantium voluptatem sint quae et. Enim libero veniam mollitia praesentium incidunt qui fugiat. Sit reprehenderit minus. Quos sed est adipisci nihil unde perspiciatis nisi. Architecto recusandae ad nemo accusamus quia.\n\nNemo quam veniam inventore dolores aspernatur vitae neque earum. Nihil voluptatem possimus soluta ut qui aut nesciunt quia. Tenetur numquam et vitae sit. Mollitia aliquid quia sequi commodi ut iste velit officiis.\n\nLaborum ea sit facilis aperiam omnis. Voluptas vitae cumque reprehenderit officia qui quas quo delectus. Saepe sunt et sed qui voluptatem quas qui voluptas temporibus. Id nihil natus aut autem alias. Quibusdam consectetur distinctio et. Id et magnam fugit quia voluptas.\n\nEt alias qui nemo repellendus ab dolore rerum. Sint repudiandae consectetur. Laboriosam aut autem qui qui non qui enim repudiandae est. Ut rerum sit sapiente voluptatum." },
                    { 46, 78, 190, "Ducimus quae dolorum voluptas commodi amet velit qui. Culpa quidem odit sunt quaerat nihil explicabo. Et consequatur nulla aut quia accusamus nobis aspernatur a.\n\nIpsum tempore quaerat sequi. Occaecati ut earum eum itaque veritatis dolor quibusdam. Ea velit sit sit ad officiis commodi debitis consequatur doloribus. Reprehenderit et consequuntur quia itaque maxime.\n\nVeniam natus et voluptatem deleniti blanditiis sunt voluptates atque impedit. Nulla consectetur ab ab sapiente libero nam sint soluta. Voluptas nostrum et enim placeat quaerat. Modi voluptas ducimus adipisci expedita voluptatem excepturi in odio aut.\n\nNihil sapiente aut ipsum doloribus qui eius nisi. Dolorem molestias enim dolorem est excepturi occaecati. Inventore quae minus adipisci tempore. Porro quaerat fuga consectetur molestiae sed et occaecati. Consequuntur consectetur reiciendis odio aut quia officiis consequuntur provident." },
                    { 35, 7, 189, "Excepturi qui ipsa quibusdam aspernatur quaerat numquam. Eos corrupti perspiciatis labore magnam consequuntur. Nisi incidunt et aut iste vel minus et et. Aliquam sed voluptatibus quia. Vel cum mollitia doloremque rerum consequatur.\n\nAdipisci numquam cumque aut facilis. Dolorum eligendi recusandae. Illum dolores et illum a perferendis aut omnis distinctio.\n\nVoluptas qui incidunt tempora ea odit et facilis. Sit ea magni molestiae. Necessitatibus at nihil sunt eveniet dolorum iusto quia corporis. Impedit et error quisquam. Tempora dolorem nihil esse quidem ex quasi. Aut veniam repudiandae possimus ab impedit.\n\nConsequatur qui rerum et neque aspernatur. Voluptas quia ut sint voluptas veritatis sint molestiae. Ratione et repellat perferendis optio quo quis. Qui eum qui aut maiores et iure. Libero facere nisi nostrum dolorum et esse." },
                    { 25, 30, 121, "Eos est minus quia aliquam. Quia possimus nemo. Cum placeat qui deleniti qui eos debitis aut dolorum. Cum laboriosam quod incidunt enim suscipit ratione. Quis voluptate fugiat numquam rerum pariatur fugiat similique quis. Necessitatibus natus necessitatibus et alias.\n\nError labore nesciunt. Qui animi incidunt cum esse nam quibusdam doloremque quas. Sint debitis blanditiis totam ut molestiae praesentium et aut.\n\nAssumenda fuga dicta inventore distinctio laborum laboriosam officia magni. Explicabo maiores vitae laudantium consequatur id sed provident. Aperiam sed et in. Nobis iusto mollitia aut tempora rerum voluptas ea molestias a. Aut ratione dolorum.\n\nPraesentium dignissimos autem. Dolorem necessitatibus quis consequatur. Quia et ut. Laborum nostrum ut modi fugit autem tempora sit. Ea corrupti earum minus. Consequuntur velit fugiat blanditiis sint omnis." },
                    { 18, 16, 183, "Temporibus ipsum a qui animi sunt veritatis error deleniti sint. Non asperiores sunt adipisci quaerat illo. Molestiae esse qui mollitia debitis quia. Voluptatem laudantium mollitia. Ullam quos consequatur itaque totam aperiam optio voluptates modi.\n\nAut velit et sint facilis architecto quia. Et explicabo et dignissimos qui nemo. Consectetur nostrum placeat. Laboriosam odit totam autem sit. Sed enim non. Dolores aliquid eum et molestiae corporis fuga.\n\nNatus maiores dicta inventore provident. Reprehenderit ab rerum et consequatur nulla ea nesciunt. Est qui facilis ea aut quos cupiditate et est accusamus. Maxime beatae perferendis et consequatur rem distinctio. Amet aliquid magnam quae itaque sed autem reiciendis deleniti facilis.\n\nSunt consectetur earum qui non expedita eius est. Aperiam amet odio consectetur sapiente non enim aperiam quo. Eveniet sit rem ut sed ea ut." },
                    { 42, 21, 125, "Ad illum deleniti consequatur. Nemo eius in. Minima nisi ipsam sint magni reprehenderit voluptas.\n\nNemo doloribus reiciendis alias eligendi et necessitatibus. Sed eveniet eos. Dolore repellat ut facilis rerum. Quam quidem repellat eveniet maiores assumenda omnis facilis sequi labore. Fuga et voluptas repellendus.\n\nDicta neque enim consequuntur labore fugit architecto odit quia ut. Aperiam nisi est enim corrupti. Quam maiores sint velit alias non labore. Sunt et dolorem. Qui provident excepturi excepturi explicabo blanditiis atque.\n\nSit occaecati molestiae temporibus nam tempora quas laborum consequatur. Earum dolores asperiores et et eius. Vitae hic doloremque vitae ratione laudantium. Non molestiae consequatur maxime." }
                });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 161, 19.0, 71 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 160, 42.0, 30 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 165, 41.0, 24 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 131, 30.0, 9 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 189, 40.0, 13 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 110, 20.0, 72 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 136, 16.0, 76 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 134, 18.0, 7 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 107, 29.0, 42 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 129, 17.0, 51 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 171, 22.0, 77 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 182, 43.0, 25 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 188, 11.0, 16 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 179, 39.0, 6 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 188, 24.0, 14 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 148, 20.0, 22 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 151, 30.0, 71 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 175, 25.0, 34 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 156, 36.0, 28 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 105, 45.0, 54 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 135, 39.0, 37 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 160, 23.0, 60 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 121, 45.0, 7 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 195, 32.0, 22 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 123, 38.0, 58 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 144, 47.0, 47 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 185, 18.0, 59 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 122, 42.0, 79 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 170, 27.0, 97 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 192, 49.0, 27 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 119, 35.0, 84 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 114, 38.0, 44 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 199, 32.0, 29 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 104, 16.0, 27 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 138, 30.0, 56 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 194, 40.0, 52 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 168, 42.0, 13 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 171, 48.0, 20 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 169, 33.0, 14 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 193, 35.0, 91 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 188, 42.0, 30 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 191, 26.0, 77 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 194, 16.0, 9 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 101, 17.0, 45 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 140, 23.0, 82 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 105, 19.0, 84 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 131, 28.0, 77 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 169, 16.0, 25 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 117, 35.0, 48 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 168, 22.0, 46 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 112, 25.0, 6 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 191, 49.0, 16 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 136, 42.0, 48 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "PetsitterId", "Price" },
                values: new object[] { 111, 27.0 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 162, 37.0, 67 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 164, 25.0, 32 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 162, 22.0, 65 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 136, 16.0, 63 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 118, 12.0, 20 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 166, 22.0, 74 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 176, 35.0, 26 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 184, 26.0, 90 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 181, 37.0, 49 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 136, 24.0, 70 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 143, 40.0, 21 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 103, 33.0, 7 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 147, 16.0, 54 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 125, 42.0, 6 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 101, 27.0, 77 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 125, 48.0, 74 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 192, 40.0, 70 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 151, 40.0, 35 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 179, 41.0, 79 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 129, 43.0, 83 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 172, 48.0, 27 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 194, 27.0, 93 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 138, 15.0, 15 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 148, 18.0, 20 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 114, 18.0, 51 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 183, 15.0, 84 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 196, 40.0, 56 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 171, 50.0, 44 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 162, 44.0, 92 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 102, 21.0, 25 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 181, 38.0, 18 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 132, 42.0, 53 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 187, 43.0, 7 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 103, 33.0, 87 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 182, 30.0, 45 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 154, 44.0, 38 });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 130, 120, 28.0, 63 },
                    { 162, 164, 48.0, 63 },
                    { 225, 158, 33.0, 63 },
                    { 99, 131, 38.0, 94 },
                    { 187, 152, 18.0, 94 },
                    { 191, 141, 33.0, 67 },
                    { 144, 104, 34.0, 64 },
                    { 232, 159, 23.0, 89 },
                    { 174, 135, 21.0, 67 },
                    { 100, 117, 50.0, 90 },
                    { 136, 154, 28.0, 62 },
                    { 274, 188, 41.0, 64 },
                    { 96, 186, 10.0, 67 },
                    { 199, 136, 47.0, 66 },
                    { 175, 110, 26.0, 90 },
                    { 177, 171, 34.0, 65 },
                    { 91, 156, 48.0, 97 },
                    { 137, 150, 37.0, 93 },
                    { 257, 197, 34.0, 92 },
                    { 226, 138, 36.0, 92 },
                    { 201, 129, 48.0, 56 },
                    { 214, 148, 41.0, 92 },
                    { 228, 154, 25.0, 56 },
                    { 261, 167, 47.0, 56 },
                    { 263, 193, 27.0, 56 },
                    { 161, 147, 48.0, 92 },
                    { 237, 167, 21.0, 57 },
                    { 277, 182, 10.0, 92 }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 165, 145, 26.0, 58 },
                    { 217, 142, 35.0, 58 },
                    { 300, 156, 15.0, 92 },
                    { 105, 198, 40.0, 92 },
                    { 153, 176, 18.0, 59 },
                    { 221, 159, 17.0, 59 },
                    { 111, 158, 15.0, 93 },
                    { 283, 146, 41.0, 60 },
                    { 202, 151, 40.0, 94 },
                    { 171, 134, 25.0, 93 },
                    { 205, 161, 17.0, 89 },
                    { 252, 164, 24.0, 68 },
                    { 151, 142, 18.0, 68 },
                    { 244, 125, 38.0, 76 },
                    { 223, 193, 31.0, 98 },
                    { 248, 171, 15.0, 77 },
                    { 278, 139, 15.0, 86 },
                    { 170, 109, 33.0, 96 },
                    { 254, 101, 24.0, 86 },
                    { 192, 130, 24.0, 86 },
                    { 159, 176, 31.0, 86 },
                    { 293, 117, 34.0, 78 },
                    { 297, 144, 19.0, 79 },
                    { 97, 151, 49.0, 82 },
                    { 281, 181, 34.0, 82 },
                    { 270, 111, 20.0, 96 },
                    { 275, 196, 42.0, 97 },
                    { 234, 180, 40.0, 85 },
                    { 251, 131, 42.0, 83 },
                    { 197, 146, 25.0, 97 },
                    { 107, 168, 41.0, 97 },
                    { 290, 113, 44.0, 83 },
                    { 215, 120, 37.0, 76 },
                    { 194, 164, 26.0, 76 },
                    { 98, 140, 41.0, 96 },
                    { 122, 145, 22.0, 87 },
                    { 218, 193, 20.0, 68 },
                    { 230, 144, 17.0, 69 },
                    { 280, 176, 31.0, 69 },
                    { 291, 123, 38.0, 69 },
                    { 148, 101, 38.0, 70 },
                    { 258, 190, 37.0, 70 }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 196, 148, 25.0, 89 },
                    { 210, 198, 18.0, 94 },
                    { 164, 150, 41.0, 71 },
                    { 145, 176, 24.0, 68 },
                    { 143, 155, 37.0, 99 },
                    { 133, 166, 18.0, 72 },
                    { 167, 140, 41.0, 72 },
                    { 242, 137, 20.0, 95 },
                    { 262, 192, 47.0, 95 },
                    { 172, 198, 13.0, 73 },
                    { 216, 178, 35.0, 73 },
                    { 247, 112, 15.0, 73 },
                    { 253, 147, 29.0, 73 },
                    { 200, 177, 14.0, 74 },
                    { 176, 117, 35.0, 89 },
                    { 180, 103, 32.0, 54 },
                    { 193, 120, 40.0, 41 },
                    { 113, 146, 46.0, 54 },
                    { 150, 164, 12.0, 4 },
                    { 265, 165, 45.0, 11 },
                    { 173, 169, 43.0, 12 },
                    { 182, 169, 41.0, 17 },
                    { 204, 171, 34.0, 30 },
                    { 149, 178, 28.0, 10 },
                    { 206, 179, 10.0, 5 },
                    { 295, 182, 33.0, 25 },
                    { 160, 184, 19.0, 23 },
                    { 109, 187, 10.0, 16 },
                    { 141, 187, 31.0, 21 },
                    { 276, 189, 33.0, 25 },
                    { 227, 190, 24.0, 21 },
                    { 292, 194, 43.0, 8 },
                    { 219, 195, 16.0, 19 },
                    { 128, 196, 45.0, 17 },
                    { 189, 196, 30.0, 6 },
                    { 209, 198, 17.0, 8 },
                    { 120, 200, 22.0, 16 },
                    { 222, 200, 45.0, 30 },
                    { 264, 200, 39.0, 13 },
                    { 271, 163, 20.0, 31 },
                    { 139, 157, 49.0, 32 },
                    { 181, 149, 13.0, 32 }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 224, 199, 40.0, 32 },
                    { 94, 196, 10.0, 33 },
                    { 126, 129, 49.0, 33 },
                    { 233, 163, 28.0, 20 },
                    { 142, 101, 46.0, 33 },
                    { 125, 159, 27.0, 5 },
                    { 288, 155, 12.0, 30 },
                    { 231, 104, 40.0, 8 },
                    { 93, 109, 43.0, 2 },
                    { 138, 109, 40.0, 3 },
                    { 168, 110, 47.0, 24 },
                    { 166, 111, 19.0, 26 },
                    { 169, 111, 29.0, 8 },
                    { 115, 117, 34.0, 7 },
                    { 245, 120, 24.0, 11 },
                    { 119, 122, 12.0, 1 },
                    { 289, 126, 28.0, 24 },
                    { 121, 128, 44.0, 15 },
                    { 134, 129, 21.0, 6 },
                    { 103, 133, 44.0, 18 },
                    { 158, 134, 15.0, 22 },
                    { 299, 138, 31.0, 26 },
                    { 123, 140, 28.0, 15 },
                    { 157, 140, 48.0, 12 },
                    { 185, 140, 12.0, 5 },
                    { 163, 141, 20.0, 5 },
                    { 104, 144, 31.0, 23 },
                    { 286, 144, 30.0, 25 },
                    { 250, 145, 43.0, 8 },
                    { 213, 147, 28.0, 29 },
                    { 101, 150, 32.0, 9 },
                    { 108, 150, 32.0, 4 },
                    { 186, 150, 24.0, 1 },
                    { 239, 151, 11.0, 6 },
                    { 203, 156, 18.0, 11 },
                    { 114, 164, 30.0, 54 },
                    { 156, 107, 24.0, 33 },
                    { 284, 157, 11.0, 33 },
                    { 285, 187, 38.0, 43 },
                    { 294, 197, 36.0, 43 },
                    { 178, 129, 30.0, 44 },
                    { 235, 110, 20.0, 44 }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 246, 160, 15.0, 45 },
                    { 112, 184, 19.0, 46 },
                    { 102, 102, 21.0, 47 },
                    { 106, 184, 30.0, 47 },
                    { 131, 119, 25.0, 47 },
                    { 155, 176, 22.0, 47 },
                    { 260, 117, 27.0, 47 },
                    { 117, 103, 29.0, 48 },
                    { 183, 142, 44.0, 48 },
                    { 268, 120, 16.0, 48 },
                    { 279, 123, 13.0, 48 },
                    { 118, 121, 47.0, 49 },
                    { 207, 110, 17.0, 49 },
                    { 229, 159, 40.0, 49 },
                    { 238, 152, 23.0, 50 },
                    { 241, 112, 21.0, 50 },
                    { 198, 134, 34.0, 51 },
                    { 135, 160, 14.0, 52 },
                    { 140, 198, 30.0, 52 },
                    { 296, 199, 27.0, 52 },
                    { 190, 186, 24.0, 53 },
                    { 220, 139, 44.0, 53 },
                    { 249, 190, 33.0, 53 },
                    { 211, 141, 37.0, 43 },
                    { 256, 157, 25.0, 33 },
                    { 152, 172, 44.0, 43 },
                    { 259, 169, 39.0, 42 },
                    { 92, 164, 21.0, 34 },
                    { 110, 119, 26.0, 34 },
                    { 267, 131, 18.0, 34 },
                    { 272, 106, 22.0, 34 },
                    { 212, 164, 18.0, 35 },
                    { 287, 137, 16.0, 35 },
                    { 236, 186, 12.0, 36 },
                    { 95, 156, 46.0, 37 },
                    { 129, 194, 28.0, 37 },
                    { 132, 161, 26.0, 37 },
                    { 146, 146, 36.0, 37 },
                    { 124, 151, 47.0, 38 },
                    { 179, 146, 37.0, 38 },
                    { 195, 179, 19.0, 38 },
                    { 282, 118, 43.0, 38 }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 188, 183, 23.0, 39 },
                    { 273, 145, 29.0, 39 },
                    { 147, 177, 40.0, 40 },
                    { 208, 111, 32.0, 40 },
                    { 298, 157, 24.0, 40 },
                    { 127, 197, 39.0, 41 },
                    { 154, 120, 35.0, 99 },
                    { 266, 178, 24.0, 41 },
                    { 269, 123, 15.0, 41 },
                    { 184, 134, 15.0, 42 },
                    { 240, 181, 43.0, 42 },
                    { 255, 131, 42.0, 42 },
                    { 116, 146, 12.0, 43 },
                    { 243, 200, 40.0, 99 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DropColumn(
                name: "AvailabilityFrom",
                table: "Petsitters");

            migrationBuilder.DropColumn(
                name: "AvailabilityTo",
                table: "Petsitters");

            migrationBuilder.DropColumn(
                name: "AzureId",
                table: "Petsitters");

            migrationBuilder.DropColumn(
                name: "Country",
                table: "Petsitters");

            migrationBuilder.DropColumn(
                name: "Environment",
                table: "Petsitters");

            migrationBuilder.DropColumn(
                name: "ParcelAndHouseNumbers",
                table: "Petsitters");

            migrationBuilder.DropColumn(
                name: "Rate",
                table: "Petsitters");

            migrationBuilder.DropColumn(
                name: "Street",
                table: "Petsitters");

            migrationBuilder.DropColumn(
                name: "Title",
                table: "Petsitters");

            migrationBuilder.DropColumn(
                name: "ZipCode",
                table: "Petsitters");

            migrationBuilder.DropColumn(
                name: "AzureId",
                table: "Clients");

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImageId",
                table: "Services",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "PhotoId",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "City",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Password",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Petsitters",
                columns: new[] { "Id", "Address", "City", "Description", "Email", "Name", "Password", "PhoneNumber", "PhotoId", "Surname" },
                values: new object[,]
                {
                    { 31, "Frederik Heights", "West Ellen", "Enim tempore et aut labore repellendus officia ut omnis voluptate beatae voluptas quam non animi dolor et repellendus id aut quisquam ullam officiis ad dolores dolor cumque aut ab et.", "Andrew_Bogan31@hotmail.com", "Andrew", "bde4b865-eb27-44ca-8ad1-68511a4efb90", "910-546-9101 x100", "https://picsum.photos/640/480/?image=1033", "Bogan" },
                    { 59, "Schiller Haven", "Hayeschester", "Cum aut voluptatibus et veritatis quam et deserunt quia voluptatem magni placeat et hic dicta consectetur natus dignissimos sed voluptatibus commodi ad fugiat voluptatem cumque vitae vel maxime est est.", "Leona86@hotmail.com", "Leona", "6c77a083-0f44-4ea1-a75b-13f2227f2fe2", "1-293-543-7165", "https://picsum.photos/640/480/?image=541", "Ruecker" },
                    { 58, "Jones Coves", "Meganefort", "Ut quaerat sint ea et nihil eos eos deleniti tenetur non totam facilis voluptatem ullam atque quos natus placeat mollitia quaerat dolor aut dolores numquam minima quo debitis facilis provident.", "Holly_Rempel@gmail.com", "Holly", "9466e24e-bce1-43c8-9c4b-a68b0a58f4ab", "1-870-666-8960 x2958", "https://picsum.photos/640/480/?image=310", "Rempel" },
                    { 57, "Heaney Plain", "Schmelerburgh", "Nostrum iusto porro illum voluptates ullam minima ipsam sit architecto pariatur quia non qui nihil odio corrupti alias doloremque nihil illum quidem in et quia necessitatibus doloremque ullam temporibus adipisci.", "Angelica.Kertzmann42@yahoo.com", "Angelica", "3aa5f749-fabf-4c73-8546-341b8d62d94d", "894-574-0578 x25654", "https://picsum.photos/640/480/?image=33", "Kertzmann" },
                    { 56, "Schamberger Station", "Lenoraborough", "Laudantium cum nobis possimus hic quia incidunt placeat quasi doloribus quasi cupiditate est perferendis iste explicabo vitae fugiat in et nesciunt quo non cum labore velit nihil itaque amet esse.", "Estelle_Lind@hotmail.com", "Estelle", "014eebfe-3f1d-4837-8279-05d342e49e11", "1-663-715-4500 x565", "https://picsum.photos/640/480/?image=515", "Lind" },
                    { 55, "Bogisich Plains", "Koelpinhaven", "Iusto tenetur commodi itaque est eum consequatur nisi fugiat atque dolores voluptate ipsa incidunt quia perferendis excepturi beatae doloribus labore rerum voluptas nihil eveniet in quidem aut esse nihil enim.", "Kendra_Morar28@yahoo.com", "Kendra", "9120caf5-1067-417c-8943-48eeac2d230a", "(962) 314-0712", "https://picsum.photos/640/480/?image=353", "Morar" },
                    { 54, "Kunde Rest", "Brownville", "Et et et voluptate aperiam labore optio corrupti consequatur itaque natus saepe error omnis voluptas consequatur amet sit minima aperiam facere quia qui voluptas numquam et officiis optio fugit ducimus.", "Roxanne.Schulist90@yahoo.com", "Roxanne", "15a59d77-9c91-402a-b2a7-157cb9b95d00", "245.327.9869 x426", "https://picsum.photos/640/480/?image=626", "Schulist" },
                    { 53, "Baumbach Parkways", "Elsafort", "Ut esse sed impedit et dolorem exercitationem molestias quod ea nulla ad fugit quia et nihil eligendi ducimus consectetur iusto voluptate iure non in voluptas earum eius iure perferendis quos.", "Maxine_Boyle@gmail.com", "Maxine", "0e98ad13-3593-404a-a927-68f3b9978f77", "(491) 530-0528", "https://picsum.photos/640/480/?image=743", "Boyle" },
                    { 52, "Jamarcus Inlet", "Estherborough", "Quam qui aliquid commodi debitis quis consequatur eum maiores voluptatem praesentium earum temporibus nisi architecto excepturi omnis magni voluptatem debitis reiciendis ea possimus voluptas nesciunt illo magni atque voluptatibus dolor.", "Margarita28@gmail.com", "Margarita", "39c72db8-427e-4175-8911-8059b0f98805", "866-700-5155 x33473", "https://picsum.photos/640/480/?image=0", "O'Conner" },
                    { 51, "Israel Pine", "Port Eloytown", "Et fugiat quaerat fuga tenetur voluptates quia dolores et officiis consequatur ullam cupiditate tenetur aut aspernatur corrupti ad repellat voluptatum explicabo vel possimus adipisci eaque temporibus quia et temporibus corporis.", "Gerald.Bergstrom70@gmail.com", "Gerald", "37b10bc5-6c90-4c08-b48f-041c7eee8924", "929-589-3403", "https://picsum.photos/640/480/?image=495", "Bergstrom" },
                    { 50, "Kessler Track", "Kesslerchester", "Perspiciatis amet inventore qui officiis nemo laudantium sunt in aliquid repudiandae a et ut aliquid inventore beatae voluptates reprehenderit amet aut laborum pariatur fuga ex sint omnis sapiente enim officia.", "Jeremy.Rohan85@gmail.com", "Jeremy", "e9459fc5-3a15-4821-870f-3e3cb0c89196", "919-893-5464", "https://picsum.photos/640/480/?image=694", "Rohan" },
                    { 49, "Leannon Springs", "Spencerville", "Excepturi est reiciendis itaque ut consequuntur similique illum aut a soluta eligendi doloribus dolores sed voluptate numquam distinctio deleniti blanditiis iusto consectetur et deleniti quis qui ratione qui rerum et.", "Lisa.Shields@hotmail.com", "Lisa", "2cb51276-9c6d-42ab-8e93-265ce06ef1d1", "1-706-249-9186 x295", "https://picsum.photos/640/480/?image=207", "Shields" },
                    { 48, "Mann Summit", "Lake Montanafort", "Quas illum corporis veritatis voluptatem qui assumenda qui laborum quos dignissimos asperiores illo vero sequi distinctio asperiores sunt atque molestiae voluptatem vitae saepe autem et atque adipisci natus omnis architecto.", "Lucia64@yahoo.com", "Lucia", "5ea660f3-e3be-4351-9932-0fcf31aec99e", "1-562-631-8417", "https://picsum.photos/640/480/?image=50", "Prosacco" },
                    { 47, "Jones Viaduct", "Lake Milanshire", "Suscipit qui consectetur provident culpa eligendi ut reprehenderit omnis iste harum pariatur ipsam et quos itaque et quia quo et voluptatem aut et ea odit velit sint perferendis corrupti et.", "Melissa23@gmail.com", "Melissa", "46b86928-bf7a-4b61-8f74-445e60a9da64", "539.692.7953", "https://picsum.photos/640/480/?image=254", "Mueller" },
                    { 46, "Padberg Locks", "Lake Brigitte", "Labore veniam velit sit et architecto temporibus consequatur sit ab aliquam aut expedita quia et aut aliquam inventore ea occaecati rerum nemo voluptatem deleniti ea voluptatem nobis sed repellat iusto.", "Pat_Sipes92@yahoo.com", "Pat", "6d250e1e-51e5-4a00-83e0-aacad15a4025", "213-551-2827 x53794", "https://picsum.photos/640/480/?image=226", "Sipes" },
                    { 60, "Liza Expressway", "Lindgrenshire", "Blanditiis quidem accusantium dolorem blanditiis voluptatem ullam facere sit mollitia et placeat iusto est ratione eos molestiae est quas aut explicabo quisquam reprehenderit quos libero enim necessitatibus delectus est ex.", "Louise.Rath13@yahoo.com", "Louise", "4a7b5118-4d12-42a0-a42c-59f694963379", "920-543-2999 x64945", "https://picsum.photos/640/480/?image=380", "Rath" },
                    { 44, "Jaylin Bridge", "Port Alfside", "Officia saepe et aut sapiente recusandae esse nihil et accusamus ut unde tenetur beatae asperiores architecto ipsa quaerat quis pariatur iure dolorem quia blanditiis cumque eveniet quas repellendus qui voluptas.", "Maggie_Lynch19@gmail.com", "Maggie", "f1595b02-209f-44f1-8644-ee1e9a82cb18", "406.952.4175 x53315", "https://picsum.photos/640/480/?image=659", "Lynch" },
                    { 45, "Shayne Spurs", "Lake Emmet", "Quia cumque aperiam ducimus id autem est at fuga qui voluptas occaecati sint praesentium itaque eos eligendi rerum aut saepe aut est excepturi aut rerum cupiditate dicta velit deleniti et.", "Joanna49@yahoo.com", "Joanna", "38f04561-4bf9-4cac-8536-f76e69cae2bd", "1-808-547-7104 x633", "https://picsum.photos/640/480/?image=934", "Smith" },
                    { 32, "Brakus Union", "North Cierrabury", "Officia ea et molestias delectus aut sint qui numquam maxime molestias nam eveniet numquam et omnis enim odit ea pariatur nam est quidem voluptas numquam consequuntur qui ducimus reprehenderit sed.", "Alberto_Gutmann@yahoo.com", "Alberto", "baadd236-05e4-4a30-9b3f-1e388900fe17", "950-285-6007", "https://picsum.photos/640/480/?image=739", "Gutmann" },
                    { 33, "Dibbert Falls", "Elimouth", "Nisi accusamus asperiores perferendis praesentium nisi qui eius sed et sed et harum assumenda amet et quasi tempore blanditiis iste dolorem omnis magnam atque eum temporibus velit ipsum debitis quia.", "Felipe_Leannon@gmail.com", "Felipe", "e35f2bec-2255-4b3a-b6f5-8c55a5a82c7f", "(208) 670-2820", "https://picsum.photos/640/480/?image=767", "Leannon" },
                    { 35, "Trinity Hollow", "Bartellberg", "Repudiandae dolor minus nam ex sed quas officia facere aspernatur velit quia dolorum qui minus minima suscipit a maiores quidem et quia quis deleniti qui in provident in ipsam libero.", "Sara41@hotmail.com", "Sara", "4e45cc7d-ef1b-4231-bb9a-d9ce8ba13941", "1-468-390-4298", "https://picsum.photos/640/480/?image=417", "Bins" },
                    { 36, "Wyman Crescent", "Watersport", "Aut dolores repudiandae in eius sapiente accusamus nostrum qui provident pariatur animi porro fuga quia placeat pariatur praesentium consequuntur ut maxime quia in reprehenderit blanditiis id et tempore accusantium vel.", "Suzanne.Dietrich93@yahoo.com", "Suzanne", "6d57893d-bd71-49d8-a3db-1efd6e5e5b61", "1-857-682-8761 x207", "https://picsum.photos/640/480/?image=991", "Dietrich" },
                    { 37, "Lynch Land", "Dickinsonhaven", "Et molestiae enim excepturi dolor quia quae qui perferendis accusamus veniam enim eos cupiditate minima veniam aut animi non at ad magnam consequatur hic atque non voluptatem aut non iure.", "Bethany77@hotmail.com", "Bethany", "8033b810-808c-456a-943e-5d9f370e261b", "777-319-0516", "https://picsum.photos/640/480/?image=826", "Mann" },
                    { 34, "Roscoe Prairie", "Keeleyborough", "Earum aperiam ex at quo et voluptatem mollitia quasi vero impedit esse ab voluptatibus et dolorum officia debitis aut et sapiente officiis officia quasi ut maiores molestias ea reiciendis nobis.", "Meghan.Gleason92@gmail.com", "Meghan", "3b764cef-ada7-47ff-8b12-57502fbb4655", "(897) 676-5661", "https://picsum.photos/640/480/?image=779", "Gleason" },
                    { 39, "Purdy Inlet", "East Jesus", "Deserunt voluptatem eligendi omnis labore amet quia accusamus veritatis et deserunt voluptatum iusto aliquam ut rerum recusandae debitis voluptas porro magni fugit molestiae aut consequuntur deleniti et ex qui eum.", "Melba15@gmail.com", "Melba", "c77b43f0-2158-454f-a46c-c69ea4900a02", "(866) 821-2153 x5170", "https://picsum.photos/640/480/?image=721", "Littel" },
                    { 40, "Imani Wall", "Lake Alfredaville", "Cumque magni commodi dolores praesentium dolorem ratione reprehenderit ipsam id dolores officiis ut tempore reiciendis laudantium praesentium aut vitae saepe qui asperiores voluptatibus sit non neque consequatur exercitationem expedita laboriosam.", "Marcella.McDermott@yahoo.com", "Marcella", "35ede398-f037-4043-b72b-e9eedeaf828a", "840.445.7673 x822", "https://picsum.photos/640/480/?image=152", "McDermott" },
                    { 41, "Ortiz Fields", "South Rod", "Quaerat nisi maiores praesentium voluptas quisquam occaecati accusantium et vero numquam ad doloribus aut aspernatur est delectus sunt omnis temporibus iure nisi assumenda accusantium voluptatum aliquam expedita iusto ipsam delectus.", "Mandy63@gmail.com", "Mandy", "3db5a3f2-ee41-4ad9-9863-6686f76a0f45", "(587) 711-2218 x7949", "https://picsum.photos/640/480/?image=712", "Kuhn" },
                    { 42, "Fahey Creek", "Lebsackbury", "Autem facere maiores sequi et est qui quaerat dolores possimus atque qui officia provident consequatur in odit aut et exercitationem temporibus omnis culpa similique eveniet laboriosam labore officiis qui maxime.", "Juan_Lindgren57@gmail.com", "Juan", "4199f26c-1cb1-4765-baea-57a63eaad321", "1-332-495-9950", "https://picsum.photos/640/480/?image=574", "Lindgren" },
                    { 43, "Zita Locks", "West Erich", "Quia rem quaerat voluptas fugiat ut et et est alias animi ratione amet asperiores hic omnis fuga reiciendis optio nam perferendis et illo inventore omnis ullam qui similique possimus ut.", "Vicki.Hermann52@hotmail.com", "Vicki", "b816aaae-cc89-4165-9afb-c518a1e558df", "426.370.1424", "https://picsum.photos/640/480/?image=441", "Hermann" },
                    { 38, "Frami Camp", "West Melba", "Eos eligendi aliquid ut sequi sint velit nostrum aut dolores veritatis ab quidem sint dolor culpa non qui aut praesentium aut laborum molestias vitae magni quidem consequuntur accusamus nesciunt consequatur.", "Joshua76@yahoo.com", "Joshua", "353108b4-8f4b-4a14-9bc2-dedc9b78a821", "425-564-3060 x20613", "https://picsum.photos/640/480/?image=442", "Wisozk" }
                });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Inventore animi aut consequatur pariatur.", "https://loremflickr.com/320/240?lock=1593273893", 3, 1 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Velit soluta ut vero voluptatum.", "https://loremflickr.com/320/240?lock=699112102", 0, 1 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "In aut accusantium inventore ad.", "https://loremflickr.com/320/240?lock=783108421", 0, 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Soluta incidunt cum exercitationem amet.", "https://loremflickr.com/320/240?lock=1632747932", 3, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Description", "ImageId", "Unit" },
                values: new object[] { "Aut et inventore ex aut.", "https://loremflickr.com/320/240?lock=20025034", 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Description", "ImageId", "Unit" },
                values: new object[] { "Voluptas quia saepe earum est.", "https://loremflickr.com/320/240?lock=1733792009", 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Est alias quia ut nulla.", "https://loremflickr.com/320/240?lock=1387034100", 1, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Voluptatum ut quos doloribus debitis.", "https://loremflickr.com/320/240?lock=294141962", 0, 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Delectus modi dolorem ratione dignissimos.", "https://loremflickr.com/320/240?lock=395229782", 3, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "ImageId", "Unit" },
                values: new object[] { "Porro quod quas totam alias.", "https://loremflickr.com/320/240?lock=1797499681", 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Dolores omnis inventore et et.", "https://loremflickr.com/320/240?lock=2109180396", 2, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "ImageId", "Name" },
                values: new object[] { "Cumque pariatur dignissimos tenetur enim.", "https://loremflickr.com/320/240?lock=1957442382", 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Fugit laudantium natus aspernatur natus.", "https://loremflickr.com/320/240?lock=1522666881", 3, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "ImageId", "Name" },
                values: new object[] { "Unde consequatur ut non accusantium.", "https://loremflickr.com/320/240?lock=1996233359", 4 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Qui aspernatur mollitia accusantium quia.", "https://loremflickr.com/320/240?lock=641503537", 2, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Necessitatibus omnis molestiae eaque ab.", "https://loremflickr.com/320/240?lock=992154566", 4, 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Description", "ImageId", "Name" },
                values: new object[] { "Reiciendis qui eius necessitatibus consequatur.", "https://loremflickr.com/320/240?lock=1717711096", 4 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Dolore corrupti qui itaque omnis.", "https://loremflickr.com/320/240?lock=848024654", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Description", "ImageId", "Name" },
                values: new object[] { "Dicta dicta eos quaerat accusantium.", "https://loremflickr.com/320/240?lock=16952326", 1 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Et molestias tenetur tempora laborum.", "https://loremflickr.com/320/240?lock=708858163", 1, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Voluptatem voluptas explicabo reiciendis illum.", "https://loremflickr.com/320/240?lock=433432689", 3, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Description", "ImageId", "Name" },
                values: new object[] { "Consequatur tenetur quia aliquam illo.", "https://loremflickr.com/320/240?lock=1251311857", 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Assumenda quisquam quis et unde.", "https://loremflickr.com/320/240?lock=1553377512", 3, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Sit voluptatem debitis est nisi.", "https://loremflickr.com/320/240?lock=679990157", 3, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Dolores odit enim sunt sunt.", "https://loremflickr.com/320/240?lock=1541424634", 4, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Ipsa et blanditiis officia omnis.", "https://loremflickr.com/320/240?lock=963023015", 0, 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Description", "ImageId", "Unit" },
                values: new object[] { "Consequatur quidem exercitationem illo laborum.", "https://loremflickr.com/320/240?lock=631340919", 0 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Id ea est beatae illum.", "https://loremflickr.com/320/240?lock=1379883833", 4, 1 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Description", "ImageId", "Name" },
                values: new object[] { "Dolores soluta et quia non.", "https://loremflickr.com/320/240?lock=516374598", 2 });

            migrationBuilder.UpdateData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "Description", "ImageId", "Name", "Unit" },
                values: new object[] { "Enim deserunt et dolor ut.", "https://loremflickr.com/320/240?lock=1096849045", 2, 1 });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 24, 57, "Labore dolor enim eveniet alias voluptate rerum. Inventore sit culpa est temporibus. Quidem optio et ut. Eveniet non voluptatum quo unde maxime atque.\n\nDelectus enim alias voluptatibus. Et nesciunt sint quos voluptates alias ab quis aut. Accusamus omnis ut assumenda qui maiores sed quos ut.\n\nSit voluptas laudantium voluptas voluptatem occaecati. Rerum veniam maxime dolor mollitia minus. Ipsa quisquam sed sequi ut perspiciatis est aspernatur optio nulla.\n\nQuo error quaerat et qui expedita repellendus qui in. Qui qui omnis deleniti et est. Aperiam est dolorem ut necessitatibus voluptate voluptatem sit suscipit. Et vel incidunt quasi dolorum reiciendis quis aut fugiat. Pariatur molestiae cupiditate consequatur minima corporis. Ut voluptatum qui inventore saepe a enim distinctio." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 19, 35, "Sequi repellat aut corrupti at dolores rerum nisi voluptas. Placeat reprehenderit tempore qui enim voluptatibus aut dolorem ex. Qui omnis asperiores at itaque placeat omnis vero sapiente voluptate. Ea dolorem voluptatibus cum vel maxime. Tempore tempore rerum sapiente voluptatem iusto.\n\nIure quasi est. Omnis doloribus voluptatem officia labore. Alias magnam unde aut autem dolor. Sint quis reprehenderit error eligendi ratione. Ut tempore dolores nobis enim fuga odio natus consequuntur itaque.\n\nIpsum tempore vero voluptatum explicabo ut quod veniam. Dolores necessitatibus similique exercitationem eos in. Et suscipit odio optio et quibusdam. Debitis quos culpa.\n\nTenetur dignissimos quia laborum quod est laborum. Veritatis saepe exercitationem voluptas hic et excepturi id. Non iure qui quae eaque dolores temporibus et nam. Quis et reiciendis maiores excepturi a quia voluptas recusandae." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 9, 42, "Dolore et nisi ipsum eaque aut maxime. Veniam voluptatem explicabo. Adipisci dolorem similique sint rerum suscipit fugit. Et labore aspernatur. Voluptates repellendus quis. Sed in commodi excepturi odit omnis sed sit optio.\n\nIure et impedit sunt exercitationem rerum quam voluptatem magni. Voluptate doloribus eaque neque placeat est consequatur. Quaerat quaerat aliquam quod et occaecati nihil tenetur qui. Esse dolorum iure modi dolorum qui.\n\nNumquam voluptatem et velit. Laudantium labore enim magni officia voluptas. Ex dicta velit esse iusto. Dolores est alias. Eum nisi corporis delectus.\n\nIpsum amet consequatur blanditiis iusto deserunt voluptatum. Delectus inventore est temporibus et est reprehenderit sed fuga. Aut sit nihil ut. Iste sunt beatae sequi doloremque assumenda blanditiis eveniet cupiditate. Minus aut earum eius officiis repudiandae voluptas. Nisi qui vel exercitationem nihil ratione aliquid." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 8, 54, "Et sunt dicta. In vel commodi ex. Ducimus dicta excepturi neque dolore tempora. Unde ducimus ut facere voluptatem suscipit porro beatae sint. Voluptatem eum non et labore quas.\n\nDistinctio asperiores est ut perspiciatis ea molestias natus voluptas. Quaerat itaque numquam quae. Vel aut nisi commodi delectus placeat. At consequatur nobis asperiores omnis voluptatibus molestiae. Non culpa est suscipit officia incidunt quia facilis.\n\nDolore omnis aut omnis qui in. Numquam et unde repellat. Qui est beatae dolores eos rerum eius omnis at non. Est a soluta dolorem. Praesentium dolore quaerat nesciunt iusto accusamus quisquam doloribus sint corporis. Odit et suscipit beatae.\n\nIpsam odio repellat quaerat qui explicabo deleniti molestiae. Facilis porro et quia mollitia. Velit enim possimus expedita. Quo praesentium ad illo dicta. Quo blanditiis fugit placeat sint qui aliquam. Rerum et ipsum." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 1, 49, "Minus vitae modi alias commodi adipisci impedit ipsa optio. Culpa quam qui et vero neque. Ipsum quo quaerat voluptatem ipsam id magni ut quis ad.\n\nLabore est facere et excepturi aut autem ab illo est. Consequuntur velit quam voluptatem itaque doloremque. Dolore repellendus beatae tempora qui dolorem eveniet possimus. Deleniti explicabo minus doloribus et possimus. Blanditiis et dolorem sint. Optio deleniti fugit.\n\nVelit magni est eveniet nisi adipisci. Cumque accusantium dolorem qui. Ut qui id. Nobis eveniet tenetur voluptatem minus quas quis ut sapiente. Aut aut animi unde corporis sapiente. Consequatur facere assumenda voluptatem occaecati.\n\nDolores nostrum saepe officia quia dignissimos similique labore ipsam voluptatem. Qui nesciunt similique. Voluptates possimus laboriosam recusandae aut vitae magni aspernatur." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 26, 45, "Tempora eum quo id neque possimus illo dolorem. Est repellendus rerum occaecati saepe accusamus. Minima sed quisquam aut est exercitationem voluptas aut consequatur. Aliquam illum commodi adipisci velit est laudantium. Laboriosam velit voluptatum porro pariatur dolorem aut quod ad. Aut qui velit doloribus non.\n\nRerum qui illo ut recusandae maiores eum autem in. Ut laudantium dolore adipisci inventore deleniti facere. Praesentium ipsam error nobis saepe cumque aperiam. Ut aperiam esse.\n\nId doloremque quis totam qui. Accusamus ea nihil est et enim. Et minima accusantium odit sint.\n\nIusto placeat sit aliquam quaerat dolore aliquid et. Ducimus autem vel in labore et et officiis qui rem. Rerum voluptatem eaque. Rerum esse sunt fugiat facere asperiores iusto sed. Occaecati dolorem at aut sed quia. Inventore alias quos aut vero." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 27, 47, "Nulla voluptatem autem dignissimos. Omnis quis quo aliquid laborum nulla tempore occaecati fugit. Aut tempore debitis aut velit omnis nihil possimus cupiditate magni.\n\nExpedita veritatis consequatur aspernatur ut quos mollitia voluptates voluptas inventore. Et quod ut qui expedita quas ea libero. Necessitatibus sunt delectus sit nam asperiores libero.\n\nQui at ipsam quo saepe et. Perspiciatis excepturi corporis dolor et sed beatae tenetur. Tempora eos officiis. Voluptas aliquam neque laudantium totam asperiores dicta aspernatur.\n\nUnde dolorem eos corrupti ducimus quia. Illum pariatur voluptates quos fugit. Illo corrupti dolorum nobis dolores aut sit iusto at autem. Expedita qui est pariatur consequatur ut ut omnis sint. Possimus aliquid dolor." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 19, 52, "Velit quis sapiente eos est voluptatem odit reiciendis. Nemo deserunt sunt dignissimos repellat eligendi aperiam nemo eum. Sint excepturi ducimus hic consequatur. Velit voluptates ullam eos quo delectus et voluptatem ut accusantium. Eum est consequatur debitis qui officiis occaecati.\n\nLaudantium rem beatae veritatis voluptatem voluptatum rerum voluptas ut magni. Laboriosam deserunt velit qui aliquid consequatur voluptas aut laboriosam qui. Ut aut consequuntur sed et dolorem molestiae non rerum. Ea quam deleniti est fugiat ut illum commodi vitae sed. Velit veritatis tempora.\n\nOmnis cupiditate est doloremque molestias magnam. Quidem sunt odit itaque. Vero inventore ut.\n\nAperiam voluptatibus quia porro est occaecati. Voluptatem est quaerat consectetur quibusdam corrupti voluptates. Sapiente consequuntur enim ut sequi est quam odit velit nulla. Est ullam optio quas." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 20, 31, "Doloremque dolore et omnis dolorem consequatur sed aut vero doloribus. Quo vitae velit. Sequi minus temporibus. Ratione aut laborum officiis aut officiis in autem ad quia. Ut omnis architecto error.\n\nEveniet ut dignissimos saepe tenetur animi natus fugit. Aut et non quaerat. Est ut rerum culpa ipsa quam quis. Et magnam non. Nobis porro possimus voluptatum omnis sint voluptatem eum aliquam eum. Odit consectetur veniam ab possimus.\n\nMolestias ut sit dolor consequatur alias repudiandae quos cupiditate. Veniam aut dignissimos adipisci soluta doloremque. Nulla ea optio dolore omnis quia debitis quis reprehenderit necessitatibus. Iure possimus consequatur laborum nostrum ipsa maxime. Voluptates et ut facere natus enim asperiores eos aut qui. Voluptatem nihil nesciunt consequatur sed in odit et a inventore.\n\nAut aut vel odit assumenda sunt. Sint ea ducimus id quia aut dolores est. Reiciendis iste ut est." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 14, 56, "Tempora iure neque. Sit nihil temporibus necessitatibus. Velit autem rerum sit neque modi est iusto recusandae. Nihil est eaque ea impedit temporibus aut. In quo consequatur expedita occaecati quis enim debitis.\n\nQui sit reiciendis expedita nulla ex mollitia quia delectus tenetur. Suscipit sunt suscipit ut et eaque nihil consectetur accusantium. Nihil non repellendus reprehenderit dolor in. At ut repudiandae quis voluptas pariatur voluptatibus id omnis.\n\nNobis omnis officia qui voluptatem eum veritatis eos doloremque. Mollitia suscipit nulla nobis aliquid totam accusantium sed adipisci. Libero a voluptas ut optio.\n\nQuos est aliquid ullam consequatur doloribus qui. Ut accusamus animi consectetur a voluptas eaque. Alias quaerat recusandae et id." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 12, 45, "Ea dolor ipsum est et voluptatem. Voluptatibus corporis sunt. Cum blanditiis tempora nisi voluptatem dolor. Animi nihil molestiae. Itaque harum officia voluptas. Voluptas aut sint.\n\nQui vel aut non velit. Ut omnis voluptatum non et facere fuga est unde. Deserunt et molestiae. Dolor provident iste sed voluptas ut. Beatae enim ea consequatur. Sunt et veniam rerum numquam magni.\n\nQuod ab hic porro qui sit. Ut exercitationem reiciendis. Ipsum quos mollitia similique. Aliquam saepe quis officiis facilis ut labore sed quia. Sit natus voluptate et vel. Hic doloremque nam qui qui voluptas.\n\nProvident ut repellendus sit amet fugiat necessitatibus reiciendis. Esse iure quia omnis reiciendis facere. Consequatur eum molestias voluptatem alias ducimus. Iure neque quo eius laudantium recusandae. Veniam velit ea quo laboriosam voluptate deleniti voluptates non." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 12, 42, "Doloribus occaecati quos. Aut ad amet et facere sit numquam et. Quod qui ipsum.\n\nMolestiae quae nam dolores aut delectus quae. Ut asperiores ut ut eos earum et iure. Accusamus tempore perferendis dolore amet maxime repudiandae. Beatae qui inventore magnam nam vitae quod.\n\nHic nesciunt qui at unde cupiditate et sit non. Voluptatem at adipisci ad. Optio ut non dolores laudantium consequatur et corporis placeat. Saepe qui maiores reprehenderit soluta voluptates neque.\n\nAsperiores rerum asperiores et quia ratione. Sint aliquam unde necessitatibus cum. Accusamus quia omnis molestiae iste et asperiores iure impedit vero. Dolore et nihil nam earum dolore veniam eos." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 25, 43, "Nihil qui sed aliquid. Qui maiores facere. Non consequatur tenetur dolor quo aliquam ex sint qui. Veniam repellendus ut voluptate libero odio eligendi reiciendis aut ut.\n\nArchitecto officia asperiores nulla nulla. Necessitatibus necessitatibus itaque quisquam aut. Ipsam est facere rerum aut asperiores non earum tenetur.\n\nNihil ea quia provident voluptates velit voluptatum reiciendis corrupti eum. Recusandae commodi repellendus doloribus velit repellat doloremque error. Error nobis natus. Voluptatem est consequatur. Perferendis suscipit dicta enim aliquam officia similique corrupti libero. Reiciendis deleniti laudantium maxime et a est quo iure.\n\nQui non repudiandae. Omnis iusto quod quibusdam vitae molestias. Animi animi sapiente voluptatem." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 11, 53, "Eius quas quod dolor ab dicta deserunt illum et. Dignissimos enim ullam quo omnis et voluptate. Et quos sequi eum. Officia enim possimus debitis eos repellendus totam numquam. Aperiam laborum aut est voluptas.\n\nNemo dolorem et cum consectetur quidem velit et necessitatibus. Non quod error et amet dolorum iure consequatur sequi. Nostrum quia minus aperiam mollitia reprehenderit qui ad est. Voluptatem deserunt expedita ipsam laborum quia ut sequi et. Fugit quo doloribus voluptatem aliquam qui est accusamus nulla asperiores. Et nobis necessitatibus similique aut iusto.\n\nEt dolores et. Inventore nobis recusandae dicta. Illum eos beatae ut nemo. Placeat blanditiis eius impedit. Accusamus quod ad molestiae eligendi laboriosam aliquid et voluptas.\n\nNecessitatibus tenetur architecto cumque blanditiis consectetur id. Suscipit quia rerum in ab maiores repudiandae aliquam quos deleniti. Fugit aut qui consequatur. Veritatis eius dolores ut. Suscipit doloremque voluptatem quas nemo aut consequuntur neque." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 23, 49, "Quis quis blanditiis incidunt laboriosam tempora dignissimos omnis vitae. Molestiae et harum et nesciunt ratione et quidem labore. Et non alias nostrum voluptatem saepe quod perferendis. Explicabo rerum qui in voluptatem mollitia ex ex reiciendis. Doloribus ab omnis quidem voluptatum id eligendi officiis.\n\nVoluptatibus exercitationem ut sint et repellendus architecto consequatur neque. Dignissimos atque et doloribus doloribus aut optio ab consequatur aperiam. Autem necessitatibus sint dolore facilis corporis in non est. Voluptatem et velit consequatur et sint numquam quo. Occaecati doloribus consectetur et minima quas.\n\nEst et et rerum molestias facilis aut amet ea. Ut eius atque. Voluptas rem minima nihil quam incidunt. Amet inventore atque laboriosam. Sint vel animi qui quidem quod accusantium non non doloremque.\n\nSint quam consectetur dolorum in eos rerum dolores asperiores voluptatem. Quisquam repellendus vero vitae. Deserunt praesentium odio nihil corporis dolorum. Adipisci officia culpa esse. Consectetur a similique vel est nostrum voluptates. Ipsa natus temporibus." });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 42, 56.0, 2 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 46, 40.0, 13 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 44, 128.0, 28 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 32, 92.0, 6 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 41, 123.0, 25 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 45, 35.0, 7 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 53, 94.0, 8 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 45, 61.0, 5 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 41, 109.0, 1 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 38, 55.0, 7 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 45, 92.0, 19 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 59, 115.0, 1 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 39, 110.0, 14 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 50, 99.0, 29 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 56, 113.0, 8 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 44, 96.0, 11 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 48, 69.0, 12 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 58, 76.0, 12 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 50, 140.0, 27 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 59, 78.0, 6 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 43, 115.0, 7 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 49, 100.0, 18 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 60, 123.0, 13 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 33, 123.0, 6 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 42, 67.0, 4 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 59, 138.0, 20 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 48, 111.0, 27 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 34, 130.0, 21 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 57, 59.0, 18 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 35, 46.0, 9 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 54, 60.0, 11 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 38, 118.0, 7 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 57, 110.0, 8 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 34, 143.0, 14 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 54, 53.0, 16 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 47, 63.0, 17 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 33, 60.0, 22 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 31, 68.0, 12 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 52, 95.0, 10 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 57, 31.0, 22 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 41, 46.0, 26 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 50, 132.0, 9 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 46, 137.0, 4 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 48, 79.0, 3 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 38, 82.0, 14 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 52, 49.0, 11 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 50, 35.0, 11 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 59, 100.0, 2 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 57, 144.0, 24 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 59, 138.0, 16 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 36, 92.0, 30 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 50, 101.0, 23 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 55, 58.0, 4 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "PetsitterId", "Price" },
                values: new object[] { 41, 81.0 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 42, 106.0, 15 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 56, 141.0, 24 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 57, 147.0, 30 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 42, 77.0, 7 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 60, 126.0, 12 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 47, 90.0, 24 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 58, 100.0, 18 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 60, 39.0, 12 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 57, 114.0, 18 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 56, 56.0, 28 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 58, 68.0, 10 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 49, 97.0, 18 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 59, 30.0, 2 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 31, 94.0, 2 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 58, 122.0, 25 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 34, 75.0, 21 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 54, 72.0, 8 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 52, 81.0, 14 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 56, 44.0, 12 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 47, 54.0, 29 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 37, 39.0, 2 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 53, 141.0, 14 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 33, 126.0, 11 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 38, 118.0, 19 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 45, 95.0, 27 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 32, 99.0, 3 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 40, 136.0, 24 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 40, 110.0, 2 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 57, 134.0, 6 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 57, 53.0, 24 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 44, 41.0, 12 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 55, 30.0, 25 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 44, 73.0, 6 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 56, 71.0, 2 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 48, 108.0, 17 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 49, 97.0, 7 });
        }
    }
}
