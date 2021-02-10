using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Petsupport.API2.Migrations
{
    public partial class AzureUpdate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "AzureId",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AlterColumn<string>(
                name: "AzureId",
                table: "Clients",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "AzureId",
                value: "7f60d5c6-bf45-4715-81fc-68a1754ba739");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "AzureId",
                value: "150d3599-3dce-4303-a9fd-934bc65f040d");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "AzureId",
                value: "c87e1a31-9805-4602-aff6-87cbfda6faab");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "AzureId",
                value: "46da5d28-1a6b-4d90-92e4-53bd3b738de5");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "AzureId",
                value: "61500ca3-37d7-47b2-a9b1-7ca616a6c2a7");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                column: "AzureId",
                value: "a813db8e-81b5-470b-b934-6f9f03a31129");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                column: "AzureId",
                value: "c74fa0ea-3e5c-409c-a1d6-08c181ff01d7");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                column: "AzureId",
                value: "d8f74fcb-4087-4551-9200-4ecd712b291b");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                column: "AzureId",
                value: "fce3f1c1-48b0-4b98-8a90-7cc6d1407596");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                column: "AzureId",
                value: "05c6436d-ae4b-48c7-bd81-e219a0caebba");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11,
                column: "AzureId",
                value: "6527a3a7-463d-4d63-b994-179410555541");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12,
                column: "AzureId",
                value: "13197074-e9cd-47e1-9570-cf6ea6778387");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13,
                column: "AzureId",
                value: "8d2a9810-de13-4ce7-87ac-142dbc583304");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14,
                column: "AzureId",
                value: "34f0fef2-041e-44a5-9389-9b031ff4b6b8");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15,
                column: "AzureId",
                value: "b81004fd-b751-4121-91be-75d89b8488f8");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 16,
                column: "AzureId",
                value: "b937d87e-677f-4e29-9044-ebddc9e86634");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 17,
                column: "AzureId",
                value: "4aeb7352-eb76-4e4a-ad3d-b128b7954a67");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 18,
                column: "AzureId",
                value: "32477ea6-ee5a-4076-8baf-be3d1ebab9b5");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 19,
                column: "AzureId",
                value: "3a007ba8-ce3c-4af8-acd6-4b3d398153aa");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 20,
                column: "AzureId",
                value: "0e5ba934-04a0-407d-b495-0c418b73034c");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 21,
                column: "AzureId",
                value: "42fdd414-972d-4578-97e8-6e0e71d76213");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 22,
                column: "AzureId",
                value: "0f156cd7-39e6-43c9-9cc4-99cacdfca043");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 23,
                column: "AzureId",
                value: "67965cd9-f668-47ee-8b1a-dca9284709d6");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 24,
                column: "AzureId",
                value: "a0092aa7-97d7-40ac-ba57-96e51d9490ff");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 25,
                column: "AzureId",
                value: "62c30cb5-4fa7-4687-bca4-7d0efb11d06c");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 26,
                column: "AzureId",
                value: "c4b4c838-5f32-4635-a176-fa987b22f39f");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 27,
                column: "AzureId",
                value: "46baa46e-c38c-4f1e-9572-35cd46f14c50");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 28,
                column: "AzureId",
                value: "fabfe1de-f510-48dd-ab21-c97d65120388");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 29,
                column: "AzureId",
                value: "51f84ed1-9078-4586-b184-cb5638f15a46");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 30,
                column: "AzureId",
                value: "5b76989d-2bbd-42f4-b4ef-ec59b79bad5b");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 31,
                column: "AzureId",
                value: "990ca61a-1850-4f0d-84c8-797a337a594c");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 32,
                column: "AzureId",
                value: "7c00d47e-46b9-439d-b914-b5da14ccca10");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 33,
                column: "AzureId",
                value: "bb5a9e8a-f306-45af-a57a-0ea5d0460048");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 34,
                column: "AzureId",
                value: "929e0338-11de-41bf-a172-d871d05c47ce");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 35,
                column: "AzureId",
                value: "f3c6d271-c478-4569-afc4-1d24dfb7b6b1");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 36,
                column: "AzureId",
                value: "b51fdbed-64e9-485f-9950-e3c8aef7cb94");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 37,
                column: "AzureId",
                value: "5222ec2e-d95d-4fd7-ae59-dda9aceb8dc4");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 38,
                column: "AzureId",
                value: "2dd6ba25-553f-4929-9345-5d1c22737673");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 39,
                column: "AzureId",
                value: "32a658f2-8318-4d5d-8665-37dd8fccff93");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 40,
                column: "AzureId",
                value: "b1f46676-04a0-430d-b7e6-e44313d1cb7d");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 41,
                column: "AzureId",
                value: "50b5d0bc-78d5-4df6-a1ac-229b7848540c");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 42,
                column: "AzureId",
                value: "19a604d0-8e57-4e90-a550-9c6b21751211");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 43,
                column: "AzureId",
                value: "ec99c166-469f-4700-bbaa-59977e44301c");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 44,
                column: "AzureId",
                value: "9c107d52-d090-4e28-a780-30b7e07f98c2");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 45,
                column: "AzureId",
                value: "14dfa5e5-5181-4ac5-ac38-c42e7f2218ac");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 46,
                column: "AzureId",
                value: "344a9cd7-91de-4f01-b99e-bc249e0f2b97");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 47,
                column: "AzureId",
                value: "89f90296-b95c-4473-af94-3c8f273042eb");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 48,
                column: "AzureId",
                value: "e92f3563-e713-4f74-af06-379a137ea612");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 49,
                column: "AzureId",
                value: "497f4dff-5532-47fe-9154-f4e3c07a4d5a");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 50,
                column: "AzureId",
                value: "b70014be-b09f-4993-9cfe-683d6b52f73a");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 51,
                column: "AzureId",
                value: "4377b8f7-2577-48d9-a6e4-310c03472232");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 52,
                column: "AzureId",
                value: "cb65d013-fb60-4568-9bbb-5a3c2efe24c9");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 53,
                column: "AzureId",
                value: "76d8a3d8-03a3-4daa-bb88-a030aeee1844");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 54,
                column: "AzureId",
                value: "f9571736-5585-4f67-8894-fa65eb48fcfa");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 55,
                column: "AzureId",
                value: "de67c9fd-4aef-4aa7-8ed3-e64e1dbf547b");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 56,
                column: "AzureId",
                value: "c7882141-b320-42f3-85cf-9dd17e2398c4");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 57,
                column: "AzureId",
                value: "acce5d41-fbd7-447f-a952-9d168993a372");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 58,
                column: "AzureId",
                value: "1746e29c-da2d-4017-8429-11239cfbd907");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 59,
                column: "AzureId",
                value: "8507029b-1baa-44ea-824a-3f7cc20787fc");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 60,
                column: "AzureId",
                value: "bec859c9-dadd-46eb-8364-0ca38e294a20");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 61,
                column: "AzureId",
                value: "66065102-ef19-4363-9f62-b42de6cb7ef3");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 62,
                column: "AzureId",
                value: "4bdd535f-d101-4917-8c0e-9df0eb549653");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 63,
                column: "AzureId",
                value: "550f0d89-10bd-4ac7-ac39-0847b13bce1b");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 64,
                column: "AzureId",
                value: "4b049353-5602-49a1-80cd-0f7e65460d97");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 65,
                column: "AzureId",
                value: "f3ffa8d5-7cec-4f94-af06-b0b6adeb1089");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 66,
                column: "AzureId",
                value: "4743cf8e-d7ec-4206-8323-2a9d1c52b76d");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 67,
                column: "AzureId",
                value: "6aa10f9c-fb79-4e53-8d5a-7d0afb036d41");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 68,
                column: "AzureId",
                value: "61d84844-81df-49b3-a36c-a91fe55cd7e0");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 69,
                column: "AzureId",
                value: "04c21167-6ea2-4ef2-befd-fa207b4b29ab");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 70,
                column: "AzureId",
                value: "c2d1216d-454b-469e-838c-20f39b3b6044");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 71,
                column: "AzureId",
                value: "b6268111-592d-4c96-99c4-0fca9eead8be");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 72,
                column: "AzureId",
                value: "9ddecd26-3e18-4245-9fd6-a0f875eeb3db");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 73,
                column: "AzureId",
                value: "bc4bafd0-9ed1-48f6-9869-a9a6ac63ae25");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 74,
                column: "AzureId",
                value: "06da37ad-5f89-4da5-ade6-ba9301c10699");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 75,
                column: "AzureId",
                value: "902d80bc-7aba-4667-8358-fa6084e940b1");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 76,
                column: "AzureId",
                value: "840d2fe9-e65d-44e8-9407-333b2b71eca2");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 77,
                column: "AzureId",
                value: "74788e04-6483-4b49-89f0-452d7e445271");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 78,
                column: "AzureId",
                value: "e22aee9a-a3c5-45bd-bf65-5ad898bafd79");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 79,
                column: "AzureId",
                value: "cfcc733b-651d-4d2b-af6c-a54bd10d5f1f");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 80,
                column: "AzureId",
                value: "98a2210c-ff17-4633-a77b-15e01faf7a83");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 81,
                column: "AzureId",
                value: "d1738c13-4d47-430d-895e-5460ec06b17e");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 82,
                column: "AzureId",
                value: "19295127-3d9b-4954-ab01-3bb4d8539e6d");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 83,
                column: "AzureId",
                value: "d07b7c8a-7baa-400e-8a60-c4f83a7cce9b");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 84,
                column: "AzureId",
                value: "3a938726-a365-4618-8fe1-8c54ce9e774a");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 85,
                column: "AzureId",
                value: "95dd669d-2ddb-498f-a79b-cf4eaf52422a");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 86,
                column: "AzureId",
                value: "2f2021bd-4be7-4961-af9f-dd2a8559a083");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 87,
                column: "AzureId",
                value: "c8b49d9e-b149-43de-9982-9df777320051");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 88,
                column: "AzureId",
                value: "40ed76fa-0f4a-4786-8e02-ddabee304d70");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 89,
                column: "AzureId",
                value: "6b91034e-9704-4179-bd83-1552b99ae29a");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 90,
                column: "AzureId",
                value: "dcf67f3a-2f0a-4e34-8ba5-a4f80bc37ad8");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 91,
                column: "AzureId",
                value: "526bbe0f-aeac-4d7d-85d3-c02a5f37e80a");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 92,
                column: "AzureId",
                value: "506796d8-4c63-4d67-b74f-1ddd520368af");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 93,
                column: "AzureId",
                value: "b5302732-fad1-43a1-8278-bad9d7253928");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 94,
                column: "AzureId",
                value: "b9942c71-b8f4-45fc-9df9-113ca1910b52");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 95,
                column: "AzureId",
                value: "07e3403d-96ea-49e8-bdca-2138b014d7ac");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 96,
                column: "AzureId",
                value: "b24a0f21-cc81-4b48-9d81-984936053fda");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 97,
                column: "AzureId",
                value: "212c23f4-7d7f-4f81-b12a-de480aa19336");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 98,
                column: "AzureId",
                value: "784255e3-ba88-4106-a3bb-3b29ce96bb6c");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 99,
                column: "AzureId",
                value: "a664b301-c977-48f8-a2af-c106a5b41778");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 100,
                column: "AzureId",
                value: "e979cbe6-c85a-4627-8d56-cc222d9acfa8");

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 49, 31, 295, DateTimeKind.Local).AddTicks(9412), new DateTime(2022, 1, 28, 14, 30, 11, 87, DateTimeKind.Local).AddTicks(246), "572f6e43-a96c-40a4-8914-6c1b3594e208" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 28, 39, 709, DateTimeKind.Local).AddTicks(8606), new DateTime(2021, 7, 10, 13, 43, 12, 452, DateTimeKind.Local).AddTicks(7870), "6ba93bb2-9102-496c-955c-c20fe38bb631" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 53, 36, 115, DateTimeKind.Local).AddTicks(3469), new DateTime(2021, 10, 25, 10, 10, 53, 589, DateTimeKind.Local).AddTicks(850), "dbb14f55-4de2-4427-a107-6a5fba2bfca2" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 6, 12, 944, DateTimeKind.Local).AddTicks(9511), new DateTime(2022, 1, 29, 3, 44, 13, 963, DateTimeKind.Local).AddTicks(5608), "f4f69500-5365-44e5-b713-0b7ad459c68a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 55, 17, 736, DateTimeKind.Local).AddTicks(4715), new DateTime(2022, 1, 10, 7, 10, 38, 579, DateTimeKind.Local).AddTicks(1517), "9e9d372e-3270-4d20-b5cf-0a3d07ddf607" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 20, 40, 450, DateTimeKind.Local).AddTicks(6121), new DateTime(2021, 5, 11, 14, 15, 59, 602, DateTimeKind.Local).AddTicks(6985), "7c71cc33-d5b0-45fa-8eaf-e2bc666a82cf" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 37, 15, 492, DateTimeKind.Local).AddTicks(7020), new DateTime(2021, 4, 5, 9, 39, 51, 957, DateTimeKind.Local).AddTicks(328), "10c33725-57aa-4cd1-b3a1-2e25cf926c15" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 13, 48, 234, DateTimeKind.Local).AddTicks(1713), new DateTime(2021, 8, 6, 21, 41, 39, 86, DateTimeKind.Local).AddTicks(8906), "57aa34bc-bd63-42c2-bb7f-afe6c6e929e6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 49, 53, 947, DateTimeKind.Local).AddTicks(4515), new DateTime(2021, 6, 10, 20, 54, 23, 849, DateTimeKind.Local).AddTicks(8229), "2d761179-a6cd-4e3a-aef5-54d9b3440d38" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 24, 41, 306, DateTimeKind.Local).AddTicks(8131), new DateTime(2021, 6, 5, 19, 20, 27, 567, DateTimeKind.Local).AddTicks(269), "e3edbdf0-0ebb-43ac-9136-027b3577a8fa" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 36, 22, 980, DateTimeKind.Local).AddTicks(4255), new DateTime(2022, 1, 10, 10, 28, 36, 942, DateTimeKind.Local).AddTicks(4327), "95a0a243-8b50-41a5-ab3c-f84637dbe3da" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 18, 31, 634, DateTimeKind.Local).AddTicks(4610), new DateTime(2021, 11, 20, 14, 59, 19, 639, DateTimeKind.Local).AddTicks(4298), "10c8b578-b542-4527-a7b3-2d5007a592a1" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 44, 47, 311, DateTimeKind.Local).AddTicks(5445), new DateTime(2021, 3, 11, 5, 17, 13, 428, DateTimeKind.Local).AddTicks(3092), "1ad7b8dd-84f9-44e2-b8c8-32c0c77076fd" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 36, 32, 222, DateTimeKind.Local).AddTicks(306), new DateTime(2021, 8, 18, 10, 36, 8, 306, DateTimeKind.Local).AddTicks(5124), "93508c2b-7d6a-4a43-9e63-432a5aeba73e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 9, 19, 168, DateTimeKind.Local).AddTicks(5201), new DateTime(2021, 9, 21, 15, 48, 36, 185, DateTimeKind.Local).AddTicks(3229), "1ff1ee8b-9441-4b77-8216-e332d1fe7139" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 22, 0, 16, DateTimeKind.Local).AddTicks(1526), new DateTime(2021, 12, 17, 22, 22, 13, 779, DateTimeKind.Local).AddTicks(7267), "e2116291-42f2-4a9f-9f46-705d9205ad22" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 40, 12, 607, DateTimeKind.Local).AddTicks(249), new DateTime(2021, 5, 17, 11, 34, 47, 813, DateTimeKind.Local).AddTicks(7598), "30cb17d1-a52d-4b78-8214-87000344bfcf" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 17, 1, 780, DateTimeKind.Local).AddTicks(9823), new DateTime(2021, 12, 29, 18, 24, 33, 186, DateTimeKind.Local).AddTicks(5451), "0360d7cf-ff90-4e2b-b10d-6cea510e3334" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 15, 58, 858, DateTimeKind.Local).AddTicks(7769), new DateTime(2021, 5, 3, 1, 4, 51, 564, DateTimeKind.Local).AddTicks(7593), "3eb2625a-8eb2-46bc-ba15-2c5a063a8369" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 6, 42, 228, DateTimeKind.Local).AddTicks(6645), new DateTime(2021, 12, 9, 22, 0, 12, 191, DateTimeKind.Local).AddTicks(7229), "1ab64f2f-974b-4b83-a70f-4fefc20491ce" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 20, 2, 876, DateTimeKind.Local).AddTicks(1542), new DateTime(2021, 11, 23, 11, 42, 19, 839, DateTimeKind.Local).AddTicks(5238), "41ca3147-eb1c-44a6-a879-8799e15747f1" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 42, 37, 282, DateTimeKind.Local).AddTicks(897), new DateTime(2021, 6, 12, 6, 33, 18, 879, DateTimeKind.Local).AddTicks(3495), "ef05ee6f-0e3e-422e-9319-bd791973b5ab" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 32, 10, 791, DateTimeKind.Local).AddTicks(9456), new DateTime(2021, 7, 3, 6, 22, 14, 237, DateTimeKind.Local).AddTicks(2195), "f67dc6b8-b0ec-4348-8622-a5bb1dd1b033" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 52, 32, 486, DateTimeKind.Local).AddTicks(4469), new DateTime(2021, 12, 16, 13, 11, 2, 447, DateTimeKind.Local).AddTicks(7855), "30b2ad86-77ad-4e24-ba6d-707d261db018" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 35, 30, 598, DateTimeKind.Local).AddTicks(4141), new DateTime(2021, 10, 1, 7, 54, 51, 243, DateTimeKind.Local).AddTicks(4750), "5372d432-9cff-441b-a6e4-a1bbd6815630" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 46, 0, 242, DateTimeKind.Local).AddTicks(598), new DateTime(2021, 12, 2, 12, 25, 26, 890, DateTimeKind.Local).AddTicks(9969), "94d7791c-448d-4556-8cb1-6a3c8df3da7f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 35, 55, 259, DateTimeKind.Local).AddTicks(2375), new DateTime(2021, 2, 28, 8, 47, 50, 65, DateTimeKind.Local).AddTicks(2290), "cd13bf8a-f330-41d2-8cf7-37e691960a5d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 53, 11, 237, DateTimeKind.Local).AddTicks(3470), new DateTime(2021, 3, 2, 22, 25, 57, 700, DateTimeKind.Local).AddTicks(1088), "08c21ba1-dbae-4e9c-9267-7e6c0140ceca" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 11, 16, 531, DateTimeKind.Local).AddTicks(8721), new DateTime(2021, 2, 22, 16, 41, 29, 997, DateTimeKind.Local).AddTicks(4271), "13552e44-b6b4-44b8-9ffe-ff69f5a21c5c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 43, 32, 660, DateTimeKind.Local).AddTicks(2497), new DateTime(2021, 5, 14, 20, 52, 52, 175, DateTimeKind.Local).AddTicks(1252), "755a603a-f9ba-4e6c-9c5f-541caebe3bf6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 43, 27, 873, DateTimeKind.Local).AddTicks(3408), new DateTime(2022, 2, 3, 3, 8, 42, 414, DateTimeKind.Local).AddTicks(6517), "e9bd2983-1d5d-4b66-946e-4e0d198f1817" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 11, 9, 289, DateTimeKind.Local).AddTicks(1890), new DateTime(2021, 10, 1, 4, 29, 37, 235, DateTimeKind.Local).AddTicks(7296), "35683f21-e6a8-4603-a18b-bff6c20b4292" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 55, 47, 926, DateTimeKind.Local).AddTicks(354), new DateTime(2022, 2, 6, 0, 30, 2, 163, DateTimeKind.Local).AddTicks(6817), "3060be3e-7bc4-4171-bcf4-985d302b4159" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 16, 35, 66, DateTimeKind.Local).AddTicks(8464), new DateTime(2021, 11, 26, 7, 36, 48, 130, DateTimeKind.Local).AddTicks(6468), "31dcc377-2d88-47c6-833e-a46e2dd62707" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 5, 29, 544, DateTimeKind.Local).AddTicks(2495), new DateTime(2021, 10, 21, 16, 23, 49, 328, DateTimeKind.Local).AddTicks(4477), "4792f062-45f5-429c-a229-c4f650864fc8" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 38, 37, 953, DateTimeKind.Local).AddTicks(530), new DateTime(2021, 4, 16, 9, 29, 17, 641, DateTimeKind.Local).AddTicks(5188), "455a4b87-2013-4d0f-93e6-873efb53aca6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 24, 12, 699, DateTimeKind.Local).AddTicks(6184), new DateTime(2021, 9, 21, 13, 44, 40, 41, DateTimeKind.Local).AddTicks(5180), "3f72203b-8f50-47dc-98fc-dbf7f75416a5" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 37, 51, 819, DateTimeKind.Local).AddTicks(9920), new DateTime(2022, 1, 20, 6, 7, 30, 491, DateTimeKind.Local).AddTicks(6716), "26fa511c-b989-4ce3-92ab-30f4b7242509" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 30, 25, 588, DateTimeKind.Local).AddTicks(9147), new DateTime(2021, 4, 17, 4, 12, 1, 915, DateTimeKind.Local).AddTicks(1393), "8c8abc5a-fc71-44b7-ac92-3e9fb5f28857" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 18, 52, 574, DateTimeKind.Local).AddTicks(3572), new DateTime(2021, 2, 18, 5, 45, 22, 777, DateTimeKind.Local).AddTicks(8744), "d39e2b8a-f2a0-4c17-b37f-e587b4b08686" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 59, 51, 713, DateTimeKind.Local).AddTicks(4787), new DateTime(2021, 12, 15, 11, 46, 47, 400, DateTimeKind.Local).AddTicks(4638), "b2b968ac-71ec-4c74-80b2-f0ef43106f74" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 58, 22, 766, DateTimeKind.Local).AddTicks(4303), new DateTime(2021, 6, 26, 11, 22, 12, 278, DateTimeKind.Local).AddTicks(1549), "d87c5495-15ac-4f00-b7e2-3e4650142a6f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 24, 1, 779, DateTimeKind.Local).AddTicks(8694), new DateTime(2021, 4, 26, 9, 0, 22, 461, DateTimeKind.Local).AddTicks(6666), "8fa15f95-d0d0-4278-9d99-c73f06568684" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 37, 47, 820, DateTimeKind.Local).AddTicks(283), new DateTime(2021, 3, 10, 9, 51, 23, 783, DateTimeKind.Local).AddTicks(3436), "d9f39332-0386-4e37-9726-f2e8a5fb7dc7" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 56, 32, 340, DateTimeKind.Local).AddTicks(5985), new DateTime(2021, 8, 9, 16, 58, 5, 265, DateTimeKind.Local).AddTicks(4463), "d38bfa6a-a44f-4151-a38a-211fbe68f04d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 18, 12, 586, DateTimeKind.Local).AddTicks(9339), new DateTime(2021, 10, 21, 17, 20, 22, 895, DateTimeKind.Local).AddTicks(7117), "0d0d6b5f-fca9-4a59-8002-5d7b9b1fd33c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 19, 54, 587, DateTimeKind.Local).AddTicks(8164), new DateTime(2021, 6, 30, 14, 46, 45, 694, DateTimeKind.Local).AddTicks(3499), "c6efa146-15de-4b07-aea5-b1a87c95735b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 17, 2, 237, DateTimeKind.Local).AddTicks(2604), new DateTime(2021, 4, 21, 6, 7, 18, 650, DateTimeKind.Local).AddTicks(6091), "6d930315-c554-4d39-af79-03b3b0e9237c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 4, 2, 187, DateTimeKind.Local).AddTicks(3310), new DateTime(2021, 10, 30, 21, 37, 3, 499, DateTimeKind.Local).AddTicks(248), "24981bd5-9846-4f95-a0bf-b653800c3c8b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 4, 54, 79, DateTimeKind.Local).AddTicks(8278), new DateTime(2021, 5, 31, 15, 35, 38, 18, DateTimeKind.Local).AddTicks(1885), "5c8a60f0-37ed-41bb-ae37-f1c01eee71ad" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 23, 14, 365, DateTimeKind.Local).AddTicks(5560), new DateTime(2021, 8, 18, 12, 13, 22, 514, DateTimeKind.Local).AddTicks(2342), "18f16213-26a6-449b-a6aa-f79dfbaf4d80" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 18, 4, 982, DateTimeKind.Local).AddTicks(1971), new DateTime(2021, 6, 16, 23, 38, 50, 265, DateTimeKind.Local).AddTicks(1179), "8a6f88b0-6260-4c91-80e3-1bf2f68f7c67" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 37, 10, 558, DateTimeKind.Local).AddTicks(8363), new DateTime(2021, 10, 13, 23, 32, 47, 527, DateTimeKind.Local).AddTicks(7540), "468e0f11-f621-4daf-bde6-56e409b4fc6b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 17, 25, 443, DateTimeKind.Local).AddTicks(3705), new DateTime(2021, 8, 29, 11, 31, 1, 902, DateTimeKind.Local).AddTicks(1134), "0d1246b7-5039-44a7-952a-35d0545cbe30" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 33, 7, 728, DateTimeKind.Local).AddTicks(6757), new DateTime(2021, 5, 9, 4, 28, 50, 998, DateTimeKind.Local).AddTicks(7142), "6863fa59-d45b-488b-b5d8-7a662775311c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 56, 55, 64, DateTimeKind.Local).AddTicks(5039), new DateTime(2021, 12, 16, 9, 51, 7, 99, DateTimeKind.Local).AddTicks(4760), "a19c7938-a834-414f-95a0-da0d9c3bd572" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 24, 40, 321, DateTimeKind.Local).AddTicks(5859), new DateTime(2021, 10, 7, 15, 11, 2, 645, DateTimeKind.Local).AddTicks(5820), "0471b8b0-198d-4348-aba4-a1832ff07f86" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 56, 45, 17, DateTimeKind.Local).AddTicks(9365), new DateTime(2021, 11, 18, 11, 18, 52, 375, DateTimeKind.Local).AddTicks(2293), "31520c2b-fa4a-4651-954e-04c9155b1599" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 57, 27, 443, DateTimeKind.Local).AddTicks(6421), new DateTime(2021, 11, 28, 15, 22, 29, 31, DateTimeKind.Local).AddTicks(3138), "c8d79a79-f26f-46d7-a892-a3656fc782b3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 31, 5, 797, DateTimeKind.Local).AddTicks(5666), new DateTime(2021, 9, 5, 16, 46, 36, 969, DateTimeKind.Local).AddTicks(567), "342ae448-3233-46c5-9c0f-899fea16bfd5" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 7, 16, 813, DateTimeKind.Local).AddTicks(4900), new DateTime(2021, 3, 8, 0, 1, 41, 972, DateTimeKind.Local).AddTicks(5392), "9ffeb87b-97ed-4d01-ae7e-7a6a4dc38cc1" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 6, 19, 156, DateTimeKind.Local).AddTicks(5117), new DateTime(2021, 11, 28, 20, 21, 41, 765, DateTimeKind.Local).AddTicks(8022), "6bb6564f-dda2-45e7-9741-7add7a234061" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 17, 50, 784, DateTimeKind.Local).AddTicks(8542), new DateTime(2021, 3, 26, 19, 50, 21, 923, DateTimeKind.Local).AddTicks(4788), "30a457fb-b296-4bd5-9e7c-4836f2b7f1d3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 20, 43, 401, DateTimeKind.Local).AddTicks(2284), new DateTime(2021, 12, 7, 1, 6, 47, 144, DateTimeKind.Local).AddTicks(4478), "92de2d17-357c-4d82-be15-c3df37a46cfe" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 6, 57, 735, DateTimeKind.Local).AddTicks(8841), new DateTime(2021, 12, 22, 8, 43, 47, 848, DateTimeKind.Local).AddTicks(7343), "de6c5249-1866-4d90-9e1d-9d36ff050508" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 49, 0, 732, DateTimeKind.Local).AddTicks(8904), new DateTime(2021, 9, 22, 15, 54, 52, 390, DateTimeKind.Local).AddTicks(6186), "fe08f93a-f539-4cbc-bf30-5f3bc3e7fdb6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 41, 46, 83, DateTimeKind.Local).AddTicks(8657), new DateTime(2021, 5, 1, 5, 25, 32, 198, DateTimeKind.Local).AddTicks(2870), "de2ba697-4cad-4ad6-a811-6edce2826e43" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 58, 26, 947, DateTimeKind.Local).AddTicks(460), new DateTime(2021, 11, 6, 3, 21, 16, 561, DateTimeKind.Local).AddTicks(9251), "cbbab8a0-4d0d-4e85-9c0b-71330cfa4aba" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 59, 15, 214, DateTimeKind.Local).AddTicks(1641), new DateTime(2021, 12, 1, 5, 18, 4, 553, DateTimeKind.Local).AddTicks(1470), "52ab5e58-af7b-486c-9ba6-c77e9f675978" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 48, 58, 160, DateTimeKind.Local).AddTicks(4893), new DateTime(2021, 7, 21, 14, 45, 48, 507, DateTimeKind.Local).AddTicks(4858), "83fde9bf-6b39-409c-81c5-bced1b8597a3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 19, 3, 443, DateTimeKind.Local).AddTicks(6205), new DateTime(2021, 11, 21, 19, 2, 57, 28, DateTimeKind.Local).AddTicks(3308), "7b29f04a-9aaa-4cd6-b0e5-325167ee8140" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 15, 6, 405, DateTimeKind.Local).AddTicks(8021), new DateTime(2021, 7, 6, 17, 40, 42, 882, DateTimeKind.Local).AddTicks(37), "00949059-a0fd-492b-b331-df010d780fea" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 7, 36, 312, DateTimeKind.Local).AddTicks(7268), new DateTime(2021, 10, 4, 20, 8, 55, 959, DateTimeKind.Local).AddTicks(6006), "5fafe61d-0e42-4217-9dad-2ea5b2d46c58" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 34, 10, 174, DateTimeKind.Local).AddTicks(5127), new DateTime(2021, 4, 25, 11, 52, 14, 224, DateTimeKind.Local).AddTicks(390), "aa2ca5c0-6d5a-42f5-a8bc-86c4f63a31f3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 41, 58, 716, DateTimeKind.Local).AddTicks(4643), new DateTime(2021, 11, 7, 23, 23, 26, 577, DateTimeKind.Local).AddTicks(6589), "44995025-160f-477a-97d1-d91d80d959b7" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 32, 27, 207, DateTimeKind.Local).AddTicks(5854), new DateTime(2022, 1, 2, 5, 26, 31, 221, DateTimeKind.Local).AddTicks(3879), "0cdc7f50-e15c-4246-be7d-3345f2f7dc61" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 51, 19, 736, DateTimeKind.Local).AddTicks(4877), new DateTime(2021, 2, 17, 17, 25, 47, 414, DateTimeKind.Local).AddTicks(3798), "993cd7fd-28f7-4c7c-b589-6d23fbfb37c4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 11, 38, 323, DateTimeKind.Local).AddTicks(1072), new DateTime(2021, 5, 22, 20, 11, 21, 556, DateTimeKind.Local).AddTicks(9802), "3280633d-296b-4f78-97e2-9a2d08fb60b4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 33, 5, 733, DateTimeKind.Local).AddTicks(2518), new DateTime(2022, 1, 9, 6, 16, 35, 779, DateTimeKind.Local).AddTicks(4271), "46093005-96a0-40b0-8ef9-717bcd23f42c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 46, 18, 580, DateTimeKind.Local).AddTicks(5329), new DateTime(2021, 9, 1, 2, 26, 27, 904, DateTimeKind.Local).AddTicks(4565), "2162c17e-0feb-411f-b2ce-f49ab8953b9f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 37, 8, 365, DateTimeKind.Local).AddTicks(7379), new DateTime(2021, 9, 1, 21, 45, 2, 795, DateTimeKind.Local).AddTicks(5710), "b13e800e-437e-469d-a552-fd92abc1740e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 54, 1, 23, DateTimeKind.Local).AddTicks(6458), new DateTime(2021, 3, 31, 14, 35, 32, 283, DateTimeKind.Local).AddTicks(9755), "9d994f7a-e57f-4019-bf9a-1b8f343f00ff" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 35, 26, 933, DateTimeKind.Local).AddTicks(6374), new DateTime(2021, 11, 8, 22, 12, 14, 556, DateTimeKind.Local).AddTicks(9299), "6846b5e4-eaab-4e9d-be72-aaf0f87452da" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 57, 24, 382, DateTimeKind.Local).AddTicks(4618), new DateTime(2021, 3, 25, 2, 17, 13, 993, DateTimeKind.Local).AddTicks(2075), "aa9ecc7c-dfbd-4d3f-ba4e-a844e4c61888" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 56, 28, 549, DateTimeKind.Local).AddTicks(7536), new DateTime(2021, 10, 27, 21, 24, 48, 822, DateTimeKind.Local).AddTicks(5608), "d2ec0869-892b-41b4-9366-e514522d6a0c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 36, 20, 316, DateTimeKind.Local).AddTicks(2489), new DateTime(2021, 3, 7, 8, 58, 18, 915, DateTimeKind.Local).AddTicks(2226), "f9976319-6d80-4fa3-ab47-2139aa7ea574" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 23, 0, 719, DateTimeKind.Local).AddTicks(1157), new DateTime(2022, 1, 23, 20, 27, 53, 627, DateTimeKind.Local).AddTicks(9808), "012461c7-4908-424e-8cf7-beb3bb962c34" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 1, 5, 244, DateTimeKind.Local).AddTicks(8867), new DateTime(2022, 1, 17, 10, 28, 42, 359, DateTimeKind.Local).AddTicks(2895), "796aeee4-a1d6-4770-8d66-34ca62f0701d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 4, 20, 815, DateTimeKind.Local).AddTicks(2824), new DateTime(2021, 12, 31, 18, 54, 1, 195, DateTimeKind.Local).AddTicks(691), "27d29890-8b89-4212-aee0-ba0cf34cd4f6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 2, 48, 164, DateTimeKind.Local).AddTicks(8895), new DateTime(2021, 3, 8, 9, 9, 12, 258, DateTimeKind.Local).AddTicks(5513), "afd93021-2045-4240-ab66-8ff340dbdd3b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 51, 52, 716, DateTimeKind.Local).AddTicks(9632), new DateTime(2022, 1, 17, 1, 29, 42, 522, DateTimeKind.Local).AddTicks(2058), "d35783c9-1fda-4b05-83ad-f6b4043ac6c9" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 39, 15, 699, DateTimeKind.Local).AddTicks(3344), new DateTime(2021, 12, 23, 3, 40, 45, 142, DateTimeKind.Local).AddTicks(7049), "9823071b-8814-43bc-8cb0-2f543e306393" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 31, 44, 609, DateTimeKind.Local).AddTicks(1900), new DateTime(2021, 2, 9, 6, 59, 37, 554, DateTimeKind.Local).AddTicks(9846), "6bb4b687-ef0c-45cb-a780-5f5a85a8c927" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 29, 21, 302, DateTimeKind.Local).AddTicks(486), new DateTime(2021, 10, 5, 8, 3, 10, 919, DateTimeKind.Local).AddTicks(1753), "024b0e1d-a6b1-4fa1-9668-0f8a7e3d17d9" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 45, 47, 270, DateTimeKind.Local).AddTicks(8033), new DateTime(2021, 7, 27, 22, 7, 7, 795, DateTimeKind.Local).AddTicks(8486), "8f2c6040-a2fd-4ff2-a6da-bee537f260d5" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 35, 17, 307, DateTimeKind.Local).AddTicks(3493), new DateTime(2021, 3, 10, 6, 24, 14, 349, DateTimeKind.Local).AddTicks(9660), "2e918085-82da-4571-bd90-eb5b0bcb35f2" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 2, 36, 925, DateTimeKind.Local).AddTicks(2549), new DateTime(2021, 10, 8, 10, 16, 0, 43, DateTimeKind.Local).AddTicks(2969), "e6cdb109-f016-4f38-8bca-2323884113f8" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 15, 19, 513, DateTimeKind.Local).AddTicks(7513), new DateTime(2022, 1, 4, 22, 12, 3, 225, DateTimeKind.Local).AddTicks(3919), "b3346c59-60d2-48f1-893a-49cc3df35dea" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 16, 21, 943, DateTimeKind.Local).AddTicks(8906), new DateTime(2021, 4, 15, 2, 40, 46, 840, DateTimeKind.Local).AddTicks(8773), "bcbcf1a2-3f32-43ce-8805-52be546d1a38" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 36, 49, 749, DateTimeKind.Local).AddTicks(554), new DateTime(2021, 4, 4, 0, 52, 33, 624, DateTimeKind.Local).AddTicks(7544), "cbbc4c82-9abd-4588-9b97-87015e139e50" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 52, 10, 790, DateTimeKind.Local).AddTicks(9759), new DateTime(2021, 10, 9, 3, 16, 42, 879, DateTimeKind.Local).AddTicks(4090), "ff5ab460-3dbe-4c0b-8cf5-196f6a8d1350" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 59, 49, 398, DateTimeKind.Local).AddTicks(7563), new DateTime(2021, 8, 14, 6, 40, 38, 119, DateTimeKind.Local).AddTicks(9633), "49b2115c-28be-419a-a110-198696ca8398" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 50, 44, 44, DateTimeKind.Local).AddTicks(5884), new DateTime(2021, 7, 8, 8, 22, 34, 228, DateTimeKind.Local).AddTicks(8198), "366bcc88-a65d-48a1-9406-9942a326162c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 6, 50, 158, DateTimeKind.Local).AddTicks(7252), new DateTime(2021, 8, 23, 3, 34, 24, 620, DateTimeKind.Local).AddTicks(2790), "bf5c799a-a53c-4ba5-b264-7e8461eb5e4d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 47, 18, 967, DateTimeKind.Local).AddTicks(3800), new DateTime(2021, 7, 31, 15, 17, 1, 478, DateTimeKind.Local).AddTicks(4371), "a99775cf-96e4-4f7a-b085-eeaf2dad7417" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 57, 12, 678, DateTimeKind.Local).AddTicks(5139), new DateTime(2021, 12, 5, 6, 7, 1, 519, DateTimeKind.Local).AddTicks(1996), "848d03f2-0cd3-453f-8adc-b2995fea23b1" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 56, 32, 739, DateTimeKind.Local).AddTicks(904), new DateTime(2021, 10, 10, 10, 51, 0, 592, DateTimeKind.Local).AddTicks(1219), "fd77398a-7777-4294-a539-51512d82c79c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 8, 17, 111, DateTimeKind.Local).AddTicks(7523), new DateTime(2021, 3, 31, 23, 21, 24, 24, DateTimeKind.Local).AddTicks(5849), "86d90269-5ea7-4da8-8c58-7860a74bab75" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 45, 37, 326, DateTimeKind.Local).AddTicks(1790), new DateTime(2021, 11, 4, 5, 0, 29, 202, DateTimeKind.Local).AddTicks(2238), "51d1e965-46b0-4516-8733-4b21d268c903" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 41, 34, 108, DateTimeKind.Local).AddTicks(5978), new DateTime(2021, 7, 29, 5, 36, 4, 994, DateTimeKind.Local).AddTicks(2052), "f3002a26-885c-460b-b66f-3c87cf6dff57" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 33, 18, 314, DateTimeKind.Local).AddTicks(2489), new DateTime(2021, 12, 29, 0, 22, 14, 610, DateTimeKind.Local).AddTicks(9732), "e075b507-345a-4db8-91f5-9a77da3bb2c9" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 30, 5, 289, DateTimeKind.Local).AddTicks(3784), new DateTime(2021, 4, 5, 8, 36, 0, 298, DateTimeKind.Local).AddTicks(1313), "f2705fff-a0f5-4ca2-abc8-24bfacbcb411" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 32, 53, 898, DateTimeKind.Local).AddTicks(2721), new DateTime(2021, 5, 17, 15, 9, 59, 80, DateTimeKind.Local).AddTicks(9461), "faca4654-4a61-4d32-b49a-28022e44ae4d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 5, 10, 440, DateTimeKind.Local).AddTicks(4953), new DateTime(2021, 10, 20, 21, 51, 26, 656, DateTimeKind.Local).AddTicks(5885), "822198b8-fc82-461b-93c8-1b09145e2089" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 59, 19, 602, DateTimeKind.Local).AddTicks(1585), new DateTime(2021, 7, 5, 17, 46, 21, 825, DateTimeKind.Local).AddTicks(7104), "092bc0c2-f132-4888-8a68-f7ea4f4a5a3a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 49, 21, 551, DateTimeKind.Local).AddTicks(9465), new DateTime(2021, 5, 30, 22, 51, 31, 161, DateTimeKind.Local).AddTicks(8097), "7ebd70ba-1dd4-4c21-8955-0d083c1b1743" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 21, 9, 996, DateTimeKind.Local).AddTicks(8761), new DateTime(2021, 12, 21, 0, 35, 17, 104, DateTimeKind.Local).AddTicks(8828), "ef48544b-2cff-447d-94bf-5ecd4d4c6985" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 59, 19, 932, DateTimeKind.Local).AddTicks(8895), new DateTime(2021, 9, 27, 9, 49, 50, 775, DateTimeKind.Local).AddTicks(4399), "f814e3d1-a065-4023-9248-bd4dc2775306" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 57, 28, 859, DateTimeKind.Local).AddTicks(5213), new DateTime(2021, 4, 20, 11, 11, 53, 962, DateTimeKind.Local).AddTicks(459), "f8c316dc-c5fa-454f-9b40-27ad33ef8424" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 17, 53, 284, DateTimeKind.Local).AddTicks(1061), new DateTime(2021, 2, 15, 3, 33, 33, 653, DateTimeKind.Local).AddTicks(5263), "9882450f-c313-475a-819d-1d3003f25179" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 4, 26, 267, DateTimeKind.Local).AddTicks(8181), new DateTime(2021, 10, 6, 20, 2, 9, 467, DateTimeKind.Local).AddTicks(543), "535e35ff-d53c-4152-8af2-3d55b0d1f66c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 45, 13, 326, DateTimeKind.Local).AddTicks(4296), new DateTime(2021, 10, 28, 22, 29, 10, 194, DateTimeKind.Local).AddTicks(43), "aa9af2f1-d72d-4b3a-b48f-5ef5392d9e5f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 31, 36, 659, DateTimeKind.Local).AddTicks(5165), new DateTime(2021, 6, 1, 18, 57, 22, 247, DateTimeKind.Local).AddTicks(664), "e5938167-b911-4d7c-ac60-4c7a27748e42" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 27, 14, 842, DateTimeKind.Local).AddTicks(1552), new DateTime(2021, 9, 10, 18, 40, 23, 792, DateTimeKind.Local).AddTicks(7106), "029cff3a-06d6-4831-af34-5dd0f10c58c2" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 57, 22, 78, DateTimeKind.Local).AddTicks(3771), new DateTime(2021, 9, 30, 15, 52, 45, 504, DateTimeKind.Local).AddTicks(5348), "b1c2c6e2-b0f9-4a15-9d39-bf136b80011a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 15, 16, 151, DateTimeKind.Local).AddTicks(2027), new DateTime(2021, 8, 3, 11, 21, 58, 486, DateTimeKind.Local).AddTicks(202), "3d7f3638-291c-40cb-8b67-50d5a256543c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 51, 46, 239, DateTimeKind.Local).AddTicks(1842), new DateTime(2021, 11, 1, 1, 16, 15, 231, DateTimeKind.Local).AddTicks(7814), "f43122b6-eab5-49ab-b437-1becec800b00" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 30, 36, 925, DateTimeKind.Local).AddTicks(3337), new DateTime(2021, 2, 19, 13, 24, 43, 410, DateTimeKind.Local).AddTicks(5906), "5396e206-7fbd-4e8e-8b6f-e0436b2c2db4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 38, 43, 402, DateTimeKind.Local).AddTicks(4679), new DateTime(2022, 1, 21, 7, 26, 49, 270, DateTimeKind.Local).AddTicks(9284), "4ca245c7-38e1-438e-bc32-d20b5709e245" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 34, 37, 481, DateTimeKind.Local).AddTicks(2800), new DateTime(2021, 6, 9, 8, 3, 56, 178, DateTimeKind.Local).AddTicks(9580), "7cca746f-5422-442b-9176-34b7bc3cc76a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 49, 31, 32, DateTimeKind.Local).AddTicks(4090), new DateTime(2021, 11, 21, 14, 37, 42, 693, DateTimeKind.Local).AddTicks(749), "315eeb84-9892-4c72-81af-791a3c242f5e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 54, 40, 174, DateTimeKind.Local).AddTicks(6188), new DateTime(2021, 3, 30, 5, 58, 16, 657, DateTimeKind.Local).AddTicks(811), "3b75670c-44d9-4326-a0f2-c042e72635f3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 25, 33, 237, DateTimeKind.Local).AddTicks(8921), new DateTime(2021, 11, 18, 15, 48, 45, 608, DateTimeKind.Local).AddTicks(660), "2b9d913e-6d35-4e3d-9458-5899059358e7" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 20, 23, 954, DateTimeKind.Local).AddTicks(43), new DateTime(2021, 4, 28, 4, 5, 58, 646, DateTimeKind.Local).AddTicks(639), "93441a07-82a8-43d1-8eb7-fe062837c2aa" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 25, 55, 469, DateTimeKind.Local).AddTicks(8185), new DateTime(2021, 12, 27, 1, 19, 16, 314, DateTimeKind.Local).AddTicks(5600), "993eb021-5777-4119-92fc-541e9b6408b5" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 58, 39, 442, DateTimeKind.Local).AddTicks(748), new DateTime(2021, 6, 8, 12, 29, 30, 20, DateTimeKind.Local).AddTicks(300), "e4179281-6408-4329-8e16-2ffa500d57d6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 35, 3, 522, DateTimeKind.Local).AddTicks(9259), new DateTime(2021, 4, 30, 1, 55, 31, 248, DateTimeKind.Local).AddTicks(532), "05fc5276-a0ed-4de5-a610-83dd326b8173" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 54, 15, 523, DateTimeKind.Local).AddTicks(823), new DateTime(2021, 7, 26, 12, 22, 59, 304, DateTimeKind.Local).AddTicks(6819), "9d2e3da3-748c-45e5-bd6b-cc3c06ffde14" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 18, 56, 21, DateTimeKind.Local).AddTicks(8996), new DateTime(2021, 7, 20, 8, 58, 23, 962, DateTimeKind.Local).AddTicks(2081), "40fe60bc-051a-4b9b-ada7-f27931c7688d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 40, 36, 279, DateTimeKind.Local).AddTicks(9760), new DateTime(2021, 8, 31, 15, 19, 45, 522, DateTimeKind.Local).AddTicks(8049), "839d6d2e-f4d7-4466-a63c-de8ad0c38799" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 34, 29, 488, DateTimeKind.Local).AddTicks(2045), new DateTime(2021, 11, 27, 22, 59, 21, 31, DateTimeKind.Local).AddTicks(5127), "c30d4dd8-bf41-4d0e-bbdf-1d3469bfcbf2" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 54, 58, 283, DateTimeKind.Local).AddTicks(4001), new DateTime(2021, 8, 6, 18, 28, 26, 835, DateTimeKind.Local).AddTicks(7279), "cbc0b54a-fb43-439c-99ee-79a4dd794a96" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 58, 6, 317, DateTimeKind.Local).AddTicks(8632), new DateTime(2021, 7, 24, 13, 44, 32, 859, DateTimeKind.Local).AddTicks(8612), "dea07f06-e215-42fc-a5dd-f6d2ee431047" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 33, 0, 455, DateTimeKind.Local).AddTicks(9855), new DateTime(2021, 6, 21, 8, 53, 52, 486, DateTimeKind.Local).AddTicks(857), "5f00d27f-117c-485f-9017-c1ddf532e2f1" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 44, 57, 522, DateTimeKind.Local).AddTicks(5784), new DateTime(2021, 11, 1, 9, 18, 36, 94, DateTimeKind.Local).AddTicks(632), "ab2e01bf-c6f4-4f71-8afe-16d318a6e924" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 40, 30, 657, DateTimeKind.Local).AddTicks(70), new DateTime(2021, 7, 18, 16, 6, 10, 303, DateTimeKind.Local).AddTicks(2162), "8b6ae43d-9f2b-442c-91ec-f5f860ebc428" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 53, 18, 878, DateTimeKind.Local).AddTicks(7768), new DateTime(2021, 4, 27, 1, 6, 17, 102, DateTimeKind.Local).AddTicks(6367), "dd62ef30-a9ed-4014-8cb0-0a71e9a204eb" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 40, 14, 623, DateTimeKind.Local).AddTicks(1041), new DateTime(2021, 3, 28, 4, 17, 45, 167, DateTimeKind.Local).AddTicks(6167), "46d9e728-3c07-478e-80a8-ba3383dd974d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 56, 28, 570, DateTimeKind.Local).AddTicks(7287), new DateTime(2021, 5, 26, 21, 33, 11, 125, DateTimeKind.Local).AddTicks(9455), "2f536d13-e573-44ed-bfa8-01580816178e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 51, 24, 797, DateTimeKind.Local).AddTicks(5382), new DateTime(2021, 5, 24, 13, 44, 25, 377, DateTimeKind.Local).AddTicks(941), "57f8304a-02a7-4458-bed4-a7f2046af057" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 35, 53, 560, DateTimeKind.Local).AddTicks(5584), new DateTime(2021, 2, 8, 22, 40, 5, 929, DateTimeKind.Local).AddTicks(5711), "8257211b-39fa-4a2a-8cc7-79f75b30aa95" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 41, 43, 129, DateTimeKind.Local).AddTicks(5169), new DateTime(2021, 4, 9, 16, 58, 24, 576, DateTimeKind.Local).AddTicks(7589), "0afe9e32-5b46-46ca-bd62-29de90f48a9d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 22, 14, 967, DateTimeKind.Local).AddTicks(3442), new DateTime(2021, 4, 17, 13, 23, 58, 29, DateTimeKind.Local).AddTicks(9981), "f2d71ca5-ecee-4b9d-89b9-5ae69bc69766" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 41, 17, 260, DateTimeKind.Local).AddTicks(7394), new DateTime(2021, 4, 24, 17, 19, 21, 553, DateTimeKind.Local).AddTicks(6358), "46694f93-a38c-48e4-99a5-51119efe6942" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 4, 47, 275, DateTimeKind.Local).AddTicks(833), new DateTime(2021, 8, 13, 5, 42, 20, 88, DateTimeKind.Local).AddTicks(6442), "19af6b97-4145-4571-9bbc-ea78cbfb34cf" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 39, 46, 146, DateTimeKind.Local).AddTicks(2005), new DateTime(2021, 2, 21, 9, 24, 47, 99, DateTimeKind.Local).AddTicks(6514), "65a130c6-dfdf-4460-a9d3-a44896deea50" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 38, 36, 160, DateTimeKind.Local).AddTicks(9533), new DateTime(2021, 8, 16, 7, 42, 15, 278, DateTimeKind.Local).AddTicks(4478), "df9f3de8-d6e6-46a9-933d-d9a3ceb8c1da" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 39, 2, 898, DateTimeKind.Local).AddTicks(6681), new DateTime(2021, 3, 28, 5, 28, 55, 876, DateTimeKind.Local).AddTicks(145), "5efd800c-a5fa-4432-b182-05b50437a83c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 38, 40, 855, DateTimeKind.Local).AddTicks(5653), new DateTime(2021, 7, 25, 15, 17, 43, 498, DateTimeKind.Local).AddTicks(2005), "53968ace-605e-4a94-a1d0-df4883e8c206" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 3, 16, 643, DateTimeKind.Local).AddTicks(777), new DateTime(2021, 2, 17, 2, 9, 44, 233, DateTimeKind.Local).AddTicks(4883), "0cf0aee6-cb43-4902-9bd5-8095378a1e18" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 37, 36, 755, DateTimeKind.Local).AddTicks(6719), new DateTime(2022, 1, 21, 10, 26, 45, 294, DateTimeKind.Local).AddTicks(8061), "94c30472-33d7-428d-b752-022b7fd1ae71" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 1, 51, 249, DateTimeKind.Local).AddTicks(1959), new DateTime(2021, 9, 9, 5, 16, 32, 286, DateTimeKind.Local).AddTicks(972), "5533664c-be22-4ba0-b86b-2e37119e7be5" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 44, 42, 691, DateTimeKind.Local).AddTicks(4372), new DateTime(2021, 5, 5, 12, 23, 59, 22, DateTimeKind.Local).AddTicks(6805), "2dc2a5f6-71f4-4a5f-95d5-89a5dbe9444e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 14, 50, 691, DateTimeKind.Local).AddTicks(5024), new DateTime(2021, 7, 16, 5, 5, 30, 800, DateTimeKind.Local).AddTicks(4026), "a31443a4-e25b-4254-9992-099ac3d88d7a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 34, 10, 203, DateTimeKind.Local).AddTicks(8773), new DateTime(2021, 6, 13, 10, 27, 38, 70, DateTimeKind.Local).AddTicks(1492), "f5849696-7158-4e57-90af-4c8eb969ea49" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 26, 44, 421, DateTimeKind.Local).AddTicks(7199), new DateTime(2021, 10, 4, 12, 50, 44, 943, DateTimeKind.Local).AddTicks(7701), "35aaf8ca-da21-47b3-8810-8332a25060c0" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 36, 28, 943, DateTimeKind.Local).AddTicks(289), new DateTime(2021, 12, 29, 15, 34, 23, 877, DateTimeKind.Local).AddTicks(9053), "9566a22e-6ab4-4097-91d0-0772b04dda8e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 22, 14, 412, DateTimeKind.Local).AddTicks(2382), new DateTime(2021, 6, 6, 5, 42, 19, 654, DateTimeKind.Local).AddTicks(9249), "cfc58625-e37e-424d-9959-8479061b450c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 14, 21, 240, DateTimeKind.Local).AddTicks(4135), new DateTime(2021, 11, 22, 16, 47, 44, 210, DateTimeKind.Local).AddTicks(232), "8b13bb4b-d8a9-4d9c-8ca9-2512edd77fb4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 51, 17, 524, DateTimeKind.Local).AddTicks(4059), new DateTime(2021, 3, 22, 3, 55, 10, 710, DateTimeKind.Local).AddTicks(9333), "c903809b-011b-44ce-8027-b2716b552780" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 43, 52, 2, DateTimeKind.Local).AddTicks(5175), new DateTime(2021, 6, 8, 23, 8, 41, 8, DateTimeKind.Local).AddTicks(7007), "c410211e-5dc5-404c-9d48-41e8ba75a639" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 10, 57, 806, DateTimeKind.Local).AddTicks(2265), new DateTime(2021, 3, 4, 15, 15, 57, 450, DateTimeKind.Local).AddTicks(3681), "48594768-433d-4be9-ad10-a774f01daaef" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 2, 44, 995, DateTimeKind.Local).AddTicks(1711), new DateTime(2022, 1, 7, 14, 20, 29, 941, DateTimeKind.Local).AddTicks(9749), "16abd6fa-9063-435f-ab5d-ee6d4a56437f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 43, 43, 958, DateTimeKind.Local).AddTicks(5124), new DateTime(2021, 2, 28, 21, 0, 56, 875, DateTimeKind.Local).AddTicks(1659), "d38d4ad5-144e-4950-977a-36043a975b1b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 20, 47, 24, DateTimeKind.Local).AddTicks(124), new DateTime(2021, 7, 24, 4, 22, 46, 863, DateTimeKind.Local).AddTicks(6154), "1a1c0371-17bc-45da-b7c7-2fbf4b03ee0c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 13, 44, 216, DateTimeKind.Local).AddTicks(1304), new DateTime(2021, 2, 14, 9, 48, 58, 373, DateTimeKind.Local).AddTicks(804), "7eb0f92d-65aa-4719-8b36-bd10cb008a3c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 49, 6, 749, DateTimeKind.Local).AddTicks(9640), new DateTime(2022, 1, 27, 4, 2, 49, 422, DateTimeKind.Local).AddTicks(6340), "1bcd5602-da7d-4d9d-920f-f70c25d47910" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 58, 49, 913, DateTimeKind.Local).AddTicks(1201), new DateTime(2021, 6, 11, 12, 54, 58, 422, DateTimeKind.Local).AddTicks(6045), "b0f9974d-17cd-40a0-b4ba-3c1471ecec8d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 41, 1, 602, DateTimeKind.Local).AddTicks(7834), new DateTime(2021, 10, 8, 13, 41, 30, 72, DateTimeKind.Local).AddTicks(6783), "5bf08be5-2840-48a0-9d3c-98e27507142c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 32, 51, 178, DateTimeKind.Local).AddTicks(9567), new DateTime(2021, 5, 7, 23, 53, 45, 769, DateTimeKind.Local).AddTicks(4210), "b518a3ae-4164-466a-b139-cb286589debf" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 55, 16, 818, DateTimeKind.Local).AddTicks(5564), new DateTime(2022, 2, 4, 8, 35, 49, 490, DateTimeKind.Local).AddTicks(4324), "1f0306f4-7adf-46a1-8ea0-adc042384ef4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 10, 19, 732, DateTimeKind.Local).AddTicks(6124), new DateTime(2022, 1, 6, 15, 0, 25, 785, DateTimeKind.Local).AddTicks(9356), "20d9b3c0-4f2d-4f33-a857-caa760a29dec" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 12, 13, 937, DateTimeKind.Local).AddTicks(5906), new DateTime(2021, 7, 30, 13, 5, 19, 247, DateTimeKind.Local).AddTicks(9279), "e8a0f0e0-d94a-4d73-8faa-de17f1e00505" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 33, 31, 408, DateTimeKind.Local).AddTicks(18), new DateTime(2021, 5, 14, 23, 35, 18, 868, DateTimeKind.Local).AddTicks(5498), "c3131e7c-74a0-4f83-9117-57efc084bbd6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 49, 36, 391, DateTimeKind.Local).AddTicks(917), new DateTime(2021, 12, 11, 4, 33, 6, 111, DateTimeKind.Local).AddTicks(1725), "2f360474-e7c1-4c59-af40-4ccc4a8d53c9" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 8, 35, 285, DateTimeKind.Local).AddTicks(3069), new DateTime(2021, 6, 19, 21, 32, 51, 163, DateTimeKind.Local).AddTicks(4310), "fe42d054-9508-4395-bc5f-887fe0e5774c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 17, 11, 505, DateTimeKind.Local).AddTicks(3208), new DateTime(2021, 9, 29, 7, 6, 49, 105, DateTimeKind.Local).AddTicks(8043), "9beb97d1-522a-4511-ad14-6b5875cd7361" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 56, 59, 249, DateTimeKind.Local).AddTicks(8152), new DateTime(2021, 10, 1, 5, 39, 6, 428, DateTimeKind.Local).AddTicks(1960), "a8969229-6962-4d6a-91c6-5aa5e657d103" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 8, 3, 828, DateTimeKind.Local).AddTicks(5631), new DateTime(2021, 9, 8, 23, 0, 40, 144, DateTimeKind.Local).AddTicks(8881), "c6781af4-ac24-4afd-8da8-41578b4273a9" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 55, 50, 788, DateTimeKind.Local).AddTicks(8100), new DateTime(2021, 6, 14, 2, 36, 22, 620, DateTimeKind.Local).AddTicks(6934), "48c16b66-6fd1-4033-935c-83fc6580c256" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 33, 9, 287, DateTimeKind.Local).AddTicks(1505), new DateTime(2021, 2, 9, 8, 27, 20, 314, DateTimeKind.Local).AddTicks(311), "5640dfeb-5e27-43f7-be56-c2e1bbf49c8b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 20, 49, 529, DateTimeKind.Local).AddTicks(5347), new DateTime(2021, 10, 21, 12, 28, 2, 537, DateTimeKind.Local).AddTicks(2310), "68edfd29-0b73-4e9f-a875-b1296f086f3e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 47, 19, 514, DateTimeKind.Local).AddTicks(3746), new DateTime(2021, 12, 6, 23, 33, 10, 901, DateTimeKind.Local).AddTicks(3713), "b6e89264-3326-43a6-a36c-8185e3fa6874" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 33, 9, 949, DateTimeKind.Local).AddTicks(5036), new DateTime(2022, 1, 10, 2, 10, 4, 816, DateTimeKind.Local).AddTicks(6750), "6447ab48-6a23-46c0-88a5-7c619f79c9bc" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 58, 39, 650, DateTimeKind.Local).AddTicks(2457), new DateTime(2022, 1, 3, 12, 55, 32, 551, DateTimeKind.Local).AddTicks(8034), "214f793c-d88f-4c69-be40-16bec633a2d4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 55, 1, 9, DateTimeKind.Local).AddTicks(643), new DateTime(2021, 6, 23, 22, 26, 50, 810, DateTimeKind.Local).AddTicks(2998), "3673f8aa-1c6d-48f9-a479-f9d2d61670d1" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 54, 11, 467, DateTimeKind.Local).AddTicks(853), new DateTime(2021, 7, 27, 23, 41, 28, 360, DateTimeKind.Local).AddTicks(5301), "381c0d64-f583-4376-9bb1-63ae51aea500" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 34, 42, 186, DateTimeKind.Local).AddTicks(1640), new DateTime(2021, 4, 22, 17, 9, 39, 973, DateTimeKind.Local).AddTicks(4869), "cf1de555-662c-4da9-b373-398419da03c3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 49, 20, 120, DateTimeKind.Local).AddTicks(3600), new DateTime(2021, 3, 11, 10, 25, 59, 441, DateTimeKind.Local).AddTicks(2452), "0796ca47-f981-4e0c-8842-e3a2f2d17df9" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 10, 1, 589, DateTimeKind.Local).AddTicks(283), new DateTime(2022, 1, 22, 23, 14, 30, 643, DateTimeKind.Local).AddTicks(3255), "c75e0d22-7b82-4f38-a813-fecffb1f3ed4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 56, 15, 353, DateTimeKind.Local).AddTicks(1954), new DateTime(2021, 10, 1, 2, 23, 26, 359, DateTimeKind.Local).AddTicks(9781), "3c8abbf9-6c26-4eae-beb5-96216c31fa7d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 47, 45, 646, DateTimeKind.Local).AddTicks(6993), new DateTime(2021, 4, 26, 2, 50, 59, 797, DateTimeKind.Local).AddTicks(5838), "1ef91283-6552-44f3-9d7c-4eea95bbe671" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 32, 27, 948, DateTimeKind.Local).AddTicks(9777), new DateTime(2021, 4, 17, 13, 58, 57, 572, DateTimeKind.Local).AddTicks(7687), "3bd75950-f2d6-4472-9c66-ab0c907ab163" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 25, 22, 585, DateTimeKind.Local).AddTicks(2972), new DateTime(2021, 9, 3, 8, 12, 4, 96, DateTimeKind.Local).AddTicks(3765), "2ffdec13-59ec-4978-874e-da795c9bd174" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 14, 34, 259, DateTimeKind.Local).AddTicks(7390), new DateTime(2022, 1, 5, 14, 5, 53, 99, DateTimeKind.Local).AddTicks(7273), "9ead6486-1c3f-4fc0-a242-d06a2d2a0a1f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 34, 16, 392, DateTimeKind.Local).AddTicks(871), new DateTime(2021, 8, 3, 10, 11, 25, 34, DateTimeKind.Local).AddTicks(6833), "49100a00-8f96-4e41-9d97-04faf268667d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 45, 52, 777, DateTimeKind.Local).AddTicks(585), new DateTime(2021, 11, 13, 11, 31, 42, 953, DateTimeKind.Local).AddTicks(1601), "485c3061-7c70-4087-8c88-ce049312a366" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 14, 38, 52, 345, DateTimeKind.Local).AddTicks(805), new DateTime(2021, 9, 10, 14, 42, 20, 188, DateTimeKind.Local).AddTicks(525), "71b506a8-bf9c-4c30-9689-7e433d97e908" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 28, 34, 323, DateTimeKind.Local).AddTicks(7577), new DateTime(2021, 4, 28, 17, 34, 35, 654, DateTimeKind.Local).AddTicks(180), "434b7a83-f717-4918-bf6f-5228d421c789" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 50, 29, 353, DateTimeKind.Local).AddTicks(4060), new DateTime(2021, 3, 9, 18, 12, 51, 904, DateTimeKind.Local).AddTicks(5764), "46f82285-5081-4c5e-a4f0-0ee5c4d19194" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 33, 8, 270, DateTimeKind.Local).AddTicks(7655), new DateTime(2021, 2, 15, 12, 50, 14, 813, DateTimeKind.Local).AddTicks(9154), "0190f404-d1e1-48b5-babd-a5f987f64a13" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 58, 55, 893, DateTimeKind.Local).AddTicks(2404), new DateTime(2021, 11, 17, 17, 27, 9, 628, DateTimeKind.Local).AddTicks(3390), "250c2699-137e-4318-bb60-435128bd41a2" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 29, 17, 926, DateTimeKind.Local).AddTicks(4011), new DateTime(2021, 7, 15, 10, 53, 38, 363, DateTimeKind.Local).AddTicks(2061), "7a9445b7-d88f-48ed-87bb-e693c2a846b3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 0, 51, 157, DateTimeKind.Local).AddTicks(4776), new DateTime(2021, 2, 18, 2, 6, 45, 858, DateTimeKind.Local).AddTicks(3885), "0918d10f-47f2-46e9-a8b5-99e675d187ef" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 23, 14, 340, DateTimeKind.Local).AddTicks(4909), new DateTime(2021, 10, 10, 12, 45, 38, 803, DateTimeKind.Local).AddTicks(8269), "10a241d0-31aa-4c1a-ac35-7153ed9e0157" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 45, 33, 357, DateTimeKind.Local).AddTicks(3428), new DateTime(2021, 3, 21, 21, 15, 23, 886, DateTimeKind.Local).AddTicks(9159), "9f295125-faad-423e-b182-9a6da679b2a2" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 10, 10, 203, DateTimeKind.Local).AddTicks(9021), new DateTime(2021, 7, 16, 16, 58, 24, 106, DateTimeKind.Local).AddTicks(2711), "e74e161d-5a16-4977-a542-5d4c488669ae" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 26, 1, 736, DateTimeKind.Local).AddTicks(756), new DateTime(2021, 8, 6, 7, 57, 52, 139, DateTimeKind.Local).AddTicks(3346), "2389e993-c4ab-4e84-ac07-6d748799fe24" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 54, 20, 35, DateTimeKind.Local).AddTicks(7989), new DateTime(2022, 1, 21, 20, 4, 54, 75, DateTimeKind.Local).AddTicks(8000), "76ad67e8-b22a-49ca-ba09-7eb5730e347b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 47, 31, 552, DateTimeKind.Local).AddTicks(5674), new DateTime(2021, 10, 16, 23, 41, 12, 66, DateTimeKind.Local).AddTicks(2074), "afcb6edd-4b6b-4e00-b0f6-fd1cb06cf7bf" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 22, 26, 919, DateTimeKind.Local).AddTicks(2902), new DateTime(2021, 5, 30, 18, 43, 39, 410, DateTimeKind.Local).AddTicks(7289), "249f620f-9c04-4618-8d7e-8f6baf1c5f8c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 8, 14, 599, DateTimeKind.Local).AddTicks(8525), new DateTime(2021, 12, 10, 18, 18, 59, 562, DateTimeKind.Local).AddTicks(1843), "5263d232-f765-471b-9281-ab028e08a82a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 37, 1, 574, DateTimeKind.Local).AddTicks(5967), new DateTime(2021, 11, 6, 11, 48, 15, 346, DateTimeKind.Local).AddTicks(7351), "050c85a8-64d2-408e-b4d3-698a774c5bcf" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 50, 17, 909, DateTimeKind.Local).AddTicks(4283), new DateTime(2021, 5, 15, 17, 35, 56, 246, DateTimeKind.Local).AddTicks(80), "2f9aa0b8-d746-4c66-961d-987e503f944a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 31, 55, 746, DateTimeKind.Local).AddTicks(7443), new DateTime(2021, 12, 24, 1, 36, 16, 908, DateTimeKind.Local).AddTicks(1972), "5aafdc43-6d1b-4d0a-832b-f8bff1035e47" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 6, 22, 419, DateTimeKind.Local).AddTicks(7398), new DateTime(2021, 2, 17, 8, 23, 54, 195, DateTimeKind.Local).AddTicks(567), "394e8d59-facf-4edd-8cf6-215280e79557" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 30, 55, 924, DateTimeKind.Local).AddTicks(5365), new DateTime(2022, 2, 3, 10, 48, 57, 885, DateTimeKind.Local).AddTicks(9500), "29edf872-6446-40de-8d99-bcb449258cf5" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 34, 13, 769, DateTimeKind.Local).AddTicks(2287), new DateTime(2021, 6, 13, 18, 47, 34, 480, DateTimeKind.Local).AddTicks(4475), "a8e74ba0-48f5-4ffc-9808-fa6d7c23d345" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 54, 45, 521, DateTimeKind.Local).AddTicks(894), new DateTime(2021, 10, 21, 9, 26, 53, 215, DateTimeKind.Local).AddTicks(3982), "06b7bbfa-b0b5-4be6-9a6d-0bc40d6a34e4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 32, 25, 280, DateTimeKind.Local).AddTicks(5941), new DateTime(2021, 10, 25, 14, 4, 29, 235, DateTimeKind.Local).AddTicks(3018), "48dec265-f8bf-469d-9a57-28d7f39b78ae" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 24, 41, 880, DateTimeKind.Local).AddTicks(8432), new DateTime(2021, 2, 25, 0, 10, 47, 685, DateTimeKind.Local).AddTicks(8602), "d3917622-ac49-4691-8ad3-6aa95c20c6db" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 2, 14, 95, DateTimeKind.Local).AddTicks(2756), new DateTime(2021, 8, 14, 11, 41, 24, 866, DateTimeKind.Local).AddTicks(8365), "99fa3650-9ac4-4805-a1ad-468f5602dc52" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 25, 42, 243, DateTimeKind.Local).AddTicks(7895), new DateTime(2021, 3, 12, 18, 32, 56, 977, DateTimeKind.Local).AddTicks(6429), "2437db8f-3456-4999-8b52-e26869d24a24" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 19, 23, 723, DateTimeKind.Local).AddTicks(7586), new DateTime(2021, 8, 14, 6, 40, 40, 587, DateTimeKind.Local).AddTicks(972), "142e9f9e-8cb4-4aa4-a1c3-45462ad375bd" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 20, 32, 456, DateTimeKind.Local).AddTicks(4453), new DateTime(2021, 12, 2, 21, 57, 19, 165, DateTimeKind.Local).AddTicks(7734), "1e866d91-3b83-4e47-81a0-cfad1e8530e7" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 33, 18, 423, DateTimeKind.Local).AddTicks(7518), new DateTime(2021, 12, 3, 15, 3, 47, 144, DateTimeKind.Local).AddTicks(8430), "b53cea59-695e-4708-b9d7-f4d543417988" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 3, 32, 801, DateTimeKind.Local).AddTicks(3362), new DateTime(2021, 9, 5, 16, 55, 34, 618, DateTimeKind.Local).AddTicks(6332), "b47d8dbd-5fa9-4fc6-8783-053e85c60b23" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 53, 52, 168, DateTimeKind.Local).AddTicks(3632), new DateTime(2022, 1, 11, 4, 32, 23, 481, DateTimeKind.Local).AddTicks(8381), "50ed95c2-0a16-4099-bcec-3d1840fd4b18" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 14, 24, 933, DateTimeKind.Local).AddTicks(7530), new DateTime(2021, 5, 29, 5, 15, 51, 876, DateTimeKind.Local).AddTicks(9259), "2d7fbf9a-dd35-4774-8261-7f1fb80b4d84" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 3, 33, 991, DateTimeKind.Local).AddTicks(1505), new DateTime(2021, 6, 11, 3, 9, 34, 90, DateTimeKind.Local).AddTicks(5048), "0f14e038-becd-4a61-8b1f-56b859457e1b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 52, 55, 985, DateTimeKind.Local).AddTicks(2261), new DateTime(2022, 1, 29, 2, 39, 49, 556, DateTimeKind.Local).AddTicks(1391), "5adc5ff4-7c81-40de-ae5b-f9957e0195cd" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 45, 39, 530, DateTimeKind.Local).AddTicks(5818), new DateTime(2021, 9, 22, 12, 6, 5, 12, DateTimeKind.Local).AddTicks(8071), "405f0c48-f4a5-439f-a47b-943efe9a0872" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 59, 10, 875, DateTimeKind.Local).AddTicks(2474), new DateTime(2021, 8, 8, 16, 28, 17, 872, DateTimeKind.Local).AddTicks(721), "080f8b34-049a-4ff9-b70a-1b55f609c0eb" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 40, 39, 993, DateTimeKind.Local).AddTicks(1466), new DateTime(2021, 9, 19, 16, 31, 24, 544, DateTimeKind.Local).AddTicks(4807), "49a84c65-92d6-4000-ae2e-eb16c9ee71ba" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 53, 20, 490, DateTimeKind.Local).AddTicks(6538), new DateTime(2021, 3, 10, 19, 35, 23, 878, DateTimeKind.Local).AddTicks(4110), "543eb03c-a89e-4000-9dd6-4b7df7e0d2a4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 24, 17, 564, DateTimeKind.Local).AddTicks(295), new DateTime(2021, 3, 29, 19, 45, 44, 192, DateTimeKind.Local).AddTicks(557), "66e46d9c-77c1-4b5b-9f72-40ea010d9002" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 5, 48, 328, DateTimeKind.Local).AddTicks(3065), new DateTime(2021, 5, 31, 4, 1, 45, 281, DateTimeKind.Local).AddTicks(4935), "3ce677bf-1641-450b-bc2b-764be1ab484b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 20, 32, 249, DateTimeKind.Local).AddTicks(5919), new DateTime(2022, 2, 4, 7, 6, 30, 744, DateTimeKind.Local).AddTicks(7594), "7b3d4aa8-d57b-41bc-bcdd-4d11f09fa1c8" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 20, 28, 257, DateTimeKind.Local).AddTicks(6813), new DateTime(2022, 1, 3, 1, 16, 39, 723, DateTimeKind.Local).AddTicks(557), "f6167e15-e173-425b-8881-82d7a20137cb" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 58, 3, 946, DateTimeKind.Local).AddTicks(1701), new DateTime(2021, 12, 15, 12, 58, 31, 375, DateTimeKind.Local).AddTicks(1936), "7b1cb343-5f8a-457c-95c3-bad6c971f2b8" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 52, 29, 326, DateTimeKind.Local).AddTicks(5823), new DateTime(2021, 3, 17, 17, 15, 44, 743, DateTimeKind.Local).AddTicks(2360), "6703c10c-065e-4fae-b70e-91b2d6e44f60" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 26, 30, 291, DateTimeKind.Local).AddTicks(3750), new DateTime(2021, 12, 26, 21, 37, 52, 510, DateTimeKind.Local).AddTicks(8423), "986a1c2a-d949-47a6-bcbd-57fca4567324" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 2, 36, 166, DateTimeKind.Local).AddTicks(5608), new DateTime(2021, 11, 15, 3, 23, 49, 1, DateTimeKind.Local).AddTicks(36), "ca520adf-aa59-4500-99c6-98a0f60192c7" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 4, 30, 753, DateTimeKind.Local).AddTicks(2622), new DateTime(2021, 5, 6, 16, 37, 14, 910, DateTimeKind.Local).AddTicks(1742), "7ca7c387-b33f-4d74-92d5-1415c04ea850" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 54, 8, 745, DateTimeKind.Local).AddTicks(9331), new DateTime(2021, 5, 14, 7, 51, 24, 503, DateTimeKind.Local).AddTicks(1938), "8e149b5c-952c-4290-93eb-0090b8000c7b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 21, 32, 985, DateTimeKind.Local).AddTicks(3879), new DateTime(2022, 1, 8, 0, 16, 38, 540, DateTimeKind.Local).AddTicks(4981), "e3607688-e24f-4975-b974-d5eb29e82c6c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 7, 59, 295, DateTimeKind.Local).AddTicks(6670), new DateTime(2021, 12, 20, 13, 40, 22, 761, DateTimeKind.Local).AddTicks(9177), "fe44d47b-9a92-4fe4-bae1-ceab8685bdf3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 0, 27, 557, DateTimeKind.Local).AddTicks(9834), new DateTime(2021, 3, 16, 16, 43, 52, 275, DateTimeKind.Local).AddTicks(7177), "4737d2d9-7120-4225-b267-d8aae8354614" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 41, 2, 241, DateTimeKind.Local).AddTicks(3129), new DateTime(2021, 9, 5, 12, 6, 29, 871, DateTimeKind.Local).AddTicks(3832), "a5e3aec9-d27a-41ae-8cc6-231c91969c6d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 4, 54, 160, DateTimeKind.Local).AddTicks(2700), new DateTime(2021, 8, 29, 15, 58, 45, 657, DateTimeKind.Local).AddTicks(4775), "b916b3e5-38ce-42b9-956f-5843d5317ec4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 13, 19, 905, DateTimeKind.Local).AddTicks(1687), new DateTime(2021, 12, 19, 8, 20, 9, 180, DateTimeKind.Local).AddTicks(2034), "f02ddcc6-2a32-49ee-81fd-011acd44c5e6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 53, 51, 958, DateTimeKind.Local).AddTicks(6049), new DateTime(2021, 9, 2, 20, 45, 44, 762, DateTimeKind.Local).AddTicks(8913), "7d249017-f720-4be0-bb7b-511ff0154a60" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 9, 5, 46, DateTimeKind.Local).AddTicks(1628), new DateTime(2021, 4, 9, 0, 32, 29, 367, DateTimeKind.Local).AddTicks(915), "2c0de966-be59-4da1-9bc2-8d3edc881e74" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 30, 18, 714, DateTimeKind.Local).AddTicks(9435), new DateTime(2021, 9, 1, 0, 56, 25, 452, DateTimeKind.Local).AddTicks(8852), "0784633d-87b3-493f-a4de-23a4968bcd03" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 5, 32, 706, DateTimeKind.Local).AddTicks(1417), new DateTime(2021, 4, 1, 13, 6, 51, 336, DateTimeKind.Local).AddTicks(157), "a903f215-21a3-4909-be85-df86c9b9139a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 3, 52, 738, DateTimeKind.Local).AddTicks(5756), new DateTime(2021, 8, 3, 18, 18, 1, 814, DateTimeKind.Local).AddTicks(3835), "053e4986-7ca6-413c-9299-4f912ca3f4e2" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 0, 3, 67, DateTimeKind.Local).AddTicks(6128), new DateTime(2021, 4, 25, 6, 55, 55, 75, DateTimeKind.Local).AddTicks(1451), "03bb72c0-b3bc-438d-b87a-ebdd8ceb592e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 59, 42, 974, DateTimeKind.Local).AddTicks(9789), new DateTime(2021, 3, 21, 2, 34, 28, 405, DateTimeKind.Local).AddTicks(8494), "984a6407-89ff-4eb4-939b-a958bd1fe5ec" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 47, 0, 32, DateTimeKind.Local).AddTicks(1293), new DateTime(2021, 5, 11, 23, 2, 51, 471, DateTimeKind.Local).AddTicks(8289), "aae01573-9395-426f-933f-a60b811cab4f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 31, 51, 220, DateTimeKind.Local).AddTicks(5110), new DateTime(2021, 9, 9, 11, 37, 4, 90, DateTimeKind.Local).AddTicks(7996), "5b8fc8cd-3e65-4657-92ae-d1929133c6f3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 6, 57, 276, DateTimeKind.Local).AddTicks(6812), new DateTime(2021, 12, 25, 2, 46, 19, 111, DateTimeKind.Local).AddTicks(5612), "5460d16b-c59c-42d5-960e-67d6dc02e65f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 9, 34, 747, DateTimeKind.Local).AddTicks(1675), new DateTime(2021, 2, 7, 15, 29, 22, 874, DateTimeKind.Local).AddTicks(4690), "d61d7f17-3d43-4fc0-a656-729667fa6d4d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 34, 11, 200, DateTimeKind.Local).AddTicks(2403), new DateTime(2021, 6, 21, 6, 21, 30, 428, DateTimeKind.Local).AddTicks(871), "031042cc-4bdc-4add-b337-c59fe325240c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 39, 23, 389, DateTimeKind.Local).AddTicks(2730), new DateTime(2021, 11, 19, 9, 14, 22, 467, DateTimeKind.Local).AddTicks(2616), "e4022d5a-a8a9-4f50-930b-d65a2cdc8da7" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 18, 35, 626, DateTimeKind.Local).AddTicks(8952), new DateTime(2021, 6, 3, 13, 45, 55, 185, DateTimeKind.Local).AddTicks(4286), "f21a400c-b3a0-46d8-b22e-8185f68720a3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 7, 44, 107, DateTimeKind.Local).AddTicks(4174), new DateTime(2021, 3, 25, 3, 56, 49, 909, DateTimeKind.Local).AddTicks(2787), "9e1d99e1-7528-4d07-87fe-048a3972b35a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 12, 43, 660, DateTimeKind.Local).AddTicks(9800), new DateTime(2021, 3, 14, 9, 28, 56, 323, DateTimeKind.Local).AddTicks(3902), "b992ac25-f9d7-4ca3-882a-b30881d556b8" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 32, 55, 983, DateTimeKind.Local).AddTicks(5938), new DateTime(2021, 4, 23, 22, 33, 4, 742, DateTimeKind.Local).AddTicks(6438), "15c5791b-a221-4217-b5e7-260a1fd278fb" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 11, 57, 598, DateTimeKind.Local).AddTicks(2227), new DateTime(2021, 8, 3, 2, 3, 2, 322, DateTimeKind.Local).AddTicks(4709), "ddcfff4c-c6d6-4854-84a9-8bb8131c6400" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 25, 48, 727, DateTimeKind.Local).AddTicks(7545), new DateTime(2021, 2, 13, 9, 7, 59, 770, DateTimeKind.Local).AddTicks(5631), "e46c1909-8ac2-4b66-bbc5-b412528aa683" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 48, 41, 401, DateTimeKind.Local).AddTicks(8862), new DateTime(2021, 11, 18, 5, 45, 49, 19, DateTimeKind.Local).AddTicks(599), "1cf8da4a-74a2-46ea-aaca-3c8b7413fca7" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 54, 47, 19, DateTimeKind.Local).AddTicks(4472), new DateTime(2021, 7, 27, 7, 29, 7, 933, DateTimeKind.Local).AddTicks(8041), "d0776819-31ef-4965-a959-ed83d46344e0" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 22, 42, 580, DateTimeKind.Local).AddTicks(3226), new DateTime(2021, 8, 18, 18, 30, 20, 531, DateTimeKind.Local).AddTicks(4711), "12ac1eb0-f37b-4968-8e51-ef8459f78bbb" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 14, 52, 534, DateTimeKind.Local).AddTicks(7284), new DateTime(2021, 6, 3, 10, 2, 2, 335, DateTimeKind.Local).AddTicks(7453), "050d7062-b28a-44de-b3e7-21c0304c5614" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 10, 28, 949, DateTimeKind.Local).AddTicks(6376), new DateTime(2021, 12, 25, 2, 43, 37, 155, DateTimeKind.Local).AddTicks(7020), "afdb3152-6118-48e2-b072-b392d75fcb72" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 11, 19, 62, DateTimeKind.Local).AddTicks(6574), new DateTime(2021, 10, 6, 20, 24, 1, 682, DateTimeKind.Local).AddTicks(5704), "df87df94-3b38-4870-870e-0751a45290b5" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 11, 41, 859, DateTimeKind.Local).AddTicks(1763), new DateTime(2021, 12, 16, 12, 3, 28, 216, DateTimeKind.Local).AddTicks(6595), "20015ffa-b334-4319-81c3-d85b8b6a7ee4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 40, 32, 853, DateTimeKind.Local).AddTicks(3703), new DateTime(2021, 2, 23, 10, 33, 17, 889, DateTimeKind.Local).AddTicks(9040), "17d85bf1-43aa-4d00-b30d-ed7ab2745b78" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 26, 2, 659, DateTimeKind.Local).AddTicks(8527), new DateTime(2022, 1, 5, 18, 52, 54, 18, DateTimeKind.Local).AddTicks(4134), "a676d9da-2b12-4c82-8b89-8568a6a20a5a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 57, 29, 106, DateTimeKind.Local).AddTicks(350), new DateTime(2021, 4, 8, 5, 6, 28, 663, DateTimeKind.Local).AddTicks(5942), "9b7d3d9f-e8ea-4916-881f-ede4d56eff56" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 9, 20, 595, DateTimeKind.Local).AddTicks(8794), new DateTime(2021, 10, 5, 23, 2, 56, 522, DateTimeKind.Local).AddTicks(6235), "461e085e-aca0-4400-b629-6123906c6229" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 41, 40, 433, DateTimeKind.Local).AddTicks(4195), new DateTime(2021, 12, 6, 11, 53, 14, 886, DateTimeKind.Local).AddTicks(5159), "c8d9cbf6-b85d-44e3-ac59-43b4f3a4c61b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 16, 45, 5, DateTimeKind.Local).AddTicks(8938), new DateTime(2021, 12, 7, 7, 53, 14, 847, DateTimeKind.Local).AddTicks(2268), "e2a1fb5a-93eb-4421-be34-eface238bd31" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 40, 17, 481, DateTimeKind.Local).AddTicks(2960), new DateTime(2021, 11, 29, 12, 17, 31, 969, DateTimeKind.Local).AddTicks(9696), "3f014ef3-7ff0-4f02-81f4-67f8721b0024" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 28, 21, 564, DateTimeKind.Local).AddTicks(8947), new DateTime(2021, 9, 14, 7, 37, 46, 803, DateTimeKind.Local).AddTicks(4854), "e51c3d3f-40a3-4315-9291-7864b70154df" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 6, 42, 200, DateTimeKind.Local).AddTicks(1217), new DateTime(2021, 3, 26, 8, 8, 0, 848, DateTimeKind.Local).AddTicks(5966), "cd97bc34-c415-48c7-94a1-d2dc8f30df5f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 8, 47, 449, DateTimeKind.Local).AddTicks(4385), new DateTime(2021, 6, 12, 19, 19, 39, 191, DateTimeKind.Local).AddTicks(5095), "c70474f0-d7ae-4819-a4a3-db04b60ae9fa" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 25, 44, 840, DateTimeKind.Local).AddTicks(3851), new DateTime(2021, 2, 21, 14, 46, 47, 930, DateTimeKind.Local).AddTicks(8268), "d31df475-48d1-4c1b-8b5d-92842b0d5948" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 43, 13, 921, DateTimeKind.Local).AddTicks(6588), new DateTime(2021, 12, 1, 11, 48, 42, 791, DateTimeKind.Local).AddTicks(6761), "278be08d-21ae-4211-b1b3-e48e8c1bbdf2" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 12, 15, 264, DateTimeKind.Local).AddTicks(6100), new DateTime(2021, 10, 27, 22, 15, 27, 815, DateTimeKind.Local).AddTicks(3255), "2a369377-cdad-4bee-87a1-09933483f66d" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<Guid>(
                name: "AzureId",
                table: "Petsitters",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<Guid>(
                name: "AzureId",
                table: "Clients",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
    }
}
