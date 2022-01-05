using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Petsupport.API2.Migrations
{
    public partial class WojtekBudujeBazePoZjebaniu : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AddressDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HouseNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FlatNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Latitude = table.Column<double>(type: "float", nullable: false),
                    Longitude = table.Column<double>(type: "float", nullable: false),
                    Range = table.Column<double>(type: "float", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AddressDetails", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BasicUserInfo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AvatarId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoGallery = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BasicUserInfo", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Petsitters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Experience = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Availability = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Environment = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Petsitters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PetPreference",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetType = table.Column<int>(type: "int", nullable: false),
                    PetWeights = table.Column<int>(type: "int", nullable: false),
                    BasicPetsitterProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetPreference", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetPreference_Petsitters_BasicPetsitterProfileId",
                        column: x => x.BasicPetsitterProfileId,
                        principalTable: "Petsitters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<double>(type: "float", nullable: false),
                    ServiceType = table.Column<int>(type: "int", nullable: false),
                    BasicPetsitterProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Services_Petsitters_BasicPetsitterProfileId",
                        column: x => x.BasicPetsitterProfileId,
                        principalTable: "Petsitters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AzureId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BasicUserInfoId = table.Column<int>(type: "int", nullable: true),
                    AddressDetailsId = table.Column<int>(type: "int", nullable: true),
                    WantsToBePetsitter = table.Column<bool>(type: "bit", nullable: false),
                    IsProfileCompleted = table.Column<bool>(type: "bit", nullable: false),
                    BasicPetsitterProfileId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_AddressDetails_AddressDetailsId",
                        column: x => x.AddressDetailsId,
                        principalTable: "AddressDetails",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_BasicUserInfo_BasicUserInfoId",
                        column: x => x.BasicUserInfoId,
                        principalTable: "BasicUserInfo",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Users_Petsitters_BasicPetsitterProfileId",
                        column: x => x.BasicPetsitterProfileId,
                        principalTable: "Petsitters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Animal",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PetType = table.Column<int>(type: "int", nullable: false),
                    PetWeight = table.Column<int>(type: "int", nullable: false),
                    Age = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoGallery = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Animal", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Animal_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookingMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetType = table.Column<int>(type: "int", nullable: false),
                    PetWeight = table.Column<int>(type: "int", nullable: false),
                    SentDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateFrom = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DateTo = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingMessages_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Animal_UserId",
                table: "Animal",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingMessages_UserId",
                table: "BookingMessages",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_PetPreference_BasicPetsitterProfileId",
                table: "PetPreference",
                column: "BasicPetsitterProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Services_BasicPetsitterProfileId",
                table: "Services",
                column: "BasicPetsitterProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_AddressDetailsId",
                table: "Users",
                column: "AddressDetailsId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BasicPetsitterProfileId",
                table: "Users",
                column: "BasicPetsitterProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_BasicUserInfoId",
                table: "Users",
                column: "BasicUserInfoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Animal");

            migrationBuilder.DropTable(
                name: "BookingMessages");

            migrationBuilder.DropTable(
                name: "PetPreference");

            migrationBuilder.DropTable(
                name: "Services");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "AddressDetails");

            migrationBuilder.DropTable(
                name: "BasicUserInfo");

            migrationBuilder.DropTable(
                name: "Petsitters");
        }
    }
}
