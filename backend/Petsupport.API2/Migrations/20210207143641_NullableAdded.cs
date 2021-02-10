using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Petsupport.API2.Migrations
{
    public partial class NullableAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PhotoId",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ParcelAndHouseNumbers",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Environment",
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
                name: "Country",
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

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1,
                column: "AzureId",
                value: "0fa8829d-8671-4992-9414-2651031541cc");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2,
                column: "AzureId",
                value: "72f94eae-f1cb-4dfe-a535-99d4b118d98f");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3,
                column: "AzureId",
                value: "d5ecc707-5129-4fa7-9732-40942e52d83b");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4,
                column: "AzureId",
                value: "22c0363c-5c41-4c9c-b0d4-347f188656bb");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5,
                column: "AzureId",
                value: "c8fd4d28-dcf4-47f5-945e-6a391e98a73c");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6,
                column: "AzureId",
                value: "87acf9da-80a1-4c2f-b264-d42178838b65");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7,
                column: "AzureId",
                value: "38a82246-d5aa-437a-8512-0129f8a1d950");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8,
                column: "AzureId",
                value: "f3feb191-7610-4074-9afa-0afa7c3cb045");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9,
                column: "AzureId",
                value: "61247b57-8476-4b23-9c53-30bb25f9ad37");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10,
                column: "AzureId",
                value: "341042a2-f993-4cdc-bd82-3830c436840f");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11,
                column: "AzureId",
                value: "4e756b79-e609-4ec0-9c32-f7c167e4adf6");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12,
                column: "AzureId",
                value: "7292eb2c-66eb-4725-a586-a263b58a8982");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13,
                column: "AzureId",
                value: "b388cbb7-a895-4c63-861e-dc02d94032f0");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14,
                column: "AzureId",
                value: "b8590727-883d-44f8-b245-70a6dbec108c");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15,
                column: "AzureId",
                value: "45503992-35f9-42bd-a247-5587d27cec3b");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 16,
                column: "AzureId",
                value: "8693c701-dd5b-47ad-93d8-af7e335fc570");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 17,
                column: "AzureId",
                value: "f7cfbde1-80a1-41ab-ae42-934470dab5e3");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 18,
                column: "AzureId",
                value: "470137ca-e9ae-4eb4-8cdf-eb4ed810a880");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 19,
                column: "AzureId",
                value: "a46843b2-0005-494a-8317-a703358b24ab");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 20,
                column: "AzureId",
                value: "26d66c5b-54e2-4c67-95a0-2a28b175823f");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 21,
                column: "AzureId",
                value: "7434b177-f110-4430-ad03-5f9ee96a3cd1");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 22,
                column: "AzureId",
                value: "49459aee-22a1-4e23-86a6-fe7f95f23add");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 23,
                column: "AzureId",
                value: "309494f8-13f7-46a3-ac3e-9b13f2f6334e");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 24,
                column: "AzureId",
                value: "367f204a-2bcd-4c34-be60-eb75cefd278f");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 25,
                column: "AzureId",
                value: "a7a94e68-f240-4d0f-a7c0-526b08252b00");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 26,
                column: "AzureId",
                value: "e37661c0-9c6a-426d-b26f-f8345d991ca8");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 27,
                column: "AzureId",
                value: "17fc6ff6-914a-4f52-9882-7ad99b63cec1");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 28,
                column: "AzureId",
                value: "fd70ae5e-7bf6-418f-ac23-bbc574b64a90");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 29,
                column: "AzureId",
                value: "25410d7c-b9bb-4029-94a5-75edcdf9b991");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 30,
                column: "AzureId",
                value: "b40d5fcc-7782-4dd1-ac08-54cd091ed8bc");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 31,
                column: "AzureId",
                value: "1f3285ac-d229-443b-b306-d8d3a36a1170");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 32,
                column: "AzureId",
                value: "f24e5efe-ac46-45ce-8b5a-d73006ef23e4");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 33,
                column: "AzureId",
                value: "b4171c8f-8ea0-4f67-ab81-8636f2dc2582");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 34,
                column: "AzureId",
                value: "c9b70a0c-ffd5-45bd-a6cc-c41722b17569");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 35,
                column: "AzureId",
                value: "876af6f1-2f5f-471a-84c1-5c3d13cf8573");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 36,
                column: "AzureId",
                value: "3e9cffb1-9f08-4306-8d13-321228ae54eb");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 37,
                column: "AzureId",
                value: "b055290c-db6a-4add-aa67-bca8cb66a5a7");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 38,
                column: "AzureId",
                value: "e1cd5d2b-29e8-4ae3-879d-864d3a83454f");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 39,
                column: "AzureId",
                value: "2b6987f0-6012-494d-a0ad-13fd21c2d206");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 40,
                column: "AzureId",
                value: "ef7d47e3-ef8b-4375-8cb8-cbeaaeadddae");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 41,
                column: "AzureId",
                value: "5d0cb4b0-98c2-4ed6-90f9-6776b25a98f9");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 42,
                column: "AzureId",
                value: "a8a5cd8b-e46c-4c35-990c-4907d08042de");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 43,
                column: "AzureId",
                value: "812c8c6f-1dad-4d3b-91b9-f75fe3e8d851");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 44,
                column: "AzureId",
                value: "230ad48e-c62c-4159-b650-d86b190bb3d7");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 45,
                column: "AzureId",
                value: "a4fca784-c8b1-4121-af52-71fc9a019663");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 46,
                column: "AzureId",
                value: "374e9bc5-3fdc-4fda-86dc-5752105fc10f");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 47,
                column: "AzureId",
                value: "43b9e732-1bb3-409e-a0dd-4e371d3e608b");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 48,
                column: "AzureId",
                value: "55894c7a-d073-4ff9-987c-1df9a5edeff0");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 49,
                column: "AzureId",
                value: "477ea16d-ac2f-4427-a310-e2058501ef59");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 50,
                column: "AzureId",
                value: "e3da9c18-e8a7-496c-bba5-3b5a360a4456");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 51,
                column: "AzureId",
                value: "d8c84ca0-91cd-46bc-a995-086c6dedcd6e");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 52,
                column: "AzureId",
                value: "da621904-54c8-4491-b2df-397cad32bcfa");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 53,
                column: "AzureId",
                value: "9c032dcf-eb03-4cd9-ad3b-ea0ab5106dc8");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 54,
                column: "AzureId",
                value: "3e99b0df-35b5-48d0-bfb2-c81954414165");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 55,
                column: "AzureId",
                value: "eaf17b12-a631-4d24-8e3e-6c93f3f73bee");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 56,
                column: "AzureId",
                value: "a8af4cbf-2dc3-4a30-b58b-c58f02be407c");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 57,
                column: "AzureId",
                value: "dfe355d9-ae41-4cc2-bf82-af7ab5061e1b");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 58,
                column: "AzureId",
                value: "0fe54118-5a21-4fe4-a85b-b32d79bb4d96");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 59,
                column: "AzureId",
                value: "2bd4e7ad-65c1-4696-9f60-11188a294a29");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 60,
                column: "AzureId",
                value: "2c9976ec-31a2-459f-8cc9-fa6e6189903f");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 61,
                column: "AzureId",
                value: "3a9cc6f3-9664-439d-934b-77443daf04b8");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 62,
                column: "AzureId",
                value: "de528727-ee5f-41ec-9e02-538310d95e30");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 63,
                column: "AzureId",
                value: "3346ca63-9917-4393-be25-78f135965ad3");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 64,
                column: "AzureId",
                value: "7d272db1-bd0e-40f1-8a62-34fbe775f99d");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 65,
                column: "AzureId",
                value: "9fb2e863-c109-4de0-8d5f-6d6f64894188");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 66,
                column: "AzureId",
                value: "1afc4e09-1563-4f72-b42c-0ec033224d41");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 67,
                column: "AzureId",
                value: "d60c29ef-f686-47b3-bdff-3277d4ddca40");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 68,
                column: "AzureId",
                value: "206fafa9-f73c-4a85-b18e-aae17d44b9c4");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 69,
                column: "AzureId",
                value: "a4a53555-5e9b-43b6-82e7-d3296880cb4c");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 70,
                column: "AzureId",
                value: "1f400107-4ac5-4737-8188-f0f59458df60");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 71,
                column: "AzureId",
                value: "7c79fc39-3826-4c16-81db-5bf87154310a");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 72,
                column: "AzureId",
                value: "753cd827-d496-4d3e-9005-f524089ed24e");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 73,
                column: "AzureId",
                value: "9feb2ac9-ef2d-4e60-a688-5de83a1d1b47");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 74,
                column: "AzureId",
                value: "4277faf0-cb49-45a4-a11a-b00e0bb358ff");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 75,
                column: "AzureId",
                value: "e97fce12-c3fb-4aea-90b3-7cd1524101ad");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 76,
                column: "AzureId",
                value: "bea3ed0c-a6e1-43f5-aff8-a0a839d55e6c");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 77,
                column: "AzureId",
                value: "ae243d7a-a534-48a8-bfaa-154ff76ea70f");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 78,
                column: "AzureId",
                value: "b261ce83-584e-4e11-b0a1-d8a1201a9957");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 79,
                column: "AzureId",
                value: "f5cbd924-842d-4ab8-ae75-c9106a4b2533");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 80,
                column: "AzureId",
                value: "00e8e3b4-eb9e-4f19-aa8f-4dd7ef5c4700");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 81,
                column: "AzureId",
                value: "e34f9bf5-9801-490c-801c-7b5ad70e8388");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 82,
                column: "AzureId",
                value: "eeb5e5b7-6adb-4e5b-b694-069ff1b3c1f9");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 83,
                column: "AzureId",
                value: "cd6009a8-be8e-49d0-9104-4fb51e2f1d34");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 84,
                column: "AzureId",
                value: "a70b39a4-4fe1-446b-b244-e2dfcfd69630");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 85,
                column: "AzureId",
                value: "d1b909a0-d1a9-4e70-b164-0a0a25ad57f7");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 86,
                column: "AzureId",
                value: "d1c05879-8793-4b33-9a19-6fe15a7739cc");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 87,
                column: "AzureId",
                value: "22894f2c-5f31-4fe2-acfd-d56b72df9fda");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 88,
                column: "AzureId",
                value: "9be3077d-8fb3-42f7-88fb-7d9a2beb380e");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 89,
                column: "AzureId",
                value: "c435b66a-fba0-4504-a18f-8fb44683a41f");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 90,
                column: "AzureId",
                value: "defe2e42-131b-4568-a268-93358ce3128b");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 91,
                column: "AzureId",
                value: "78cb475a-ec71-4e70-a186-a80300c3b557");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 92,
                column: "AzureId",
                value: "728f5a88-4b9c-4319-8794-9fc0799ddc66");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 93,
                column: "AzureId",
                value: "a8e0a27a-21f5-4861-b9a7-ef8e43fec6c7");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 94,
                column: "AzureId",
                value: "ffdd11ec-a2a0-45c1-b1d2-c4a6846fde8a");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 95,
                column: "AzureId",
                value: "03b4d94b-ac27-4294-930e-42d09b180539");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 96,
                column: "AzureId",
                value: "d3f74f3a-668e-4e19-8151-d271e932bb8e");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 97,
                column: "AzureId",
                value: "81e0137d-1aeb-41c4-8d4f-8d3da2a1feb8");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 98,
                column: "AzureId",
                value: "6d77cd14-acb6-4a25-b7a4-8848efb5e102");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 99,
                column: "AzureId",
                value: "efa068eb-0caa-476f-a68b-12db19f6645c");

            migrationBuilder.UpdateData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 100,
                column: "AzureId",
                value: "25098815-ba4e-4ff7-a0d4-fcb8ad48bbfe");

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 101,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 59, 14, 250, DateTimeKind.Local).AddTicks(7113), new DateTime(2022, 1, 28, 15, 39, 54, 41, DateTimeKind.Local).AddTicks(7950), "9999323b-b471-4e03-933d-1e007d2c3f88" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 102,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 38, 22, 669, DateTimeKind.Local).AddTicks(6138), new DateTime(2021, 7, 10, 14, 52, 55, 412, DateTimeKind.Local).AddTicks(5402), "b198976a-92b6-4cb6-bfc0-c532ea179148" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 103,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 3, 19, 75, DateTimeKind.Local).AddTicks(1359), new DateTime(2021, 10, 25, 11, 20, 36, 548, DateTimeKind.Local).AddTicks(8743), "09c9c4cd-6080-4966-ad1f-56cb1dfb16ef" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 104,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 15, 55, 904, DateTimeKind.Local).AddTicks(7710), new DateTime(2022, 1, 29, 4, 53, 56, 923, DateTimeKind.Local).AddTicks(3808), "cd5175a4-a266-4b49-bc98-e265dd38ba14" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 105,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 5, 0, 696, DateTimeKind.Local).AddTicks(2910), new DateTime(2022, 1, 10, 8, 20, 21, 538, DateTimeKind.Local).AddTicks(9712), "a7c553aa-3ba8-41a8-a9bc-aead9d512d86" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 106,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 30, 23, 410, DateTimeKind.Local).AddTicks(4142), new DateTime(2021, 5, 11, 15, 25, 42, 562, DateTimeKind.Local).AddTicks(5003), "bbe45745-0784-484b-a723-2392d266f148" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 107,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 46, 58, 453, DateTimeKind.Local).AddTicks(5970), new DateTime(2021, 4, 5, 10, 49, 34, 917, DateTimeKind.Local).AddTicks(9278), "b62cec84-b096-4ffb-9c39-95034cdcaa81" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 108,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 23, 31, 195, DateTimeKind.Local).AddTicks(834), new DateTime(2021, 8, 6, 22, 51, 22, 47, DateTimeKind.Local).AddTicks(8026), "ffb11d67-42da-45fe-907c-48d5fe9d2fca" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 109,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 59, 36, 908, DateTimeKind.Local).AddTicks(4116), new DateTime(2021, 6, 10, 22, 4, 6, 810, DateTimeKind.Local).AddTicks(7829), "4195e559-650e-479f-95d3-331ae4d55ca5" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 110,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 34, 24, 268, DateTimeKind.Local).AddTicks(3581), new DateTime(2021, 6, 5, 20, 30, 10, 528, DateTimeKind.Local).AddTicks(5720), "fc47ba41-514d-4ce5-9fb7-80ecf9ba7b05" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 111,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 46, 5, 942, DateTimeKind.Local).AddTicks(1004), new DateTime(2022, 1, 10, 11, 38, 19, 904, DateTimeKind.Local).AddTicks(1078), "8c0ff0ee-3ce4-453b-ad98-0944f5288347" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 112,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 28, 14, 596, DateTimeKind.Local).AddTicks(1659), new DateTime(2021, 11, 20, 16, 9, 2, 601, DateTimeKind.Local).AddTicks(1344), "8afa580e-cb43-4853-a888-5b1a73adddf4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 113,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 54, 30, 273, DateTimeKind.Local).AddTicks(2801), new DateTime(2021, 3, 11, 6, 26, 56, 390, DateTimeKind.Local).AddTicks(448), "645ba3a4-d451-4561-89e2-6cea5957b734" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 114,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 46, 15, 180, DateTimeKind.Local).AddTicks(9745), new DateTime(2021, 8, 18, 11, 45, 51, 265, DateTimeKind.Local).AddTicks(4228), "f0a128bd-8e8d-453e-bdc0-db894123786f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 115,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 19, 2, 127, DateTimeKind.Local).AddTicks(4092), new DateTime(2021, 9, 21, 16, 58, 19, 144, DateTimeKind.Local).AddTicks(2119), "db99b553-67da-4602-8c75-8d12a6b54360" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 116,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 31, 42, 975, DateTimeKind.Local).AddTicks(460), new DateTime(2021, 12, 17, 23, 31, 56, 738, DateTimeKind.Local).AddTicks(6202), "acb4a1d2-f129-4d22-9025-3695cb906074" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 117,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 49, 55, 565, DateTimeKind.Local).AddTicks(9474), new DateTime(2021, 5, 17, 12, 44, 30, 772, DateTimeKind.Local).AddTicks(6824), "f60296d7-8d44-455b-ab31-d237af5d80c4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 118,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 26, 44, 739, DateTimeKind.Local).AddTicks(9216), new DateTime(2021, 12, 29, 19, 34, 16, 145, DateTimeKind.Local).AddTicks(4844), "f0fbcb0c-db3b-4a60-b67e-fd5483c4d810" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 119,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 25, 41, 817, DateTimeKind.Local).AddTicks(7514), new DateTime(2021, 5, 3, 2, 14, 34, 523, DateTimeKind.Local).AddTicks(7338), "ada33200-b83f-4ecf-93cb-b8ee7de7b535" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 120,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 16, 25, 187, DateTimeKind.Local).AddTicks(6465), new DateTime(2021, 12, 9, 23, 9, 55, 150, DateTimeKind.Local).AddTicks(7049), "6ff72422-7f9e-4278-bde8-275dd7238c8a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 121,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 29, 45, 835, DateTimeKind.Local).AddTicks(1679), new DateTime(2021, 11, 23, 12, 52, 2, 798, DateTimeKind.Local).AddTicks(5377), "97b2c797-8a35-45aa-ac69-1ba18854df7f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 122,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 52, 20, 241, DateTimeKind.Local).AddTicks(1236), new DateTime(2021, 6, 12, 7, 43, 1, 838, DateTimeKind.Local).AddTicks(3833), "943f9a41-dd4d-425d-9550-2c9c82fa1ecf" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 123,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 41, 53, 750, DateTimeKind.Local).AddTicks(9635), new DateTime(2021, 7, 3, 7, 31, 57, 196, DateTimeKind.Local).AddTicks(2374), "83facfc4-5620-4416-a3d4-cb48893a9452" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 124,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 2, 15, 445, DateTimeKind.Local).AddTicks(4724), new DateTime(2021, 12, 16, 14, 20, 45, 406, DateTimeKind.Local).AddTicks(8111), "810821d8-0710-4e9f-b856-48d18a48bed2" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 45, 13, 557, DateTimeKind.Local).AddTicks(4326), new DateTime(2021, 10, 1, 9, 4, 34, 202, DateTimeKind.Local).AddTicks(4936), "178e4828-3117-4ad4-af4f-69b4c61212f9" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 126,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 55, 43, 201, DateTimeKind.Local).AddTicks(991), new DateTime(2021, 12, 2, 13, 35, 9, 850, DateTimeKind.Local).AddTicks(362), "9c3828d6-b323-45de-8d29-bc3be9f8959b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 127,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 45, 38, 218, DateTimeKind.Local).AddTicks(3179), new DateTime(2021, 2, 28, 9, 57, 33, 24, DateTimeKind.Local).AddTicks(3096), "56e58439-99a3-4c48-8c7e-ed7426ab7b26" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 128,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 2, 54, 196, DateTimeKind.Local).AddTicks(4835), new DateTime(2021, 3, 2, 23, 35, 40, 659, DateTimeKind.Local).AddTicks(2456), "a09eb55f-89ab-49b2-8bbf-32c0ec695f73" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 129,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 20, 59, 490, DateTimeKind.Local).AddTicks(9499), new DateTime(2021, 2, 22, 17, 51, 12, 956, DateTimeKind.Local).AddTicks(5045), "751d0f6a-0a0d-4b0b-b32f-d2899690ed6a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 130,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 53, 15, 619, DateTimeKind.Local).AddTicks(3261), new DateTime(2021, 5, 14, 22, 2, 35, 134, DateTimeKind.Local).AddTicks(2017), "66fd571d-f55c-48c6-992f-c1b2036785cc" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 131,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 53, 10, 832, DateTimeKind.Local).AddTicks(4228), new DateTime(2022, 2, 3, 4, 18, 25, 373, DateTimeKind.Local).AddTicks(7337), "9a25eea2-9eaa-4e72-8638-cf860f6a8ab6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 132,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 20, 52, 248, DateTimeKind.Local).AddTicks(2476), new DateTime(2021, 10, 1, 5, 39, 20, 194, DateTimeKind.Local).AddTicks(7879), "2741e099-626e-425e-a579-1d44c5eecbbb" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 133,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 5, 30, 885, DateTimeKind.Local).AddTicks(544), new DateTime(2022, 2, 6, 1, 39, 45, 122, DateTimeKind.Local).AddTicks(7007), "f2c100f3-a75c-443e-a12e-bce28af98f5f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 134,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 26, 18, 25, DateTimeKind.Local).AddTicks(8419), new DateTime(2021, 11, 26, 8, 46, 31, 89, DateTimeKind.Local).AddTicks(6422), "2a04de3c-96be-4581-96f8-f8d0b981c799" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 135,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 15, 12, 503, DateTimeKind.Local).AddTicks(2060), new DateTime(2021, 10, 21, 17, 33, 32, 287, DateTimeKind.Local).AddTicks(4036), "986afa30-7fda-4846-af80-8c2b2325b224" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 136,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 48, 20, 912, DateTimeKind.Local).AddTicks(1195), new DateTime(2021, 4, 16, 10, 39, 0, 600, DateTimeKind.Local).AddTicks(5854), "b9299453-8eaf-404c-b44f-b50fb0825795" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 137,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 33, 55, 658, DateTimeKind.Local).AddTicks(7051), new DateTime(2021, 9, 21, 14, 54, 23, 0, DateTimeKind.Local).AddTicks(6047), "d529d3eb-1da7-4f07-9015-3c5de674a9a9" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 138,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 47, 34, 779, DateTimeKind.Local).AddTicks(809), new DateTime(2022, 1, 20, 7, 17, 13, 450, DateTimeKind.Local).AddTicks(7605), "8559cc52-edef-4088-bf40-f15932f1c96b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 139,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 40, 8, 548, DateTimeKind.Local).AddTicks(932), new DateTime(2021, 4, 17, 5, 21, 44, 874, DateTimeKind.Local).AddTicks(3178), "efb3c4a4-3ab6-420a-928f-050771d2b1ba" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 140,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 28, 35, 533, DateTimeKind.Local).AddTicks(5292), new DateTime(2021, 2, 18, 6, 55, 5, 737, DateTimeKind.Local).AddTicks(462), "788aa221-11e0-4a78-80d8-4df75f5e4009" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 141,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 9, 34, 673, DateTimeKind.Local).AddTicks(7718), new DateTime(2021, 12, 15, 12, 56, 30, 360, DateTimeKind.Local).AddTicks(7572), "bd654b4c-d3b7-490f-8b57-6eef41f7e4d6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 142,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 8, 5, 726, DateTimeKind.Local).AddTicks(7281), new DateTime(2021, 6, 26, 12, 31, 55, 238, DateTimeKind.Local).AddTicks(4527), "6b3c8a18-72ba-468c-a7e8-f4048a240782" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 143,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 33, 44, 740, DateTimeKind.Local).AddTicks(1637), new DateTime(2021, 4, 26, 10, 10, 5, 421, DateTimeKind.Local).AddTicks(9609), "02b02c2d-9c52-4f31-8d33-88ecdf375ff1" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 144,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 47, 30, 780, DateTimeKind.Local).AddTicks(2641), new DateTime(2021, 3, 10, 11, 1, 6, 743, DateTimeKind.Local).AddTicks(5795), "5ce2129f-be4b-49ac-be70-9986c37fff3f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 145,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 6, 15, 300, DateTimeKind.Local).AddTicks(7978), new DateTime(2021, 8, 9, 18, 7, 48, 225, DateTimeKind.Local).AddTicks(6454), "785a7316-810c-4a85-8ae4-20bafdc848e3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 146,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 27, 55, 547, DateTimeKind.Local).AddTicks(1487), new DateTime(2021, 10, 21, 18, 30, 5, 855, DateTimeKind.Local).AddTicks(9266), "3ebad479-0304-4407-b6c9-5627b5ce1cc5" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 147,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 29, 37, 548, DateTimeKind.Local).AddTicks(644), new DateTime(2021, 6, 30, 15, 56, 28, 654, DateTimeKind.Local).AddTicks(5978), "f21a90c0-0121-451d-a2e7-a0ce2fe1b889" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 148,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 26, 45, 197, DateTimeKind.Local).AddTicks(5857), new DateTime(2021, 4, 21, 7, 17, 1, 610, DateTimeKind.Local).AddTicks(9346), "8419b498-9366-4d94-8874-fec5be9f4315" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 149,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 13, 45, 147, DateTimeKind.Local).AddTicks(6898), new DateTime(2021, 10, 30, 22, 46, 46, 459, DateTimeKind.Local).AddTicks(3838), "e81ea545-df4c-42b6-95d4-33baf0ea45b9" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 150,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 14, 37, 40, DateTimeKind.Local).AddTicks(2154), new DateTime(2021, 5, 31, 16, 45, 20, 978, DateTimeKind.Local).AddTicks(5763), "32cf2236-f7f3-419c-8944-0436eb38c2ba" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 151,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 32, 57, 325, DateTimeKind.Local).AddTicks(9818), new DateTime(2021, 8, 18, 13, 23, 5, 474, DateTimeKind.Local).AddTicks(6600), "d5313f0c-e529-4adc-a540-917b0cc5a637" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 152,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 27, 47, 942, DateTimeKind.Local).AddTicks(6520), new DateTime(2021, 6, 17, 0, 48, 33, 225, DateTimeKind.Local).AddTicks(5729), "d5e50e6d-d69d-4b93-8c62-7cbd13b39c28" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 153,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 46, 53, 519, DateTimeKind.Local).AddTicks(1047), new DateTime(2021, 10, 14, 0, 42, 30, 488, DateTimeKind.Local).AddTicks(222), "ca6ca90b-7bfb-4b6d-8caf-d97f6b39338f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 154,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 27, 8, 403, DateTimeKind.Local).AddTicks(6932), new DateTime(2021, 8, 29, 12, 40, 44, 862, DateTimeKind.Local).AddTicks(4362), "e40b1738-8ad5-4d6b-a90a-7afe4be4e80c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 155,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 42, 50, 688, DateTimeKind.Local).AddTicks(9869), new DateTime(2021, 5, 9, 5, 38, 33, 959, DateTimeKind.Local).AddTicks(255), "006e89f0-fab2-4eff-883d-031df3758ccb" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 156,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 6, 38, 24, DateTimeKind.Local).AddTicks(7863), new DateTime(2021, 12, 16, 11, 0, 50, 59, DateTimeKind.Local).AddTicks(7584), "734a7d0b-ba3e-4a02-bc30-fdd3fd69c580" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 157,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 34, 23, 281, DateTimeKind.Local).AddTicks(8979), new DateTime(2021, 10, 7, 16, 20, 45, 605, DateTimeKind.Local).AddTicks(8941), "0e5317ef-38cd-443a-86d2-0358c98285d4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 158,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 6, 27, 978, DateTimeKind.Local).AddTicks(2781), new DateTime(2021, 11, 18, 12, 28, 35, 335, DateTimeKind.Local).AddTicks(5710), "57589b9f-a131-4747-9768-bfae8a9e213f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 159,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 7, 10, 403, DateTimeKind.Local).AddTicks(9748), new DateTime(2021, 11, 28, 16, 32, 11, 991, DateTimeKind.Local).AddTicks(6464), "aa9ee6fb-ba72-4126-8ef9-887632158e19" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 160,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 40, 48, 757, DateTimeKind.Local).AddTicks(7611), new DateTime(2021, 9, 5, 17, 56, 19, 929, DateTimeKind.Local).AddTicks(2510), "b81797bc-63aa-41d2-88b6-ab7b1fe4c66c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 161,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 16, 59, 773, DateTimeKind.Local).AddTicks(7166), new DateTime(2021, 3, 8, 1, 11, 24, 932, DateTimeKind.Local).AddTicks(7659), "89616613-15aa-4863-ba95-b6ed54672137" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 162,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 16, 2, 116, DateTimeKind.Local).AddTicks(6696), new DateTime(2021, 11, 28, 21, 31, 24, 725, DateTimeKind.Local).AddTicks(9598), "9d61d376-77a6-45bb-9d45-150db209a5cf" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 163,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 27, 33, 745, DateTimeKind.Local).AddTicks(157), new DateTime(2021, 3, 26, 21, 0, 4, 883, DateTimeKind.Local).AddTicks(6402), "54af4d02-8293-4800-8172-71332cad8337" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 164,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 30, 26, 361, DateTimeKind.Local).AddTicks(4086), new DateTime(2021, 12, 7, 2, 16, 30, 104, DateTimeKind.Local).AddTicks(6280), "ea77c03f-7453-4be2-904c-bf3b339d63e3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 16, 40, 696, DateTimeKind.Local).AddTicks(1644), new DateTime(2021, 12, 22, 9, 53, 30, 809, DateTimeKind.Local).AddTicks(147), "ba661f37-d07a-4822-9671-a7d2dffeda24" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 166,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 58, 43, 693, DateTimeKind.Local).AddTicks(1188), new DateTime(2021, 9, 22, 17, 4, 35, 350, DateTimeKind.Local).AddTicks(8470), "dc0fd59c-c34c-46a0-bfe2-f37935f73df5" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 167,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 51, 29, 44, DateTimeKind.Local).AddTicks(1277), new DateTime(2021, 5, 1, 6, 35, 15, 158, DateTimeKind.Local).AddTicks(5489), "8c62ce81-0edf-4e8a-951b-144cf2831807" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 168,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 8, 9, 907, DateTimeKind.Local).AddTicks(3756), new DateTime(2021, 11, 6, 4, 30, 59, 522, DateTimeKind.Local).AddTicks(2547), "093b2be6-5501-425c-90ec-11ea7f101cfe" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 169,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 8, 58, 174, DateTimeKind.Local).AddTicks(5006), new DateTime(2021, 12, 1, 6, 27, 47, 513, DateTimeKind.Local).AddTicks(4835), "1ceca2a3-b814-45e7-8192-d9d206ec6aaf" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 170,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 58, 41, 120, DateTimeKind.Local).AddTicks(8547), new DateTime(2021, 7, 21, 15, 55, 31, 467, DateTimeKind.Local).AddTicks(8512), "8304b9ab-b2ba-4488-b489-84c4ce7dc1d3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 171,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 28, 46, 404, DateTimeKind.Local).AddTicks(179), new DateTime(2021, 11, 21, 20, 12, 39, 988, DateTimeKind.Local).AddTicks(7283), "9a1f4e1f-047f-4578-ae35-1a975dd20ed4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 172,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 24, 49, 366, DateTimeKind.Local).AddTicks(7232), new DateTime(2021, 7, 6, 18, 50, 25, 842, DateTimeKind.Local).AddTicks(9250), "1aa9724b-f501-4fad-9372-122f21feffa7" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 173,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 17, 19, 273, DateTimeKind.Local).AddTicks(6011), new DateTime(2021, 10, 4, 21, 18, 38, 920, DateTimeKind.Local).AddTicks(4748), "83e72e0d-5cf8-4cae-bb78-bb4728f0e2e1" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 174,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 43, 53, 135, DateTimeKind.Local).AddTicks(3884), new DateTime(2021, 4, 25, 13, 1, 57, 184, DateTimeKind.Local).AddTicks(9147), "3e8f3d4b-6cc9-48ca-95ae-0b93f1a3527a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 175,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 51, 41, 677, DateTimeKind.Local).AddTicks(3430), new DateTime(2021, 11, 8, 0, 33, 9, 538, DateTimeKind.Local).AddTicks(5377), "44982b6d-80a0-4683-9c3f-1f076ea0f20c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 176,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 42, 10, 168, DateTimeKind.Local).AddTicks(4673), new DateTime(2022, 1, 2, 6, 36, 14, 182, DateTimeKind.Local).AddTicks(2697), "0698db3f-63f6-42bb-86d7-ea7df060f73d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 177,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 1, 2, 697, DateTimeKind.Local).AddTicks(3727), new DateTime(2021, 2, 17, 18, 35, 30, 375, DateTimeKind.Local).AddTicks(2649), "afb832bd-ca29-4bfe-b89e-9b956c297913" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 178,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 21, 21, 283, DateTimeKind.Local).AddTicks(9997), new DateTime(2021, 5, 22, 21, 21, 4, 517, DateTimeKind.Local).AddTicks(8729), "3591ae52-ccb6-4670-9c93-77b463faee7f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 179,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 42, 48, 694, DateTimeKind.Local).AddTicks(1456), new DateTime(2022, 1, 9, 7, 26, 18, 740, DateTimeKind.Local).AddTicks(3209), "4946a486-489c-4e83-8e0b-10c01f2fd456" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 180,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 56, 1, 541, DateTimeKind.Local).AddTicks(4317), new DateTime(2021, 9, 1, 3, 36, 10, 865, DateTimeKind.Local).AddTicks(3553), "96613de9-3d7b-46c3-85ec-c969b2b492cc" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 181,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 46, 51, 325, DateTimeKind.Local).AddTicks(7170), new DateTime(2021, 9, 1, 22, 54, 45, 755, DateTimeKind.Local).AddTicks(5499), "e61f42da-42fb-4f08-abf2-6db096712c5e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 182,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 3, 43, 983, DateTimeKind.Local).AddTicks(5836), new DateTime(2021, 3, 31, 15, 45, 15, 243, DateTimeKind.Local).AddTicks(9131), "e0366ba5-f7e0-438c-acbd-fcd8e4ab4a41" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 183,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 45, 9, 893, DateTimeKind.Local).AddTicks(5504), new DateTime(2021, 11, 8, 23, 21, 57, 516, DateTimeKind.Local).AddTicks(8429), "41f677f1-3b95-4236-bf8f-a0e4e8b53a91" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 184,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 7, 7, 342, DateTimeKind.Local).AddTicks(3550), new DateTime(2021, 3, 25, 3, 26, 56, 953, DateTimeKind.Local).AddTicks(1007), "2179649a-92fd-4a4f-92e0-69291badaa17" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 6, 11, 509, DateTimeKind.Local).AddTicks(6446), new DateTime(2021, 10, 27, 22, 34, 31, 782, DateTimeKind.Local).AddTicks(4517), "6aa49683-b015-4405-b015-c9535ae18918" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 186,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 46, 3, 276, DateTimeKind.Local).AddTicks(1003), new DateTime(2021, 3, 7, 10, 8, 1, 875, DateTimeKind.Local).AddTicks(738), "76af0547-a413-4cd5-af36-e9e02d476e77" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 187,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 32, 43, 678, DateTimeKind.Local).AddTicks(9698), new DateTime(2022, 1, 23, 21, 37, 36, 587, DateTimeKind.Local).AddTicks(8349), "c881666e-1776-4040-928b-48143ebe01ec" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 188,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 10, 48, 204, DateTimeKind.Local).AddTicks(6976), new DateTime(2022, 1, 17, 11, 38, 25, 319, DateTimeKind.Local).AddTicks(1004), "2cd9f600-d0ec-4cb8-9208-e83bfee363b2" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 189,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 14, 3, 775, DateTimeKind.Local).AddTicks(1341), new DateTime(2021, 12, 31, 20, 3, 44, 154, DateTimeKind.Local).AddTicks(9209), "27f85f3f-53d9-4439-8968-0ed76bf85db0" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 190,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 12, 31, 124, DateTimeKind.Local).AddTicks(7421), new DateTime(2021, 3, 8, 10, 18, 55, 218, DateTimeKind.Local).AddTicks(4038), "62bef3ce-8eab-4a37-8f33-32e7612fd0a0" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 191,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 1, 35, 676, DateTimeKind.Local).AddTicks(8283), new DateTime(2022, 1, 17, 2, 39, 25, 482, DateTimeKind.Local).AddTicks(709), "e095e5a3-a9ef-4450-a47a-54891d67d50a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 192,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 48, 58, 659, DateTimeKind.Local).AddTicks(2180), new DateTime(2021, 12, 23, 4, 50, 28, 102, DateTimeKind.Local).AddTicks(5885), "eeffb36c-b97e-48b5-940c-8adac0af62f0" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 193,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 41, 27, 569, DateTimeKind.Local).AddTicks(830), new DateTime(2021, 2, 9, 8, 9, 20, 514, DateTimeKind.Local).AddTicks(8776), "54ceaf50-d954-4b9a-b458-3bd1967c0bfe" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 194,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 39, 4, 261, DateTimeKind.Local).AddTicks(9427), new DateTime(2021, 10, 5, 9, 12, 53, 879, DateTimeKind.Local).AddTicks(693), "9193fb5e-475a-46ac-8747-031d38607004" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 195,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 55, 30, 230, DateTimeKind.Local).AddTicks(5487), new DateTime(2021, 7, 27, 23, 16, 50, 755, DateTimeKind.Local).AddTicks(5940), "6b6ea3a7-14cb-4124-a8aa-31a49bf1624a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 196,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 45, 0, 267, DateTimeKind.Local).AddTicks(459), new DateTime(2021, 3, 10, 7, 33, 57, 309, DateTimeKind.Local).AddTicks(6625), "41e5b93e-0312-46c1-bfeb-bf84845ee359" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 197,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 12, 19, 884, DateTimeKind.Local).AddTicks(9767), new DateTime(2021, 10, 8, 11, 25, 43, 3, DateTimeKind.Local).AddTicks(188), "4f09bd44-3ce9-428c-99dd-06badd90c5f1" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 198,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 25, 2, 473, DateTimeKind.Local).AddTicks(4265), new DateTime(2022, 1, 4, 23, 21, 46, 185, DateTimeKind.Local).AddTicks(670), "c470bef6-ae66-4d81-94d3-2451b67f4bb8" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 199,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 26, 4, 903, DateTimeKind.Local).AddTicks(8296), new DateTime(2021, 4, 15, 3, 50, 29, 800, DateTimeKind.Local).AddTicks(8163), "131f0b08-36cf-4d15-b0d2-31d51b337eb1" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 200,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 46, 32, 709, DateTimeKind.Local).AddTicks(1068), new DateTime(2021, 4, 4, 2, 2, 16, 584, DateTimeKind.Local).AddTicks(8061), "b0509e82-9e84-4321-b195-e3e89db5b6e8" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 201,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 1, 53, 751, DateTimeKind.Local).AddTicks(771), new DateTime(2021, 10, 9, 4, 26, 25, 839, DateTimeKind.Local).AddTicks(5103), "a2ff6df8-8789-4999-94a2-447a461ef12c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 202,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 9, 32, 358, DateTimeKind.Local).AddTicks(9043), new DateTime(2021, 8, 14, 7, 50, 21, 80, DateTimeKind.Local).AddTicks(1114), "259ad103-a20c-4d76-9c90-90dbabfe5b12" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 203,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 0, 27, 4, DateTimeKind.Local).AddTicks(7742), new DateTime(2021, 7, 8, 9, 32, 17, 189, DateTimeKind.Local).AddTicks(56), "f3da0938-5d5b-4ca4-8360-086702ebb8a2" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 204,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 16, 33, 118, DateTimeKind.Local).AddTicks(9424), new DateTime(2021, 8, 23, 4, 44, 7, 580, DateTimeKind.Local).AddTicks(4961), "d3152533-4c14-4bfd-a39f-d4b128be8e47" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 205,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 57, 1, 930, DateTimeKind.Local).AddTicks(7119), new DateTime(2021, 7, 31, 16, 26, 44, 441, DateTimeKind.Local).AddTicks(7692), "7ff42f82-f577-4e72-b67f-316827aeb1f8" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 206,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 6, 55, 641, DateTimeKind.Local).AddTicks(8059), new DateTime(2021, 12, 5, 7, 16, 44, 482, DateTimeKind.Local).AddTicks(4915), "4ee8968b-4199-4eb3-a1f1-2ad933ec85d8" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 207,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 6, 15, 702, DateTimeKind.Local).AddTicks(1688), new DateTime(2021, 10, 10, 12, 0, 43, 555, DateTimeKind.Local).AddTicks(2002), "a39220fa-965d-4a61-b8f9-b1086e68b46f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 208,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 18, 0, 74, DateTimeKind.Local).AddTicks(9530), new DateTime(2021, 4, 1, 0, 31, 6, 987, DateTimeKind.Local).AddTicks(7856), "be7782fb-372f-4be9-b4a5-0862f29c8872" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 209,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 55, 20, 289, DateTimeKind.Local).AddTicks(4041), new DateTime(2021, 11, 4, 6, 10, 12, 165, DateTimeKind.Local).AddTicks(4490), "c29a82da-ad49-47e1-b0b3-524b0536a971" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 210,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 51, 17, 71, DateTimeKind.Local).AddTicks(8877), new DateTime(2021, 7, 29, 6, 45, 47, 957, DateTimeKind.Local).AddTicks(4953), "af3e4e34-38c7-4d21-97e5-344b3f9413ca" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 211,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 43, 1, 277, DateTimeKind.Local).AddTicks(5367), new DateTime(2021, 12, 29, 1, 31, 57, 574, DateTimeKind.Local).AddTicks(2611), "f9582401-1747-404d-8cf9-1e93415f75ff" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 212,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 39, 48, 251, DateTimeKind.Local).AddTicks(8786), new DateTime(2021, 4, 5, 9, 45, 43, 260, DateTimeKind.Local).AddTicks(6314), "9a4677bb-bf60-401a-949c-132d1d5947b4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 213,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 42, 36, 860, DateTimeKind.Local).AddTicks(7654), new DateTime(2021, 5, 17, 16, 19, 42, 43, DateTimeKind.Local).AddTicks(4392), "d2980bc1-9e73-4be0-b7c3-db5a30b24261" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 214,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 14, 53, 402, DateTimeKind.Local).AddTicks(9881), new DateTime(2021, 10, 20, 23, 1, 9, 619, DateTimeKind.Local).AddTicks(812), "545bba13-3c27-40ad-b68f-997f1c3ce96b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 215,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 9, 2, 564, DateTimeKind.Local).AddTicks(6478), new DateTime(2021, 7, 5, 18, 56, 4, 788, DateTimeKind.Local).AddTicks(1996), "69583091-4a54-4036-a117-f47b641bf77c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 216,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 59, 4, 514, DateTimeKind.Local).AddTicks(3316), new DateTime(2021, 5, 31, 0, 1, 14, 124, DateTimeKind.Local).AddTicks(1945), "679ebdf3-6ab3-4e56-b26f-75265d8e867f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 217,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 30, 52, 959, DateTimeKind.Local).AddTicks(2540), new DateTime(2021, 12, 21, 1, 45, 0, 67, DateTimeKind.Local).AddTicks(2607), "24c1f35a-a021-4e1f-8bb4-e9c55729077d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 218,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 9, 2, 895, DateTimeKind.Local).AddTicks(3250), new DateTime(2021, 9, 27, 10, 59, 33, 737, DateTimeKind.Local).AddTicks(8754), "5baaf313-5d7c-4882-8c36-bc9be5bf6ac4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 219,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 7, 11, 821, DateTimeKind.Local).AddTicks(9667), new DateTime(2021, 4, 20, 12, 21, 36, 924, DateTimeKind.Local).AddTicks(4913), "8832f0ad-c877-42ef-b81e-9defe69f3089" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 220,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 27, 36, 246, DateTimeKind.Local).AddTicks(5640), new DateTime(2021, 2, 15, 4, 43, 16, 615, DateTimeKind.Local).AddTicks(9841), "8e69cbee-fd3f-4999-ba01-6e9d8ba64392" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 221,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 14, 9, 230, DateTimeKind.Local).AddTicks(3612), new DateTime(2021, 10, 6, 21, 11, 52, 429, DateTimeKind.Local).AddTicks(5975), "8c40097e-cce9-4d78-8b55-c4ab8c36c89b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 222,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 54, 56, 289, DateTimeKind.Local).AddTicks(236), new DateTime(2021, 10, 28, 23, 38, 53, 156, DateTimeKind.Local).AddTicks(5985), "7f12b4b1-008e-4e7a-ae1b-5292e1c2eb4b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 223,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 41, 19, 622, DateTimeKind.Local).AddTicks(761), new DateTime(2021, 6, 1, 20, 7, 5, 209, DateTimeKind.Local).AddTicks(6260), "fc760487-62f4-4407-b3c1-f17bcccb7833" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 224,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 36, 57, 804, DateTimeKind.Local).AddTicks(7617), new DateTime(2021, 9, 10, 19, 50, 6, 755, DateTimeKind.Local).AddTicks(3172), "6d5b3721-34c7-4aa5-a875-17165736c999" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 225,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 7, 5, 41, DateTimeKind.Local).AddTicks(45), new DateTime(2021, 9, 30, 17, 2, 28, 467, DateTimeKind.Local).AddTicks(1622), "4cab7762-a28b-49c5-9916-86f23d227367" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 226,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 24, 59, 113, DateTimeKind.Local).AddTicks(7622), new DateTime(2021, 8, 3, 12, 31, 41, 448, DateTimeKind.Local).AddTicks(5793), "b0e71f1b-4c7b-4495-bb66-a3d4e3ddecb5" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 227,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 1, 29, 201, DateTimeKind.Local).AddTicks(7353), new DateTime(2021, 11, 1, 2, 25, 58, 194, DateTimeKind.Local).AddTicks(7812), "67d7e022-10ce-43eb-be2b-11e1fb4c5e9c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 228,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 40, 19, 888, DateTimeKind.Local).AddTicks(3740), new DateTime(2021, 2, 19, 14, 34, 26, 373, DateTimeKind.Local).AddTicks(6309), "1b59e96d-5d2a-4867-8802-0389fe001c3f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 229,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 48, 26, 367, DateTimeKind.Local).AddTicks(2257), new DateTime(2022, 1, 21, 8, 36, 32, 235, DateTimeKind.Local).AddTicks(6875), "d03ed702-c63e-4e83-b8bd-d3ad5d80ce85" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 230,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 44, 20, 446, DateTimeKind.Local).AddTicks(1110), new DateTime(2021, 6, 9, 9, 13, 39, 143, DateTimeKind.Local).AddTicks(7890), "11a10848-82ac-4b0c-b235-4844023f7af3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 231,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 59, 13, 997, DateTimeKind.Local).AddTicks(2037), new DateTime(2021, 11, 21, 15, 47, 25, 657, DateTimeKind.Local).AddTicks(8696), "10e22ae4-cd60-4b48-88c3-cda7d9fc1a3e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 232,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 4, 23, 139, DateTimeKind.Local).AddTicks(3943), new DateTime(2021, 3, 30, 7, 7, 59, 621, DateTimeKind.Local).AddTicks(8565), "50d8b14e-80a1-42af-88ff-be67cdfb91eb" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 233,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 35, 16, 202, DateTimeKind.Local).AddTicks(6340), new DateTime(2021, 11, 18, 16, 58, 28, 572, DateTimeKind.Local).AddTicks(8078), "9f93f4d0-29f6-4ac3-b564-d2adc174da04" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 234,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 30, 6, 918, DateTimeKind.Local).AddTicks(8100), new DateTime(2021, 4, 28, 5, 15, 41, 610, DateTimeKind.Local).AddTicks(8698), "35049933-4729-4e29-b22c-7db110d5283f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 235,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 35, 38, 434, DateTimeKind.Local).AddTicks(5746), new DateTime(2021, 12, 27, 2, 28, 59, 279, DateTimeKind.Local).AddTicks(3159), "797ff6b2-a765-4dff-9a46-9e91d80f6558" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 236,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 8, 22, 406, DateTimeKind.Local).AddTicks(6745), new DateTime(2021, 6, 8, 13, 39, 12, 984, DateTimeKind.Local).AddTicks(6293), "a5c8b973-d62c-4354-a7e8-29a21a735d5c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 237,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 44, 46, 486, DateTimeKind.Local).AddTicks(3886), new DateTime(2021, 4, 30, 3, 5, 14, 211, DateTimeKind.Local).AddTicks(5155), "7329692a-b017-4c87-b37b-9a748fbe1abf" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 238,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 3, 58, 486, DateTimeKind.Local).AddTicks(5750), new DateTime(2021, 7, 26, 13, 32, 42, 268, DateTimeKind.Local).AddTicks(1746), "1efef9c5-0527-49ca-a865-2f382a28cdef" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 239,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 28, 38, 985, DateTimeKind.Local).AddTicks(552), new DateTime(2021, 7, 20, 10, 8, 6, 925, DateTimeKind.Local).AddTicks(3637), "e8e4d2e4-401b-4661-ad46-8a3a01d16317" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 240,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 50, 19, 243, DateTimeKind.Local).AddTicks(1748), new DateTime(2021, 8, 31, 16, 29, 28, 486, DateTimeKind.Local).AddTicks(37), "1fbb6f8e-2e27-4a07-8094-56a5da91c2cf" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 241,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 44, 12, 451, DateTimeKind.Local).AddTicks(4343), new DateTime(2021, 11, 28, 0, 9, 3, 994, DateTimeKind.Local).AddTicks(7424), "89b6450f-a6f7-417f-9311-64d1d1337301" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 242,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 4, 41, 246, DateTimeKind.Local).AddTicks(6313), new DateTime(2021, 8, 6, 19, 38, 9, 798, DateTimeKind.Local).AddTicks(9590), "23adffe3-8613-4180-bdc5-b532b28ca903" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 243,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 7, 49, 281, DateTimeKind.Local).AddTicks(1378), new DateTime(2021, 7, 24, 14, 54, 15, 823, DateTimeKind.Local).AddTicks(1358), "23dadb70-db4c-43de-9774-0107e907cda2" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 244,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 42, 43, 419, DateTimeKind.Local).AddTicks(2593), new DateTime(2021, 6, 21, 10, 3, 35, 449, DateTimeKind.Local).AddTicks(3591), "c561ba84-1aa7-49aa-a220-9a894035acef" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 245,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 54, 40, 485, DateTimeKind.Local).AddTicks(8523), new DateTime(2021, 11, 1, 10, 28, 19, 57, DateTimeKind.Local).AddTicks(3371), "cfc8c876-287a-4670-bc0f-685b436eb19a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 246,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 50, 13, 620, DateTimeKind.Local).AddTicks(3086), new DateTime(2021, 7, 18, 17, 15, 53, 266, DateTimeKind.Local).AddTicks(5179), "735eaf55-64e2-4603-9765-b17f7ab9f0cf" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 247,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 3, 1, 842, DateTimeKind.Local).AddTicks(974), new DateTime(2021, 4, 27, 2, 16, 0, 65, DateTimeKind.Local).AddTicks(9575), "8e0e60bb-d67c-4953-bb74-909e2d08818d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 248,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 49, 57, 586, DateTimeKind.Local).AddTicks(5176), new DateTime(2021, 3, 28, 5, 27, 28, 131, DateTimeKind.Local).AddTicks(307), "7599e358-c747-4e29-a346-984ed10531da" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 249,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 6, 11, 534, DateTimeKind.Local).AddTicks(1610), new DateTime(2021, 5, 26, 22, 42, 54, 89, DateTimeKind.Local).AddTicks(3779), "8ff7d3ca-ecf3-4b49-b713-80940e8981d7" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 250,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 1, 7, 760, DateTimeKind.Local).AddTicks(9878), new DateTime(2021, 5, 24, 14, 54, 8, 340, DateTimeKind.Local).AddTicks(5437), "81991c9f-02fb-4101-9efd-0bea3b6f0484" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 251,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 45, 36, 522, DateTimeKind.Local).AddTicks(9138), new DateTime(2021, 2, 8, 23, 49, 48, 891, DateTimeKind.Local).AddTicks(9263), "db8d2977-14b3-435e-8423-0f8bc6ac4118" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 252,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 51, 26, 91, DateTimeKind.Local).AddTicks(8702), new DateTime(2021, 4, 9, 18, 8, 7, 539, DateTimeKind.Local).AddTicks(1121), "f77a5cda-84fa-4424-9545-02cd67432d22" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 253,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 31, 57, 930, DateTimeKind.Local).AddTicks(8223), new DateTime(2021, 4, 17, 14, 33, 40, 993, DateTimeKind.Local).AddTicks(4767), "0564d4cd-4f1e-4735-b488-0af6e58f3565" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 254,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 51, 0, 224, DateTimeKind.Local).AddTicks(1683), new DateTime(2021, 4, 24, 18, 29, 4, 517, DateTimeKind.Local).AddTicks(646), "504d3887-1c7d-42a7-b9eb-700ff1f5e88b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 255,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 14, 30, 238, DateTimeKind.Local).AddTicks(5126), new DateTime(2021, 8, 13, 6, 52, 3, 52, DateTimeKind.Local).AddTicks(735), "434a13f6-b2ac-4e12-a283-c5fb094ccc1b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 256,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 49, 29, 109, DateTimeKind.Local).AddTicks(8523), new DateTime(2021, 2, 21, 10, 34, 30, 63, DateTimeKind.Local).AddTicks(3032), "6ebdaad6-3c0c-4b05-97e5-ee440a7aae87" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 257,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 48, 19, 124, DateTimeKind.Local).AddTicks(6322), new DateTime(2021, 8, 16, 8, 51, 58, 242, DateTimeKind.Local).AddTicks(1268), "085364a5-166f-474f-8d4e-da16de3ce0ee" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 258,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 48, 45, 862, DateTimeKind.Local).AddTicks(3680), new DateTime(2021, 3, 28, 6, 38, 38, 839, DateTimeKind.Local).AddTicks(7144), "bb2dc0a3-e98e-4a1b-ab3c-88d5e99a1e9c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 259,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 48, 23, 819, DateTimeKind.Local).AddTicks(2062), new DateTime(2021, 7, 25, 16, 27, 26, 461, DateTimeKind.Local).AddTicks(8413), "1037e3c2-8d1c-4eba-aa6e-107620a25c66" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 260,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 12, 59, 606, DateTimeKind.Local).AddTicks(7381), new DateTime(2021, 2, 17, 3, 19, 27, 197, DateTimeKind.Local).AddTicks(1488), "2f9d626b-9be4-4d6f-8310-edb2ef321d2d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 261,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 47, 19, 719, DateTimeKind.Local).AddTicks(2487), new DateTime(2022, 1, 21, 11, 36, 28, 258, DateTimeKind.Local).AddTicks(3831), "b257052b-6b1f-48d6-9196-61b1d8c867a2" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 262,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 11, 34, 212, DateTimeKind.Local).AddTicks(8683), new DateTime(2021, 9, 9, 6, 26, 15, 249, DateTimeKind.Local).AddTicks(7697), "88e90ac7-8428-4fb8-9c9b-8e194c255fd9" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 263,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 54, 25, 655, DateTimeKind.Local).AddTicks(1372), new DateTime(2021, 5, 5, 13, 33, 41, 986, DateTimeKind.Local).AddTicks(3807), "41135e47-27fa-47e5-b1ba-d8f31583f18a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 264,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 24, 33, 655, DateTimeKind.Local).AddTicks(2714), new DateTime(2021, 7, 16, 6, 15, 13, 764, DateTimeKind.Local).AddTicks(1718), "85af5c87-6ea0-42b1-9f2f-9d4333f4e520" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 265,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 43, 53, 167, DateTimeKind.Local).AddTicks(5911), new DateTime(2021, 6, 13, 11, 37, 21, 33, DateTimeKind.Local).AddTicks(8628), "0ac18fbb-12e4-421d-9266-1385f96957e4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 266,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 36, 27, 385, DateTimeKind.Local).AddTicks(3965), new DateTime(2021, 10, 4, 14, 0, 27, 907, DateTimeKind.Local).AddTicks(4465), "a0c4c150-a557-4ec3-a3b0-8ab6300fa79e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 267,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 46, 11, 906, DateTimeKind.Local).AddTicks(6402), new DateTime(2021, 12, 29, 16, 44, 6, 841, DateTimeKind.Local).AddTicks(5165), "dbb7fe76-e708-4787-bd74-245a4b785811" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 268,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 31, 57, 375, DateTimeKind.Local).AddTicks(8568), new DateTime(2021, 6, 6, 6, 52, 2, 618, DateTimeKind.Local).AddTicks(5434), "60c8946c-2460-4090-ac8e-dc2fbd59cb25" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 269,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 24, 4, 204, DateTimeKind.Local).AddTicks(242), new DateTime(2021, 11, 22, 17, 57, 27, 173, DateTimeKind.Local).AddTicks(6340), "091b8bde-1623-4e72-994a-74ae8982a805" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 270,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 1, 0, 488, DateTimeKind.Local).AddTicks(267), new DateTime(2021, 3, 22, 5, 4, 53, 674, DateTimeKind.Local).AddTicks(5541), "4798402d-fed1-4d29-9470-c18bf9f355dd" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 271,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 53, 34, 966, DateTimeKind.Local).AddTicks(1472), new DateTime(2021, 6, 9, 0, 18, 23, 972, DateTimeKind.Local).AddTicks(3305), "e54acfe2-a316-47b0-9563-d6693493c596" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 272,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 20, 40, 769, DateTimeKind.Local).AddTicks(8515), new DateTime(2021, 3, 4, 16, 25, 40, 413, DateTimeKind.Local).AddTicks(9931), "cfc478af-dcfb-44a0-b7bd-b14316c7a232" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 273,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 16, 12, 27, 958, DateTimeKind.Local).AddTicks(7285), new DateTime(2022, 1, 7, 15, 30, 12, 905, DateTimeKind.Local).AddTicks(5322), "3655cbde-9848-468a-a129-6a7b78615915" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 274,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 53, 26, 922, DateTimeKind.Local).AddTicks(684), new DateTime(2021, 2, 28, 22, 10, 39, 838, DateTimeKind.Local).AddTicks(7216), "68a51b82-81ba-4dc5-83e1-03c68eb1128f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 275,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 30, 29, 987, DateTimeKind.Local).AddTicks(6530), new DateTime(2021, 7, 24, 5, 32, 29, 827, DateTimeKind.Local).AddTicks(2562), "05c01f84-9d52-43f3-a761-23789471b7a9" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 276,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 23, 27, 179, DateTimeKind.Local).AddTicks(8009), new DateTime(2021, 2, 14, 10, 58, 41, 336, DateTimeKind.Local).AddTicks(7510), "cf36a5bf-ac2d-4eda-b482-8923ae125359" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 277,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 58, 49, 713, DateTimeKind.Local).AddTicks(6599), new DateTime(2022, 1, 27, 5, 12, 32, 386, DateTimeKind.Local).AddTicks(3300), "7bcc9d22-eb7b-46ff-b980-939911655c3e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 278,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 8, 32, 876, DateTimeKind.Local).AddTicks(7863), new DateTime(2021, 6, 11, 14, 4, 41, 386, DateTimeKind.Local).AddTicks(2708), "7f2fcbfd-56a9-494c-b4cc-52df20809a1b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 279,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 50, 44, 566, DateTimeKind.Local).AddTicks(4417), new DateTime(2021, 10, 8, 14, 51, 13, 36, DateTimeKind.Local).AddTicks(3366), "d8785fdf-7d08-4f86-9054-a30ba83873c7" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 280,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 42, 34, 142, DateTimeKind.Local).AddTicks(6146), new DateTime(2021, 5, 8, 1, 3, 28, 733, DateTimeKind.Local).AddTicks(790), "617852f7-58f7-4127-9d43-602dc85032b7" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 281,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 4, 59, 782, DateTimeKind.Local).AddTicks(2146), new DateTime(2022, 2, 4, 9, 45, 32, 454, DateTimeKind.Local).AddTicks(904), "5e15aed9-794e-436b-8194-976d9a058e89" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 282,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 20, 2, 696, DateTimeKind.Local).AddTicks(7576), new DateTime(2022, 1, 6, 16, 10, 8, 750, DateTimeKind.Local).AddTicks(809), "ff29d50c-6e7b-46e2-9567-c7d9d4bed308" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 283,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 21, 56, 901, DateTimeKind.Local).AddTicks(7470), new DateTime(2021, 7, 30, 14, 15, 2, 212, DateTimeKind.Local).AddTicks(842), "5ba2f510-c529-40b6-9831-8f2c5ce490a6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 284,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 43, 14, 373, DateTimeKind.Local).AddTicks(2409), new DateTime(2021, 5, 15, 0, 45, 1, 833, DateTimeKind.Local).AddTicks(7888), "635a2d4d-f786-4a6c-a8a2-a6807ad98075" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 285,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 59, 19, 356, DateTimeKind.Local).AddTicks(2529), new DateTime(2021, 12, 11, 5, 42, 49, 76, DateTimeKind.Local).AddTicks(3336), "a2a59db9-e90b-41ee-9d07-cd26fa81120e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 286,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 18, 18, 250, DateTimeKind.Local).AddTicks(4701), new DateTime(2021, 6, 19, 22, 42, 34, 128, DateTimeKind.Local).AddTicks(5941), "969b7656-7254-4e2f-8fd2-bd269cac3c8e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 287,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 26, 54, 470, DateTimeKind.Local).AddTicks(4882), new DateTime(2021, 9, 29, 8, 16, 32, 70, DateTimeKind.Local).AddTicks(9716), "066615f0-07d6-4abe-accd-611d3531c6f9" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 288,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 6, 42, 214, DateTimeKind.Local).AddTicks(9415), new DateTime(2021, 10, 1, 6, 48, 49, 393, DateTimeKind.Local).AddTicks(3220), "be20be1e-e28a-4b27-b773-d2b4ed187650" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 289,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 17, 46, 793, DateTimeKind.Local).AddTicks(6962), new DateTime(2021, 9, 9, 0, 10, 23, 110, DateTimeKind.Local).AddTicks(212), "47eb84d4-8e8d-4f99-9e1b-a656cc4c4ffe" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 290,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 5, 33, 753, DateTimeKind.Local).AddTicks(9435), new DateTime(2021, 6, 14, 3, 46, 5, 585, DateTimeKind.Local).AddTicks(8269), "22064cb7-eb4a-439d-9d22-e494954a01aa" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 291,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 42, 52, 252, DateTimeKind.Local).AddTicks(3329), new DateTime(2021, 2, 9, 9, 37, 3, 279, DateTimeKind.Local).AddTicks(2135), "ddcfaeac-6da3-487e-9a5e-bce8b86bd76a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 292,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 30, 32, 494, DateTimeKind.Local).AddTicks(6968), new DateTime(2021, 10, 21, 13, 37, 45, 502, DateTimeKind.Local).AddTicks(3929), "3f633639-5696-4f89-a800-cd557e8c4c66" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 293,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 57, 2, 479, DateTimeKind.Local).AddTicks(5585), new DateTime(2021, 12, 7, 0, 42, 53, 866, DateTimeKind.Local).AddTicks(5554), "c34d3b9c-be26-4404-b53b-939bea77f271" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 294,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 42, 52, 914, DateTimeKind.Local).AddTicks(8914), new DateTime(2022, 1, 10, 3, 19, 47, 782, DateTimeKind.Local).AddTicks(632), "42a624f5-9d2e-4727-aee0-7ee0f4b633df" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 295,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 8, 22, 615, DateTimeKind.Local).AddTicks(6486), new DateTime(2022, 1, 3, 14, 5, 15, 517, DateTimeKind.Local).AddTicks(2062), "f0c5f07b-8f61-4c65-afc7-543d427b576c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 296,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 4, 43, 974, DateTimeKind.Local).AddTicks(4385), new DateTime(2021, 6, 23, 23, 36, 33, 775, DateTimeKind.Local).AddTicks(6740), "25a5b95f-eb98-439c-b248-33ab5fdc8e4f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 297,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 3, 54, 432, DateTimeKind.Local).AddTicks(5200), new DateTime(2021, 7, 28, 0, 51, 11, 325, DateTimeKind.Local).AddTicks(9648), "6af96984-45b6-4640-bb39-6c252144dcff" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 298,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 44, 25, 151, DateTimeKind.Local).AddTicks(5963), new DateTime(2021, 4, 22, 18, 19, 22, 938, DateTimeKind.Local).AddTicks(9192), "bc5822f6-0ead-4002-9ad4-4ff8aeafd862" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 299,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 59, 3, 85, DateTimeKind.Local).AddTicks(7838), new DateTime(2021, 3, 11, 11, 35, 42, 406, DateTimeKind.Local).AddTicks(6688), "1efb3c41-278a-4080-b23e-ef591d5ed1be" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 300,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 19, 44, 554, DateTimeKind.Local).AddTicks(4308), new DateTime(2022, 1, 23, 0, 24, 13, 608, DateTimeKind.Local).AddTicks(7279), "55d53ac1-dde5-41bf-8f66-249b2b1c437c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 301,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 18, 5, 58, 318, DateTimeKind.Local).AddTicks(5951), new DateTime(2021, 10, 1, 3, 33, 9, 325, DateTimeKind.Local).AddTicks(3779), "499aaa05-6fc6-476c-99cc-824e1e8892f6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 302,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 57, 28, 612, DateTimeKind.Local).AddTicks(377), new DateTime(2021, 4, 26, 4, 0, 42, 762, DateTimeKind.Local).AddTicks(9220), "cb58fe68-e470-4fee-bce0-06bb2e202cf0" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 303,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 42, 10, 914, DateTimeKind.Local).AddTicks(3918), new DateTime(2021, 4, 17, 15, 8, 40, 538, DateTimeKind.Local).AddTicks(1831), "127a5ceb-d42f-4b0c-8fe8-f234994676a3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 304,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 35, 5, 550, DateTimeKind.Local).AddTicks(7223), new DateTime(2021, 9, 3, 9, 21, 47, 61, DateTimeKind.Local).AddTicks(8017), "88564e23-c628-4352-89e6-0e5cb301e72f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 305,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 24, 17, 225, DateTimeKind.Local).AddTicks(1341), new DateTime(2022, 1, 5, 15, 15, 36, 65, DateTimeKind.Local).AddTicks(1224), "e3e920f6-8c96-4278-903f-f1435656af1d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 306,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 43, 59, 357, DateTimeKind.Local).AddTicks(4764), new DateTime(2021, 8, 3, 11, 21, 8, 0, DateTimeKind.Local).AddTicks(727), "28413877-a482-433e-917f-b73fed40054f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 307,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 3, 55, 35, 742, DateTimeKind.Local).AddTicks(4555), new DateTime(2021, 11, 13, 12, 41, 25, 918, DateTimeKind.Local).AddTicks(5571), "128c9beb-77a5-4548-b2f4-9853c6ffb331" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 308,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 15, 48, 35, 309, DateTimeKind.Local).AddTicks(4687), new DateTime(2021, 9, 10, 15, 52, 3, 152, DateTimeKind.Local).AddTicks(4401), "c66f303c-ca4c-4122-88c4-9db1ce1aaee4" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 309,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 38, 17, 288, DateTimeKind.Local).AddTicks(335), new DateTime(2021, 4, 28, 18, 44, 18, 618, DateTimeKind.Local).AddTicks(2936), "19b7a952-5df5-4575-bb9d-2076a7a15c32" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 310,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 0, 12, 318, DateTimeKind.Local).AddTicks(7034), new DateTime(2021, 3, 9, 19, 22, 34, 869, DateTimeKind.Local).AddTicks(8740), "60767707-7116-481d-b128-c9f6c2c6dfb7" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 311,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 42, 51, 236, DateTimeKind.Local).AddTicks(3955), new DateTime(2021, 2, 15, 13, 59, 57, 779, DateTimeKind.Local).AddTicks(5453), "634d0867-0d94-4416-8629-60097d551f27" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 312,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 8, 38, 859, DateTimeKind.Local).AddTicks(8634), new DateTime(2021, 11, 17, 18, 36, 52, 594, DateTimeKind.Local).AddTicks(9622), "7bdad988-2802-4ef1-b000-c91c8b377bb8" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 313,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 39, 0, 893, DateTimeKind.Local).AddTicks(108), new DateTime(2021, 7, 15, 12, 3, 21, 329, DateTimeKind.Local).AddTicks(8158), "a015b0fc-bc1b-4c6f-b7aa-e096074c1410" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 10, 34, 124, DateTimeKind.Local).AddTicks(3763), new DateTime(2021, 2, 18, 3, 16, 28, 825, DateTimeKind.Local).AddTicks(2854), "33f9c858-2cd2-445f-a334-4d0495b76426" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 315,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 32, 57, 307, DateTimeKind.Local).AddTicks(3072), new DateTime(2021, 10, 10, 13, 55, 21, 770, DateTimeKind.Local).AddTicks(6429), "0d116a44-ff09-4f86-8bcf-6a597007f401" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 316,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 55, 16, 324, DateTimeKind.Local).AddTicks(1552), new DateTime(2021, 3, 21, 22, 25, 6, 853, DateTimeKind.Local).AddTicks(7282), "1da180ff-0a07-47f5-b51b-e792b5c0d8f6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 317,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 19, 53, 170, DateTimeKind.Local).AddTicks(7594), new DateTime(2021, 7, 16, 18, 8, 7, 73, DateTimeKind.Local).AddTicks(1285), "575e7fb0-59da-4bdd-acbb-aab8fc360d49" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 318,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 35, 44, 702, DateTimeKind.Local).AddTicks(9302), new DateTime(2021, 8, 6, 9, 7, 35, 106, DateTimeKind.Local).AddTicks(1893), "ffe48600-cc01-4f41-a68d-c7c04844ec71" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 319,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 4, 3, 2, DateTimeKind.Local).AddTicks(6491), new DateTime(2022, 1, 21, 21, 14, 37, 42, DateTimeKind.Local).AddTicks(6502), "deefb96b-e1b0-4764-ab62-69f81d51edb3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 320,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 57, 14, 519, DateTimeKind.Local).AddTicks(4305), new DateTime(2021, 10, 17, 0, 50, 55, 33, DateTimeKind.Local).AddTicks(705), "8805e9a1-c78b-43f2-81e2-ac27ff72d139" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 321,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 32, 9, 886, DateTimeKind.Local).AddTicks(832), new DateTime(2021, 5, 30, 19, 53, 22, 377, DateTimeKind.Local).AddTicks(5217), "902b6285-a34c-4710-bc25-951cd0fdca52" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 322,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 17, 57, 566, DateTimeKind.Local).AddTicks(6104), new DateTime(2021, 12, 10, 19, 28, 42, 528, DateTimeKind.Local).AddTicks(9422), "da318a2e-9ae6-4413-9c13-6c44c437ab00" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 323,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 46, 44, 541, DateTimeKind.Local).AddTicks(3516), new DateTime(2021, 11, 6, 12, 57, 58, 313, DateTimeKind.Local).AddTicks(4899), "40ae70db-1c1f-4fd0-9e43-92ab80e01faa" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 324,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 0, 0, 876, DateTimeKind.Local).AddTicks(1476), new DateTime(2021, 5, 15, 18, 45, 39, 212, DateTimeKind.Local).AddTicks(7272), "7ddf2e4a-03fe-496f-acdb-4ba5baf340a6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 325,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 41, 38, 713, DateTimeKind.Local).AddTicks(4403), new DateTime(2021, 12, 24, 2, 45, 59, 874, DateTimeKind.Local).AddTicks(8932), "e5001f3e-4493-4b5d-86ca-453cc061c985" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 326,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 16, 5, 386, DateTimeKind.Local).AddTicks(4300), new DateTime(2021, 2, 17, 9, 33, 37, 161, DateTimeKind.Local).AddTicks(7467), "ee3bc8f9-4643-4efe-ac7c-6b368b38f5f0" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 327,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 40, 38, 891, DateTimeKind.Local).AddTicks(2289), new DateTime(2022, 2, 3, 11, 58, 40, 852, DateTimeKind.Local).AddTicks(6423), "553576cc-4e67-4b96-aeb9-d81edd958a13" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 328,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 43, 56, 736, DateTimeKind.Local).AddTicks(2284), new DateTime(2021, 6, 13, 19, 57, 17, 447, DateTimeKind.Local).AddTicks(4472), "2cd8ec2e-94d9-4959-9b73-540632a906bc" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 329,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 4, 28, 488, DateTimeKind.Local).AddTicks(1074), new DateTime(2021, 10, 21, 10, 36, 36, 182, DateTimeKind.Local).AddTicks(4164), "081a4293-7504-4721-af50-35521fda8a96" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 330,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 42, 8, 247, DateTimeKind.Local).AddTicks(5869), new DateTime(2021, 10, 25, 15, 14, 12, 202, DateTimeKind.Local).AddTicks(2948), "6c3823c4-8635-43fb-b959-15e7a2cdc695" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 331,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 34, 24, 847, DateTimeKind.Local).AddTicks(6707), new DateTime(2021, 2, 25, 1, 20, 30, 652, DateTimeKind.Local).AddTicks(6874), "6ac1d2eb-7021-4536-937a-1de0a964c8b2" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 332,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 11, 57, 62, DateTimeKind.Local).AddTicks(234), new DateTime(2021, 8, 14, 12, 51, 7, 833, DateTimeKind.Local).AddTicks(5824), "e96afb2c-efd3-45f7-b6ce-532311b2a470" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 333,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 35, 25, 210, DateTimeKind.Local).AddTicks(5215), new DateTime(2021, 3, 12, 19, 42, 39, 944, DateTimeKind.Local).AddTicks(3750), "0ab5e8af-ccd3-43dc-bf97-fad893a1e706" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 334,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 29, 6, 690, DateTimeKind.Local).AddTicks(9972), new DateTime(2021, 8, 14, 7, 50, 23, 554, DateTimeKind.Local).AddTicks(3362), "7337d3b8-232b-45cd-bb18-d11ba5c05c1b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 335,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 30, 15, 423, DateTimeKind.Local).AddTicks(6857), new DateTime(2021, 12, 2, 23, 7, 2, 133, DateTimeKind.Local).AddTicks(139), "9ba727a5-41d0-4d54-967f-eb8284df6f6a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 336,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 43, 1, 390, DateTimeKind.Local).AddTicks(9927), new DateTime(2021, 12, 3, 16, 13, 30, 112, DateTimeKind.Local).AddTicks(838), "5f2f72b2-5706-4994-86de-a367ce2d8c31" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 337,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 13, 15, 768, DateTimeKind.Local).AddTicks(5591), new DateTime(2021, 9, 5, 18, 5, 17, 585, DateTimeKind.Local).AddTicks(8559), "4ac339fd-a510-4c7e-992c-ad5ea6b14591" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 338,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 3, 35, 135, DateTimeKind.Local).AddTicks(4683), new DateTime(2022, 1, 11, 5, 42, 6, 448, DateTimeKind.Local).AddTicks(9431), "49560b04-c809-4bef-8753-25406e564790" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 339,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 24, 7, 900, DateTimeKind.Local).AddTicks(8425), new DateTime(2021, 5, 29, 6, 25, 34, 844, DateTimeKind.Local).AddTicks(154), "c4ce1165-526b-49a9-9878-434c23f37a89" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 340,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 13, 16, 958, DateTimeKind.Local).AddTicks(2218), new DateTime(2021, 6, 11, 4, 19, 17, 57, DateTimeKind.Local).AddTicks(5760), "a0f1a96f-9a4c-4e2a-8732-8b14ea9deeb0" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 341,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 2, 38, 952, DateTimeKind.Local).AddTicks(3126), new DateTime(2022, 1, 29, 3, 49, 32, 523, DateTimeKind.Local).AddTicks(2257), "ed2c3a64-b926-4470-b39a-5ce27bb73aab" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 342,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 8, 55, 22, 497, DateTimeKind.Local).AddTicks(6514), new DateTime(2021, 9, 22, 13, 15, 47, 979, DateTimeKind.Local).AddTicks(8767), "606054ea-0c7e-464a-bb93-18b118d0fc83" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 343,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 8, 53, 842, DateTimeKind.Local).AddTicks(2967), new DateTime(2021, 8, 8, 17, 38, 0, 839, DateTimeKind.Local).AddTicks(1213), "4097cb23-3e21-4d06-8bfb-930e34dcb184" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 344,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 50, 22, 960, DateTimeKind.Local).AddTicks(2044), new DateTime(2021, 9, 19, 17, 41, 7, 511, DateTimeKind.Local).AddTicks(5385), "30a7f7f4-936d-416a-9faf-840fc287c915" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 345,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 3, 3, 457, DateTimeKind.Local).AddTicks(7056), new DateTime(2021, 3, 10, 20, 45, 6, 845, DateTimeKind.Local).AddTicks(4628), "77467f19-4489-4226-899d-99bc9fd33ece" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 346,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 34, 0, 531, DateTimeKind.Local).AddTicks(3810), new DateTime(2021, 3, 29, 20, 55, 27, 159, DateTimeKind.Local).AddTicks(4075), "c074f152-d2c9-4acb-b35c-74d8fb81142e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 347,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 15, 31, 295, DateTimeKind.Local).AddTicks(5927), new DateTime(2021, 5, 31, 5, 11, 28, 248, DateTimeKind.Local).AddTicks(7796), "d04529c7-6480-4a2e-ba03-dae191918938" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 348,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 30, 15, 216, DateTimeKind.Local).AddTicks(8732), new DateTime(2022, 2, 4, 8, 16, 13, 712, DateTimeKind.Local).AddTicks(457), "ed0c1075-abdd-4431-9fb1-ad5899d510ae" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 349,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 30, 11, 224, DateTimeKind.Local).AddTicks(9684), new DateTime(2022, 1, 3, 2, 26, 22, 690, DateTimeKind.Local).AddTicks(3428), "81aea81f-b442-476b-b2cd-36e7dd095a3a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 350,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 14, 7, 46, 913, DateTimeKind.Local).AddTicks(4429), new DateTime(2021, 12, 15, 14, 8, 14, 342, DateTimeKind.Local).AddTicks(4663), "758caf59-136c-4fc2-b1d0-d85a1bd9f0f7" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 351,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 2, 12, 293, DateTimeKind.Local).AddTicks(8344), new DateTime(2021, 3, 17, 18, 25, 27, 710, DateTimeKind.Local).AddTicks(4880), "e4c34e70-9d32-4f95-b071-13173bad0297" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 352,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 36, 13, 258, DateTimeKind.Local).AddTicks(6446), new DateTime(2021, 12, 26, 22, 47, 35, 478, DateTimeKind.Local).AddTicks(1120), "222af607-96b1-4f2f-ac0f-b7524b659a2d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 353,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 12, 19, 133, DateTimeKind.Local).AddTicks(8463), new DateTime(2021, 11, 15, 4, 33, 31, 968, DateTimeKind.Local).AddTicks(2891), "7f05cce1-d733-4164-91de-81fa1c13568c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 354,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 14, 13, 720, DateTimeKind.Local).AddTicks(4816), new DateTime(2021, 5, 6, 17, 46, 57, 877, DateTimeKind.Local).AddTicks(3936), "a2e769fa-71b2-4f15-b629-6650d1154daa" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 355,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 3, 51, 713, DateTimeKind.Local).AddTicks(1459), new DateTime(2021, 5, 14, 9, 1, 7, 470, DateTimeKind.Local).AddTicks(4066), "7cce09a8-dd0d-4f81-9e5d-8fbb1c460d3b" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 356,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 31, 15, 952, DateTimeKind.Local).AddTicks(6032), new DateTime(2022, 1, 8, 1, 26, 21, 507, DateTimeKind.Local).AddTicks(7134), "da7dc208-512c-488c-bcc0-f0a33af3e68a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 357,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 17, 42, 261, DateTimeKind.Local).AddTicks(2955), new DateTime(2021, 12, 20, 14, 50, 5, 727, DateTimeKind.Local).AddTicks(5448), "a9954cd7-72d6-4f2f-a9bc-94a8fa6345c3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 358,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 10, 10, 523, DateTimeKind.Local).AddTicks(2382), new DateTime(2021, 3, 16, 17, 53, 35, 240, DateTimeKind.Local).AddTicks(9724), "bd1c049a-5448-48a4-87fd-e73f4f2c63b3" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 359,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 50, 45, 206, DateTimeKind.Local).AddTicks(6135), new DateTime(2021, 9, 5, 13, 16, 12, 836, DateTimeKind.Local).AddTicks(6838), "7d06c32f-9757-42ea-a29f-8a74739c4775" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 360,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 14, 37, 125, DateTimeKind.Local).AddTicks(6889), new DateTime(2021, 8, 29, 17, 8, 28, 622, DateTimeKind.Local).AddTicks(8962), "ee947779-1762-426f-bbab-faf1a77c95cd" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 361,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 23, 2, 870, DateTimeKind.Local).AddTicks(5787), new DateTime(2021, 12, 19, 9, 29, 52, 145, DateTimeKind.Local).AddTicks(6134), "2ed3cca6-8afd-405f-82ec-be7cc0b225be" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 362,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 3, 34, 924, DateTimeKind.Local).AddTicks(100), new DateTime(2021, 9, 2, 21, 55, 27, 728, DateTimeKind.Local).AddTicks(2965), "15eb138c-5c1c-4489-8eaa-2907dc348cbd" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 363,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 18, 48, 11, DateTimeKind.Local).AddTicks(5712), new DateTime(2021, 4, 9, 1, 42, 12, 332, DateTimeKind.Local).AddTicks(4999), "030b0947-f5d0-4e1d-b3ab-154a283b0be6" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 364,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 17, 40, 1, 680, DateTimeKind.Local).AddTicks(1991), new DateTime(2021, 9, 1, 2, 6, 8, 418, DateTimeKind.Local).AddTicks(1407), "3ef632a1-f13b-4ff5-89ed-3b398b86aa79" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 365,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 15, 15, 671, DateTimeKind.Local).AddTicks(1927), new DateTime(2021, 4, 1, 14, 16, 34, 301, DateTimeKind.Local).AddTicks(665), "bdc9019d-302e-4e29-9c82-8f3425dbf19f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 366,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 13, 35, 704, DateTimeKind.Local).AddTicks(8078), new DateTime(2021, 8, 3, 19, 27, 44, 780, DateTimeKind.Local).AddTicks(6156), "8f6db371-2f76-4762-aa11-6f08170544b8" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 367,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 9, 46, 33, DateTimeKind.Local).AddTicks(7681), new DateTime(2021, 4, 25, 8, 5, 38, 41, DateTimeKind.Local).AddTicks(3003), "80474086-2233-4cac-8489-5aeaf9a10ddc" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 368,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 11, 9, 25, 940, DateTimeKind.Local).AddTicks(6134), new DateTime(2021, 3, 21, 3, 44, 11, 371, DateTimeKind.Local).AddTicks(4837), "f40a84d6-521a-4108-ba21-e96025f44e3c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 369,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 56, 42, 997, DateTimeKind.Local).AddTicks(7465), new DateTime(2021, 5, 12, 0, 12, 34, 437, DateTimeKind.Local).AddTicks(4460), "ee1d329c-cde5-4466-ac74-ac1404a10982" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 370,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 41, 34, 186, DateTimeKind.Local).AddTicks(150), new DateTime(2021, 9, 9, 12, 46, 47, 56, DateTimeKind.Local).AddTicks(3036), "7827a91b-1b75-436f-a63e-07d46b5bf15a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 371,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 21, 16, 40, 244, DateTimeKind.Local).AddTicks(4056), new DateTime(2021, 12, 25, 3, 56, 2, 79, DateTimeKind.Local).AddTicks(2858), "0b8001ea-df73-4147-b50f-8532fe63e398" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 372,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 19, 17, 714, DateTimeKind.Local).AddTicks(9329), new DateTime(2021, 2, 7, 16, 39, 5, 842, DateTimeKind.Local).AddTicks(2346), "70ff1112-dc37-40de-8d28-6609325e8085" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 373,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 43, 54, 167, DateTimeKind.Local).AddTicks(4108), new DateTime(2021, 6, 21, 7, 31, 13, 395, DateTimeKind.Local).AddTicks(2681), "2b8771c5-d7b3-40e8-a08e-8ca61af22a3e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 374,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 10, 49, 6, 355, DateTimeKind.Local).AddTicks(5735), new DateTime(2021, 11, 19, 10, 24, 5, 433, DateTimeKind.Local).AddTicks(5620), "544926c7-2832-436f-b681-1b13b9e8a703" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 375,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 28, 18, 593, DateTimeKind.Local).AddTicks(1484), new DateTime(2021, 6, 3, 14, 55, 38, 151, DateTimeKind.Local).AddTicks(6819), "22061a71-e18b-4f83-8bdd-c0e99ee156ee" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 376,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 5, 17, 27, 73, DateTimeKind.Local).AddTicks(6827), new DateTime(2021, 3, 25, 5, 6, 32, 875, DateTimeKind.Local).AddTicks(5439), "8397f278-1609-4f83-ba18-13ea101e939d" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 377,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 4, 22, 26, 627, DateTimeKind.Local).AddTicks(2553), new DateTime(2021, 3, 14, 10, 38, 39, 289, DateTimeKind.Local).AddTicks(6655), "bf6f015f-b6e5-427e-bb4b-f1f6c0536adc" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 378,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 42, 38, 949, DateTimeKind.Local).AddTicks(8453), new DateTime(2021, 4, 23, 23, 42, 47, 708, DateTimeKind.Local).AddTicks(8952), "842ea414-f5fb-477c-aa45-7fec3bfb9c2f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 379,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 20, 21, 40, 564, DateTimeKind.Local).AddTicks(4753), new DateTime(2021, 8, 3, 3, 12, 45, 288, DateTimeKind.Local).AddTicks(7235), "c1ae6b83-79a8-4c94-b61d-c3a331a41806" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 380,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 35, 31, 694, DateTimeKind.Local).AddTicks(1102), new DateTime(2021, 2, 13, 10, 17, 42, 736, DateTimeKind.Local).AddTicks(9190), "fd06cf66-ccd3-45f8-a628-b80762c52a27" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 381,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 1, 58, 24, 368, DateTimeKind.Local).AddTicks(2430), new DateTime(2021, 11, 18, 6, 55, 31, 985, DateTimeKind.Local).AddTicks(4167), "808dd81d-b966-419f-afde-8176c68e5b3a" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 382,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 4, 29, 985, DateTimeKind.Local).AddTicks(7705), new DateTime(2021, 7, 27, 8, 38, 50, 900, DateTimeKind.Local).AddTicks(1275), "f98ac660-088b-4219-b1e9-d363607fda56" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 383,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 32, 25, 546, DateTimeKind.Local).AddTicks(6387), new DateTime(2021, 8, 18, 19, 40, 3, 497, DateTimeKind.Local).AddTicks(7872), "fee60cb8-fe65-47d9-b08e-59568e2c2cc8" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 384,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 2, 24, 35, 501, DateTimeKind.Local).AddTicks(1015), new DateTime(2021, 6, 3, 11, 11, 45, 302, DateTimeKind.Local).AddTicks(1300), "76ef2fd7-76de-4cb9-b07b-745383c30145" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 385,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 20, 11, 915, DateTimeKind.Local).AddTicks(5268), new DateTime(2021, 12, 25, 3, 53, 20, 121, DateTimeKind.Local).AddTicks(5909), "35b1b47e-ab38-47a3-a25c-f49926ff282c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 386,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 21, 2, 28, DateTimeKind.Local).AddTicks(5413), new DateTime(2021, 10, 6, 21, 33, 44, 648, DateTimeKind.Local).AddTicks(4542), "31c7d491-a30c-4365-bd71-d0de0940b713" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 387,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 22, 21, 24, 830, DateTimeKind.Local).AddTicks(667), new DateTime(2021, 12, 16, 13, 13, 11, 187, DateTimeKind.Local).AddTicks(5502), "cb3774a7-eb2a-4f2d-a63d-d6b2d0567093" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 388,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 50, 15, 824, DateTimeKind.Local).AddTicks(3041), new DateTime(2021, 2, 23, 11, 43, 0, 860, DateTimeKind.Local).AddTicks(8377), "22dbb00f-a588-40e7-b193-7b97e604e259" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 389,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 23, 35, 45, 630, DateTimeKind.Local).AddTicks(8281), new DateTime(2022, 1, 5, 20, 2, 36, 989, DateTimeKind.Local).AddTicks(3888), "4834b749-6779-406d-b32a-aa3cdc6b3a67" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 390,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 6, 19, 7, 12, 77, DateTimeKind.Local).AddTicks(1445), new DateTime(2021, 4, 8, 6, 16, 11, 634, DateTimeKind.Local).AddTicks(7040), "1628365f-c48b-4e57-aff1-4b6e6c2f85f7" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 391,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 15, 19, 3, 566, DateTimeKind.Local).AddTicks(9870), new DateTime(2021, 10, 6, 0, 12, 39, 493, DateTimeKind.Local).AddTicks(7310), "7eb0211e-dc5c-48f0-ab49-d5fba31d072f" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 392,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 6, 51, 23, 404, DateTimeKind.Local).AddTicks(5283), new DateTime(2021, 12, 6, 13, 2, 57, 857, DateTimeKind.Local).AddTicks(6246), "e5abbf26-6b5d-4683-9039-73c016989581" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 393,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 26, 27, 976, DateTimeKind.Local).AddTicks(9363), new DateTime(2021, 12, 7, 9, 2, 57, 818, DateTimeKind.Local).AddTicks(2694), "f16e4e56-9c1d-4fe0-90df-110254e2d390" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 394,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 50, 0, 452, DateTimeKind.Local).AddTicks(3302), new DateTime(2021, 11, 29, 13, 27, 14, 941, DateTimeKind.Local).AddTicks(37), "c158a932-eb12-4552-a58f-72ac20bd5b1c" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 395,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 38, 4, 535, DateTimeKind.Local).AddTicks(9019), new DateTime(2021, 9, 14, 8, 47, 29, 774, DateTimeKind.Local).AddTicks(4924), "8a8a6a46-d65c-49f6-8850-4b15ecae3232" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 396,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 0, 16, 25, 171, DateTimeKind.Local).AddTicks(4486), new DateTime(2021, 3, 26, 9, 17, 43, 819, DateTimeKind.Local).AddTicks(9240), "9e767e0e-11ca-4c15-a2f4-5cc0fc1e2f33" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 397,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 13, 18, 30, 420, DateTimeKind.Local).AddTicks(6141), new DateTime(2021, 6, 12, 20, 29, 22, 162, DateTimeKind.Local).AddTicks(6852), "34fd6db2-f02e-411d-a1d3-1524d65b3919" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 398,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 12, 35, 27, 811, DateTimeKind.Local).AddTicks(5840), new DateTime(2021, 2, 21, 15, 56, 30, 902, DateTimeKind.Local).AddTicks(258), "9e3f819a-6a27-4dba-bcb8-71af97053d2e" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 399,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 7, 52, 56, 892, DateTimeKind.Local).AddTicks(9018), new DateTime(2021, 12, 1, 12, 58, 25, 762, DateTimeKind.Local).AddTicks(9191), "55ea4a84-83a8-4ec9-9bf1-97ba2e973841" });

            migrationBuilder.UpdateData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 400,
                columns: new[] { "AvailabilityFrom", "AvailabilityTo", "AzureId" },
                values: new object[] { new DateTime(2021, 2, 7, 9, 21, 58, 235, DateTimeKind.Local).AddTicks(8467), new DateTime(2021, 10, 27, 23, 25, 10, 786, DateTimeKind.Local).AddTicks(5623), "b2f0d412-ba0b-4be0-9dfa-f24ecd688d36" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ZipCode",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Title",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Street",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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
                name: "ParcelAndHouseNumbers",
                table: "Petsitters",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Environment",
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
                name: "Country",
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
    }
}
