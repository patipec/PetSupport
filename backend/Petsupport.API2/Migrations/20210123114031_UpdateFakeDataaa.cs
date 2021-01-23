using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Petsupport.API2.Migrations
{
    public partial class UpdateFakeDataaa : Migration
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
                value: new Guid("443a2f5b-41bd-4a63-960d-b9c2c731b8e7"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "AzureId",
                value: new Guid("ccabf005-941c-44c0-85de-e0901ac9f84c"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "AzureId",
                value: new Guid("a28defbf-29e7-4a0c-99f5-585fec08ba86"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "AzureId",
                value: new Guid("013cbc96-d27e-4964-9390-8c51b8548d3d"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "AzureId",
                value: new Guid("88dc5573-0fe0-4e02-b34a-e3150c91f367"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                column: "AzureId",
                value: new Guid("152b79c9-7baf-4e04-903f-c63e5223d1d0"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                column: "AzureId",
                value: new Guid("c07999fe-da88-4683-ac51-0697954cd5ef"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                column: "AzureId",
                value: new Guid("3016da7d-5b75-497b-bdf7-c814777206f7"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                column: "AzureId",
                value: new Guid("de2a8dad-753b-4d25-9c59-368916333843"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                column: "AzureId",
                value: new Guid("df58a510-30c1-4316-b5f5-77121ecebe05"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11,
                column: "AzureId",
                value: new Guid("b64dcc2d-3b30-4c65-b163-5383b63a9c5f"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12,
                column: "AzureId",
                value: new Guid("5c4b1fd8-f7d2-4015-90d1-2db2782c16a5"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13,
                column: "AzureId",
                value: new Guid("73ee0545-0290-45ff-8ea1-032b8fc9ccc4"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14,
                column: "AzureId",
                value: new Guid("112c168e-114e-4d99-9f63-255e17aaa51b"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15,
                column: "AzureId",
                value: new Guid("dc674972-a82c-4965-9af0-fdcc48f8bd68"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 16,
                column: "AzureId",
                value: new Guid("76f59062-fd2c-467e-819f-1a8c323e636e"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 17,
                column: "AzureId",
                value: new Guid("a136881a-4281-4cea-9590-abafc02597ae"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 18,
                column: "AzureId",
                value: new Guid("c186c52a-e2fa-4710-9921-9a06fb1408a5"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 19,
                column: "AzureId",
                value: new Guid("d1a49eff-2ff1-4c8d-ae2d-89dc6ea4c57f"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 20,
                column: "AzureId",
                value: new Guid("2ab74ff6-26f5-4685-85eb-4be7edfe7afe"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 21,
                column: "AzureId",
                value: new Guid("db9fce48-5cf9-40d3-bb5d-fe5f9e572603"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 22,
                column: "AzureId",
                value: new Guid("0aba8576-27bf-4bf7-b807-f385c793523b"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 23,
                column: "AzureId",
                value: new Guid("da605c4b-edc5-453e-838b-9b9c4656ae34"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 24,
                column: "AzureId",
                value: new Guid("c10c5ac5-3e0f-41f8-8c75-8b1bbf434db1"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 25,
                column: "AzureId",
                value: new Guid("c1969367-2ec4-4f24-96f5-f0edd077eae7"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 26,
                column: "AzureId",
                value: new Guid("ec950014-ebc1-4901-b7b3-d6fc1f9e7ab7"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 27,
                column: "AzureId",
                value: new Guid("e79cbc57-e80e-44a2-b39e-202cebd38d9a"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 28,
                column: "AzureId",
                value: new Guid("c4e898a0-dd7f-48c3-9c7e-ada9e6478945"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 29,
                column: "AzureId",
                value: new Guid("4389ebbd-6d96-4b8d-858b-4bf3e8920462"));

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 30,
                column: "AzureId",
                value: new Guid("8b2834db-c22e-41a6-aca7-2ce2b92ef348"));

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AzureId", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 100, new Guid("a5f15cb9-61b5-451d-b82c-3848e1c92386"), "Hector.Kilback22@gmail.com", "Hector", "1-288-747-4751 x08608", "Kilback" },
                    { 83, new Guid("72eaed33-b399-44fd-8be1-efe279979a80"), "Mike.Durgan@hotmail.com", "Mike", "1-626-843-5533 x93368", "Durgan" },
                    { 84, new Guid("228893c4-b4f2-4ff9-9fae-84bbc7f93a25"), "Mike.Renner23@yahoo.com", "Mike", "1-472-203-3735 x870", "Renner" },
                    { 85, new Guid("3118e0c6-2fe4-4b56-88cc-57e6a8901f46"), "Christopher_Kassulke@gmail.com", "Christopher", "537-957-5955", "Kassulke" },
                    { 86, new Guid("61a08a57-2bdc-4864-9078-d5cddfc2123c"), "Rodney.Bayer63@yahoo.com", "Rodney", "(900) 653-7830 x681", "Bayer" },
                    { 87, new Guid("b1908d53-43c9-4876-bd57-f86dd70f79ab"), "Rebecca_Lind26@hotmail.com", "Rebecca", "909-489-1949", "Lind" },
                    { 88, new Guid("f1331987-8cdb-414b-acc9-306e0d934e6e"), "Rufus.Okuneva16@gmail.com", "Rufus", "212-784-2338 x68206", "Okuneva" },
                    { 89, new Guid("f1c5eae4-6907-489d-a194-87a26eec607d"), "Randal.McDermott37@gmail.com", "Randal", "937-746-6693 x47030", "McDermott" },
                    { 90, new Guid("9d2ad1b9-5d96-437a-a561-f97b9c3cb3c5"), "Frankie28@hotmail.com", "Frankie", "245.926.9416 x7667", "Mante" },
                    { 91, new Guid("60aa333b-7e10-4b69-9275-5db710e42aa7"), "Carl_Maggio@gmail.com", "Carl", "(273) 985-5351", "Maggio" },
                    { 92, new Guid("e931a377-4c08-4a0e-981c-7069ce16687a"), "Lori.Emard94@yahoo.com", "Lori", "1-401-444-0460", "Emard" },
                    { 93, new Guid("c2be291d-b780-4f48-bcb4-62f3fd40392c"), "Josh93@gmail.com", "Josh", "(785) 202-3833", "Volkman" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AzureId", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 94, new Guid("6404aa3e-ee66-441e-8f76-9c6080d3594c"), "Kevin80@gmail.com", "Kevin", "(994) 662-5735 x2169", "Kshlerin" },
                    { 95, new Guid("a3199c2e-e81a-4f0d-ae46-172f389c1138"), "Jerry.Terry@gmail.com", "Jerry", "735-714-3762 x8420", "Terry" },
                    { 96, new Guid("bd8665eb-5bb5-4d70-b852-84958ab3bb66"), "Roberto_Goodwin@yahoo.com", "Roberto", "1-544-329-0627 x0241", "Goodwin" },
                    { 97, new Guid("dee160b1-636d-4606-88e3-42453ae828a1"), "Jana_Will27@hotmail.com", "Jana", "693.407.7151 x942", "Will" },
                    { 98, new Guid("68dae983-fd30-43f6-8bd3-edf7ebab7f69"), "Antoinette26@yahoo.com", "Antoinette", "1-534-847-8817 x2393", "Schneider" },
                    { 99, new Guid("1d25670d-80f8-47d9-9a80-f44e43980b71"), "Helen84@gmail.com", "Helen", "(419) 296-4702 x22389", "Hintz" },
                    { 82, new Guid("78c2d0f3-f7e8-4844-83e8-8ea9f4eafa89"), "Oliver66@yahoo.com", "Oliver", "714-375-9073 x463", "Bailey" },
                    { 81, new Guid("374f1881-6ca9-467a-aeb0-9ba8a8f5d911"), "Guillermo.Cruickshank13@yahoo.com", "Guillermo", "920-543-2999 x64945", "Cruickshank" },
                    { 31, new Guid("acd6f66b-8c9b-44fb-9ba8-e68fb515ffd3"), "Francis23@gmail.com", "Francis", "784.342.6059", "Nader" },
                    { 79, new Guid("947f4f18-1ebe-48c7-bdde-2394fe45f1c5"), "Drew_Conn84@hotmail.com", "Drew", "827.681.2288 x652", "Conn" },
                    { 40, new Guid("31228bed-c949-498f-bb1e-351bcdef5ce9"), "Herbert_Muller3@gmail.com", "Herbert", "1-856-661-2329 x6980", "Muller" },
                    { 41, new Guid("a1fb5cef-c23d-4532-879c-b7577efffc6e"), "Nicolas_Smitham68@gmail.com", "Nicolas", "949.285.0995 x496", "Smitham" },
                    { 42, new Guid("00b9873c-6893-4469-bde1-99d79ec68e0b"), "Carmen.Will25@yahoo.com", "Carmen", "1-263-650-6424", "Will" },
                    { 43, new Guid("40f0ea55-55e7-45ba-84ac-ed37a72aacc6"), "Amos.Heaney63@gmail.com", "Amos", "1-615-585-5782 x8761", "Heaney" },
                    { 44, new Guid("472ccd4a-6367-488b-98e6-61fda0fb7cc7"), "Shirley_Watsica@gmail.com", "Shirley", "1-876-617-8412 x713", "Watsica" },
                    { 45, new Guid("f7fca220-1861-4e79-9079-8f0220948131"), "Annie.Yost89@hotmail.com", "Annie", "(866) 497-7213 x7863", "Yost" },
                    { 46, new Guid("d6f5d942-f6a4-4138-99fb-3cb88fc34369"), "Tracey.Johnston6@yahoo.com", "Tracey", "958.224.2564", "Johnston" },
                    { 47, new Guid("3bb49dfe-fb66-4008-8010-6e6b258504c4"), "Donnie_Rau@yahoo.com", "Donnie", "342-684-0069", "Rau" },
                    { 48, new Guid("84d51d70-4253-4ea0-b47b-56618cfc1d11"), "Betsy86@gmail.com", "Betsy", "269.739.5552 x6949", "Powlowski" },
                    { 49, new Guid("073ea05c-db7f-4dac-88e9-491bdeb0b2e8"), "Jacob.McLaughlin@hotmail.com", "Jacob", "1-514-983-5864", "McLaughlin" },
                    { 50, new Guid("432f12d8-6e87-4dd6-a02f-e4cada63d924"), "Dolores29@gmail.com", "Dolores", "(591) 484-4169 x0183", "Bednar" },
                    { 51, new Guid("d1882c3c-b926-4369-9d93-937d6e976a5f"), "Dolores.Connelly69@yahoo.com", "Dolores", "(657) 748-7216 x637", "Connelly" },
                    { 52, new Guid("4a500533-15a4-4c5e-ac51-c2ebead48336"), "Rosalie.Nienow@yahoo.com", "Rosalie", "494-477-5098 x2291", "Nienow" },
                    { 53, new Guid("4c2e878b-3239-4a60-a088-0775fe29607d"), "Violet_Will@yahoo.com", "Violet", "692-967-4949 x192", "Will" },
                    { 55, new Guid("b4fc07f0-e1f0-432e-9015-787b76b4b9ea"), "Pam_Green@hotmail.com", "Pam", "1-211-699-5696 x6090", "Green" },
                    { 56, new Guid("b7f57237-99c7-4282-85cf-74db98e119f5"), "Calvin.Denesik@hotmail.com", "Calvin", "747.408.6872", "Denesik" },
                    { 57, new Guid("891d20fa-ebe1-4081-acb8-34eff9cc338f"), "Karl_Prosacco@yahoo.com", "Karl", "576.280.4134", "Prosacco" },
                    { 58, new Guid("4482395f-141f-4481-9fe7-de449aa909ef"), "Rachael_Schmidt97@hotmail.com", "Rachael", "788-375-7404", "Schmidt" },
                    { 59, new Guid("19c8bd46-33e2-4c22-8b80-9f389309f127"), "Harold.Huel@yahoo.com", "Harold", "1-512-682-7537", "Huel" },
                    { 80, new Guid("4f15879c-2a3d-4051-9fbe-036b5b083a06"), "Meghan_Hessel79@yahoo.com", "Meghan", "932-417-4203 x8919", "Hessel" },
                    { 60, new Guid("e4500b0a-9dcd-41a3-9e96-3cda7cba1f24"), "Nadine_Walsh54@gmail.com", "Nadine", "(462) 851-2035", "Walsh" },
                    { 39, new Guid("b1a7bfad-1ac8-49fa-a0b0-37b33d954b16"), "Mike_Mante26@gmail.com", "Mike", "606.854.4150", "Mante" },
                    { 38, new Guid("7f031b09-2399-4dde-9e9b-08d865f8f1f5"), "Genevieve_Treutel32@yahoo.com", "Genevieve", "817-343-2600 x1451", "Treutel" },
                    { 54, new Guid("ff0f702f-b8cc-47c7-9d30-1dee4c0d406f"), "Chad_Swift93@gmail.com", "Chad", "419-341-1570 x132", "Swift" },
                    { 36, new Guid("63d3c21a-96e7-441d-a7bd-25c66d104360"), "Roxanne.Bogisich85@gmail.com", "Roxanne", "1-883-736-8127 x5254", "Bogisich" },
                    { 78, new Guid("f5014387-a72b-49fd-bd22-0abeb57c4411"), "Pete.Gislason92@gmail.com", "Pete", "(606) 768-9602 x95809", "Gislason" },
                    { 37, new Guid("330cc9d5-5fdd-4e67-9728-a83cc979b2dd"), "Amos74@yahoo.com", "Amos", "541.782.4424 x0644", "Baumbach" },
                    { 77, new Guid("9ee23d49-f491-4e7d-bb42-a2a8216c8e36"), "Cesar_Walker@yahoo.com", "Cesar", "(731) 535-7442", "Walker" },
                    { 76, new Guid("5fabd31b-d9aa-487c-931a-69bdcb62e81f"), "Jeanne_Kemmer@yahoo.com", "Jeanne", "(735) 678-7749 x034", "Kemmer" },
                    { 75, new Guid("5902c662-353a-4c49-a1f5-0223b30c53bc"), "Jodi8@yahoo.com", "Jodi", "616.923.5249", "Jacobi" },
                    { 73, new Guid("31f9888e-acfe-4bc9-abb8-27db1a75a0bc"), "Loren.DAmore36@hotmail.com", "Loren", "1-346-988-6142", "D'Amore" },
                    { 72, new Guid("e750cff8-661f-4f3c-a2b6-c9e662565672"), "Gail27@gmail.com", "Gail", "323.569.9315", "Wintheiser" }
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "AzureId", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 71, new Guid("dfd909ef-0211-4dd9-b3c7-3172630027e4"), "Lucy.Carter@hotmail.com", "Lucy", "1-264-714-4323", "Carter" },
                    { 70, new Guid("d80dd99d-e6c7-4055-bb7c-2bdbed52ac31"), "Emanuel_Lakin@gmail.com", "Emanuel", "449-413-0052", "Lakin" },
                    { 69, new Guid("24b9888d-6fa2-4297-a805-ce6f963e73f3"), "Kristina46@yahoo.com", "Kristina", "550.204.1160", "Satterfield" },
                    { 68, new Guid("66a72d12-5bb5-4705-a515-930aa7fd3197"), "Diane19@gmail.com", "Diane", "1-734-829-3044", "Kuhn" },
                    { 74, new Guid("9df21701-2efe-4bcb-bcad-5c9d549c78cf"), "Santiago_Bauch@gmail.com", "Santiago", "1-493-596-8038 x44402", "Bauch" },
                    { 66, new Guid("54ca8f4d-4c29-41ed-a80a-ce10de2e2f4f"), "Dana.Walter2@yahoo.com", "Dana", "236.918.5103 x8345", "Walter" },
                    { 67, new Guid("b76f1aa9-b417-414e-866d-7a8e826ddf9c"), "Tonya_Gottlieb@gmail.com", "Tonya", "753-909-1673 x06775", "Gottlieb" },
                    { 33, new Guid("de6c58f5-deb6-40c3-b156-3ac6ac850996"), "Brandon5@gmail.com", "Brandon", "506.258.9932 x8062", "Kshlerin" },
                    { 34, new Guid("5094b011-7174-4a8f-aa40-c5b3c2271c54"), "Arnold.Langworth@hotmail.com", "Arnold", "263.914.7811", "Langworth" },
                    { 61, new Guid("974856eb-f31a-4514-9e29-4c0275030dbc"), "Francis.Hills48@yahoo.com", "Francis", "1-809-424-6416 x2884", "Hills" },
                    { 35, new Guid("8ddf3b84-888d-4a2e-a239-52b15544f20a"), "Tracy19@yahoo.com", "Tracy", "(204) 618-1349", "Bahringer" },
                    { 32, new Guid("2980fb5c-d584-4f4f-9d18-8095d948235f"), "Annie50@gmail.com", "Annie", "911.342.6637 x7540", "Reinger" },
                    { 63, new Guid("03b45eb6-8c41-4ec9-849f-f3cc35d96371"), "Krystal.Lueilwitz83@hotmail.com", "Krystal", "590-581-6904 x9008", "Lueilwitz" },
                    { 64, new Guid("4a7d7f44-02cb-4e8e-a5e4-b483abd556cf"), "Rita11@hotmail.com", "Rita", "561-273-3065", "Wilderman" },
                    { 65, new Guid("7ffe64f0-7df2-4b46-a4d7-4abd4e46b9fa"), "Leonard_Olson@yahoo.com", "Leonard", "918.981.8571 x170", "Olson" },
                    { 62, new Guid("1ce39c1d-10cc-495b-b32f-e3d78cb23291"), "Kim17@yahoo.com", "Kim", "1-970-631-5335", "Bruen" }
                });

            migrationBuilder.InsertData(
                table: "Petsitters",
                columns: new[] { "Id", "AvailabilityFrom", "AvailabilityTo", "AzureId", "City", "Country", "Description", "Email", "Environment", "Name", "ParcelAndHouseNumbers", "PhoneNumber", "PhotoId", "Rate", "Street", "Surname", "Title", "ZipCode" },
                values: new object[,]
                {
                    { 181, new DateTime(2021, 1, 23, 12, 18, 39, 844, DateTimeKind.Local).AddTicks(2642), new DateTime(2021, 10, 19, 17, 4, 9, 833, DateTimeKind.Local).AddTicks(2753), new Guid("6fb1c702-02c5-4ec7-b2f0-b5a40363bdc9"), "Radom", "Bhutan", "Quas inventore possimus voluptatum nam quia voluptate fuga odio sint ut veritatis in culpa magnam optio odio atque aliquam quas quis doloremque dignissimos tempora ex id iure aut commodi at.", "Hugh.Glover@gmail.com", "Provident sed veritatis id in.", "Hugh", "90873", "207.590.0746 x64901", "https://picsum.photos/640/480/?image=559", 4.9844230953531445, "Tevin Motorway", "Glover", "Voluptatum et.", "62503-3302" },
                    { 179, new DateTime(2021, 1, 23, 10, 58, 44, 790, DateTimeKind.Local).AddTicks(1116), new DateTime(2021, 2, 10, 19, 9, 43, 302, DateTimeKind.Local).AddTicks(7216), new Guid("8c068f07-9418-4306-9d44-86defde131ce"), "Gdynia", "Austria", "Ut enim quae quam ut quod quia dolorum reprehenderit omnis voluptatem mollitia corporis et ratione magnam ut accusantium rerum dolorem amet veniam et quis suscipit nisi explicabo odio dolore vel.", "Bert.Graham21@hotmail.com", "Doloremque omnis dicta iste facilis.", "Bert", "4653", "894-903-4097 x570", "https://picsum.photos/640/480/?image=630", 3.7729263504841022, "Bartoletti Cliffs", "Graham", "Aperiam est.", "08135-4922" },
                    { 178, new DateTime(2021, 1, 23, 5, 8, 26, 194, DateTimeKind.Local).AddTicks(9194), new DateTime(2021, 6, 2, 17, 52, 39, 389, DateTimeKind.Local).AddTicks(2411), new Guid("4d91c40f-bec9-48bd-b79d-bd34bacf34d8"), "Gdynia", "French Guiana", "Quis ut excepturi voluptatem ex dolores natus et quam quibusdam consequatur dolores dolorem debitis vel quas ipsa nisi suscipit quis quaerat quis ratione unde impedit qui pariatur minima quis qui.", "Alfred_Jacobi47@gmail.com", "Provident numquam alias facere delectus.", "Alfred", "02439", "393.959.2001", "https://picsum.photos/640/480/?image=259", 3.2833328239076458, "McClure Stream", "Jacobi", "Delectus reprehenderit.", "06477" },
                    { 177, new DateTime(2021, 1, 23, 1, 8, 36, 239, DateTimeKind.Local).AddTicks(4581), new DateTime(2021, 7, 9, 11, 4, 29, 481, DateTimeKind.Local).AddTicks(3158), new Guid("b7076e58-6c27-4a50-8122-9797df67446e"), "Warsaw", "Philippines", "Quia placeat nisi dolorem cumque fugit sed nihil doloribus quae velit aut quis repudiandae animi aliquam magni et veniam aut enim voluptatem cumque nesciunt veritatis qui porro ut saepe similique.", "Kristen70@gmail.com", "Doloremque reprehenderit aut quae sit.", "Kristen", "14201", "261.518.4231 x605", "https://picsum.photos/640/480/?image=525", 1.5909889343152703, "Cleveland Knolls", "Brown", "Et quod.", "91283" },
                    { 176, new DateTime(2021, 1, 23, 9, 40, 0, 699, DateTimeKind.Local).AddTicks(4675), new DateTime(2021, 2, 11, 7, 20, 18, 720, DateTimeKind.Local).AddTicks(1049), new Guid("2656db26-0238-4b4d-b6fb-a805b9be607a"), "Warsaw", "Lao People's Democratic Republic", "Dignissimos itaque illum quod praesentium rerum ipsum ut odio doloremque quo at omnis unde iste eum et nostrum quidem quisquam aut eum qui et et tempore amet quidem dolore eum.", "Rodney_Smitham@gmail.com", "Dignissimos fuga repellendus accusamus et.", "Rodney", "736", "774.935.6480", "https://picsum.photos/640/480/?image=935", 1.2333107498629534, "Goodwin Circle", "Smitham", "Aut itaque.", "52311" },
                    { 175, new DateTime(2021, 1, 23, 1, 35, 14, 380, DateTimeKind.Local).AddTicks(2865), new DateTime(2021, 10, 29, 17, 36, 17, 905, DateTimeKind.Local).AddTicks(7258), new Guid("1388f7f2-790d-438d-97da-bad2752bdbfa"), "Warsaw", "Spain", "Non repellendus sunt est nihil aut vel qui est dignissimos occaecati reiciendis sequi doloribus delectus necessitatibus quis ut id officia commodi autem vel accusamus pariatur nobis recusandae ipsum omnis dolores.", "Kate.Effertz75@yahoo.com", "Dolores magni aut reprehenderit quo.", "Kate", "135", "454-938-3295 x0979", "https://picsum.photos/640/480/?image=169", 3.4792485863339384, "Amaya Lock", "Effertz", "Voluptas beatae.", "27799" },
                    { 171, new DateTime(2021, 1, 22, 21, 8, 26, 279, DateTimeKind.Local).AddTicks(7308), new DateTime(2021, 12, 25, 10, 22, 22, 290, DateTimeKind.Local).AddTicks(9382), new Guid("701cdcac-70a6-4337-8822-0ce1c2bb2c07"), "Warsaw", "Tunisia", "Molestiae vitae voluptatibus vitae consequatur tenetur doloremque voluptatibus eaque architecto placeat nemo inventore dicta incidunt nulla esse mollitia consequuntur commodi officia quis rerum et aut nemo tenetur non nemo aut.", "Leland68@gmail.com", "Quidem eos commodi aut optio.", "Leland", "021", "913.552.8777", "https://picsum.photos/640/480/?image=616", 4.1419811766324477, "O'Connell Mills", "Rau", "Minus explicabo.", "23406-7602" },
                    { 173, new DateTime(2021, 1, 22, 16, 8, 25, 748, DateTimeKind.Local).AddTicks(1529), new DateTime(2021, 3, 27, 13, 9, 10, 573, DateTimeKind.Local).AddTicks(9780), new Guid("24b13249-4cfe-4c16-a8bf-085cfa64123a"), "Warsaw", "Sao Tome and Principe", "Rerum sed unde cumque eaque quidem et eaque quisquam maiores eaque quia minus accusamus veniam exercitationem doloremque nobis praesentium dolorem minus dolorem velit quasi corrupti rerum assumenda voluptate cum tenetur.", "Lindsey90@hotmail.com", "Deleniti non explicabo et dolore.", "Lindsey", "81352", "891.515.2041 x97479", "https://picsum.photos/640/480/?image=672", 2.7115153790039548, "Hessel Walks", "Gutkowski", "Porro sint.", "96082-8855" },
                    { 172, new DateTime(2021, 1, 22, 23, 39, 0, 990, DateTimeKind.Local).AddTicks(3360), new DateTime(2021, 4, 3, 7, 32, 57, 132, DateTimeKind.Local).AddTicks(6712), new Guid("378e8d1c-2771-400e-8427-05f46c39695e"), "Radom", "Thailand", "Harum enim exercitationem enim voluptatem ut rem eaque nostrum tempore optio ut molestiae minus veritatis non ut veniam ea deserunt error commodi repudiandae maiores dolore tempore quam qui iusto doloribus.", "Owen_Padberg72@hotmail.com", "Qui nemo veritatis aliquid molestiae.", "Owen", "9187", "(388) 492-6994 x397", "https://picsum.photos/640/480/?image=739", 3.737436206423415, "Streich Expressway", "Padberg", "Neque ut.", "89980-0169" },
                    { 170, new DateTime(2021, 1, 22, 16, 23, 25, 135, DateTimeKind.Local).AddTicks(6850), new DateTime(2021, 2, 7, 17, 50, 43, 885, DateTimeKind.Local).AddTicks(6286), new Guid("6219d663-bb4c-4169-a297-15dbdf119df8"), "Gdynia", "Uzbekistan", "Dolore voluptatem eius exercitationem quibusdam suscipit voluptas aut commodi labore maxime sunt est facilis porro a est ullam et ducimus hic voluptatem consequatur esse culpa modi et qui sapiente dolore.", "Vicki57@gmail.com", "Dolores quidem quo et voluptatibus.", "Vicki", "559", "409-504-2858 x7691", "https://picsum.photos/640/480/?image=198", 2.3469698081477404, "Markus Green", "Hand", "Eveniet numquam.", "20426" },
                    { 169, new DateTime(2021, 1, 22, 20, 19, 52, 90, DateTimeKind.Local).AddTicks(7032), new DateTime(2021, 12, 5, 15, 18, 2, 131, DateTimeKind.Local).AddTicks(5926), new Guid("375e0835-6b9f-4120-98af-ddb72ca85c1f"), "Warsaw", "Australia", "Eius aut cum tempora ullam alias necessitatibus placeat aliquam asperiores eveniet incidunt blanditiis et unde eos exercitationem consequatur ut velit dolore laudantium consectetur ad et sequi voluptatem pariatur architecto et.", "Marsha16@gmail.com", "Assumenda dolor temporibus molestiae possimus.", "Marsha", "579", "581.458.2226 x850", "https://picsum.photos/640/480/?image=491", 2.6368851483039952, "Bayer Row", "Lesch", "Necessitatibus aliquid.", "37237" },
                    { 182, new DateTime(2021, 1, 23, 7, 0, 25, 368, DateTimeKind.Local).AddTicks(9313), new DateTime(2021, 2, 19, 18, 13, 26, 339, DateTimeKind.Local).AddTicks(9045), new Guid("3e98ba95-df9a-47dd-a476-77d32bf1b90c"), "Warsaw", "Haiti", "Incidunt et dignissimos vel voluptate non quia nemo ipsam esse magni nostrum consequatur ratione sint temporibus recusandae cumque nostrum veritatis rerum voluptatem animi fugit hic eum sequi cupiditate fugit debitis.", "Kent.Jacobs2@gmail.com", "Voluptas eos voluptatem inventore mollitia.", "Kent", "46169", "616.522.0626", "https://picsum.photos/640/480/?image=190", 2.8560199522674177, "Feil Ford", "Jacobs", "Ut facilis.", "14658-6010" },
                    { 168, new DateTime(2021, 1, 22, 19, 59, 50, 669, DateTimeKind.Local).AddTicks(1988), new DateTime(2021, 10, 26, 23, 8, 46, 438, DateTimeKind.Local).AddTicks(974), new Guid("b8762def-ccba-440f-bed5-8dedf99e1365"), "Radom", "Chile", "Dicta magni natus autem nemo ullam id qui voluptates corporis eum accusamus iusto dolor commodi consequuntur accusamus aspernatur molestiae sed aliquid quas ut quae nulla earum quis aut voluptas eos.", "Grady66@hotmail.com", "Amet autem quia enim culpa.", "Grady", "752", "(850) 223-6139", "https://picsum.photos/640/480/?image=799", 1.4972725363901223, "Gislason Crescent", "Kovacek", "Dignissimos qui.", "65298" },
                    { 174, new DateTime(2021, 1, 23, 0, 59, 9, 112, DateTimeKind.Local).AddTicks(8567), new DateTime(2021, 6, 11, 4, 39, 40, 849, DateTimeKind.Local).AddTicks(3018), new Guid("844b1ffb-b337-4a74-a676-74207035f794"), "Radom", "Hungary", "Quia autem nemo autem voluptatem ut reiciendis est consequatur similique sapiente consequatur et omnis et eum officiis repellendus ex consequuntur id repellendus velit libero nihil nostrum mollitia architecto aut odio.", "Noel_Hilll11@gmail.com", "Rerum dicta minus autem et.", "Noel", "26862", "496.669.5138 x19121", "https://picsum.photos/640/480/?image=386", 3.1551468065730979, "Heaney Extension", "Hilll", "Quam quia.", "18618-2141" },
                    { 183, new DateTime(2021, 1, 23, 8, 32, 3, 480, DateTimeKind.Local).AddTicks(6448), new DateTime(2021, 4, 13, 7, 38, 39, 614, DateTimeKind.Local).AddTicks(1760), new Guid("510a7b68-2f40-4488-8bde-13b611a9ae0f"), "Radom", "Niue", "Libero omnis blanditiis rerum ducimus dolores et dolor eius dolorem ipsa asperiores consequuntur non labore et doloribus neque voluptas est ipsa minima ex beatae voluptas adipisci animi accusamus beatae rerum.", "Brad.Fisher@yahoo.com", "Dolores vero perferendis iure velit.", "Brad", "3549", "1-335-554-9879", "https://picsum.photos/640/480/?image=504", 1.3077908010723958, "Noemie Mills", "Fisher", "Quia sequi.", "79054" },
                    { 195, new DateTime(2021, 1, 22, 22, 54, 36, 476, DateTimeKind.Local).AddTicks(5901), new DateTime(2021, 6, 29, 21, 56, 28, 511, DateTimeKind.Local).AddTicks(384), new Guid("270482bf-6c76-4637-badc-98e579385077"), "Gdynia", "Benin", "Ut illum labore quia culpa molestiae nemo quos rem omnis dolores voluptas officia nihil numquam vel occaecati et sed dolorem qui ut nemo ullam at non cumque porro id inventore.", "Julia4@hotmail.com", "Delectus excepturi itaque rem et.", "Julia", "929", "(911) 573-1277", "https://picsum.photos/640/480/?image=105", 3.7693714195719785, "Collier Cliffs", "DuBuque", "Nemo est.", "51262-5889" },
                    { 185, new DateTime(2021, 1, 22, 18, 38, 14, 799, DateTimeKind.Local).AddTicks(4632), new DateTime(2021, 5, 4, 11, 13, 44, 292, DateTimeKind.Local).AddTicks(9784), new Guid("12a7d4e1-9ea1-468f-9e27-90080a77a9b9"), "Gdynia", "Mozambique", "Saepe voluptates sed hic voluptas voluptatem aspernatur cumque sequi cum rem ut dolores dolor sint sed et et sint neque est aperiam molestiae molestiae et eum animi rerum reiciendis ex.", "Carole_Gleichner@hotmail.com", "Maiores omnis sit dolores unde.", "Carole", "0130", "(982) 591-0590 x04140", "https://picsum.photos/640/480/?image=777", 2.9763482240849868, "Coy Skyway", "Gleichner", "Sapiente eos.", "77383-5722" },
                    { 167, new DateTime(2021, 1, 23, 0, 6, 39, 704, DateTimeKind.Local).AddTicks(8961), new DateTime(2021, 4, 4, 3, 8, 30, 623, DateTimeKind.Local).AddTicks(8338), new Guid("151e7b5a-c892-4053-84f7-4b62e87df089"), "Warsaw", "Yemen", "Quia eos cupiditate aliquam rem praesentium ut accusamus et sint et hic sed rerum optio dolore corporis incidunt ullam at ex autem ad labore odit iste maiores eum repudiandae doloribus.", "Donald_Predovic@hotmail.com", "Possimus voluptatem esse qui quis.", "Donald", "90423", "234-833-5749 x78167", "https://picsum.photos/640/480/?image=1076", 3.1804939928373761, "Tobin Court", "Predovic", "Aliquid harum.", "59691" },
                    { 200, new DateTime(2021, 1, 23, 11, 4, 19, 416, DateTimeKind.Local).AddTicks(6827), new DateTime(2021, 8, 4, 13, 59, 5, 965, DateTimeKind.Local).AddTicks(4426), new Guid("6b01f9cf-ce38-4d0a-ba8f-ced15fd4b34c"), "Radom", "Myanmar", "Sed iure sed aspernatur aut autem inventore doloribus qui vero illum quia rerum unde voluptatem error voluptatem blanditiis commodi est est rerum ut fugit nam cum in velit aliquid quia.", "Essie42@yahoo.com", "Pariatur dicta et suscipit eius.", "Essie", "0300", "1-906-290-6726 x3597", "https://picsum.photos/640/480/?image=914", 3.512348233960731, "Dorian Squares", "Will", "Est quaerat.", "01981-7751" },
                    { 199, new DateTime(2021, 1, 22, 14, 27, 25, 31, DateTimeKind.Local).AddTicks(1340), new DateTime(2021, 7, 15, 14, 24, 28, 527, DateTimeKind.Local).AddTicks(9282), new Guid("7a55858f-9389-4372-90cf-b5dda0d4331d"), "Warsaw", "Falkland Islands (Malvinas)", "Ut aut aut sed quod non officiis ut officiis quo aliquid rerum voluptatum odio consectetur ducimus qui et et harum qui voluptatem repellendus molestiae ex harum sunt exercitationem in sint.", "Mario92@hotmail.com", "Aspernatur unde omnis aut iusto.", "Mario", "7381", "644-883-2784", "https://picsum.photos/640/480/?image=154", 4.2390703853401686, "Wilbert Corners", "Walter", "Sed sint.", "79774-5451" },
                    { 198, new DateTime(2021, 1, 22, 21, 6, 31, 287, DateTimeKind.Local).AddTicks(5016), new DateTime(2021, 1, 29, 4, 14, 31, 282, DateTimeKind.Local).AddTicks(2432), new Guid("96a6e2e9-5e78-4a90-a3ed-cc8353603f9e"), "Warsaw", "Croatia", "Rem culpa architecto ut voluptatem blanditiis eaque omnis ut saepe harum et animi a labore aut a voluptate excepturi iure labore et iste repellendus ipsa ducimus doloremque explicabo ea praesentium.", "Pam_Fisher@yahoo.com", "Ullam sapiente dolorem expedita ea.", "Pam", "645", "1-583-603-7945 x156", "https://picsum.photos/640/480/?image=960", 1.0544835999861748, "Blanda Field", "Fisher", "Qui quaerat.", "93730" },
                    { 197, new DateTime(2021, 1, 23, 6, 29, 40, 972, DateTimeKind.Local).AddTicks(1924), new DateTime(2021, 4, 8, 14, 35, 0, 595, DateTimeKind.Local).AddTicks(300), new Guid("46746ab5-3e01-4064-b7cb-b3f540747f22"), "Warsaw", "Japan", "A architecto quod numquam blanditiis sit explicabo iusto sunt ad nostrum et unde dolorum laudantium et exercitationem omnis in ut tempore perferendis dolor perferendis aut rem eum nulla et debitis.", "Justin_Schamberger0@gmail.com", "Corporis eos rerum sit earum.", "Justin", "578", "876.865.0352 x941", "https://picsum.photos/640/480/?image=740", 2.4076042628882472, "Ondricka Hill", "Schamberger", "Qui minima.", "82225" },
                    { 196, new DateTime(2021, 1, 22, 16, 27, 57, 321, DateTimeKind.Local).AddTicks(9481), new DateTime(2021, 11, 17, 15, 50, 50, 116, DateTimeKind.Local).AddTicks(9293), new Guid("bc8a3796-48cc-4956-add2-84ceb6287c90"), "Radom", "Micronesia", "Et dolor cum culpa adipisci cum vel minima dignissimos sint debitis molestias velit sunt dolorem totam aspernatur deserunt assumenda corporis tempora minima autem qui alias aut iusto ut corrupti nostrum.", "Daisy.Romaguera@yahoo.com", "Qui eum vero culpa amet.", "Daisy", "130", "1-720-360-2088 x63524", "https://picsum.photos/640/480/?image=17", 4.2463600538886901, "Rosemary Mountain", "Romaguera", "Dolor repellat.", "44612-9680" },
                    { 194, new DateTime(2021, 1, 23, 7, 36, 8, 280, DateTimeKind.Local).AddTicks(7678), new DateTime(2021, 7, 1, 14, 30, 7, 323, DateTimeKind.Local).AddTicks(6421), new Guid("3abc10ca-580d-4382-b63b-5bcdefcae60b"), "Warsaw", "Ecuador", "Sit accusantium odio consequatur facere harum numquam eius minima beatae nostrum voluptatem voluptatem quis quidem officiis nobis vitae labore illo provident voluptatem reiciendis nam nisi tenetur nihil eaque perferendis quis.", "Jimmy_Kris6@gmail.com", "Optio ab est laudantium quibusdam.", "Jimmy", "845", "1-932-963-7437 x19419", "https://picsum.photos/640/480/?image=91", 3.1858410826818275, "Balistreri Orchard", "Kris", "Cumque non.", "95985-6557" },
                    { 193, new DateTime(2021, 1, 23, 9, 32, 42, 468, DateTimeKind.Local).AddTicks(9848), new DateTime(2021, 10, 12, 4, 22, 11, 169, DateTimeKind.Local).AddTicks(8331), new Guid("5a1f2c9e-52fd-4ac4-b9da-9ca000d2bee5"), "Gdynia", "Martinique", "Officiis occaecati et neque possimus ullam ut voluptatem excepturi ullam harum sequi quae accusamus magni neque est atque deserunt est asperiores quisquam dolores et delectus minima qui quasi nesciunt ad.", "Brad_Blick@gmail.com", "Animi illum voluptas voluptatem voluptatem.", "Brad", "2652", "300-586-2205 x072", "https://picsum.photos/640/480/?image=132", 2.9056445387684016, "Bernhard Manors", "Blick", "Neque quia.", "33605" },
                    { 192, new DateTime(2021, 1, 22, 23, 11, 7, 234, DateTimeKind.Local).AddTicks(4019), new DateTime(2021, 2, 24, 18, 0, 0, 963, DateTimeKind.Local).AddTicks(8849), new Guid("53977216-421d-4cd5-852e-dbec1bfe1b68"), "Gdynia", "Ecuador", "Nobis eos enim eaque provident laborum libero ut ea quibusdam pariatur animi dolorum et mollitia reprehenderit magnam suscipit maiores recusandae excepturi qui cumque mollitia quasi est ab quaerat eum voluptas.", "Kristine34@yahoo.com", "Neque porro delectus aut error.", "Kristine", "1795", "960-388-8081", "https://picsum.photos/640/480/?image=348", 3.0982348816926755, "America Haven", "Hilpert", "Eum aut.", "05674-4812" }
                });

            migrationBuilder.InsertData(
                table: "Petsitters",
                columns: new[] { "Id", "AvailabilityFrom", "AvailabilityTo", "AzureId", "City", "Country", "Description", "Email", "Environment", "Name", "ParcelAndHouseNumbers", "PhoneNumber", "PhotoId", "Rate", "Street", "Surname", "Title", "ZipCode" },
                values: new object[,]
                {
                    { 191, new DateTime(2021, 1, 23, 7, 45, 49, 223, DateTimeKind.Local).AddTicks(6266), new DateTime(2021, 6, 28, 6, 33, 40, 254, DateTimeKind.Local).AddTicks(1480), new Guid("936adf51-c121-49e5-a9a0-40d998a71b70"), "Gdynia", "Burkina Faso", "Commodi et et aliquam vero quae consequatur qui qui hic ea vel praesentium temporibus harum eos nostrum aspernatur sunt illo quia eum ipsa est sunt corrupti rerum omnis in aut.", "Spencer.Pollich89@hotmail.com", "Dolores nihil est provident sunt.", "Spencer", "8045", "776.945.5090", "https://picsum.photos/640/480/?image=873", 1.2675467432791119, "Name Burg", "Pollich", "Et optio.", "39984" },
                    { 190, new DateTime(2021, 1, 22, 22, 26, 56, 798, DateTimeKind.Local).AddTicks(8371), new DateTime(2021, 10, 10, 22, 37, 18, 841, DateTimeKind.Local).AddTicks(900), new Guid("d1fe2d39-f97c-446b-8a4c-9b8d5b2e320a"), "Warsaw", "Netherlands", "Modi vel rerum beatae velit velit est ea minima illum odio earum iusto assumenda aut est quibusdam porro error nobis dolor nostrum nisi id enim est dolorem labore saepe sunt.", "Orlando_Abernathy12@hotmail.com", "Reprehenderit at nisi non rem.", "Orlando", "2177", "862.515.6639 x601", "https://picsum.photos/640/480/?image=681", 4.9582967795237423, "Imani Drive", "Abernathy", "Sapiente ut.", "37753" },
                    { 189, new DateTime(2021, 1, 22, 19, 27, 54, 7, DateTimeKind.Local).AddTicks(2041), new DateTime(2021, 3, 26, 8, 5, 2, 82, DateTimeKind.Local).AddTicks(9714), new Guid("3f6b90b2-5c93-4a2c-9a00-eabc7ff50d35"), "Warsaw", "Italy", "Qui soluta sequi qui veritatis quidem voluptatem iure fugiat molestiae nostrum dolore voluptatem magni natus qui qui magni aut vel sunt porro illo ut veritatis sapiente ut perferendis est eum.", "Charlie_Hermann@yahoo.com", "Et sint iure aspernatur consequatur.", "Charlie", "9268", "942.222.6872 x92029", "https://picsum.photos/640/480/?image=1048", 1.0330276936446445, "Bernhard Freeway", "Hermann", "Tenetur aut.", "09558-8741" },
                    { 188, new DateTime(2021, 1, 23, 10, 58, 58, 761, DateTimeKind.Local).AddTicks(9506), new DateTime(2021, 12, 25, 3, 55, 16, 40, DateTimeKind.Local).AddTicks(471), new Guid("ce22fa6f-0167-499b-a7b8-c93b7fbe172a"), "Gdynia", "Dominican Republic", "Impedit tempora consequatur voluptatem ad iste quia et ut quibusdam enim enim officia fugiat impedit vel sunt eveniet illum maxime nostrum vel et tempora autem aut sed aut aspernatur nesciunt.", "Preston_King61@yahoo.com", "Modi voluptatem sit commodi qui.", "Preston", "46835", "(441) 661-3881 x8106", "https://picsum.photos/640/480/?image=782", 4.4691254941137162, "Webster Dam", "King", "Placeat dolores.", "12305" },
                    { 187, new DateTime(2021, 1, 23, 4, 28, 26, 228, DateTimeKind.Local).AddTicks(3620), new DateTime(2021, 2, 14, 13, 0, 30, 863, DateTimeKind.Local).AddTicks(1746), new Guid("f2ced20d-d399-49a4-bf1c-a07429ffd748"), "Gdynia", "Japan", "Laudantium aut sunt eos at sit voluptatem modi fuga eligendi et et iusto nesciunt enim eligendi fugiat omnis sunt cumque numquam et velit voluptate sint dolore enim nisi maxime et.", "Alex27@gmail.com", "Dolorem ut id voluptates consequatur.", "Alex", "30750", "919-704-9579 x056", "https://picsum.photos/640/480/?image=267", 3.4315736677644653, "Daniella Locks", "Kub", "Qui nobis.", "48801-5140" },
                    { 186, new DateTime(2021, 1, 22, 17, 14, 19, 413, DateTimeKind.Local).AddTicks(5403), new DateTime(2021, 5, 29, 17, 5, 13, 130, DateTimeKind.Local).AddTicks(8876), new Guid("a5222b14-abf6-44a9-a765-cebe98be8139"), "Gdynia", "Romania", "Non aut odio sit illum doloremque magnam voluptatem vel ullam distinctio non libero laborum aut consequatur qui consequatur voluptas quis molestiae aperiam possimus fuga et ex doloribus itaque libero natus.", "Marco.Schmitt21@yahoo.com", "Saepe consequuntur illum laudantium laudantium.", "Marco", "751", "(255) 322-8377", "https://picsum.photos/640/480/?image=346", 2.9409571410813169, "Kub Divide", "Schmitt", "Eum nostrum.", "32875-4441" },
                    { 184, new DateTime(2021, 1, 22, 15, 4, 41, 946, DateTimeKind.Local).AddTicks(7228), new DateTime(2021, 8, 8, 11, 18, 24, 635, DateTimeKind.Local).AddTicks(65), new Guid("b9ab1e72-c9b9-417a-b3de-6fc343e1fd68"), "Warsaw", "Ethiopia", "Nihil veritatis beatae atque voluptatem voluptatum numquam maxime et libero occaecati magnam nesciunt in cumque placeat at in voluptatibus consequatur aut magnam magni dolores et porro non eius voluptatibus voluptatibus.", "Shawn_Funk@gmail.com", "Laborum dolores blanditiis recusandae qui.", "Shawn", "79505", "732-432-5355 x686", "https://picsum.photos/640/480/?image=332", 1.5699284917534926, "Rutherford Pike", "Funk", "Dolores consectetur.", "01342" },
                    { 166, new DateTime(2021, 1, 23, 9, 41, 19, 791, DateTimeKind.Local).AddTicks(2559), new DateTime(2021, 12, 31, 12, 31, 17, 706, DateTimeKind.Local).AddTicks(7794), new Guid("c2354448-71cd-4cbe-9127-e5c56fa7f91a"), "Warsaw", "South Georgia and the South Sandwich Islands", "Quam distinctio ut enim sed voluptatum at dolores et ad consequatur in iusto deserunt ullam qui molestiae voluptatem et rerum molestias odit inventore qui aliquam dolore possimus ipsam est rem.", "Bennie44@gmail.com", "Voluptatem perferendis accusamus porro sed.", "Bennie", "40221", "(453) 274-8700 x33067", "https://picsum.photos/640/480/?image=629", 4.1958467304687233, "Kennith Circle", "Bauch", "Enim id.", "37199-2524" },
                    { 180, new DateTime(2021, 1, 23, 0, 42, 12, 907, DateTimeKind.Local).AddTicks(9933), new DateTime(2021, 8, 30, 22, 9, 49, 842, DateTimeKind.Local).AddTicks(6771), new Guid("4f7c5dea-5f47-4cb4-af44-7d0da1a876c0"), "Gdynia", "Austria", "Aperiam vitae unde assumenda hic molestias sed quia repudiandae eos facere illum dolores non voluptatem nihil quia asperiores consequuntur sed nihil sint quia voluptatem voluptatem cum quis voluptatum laborum dolores.", "Brittany90@gmail.com", "Qui illo adipisci sed officiis.", "Brittany", "6793", "1-341-397-9120 x787", "https://picsum.photos/640/480/?image=89", 4.3452206996014437, "Raymundo Loaf", "Mayert", "Voluptas qui.", "68486" },
                    { 164, new DateTime(2021, 1, 23, 4, 10, 8, 728, DateTimeKind.Local).AddTicks(9238), new DateTime(2021, 5, 1, 7, 20, 10, 957, DateTimeKind.Local).AddTicks(6501), new Guid("4fc9d314-2ed8-43c7-a537-c2b1bf6a20fa"), "Warsaw", "Togo", "Consectetur cumque nemo natus quisquam qui magnam neque minus voluptatem deserunt labore debitis perspiciatis ratione ab ex maiores consequuntur consectetur earum eaque impedit voluptatem rerum dolorem repellat debitis velit qui.", "Suzanne.Schoen@yahoo.com", "Doloribus quae et iste qui.", "Suzanne", "3810", "636.418.5868 x177", "https://picsum.photos/640/480/?image=966", 4.9041485338956807, "Helene Divide", "Schoen", "Velit voluptatem.", "51858-7312" },
                    { 101, new DateTime(2021, 1, 23, 4, 17, 56, 632, DateTimeKind.Local).AddTicks(4080), new DateTime(2021, 10, 25, 3, 46, 27, 540, DateTimeKind.Local).AddTicks(9973), new Guid("e945e9b7-6b1b-494d-8dd9-f0539f1865c7"), "Gdynia", "Tunisia", "Voluptatum omnis sint voluptatem eum aliquam eum nisi odit consectetur veniam ab possimus et eos molestias ut sit dolor consequatur alias repudiandae quos cupiditate praesentium veniam aut dignissimos adipisci soluta.", "Salvatore_Shields75@hotmail.com", "Asperiores eos aut qui itaque.", "Salvatore", "52823", "791.886.8985", "https://picsum.photos/640/480/?image=33", 4.6183163018982469, "Hessel Ridge", "Shields", "Natus enim.", "53736-2079" },
                    { 102, new DateTime(2021, 1, 23, 11, 54, 54, 483, DateTimeKind.Local).AddTicks(561), new DateTime(2021, 10, 25, 15, 46, 47, 947, DateTimeKind.Local).AddTicks(8497), new Guid("f2ef398d-d3e0-46df-b11a-6e446d210d6a"), "Radom", "Bahamas", "Occaecati quis enim debitis vel molestiae qui sit reiciendis expedita nulla ex mollitia quia delectus tenetur vel suscipit sunt suscipit ut et eaque nihil consectetur accusantium blanditiis nihil non repellendus.", "Ben.Cronin65@yahoo.com", "Nulla nobis aliquid totam accusantium.", "Ben", "92889", "217.506.5447 x10461", "https://picsum.photos/640/480/?image=424", 1.5541576354550932, "Nicole Terrace", "Cronin", "Mollitia suscipit.", "50867-5808" },
                    { 103, new DateTime(2021, 1, 22, 22, 36, 28, 749, DateTimeKind.Local).AddTicks(45), new DateTime(2021, 3, 31, 18, 20, 28, 835, DateTimeKind.Local).AddTicks(4897), new Guid("01fe6b34-17ee-4410-bc73-2ed7b3850c68"), "Radom", "United States Minor Outlying Islands", "Aut sint repellat ut qui vel aut non velit dolor ut omnis voluptatum non et facere fuga est unde doloremque deserunt et molestiae ea dolor provident iste sed voluptas ut.", "Earl76@hotmail.com", "Exercitationem reiciendis quia ipsum quos.", "Earl", "5026", "952.686.1930", "https://picsum.photos/640/480/?image=149", 3.8611398706497346, "Ford Avenue", "Gleason", "Consequatur ut.", "18370" },
                    { 104, new DateTime(2021, 1, 23, 10, 40, 16, 18, DateTimeKind.Local).AddTicks(5775), new DateTime(2021, 10, 20, 6, 23, 25, 654, DateTimeKind.Local).AddTicks(1596), new Guid("949c1a34-6152-4b78-9621-55ca8a3bd7c3"), "Warsaw", "Egypt", "Non quis autem sed inventore doloribus occaecati quos cumque aut ad amet et facere sit numquam et dicta quod qui ipsum voluptatum et molestiae quae nam dolores aut delectus quae.", "Sonia_Streich@yahoo.com", "Hic nesciunt qui at unde.", "Sonia", "98358", "698.549.0675", "https://picsum.photos/640/480/?image=695", 3.6566279598775449, "Tromp Turnpike", "Streich", "Blanditiis possimus.", "02179-5010" },
                    { 105, new DateTime(2021, 1, 23, 2, 28, 52, 935, DateTimeKind.Local).AddTicks(9510), new DateTime(2021, 6, 3, 4, 32, 18, 737, DateTimeKind.Local).AddTicks(6689), new Guid("ab332ef6-a729-4ddc-8194-912204510e19"), "Gdynia", "Solomon Islands", "Aliquid aut qui maiores facere vero non consequatur tenetur dolor quo aliquam ex sint qui asperiores veniam repellendus ut voluptate libero odio eligendi reiciendis aut ut doloremque ut architecto officia.", "Angie.Harris@hotmail.com", "Voluptates velit voluptatum reiciendis corrupti.", "Angie", "971", "(523) 476-8893 x691", "https://picsum.photos/640/480/?image=1079", 4.9892059173384711, "Hermann Tunnel", "Harris", "Quia provident.", "36781-9999" },
                    { 129, new DateTime(2021, 1, 22, 23, 35, 16, 537, DateTimeKind.Local).AddTicks(1293), new DateTime(2021, 5, 11, 3, 29, 15, 632, DateTimeKind.Local).AddTicks(1418), new Guid("02070da2-2d76-4df6-a386-f1d8f30bdb55"), "Gdynia", "Montserrat", "Quasi nihil deserunt dolorem et quaerat voluptatum aut cum ipsa magnam quod voluptatibus omnis quia est non rerum at qui sunt molestiae officiis et asperiores et quod nostrum facilis odio.", "Rolando75@hotmail.com", "Enim aperiam odio distinctio ratione.", "Rolando", "651", "1-295-358-4734", "https://picsum.photos/640/480/?image=237", 1.7586016304598198, "Zoey Run", "Christiansen", "Harum amet.", "67590" },
                    { 106, new DateTime(2021, 1, 22, 22, 20, 0, 827, DateTimeKind.Local).AddTicks(1539), new DateTime(2021, 6, 14, 18, 24, 37, 218, DateTimeKind.Local).AddTicks(4618), new Guid("8ffbac9b-dbe6-400e-8fe9-0e4fcd015846"), "Warsaw", "Romania", "Dignissimos enim ullam quo omnis et voluptate quia et quos sequi eum eligendi officia enim possimus debitis eos repellendus totam numquam ullam aperiam laborum aut est voluptas facere eos nemo.", "Alberta.Watsica60@yahoo.com", "Est fugiat voluptatem deserunt expedita.", "Alberta", "98857", "(606) 288-0303 x2554", "https://picsum.photos/640/480/?image=182", 1.1317130346464519, "Dicki Points", "Watsica", "Qui ad.", "41638-1822" },
                    { 107, new DateTime(2021, 1, 23, 12, 36, 39, 701, DateTimeKind.Local).AddTicks(2825), new DateTime(2021, 5, 10, 7, 12, 8, 4, DateTimeKind.Local).AddTicks(5564), new Guid("6afb0a84-d498-4e4a-b770-d0f9aabc7177"), "Warsaw", "Bahamas", "Repudiandae aliquam quos deleniti eos fugit aut qui consequatur quia veritatis eius dolores ut porro suscipit doloremque voluptatem quas nemo aut consequuntur neque est facere natus pariatur quis quis blanditiis.", "Joey98@yahoo.com", "Quod perferendis temporibus explicabo rerum.", "Joey", "84666", "(894) 886-8514 x5084", "https://picsum.photos/640/480/?image=249", 1.8496286910258366, "Imogene Springs", "Hane", "Voluptatem saepe.", "18626" },
                    { 108, new DateTime(2021, 1, 23, 1, 37, 28, 637, DateTimeKind.Local).AddTicks(4568), new DateTime(2021, 7, 3, 4, 45, 7, 851, DateTimeKind.Local).AddTicks(8713), new Guid("627b56d5-0144-49a2-ad66-f0a40c2f828a"), "Gdynia", "Honduras", "Rerum molestias facilis aut amet ea illo ut eius atque dolores voluptas rem minima nihil quam incidunt dolor amet inventore atque laboriosam rerum sint vel animi qui quidem quod accusantium.", "Violet_Gleason@yahoo.com", "Dolorum magni adipisci officia culpa.", "Violet", "4163", "768-892-9587 x0319", "https://picsum.photos/640/480/?image=572", 3.3751218013349558, "Otis Ways", "Gleason", "Nihil corporis.", "94901-7780" },
                    { 109, new DateTime(2021, 1, 22, 15, 35, 57, 518, DateTimeKind.Local).AddTicks(1660), new DateTime(2021, 11, 29, 13, 2, 24, 728, DateTimeKind.Local).AddTicks(3034), new Guid("49524a32-3801-4f9f-9ade-829f812f8bf3"), "Warsaw", "Brazil", "Ut placeat sed sed pariatur eaque voluptas pariatur perspiciatis fugiat sunt ullam eveniet quibusdam nisi deleniti tempora dolorem expedita praesentium quia ad vel omnis possimus sit ex fugit nihil necessitatibus.", "Ian.Dickens52@gmail.com", "Illo deserunt sed optio itaque.", "Ian", "7985", "684.868.0766", "https://picsum.photos/640/480/?image=1014", 2.1987851360807129, "Joel Ridges", "Dickens", "Vel pariatur.", "80722" },
                    { 110, new DateTime(2021, 1, 23, 5, 48, 57, 137, DateTimeKind.Local).AddTicks(7941), new DateTime(2021, 8, 13, 2, 55, 10, 948, DateTimeKind.Local).AddTicks(3577), new Guid("5bdbf949-cdd4-4287-bdd2-e5146e6fd3a7"), "Radom", "Micronesia", "Sunt exercitationem sint sequi et eos voluptatem facere non fugit neque voluptatem dolorem at non porro et cupiditate quia commodi error qui quidem rerum officiis odit exercitationem perferendis quam velit.", "Angelica.Skiles8@hotmail.com", "Molestias expedita et veniam dolores.", "Angelica", "693", "1-424-220-2580", "https://picsum.photos/640/480/?image=96", 3.8679382590893367, "Nitzsche Courts", "Skiles", "Rerum cupiditate.", "09481-0777" },
                    { 111, new DateTime(2021, 1, 22, 19, 54, 39, 914, DateTimeKind.Local).AddTicks(8915), new DateTime(2021, 1, 26, 3, 4, 38, 371, DateTimeKind.Local).AddTicks(4730), new Guid("0437949f-11e5-4615-a19d-b30dc8128337"), "Gdynia", "Virgin Islands, U.S.", "Voluptatem ducimus laudantium molestiae voluptas quae sed amet dicta dolores tenetur quis enim est in sit quia consectetur dolore aspernatur modi iure cumque qui dolorem sint natus molestiae laboriosam nulla.", "Ethel86@yahoo.com", "Voluptatem aut facilis harum maxime.", "Ethel", "1007", "(408) 678-3528 x486", "https://picsum.photos/640/480/?image=970", 2.9942395584630965, "Everette Center", "Hartmann", "Tempora rerum.", "27801" },
                    { 112, new DateTime(2021, 1, 22, 18, 19, 10, 406, DateTimeKind.Local).AddTicks(7686), new DateTime(2021, 11, 5, 16, 49, 7, 696, DateTimeKind.Local).AddTicks(1401), new Guid("8938613e-312c-4268-9152-fa09fd10bc0f"), "Gdynia", "Comoros", "Et tempora labore eaque mollitia saepe dolorem dolorem alias est velit nam repellendus earum corrupti tempora totam totam unde odit illo dicta ab totam eaque cum iste alias debitis commodi.", "Sheri.Schulist@yahoo.com", "Ab architecto perspiciatis voluptatem error.", "Sheri", "572", "1-314-379-6870 x50236", "https://picsum.photos/640/480/?image=939", 1.3465014455590869, "Osinski Locks", "Schulist", "Adipisci repudiandae.", "05207" },
                    { 113, new DateTime(2021, 1, 22, 13, 38, 0, 315, DateTimeKind.Local).AddTicks(2765), new DateTime(2021, 7, 22, 14, 15, 22, 37, DateTimeKind.Local).AddTicks(7402), new Guid("336dde42-5ddf-4d46-905d-49941886c399"), "Radom", "Kyrgyz Republic", "Vel sit at cupiditate necessitatibus ullam adipisci quo exercitationem maxime et excepturi aut consequuntur minima delectus architecto natus soluta voluptatem deleniti possimus error perferendis corporis mollitia harum dignissimos quis nulla.", "Edmund.Abbott@hotmail.com", "Dignissimos perspiciatis inventore qui quo.", "Edmund", "91545", "(713) 705-8078 x5726", "https://picsum.photos/640/480/?image=9", 4.6297186555479275, "Botsford Shoal", "Abbott", "Cupiditate accusantium.", "74704" },
                    { 115, new DateTime(2021, 1, 22, 20, 24, 8, 540, DateTimeKind.Local).AddTicks(1039), new DateTime(2022, 1, 12, 5, 31, 14, 637, DateTimeKind.Local).AddTicks(7899), new Guid("322db756-7b6b-43e3-bc7a-9efa8a9fa8b0"), "Radom", "Latvia", "Dolore ut voluptates aut similique iste et autem veritatis est occaecati delectus sit reprehenderit est molestiae ratione tempore officia qui ut consequatur et aut id soluta et iure quo eveniet.", "Carlton.Kautzer2@hotmail.com", "Quis in accusamus consequuntur odio.", "Carlton", "232", "615-271-6816", "https://picsum.photos/640/480/?image=551", 1.4086740633513193, "Andreanne Burg", "Kautzer", "Perferendis eveniet.", "66115" },
                    { 116, new DateTime(2021, 1, 23, 6, 0, 59, 829, DateTimeKind.Local).AddTicks(459), new DateTime(2021, 8, 9, 3, 21, 6, 414, DateTimeKind.Local).AddTicks(8938), new Guid("65d7e328-2be4-482f-9a14-c40ec0ee7d37"), "Radom", "French Southern Territories", "Velit dolor non aspernatur odio ab unde minus est ducimus odit odio consequatur eos qui rerum autem nisi culpa illo quo qui quia rem eaque et sit similique temporibus aut.", "Guadalupe77@hotmail.com", "Ut itaque autem consequatur blanditiis.", "Guadalupe", "17893", "(741) 882-6751 x5148", "https://picsum.photos/640/480/?image=164", 3.7149344434565559, "Kaleb Cliffs", "Lakin", "Sunt voluptatem.", "98288" },
                    { 117, new DateTime(2021, 1, 23, 8, 4, 49, 713, DateTimeKind.Local).AddTicks(2544), new DateTime(2021, 3, 14, 5, 29, 9, 781, DateTimeKind.Local).AddTicks(105), new Guid("0fef7d37-5fad-433a-babc-8adcf16ba185"), "Gdynia", "Serbia", "Autem placeat omnis omnis pariatur harum optio omnis rem itaque expedita cupiditate tempora eveniet deleniti non molestias laudantium aut quia officia quaerat rerum minima eum quia ea debitis ut laboriosam.", "Clyde.Raynor29@hotmail.com", "Eos facere quo fugit odit.", "Clyde", "9942", "1-688-731-1208 x555", "https://picsum.photos/640/480/?image=652", 2.1303995573569088, "Hoppe Track", "Raynor", "Similique molestias.", "96431" },
                    { 118, new DateTime(2021, 1, 23, 2, 52, 36, 491, DateTimeKind.Local).AddTicks(8009), new DateTime(2021, 6, 5, 19, 40, 58, 376, DateTimeKind.Local).AddTicks(6198), new Guid("4a8f6711-e2c1-4efa-a51e-13d8ade98f03"), "Gdynia", "Comoros", "Commodi et pariatur voluptatem quia ad pariatur officia et nesciunt error minima fuga neque doloribus amet maiores qui dolorem id eveniet consequatur harum dolore consequatur harum veniam corporis exercitationem rerum.", "Saul10@gmail.com", "Omnis laborum animi hic ut.", "Saul", "837", "1-405-686-6186", "https://picsum.photos/640/480/?image=976", 2.3136857325740561, "Trinity Coves", "Ledner", "Cupiditate non.", "22330-5439" },
                    { 119, new DateTime(2021, 1, 23, 7, 37, 59, 580, DateTimeKind.Local).AddTicks(2197), new DateTime(2021, 11, 21, 22, 24, 13, 24, DateTimeKind.Local).AddTicks(2388), new Guid("09aa6b39-f802-4f67-b12a-21a31fdb5422"), "Warsaw", "Pakistan", "Quis delectus asperiores corrupti nihil dignissimos ut quidem saepe repudiandae consequatur dolores excepturi voluptatem aut numquam et a voluptatum quibusdam animi minima sint a est autem fugit quibusdam voluptate sit.", "Priscilla.Greenholt@hotmail.com", "Ab aperiam porro voluptates sit.", "Priscilla", "1837", "443-627-2931 x34497", "https://picsum.photos/640/480/?image=703", 4.6338031793170629, "Stehr Well", "Greenholt", "Animi aut.", "08408-9710" },
                    { 120, new DateTime(2021, 1, 22, 17, 52, 46, 846, DateTimeKind.Local).AddTicks(3693), new DateTime(2021, 2, 11, 21, 39, 50, 866, DateTimeKind.Local).AddTicks(9069), new Guid("f1610d3f-ccee-43c4-9cb3-1dca58f20b1f"), "Warsaw", "Uruguay", "Aut ut tenetur ut ut sit cumque voluptate voluptas quaerat ullam provident fuga rerum nisi maxime rem facere sequi consectetur vel quibusdam eaque aliquid sit laudantium soluta delectus totam quidem.", "Norman.Terry@gmail.com", "Eius nam enim eos animi.", "Norman", "60263", "1-844-699-8363 x3721", "https://picsum.photos/640/480/?image=633", 3.1105729127817661, "Pfannerstill Plain", "Terry", "Laboriosam officiis.", "28453" },
                    { 121, new DateTime(2021, 1, 23, 2, 41, 55, 115, DateTimeKind.Local).AddTicks(5013), new DateTime(2021, 6, 14, 22, 58, 16, 228, DateTimeKind.Local).AddTicks(9970), new Guid("5b4cd0e9-80ab-4260-8e86-3430366d7945"), "Warsaw", "Papua New Guinea", "Illo nemo sunt dolores sed non accusantium voluptatem explicabo aut cumque ab eos alias ut quam vel minima ut iste qui voluptas aut id vitae sit repellat molestiae quod accusamus.", "Kendra_OConner97@hotmail.com", "Ex velit officiis recusandae mollitia.", "Kendra", "78157", "1-515-818-7174 x652", "https://picsum.photos/640/480/?image=1011", 2.5149249478778453, "Hane Plaza", "O'Conner", "Est exercitationem.", "62981-2105" },
                    { 122, new DateTime(2021, 1, 22, 23, 51, 6, 565, DateTimeKind.Local).AddTicks(7290), new DateTime(2021, 11, 2, 9, 14, 48, 44, DateTimeKind.Local).AddTicks(2567), new Guid("6d688377-7d56-49ae-a625-cb283ff970f4"), "Gdynia", "Monaco", "Assumenda quis quo in ipsam corrupti tenetur soluta fugiat vero aut ea minima quidem est quo atque rerum corrupti assumenda voluptatem dolorum nihil vel vel quos culpa optio deleniti praesentium.", "Allen3@yahoo.com", "Ut omnis qui voluptates quaerat.", "Allen", "88706", "977-721-7273 x21299", "https://picsum.photos/640/480/?image=449", 1.6483598037848062, "Adalberto Street", "Wiegand", "Voluptatem rerum.", "83516-0333" },
                    { 123, new DateTime(2021, 1, 22, 16, 19, 12, 332, DateTimeKind.Local).AddTicks(5108), new DateTime(2021, 11, 25, 21, 34, 53, 209, DateTimeKind.Local).AddTicks(5067), new Guid("341a3d2c-c08a-4863-847b-bdf21bfc7db6"), "Radom", "Guam", "Porro velit quaerat adipisci repellendus ut cupiditate et libero expedita ad et sapiente et adipisci quis eius quis sit non est totam enim amet veniam numquam officiis corporis eos doloremque.", "Roberto33@yahoo.com", "Voluptatum autem est dolore eos.", "Roberto", "1681", "268.453.1086 x4260", "https://picsum.photos/640/480/?image=651", 4.2945593219690767, "Garnet River", "Kihn", "Velit sint.", "12301" },
                    { 124, new DateTime(2021, 1, 23, 1, 16, 35, 140, DateTimeKind.Local).AddTicks(6575), new DateTime(2021, 12, 4, 7, 51, 57, 611, DateTimeKind.Local).AddTicks(3549), new Guid("93fb2830-1a61-4d83-bf6a-49f038b98a26"), "Warsaw", "Saint Vincent and the Grenadines", "Vel voluptas nam exercitationem excepturi deserunt provident odit voluptatem aut officia quia est voluptas consequuntur dolorem nulla est molestiae eius ratione recusandae non amet odio dolore mollitia consequatur aut modi.", "Noah8@hotmail.com", "Quibusdam voluptatum vero voluptatem repellat.", "Noah", "9554", "358.655.2811 x804", "https://picsum.photos/640/480/?image=1022", 1.3919562904126739, "Leland Camp", "Marquardt", "Earum debitis.", "85635-1280" },
                    { 125, new DateTime(2021, 1, 22, 15, 40, 0, 906, DateTimeKind.Local).AddTicks(6951), new DateTime(2021, 10, 28, 21, 51, 42, 451, DateTimeKind.Local).AddTicks(817), new Guid("f39836fc-e024-4a64-941a-638e35d4e71f"), "Gdynia", "South Georgia and the South Sandwich Islands", "Quod officiis voluptatum odio et et et quia veritatis tenetur earum mollitia sapiente illo libero tenetur quo porro illo dolor sint dolore non magni quam sapiente pariatur voluptatibus cum voluptatem.", "Curtis_Bashirian@hotmail.com", "Rerum nisi voluptatem veniam perferendis.", "Curtis", "4273", "539.488.0358 x48036", "https://picsum.photos/640/480/?image=1026", 4.349347827653097, "Kirlin Track", "Bashirian", "Consequatur dolores.", "42633-6287" },
                    { 126, new DateTime(2021, 1, 23, 9, 22, 34, 892, DateTimeKind.Local).AddTicks(3098), new DateTime(2021, 1, 26, 19, 29, 42, 531, DateTimeKind.Local).AddTicks(731), new Guid("403d56fd-95ce-42cc-b654-66c64f7b8d03"), "Warsaw", "Grenada", "Rem deserunt soluta ut eum aut rem quaerat temporibus explicabo tempora recusandae laboriosam aut voluptas doloremque totam voluptatem totam rerum voluptatem iusto omnis quisquam perspiciatis modi aut minima laudantium tempore.", "Dora_Vandervort@yahoo.com", "Eaque vel a et neque.", "Dora", "925", "1-992-570-2509 x3101", "https://picsum.photos/640/480/?image=894", 1.1022107638894632, "Windler Club", "Vandervort", "Corrupti natus.", "94746-9119" },
                    { 127, new DateTime(2021, 1, 23, 7, 57, 52, 936, DateTimeKind.Local).AddTicks(5519), new DateTime(2022, 1, 9, 16, 41, 2, 875, DateTimeKind.Local).AddTicks(5816), new Guid("03b9d201-3745-4dd7-9f85-4dd7efeee6e7"), "Warsaw", "Falkland Islands (Malvinas)", "Repellendus ullam expedita dolores dolor illo inventore adipisci illum laboriosam non labore pariatur pariatur dolore hic qui eligendi eligendi officia explicabo magnam sit dolorem necessitatibus alias neque rerum nihil sapiente.", "Lillian_Schimmel5@hotmail.com", "Eum et dolor saepe quam.", "Lillian", "74534", "(686) 920-6093 x1663", "https://picsum.photos/640/480/?image=844", 1.2286035307816245, "Dagmar Bridge", "Schimmel", "Sed delectus.", "37568-6341" },
                    { 128, new DateTime(2021, 1, 22, 13, 50, 57, 848, DateTimeKind.Local).AddTicks(1081), new DateTime(2021, 9, 26, 18, 17, 20, 598, DateTimeKind.Local).AddTicks(6009), new Guid("fd15b0c9-aef3-4544-8e20-d0ba83a7e207"), "Gdynia", "Aruba", "Non adipisci sunt illum voluptatibus veritatis et ex molestiae id ut repellat facere quasi fuga quae iure sint consequatur tempore qui aut ea consectetur ea inventore recusandae sed cupiditate aut.", "Ginger.MacGyver@hotmail.com", "Nihil sed quia autem eveniet.", "Ginger", "72601", "922.615.3984", "https://picsum.photos/640/480/?image=394", 1.8149785198341024, "Kemmer Greens", "MacGyver", "Iure et.", "99496" },
                    { 165, new DateTime(2021, 1, 23, 0, 50, 3, 162, DateTimeKind.Local).AddTicks(7083), new DateTime(2021, 9, 2, 7, 54, 17, 321, DateTimeKind.Local).AddTicks(3785), new Guid("b87d2f42-459d-4286-8032-08891711bdce"), "Warsaw", "Egypt", "Praesentium reprehenderit enim et voluptatum reprehenderit quisquam ea non nisi qui et est blanditiis voluptas aut omnis eum sit hic voluptas aliquam maiores nihil molestiae eos id qui sed totam.", "Winston.McKenzie@gmail.com", "Id vel laborum temporibus eos.", "Winston", "08723", "1-698-471-3679", "https://picsum.photos/640/480/?image=327", 1.4073235468973051, "Morar Summit", "McKenzie", "Quia ea.", "89101-1744" },
                    { 130, new DateTime(2021, 1, 23, 8, 33, 39, 485, DateTimeKind.Local).AddTicks(1501), new DateTime(2021, 3, 16, 11, 51, 53, 325, DateTimeKind.Local).AddTicks(4115), new Guid("a4910c8c-eef1-4868-85eb-cc936ece1c70"), "Warsaw", "Brunei Darussalam", "Maiores repudiandae illum quis facilis eius aut et ipsam sed quisquam est aut ratione quod molestiae sunt aliquam praesentium sit corporis quod esse consectetur impedit repellat et expedita voluptatem culpa.", "Jodi44@gmail.com", "Fuga in est aliquid ex.", "Jodi", "60559", "1-985-713-4893", "https://picsum.photos/640/480/?image=975", 4.4557089225648472, "Samanta Glen", "Daniel", "Dolore et.", "19763-5936" },
                    { 131, new DateTime(2021, 1, 22, 14, 39, 5, 753, DateTimeKind.Local).AddTicks(9125), new DateTime(2021, 4, 3, 2, 14, 48, 940, DateTimeKind.Local).AddTicks(2295), new Guid("e7a809d7-7e85-4aa4-a5ca-094c5b1ec9fa"), "Gdynia", "Mauritius", "Omnis iusto nisi vitae magni at placeat atque error voluptas commodi minima laboriosam optio perferendis vitae laboriosam cumque qui molestiae itaque aspernatur alias blanditiis et praesentium itaque odit omnis eveniet.", "Whitney_Nicolas77@hotmail.com", "Illo rerum cumque voluptas cum.", "Whitney", "269", "1-640-562-7987 x617", "https://picsum.photos/640/480/?image=717", 3.1015960621189307, "O'Kon Crossroad", "Nicolas", "Laboriosam atque.", "74523" },
                    { 114, new DateTime(2021, 1, 23, 10, 45, 4, 9, DateTimeKind.Local).AddTicks(6129), new DateTime(2021, 1, 29, 22, 51, 26, 695, DateTimeKind.Local).AddTicks(3075), new Guid("4a76bc6e-f74d-452b-84c3-ae54394a0e34"), "Gdynia", "Chad", "Repudiandae nam rem non veritatis laborum illo placeat quam placeat rerum laudantium voluptate doloremque laborum in dolorum consequatur sunt dolore in dolor eius quam voluptatem quidem accusantium voluptate consequatur sit.", "Marcus_Orn@hotmail.com", "Dolorum ut incidunt id ducimus.", "Marcus", "8685", "(960) 391-2211 x54342", "https://picsum.photos/640/480/?image=722", 2.7231184904105579, "Alexzander Place", "Orn", "Consectetur non.", "45336" }
                });

            migrationBuilder.InsertData(
                table: "Petsitters",
                columns: new[] { "Id", "AvailabilityFrom", "AvailabilityTo", "AzureId", "City", "Country", "Description", "Email", "Environment", "Name", "ParcelAndHouseNumbers", "PhoneNumber", "PhotoId", "Rate", "Street", "Surname", "Title", "ZipCode" },
                values: new object[,]
                {
                    { 133, new DateTime(2021, 1, 22, 20, 25, 45, 28, DateTimeKind.Local).AddTicks(7249), new DateTime(2021, 5, 28, 7, 10, 16, 444, DateTimeKind.Local).AddTicks(9396), new Guid("98b3cefe-818d-4370-ac17-a6b6c08db69d"), "Gdynia", "Aruba", "Suscipit ad et omnis blanditiis ut est sapiente id accusamus harum totam rerum aut in eveniet ea sint et delectus dicta quis iste architecto aspernatur omnis impedit et cum vel.", "Jeannie.Lang44@yahoo.com", "Delectus porro est soluta cum.", "Jeannie", "491", "1-383-270-9830 x55243", "https://picsum.photos/640/480/?image=1080", 2.6686048571339831, "Pacocha Oval", "Lang", "Ex ea.", "78434-5237" },
                    { 163, new DateTime(2021, 1, 23, 4, 6, 51, 494, DateTimeKind.Local).AddTicks(4526), new DateTime(2022, 1, 16, 19, 44, 31, 946, DateTimeKind.Local).AddTicks(5532), new Guid("f00c8283-d284-40ce-b37a-b4791b9902a0"), "Warsaw", "Kazakhstan", "Architecto id numquam quo dolores aliquam dicta facere repellendus sequi et aut est dicta nostrum id consectetur doloribus dolores minus molestias nam sit maiores ut molestias unde ducimus eos voluptatum.", "Irving.Pouros48@yahoo.com", "Tempora ducimus maiores impedit rerum.", "Irving", "21820", "715-774-2912 x9422", "https://picsum.photos/640/480/?image=377", 2.1369034597356356, "Monty Fort", "Pouros", "Voluptate quisquam.", "17553-6908" },
                    { 132, new DateTime(2021, 1, 22, 19, 58, 48, 398, DateTimeKind.Local).AddTicks(7170), new DateTime(2021, 8, 10, 18, 25, 32, 117, DateTimeKind.Local).AddTicks(2624), new Guid("e616d5b3-181e-422c-9026-4f57d0177f25"), "Gdynia", "Equatorial Guinea", "Consequatur similique omnis asperiores accusantium nam voluptas aspernatur ad omnis sunt et illo eos facilis ut perspiciatis quod quam iure provident rerum id quas natus ea voluptatum in error ipsam.", "Frankie7@hotmail.com", "Ab iusto dolorum amet consectetur.", "Frankie", "74573", "741.845.7109 x0944", "https://picsum.photos/640/480/?image=293", 2.7811729152599223, "Otto Expressway", "Konopelski", "Qui fugiat.", "56626-4679" },
                    { 162, new DateTime(2021, 1, 22, 15, 19, 25, 721, DateTimeKind.Local).AddTicks(5507), new DateTime(2022, 1, 18, 5, 46, 46, 282, DateTimeKind.Local).AddTicks(7974), new Guid("6ce70cb8-8f24-43f1-85eb-484cedc04195"), "Gdynia", "Antigua and Barbuda", "Dicta ipsa nemo fugit vero consequuntur accusantium quis ut quis saepe deserunt dignissimos autem et impedit at nobis non voluptate voluptatem et provident et quae ut quae voluptas iste non.", "Mercedes_Johnson@hotmail.com", "Excepturi molestias et necessitatibus beatae.", "Mercedes", "8072", "502-304-5338", "https://picsum.photos/640/480/?image=382", 1.3842816000731111, "Thaddeus Junction", "Johnson", "Fuga sit.", "61864-2656" },
                    { 160, new DateTime(2021, 1, 22, 23, 11, 1, 858, DateTimeKind.Local).AddTicks(1827), new DateTime(2021, 11, 13, 13, 36, 3, 445, DateTimeKind.Local).AddTicks(8521), new Guid("0652602f-600e-4e6a-96ed-08fa06957153"), "Gdynia", "Morocco", "Enim ipsa necessitatibus nostrum enim laborum animi cumque commodi corporis rerum ducimus optio earum natus rerum error nisi eos voluptas est nihil est et omnis porro quia fuga consequatur numquam.", "Debra_Mohr3@gmail.com", "At ipsam est aliquid maiores.", "Debra", "49857", "768.971.4349 x90251", "https://picsum.photos/640/480/?image=492", 3.566376542004932, "Kertzmann Via", "Mohr", "Sapiente unde.", "27067" },
                    { 159, new DateTime(2021, 1, 23, 4, 8, 50, 252, DateTimeKind.Local).AddTicks(845), new DateTime(2021, 12, 9, 4, 22, 20, 595, DateTimeKind.Local).AddTicks(261), new Guid("0528960c-5495-44bb-abda-250d370aedee"), "Radom", "Sierra Leone", "Ea consequuntur in ea assumenda aut voluptatem tempora qui consequuntur ullam corrupti perferendis quibusdam et et facilis nihil possimus nobis voluptas quo aliquid voluptatem facere harum et laudantium qui explicabo.", "Marilyn0@hotmail.com", "Eos sunt molestiae cum occaecati.", "Marilyn", "998", "1-595-511-4028 x296", "https://picsum.photos/640/480/?image=33", 3.3053431298142963, "Clemens Stravenue", "Schmidt", "Voluptate repudiandae.", "58494" },
                    { 158, new DateTime(2021, 1, 22, 23, 28, 11, 780, DateTimeKind.Local).AddTicks(7419), new DateTime(2021, 11, 11, 18, 31, 46, 735, DateTimeKind.Local).AddTicks(4998), new Guid("95e50945-df78-4499-98a3-177bfd625030"), "Gdynia", "Monaco", "Nihil voluptatem similique saepe mollitia voluptas ex distinctio labore dolore molestiae nam rerum eum voluptatibus esse id sit totam et animi expedita explicabo et id quibusdam quidem sed architecto impedit.", "Johnathan.Greenfelder77@hotmail.com", "Voluptate aut quia voluptas illo.", "Johnathan", "9208", "1-691-694-0929 x282", "https://picsum.photos/640/480/?image=33", 3.6523904868645549, "Keegan Turnpike", "Greenfelder", "Minus expedita.", "41038" },
                    { 157, new DateTime(2021, 1, 23, 12, 34, 20, 369, DateTimeKind.Local).AddTicks(9733), new DateTime(2021, 11, 30, 13, 4, 28, 696, DateTimeKind.Local).AddTicks(6784), new Guid("bcd67f6f-e707-4c68-8f5e-3daf43aca20a"), "Gdynia", "American Samoa", "Dolores quae aut id doloribus sint non quasi quaerat ut voluptatem rerum minima saepe nihil maiores corrupti ut quasi aliquid quis nemo quas pariatur veritatis rerum rerum iusto commodi ut.", "Olive10@gmail.com", "Ut aliquam ut odit sunt.", "Olive", "9122", "347.352.2912 x024", "https://picsum.photos/640/480/?image=183", 4.4871191678043072, "Judy Springs", "Kirlin", "Qui amet.", "77561-4840" },
                    { 156, new DateTime(2021, 1, 22, 23, 48, 31, 163, DateTimeKind.Local).AddTicks(189), new DateTime(2021, 11, 17, 22, 4, 30, 519, DateTimeKind.Local).AddTicks(2172), new Guid("763cf5d6-2c0e-416b-b141-a1a077388862"), "Radom", "Togo", "Est provident repudiandae molestiae magni id neque culpa pariatur accusamus ratione facere aut tenetur fugit ad qui vel eius aperiam voluptatibus reprehenderit tempora ut et modi sequi illo aut minima.", "Jean_Homenick@hotmail.com", "Ex quisquam sit corporis quis.", "Jean", "52605", "816.653.8745", "https://picsum.photos/640/480/?image=985", 1.0486605484265186, "Afton Plains", "Homenick", "Voluptatem excepturi.", "89280" },
                    { 155, new DateTime(2021, 1, 23, 11, 38, 13, 343, DateTimeKind.Local).AddTicks(8159), new DateTime(2021, 2, 2, 20, 59, 38, 810, DateTimeKind.Local).AddTicks(9700), new Guid("a67a7ece-3b99-4636-b93e-ea825c52bf7e"), "Warsaw", "Uzbekistan", "Voluptatem est doloribus sint fugit rerum et et ex quis sit ullam qui cumque possimus praesentium laboriosam et id est expedita possimus praesentium inventore asperiores alias quas quia omnis voluptas.", "Steve93@gmail.com", "Quas minima reprehenderit ratione recusandae.", "Steve", "11015", "1-530-620-0151 x692", "https://picsum.photos/640/480/?image=603", 2.1200842639059223, "Milford Manors", "Reilly", "Laudantium quam.", "21225" },
                    { 154, new DateTime(2021, 1, 22, 14, 44, 48, 632, DateTimeKind.Local).AddTicks(4484), new DateTime(2021, 3, 23, 9, 1, 41, 786, DateTimeKind.Local).AddTicks(8328), new Guid("38bd8528-898b-4701-8356-1b1a88bfdbec"), "Gdynia", "Argentina", "Ut ipsum harum enim a quae vel placeat praesentium nihil illo aspernatur ut quo placeat sit asperiores ipsam omnis sed soluta quia est non quia incidunt ratione at in totam.", "Jodi_Crona5@hotmail.com", "Molestiae placeat autem inventore in.", "Jodi", "6472", "915-207-4840 x9079", "https://picsum.photos/640/480/?image=947", 3.0656289356134967, "Hane Station", "Crona", "Magni ea.", "41735" },
                    { 153, new DateTime(2021, 1, 23, 4, 47, 49, 352, DateTimeKind.Local).AddTicks(5350), new DateTime(2021, 5, 19, 0, 59, 0, 35, DateTimeKind.Local).AddTicks(3264), new Guid("03541a25-04a2-44f2-82f8-567d34c3a19a"), "Gdynia", "Costa Rica", "Facere doloremque omnis aut occaecati occaecati pariatur assumenda consectetur laboriosam ut similique id ut ut adipisci laudantium sunt ex cumque sint qui magnam voluptates quis beatae illum totam architecto cupiditate.", "Hope83@gmail.com", "Et qui odio nihil vel.", "Hope", "35450", "(371) 766-8178", "https://picsum.photos/640/480/?image=195", 4.1438161838538088, "Darwin Villages", "Bashirian", "Dolorem dolor.", "41323-3554" },
                    { 152, new DateTime(2021, 1, 23, 2, 52, 8, 949, DateTimeKind.Local).AddTicks(4959), new DateTime(2021, 12, 14, 12, 42, 42, 504, DateTimeKind.Local).AddTicks(922), new Guid("9e42b96f-4f08-46c6-8501-9b4b6c51d606"), "Radom", "Reunion", "Soluta provident provident et laudantium accusantium nihil odio dolorum voluptas consequuntur ut minus exercitationem cupiditate harum quo perspiciatis vel et et facilis similique adipisci harum eligendi molestias sunt ea autem.", "Alfred.Fay68@hotmail.com", "Eaque delectus suscipit ad est.", "Alfred", "692", "(358) 785-6875", "https://picsum.photos/640/480/?image=799", 4.7502812406747985, "Dare Ports", "Fay", "Mollitia omnis.", "92595-8577" },
                    { 151, new DateTime(2021, 1, 22, 20, 3, 16, 843, DateTimeKind.Local).AddTicks(3253), new DateTime(2021, 12, 3, 15, 10, 51, 938, DateTimeKind.Local).AddTicks(6033), new Guid("d370dc85-a98d-43cc-9432-d489e00af33f"), "Radom", "Brunei Darussalam", "Voluptatem odio inventore quidem eos voluptatibus cumque doloremque sunt et ea nesciunt et sit aspernatur sint ducimus assumenda rerum quo quam eos nemo consequatur voluptate impedit est odio similique cum.", "Tommie.Runolfsdottir@yahoo.com", "Ut et eum impedit dolor.", "Tommie", "298", "1-459-243-6429", "https://picsum.photos/640/480/?image=439", 2.0286422693303985, "Gutmann Camp", "Runolfsdottir", "Repellendus voluptatem.", "17252" },
                    { 150, new DateTime(2021, 1, 22, 16, 43, 17, 403, DateTimeKind.Local).AddTicks(9534), new DateTime(2021, 12, 27, 0, 23, 54, 783, DateTimeKind.Local).AddTicks(7730), new Guid("cb568769-fb13-44a0-9ae0-71d35ca08fd8"), "Warsaw", "Tanzania", "Repudiandae cum est impedit illo dolore reiciendis facilis et atque unde placeat vitae similique sit est quia velit saepe non modi veritatis sequi vero dolorem suscipit at voluptatem debitis doloremque.", "Shelia_Roob5@gmail.com", "Pariatur occaecati facere ut porro.", "Shelia", "444", "687.599.9837", "https://picsum.photos/640/480/?image=952", 3.0169899826948483, "Presley Meadow", "Roob", "Consequuntur quo.", "22523-8647" },
                    { 149, new DateTime(2021, 1, 23, 12, 5, 22, 316, DateTimeKind.Local).AddTicks(4028), new DateTime(2022, 1, 17, 20, 22, 13, 98, DateTimeKind.Local).AddTicks(6774), new Guid("61846364-72af-4a6a-98a6-f68779298fb3"), "Warsaw", "Bulgaria", "Molestias est porro consequatur facere vero aut dolorem esse incidunt at dignissimos delectus corrupti at necessitatibus tempora dolor voluptatem quae et dolor itaque omnis repellat ad officiis ex quasi aperiam.", "Jody63@gmail.com", "Sit libero a consequatur voluptatum.", "Jody", "710", "1-471-654-7999 x55410", "https://picsum.photos/640/480/?image=105", 2.2091825852213347, "Maggio Causeway", "Roob", "Beatae assumenda.", "60497-0456" },
                    { 161, new DateTime(2021, 1, 23, 2, 29, 13, 516, DateTimeKind.Local).AddTicks(2029), new DateTime(2021, 2, 21, 21, 21, 11, 908, DateTimeKind.Local).AddTicks(2138), new Guid("a6ad929e-fb66-4e03-b979-9e01134cbbb9"), "Gdynia", "Grenada", "Optio laboriosam soluta consequuntur quia blanditiis et deleniti ut doloribus perferendis reprehenderit odio sit laborum ab sit perferendis sit fugiat inventore quia et commodi doloremque fuga sit omnis occaecati ea.", "Sherri14@gmail.com", "Voluptatem aspernatur culpa quia totam.", "Sherri", "70245", "502.649.8196 x944", "https://picsum.photos/640/480/?image=620", 4.5152095982410057, "Freida Tunnel", "Jast", "In quo.", "94102-7325" },
                    { 148, new DateTime(2021, 1, 22, 13, 18, 2, 172, DateTimeKind.Local).AddTicks(5776), new DateTime(2021, 8, 16, 12, 48, 16, 59, DateTimeKind.Local).AddTicks(6748), new Guid("ea338d6a-8ed5-4aa1-b126-009afeefa4b8"), "Warsaw", "Japan", "Ea quibusdam aliquid est itaque neque sit velit tempora est ut dolores ipsam et asperiores blanditiis repudiandae minima eius et et quia nobis quisquam aut minus qui deleniti nihil molestiae.", "Timothy.Beer42@hotmail.com", "Et libero sed laboriosam nihil.", "Timothy", "00115", "1-912-892-2150 x483", "https://picsum.photos/640/480/?image=1053", 4.0998732499312016, "Monica Crest", "Beer", "Beatae aut.", "89652-0554" },
                    { 136, new DateTime(2021, 1, 22, 15, 44, 12, 971, DateTimeKind.Local).AddTicks(1309), new DateTime(2021, 7, 8, 11, 54, 2, 219, DateTimeKind.Local).AddTicks(2865), new Guid("36c40424-fb03-4251-92d5-e39c202f2d8b"), "Warsaw", "Bhutan", "Quidem ut id inventore aut qui et fugit impedit et hic hic omnis consectetur qui sapiente qui error qui doloribus vitae consequatur est molestiae ipsa quis et consectetur consectetur porro.", "Steve6@yahoo.com", "Atque minus incidunt maiores ut.", "Steve", "118", "968.534.0340", "https://picsum.photos/640/480/?image=809", 1.8461753562307801, "Rusty Forks", "Gerlach", "Est molestias.", "42118" },
                    { 134, new DateTime(2021, 1, 23, 5, 17, 6, 698, DateTimeKind.Local).AddTicks(9109), new DateTime(2021, 10, 10, 4, 53, 29, 833, DateTimeKind.Local).AddTicks(6131), new Guid("d5b8529a-fd32-4beb-9601-c0cf857dde9a"), "Gdynia", "Saint Martin", "Minima voluptatem quo sint qui corporis placeat eaque nobis error provident nobis illo deleniti qui dolor quia modi error expedita deserunt dolores autem qui qui aut dolore repudiandae consequuntur qui.", "Steve_Graham@hotmail.com", "Rerum dignissimos sed nulla inventore.", "Steve", "3637", "1-392-465-5386", "https://picsum.photos/640/480/?image=118", 3.6823366296861026, "Schmidt Points", "Graham", "Sit qui.", "04535-5912" },
                    { 137, new DateTime(2021, 1, 23, 12, 18, 3, 228, DateTimeKind.Local).AddTicks(5308), new DateTime(2021, 10, 23, 16, 43, 54, 540, DateTimeKind.Local).AddTicks(4102), new Guid("f890e41c-febf-45f6-86d6-739bd3080cd4"), "Gdynia", "Paraguay", "Repellendus animi laudantium veritatis sed vitae quidem iste et recusandae maxime reiciendis quas pariatur veniam optio earum debitis ipsum explicabo qui voluptate quis alias autem est neque qui eligendi alias.", "Darlene.Armstrong47@yahoo.com", "Laudantium est mollitia et sit.", "Darlene", "79064", "(876) 458-2469 x0775", "https://picsum.photos/640/480/?image=247", 3.9280847231522595, "Ed Green", "Armstrong", "Vel ipsam.", "67581-5519" },
                    { 138, new DateTime(2021, 1, 23, 7, 56, 12, 310, DateTimeKind.Local).AddTicks(8304), new DateTime(2021, 7, 2, 15, 58, 48, 151, DateTimeKind.Local).AddTicks(7752), new Guid("3e44273d-a407-49cd-8044-c31e0f4f35a3"), "Gdynia", "Martinique", "Dolorum perspiciatis soluta sed et a quo sit facere omnis veniam itaque amet dolor enim esse hic aut et aut ipsum sed labore quia quo qui eum aliquid voluptas hic.", "Bernadette_Purdy@hotmail.com", "Illum officia qui quam nemo.", "Bernadette", "5788", "745.646.8505 x1159", "https://picsum.photos/640/480/?image=344", 2.9265538742423773, "Ida Mews", "Purdy", "Blanditiis vero.", "59135" },
                    { 139, new DateTime(2021, 1, 23, 10, 26, 34, 138, DateTimeKind.Local).AddTicks(4464), new DateTime(2021, 4, 19, 2, 31, 13, 893, DateTimeKind.Local).AddTicks(6937), new Guid("272af3ec-54da-4709-9433-58b158f27477"), "Radom", "Mexico", "Aut fugit ut sit tempore sit non eos quia accusantium aut rerum ut numquam perspiciatis ut sunt aut accusamus vitae voluptas facilis et qui aut aspernatur aut sed tempora et.", "Rickey_Barton@yahoo.com", "Facilis id quia quod laudantium.", "Rickey", "682", "324-952-1928 x91844", "https://picsum.photos/640/480/?image=57", 3.1528661521863501, "Ali Drive", "Barton", "Magnam enim.", "92115" },
                    { 135, new DateTime(2021, 1, 23, 3, 19, 13, 364, DateTimeKind.Local).AddTicks(4061), new DateTime(2021, 9, 16, 23, 50, 29, 736, DateTimeKind.Local).AddTicks(929), new Guid("548c5236-aba6-4911-913f-5e89962ff33a"), "Gdynia", "Peru", "Dolorem sunt laboriosam dolor maiores commodi adipisci minus voluptatem explicabo earum voluptatem voluptas ea hic fuga numquam voluptatem a dicta porro similique voluptatem a itaque quo aut id vitae non.", "Laverne_Stracke@yahoo.com", "Quaerat et aliquam eum eum.", "Laverne", "42822", "978-608-2378 x04616", "https://picsum.photos/640/480/?image=16", 4.4113832839817668, "Koss Ramp", "Stracke", "Reprehenderit nobis.", "11647" },
                    { 140, new DateTime(2021, 1, 22, 18, 20, 0, 223, DateTimeKind.Local).AddTicks(686), new DateTime(2021, 8, 31, 13, 9, 37, 573, DateTimeKind.Local).AddTicks(1961), new Guid("9becf948-7e79-4a69-a52f-4e83ce37506e"), "Warsaw", "Angola", "Placeat recusandae aliquid molestiae dolores ea ad harum velit dolore nihil voluptatem ut enim magnam placeat reprehenderit blanditiis amet libero in iste ratione dolor quis eos labore et cumque est.", "Rick.Kirlin@yahoo.com", "Ipsam eveniet illo consectetur repellendus.", "Rick", "6002", "1-796-705-5403 x5789", "https://picsum.photos/640/480/?image=441", 4.4823955444071419, "Durgan Glens", "Kirlin", "Illum deleniti.", "40927" },
                    { 142, new DateTime(2021, 1, 23, 4, 11, 57, 182, DateTimeKind.Local).AddTicks(8169), new DateTime(2021, 6, 11, 9, 35, 46, 694, DateTimeKind.Local).AddTicks(5395), new Guid("590aead4-2c86-41a2-bd88-b20fa13346a7"), "Warsaw", "Cote d'Ivoire", "Vero maxime ut laboriosam cumque consequatur tenetur ut nobis aperiam distinctio repudiandae voluptatum quis culpa repudiandae autem placeat delectus rerum quam et quis repellat molestiae autem corporis est repudiandae totam.", "Jamie34@gmail.com", "Praesentium ut repudiandae voluptates cumque.", "Jamie", "3230", "(361) 483-9537", "https://picsum.photos/640/480/?image=174", 2.7121377036497636, "Beahan Forest", "Hickle", "Molestiae sed.", "25480-8449" },
                    { 143, new DateTime(2021, 1, 23, 9, 39, 35, 954, DateTimeKind.Local).AddTicks(6760), new DateTime(2021, 12, 19, 21, 14, 31, 28, DateTimeKind.Local).AddTicks(9234), new Guid("327c52cc-75c5-4f5d-bd94-5b9a74c0820e"), "Radom", "Iraq", "Facilis et ut possimus nemo nemo voluptate ut iure tempore atque et est rerum enim ea non id repellat dolorem praesentium et provident ducimus iure velit aut culpa aut nihil.", "Dustin0@yahoo.com", "Ea molestiae perspiciatis numquam explicabo.", "Dustin", "3328", "1-381-249-8292", "https://picsum.photos/640/480/?image=927", 4.3919319582134166, "Abbie Shores", "Emard", "Vitae aut.", "44393" },
                    { 144, new DateTime(2021, 1, 23, 9, 8, 55, 293, DateTimeKind.Local).AddTicks(7466), new DateTime(2021, 6, 3, 15, 57, 59, 125, DateTimeKind.Local).AddTicks(1865), new Guid("06a3a6f1-4c1a-4e1c-85e8-c98ab3080313"), "Gdynia", "Jamaica", "Architecto autem ut ut qui amet similique animi voluptates error corrupti veritatis voluptate qui accusantium non corporis sed doloremque voluptas voluptas earum quam enim a ut quidem vitae et et.", "Holly61@yahoo.com", "Velit nisi voluptates est magni.", "Holly", "841", "617-409-2509", "https://picsum.photos/640/480/?image=726", 4.4804828648830224, "Volkman Land", "Tremblay", "Qui mollitia.", "38861" },
                    { 145, new DateTime(2021, 1, 23, 2, 20, 53, 176, DateTimeKind.Local).AddTicks(8704), new DateTime(2021, 6, 15, 20, 27, 32, 288, DateTimeKind.Local).AddTicks(3569), new Guid("9686aed3-8ffb-4b4f-b9f4-5e789f22ffa2"), "Radom", "Macedonia", "Quidem et deleniti aliquid voluptatem asperiores ut assumenda culpa odit quia asperiores natus asperiores corrupti qui voluptatem expedita est rerum amet dolore asperiores hic nemo sed quisquam recusandae quia ut.", "Emanuel_Hagenes50@gmail.com", "Beatae placeat ipsam iure quasi.", "Emanuel", "6080", "1-247-909-0705", "https://picsum.photos/640/480/?image=683", 3.4679212805200001, "Willy Crescent", "Hagenes", "Eveniet ea.", "94468" },
                    { 146, new DateTime(2021, 1, 23, 7, 21, 34, 805, DateTimeKind.Local).AddTicks(7817), new DateTime(2021, 8, 18, 8, 10, 25, 427, DateTimeKind.Local).AddTicks(3877), new Guid("cf047336-3bbc-4429-a1e7-249be3659a7d"), "Radom", "Somalia", "Rerum perferendis pariatur rerum explicabo id veritatis officia maxime autem quod ut aperiam nostrum odit libero unde et deserunt ipsum recusandae vero voluptate vero mollitia aut doloribus vitae porro ut.", "Sarah50@hotmail.com", "Animi voluptatem earum sunt dolor.", "Sarah", "757", "968.828.5246 x1590", "https://picsum.photos/640/480/?image=941", 4.064107754763266, "Williamson Wells", "Schuppe", "Culpa harum.", "59513" },
                    { 147, new DateTime(2021, 1, 23, 3, 16, 3, 977, DateTimeKind.Local).AddTicks(717), new DateTime(2021, 3, 15, 21, 24, 34, 288, DateTimeKind.Local).AddTicks(5174), new Guid("ec86273a-2045-49d4-af34-85e8a74f8db6"), "Gdynia", "Saint Pierre and Miquelon", "Id soluta et asperiores alias eligendi architecto itaque labore placeat dolor libero consequuntur rerum ut cupiditate assumenda et occaecati voluptas dolorem molestias dicta excepturi et quam vel repellendus rerum sit.", "Ollie_Green46@yahoo.com", "Deserunt qui laboriosam culpa debitis.", "Ollie", "4619", "982-260-3247", "https://picsum.photos/640/480/?image=798", 4.4588198528898975, "Bernier Haven", "Green", "Exercitationem tempora.", "43853-1618" },
                    { 141, new DateTime(2021, 1, 23, 10, 18, 4, 456, DateTimeKind.Local).AddTicks(4949), new DateTime(2021, 7, 3, 7, 59, 14, 92, DateTimeKind.Local).AddTicks(7446), new Guid("6ae91c99-a790-4093-bb7c-804ae31aa355"), "Warsaw", "Dominican Republic", "Necessitatibus in corrupti aut dolor impedit reprehenderit tenetur deleniti delectus omnis eum accusamus eligendi quae vitae iusto quae odit nemo deserunt laboriosam alias expedita debitis voluptatem sint labore eveniet perferendis.", "Kathy.Nicolas@hotmail.com", "Fugiat dolores accusantium consectetur sequi.", "Kathy", "56322", "(249) 429-5255 x83808", "https://picsum.photos/640/480/?image=651", 4.3303451311450196, "Alanis Lock", "Nicolas", "Unde in.", "28220-6894" }
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
                values: new object[] { 13, 145, "Dolores impedit voluptas sed eveniet cupiditate culpa dignissimos. Fugiat corporis qui. Quidem tempore ex totam qui deleniti consequatur vero commodi.\n\nVel natus voluptatem eum delectus sint. Eveniet est nobis soluta velit minus dolorem. Molestiae libero iste sint repudiandae rerum. Et iste et repellat consequuntur quisquam est odit accusamus est.\n\nNemo suscipit sed adipisci voluptatum. Tempora voluptate magni odit. Quaerat fuga corporis quaerat illo suscipit corporis dignissimos iure voluptatum. Rerum voluptas hic delectus temporibus rerum dolore qui vel voluptates.\n\nVero magni tempora voluptatum beatae possimus. Sed et illum animi ipsum autem dolorem praesentium. Assumenda similique voluptas sit accusamus molestiae optio." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 25, 144, "Nisi nesciunt unde nostrum quae. Labore dignissimos magni eum eos. Nobis nihil itaque beatae. Dolorem omnis deserunt delectus nihil expedita vel dolore qui. Sint molestiae iusto temporibus incidunt similique reprehenderit laboriosam autem aliquam.\n\nSint eos vel sit voluptas voluptates nisi. Ipsam non aliquid officiis enim laudantium sint ea. Quas minus quae praesentium enim quisquam perferendis eligendi eaque et. Exercitationem commodi error dolorem ullam est eos blanditiis. Explicabo necessitatibus et ut rerum tempore qui.\n\nSint assumenda et doloribus quam officiis cupiditate. Explicabo est esse consequatur quidem est. Est nisi hic consequatur non.\n\nAnimi laudantium illum dolorem laborum dolorem ratione excepturi. Dolores recusandae dolores occaecati vero alias nemo. Est ullam dolorem excepturi numquam eaque eius praesentium dolorem dolorum. Animi est numquam omnis. Vero dolorem consectetur ipsum mollitia quaerat optio sit qui ab." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 44, 129, "Nihil est eaque alias. Tempora placeat voluptatem iure nihil animi consequatur ducimus. Recusandae repudiandae accusamus sint. Ratione nam est vel dolores aliquid. Id dolores non neque possimus temporibus.\n\nVelit cupiditate error quisquam sed voluptas labore nihil dolor voluptas. Incidunt vel quos qui tempore sit commodi. Ex sed minus. Ut et dolore dolorum aliquam eius modi libero vel voluptate. Consequatur velit ut ratione vel illo. A voluptates quae error quia dolorum fugit aspernatur quaerat voluptatibus.\n\nAnimi molestiae laudantium est nam quasi nostrum impedit. Corrupti iste explicabo omnis qui sit atque maiores quia aperiam. Asperiores qui in dolorem dolorem suscipit provident et quas sequi. Et minima architecto consequatur illo perspiciatis voluptas soluta beatae sunt.\n\nRem aliquid tenetur aut ullam quis harum fugit recusandae rerum. Maxime voluptatem pariatur rerum qui sit. Distinctio sed eum non ipsam illum nobis. Ad earum eius." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 96, 165, "Provident odit rem officiis non incidunt laboriosam officiis. Accusantium exercitationem accusamus. Expedita quia et earum aliquid. Molestiae qui dicta earum aperiam dolores sed. Perferendis eligendi saepe nostrum doloribus. Aspernatur dolorum maxime dolorem rerum et nemo.\n\nTemporibus quas voluptatem rerum ea. Et aperiam ad nostrum quam. Quas dignissimos neque odio quod velit. Quia dolor voluptatem minus corporis ex incidunt aperiam laudantium id.\n\nIncidunt odit vel ullam odio perferendis amet. Non rerum expedita et alias sunt illo deserunt dolor. Qui quia iure commodi repellat voluptatem rerum. Porro deserunt consequuntur quia id exercitationem minima quod amet. Eligendi qui est nihil omnis. Perferendis vel cupiditate provident qui minus corporis rerum.\n\nAut autem neque accusamus aut distinctio expedita nam ullam mollitia. Est laboriosam ea suscipit voluptatem iure optio ut. Vero corporis et. Ut dolorum fuga odit ipsa maiores nostrum corrupti. Quisquam quis corrupti in ipsam et. Corrupti inventore consequuntur." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 2, 196, "Neque adipisci totam. Id id dolorem accusantium impedit. Nihil occaecati quos eaque. Fuga enim nemo ratione ratione dolorum architecto.\n\nQuasi blanditiis officiis unde quibusdam dolor optio quisquam. Culpa praesentium repudiandae in rerum est placeat quidem optio in. Sequi autem facere asperiores itaque. Vel est accusamus quaerat quam sunt. Dolor ad voluptatem et minima. Provident odio cumque culpa.\n\nQuidem quae tempore dolorum in molestias et. Et provident ad cumque aut est. Commodi quae at nobis neque. Error autem consequatur ut rerum. Laudantium quae voluptates qui numquam. Quam ullam iure qui doloremque rem placeat dolores deserunt.\n\nRepellat ducimus maiores libero. Dolorem reprehenderit nulla eveniet placeat sed quasi magnam corporis. Sint voluptatem praesentium. Deserunt vitae inventore eos laudantium enim. Modi sit eum recusandae libero omnis quisquam perspiciatis consequatur explicabo. Est deserunt debitis sint id voluptatem explicabo numquam tempora eos." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 96, 184, "Aperiam qui aliquam dolorem itaque qui cupiditate. Ut rerum autem laudantium sapiente. Nihil aliquid impedit. Maiores et laudantium et sunt architecto voluptatum quod assumenda dolore. Fugiat eum et. Suscipit harum quidem laudantium vel et.\n\nVoluptas eligendi non eos qui. Perferendis temporibus officiis et ut. Laboriosam dolores ipsum similique dolor est velit illum ad ad. Error enim aperiam. Ducimus temporibus necessitatibus voluptas molestias deleniti et dolores.\n\nItaque suscipit eum facere blanditiis non ea deleniti. Dicta sed laudantium. Veniam est incidunt.\n\nIllo fuga consequatur. Odit qui similique alias maiores aut qui atque aspernatur. Repellat molestiae et ex vel veritatis illum veritatis nam vitae. Rerum molestiae voluptatibus porro. Quidem ad repellendus qui beatae unde ad." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 23, 111, "Blanditiis tempora corporis dicta. Doloribus sed totam ratione eaque suscipit esse. Minima asperiores sapiente quis et nesciunt ullam qui. Vel laudantium sed cumque a. Ducimus est dolores quia nesciunt officiis commodi quo ea asperiores.\n\nModi sint similique similique corporis vero sequi eos dicta qui. Quos quasi ex animi dolorem nulla quo delectus sint aperiam. Sit et ut non quaerat. Repudiandae sequi animi nostrum sit sed beatae quasi porro. Neque quaerat perspiciatis explicabo eum et expedita facilis illo.\n\nAdipisci doloribus cupiditate accusantium soluta. Recusandae dolores quasi nam sunt animi qui hic recusandae voluptatibus. Rem et minima provident qui aperiam cum impedit. Earum praesentium sequi voluptas quaerat. Blanditiis corrupti porro neque. Voluptatem laboriosam minima.\n\nFacilis voluptatem architecto expedita voluptatem ratione eveniet. A ipsum amet occaecati quod maxime a pariatur voluptatem nemo. Voluptatum nisi incidunt ea recusandae ratione voluptates incidunt assumenda et." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 14, 144, "A consequatur aut animi. Modi quibusdam natus. Aut dicta ut recusandae maxime. Sed incidunt earum aperiam exercitationem nam incidunt velit maxime qui. Labore repudiandae magni aut cupiditate eaque animi.\n\nItaque architecto dolore enim dicta consectetur sint et aliquid. Sapiente non neque quaerat error. Quos aspernatur nostrum rem est qui eos praesentium. Maiores aut et corporis ea ab consequatur.\n\nEaque consequuntur maiores tempore rerum odit placeat dolorem veritatis molestiae. Corporis architecto expedita error. Doloremque itaque nemo voluptates illo. Itaque repellendus id aut nemo atque voluptas. Ut mollitia distinctio velit eius iusto eligendi qui sequi amet.\n\nSit quo veniam ut voluptates modi et. Voluptas aut inventore. Voluptates dolores consectetur velit itaque nulla quibusdam ut. Quasi nesciunt qui facilis officiis iusto. Id non repellendus quia." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 50, 119, "Quas quas consectetur vitae. Omnis nam nesciunt sed sit nostrum est. Quos rerum nemo iure.\n\nQuaerat iste cumque officia. Temporibus id in. Quia recusandae blanditiis. Veniam ut optio et et porro.\n\nVoluptate repellat quae fuga qui quo rerum aut. Deleniti minus qui suscipit hic. Aut repudiandae nesciunt exercitationem aut ea perspiciatis fugiat. Natus officiis odio ad quibusdam qui et. Vel sint pariatur iste expedita sapiente ducimus architecto.\n\nAutem nulla sed qui beatae. Nemo necessitatibus occaecati dolores quam. Minima eos dolorem dignissimos et impedit enim laborum enim. Dolorem inventore sint illum aspernatur odit voluptatem hic impedit eius. Architecto facere maiores. Fugiat quibusdam odit delectus et non." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 26, 116, "Doloribus reprehenderit numquam eveniet. Aut labore aut sint voluptatem qui vel quaerat. Velit quod sunt repellendus.\n\nQuia aut dolor ipsa incidunt repudiandae dolorem facilis. Rerum libero aut officiis culpa aut. Itaque ab aut esse temporibus aspernatur quo delectus.\n\nSed officiis assumenda. Ea quis illo corporis. Aut numquam ipsum. Qui quidem mollitia similique ut ex suscipit earum.\n\nAtque aut occaecati. Dolor tenetur aut enim non dolor non vel nostrum. Et officia exercitationem facere similique omnis incidunt quas voluptas. Voluptatem omnis consectetur non et laborum. Vitae vero facere quis ea quo natus enim aliquid et." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 1, 161, "Dignissimos ut quisquam voluptas eum inventore. Quis consequuntur saepe reiciendis ipsa eos nam. Omnis culpa voluptate. Vero magni occaecati ut officia aut placeat.\n\nNumquam harum dolorum et autem molestiae. Et totam sed deleniti omnis laboriosam impedit minus. Nemo ipsam cumque eveniet ut deserunt laboriosam sed ea. Voluptas molestiae aut dolores dignissimos quidem quia. Nesciunt quos enim.\n\nNumquam a sunt nostrum vel molestiae quae occaecati. Repellendus soluta minima error ab quo. Fuga nostrum quam aspernatur. Mollitia omnis fuga suscipit possimus voluptas tempora ut unde.\n\nEum est atque itaque optio ullam sapiente. Ex aut et qui consequuntur. Debitis officia corrupti saepe sed velit pariatur vel qui." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 18, 162, "Dolorum vitae illum quis officiis perspiciatis sunt qui sint error. Sint quia sit ratione maxime fugiat est quidem et deleniti. Aliquam quod laboriosam perferendis ipsa quod qui eum et possimus. Nisi laboriosam consectetur ut est aperiam mollitia aperiam. Sapiente accusantium qui vel non et. Quidem doloribus non ut ducimus voluptatum maxime eum.\n\nEos et aliquid repellat sunt optio qui voluptas reiciendis asperiores. Quia odit expedita ipsa totam architecto repudiandae incidunt nesciunt sapiente. Dolor eaque vel quo recusandae numquam corporis accusamus deserunt.\n\nOmnis quia aspernatur nobis voluptate officiis. Dignissimos laborum ut officiis placeat. Aut ad et voluptatibus in eum. Sint maiores inventore quia enim sit magnam.\n\nLaudantium aut in mollitia quod sit atque earum dolor libero. Ut quo ut. Corporis nostrum eum a distinctio quo quia. Voluptas omnis perspiciatis autem fugit omnis. Modi fuga error sint ratione. Voluptatum sequi est." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 80, 156, "Qui autem optio sed. Quos sit voluptatem et nostrum aut non qui. Quidem fugiat adipisci sed consequatur neque velit ducimus. Laboriosam velit sed ducimus dolorem eos. Voluptate et sequi quia id ut veritatis nisi.\n\nPossimus aliquid nihil suscipit praesentium corporis alias. Voluptas voluptatem quos perferendis nihil qui. Veniam autem ex consequatur iusto quae adipisci rerum aut.\n\nInventore voluptatem et nam. At vel maxime ea inventore accusantium vitae aut saepe. Ut maiores illum sed. Dignissimos possimus suscipit blanditiis mollitia impedit. Quisquam culpa error totam voluptatem. Modi dolore voluptatibus similique dolor unde.\n\nSoluta doloribus qui quaerat exercitationem voluptatum aut ut. Quia et eveniet. Autem corporis est qui quasi veritatis. Distinctio dolorem voluptas deserunt nihil harum distinctio. Numquam in aut enim similique possimus voluptas voluptas." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 20, 161, "Tempora atque quas ex. Quam a molestiae rerum exercitationem fugit. Atque sed aut. Voluptatem eos omnis nam illum praesentium sit.\n\nAutem sit minus doloremque sed vitae. Assumenda eum quis quia distinctio. Consectetur quis cum incidunt nihil et. Optio repellendus ducimus repellendus magnam. Totam facilis quidem esse assumenda laudantium eum.\n\nDicta modi in voluptate non eos laboriosam. Eum quibusdam at libero rerum voluptatem maiores qui. Aspernatur reprehenderit nihil aut rerum hic dolor et et. Dolores velit occaecati impedit fugiat non qui. Qui eum ullam impedit. Ea magni et maiores qui rerum.\n\nEst fugiat sit consequatur iusto magnam. Sed ad dolorum corrupti mollitia magnam sed. Enim sunt voluptatem eos. Veritatis sed facere blanditiis iure. Nisi debitis ut delectus eum aut explicabo tempora corrupti culpa." });

            migrationBuilder.UpdateData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "ClientId", "PetsitterId", "Text" },
                values: new object[] { 35, 151, "Maiores repellat dolor non vel. Quia sequi necessitatibus. Eveniet autem consequatur nesciunt voluptatem. Beatae natus reiciendis.\n\nQuisquam recusandae enim ut excepturi et voluptatem porro distinctio consequatur. Fuga vero autem et ex perspiciatis facilis ad. Consectetur maiores sapiente quasi aut neque itaque voluptates autem. Earum commodi recusandae autem ut veritatis accusamus.\n\nEt voluptatem iusto incidunt dolores. Facere tenetur repellendus magnam. Provident sint cumque libero quo minus aut et tempora. Natus fugit nisi sequi accusamus. Est atque odit consequatur corrupti similique. Distinctio facilis possimus possimus laudantium.\n\nNon sequi expedita et aut. Nam ut distinctio. Sunt et placeat tenetur illo eaque sunt. Et assumenda veritatis. Cum dolore enim delectus in ipsa. A reiciendis molestias." });

            migrationBuilder.InsertData(
                table: "BookingMessages",
                columns: new[] { "Id", "ClientId", "PetsitterId", "Text" },
                values: new object[,]
                {
                    { 30, 28, 131, "Temporibus porro molestiae et sed similique. Quidem iure velit eos earum aut. Sapiente hic tempore hic qui velit ipsum dignissimos ducimus. Fuga dolorem est soluta quo ea soluta. Omnis placeat et sint nostrum eum.\n\nCorrupti autem mollitia sed reprehenderit ullam sed incidunt. Mollitia repudiandae aliquid aut qui exercitationem ut. Vel dolorum eaque autem dolor. Accusantium sint id dolorem voluptatem non ipsa expedita nostrum perspiciatis.\n\nAutem nulla voluptas modi quia quae perspiciatis nesciunt. Ducimus voluptas occaecati. Blanditiis natus est voluptatum omnis commodi. Nihil accusamus similique animi et dolores vero corporis deleniti itaque. Consequatur sed nobis sint et earum deserunt.\n\nDolore fuga vel culpa consectetur eius repellendus consequatur quis qui. Non dolor placeat consequatur. Minima est similique consectetur amet et cum. Dolorem occaecati ipsam eligendi." },
                    { 36, 7, 189, "Excepturi qui ipsa quibusdam aspernatur quaerat numquam. Eos corrupti perspiciatis labore magnam consequuntur. Nisi incidunt et aut iste vel minus et et. Aliquam sed voluptatibus quia. Vel cum mollitia doloremque rerum consequatur.\n\nAdipisci numquam cumque aut facilis. Dolorum eligendi recusandae. Illum dolores et illum a perferendis aut omnis distinctio.\n\nVoluptas qui incidunt tempora ea odit et facilis. Sit ea magni molestiae. Necessitatibus at nihil sunt eveniet dolorum iusto quia corporis. Impedit et error quisquam. Tempora dolorem nihil esse quidem ex quasi. Aut veniam repudiandae possimus ab impedit.\n\nConsequatur qui rerum et neque aspernatur. Voluptas quia ut sint voluptas veritatis sint molestiae. Ratione et repellat perferendis optio quo quis. Qui eum qui aut maiores et iure. Libero facere nisi nostrum dolorum et esse." },
                    { 47, 78, 190, "Ducimus quae dolorum voluptas commodi amet velit qui. Culpa quidem odit sunt quaerat nihil explicabo. Et consequatur nulla aut quia accusamus nobis aspernatur a.\n\nIpsum tempore quaerat sequi. Occaecati ut earum eum itaque veritatis dolor quibusdam. Ea velit sit sit ad officiis commodi debitis consequatur doloribus. Reprehenderit et consequuntur quia itaque maxime.\n\nVeniam natus et voluptatem deleniti blanditiis sunt voluptates atque impedit. Nulla consectetur ab ab sapiente libero nam sint soluta. Voluptas nostrum et enim placeat quaerat. Modi voluptas ducimus adipisci expedita voluptatem excepturi in odio aut.\n\nNihil sapiente aut ipsum doloribus qui eius nisi. Dolorem molestias enim dolorem est excepturi occaecati. Inventore quae minus adipisci tempore. Porro quaerat fuga consectetur molestiae sed et occaecati. Consequuntur consectetur reiciendis odio aut quia officiis consequuntur provident." },
                    { 48, 34, 192, "Dolor consequatur non facere asperiores. Vel fugiat consequatur provident. Enim dolorem repudiandae.\n\nNostrum aut sint facilis porro ratione quidem maxime quasi rerum. Amet sint velit minima. Harum praesentium vitae aliquam quaerat. Ut occaecati qui tenetur.\n\nRerum ipsum porro quia quas quia labore aut. Velit ut doloremque minus amet nobis. Maiores adipisci repudiandae est magnam. Quidem nihil fugiat aut eligendi sed ut in.\n\nEum reiciendis quibusdam eveniet et itaque soluta maxime a. Et eius sint ab. Architecto quos amet provident hic eaque impedit. Aliquam provident aut autem qui atque. Nulla sit repudiandae." },
                    { 16, 98, 133, "Blanditiis est sit nulla porro nihil. Sunt sint vero illum reprehenderit id est nam cum. Voluptatem adipisci quod voluptatum velit ut consequatur dignissimos dolorum.\n\nIste culpa nemo omnis vel facilis qui consequatur. Repellendus ab rerum est aut sit velit ratione amet iusto. Exercitationem ullam tempore ipsum omnis qui.\n\nVel quia ea. Sit sed perferendis. Unde eaque in sapiente voluptatem. Dolor ab aut omnis sunt. Beatae recusandae eos quaerat amet. Voluptate quaerat et eos alias quam quo sed maiores.\n\nTenetur praesentium non dicta asperiores eos. Laborum voluptatum reprehenderit. Sint fuga et modi corporis iste delectus dignissimos ipsam ratione. Ex quo possimus et velit eaque sequi magnam corrupti enim. Libero voluptatem explicabo." },
                    { 46, 54, 133, "Quod dolores voluptatibus quidem reiciendis rerum ut laudantium voluptatem possimus. Magni et cum sed rerum. Et vero occaecati ut fuga dolor dignissimos. Sit quia perferendis.\n\nSunt dicta veritatis unde ducimus est deserunt aliquam. Neque natus tempore. Officia fugit non nisi iure dignissimos sit rem occaecati soluta.\n\nFugit a sed. Quibusdam sint modi veniam est sit velit. Aut incidunt excepturi. Quia est eligendi a incidunt. Deserunt voluptas accusamus quo id similique asperiores labore. Voluptate aspernatur sed.\n\nIllo optio minima est laboriosam iure voluptas ea. Eos et nesciunt recusandae necessitatibus ratione autem maiores consequatur dolor. Commodi quia est a omnis et. Consequatur magni temporibus ut similique." },
                    { 19, 16, 183, "Temporibus ipsum a qui animi sunt veritatis error deleniti sint. Non asperiores sunt adipisci quaerat illo. Molestiae esse qui mollitia debitis quia. Voluptatem laudantium mollitia. Ullam quos consequatur itaque totam aperiam optio voluptates modi.\n\nAut velit et sint facilis architecto quia. Et explicabo et dignissimos qui nemo. Consectetur nostrum placeat. Laboriosam odit totam autem sit. Sed enim non. Dolores aliquid eum et molestiae corporis fuga.\n\nNatus maiores dicta inventore provident. Reprehenderit ab rerum et consequatur nulla ea nesciunt. Est qui facilis ea aut quos cupiditate et est accusamus. Maxime beatae perferendis et consequatur rem distinctio. Amet aliquid magnam quae itaque sed autem reiciendis deleniti facilis.\n\nSunt consectetur earum qui non expedita eius est. Aperiam amet odio consectetur sapiente non enim aperiam quo. Eveniet sit rem ut sed ea ut." },
                    { 21, 48, 130, "Id voluptatem est itaque eligendi consequatur. Dolor corrupti et et in labore. Corrupti at repellendus eos. Laborum debitis corporis fuga dolores quod et labore ipsa ut.\n\nNemo ut sint quia aperiam voluptatibus explicabo facere. Quasi eligendi fugiat numquam temporibus. Repellat perspiciatis nesciunt. Quos odio quos impedit et ullam. Sequi adipisci saepe sunt ea non non nulla.\n\nQuisquam perferendis blanditiis accusamus eligendi. Soluta perspiciatis amet. Velit impedit distinctio et optio aut. Et numquam illum iste sit dolorem suscipit. Eveniet vero qui quo deleniti ut consequatur dolor est.\n\nNihil non et sit consequatur dolorem ipsam. Quis dignissimos sed sunt debitis voluptatum rerum eos harum. Facere nihil consectetur sed ipsa autem magnam tenetur eum. Similique ipsa provident necessitatibus cupiditate dolorem dolor quae." },
                    { 29, 91, 137, "Repudiandae voluptatem ut autem et. Est quis natus. Veniam et voluptates sit fuga. Voluptas exercitationem iure dolores. Eaque expedita maxime ea reiciendis qui.\n\nPariatur consequatur aliquam aliquam provident blanditiis eligendi rem molestias. Aut pariatur voluptatem autem sit repudiandae cupiditate laboriosam rem. Hic id quasi occaecati ratione quo debitis consequatur nesciunt perferendis. Nihil et et impedit delectus doloremque.\n\nQui non id aliquam dolores esse. Et dolore rem eum quo quidem aut minima. Fugit ullam minus aut eligendi culpa voluptas ipsam quos ut. Aliquid deserunt vitae numquam rerum vero sapiente. Et non deleniti in odit et voluptate et.\n\nDolor illum enim eius non. Libero ullam iste nobis voluptatem id nihil. Ratione eos exercitationem quo dolorem aliquam rerum reiciendis cum. Non eligendi quidem quisquam fuga. Quis hic et voluptatibus ipsam provident labore. Et atque perspiciatis qui." },
                    { 33, 36, 135, "Ut minus nesciunt minima tenetur minima soluta. Qui in non eligendi enim. Et est accusantium dolorum modi eaque ut enim. Vero eaque aliquid quae fugit natus possimus eum enim. Et recusandae vero corporis qui tempora corporis labore cum.\n\nExcepturi quod quia a. Et numquam est dolores iste sed incidunt. Ullam et id ut error dolor quidem adipisci eius rerum. Id et eum in. Et quibusdam nostrum est tempore ut.\n\nSunt unde magni. Expedita quia magnam provident cumque non consequatur. Fuga quasi cum saepe. Recusandae exercitationem vero beatae modi et quae quidem sit numquam.\n\nBlanditiis aliquam tenetur rerum. Qui perferendis est explicabo sed ipsa harum. Aperiam eos autem quis assumenda pariatur sed in. Id illo odio hic et ab vitae et voluptas sapiente. Quis dolore tempore illo quaerat ab. Distinctio et aut in magnam modi consequatur amet commodi libero." },
                    { 49, 21, 178, "Repellendus et ab excepturi ipsum est. Assumenda quam temporibus. Officia et fuga beatae et omnis qui quia sunt. Consequatur repudiandae natus quis quaerat quo voluptas. Nemo qui nulla assumenda nobis nihil possimus atque odio et. Quia corrupti fugit.\n\nAut et et voluptas voluptatem ea quae. Sit nulla esse. Corrupti modi repudiandae vel possimus eos aut.\n\nQui non sint quia eum fugit eos veritatis dolore illo. Optio ut atque reprehenderit suscipit. Facere rerum explicabo voluptas qui voluptas quis. Asperiores numquam tenetur et. Fuga alias sunt expedita voluptatibus recusandae culpa.\n\nDolore amet sit itaque autem dolorem qui occaecati quod. Voluptatum adipisci aut dolorem omnis ipsum labore. Et dicta iure. Voluptates illum soluta et dolore quia enim et blanditiis possimus." },
                    { 18, 39, 172, "Qui amet laborum libero quia tempora mollitia consequatur. Ad aut tempora quidem aut excepturi debitis omnis. Ut et corrupti aut aliquid. Autem sunt voluptas esse ut nihil sed. Itaque mollitia mollitia et adipisci maxime et voluptas quia.\n\nProvident sit assumenda cum quaerat et repellat sed commodi. Omnis ut perferendis fugiat aspernatur exercitationem quidem eveniet sit. Enim sequi aut quis eaque molestias officia nobis doloremque. Est deleniti dolores voluptatibus qui dolor. Eveniet et quia ut necessitatibus possimus rerum. Commodi culpa dicta explicabo.\n\nEt eos voluptatem omnis autem. Deleniti quidem facere et enim. Recusandae beatae exercitationem quod doloremque perferendis sint. Quod fugiat consequatur accusamus eum qui veritatis consequuntur.\n\nEt officia qui qui voluptates laboriosam nisi et dignissimos vero. Quaerat ipsam occaecati distinctio. Dolorem accusamus et dolorum unde architecto. Omnis unde aperiam magni. Ipsum reiciendis quaerat ex sapiente." },
                    { 45, 43, 137, "Voluptates voluptatem est est aperiam aperiam quidem. Sit vel molestiae dolore atque aut fugiat. Dolor ut corrupti ducimus earum modi deleniti ea qui. Sit non tempore excepturi at voluptate et quis. Aut non occaecati.\n\nNostrum fugit voluptas assumenda minima architecto. Nisi velit consequatur atque qui earum non et est. Sit repellat nemo perferendis aut non tempore cupiditate sint.\n\nQuibusdam tenetur dolorum distinctio. Illo nesciunt dolorem saepe impedit beatae et voluptates cum. Et accusantium blanditiis.\n\nDistinctio ipsam eaque debitis cupiditate voluptas quam dolor amet. Dolore omnis eveniet fuga perspiciatis praesentium consectetur dolorem. Necessitatibus illo et quibusdam dolores magnam nisi. Laboriosam repellat veritatis facilis et ab." },
                    { 20, 29, 171, "Quae sequi corrupti quia voluptatum iste dolores. Ad ut aliquam perferendis. Voluptatem dolorem vel.\n\nConsectetur atque earum facilis voluptatem voluptatem excepturi dolorum eius voluptate. Sit hic recusandae natus ex doloribus. Hic sit corrupti. Quia voluptas error enim rerum. Velit illum quis perspiciatis. Minus aspernatur id sunt ea magni.\n\nVero laboriosam qui qui explicabo in quia qui. Neque dolores eos voluptas atque illum nemo aspernatur. Facere dolorum nisi.\n\nAperiam sint eligendi eius fugiat tenetur. Officia eveniet est ex harum aperiam ducimus fugit totam. Voluptatem porro impedit expedita ut soluta est dolore minima." },
                    { 42, 58, 162, "Eveniet magni corrupti. Et asperiores aut incidunt voluptas sint voluptatem laborum. Incidunt est aperiam accusamus optio.\n\nQuas facere consequatur. Quaerat doloremque dolor quis est qui. Eum dolor natus labore eos ea. Reiciendis voluptate placeat voluptates voluptatem repellendus itaque doloribus omnis omnis. Vel consequatur et saepe beatae excepturi qui quia explicabo autem.\n\nAnimi qui cumque quae. Eum aut doloribus voluptates tempore accusamus. Ad nostrum mollitia iusto modi qui enim ut. Et ut omnis.\n\nNihil quae aspernatur quod voluptatem dolorum molestias adipisci voluptatem quia. Quod ducimus nesciunt a temporibus doloremque impedit. Quia dolorum temporibus sint nihil ut. Odit sed quia ipsum voluptatem molestiae dolores iste. Possimus necessitatibus ipsum voluptate." },
                    { 28, 60, 157, "Distinctio amet ad non eos qui praesentium voluptatem dolor. Eius illo voluptas et fugit temporibus aut. Beatae ipsam ea tenetur corporis consequatur ipsam quidem rerum et. Possimus repudiandae vel cum tempore.\n\nQuisquam mollitia iusto eius iste eos voluptatem. Neque iusto a delectus et dolore et est cupiditate. Voluptate nihil aut. Laborum tempora quaerat aut quo quam.\n\nVel et assumenda officia et quia. Vero omnis dolores harum iusto est. Cum sint eius et saepe modi nostrum laborum voluptatem deserunt. Quaerat voluptatibus quia sapiente placeat ratione eveniet ad. Inventore nemo velit nulla sit expedita et libero corporis.\n\nDucimus vel minus. Nisi officia est non consequatur fugit voluptas. Quia earum aut tempora labore saepe. Aliquid id neque. Dolorem consequatur porro autem aut ut voluptatibus dolorum enim aliquid. Velit dignissimos dolore et dolorum nesciunt et." },
                    { 17, 29, 157, "Facere facilis impedit. Velit maxime veniam quasi omnis fugit. Sunt perspiciatis voluptate ut.\n\nIllum sit error. Et blanditiis tempora et est blanditiis. Sint consequuntur quod enim aut autem natus et sed sint.\n\nVoluptatem laboriosam voluptatem. Explicabo repudiandae assumenda. Et aut doloribus maxime a occaecati dolorum nobis. Atque non quisquam quis.\n\nEst quis rerum est. Nulla id quo amet. Voluptatem esse aut aut velit magni doloribus. Et occaecati aut eos repellat enim commodi facere debitis enim." },
                    { 41, 86, 148, "Molestias voluptatibus doloribus sed maiores veritatis aut. Animi aut consequuntur voluptate dicta qui voluptate omnis. Magnam est cum nesciunt eum aspernatur.\n\nQuod fugit libero voluptas totam debitis. Fuga et nisi dolores autem nostrum sit ipsam velit eos. Corporis voluptatem perspiciatis beatae ullam tempora harum aut. Neque error ea quia. Et dolor et hic et voluptatibus dolores magni sit dolor. Eum repudiandae maiores aut quasi quis.\n\nMaxime autem distinctio aut nam. Odio dolores dolores et dolor inventore exercitationem modi est. Excepturi earum consequatur voluptas aut molestias quia vitae. Facilis sint enim est eos sequi temporibus dicta veritatis.\n\nVoluptate eveniet in. Doloribus nulla quidem voluptatum. Quisquam eos neque corporis quaerat animi. Consequatur quo esse labore." },
                    { 31, 6, 154, "Laudantium quis soluta beatae illo maiores velit iusto ut ab. Dicta possimus sunt harum blanditiis soluta voluptate modi numquam voluptatem. Aut consequatur hic. Possimus tempore ut sunt enim enim est exercitationem. Aut quasi molestiae.\n\nIpsam dolores voluptas eos enim. Quam minus necessitatibus eos perferendis magni quo. Et ea error tempore magni quam. Quod provident quaerat omnis.\n\nLaudantium accusantium dolorem eum possimus tenetur. Ut rerum voluptatem libero optio ex eius accusantium repellendus eaque. Qui rem adipisci. Nihil et qui autem aperiam veritatis. Animi qui ea est adipisci a nihil.\n\nQuaerat quia voluptates deserunt reiciendis explicabo. Reiciendis omnis sed quia tenetur dolores sit quidem voluptatem sed. Quia qui maiores." },
                    { 39, 49, 182, "Pariatur et porro perferendis ab. Natus iusto ducimus hic esse cumque aliquam id. Est corrupti itaque. Neque aut est explicabo voluptatibus. Ratione voluptatem nulla sed earum illum.\n\nId ut dolore debitis ea nihil assumenda. Possimus ipsa quos aut aut et saepe eligendi. Doloremque accusamus modi.\n\nEt consequatur id dolorum ut. Quo ut molestias magni voluptas. Sint et repellendus. Vitae sint corrupti odio numquam error id ut nihil.\n\nSequi non voluptates rerum et ipsum. Ullam odio qui dolor cupiditate praesentium. Vero sed ea. Debitis ut eum et labore hic ex id." },
                    { 34, 57, 127, "Nulla culpa occaecati eveniet molestias dolorum minima delectus. Amet non vitae qui molestiae temporibus laudantium. Aut porro et blanditiis sequi. Laboriosam et eius.\n\nNobis velit rerum voluptas deserunt pariatur odio nam. Sequi facere et est. Cum et amet ipsum beatae itaque qui eveniet. Sequi nulla ducimus amet eligendi. Dolor aspernatur quis aperiam mollitia veniam sequi.\n\nCorrupti exercitationem maiores quia enim ipsum. Quis enim omnis voluptatum blanditiis. Harum eos facilis veniam. Et corrupti sint ratione distinctio placeat nesciunt aut inventore. Qui illo esse cupiditate quasi id.\n\nTenetur enim qui quia autem iste quia nihil numquam. Accusantium laudantium voluptatem. Ipsam quos dicta veritatis non nisi. Ut delectus laboriosam fugit eveniet necessitatibus eius ut. Iure esse tenetur ex eligendi aut sed saepe eligendi commodi." },
                    { 22, 89, 127, "Cumque asperiores ab eum commodi voluptas. Ut voluptas eaque id eum sit sunt laboriosam officia. Consequatur beatae vero suscipit est quaerat.\n\nFacilis error impedit exercitationem deserunt mollitia placeat repellendus consequatur alias. Et expedita molestiae atque. Mollitia et non.\n\nOfficiis tenetur dolorem deserunt. Quaerat aut voluptatem ab explicabo id aut. Quisquam sed qui earum dolore dignissimos. Mollitia est sunt ratione occaecati eum culpa deserunt possimus quod.\n\nEarum voluptas est laborum rerum nihil aperiam laboriosam. Harum voluptatem voluptates praesentium quaerat sit impedit veniam tenetur et. Dicta ipsam omnis tempora eum soluta quasi. Soluta non qui nemo ut alias et impedit. Officia quaerat ut numquam odit quae sapiente sit distinctio est." },
                    { 44, 25, 153, "Sed maxime labore laudantium officia dolorum laboriosam voluptatibus minus. Minima sit rerum dignissimos ea fuga. Nostrum id quis provident nisi soluta aperiam illo. Voluptatem quod eius omnis sunt natus voluptatem sequi.\n\nLibero suscipit harum accusamus. Ut exercitationem est accusamus veniam consequatur dicta occaecati. Aperiam incidunt facilis rerum aliquam est.\n\nVelit repudiandae ea mollitia. Aut nisi quisquam aperiam qui nihil sequi tenetur autem. Minus fuga error ab doloremque dolorem est enim.\n\nQuo qui vero sint. Ut et sit totam. Porro excepturi ratione quia voluptatem corporis ratione dolore quidem nam." },
                    { 50, 99, 112, "Placeat est ab quia esse voluptatum rem iusto assumenda quis. Quo voluptatem atque maxime voluptas hic ex. Ut minima velit aliquam ea sint. Quia et veritatis porro architecto consequuntur totam rerum. Deserunt ipsa molestias libero voluptates molestiae.\n\nNemo sint velit. Eum facere et. Voluptas id aliquid harum unde reprehenderit est sed porro. Tempora quis ab exercitationem iure.\n\nVeritatis sequi et odio est rem. Aut ratione rerum dignissimos molestias animi autem corrupti ducimus voluptates. Occaecati sed aut officiis velit. Corporis hic rerum velit aut.\n\nNon eaque porro. Animi vel consequatur architecto dolores et eum ea dignissimos. Optio fugit saepe quod." },
                    { 37, 48, 113, "Ea quo tempora voluptate. Ex quis laborum voluptatibus quo. Porro et at molestiae dolore omnis minima. Omnis enim pariatur ut quia enim quia quidem et quos. Accusamus ut facere rem rerum cum deserunt reiciendis. Ducimus laborum magnam ea et quae.\n\nOdio consectetur ea rerum pariatur deserunt neque non. Itaque illo aspernatur consectetur quisquam ducimus sed. Voluptas beatae sapiente dolor ut.\n\nEt qui iusto dolorem inventore ducimus repellat consequuntur. Atque adipisci qui sunt consequatur. Hic officia perspiciatis. Quod ut debitis ut qui. Dolores et veritatis ut.\n\nRem dignissimos placeat quo accusantium nesciunt repellat. Odit earum molestiae dolorem nihil cupiditate porro doloremque voluptas. Magni autem quidem quidem aut fugit et iste nihil." },
                    { 24, 56, 127, "Cum sapiente qui. Voluptate blanditiis rerum repudiandae veniam repudiandae qui ducimus sunt eos. Cum aut ducimus velit itaque aut sit accusantium dolorem. Sunt consectetur sed ratione ut culpa pariatur omnis.\n\nNon qui qui eum deleniti occaecati accusamus assumenda rerum eveniet. Harum vel eius suscipit eveniet vel ea unde qui. Recusandae sunt quaerat fugiat voluptatem voluptate voluptas maxime. Debitis libero aut non voluptatem. Distinctio et porro esse aut. Beatae non at itaque autem.\n\nRerum assumenda corrupti incidunt nulla enim deserunt dolorem aut. Numquam fugit aut accusantium laborum sit sed. Id tenetur illo labore placeat rerum dolores. Voluptate vero rerum.\n\nNecessitatibus dicta tenetur odit similique reprehenderit odio quaerat itaque libero. Dolor sint et corporis repellat tempora. Voluptates id voluptate assumenda commodi omnis. Sit nulla explicabo et et id." },
                    { 25, 48, 119, "Accusantium voluptatem sint quae et. Enim libero veniam mollitia praesentium incidunt qui fugiat. Sit reprehenderit minus. Quos sed est adipisci nihil unde perspiciatis nisi. Architecto recusandae ad nemo accusamus quia.\n\nNemo quam veniam inventore dolores aspernatur vitae neque earum. Nihil voluptatem possimus soluta ut qui aut nesciunt quia. Tenetur numquam et vitae sit. Mollitia aliquid quia sequi commodi ut iste velit officiis.\n\nLaborum ea sit facilis aperiam omnis. Voluptas vitae cumque reprehenderit officia qui quas quo delectus. Saepe sunt et sed qui voluptatem quas qui voluptas temporibus. Id nihil natus aut autem alias. Quibusdam consectetur distinctio et. Id et magnam fugit quia voluptas.\n\nEt alias qui nemo repellendus ab dolore rerum. Sint repudiandae consectetur. Laboriosam aut autem qui qui non qui enim repudiandae est. Ut rerum sit sapiente voluptatum." }
                });

            migrationBuilder.InsertData(
                table: "BookingMessages",
                columns: new[] { "Id", "ClientId", "PetsitterId", "Text" },
                values: new object[,]
                {
                    { 26, 30, 121, "Eos est minus quia aliquam. Quia possimus nemo. Cum placeat qui deleniti qui eos debitis aut dolorum. Cum laboriosam quod incidunt enim suscipit ratione. Quis voluptate fugiat numquam rerum pariatur fugiat similique quis. Necessitatibus natus necessitatibus et alias.\n\nError labore nesciunt. Qui animi incidunt cum esse nam quibusdam doloremque quas. Sint debitis blanditiis totam ut molestiae praesentium et aut.\n\nAssumenda fuga dicta inventore distinctio laborum laboriosam officia magni. Explicabo maiores vitae laudantium consequatur id sed provident. Aperiam sed et in. Nobis iusto mollitia aut tempora rerum voluptas ea molestias a. Aut ratione dolorum.\n\nPraesentium dignissimos autem. Dolorem necessitatibus quis consequatur. Quia et ut. Laborum nostrum ut modi fugit autem tempora sit. Ea corrupti earum minus. Consequuntur velit fugiat blanditiis sint omnis." },
                    { 27, 58, 114, "Aliquam qui autem veritatis deserunt consequatur. Porro dolores libero eveniet nam voluptatem facere doloremque et non. Eius vitae rerum.\n\nVelit dolore deserunt. Et consequatur quos iste aperiam. Velit ut ut culpa.\n\nIncidunt qui est dignissimos et culpa. Voluptatem vitae nihil tempore magnam odit. Aut id ab illo vel.\n\nPlaceat ipsa quo consequatur aut eos laudantium id dolor veritatis. Consequatur id maiores et fugit omnis voluptatem fugiat. Sit dolor odio sit labore qui cum consectetur aut. Sint sed nisi molestiae atque velit inventore iusto a porro. Cupiditate ullam commodi perferendis aut et quis vel quos quis. Unde aperiam libero." },
                    { 32, 93, 197, "Veniam soluta nemo consequatur neque. Voluptatem quisquam natus illum delectus. Id qui est nisi quam sit eum. Dolorum odit ea est ut asperiores et eum deleniti. Exercitationem aliquam ipsa voluptatem eligendi esse. Aut et earum rerum ut itaque commodi.\n\nMollitia qui quo labore similique rerum sunt. Nihil dolor minima. Totam dolorem laboriosam itaque labore et cupiditate. Occaecati laboriosam possimus adipisci possimus ducimus ea necessitatibus. Eum ipsum eaque illo hic qui laboriosam libero et et.\n\nDoloremque natus sint eos. Quas ducimus id. Asperiores accusamus voluptas a et aliquam eum occaecati atque quia. Sed ipsa voluptatem consequatur labore provident sint.\n\nUt repellat qui ipsum omnis quos dolor labore inventore facere. A veniam voluptatem reprehenderit corporis velit aspernatur rerum qui excepturi. Possimus et consequatur a. Labore molestias eveniet rem maiores cum id soluta repellat est. Ea sunt rem officia laudantium minus sit qui. Sit non nihil eaque iusto harum et corrupti sed labore." },
                    { 23, 65, 126, "Et dicta consequuntur facilis fuga. Unde incidunt sed quidem. Expedita qui labore aut natus. Qui voluptatum omnis optio eligendi quam. Voluptatibus enim officia eveniet quisquam asperiores. Dicta consequatur ut deserunt eius modi ex et dolores.\n\nInventore animi repudiandae ducimus ipsam. Voluptatem aspernatur incidunt et ipsum odit et odit. Est nam ex fuga est molestias non qui. Pariatur eum est autem.\n\nVoluptatem reiciendis ea. Quidem qui corrupti provident tenetur. In dolorum omnis rerum sint cumque quis atque omnis. Eligendi necessitatibus officiis facere pariatur nulla.\n\nAnimi corrupti beatae cupiditate omnis dolores quo adipisci. Minima rem pariatur ut dolores ea possimus architecto. Qui officiis exercitationem ratione perspiciatis neque et nulla voluptate voluptatem. Est corrupti autem. Temporibus recusandae laudantium. Illo eos fuga ut est tenetur consequatur perferendis nihil." },
                    { 35, 24, 198, "Rerum deserunt ipsam. Id et odio. Quia laboriosam ratione. Nemo dolore veritatis eveniet nam a beatae ut. Laborum excepturi autem optio corporis nostrum adipisci consequatur.\n\nQui cumque vero reprehenderit occaecati. Aut deleniti nihil excepturi vel quia laborum. Ut nihil a fugiat.\n\nSit nesciunt ut ducimus suscipit vitae cupiditate enim. Et dolore rerum ipsa ut facere. Qui at ut. Dolor voluptatum et facere veniam. Eveniet qui est mollitia suscipit ea. Totam aliquid labore iusto voluptate inventore odio.\n\nQuae autem ut quod dolorem facilis blanditiis. Aliquam aut exercitationem rem repudiandae ut quas excepturi neque non. Earum officia quo exercitationem." },
                    { 43, 21, 125, "Ad illum deleniti consequatur. Nemo eius in. Minima nisi ipsam sint magni reprehenderit voluptas.\n\nNemo doloribus reiciendis alias eligendi et necessitatibus. Sed eveniet eos. Dolore repellat ut facilis rerum. Quam quidem repellat eveniet maiores assumenda omnis facilis sequi labore. Fuga et voluptas repellendus.\n\nDicta neque enim consequuntur labore fugit architecto odit quia ut. Aperiam nisi est enim corrupti. Quam maiores sint velit alias non labore. Sunt et dolorem. Qui provident excepturi excepturi explicabo blanditiis atque.\n\nSit occaecati molestiae temporibus nam tempora quas laborum consequatur. Earum dolores asperiores et et eius. Vitae hic doloremque vitae ratione laudantium. Non molestiae consequatur maxime." },
                    { 38, 93, 101, "Nesciunt adipisci aut est quis laboriosam ipsum asperiores autem deserunt. Tempora et laborum illo natus sed ducimus aut. Dolore quo cumque officiis quo iusto quidem sint. Qui repellat rerum est consequatur assumenda.\n\nEt molestiae est nesciunt dolorem laboriosam repellendus delectus. Quia et accusamus repellat quas iste. Facilis est voluptatem quos aut necessitatibus at nihil aliquam. Laboriosam mollitia quisquam et autem nulla nihil. Ea sit velit in quam et sint et molestiae.\n\nQuae voluptatum hic odio. Vitae voluptatem ducimus eos. Voluptates in maiores et corporis repellat consectetur dolore.\n\nEt ducimus ipsum aspernatur sed voluptate. Ut qui in. Laudantium et similique quia. Reprehenderit sequi mollitia. Voluptatum qui veniam adipisci quos odio. Tempore sed et qui distinctio occaecati." },
                    { 40, 12, 200, "Voluptas velit dolorum rerum. Autem mollitia amet praesentium et fugit voluptas. Et corporis asperiores accusantium et. Doloremque et veniam perspiciatis itaque. Dolore quis sapiente officia magni quia quis.\n\nAutem culpa ut in. Atque itaque quia modi a incidunt. Natus laborum facilis. Impedit error omnis est delectus. Expedita soluta nostrum ipsam dicta harum.\n\nPlaceat eum ratione fugit magnam. Sunt qui maiores officiis sunt quasi veritatis officia. Non est cum ipsam modi nihil est cupiditate. Enim eveniet et modi veniam dolores qui nemo in saepe. Ea et ducimus commodi.\n\nAliquam culpa necessitatibus natus saepe. Quasi reiciendis voluptas fuga velit ipsam. Voluptates qui corporis quia nulla. Quibusdam accusamus ipsum at deleniti. Quos dolorem vel ullam est et ipsam reprehenderit hic. Doloremque quidem voluptate autem." }
                });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 187, 20.0, 65 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 102, 49.0, 79 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 137, 42.0, 75 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 156, 27.0, 82 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 129, 34.0, 95 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 177, 20.0, 61 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 152, 43.0, 96 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 169, 39.0, 20 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 122, 37.0, 97 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 151, 31.0, 55 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 193, 38.0, 91 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 186, 27.0, 92 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 193, 13.0, 92 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 118, 11.0, 36 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 173, 42.0, 61 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 122, 33.0, 78 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 119, 20.0, 51 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 183, 25.0, 92 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 141, 28.0, 18 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 155, 43.0, 81 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 129, 18.0, 87 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 128, 46.0, 64 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 172, 11.0, 44 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 118, 37.0, 84 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 120, 34.0, 34 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 181, 34.0, 96 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 192, 17.0, 1 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 110, 12.0, 32 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 127, 50.0, 10 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 132, 40.0, 46 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 197, 15.0, 38 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 124, 30.0, 90 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 182, 49.0, 46 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 189, 24.0, 50 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 156, 36.0, 1 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 157, 33.0, 64 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 180, 19.0, 61 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 186, 42.0, 63 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 165, 32.0, 20 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 116, 32.0, 1 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 192, 49.0, 41 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 129, 28.0, 21 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 157, 28.0, 96 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 110, 30.0, 100 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 163, 30.0, 4 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 184, 22.0, 55 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 47,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 139, 28.0, 71 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 142, 44.0, 52 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 49,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 153, 40.0, 12 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 50,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 132, 38.0, 60 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 51,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 195, 28.0, 66 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 52,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 143, 14.0, 98 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 53,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 138, 42.0, 27 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 54,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 120, 38.0, 100 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 55,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 113, 34.0, 71 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 56,
                columns: new[] { "PetsitterId", "Price" },
                values: new object[] { 171, 34.0 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 57,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 130, 36.0, 82 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 58,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 124, 22.0, 78 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 59,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 109, 45.0, 51 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 60,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 113, 14.0, 77 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 61,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 172, 24.0, 26 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 62,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 176, 23.0, 15 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 63,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 107, 12.0, 20 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 64,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 142, 21.0, 47 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 65,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 151, 38.0, 19 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 66,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 177, 43.0, 30 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 67,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 125, 45.0, 83 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 68,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 116, 41.0, 3 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 69,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 106, 45.0, 72 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 70,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 114, 29.0, 35 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 71,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 122, 30.0, 26 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 72,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 171, 40.0, 49 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 73,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 134, 32.0, 38 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 74,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 128, 12.0, 64 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 75,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 154, 24.0, 89 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 76,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 137, 34.0, 73 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 77,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 160, 18.0, 32 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 78,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 107, 48.0, 88 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 79,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 122, 19.0, 56 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 80,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 158, 27.0, 70 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 81,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 147, 44.0, 94 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 82,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 159, 19.0, 20 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 83,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 179, 38.0, 80 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 84,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 197, 47.0, 44 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 85,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 127, 17.0, 98 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 86,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 184, 16.0, 63 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 87,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 144, 49.0, 70 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 88,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 129, 11.0, 54 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 89,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 127, 25.0, 16 });

            migrationBuilder.UpdateData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 90,
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 156, 47.0, 49 });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 158, 118, 27.0, 85 },
                    { 140, 118, 23.0, 71 },
                    { 125, 174, 47.0, 96 },
                    { 218, 105, 30.0, 26 },
                    { 216, 192, 36.0, 95 },
                    { 299, 176, 18.0, 72 },
                    { 212, 112, 23.0, 95 },
                    { 126, 170, 30.0, 74 },
                    { 93, 120, 37.0, 95 },
                    { 254, 166, 41.0, 94 },
                    { 182, 141, 48.0, 74 },
                    { 248, 141, 35.0, 74 },
                    { 127, 135, 42.0, 75 },
                    { 136, 156, 38.0, 75 },
                    { 179, 138, 33.0, 94 },
                    { 223, 124, 14.0, 93 },
                    { 130, 127, 48.0, 95 },
                    { 146, 197, 35.0, 96 },
                    { 217, 163, 26.0, 96 },
                    { 160, 192, 43.0, 75 },
                    { 155, 190, 30.0, 100 },
                    { 231, 189, 38.0, 64 },
                    { 137, 144, 35.0, 100 },
                    { 194, 132, 49.0, 98 },
                    { 152, 182, 26.0, 98 },
                    { 201, 137, 41.0, 65 },
                    { 281, 192, 46.0, 65 },
                    { 174, 101, 50.0, 6 }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 181, 133, 49.0, 97 },
                    { 203, 170, 41.0, 70 },
                    { 107, 116, 24.0, 97 },
                    { 270, 176, 41.0, 67 },
                    { 110, 167, 35.0, 68 },
                    { 192, 193, 13.0, 68 },
                    { 234, 138, 11.0, 68 },
                    { 205, 104, 27.0, 5 },
                    { 266, 143, 35.0, 68 },
                    { 198, 199, 12.0, 69 },
                    { 256, 156, 30.0, 96 },
                    { 154, 194, 17.0, 70 },
                    { 118, 149, 24.0, 67 },
                    { 193, 103, 33.0, 75 },
                    { 240, 105, 30.0, 6 },
                    { 145, 138, 32.0, 85 },
                    { 168, 154, 35.0, 91 },
                    { 150, 137, 44.0, 91 },
                    { 141, 153, 45.0, 80 },
                    { 209, 199, 40.0, 64 },
                    { 98, 109, 10.0, 14 },
                    { 92, 113, 38.0, 82 },
                    { 123, 106, 10.0, 82 },
                    { 295, 142, 15.0, 82 },
                    { 277, 130, 47.0, 88 },
                    { 108, 148, 14.0, 80 },
                    { 264, 108, 49.0, 17 },
                    { 148, 102, 48.0, 83 },
                    { 275, 153, 34.0, 86 },
                    { 129, 183, 39.0, 84 },
                    { 238, 148, 23.0, 86 },
                    { 142, 107, 11.0, 84 },
                    { 176, 115, 28.0, 84 },
                    { 207, 143, 40.0, 86 },
                    { 138, 192, 11.0, 86 },
                    { 228, 112, 24.0, 84 },
                    { 183, 117, 47.0, 87 },
                    { 96, 130, 46.0, 80 },
                    { 258, 111, 38.0, 20 },
                    { 269, 192, 18.0, 79 },
                    { 202, 140, 10.0, 75 },
                    { 298, 199, 20.0, 75 }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 164, 116, 17.0, 1 },
                    { 91, 152, 37.0, 76 },
                    { 120, 121, 11.0, 76 },
                    { 261, 105, 14.0, 2 },
                    { 257, 194, 32.0, 76 },
                    { 279, 132, 33.0, 76 },
                    { 284, 149, 27.0, 76 },
                    { 289, 185, 14.0, 76 },
                    { 128, 179, 21.0, 77 },
                    { 153, 196, 22.0, 77 },
                    { 286, 108, 33.0, 77 },
                    { 189, 106, 34.0, 28 },
                    { 162, 197, 30.0, 78 },
                    { 294, 106, 42.0, 3 },
                    { 219, 171, 28.0, 78 },
                    { 222, 172, 14.0, 78 },
                    { 237, 117, 27.0, 78 },
                    { 132, 115, 29.0, 14 },
                    { 197, 133, 32.0, 91 },
                    { 173, 149, 18.0, 93 },
                    { 116, 126, 43.0, 64 },
                    { 94, 114, 47.0, 58 },
                    { 95, 191, 45.0, 64 },
                    { 101, 184, 22.0, 23 },
                    { 135, 184, 48.0, 14 },
                    { 236, 132, 38.0, 9 },
                    { 260, 189, 41.0, 19 },
                    { 166, 193, 43.0, 13 },
                    { 242, 194, 43.0, 20 },
                    { 265, 194, 26.0, 20 },
                    { 297, 195, 50.0, 25 },
                    { 221, 126, 26.0, 24 },
                    { 139, 125, 42.0, 28 },
                    { 103, 125, 17.0, 15 },
                    { 215, 123, 29.0, 23 },
                    { 105, 146, 15.0, 31 },
                    { 175, 116, 21.0, 31 },
                    { 177, 187, 26.0, 31 },
                    { 243, 139, 48.0, 32 },
                    { 293, 150, 30.0, 32 },
                    { 100, 182, 12.0, 33 },
                    { 287, 189, 35.0, 33 }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 200, 168, 28.0, 35 },
                    { 211, 133, 26.0, 35 },
                    { 241, 101, 31.0, 35 },
                    { 247, 186, 18.0, 35 },
                    { 282, 121, 32.0, 35 },
                    { 119, 170, 27.0, 36 },
                    { 149, 133, 32.0, 1 },
                    { 147, 134, 14.0, 28 },
                    { 267, 135, 28.0, 20 },
                    { 255, 174, 21.0, 11 },
                    { 134, 151, 43.0, 20 },
                    { 296, 150, 25.0, 29 },
                    { 122, 154, 20.0, 16 },
                    { 262, 149, 14.0, 17 },
                    { 210, 147, 13.0, 30 },
                    { 157, 147, 23.0, 28 },
                    { 292, 157, 31.0, 28 },
                    { 208, 159, 18.0, 20 },
                    { 276, 159, 50.0, 17 },
                    { 167, 146, 28.0, 24 },
                    { 99, 145, 26.0, 19 },
                    { 290, 144, 44.0, 26 },
                    { 245, 153, 26.0, 36 },
                    { 171, 143, 11.0, 5 },
                    { 112, 165, 24.0, 30 },
                    { 239, 142, 26.0, 14 },
                    { 151, 167, 30.0, 2 },
                    { 229, 167, 14.0, 29 },
                    { 206, 168, 38.0, 21 },
                    { 273, 168, 48.0, 25 },
                    { 285, 169, 11.0, 17 },
                    { 250, 138, 29.0, 23 },
                    { 291, 136, 37.0, 5 },
                    { 188, 172, 21.0, 21 },
                    { 227, 173, 38.0, 8 },
                    { 115, 174, 40.0, 29 },
                    { 113, 163, 17.0, 14 },
                    { 300, 111, 34.0, 36 },
                    { 226, 193, 49.0, 37 },
                    { 283, 156, 33.0, 37 },
                    { 144, 145, 31.0, 51 },
                    { 233, 144, 28.0, 51 }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 213, 122, 40.0, 12 },
                    { 159, 123, 49.0, 52 },
                    { 214, 186, 43.0, 52 },
                    { 196, 121, 10.0, 53 },
                    { 278, 198, 49.0, 54 },
                    { 156, 109, 11.0, 55 },
                    { 235, 154, 30.0, 55 },
                    { 133, 120, 15.0, 21 },
                    { 163, 104, 45.0, 56 },
                    { 225, 196, 23.0, 57 },
                    { 244, 106, 44.0, 50 },
                    { 263, 140, 49.0, 57 },
                    { 246, 167, 22.0, 58 },
                    { 280, 163, 25.0, 58 },
                    { 143, 187, 43.0, 59 },
                    { 170, 107, 28.0, 59 },
                    { 259, 130, 34.0, 60 },
                    { 199, 164, 40.0, 61 },
                    { 232, 165, 21.0, 61 },
                    { 253, 151, 24.0, 61 },
                    { 114, 120, 36.0, 6 },
                    { 274, 119, 26.0, 16 },
                    { 272, 158, 47.0, 62 },
                    { 271, 173, 27.0, 63 },
                    { 121, 107, 29.0, 58 },
                    { 104, 148, 37.0, 64 },
                    { 195, 152, 44.0, 50 },
                    { 161, 147, 37.0, 50 },
                    { 252, 197, 23.0, 38 },
                    { 97, 177, 47.0, 39 },
                    { 106, 106, 46.0, 39 },
                    { 111, 132, 35.0, 39 },
                    { 117, 190, 42.0, 39 },
                    { 186, 147, 34.0, 39 },
                    { 251, 189, 28.0, 39 },
                    { 165, 134, 33.0, 40 },
                    { 187, 137, 36.0, 40 },
                    { 230, 190, 17.0, 41 },
                    { 131, 193, 25.0, 42 },
                    { 220, 158, 14.0, 42 },
                    { 169, 154, 17.0, 50 },
                    { 249, 176, 41.0, 42 }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 180, 105, 21.0, 43 },
                    { 124, 177, 20.0, 44 },
                    { 191, 162, 30.0, 44 },
                    { 204, 110, 35.0, 44 },
                    { 268, 129, 29.0, 44 },
                    { 184, 137, 18.0, 45 },
                    { 102, 177, 37.0, 46 },
                    { 178, 115, 30.0, 46 },
                    { 185, 163, 17.0, 46 },
                    { 288, 120, 42.0, 46 },
                    { 172, 148, 18.0, 47 },
                    { 224, 108, 13.0, 47 },
                    { 109, 101, 35.0, 43 },
                    { 190, 152, 31.0, 10 }
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
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 155);

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
                keyValue: 175);

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
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 34);

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
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 81);

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
                keyValue: 99);

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
                keyValue: 98);

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
                keyValue: 105);

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
                keyValue: 108);

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
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 116);

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
                keyValue: 124);

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
                keyValue: 132);

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
                keyValue: 143);

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
                keyValue: 170);

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
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 174);

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
                keyValue: 185);

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
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 191);

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
                keyValue: 55);

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
                keyValue: 61);

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
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 75);

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
                keyValue: 80);

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
                keyValue: 84);

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
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 91);

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
                keyValue: 100);

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
                columns: new[] { "PetsitterId", "Price", "ServiceId" },
                values: new object[] { 41, 81.0, 1 });

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
                columns: new[] { "PetsitterId", "Price" },
                values: new object[] { 56, 141.0 });

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
