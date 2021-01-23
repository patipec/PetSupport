using Microsoft.EntityFrameworkCore.Migrations;

namespace Petsupport.API2.Migrations
{
    public partial class UpdateEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Petsitters",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhotoId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Petsitters", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Services",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageId = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Services", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BookingMessages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetsitterId = table.Column<int>(type: "int", nullable: false),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingMessages", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingMessages_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingMessages_Petsitters_PetsitterId",
                        column: x => x.PetsitterId,
                        principalTable: "Petsitters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PetSupportServices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PetsitterId = table.Column<int>(type: "int", nullable: false),
                    ServiceId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetSupportServices", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetSupportServices_Petsitters_PetsitterId",
                        column: x => x.PetsitterId,
                        principalTable: "Petsitters",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PetSupportServices_Services_ServiceId",
                        column: x => x.ServiceId,
                        principalTable: "Services",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "Id", "Email", "Name", "PhoneNumber", "Surname" },
                values: new object[,]
                {
                    { 1, "Tabitha81@gmail.com", "Tabitha", "(367) 863-7564 x5861", "Marquardt" },
                    { 30, "Viola_Becker31@yahoo.com", "Viola", "818.996.3457", "Becker" },
                    { 29, "Jean58@yahoo.com", "Jean", "667-907-0061 x783", "Olson" },
                    { 28, "Tracy.Thompson@yahoo.com", "Tracy", "1-282-558-9912 x302", "Thompson" },
                    { 27, "Irene.Upton@yahoo.com", "Irene", "(663) 715-6865 x8054", "Upton" },
                    { 26, "Leah_Steuber@yahoo.com", "Leah", "646.777.6076 x844", "Steuber" },
                    { 25, "Chad78@hotmail.com", "Chad", "787-410-9624 x667", "Koss" },
                    { 24, "Mary_Crona@gmail.com", "Mary", "(278) 458-0728 x2167", "Crona" },
                    { 22, "Katherine_Cole61@yahoo.com", "Katherine", "283.755.0135 x356", "Cole" },
                    { 21, "Neal29@yahoo.com", "Neal", "(419) 734-5333 x49286", "Turner" },
                    { 20, "Dallas.Kuhic1@gmail.com", "Dallas", "(614) 758-1162 x7491", "Kuhic" },
                    { 19, "Thelma_VonRueden20@hotmail.com", "Thelma", "228.838.8882 x1075", "VonRueden" },
                    { 18, "Muriel6@gmail.com", "Muriel", "(909) 739-3988 x41259", "Skiles" },
                    { 17, "Lucille_Veum20@gmail.com", "Lucille", "1-664-385-3643", "Veum" },
                    { 16, "Jesse_Bernier92@yahoo.com", "Jesse", "413-632-5828 x16164", "Bernier" },
                    { 23, "Patricia_Morar2@hotmail.com", "Patricia", "(376) 631-4228", "Morar" },
                    { 14, "Marcus_Hermiston@yahoo.com", "Marcus", "1-368-503-9574 x1287", "Hermiston" },
                    { 15, "Nettie34@hotmail.com", "Nettie", "(643) 801-8923", "Will" },
                    { 2, "Clifton.Metz@yahoo.com", "Clifton", "1-637-392-0725 x0811", "Metz" },
                    { 3, "Rosa58@yahoo.com", "Rosa", "(205) 555-6609 x520", "Braun" },
                    { 4, "Salvatore.Luettgen41@hotmail.com", "Salvatore", "833-734-8284 x85146", "Luettgen" },
                    { 5, "Dixie_Erdman98@hotmail.com", "Dixie", "957-710-3185 x1359", "Erdman" },
                    { 7, "June36@gmail.com", "June", "338-637-6082 x77943", "O'Keefe" },
                    { 6, "Calvin48@hotmail.com", "Calvin", "970.985.5294 x882", "Weber" },
                    { 9, "Lila.Murphy55@hotmail.com", "Lila", "(575) 708-6262 x7984", "Murphy" },
                    { 10, "Sammy.Terry@gmail.com", "Sammy", "451-711-4431 x68832", "Terry" },
                    { 11, "Felipe99@yahoo.com", "Felipe", "1-443-765-5820", "Bahringer" },
                    { 12, "Tammy_Marquardt61@gmail.com", "Tammy", "1-238-936-6451 x46634", "Marquardt" },
                    { 13, "Alfred.Murazik42@yahoo.com", "Alfred", "(650) 663-3103", "Murazik" },
                    { 8, "Arlene_Rosenbaum82@yahoo.com", "Arlene", "1-836-723-4030 x629", "Rosenbaum" }
                });

            migrationBuilder.InsertData(
                table: "Petsitters",
                columns: new[] { "Id", "Address", "City", "Description", "Email", "Name", "Password", "PhoneNumber", "PhotoId", "Surname" },
                values: new object[,]
                {
                    { 48, "Mann Summit", "Lake Montanafort", "Quas illum corporis veritatis voluptatem qui assumenda qui laborum quos dignissimos asperiores illo vero sequi distinctio asperiores sunt atque molestiae voluptatem vitae saepe autem et atque adipisci natus omnis architecto.", "Lucia64@yahoo.com", "Lucia", "5ea660f3-e3be-4351-9932-0fcf31aec99e", "1-562-631-8417", "https://picsum.photos/640/480/?image=50", "Prosacco" },
                    { 52, "Jamarcus Inlet", "Estherborough", "Quam qui aliquid commodi debitis quis consequatur eum maiores voluptatem praesentium earum temporibus nisi architecto excepturi omnis magni voluptatem debitis reiciendis ea possimus voluptas nesciunt illo magni atque voluptatibus dolor.", "Margarita28@gmail.com", "Margarita", "39c72db8-427e-4175-8911-8059b0f98805", "866-700-5155 x33473", "https://picsum.photos/640/480/?image=0", "O'Conner" },
                    { 49, "Leannon Springs", "Spencerville", "Excepturi est reiciendis itaque ut consequuntur similique illum aut a soluta eligendi doloribus dolores sed voluptate numquam distinctio deleniti blanditiis iusto consectetur et deleniti quis qui ratione qui rerum et.", "Lisa.Shields@hotmail.com", "Lisa", "2cb51276-9c6d-42ab-8e93-265ce06ef1d1", "1-706-249-9186 x295", "https://picsum.photos/640/480/?image=207", "Shields" },
                    { 50, "Kessler Track", "Kesslerchester", "Perspiciatis amet inventore qui officiis nemo laudantium sunt in aliquid repudiandae a et ut aliquid inventore beatae voluptates reprehenderit amet aut laborum pariatur fuga ex sint omnis sapiente enim officia.", "Jeremy.Rohan85@gmail.com", "Jeremy", "e9459fc5-3a15-4821-870f-3e3cb0c89196", "919-893-5464", "https://picsum.photos/640/480/?image=694", "Rohan" },
                    { 51, "Israel Pine", "Port Eloytown", "Et fugiat quaerat fuga tenetur voluptates quia dolores et officiis consequatur ullam cupiditate tenetur aut aspernatur corrupti ad repellat voluptatum explicabo vel possimus adipisci eaque temporibus quia et temporibus corporis.", "Gerald.Bergstrom70@gmail.com", "Gerald", "37b10bc5-6c90-4c08-b48f-041c7eee8924", "929-589-3403", "https://picsum.photos/640/480/?image=495", "Bergstrom" },
                    { 53, "Baumbach Parkways", "Elsafort", "Ut esse sed impedit et dolorem exercitationem molestias quod ea nulla ad fugit quia et nihil eligendi ducimus consectetur iusto voluptate iure non in voluptas earum eius iure perferendis quos.", "Maxine_Boyle@gmail.com", "Maxine", "0e98ad13-3593-404a-a927-68f3b9978f77", "(491) 530-0528", "https://picsum.photos/640/480/?image=743", "Boyle" },
                    { 60, "Liza Expressway", "Lindgrenshire", "Blanditiis quidem accusantium dolorem blanditiis voluptatem ullam facere sit mollitia et placeat iusto est ratione eos molestiae est quas aut explicabo quisquam reprehenderit quos libero enim necessitatibus delectus est ex.", "Louise.Rath13@yahoo.com", "Louise", "4a7b5118-4d12-42a0-a42c-59f694963379", "920-543-2999 x64945", "https://picsum.photos/640/480/?image=380", "Rath" },
                    { 55, "Bogisich Plains", "Koelpinhaven", "Iusto tenetur commodi itaque est eum consequatur nisi fugiat atque dolores voluptate ipsa incidunt quia perferendis excepturi beatae doloribus labore rerum voluptas nihil eveniet in quidem aut esse nihil enim.", "Kendra_Morar28@yahoo.com", "Kendra", "9120caf5-1067-417c-8943-48eeac2d230a", "(962) 314-0712", "https://picsum.photos/640/480/?image=353", "Morar" },
                    { 56, "Schamberger Station", "Lenoraborough", "Laudantium cum nobis possimus hic quia incidunt placeat quasi doloribus quasi cupiditate est perferendis iste explicabo vitae fugiat in et nesciunt quo non cum labore velit nihil itaque amet esse.", "Estelle_Lind@hotmail.com", "Estelle", "014eebfe-3f1d-4837-8279-05d342e49e11", "1-663-715-4500 x565", "https://picsum.photos/640/480/?image=515", "Lind" },
                    { 57, "Heaney Plain", "Schmelerburgh", "Nostrum iusto porro illum voluptates ullam minima ipsam sit architecto pariatur quia non qui nihil odio corrupti alias doloremque nihil illum quidem in et quia necessitatibus doloremque ullam temporibus adipisci.", "Angelica.Kertzmann42@yahoo.com", "Angelica", "3aa5f749-fabf-4c73-8546-341b8d62d94d", "894-574-0578 x25654", "https://picsum.photos/640/480/?image=33", "Kertzmann" },
                    { 58, "Jones Coves", "Meganefort", "Ut quaerat sint ea et nihil eos eos deleniti tenetur non totam facilis voluptatem ullam atque quos natus placeat mollitia quaerat dolor aut dolores numquam minima quo debitis facilis provident.", "Holly_Rempel@gmail.com", "Holly", "9466e24e-bce1-43c8-9c4b-a68b0a58f4ab", "1-870-666-8960 x2958", "https://picsum.photos/640/480/?image=310", "Rempel" },
                    { 59, "Schiller Haven", "Hayeschester", "Cum aut voluptatibus et veritatis quam et deserunt quia voluptatem magni placeat et hic dicta consectetur natus dignissimos sed voluptatibus commodi ad fugiat voluptatem cumque vitae vel maxime est est.", "Leona86@hotmail.com", "Leona", "6c77a083-0f44-4ea1-a75b-13f2227f2fe2", "1-293-543-7165", "https://picsum.photos/640/480/?image=541", "Ruecker" }
                });

            migrationBuilder.InsertData(
                table: "Petsitters",
                columns: new[] { "Id", "Address", "City", "Description", "Email", "Name", "Password", "PhoneNumber", "PhotoId", "Surname" },
                values: new object[,]
                {
                    { 47, "Jones Viaduct", "Lake Milanshire", "Suscipit qui consectetur provident culpa eligendi ut reprehenderit omnis iste harum pariatur ipsam et quos itaque et quia quo et voluptatem aut et ea odit velit sint perferendis corrupti et.", "Melissa23@gmail.com", "Melissa", "46b86928-bf7a-4b61-8f74-445e60a9da64", "539.692.7953", "https://picsum.photos/640/480/?image=254", "Mueller" },
                    { 54, "Kunde Rest", "Brownville", "Et et et voluptate aperiam labore optio corrupti consequatur itaque natus saepe error omnis voluptas consequatur amet sit minima aperiam facere quia qui voluptas numquam et officiis optio fugit ducimus.", "Roxanne.Schulist90@yahoo.com", "Roxanne", "15a59d77-9c91-402a-b2a7-157cb9b95d00", "245.327.9869 x426", "https://picsum.photos/640/480/?image=626", "Schulist" },
                    { 46, "Padberg Locks", "Lake Brigitte", "Labore veniam velit sit et architecto temporibus consequatur sit ab aliquam aut expedita quia et aut aliquam inventore ea occaecati rerum nemo voluptatem deleniti ea voluptatem nobis sed repellat iusto.", "Pat_Sipes92@yahoo.com", "Pat", "6d250e1e-51e5-4a00-83e0-aacad15a4025", "213-551-2827 x53794", "https://picsum.photos/640/480/?image=226", "Sipes" },
                    { 45, "Shayne Spurs", "Lake Emmet", "Quia cumque aperiam ducimus id autem est at fuga qui voluptas occaecati sint praesentium itaque eos eligendi rerum aut saepe aut est excepturi aut rerum cupiditate dicta velit deleniti et.", "Joanna49@yahoo.com", "Joanna", "38f04561-4bf9-4cac-8536-f76e69cae2bd", "1-808-547-7104 x633", "https://picsum.photos/640/480/?image=934", "Smith" },
                    { 44, "Jaylin Bridge", "Port Alfside", "Officia saepe et aut sapiente recusandae esse nihil et accusamus ut unde tenetur beatae asperiores architecto ipsa quaerat quis pariatur iure dolorem quia blanditiis cumque eveniet quas repellendus qui voluptas.", "Maggie_Lynch19@gmail.com", "Maggie", "f1595b02-209f-44f1-8644-ee1e9a82cb18", "406.952.4175 x53315", "https://picsum.photos/640/480/?image=659", "Lynch" },
                    { 32, "Brakus Union", "North Cierrabury", "Officia ea et molestias delectus aut sint qui numquam maxime molestias nam eveniet numquam et omnis enim odit ea pariatur nam est quidem voluptas numquam consequuntur qui ducimus reprehenderit sed.", "Alberto_Gutmann@yahoo.com", "Alberto", "baadd236-05e4-4a30-9b3f-1e388900fe17", "950-285-6007", "https://picsum.photos/640/480/?image=739", "Gutmann" },
                    { 33, "Dibbert Falls", "Elimouth", "Nisi accusamus asperiores perferendis praesentium nisi qui eius sed et sed et harum assumenda amet et quasi tempore blanditiis iste dolorem omnis magnam atque eum temporibus velit ipsum debitis quia.", "Felipe_Leannon@gmail.com", "Felipe", "e35f2bec-2255-4b3a-b6f5-8c55a5a82c7f", "(208) 670-2820", "https://picsum.photos/640/480/?image=767", "Leannon" },
                    { 34, "Roscoe Prairie", "Keeleyborough", "Earum aperiam ex at quo et voluptatem mollitia quasi vero impedit esse ab voluptatibus et dolorum officia debitis aut et sapiente officiis officia quasi ut maiores molestias ea reiciendis nobis.", "Meghan.Gleason92@gmail.com", "Meghan", "3b764cef-ada7-47ff-8b12-57502fbb4655", "(897) 676-5661", "https://picsum.photos/640/480/?image=779", "Gleason" },
                    { 35, "Trinity Hollow", "Bartellberg", "Repudiandae dolor minus nam ex sed quas officia facere aspernatur velit quia dolorum qui minus minima suscipit a maiores quidem et quia quis deleniti qui in provident in ipsam libero.", "Sara41@hotmail.com", "Sara", "4e45cc7d-ef1b-4231-bb9a-d9ce8ba13941", "1-468-390-4298", "https://picsum.photos/640/480/?image=417", "Bins" },
                    { 36, "Wyman Crescent", "Watersport", "Aut dolores repudiandae in eius sapiente accusamus nostrum qui provident pariatur animi porro fuga quia placeat pariatur praesentium consequuntur ut maxime quia in reprehenderit blanditiis id et tempore accusantium vel.", "Suzanne.Dietrich93@yahoo.com", "Suzanne", "6d57893d-bd71-49d8-a3db-1efd6e5e5b61", "1-857-682-8761 x207", "https://picsum.photos/640/480/?image=991", "Dietrich" },
                    { 37, "Lynch Land", "Dickinsonhaven", "Et molestiae enim excepturi dolor quia quae qui perferendis accusamus veniam enim eos cupiditate minima veniam aut animi non at ad magnam consequatur hic atque non voluptatem aut non iure.", "Bethany77@hotmail.com", "Bethany", "8033b810-808c-456a-943e-5d9f370e261b", "777-319-0516", "https://picsum.photos/640/480/?image=826", "Mann" },
                    { 31, "Frederik Heights", "West Ellen", "Enim tempore et aut labore repellendus officia ut omnis voluptate beatae voluptas quam non animi dolor et repellendus id aut quisquam ullam officiis ad dolores dolor cumque aut ab et.", "Andrew_Bogan31@hotmail.com", "Andrew", "bde4b865-eb27-44ca-8ad1-68511a4efb90", "910-546-9101 x100", "https://picsum.photos/640/480/?image=1033", "Bogan" },
                    { 39, "Purdy Inlet", "East Jesus", "Deserunt voluptatem eligendi omnis labore amet quia accusamus veritatis et deserunt voluptatum iusto aliquam ut rerum recusandae debitis voluptas porro magni fugit molestiae aut consequuntur deleniti et ex qui eum.", "Melba15@gmail.com", "Melba", "c77b43f0-2158-454f-a46c-c69ea4900a02", "(866) 821-2153 x5170", "https://picsum.photos/640/480/?image=721", "Littel" },
                    { 40, "Imani Wall", "Lake Alfredaville", "Cumque magni commodi dolores praesentium dolorem ratione reprehenderit ipsam id dolores officiis ut tempore reiciendis laudantium praesentium aut vitae saepe qui asperiores voluptatibus sit non neque consequatur exercitationem expedita laboriosam.", "Marcella.McDermott@yahoo.com", "Marcella", "35ede398-f037-4043-b72b-e9eedeaf828a", "840.445.7673 x822", "https://picsum.photos/640/480/?image=152", "McDermott" },
                    { 41, "Ortiz Fields", "South Rod", "Quaerat nisi maiores praesentium voluptas quisquam occaecati accusantium et vero numquam ad doloribus aut aspernatur est delectus sunt omnis temporibus iure nisi assumenda accusantium voluptatum aliquam expedita iusto ipsam delectus.", "Mandy63@gmail.com", "Mandy", "3db5a3f2-ee41-4ad9-9863-6686f76a0f45", "(587) 711-2218 x7949", "https://picsum.photos/640/480/?image=712", "Kuhn" },
                    { 42, "Fahey Creek", "Lebsackbury", "Autem facere maiores sequi et est qui quaerat dolores possimus atque qui officia provident consequatur in odit aut et exercitationem temporibus omnis culpa similique eveniet laboriosam labore officiis qui maxime.", "Juan_Lindgren57@gmail.com", "Juan", "4199f26c-1cb1-4765-baea-57a63eaad321", "1-332-495-9950", "https://picsum.photos/640/480/?image=574", "Lindgren" },
                    { 43, "Zita Locks", "West Erich", "Quia rem quaerat voluptas fugiat ut et et est alias animi ratione amet asperiores hic omnis fuga reiciendis optio nam perferendis et illo inventore omnis ullam qui similique possimus ut.", "Vicki.Hermann52@hotmail.com", "Vicki", "b816aaae-cc89-4165-9afb-c518a1e558df", "426.370.1424", "https://picsum.photos/640/480/?image=441", "Hermann" },
                    { 38, "Frami Camp", "West Melba", "Eos eligendi aliquid ut sequi sint velit nostrum aut dolores veritatis ab quidem sint dolor culpa non qui aut praesentium aut laborum molestias vitae magni quidem consequuntur accusamus nesciunt consequatur.", "Joshua76@yahoo.com", "Joshua", "353108b4-8f4b-4a14-9bc2-dedc9b78a821", "425-564-3060 x20613", "https://picsum.photos/640/480/?image=442", "Wisozk" }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "ImageId", "Name", "Unit" },
                values: new object[,]
                {
                    { 17, "Reiciendis qui eius necessitatibus consequatur.", "https://loremflickr.com/320/240?lock=1717711096", 4, 1 },
                    { 18, "Dolore corrupti qui itaque omnis.", "https://loremflickr.com/320/240?lock=848024654", 0, 0 },
                    { 19, "Dicta dicta eos quaerat accusantium.", "https://loremflickr.com/320/240?lock=16952326", 1, 1 },
                    { 20, "Et molestias tenetur tempora laborum.", "https://loremflickr.com/320/240?lock=708858163", 1, 0 },
                    { 21, "Voluptatem voluptas explicabo reiciendis illum.", "https://loremflickr.com/320/240?lock=433432689", 3, 0 },
                    { 22, "Consequatur tenetur quia aliquam illo.", "https://loremflickr.com/320/240?lock=1251311857", 2, 1 },
                    { 25, "Dolores odit enim sunt sunt.", "https://loremflickr.com/320/240?lock=1541424634", 4, 0 },
                    { 24, "Sit voluptatem debitis est nisi.", "https://loremflickr.com/320/240?lock=679990157", 3, 0 },
                    { 26, "Ipsa et blanditiis officia omnis.", "https://loremflickr.com/320/240?lock=963023015", 0, 0 },
                    { 27, "Consequatur quidem exercitationem illo laborum.", "https://loremflickr.com/320/240?lock=631340919", 3, 0 },
                    { 28, "Id ea est beatae illum.", "https://loremflickr.com/320/240?lock=1379883833", 4, 1 },
                    { 16, "Necessitatibus omnis molestiae eaque ab.", "https://loremflickr.com/320/240?lock=992154566", 4, 2 },
                    { 23, "Assumenda quisquam quis et unde.", "https://loremflickr.com/320/240?lock=1553377512", 3, 0 },
                    { 15, "Qui aspernatur mollitia accusantium quia.", "https://loremflickr.com/320/240?lock=641503537", 2, 0 },
                    { 8, "Voluptatum ut quos doloribus debitis.", "https://loremflickr.com/320/240?lock=294141962", 0, 2 },
                    { 13, "Fugit laudantium natus aspernatur natus.", "https://loremflickr.com/320/240?lock=1522666881", 3, 0 },
                    { 12, "Cumque pariatur dignissimos tenetur enim.", "https://loremflickr.com/320/240?lock=1957442382", 0, 1 },
                    { 11, "Dolores omnis inventore et et.", "https://loremflickr.com/320/240?lock=2109180396", 2, 0 },
                    { 10, "Porro quod quas totam alias.", "https://loremflickr.com/320/240?lock=1797499681", 1, 0 },
                    { 9, "Delectus modi dolorem ratione dignissimos.", "https://loremflickr.com/320/240?lock=395229782", 3, 0 },
                    { 29, "Dolores soluta et quia non.", "https://loremflickr.com/320/240?lock=516374598", 2, 0 },
                    { 7, "Est alias quia ut nulla.", "https://loremflickr.com/320/240?lock=1387034100", 1, 0 },
                    { 6, "Voluptas quia saepe earum est.", "https://loremflickr.com/320/240?lock=1733792009", 0, 0 },
                    { 5, "Aut et inventore ex aut.", "https://loremflickr.com/320/240?lock=20025034", 4, 2 }
                });

            migrationBuilder.InsertData(
                table: "Services",
                columns: new[] { "Id", "Description", "ImageId", "Name", "Unit" },
                values: new object[,]
                {
                    { 4, "Soluta incidunt cum exercitationem amet.", "https://loremflickr.com/320/240?lock=1632747932", 3, 0 },
                    { 3, "In aut accusantium inventore ad.", "https://loremflickr.com/320/240?lock=783108421", 0, 2 },
                    { 2, "Velit soluta ut vero voluptatum.", "https://loremflickr.com/320/240?lock=699112102", 0, 1 },
                    { 1, "Inventore animi aut consequatur pariatur.", "https://loremflickr.com/320/240?lock=1593273893", 3, 1 },
                    { 14, "Unde consequatur ut non accusantium.", "https://loremflickr.com/320/240?lock=1996233359", 4, 1 },
                    { 30, "Enim deserunt et dolor ut.", "https://loremflickr.com/320/240?lock=1096849045", 2, 1 }
                });

            migrationBuilder.InsertData(
                table: "BookingMessages",
                columns: new[] { "Id", "ClientId", "PetsitterId", "Text" },
                values: new object[,]
                {
                    { 9, 20, 31, "Doloremque dolore et omnis dolorem consequatur sed aut vero doloribus. Quo vitae velit. Sequi minus temporibus. Ratione aut laborum officiis aut officiis in autem ad quia. Ut omnis architecto error.\n\nEveniet ut dignissimos saepe tenetur animi natus fugit. Aut et non quaerat. Est ut rerum culpa ipsa quam quis. Et magnam non. Nobis porro possimus voluptatum omnis sint voluptatem eum aliquam eum. Odit consectetur veniam ab possimus.\n\nMolestias ut sit dolor consequatur alias repudiandae quos cupiditate. Veniam aut dignissimos adipisci soluta doloremque. Nulla ea optio dolore omnis quia debitis quis reprehenderit necessitatibus. Iure possimus consequatur laborum nostrum ipsa maxime. Voluptates et ut facere natus enim asperiores eos aut qui. Voluptatem nihil nesciunt consequatur sed in odit et a inventore.\n\nAut aut vel odit assumenda sunt. Sint ea ducimus id quia aut dolores est. Reiciendis iste ut est." },
                    { 1, 24, 57, "Labore dolor enim eveniet alias voluptate rerum. Inventore sit culpa est temporibus. Quidem optio et ut. Eveniet non voluptatum quo unde maxime atque.\n\nDelectus enim alias voluptatibus. Et nesciunt sint quos voluptates alias ab quis aut. Accusamus omnis ut assumenda qui maiores sed quos ut.\n\nSit voluptas laudantium voluptas voluptatem occaecati. Rerum veniam maxime dolor mollitia minus. Ipsa quisquam sed sequi ut perspiciatis est aspernatur optio nulla.\n\nQuo error quaerat et qui expedita repellendus qui in. Qui qui omnis deleniti et est. Aperiam est dolorem ut necessitatibus voluptate voluptatem sit suscipit. Et vel incidunt quasi dolorum reiciendis quis aut fugiat. Pariatur molestiae cupiditate consequatur minima corporis. Ut voluptatum qui inventore saepe a enim distinctio." },
                    { 10, 14, 56, "Tempora iure neque. Sit nihil temporibus necessitatibus. Velit autem rerum sit neque modi est iusto recusandae. Nihil est eaque ea impedit temporibus aut. In quo consequatur expedita occaecati quis enim debitis.\n\nQui sit reiciendis expedita nulla ex mollitia quia delectus tenetur. Suscipit sunt suscipit ut et eaque nihil consectetur accusantium. Nihil non repellendus reprehenderit dolor in. At ut repudiandae quis voluptas pariatur voluptatibus id omnis.\n\nNobis omnis officia qui voluptatem eum veritatis eos doloremque. Mollitia suscipit nulla nobis aliquid totam accusantium sed adipisci. Libero a voluptas ut optio.\n\nQuos est aliquid ullam consequatur doloribus qui. Ut accusamus animi consectetur a voluptas eaque. Alias quaerat recusandae et id." },
                    { 4, 8, 54, "Et sunt dicta. In vel commodi ex. Ducimus dicta excepturi neque dolore tempora. Unde ducimus ut facere voluptatem suscipit porro beatae sint. Voluptatem eum non et labore quas.\n\nDistinctio asperiores est ut perspiciatis ea molestias natus voluptas. Quaerat itaque numquam quae. Vel aut nisi commodi delectus placeat. At consequatur nobis asperiores omnis voluptatibus molestiae. Non culpa est suscipit officia incidunt quia facilis.\n\nDolore omnis aut omnis qui in. Numquam et unde repellat. Qui est beatae dolores eos rerum eius omnis at non. Est a soluta dolorem. Praesentium dolore quaerat nesciunt iusto accusamus quisquam doloribus sint corporis. Odit et suscipit beatae.\n\nIpsam odio repellat quaerat qui explicabo deleniti molestiae. Facilis porro et quia mollitia. Velit enim possimus expedita. Quo praesentium ad illo dicta. Quo blanditiis fugit placeat sint qui aliquam. Rerum et ipsum." },
                    { 8, 19, 52, "Velit quis sapiente eos est voluptatem odit reiciendis. Nemo deserunt sunt dignissimos repellat eligendi aperiam nemo eum. Sint excepturi ducimus hic consequatur. Velit voluptates ullam eos quo delectus et voluptatem ut accusantium. Eum est consequatur debitis qui officiis occaecati.\n\nLaudantium rem beatae veritatis voluptatem voluptatum rerum voluptas ut magni. Laboriosam deserunt velit qui aliquid consequatur voluptas aut laboriosam qui. Ut aut consequuntur sed et dolorem molestiae non rerum. Ea quam deleniti est fugiat ut illum commodi vitae sed. Velit veritatis tempora.\n\nOmnis cupiditate est doloremque molestias magnam. Quidem sunt odit itaque. Vero inventore ut.\n\nAperiam voluptatibus quia porro est occaecati. Voluptatem est quaerat consectetur quibusdam corrupti voluptates. Sapiente consequuntur enim ut sequi est quam odit velit nulla. Est ullam optio quas." },
                    { 15, 23, 49, "Quis quis blanditiis incidunt laboriosam tempora dignissimos omnis vitae. Molestiae et harum et nesciunt ratione et quidem labore. Et non alias nostrum voluptatem saepe quod perferendis. Explicabo rerum qui in voluptatem mollitia ex ex reiciendis. Doloribus ab omnis quidem voluptatum id eligendi officiis.\n\nVoluptatibus exercitationem ut sint et repellendus architecto consequatur neque. Dignissimos atque et doloribus doloribus aut optio ab consequatur aperiam. Autem necessitatibus sint dolore facilis corporis in non est. Voluptatem et velit consequatur et sint numquam quo. Occaecati doloribus consectetur et minima quas.\n\nEst et et rerum molestias facilis aut amet ea. Ut eius atque. Voluptas rem minima nihil quam incidunt. Amet inventore atque laboriosam. Sint vel animi qui quidem quod accusantium non non doloremque.\n\nSint quam consectetur dolorum in eos rerum dolores asperiores voluptatem. Quisquam repellendus vero vitae. Deserunt praesentium odio nihil corporis dolorum. Adipisci officia culpa esse. Consectetur a similique vel est nostrum voluptates. Ipsa natus temporibus." },
                    { 5, 1, 49, "Minus vitae modi alias commodi adipisci impedit ipsa optio. Culpa quam qui et vero neque. Ipsum quo quaerat voluptatem ipsam id magni ut quis ad.\n\nLabore est facere et excepturi aut autem ab illo est. Consequuntur velit quam voluptatem itaque doloremque. Dolore repellendus beatae tempora qui dolorem eveniet possimus. Deleniti explicabo minus doloribus et possimus. Blanditiis et dolorem sint. Optio deleniti fugit.\n\nVelit magni est eveniet nisi adipisci. Cumque accusantium dolorem qui. Ut qui id. Nobis eveniet tenetur voluptatem minus quas quis ut sapiente. Aut aut animi unde corporis sapiente. Consequatur facere assumenda voluptatem occaecati.\n\nDolores nostrum saepe officia quia dignissimos similique labore ipsam voluptatem. Qui nesciunt similique. Voluptates possimus laboriosam recusandae aut vitae magni aspernatur." },
                    { 14, 11, 53, "Eius quas quod dolor ab dicta deserunt illum et. Dignissimos enim ullam quo omnis et voluptate. Et quos sequi eum. Officia enim possimus debitis eos repellendus totam numquam. Aperiam laborum aut est voluptas.\n\nNemo dolorem et cum consectetur quidem velit et necessitatibus. Non quod error et amet dolorum iure consequatur sequi. Nostrum quia minus aperiam mollitia reprehenderit qui ad est. Voluptatem deserunt expedita ipsam laborum quia ut sequi et. Fugit quo doloribus voluptatem aliquam qui est accusamus nulla asperiores. Et nobis necessitatibus similique aut iusto.\n\nEt dolores et. Inventore nobis recusandae dicta. Illum eos beatae ut nemo. Placeat blanditiis eius impedit. Accusamus quod ad molestiae eligendi laboriosam aliquid et voluptas.\n\nNecessitatibus tenetur architecto cumque blanditiis consectetur id. Suscipit quia rerum in ab maiores repudiandae aliquam quos deleniti. Fugit aut qui consequatur. Veritatis eius dolores ut. Suscipit doloremque voluptatem quas nemo aut consequuntur neque." },
                    { 11, 12, 45, "Ea dolor ipsum est et voluptatem. Voluptatibus corporis sunt. Cum blanditiis tempora nisi voluptatem dolor. Animi nihil molestiae. Itaque harum officia voluptas. Voluptas aut sint.\n\nQui vel aut non velit. Ut omnis voluptatum non et facere fuga est unde. Deserunt et molestiae. Dolor provident iste sed voluptas ut. Beatae enim ea consequatur. Sunt et veniam rerum numquam magni.\n\nQuod ab hic porro qui sit. Ut exercitationem reiciendis. Ipsum quos mollitia similique. Aliquam saepe quis officiis facilis ut labore sed quia. Sit natus voluptate et vel. Hic doloremque nam qui qui voluptas.\n\nProvident ut repellendus sit amet fugiat necessitatibus reiciendis. Esse iure quia omnis reiciendis facere. Consequatur eum molestias voluptatem alias ducimus. Iure neque quo eius laudantium recusandae. Veniam velit ea quo laboriosam voluptate deleniti voluptates non." },
                    { 6, 26, 45, "Tempora eum quo id neque possimus illo dolorem. Est repellendus rerum occaecati saepe accusamus. Minima sed quisquam aut est exercitationem voluptas aut consequatur. Aliquam illum commodi adipisci velit est laudantium. Laboriosam velit voluptatum porro pariatur dolorem aut quod ad. Aut qui velit doloribus non.\n\nRerum qui illo ut recusandae maiores eum autem in. Ut laudantium dolore adipisci inventore deleniti facere. Praesentium ipsam error nobis saepe cumque aperiam. Ut aperiam esse.\n\nId doloremque quis totam qui. Accusamus ea nihil est et enim. Et minima accusantium odit sint.\n\nIusto placeat sit aliquam quaerat dolore aliquid et. Ducimus autem vel in labore et et officiis qui rem. Rerum voluptatem eaque. Rerum esse sunt fugiat facere asperiores iusto sed. Occaecati dolorem at aut sed quia. Inventore alias quos aut vero." },
                    { 13, 25, 43, "Nihil qui sed aliquid. Qui maiores facere. Non consequatur tenetur dolor quo aliquam ex sint qui. Veniam repellendus ut voluptate libero odio eligendi reiciendis aut ut.\n\nArchitecto officia asperiores nulla nulla. Necessitatibus necessitatibus itaque quisquam aut. Ipsam est facere rerum aut asperiores non earum tenetur.\n\nNihil ea quia provident voluptates velit voluptatum reiciendis corrupti eum. Recusandae commodi repellendus doloribus velit repellat doloremque error. Error nobis natus. Voluptatem est consequatur. Perferendis suscipit dicta enim aliquam officia similique corrupti libero. Reiciendis deleniti laudantium maxime et a est quo iure.\n\nQui non repudiandae. Omnis iusto quod quibusdam vitae molestias. Animi animi sapiente voluptatem." },
                    { 12, 12, 42, "Doloribus occaecati quos. Aut ad amet et facere sit numquam et. Quod qui ipsum.\n\nMolestiae quae nam dolores aut delectus quae. Ut asperiores ut ut eos earum et iure. Accusamus tempore perferendis dolore amet maxime repudiandae. Beatae qui inventore magnam nam vitae quod.\n\nHic nesciunt qui at unde cupiditate et sit non. Voluptatem at adipisci ad. Optio ut non dolores laudantium consequatur et corporis placeat. Saepe qui maiores reprehenderit soluta voluptates neque.\n\nAsperiores rerum asperiores et quia ratione. Sint aliquam unde necessitatibus cum. Accusamus quia omnis molestiae iste et asperiores iure impedit vero. Dolore et nihil nam earum dolore veniam eos." },
                    { 3, 9, 42, "Dolore et nisi ipsum eaque aut maxime. Veniam voluptatem explicabo. Adipisci dolorem similique sint rerum suscipit fugit. Et labore aspernatur. Voluptates repellendus quis. Sed in commodi excepturi odit omnis sed sit optio.\n\nIure et impedit sunt exercitationem rerum quam voluptatem magni. Voluptate doloribus eaque neque placeat est consequatur. Quaerat quaerat aliquam quod et occaecati nihil tenetur qui. Esse dolorum iure modi dolorum qui.\n\nNumquam voluptatem et velit. Laudantium labore enim magni officia voluptas. Ex dicta velit esse iusto. Dolores est alias. Eum nisi corporis delectus.\n\nIpsum amet consequatur blanditiis iusto deserunt voluptatum. Delectus inventore est temporibus et est reprehenderit sed fuga. Aut sit nihil ut. Iste sunt beatae sequi doloremque assumenda blanditiis eveniet cupiditate. Minus aut earum eius officiis repudiandae voluptas. Nisi qui vel exercitationem nihil ratione aliquid." },
                    { 2, 19, 35, "Sequi repellat aut corrupti at dolores rerum nisi voluptas. Placeat reprehenderit tempore qui enim voluptatibus aut dolorem ex. Qui omnis asperiores at itaque placeat omnis vero sapiente voluptate. Ea dolorem voluptatibus cum vel maxime. Tempore tempore rerum sapiente voluptatem iusto.\n\nIure quasi est. Omnis doloribus voluptatem officia labore. Alias magnam unde aut autem dolor. Sint quis reprehenderit error eligendi ratione. Ut tempore dolores nobis enim fuga odio natus consequuntur itaque.\n\nIpsum tempore vero voluptatum explicabo ut quod veniam. Dolores necessitatibus similique exercitationem eos in. Et suscipit odio optio et quibusdam. Debitis quos culpa.\n\nTenetur dignissimos quia laborum quod est laborum. Veritatis saepe exercitationem voluptas hic et excepturi id. Non iure qui quae eaque dolores temporibus et nam. Quis et reiciendis maiores excepturi a quia voluptas recusandae." },
                    { 7, 27, 47, "Nulla voluptatem autem dignissimos. Omnis quis quo aliquid laborum nulla tempore occaecati fugit. Aut tempore debitis aut velit omnis nihil possimus cupiditate magni.\n\nExpedita veritatis consequatur aspernatur ut quos mollitia voluptates voluptas inventore. Et quod ut qui expedita quas ea libero. Necessitatibus sunt delectus sit nam asperiores libero.\n\nQui at ipsam quo saepe et. Perspiciatis excepturi corporis dolor et sed beatae tenetur. Tempora eos officiis. Voluptas aliquam neque laudantium totam asperiores dicta aspernatur.\n\nUnde dolorem eos corrupti ducimus quia. Illum pariatur voluptates quos fugit. Illo corrupti dolorum nobis dolores aut sit iusto at autem. Expedita qui est pariatur consequatur ut ut omnis sint. Possimus aliquid dolor." }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 36, 47, 63.0, 17 },
                    { 11, 45, 92.0, 19 },
                    { 66, 49, 97.0, 18 },
                    { 63, 57, 114.0, 18 },
                    { 61, 58, 100.0, 18 },
                    { 29, 57, 59.0, 18 },
                    { 22, 49, 100.0, 18 },
                    { 89, 48, 108.0, 17 },
                    { 50, 59, 138.0, 16 },
                    { 23, 60, 123.0, 13 },
                    { 55, 42, 106.0, 15 },
                    { 76, 53, 141.0, 14 },
                    { 72, 52, 81.0, 14 },
                    { 45, 38, 82.0, 14 },
                    { 34, 34, 143.0, 14 },
                    { 13, 39, 110.0, 14 },
                    { 78, 38, 118.0, 19 },
                    { 2, 46, 40.0, 13 },
                    { 85, 44, 41.0, 12 },
                    { 35, 54, 53.0, 16 },
                    { 26, 59, 138.0, 20 },
                    { 56, 56, 141.0, 24 },
                    { 70, 34, 75.0, 21 },
                    { 74, 47, 54.0, 29 },
                    { 14, 50, 99.0, 29 },
                    { 64, 56, 56.0, 28 },
                    { 3, 44, 128.0, 28 }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 79, 45, 95.0, 27 },
                    { 27, 48, 111.0, 27 },
                    { 19, 50, 140.0, 27 },
                    { 41, 41, 46.0, 26 },
                    { 86, 55, 30.0, 25 },
                    { 69, 58, 122.0, 25 },
                    { 5, 41, 123.0, 25 },
                    { 84, 57, 53.0, 24 },
                    { 81, 40, 136.0, 24 },
                    { 60, 47, 90.0, 24 },
                    { 73, 56, 44.0, 12 },
                    { 49, 57, 144.0, 24 },
                    { 52, 50, 101.0, 23 },
                    { 40, 57, 31.0, 22 },
                    { 37, 33, 60.0, 22 },
                    { 28, 34, 130.0, 21 },
                    { 62, 60, 39.0, 12 },
                    { 46, 52, 49.0, 11 },
                    { 38, 31, 68.0, 12 },
                    { 24, 33, 123.0, 6 },
                    { 20, 59, 78.0, 6 },
                    { 4, 32, 92.0, 6 },
                    { 8, 45, 61.0, 5 },
                    { 53, 55, 58.0, 4 },
                    { 43, 46, 137.0, 4 },
                    { 25, 42, 67.0, 4 },
                    { 80, 32, 99.0, 3 },
                    { 44, 48, 79.0, 3 },
                    { 88, 56, 71.0, 2 },
                    { 82, 40, 110.0, 2 },
                    { 75, 37, 39.0, 2 },
                    { 68, 31, 94.0, 2 },
                    { 67, 59, 30.0, 2 },
                    { 48, 59, 100.0, 2 },
                    { 1, 42, 56.0, 2 },
                    { 54, 41, 81.0, 1 },
                    { 12, 59, 115.0, 1 },
                    { 9, 41, 109.0, 1 },
                    { 83, 57, 134.0, 6 },
                    { 59, 60, 126.0, 12 },
                    { 87, 44, 73.0, 6 },
                    { 10, 38, 55.0, 7 }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 18, 58, 76.0, 12 },
                    { 17, 48, 69.0, 12 },
                    { 77, 33, 126.0, 11 },
                    { 47, 50, 35.0, 11 },
                    { 51, 36, 92.0, 30 },
                    { 31, 54, 60.0, 11 },
                    { 16, 44, 96.0, 11 },
                    { 65, 58, 68.0, 10 },
                    { 39, 52, 95.0, 10 },
                    { 42, 50, 132.0, 9 },
                    { 30, 35, 46.0, 9 },
                    { 71, 54, 72.0, 8 },
                    { 33, 57, 110.0, 8 },
                    { 15, 56, 113.0, 8 },
                    { 7, 53, 94.0, 8 },
                    { 90, 49, 97.0, 7 },
                    { 58, 42, 77.0, 7 },
                    { 32, 38, 118.0, 7 },
                    { 21, 43, 115.0, 7 },
                    { 6, 45, 35.0, 7 },
                    { 57, 57, 147.0, 30 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookingMessages_ClientId",
                table: "BookingMessages",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingMessages_PetsitterId",
                table: "BookingMessages",
                column: "PetsitterId");

            migrationBuilder.CreateIndex(
                name: "IX_PetSupportServices_PetsitterId",
                table: "PetSupportServices",
                column: "PetsitterId");

            migrationBuilder.CreateIndex(
                name: "IX_PetSupportServices_ServiceId",
                table: "PetSupportServices",
                column: "ServiceId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingMessages");

            migrationBuilder.DropTable(
                name: "PetSupportServices");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "Petsitters");

            migrationBuilder.DropTable(
                name: "Services");
        }
    }
}
