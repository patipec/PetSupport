using Microsoft.EntityFrameworkCore.Migrations;

namespace PetSupport.Infrastructure.Data.Migrations
{
    public partial class AddFakeData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Services");

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
                columns: new[] { "Id", "City", "Description", "Email", "Name", "Password", "PhoneNumber", "PhotoId", "Surname" },
                values: new object[,]
                {
                    { 48, "Sarahside", "Enim qui occaecati cum quia commodi adipisci eum nihil dolorem est non et minima quia occaecati aspernatur mollitia atque quo sint doloribus in facere hic mollitia accusamus facere quo quis.", "Agnes57@gmail.com", "Agnes", "e0247523-4d1f-43fd-9c62-00827f16113b", "415-856-5375", "https://picsum.photos/640/480/?image=338", "Cronin" },
                    { 52, "New Koreyborough", "Temporibus corporis blanditiis ut itaque nemo quae blanditiis qui animi qui laborum est quo atque natus esse praesentium perferendis est quasi et non eum aut est est est architecto et.", "Luther.Schimmel62@gmail.com", "Luther", "51c79a5d-0542-459e-a24a-3e94fd6eea6c", "(765) 389-1447", "https://picsum.photos/640/480/?image=635", "Schimmel" },
                    { 49, "West Alexandrine", "Cupiditate aperiam sint non minus quasi beatae et quam molestiae non eos quo fuga quia tenetur sed dignissimos et neque quia quae ex explicabo ratione modi praesentium aspernatur soluta sit.", "Marty.Medhurst@gmail.com", "Marty", "90db37a1-c3d4-4b40-bf8e-6763462dfb98", "1-806-658-3038 x776", "https://picsum.photos/640/480/?image=865", "Medhurst" },
                    { 50, "New Lorena", "Quia voluptatem placeat et necessitatibus tempora iusto itaque cumque quis occaecati expedita doloremque repudiandae illum velit sapiente rerum voluptatem perspiciatis dolores et esse voluptatibus maiores recusandae ut voluptas quo pariatur.", "Hilda_Gibson77@gmail.com", "Hilda", "3738054f-d13b-4ab7-9b02-c8c89fede704", "636.574.1464", "https://picsum.photos/640/480/?image=898", "Gibson" },
                    { 51, "North Tatyana", "Accusamus praesentium fugit et sit corporis illum magni veritatis voluptatem blanditiis voluptas esse voluptatem debitis esse minima repudiandae debitis recusandae laboriosam iusto eaque ea provident et voluptatem consequatur quo a.", "Max_Reynolds43@yahoo.com", "Max", "7f84667d-7930-44a3-b85d-edf3445f45bb", "(968) 424-9257 x70936", "https://picsum.photos/640/480/?image=563", "Reynolds" },
                    { 53, "East Herbert", "Voluptatem debitis reiciendis ea possimus voluptas nesciunt illo magni atque voluptatibus dolor alias et suscipit nisi aut laudantium ut asperiores molestias aspernatur consequatur sit eaque quae doloremque tempora aliquid corporis.", "Edgar.Russel@yahoo.com", "Edgar", "f3787945-9675-42b2-9e63-5ec96e6a5d20", "(475) 375-5836", "https://picsum.photos/640/480/?image=25", "Russel" },
                    { 60, "Lake Alan", "Qui et quia recusandae eaque iste vero vel illo eos cum aut voluptatibus et veritatis quam et deserunt quia voluptatem magni placeat et hic dicta consectetur natus dignissimos sed voluptatibus.", "Margie33@gmail.com", "Margie", "0d26f979-20db-4435-8cb5-930b8ec0aba9", "1-648-672-9310 x493", "https://picsum.photos/640/480/?image=392", "Grant" },
                    { 55, "Morarville", "Corrupti consequatur itaque natus saepe error omnis voluptas consequatur amet sit minima aperiam facere quia qui voluptas numquam et officiis optio fugit ducimus in asperiores aut velit et quos est.", "Sergio69@gmail.com", "Sergio", "78ea2fcc-bd8b-4707-950f-1c09c1915c9c", "(339) 734-0186 x358", "https://picsum.photos/640/480/?image=944", "Adams" },
                    { 56, "Port Kenna", "Tenetur commodi itaque est eum consequatur nisi fugiat atque dolores voluptate ipsa incidunt quia perferendis excepturi beatae doloribus labore rerum voluptas nihil eveniet in quidem aut esse nihil enim voluptas.", "Bryan.Barton43@hotmail.com", "Bryan", "b5f2ff29-6bee-4efa-94ca-ec9e932fb3b1", "571.223.9353", "https://picsum.photos/640/480/?image=947", "Barton" },
                    { 57, "Lenoraborough", "Laudantium cum nobis possimus hic quia incidunt placeat quasi doloribus quasi cupiditate est perferendis iste explicabo vitae fugiat in et nesciunt quo non cum labore velit nihil itaque amet esse.", "Jeremiah_Walter@hotmail.com", "Jeremiah", "330b78a4-6c8b-4483-8874-7a5bc5c21820", "1-356-663-1545 x00565", "https://picsum.photos/640/480/?image=515", "Walter" },
                    { 58, "Cartwrighthaven", "Nihil quia consectetur aliquid unde facere dignissimos nihil nostrum iusto porro illum voluptates ullam minima ipsam sit architecto pariatur quia non qui nihil odio corrupti alias doloremque nihil illum quidem.", "Alexandra71@hotmail.com", "Alexandra", "280bcb53-0bc8-4754-b9e5-025d237af3af", "988-749-4740 x57825", "https://picsum.photos/640/480/?image=623", "Schoen" },
                    { 59, "East Rodgerhaven", "Veniam dolorem rerum fuga nesciunt occaecati culpa ut quaerat sint ea et nihil eos eos deleniti tenetur non totam facilis voluptatem ullam atque quos natus placeat mollitia quaerat dolor aut.", "Clifford.Schamberger@gmail.com", "Clifford", "5fc4b9f9-8368-4885-aa3d-356089dc271e", "1-446-408-5067 x8570", "https://picsum.photos/640/480/?image=147", "Schamberger" }
                });

            migrationBuilder.InsertData(
                table: "Petsitters",
                columns: new[] { "Id", "City", "Description", "Email", "Name", "Password", "PhoneNumber", "PhotoId", "Surname" },
                values: new object[,]
                {
                    { 47, "New Deionfort", "Reprehenderit sint nemo reiciendis non voluptatem porro ut unde iure magnam consequatur eveniet voluptas vero veritatis occaecati eligendi dolorem et est repellat id facere nisi vitae hic quis voluptatum laborum.", "Jeannie.OConnell@yahoo.com", "Jeannie", "b7e68e5e-cf70-4d05-826e-4959b4c09c81", "1-548-589-2213 x80733", "https://picsum.photos/640/480/?image=502", "O'Connell" },
                    { 54, "Hattieton", "Eligendi ducimus consectetur iusto voluptate iure non in voluptas earum eius iure perferendis quos nobis sed nemo et eos ipsa in et omnis vel debitis provident non ipsa sint sint.", "Kathryn70@gmail.com", "Kathryn", "8406f66a-4c40-4c9d-b610-ac273feccfc0", "843-661-5618", "https://picsum.photos/640/480/?image=618", "Gutmann" },
                    { 46, "South Angus", "Odit molestiae quia vel omnis consectetur tempora consequatur numquam impedit cupiditate autem quisquam sapiente praesentium facere adipisci voluptatibus illo beatae sint accusamus qui molestiae ab nobis sed odio dignissimos aut.", "Traci_McGlynn84@yahoo.com", "Traci", "1f69dea0-68cd-436c-8f28-1a75ba9e3842", "(857) 840-4370 x47778", "https://picsum.photos/640/480/?image=712", "McGlynn" },
                    { 45, "Pablomouth", "Sint aut molestiae quae consequatur quam assumenda temporibus aut veritatis et et nemo voluptas quaerat cupiditate soluta et voluptatem animi officia accusantium atque est perferendis ea soluta aut et dolore.", "Mary.Jenkins60@yahoo.com", "Mary", "2f89ac0f-9571-460c-8dbe-f6b359117b3e", "894-976-8559", "https://picsum.photos/640/480/?image=477", "Jenkins" },
                    { 44, "Brisatown", "Aliquid enim amet mollitia minima quibusdam vero asperiores tenetur aspernatur sed corporis eos eum nihil nemo deleniti dolor architecto aut tempore vel omnis incidunt sint quis est illum id culpa.", "Priscilla_Wehner@hotmail.com", "Priscilla", "3783b361-f3bf-4f25-8008-fef72cd7d29a", "1-205-711-9956 x96609", "https://picsum.photos/640/480/?image=273", "Wehner" },
                    { 32, "Isaiahbury", "Quia sit sint qui eligendi officia ea et molestias delectus aut sint qui numquam maxime molestias nam eveniet numquam et omnis enim odit ea pariatur nam est quidem voluptas numquam.", "Maurice.Hane1@hotmail.com", "Maurice", "b3d90daf-0c36-44f4-b81f-ee0e21fdcae4", "(980) 290-5085", "https://picsum.photos/640/480/?image=135", "Hane" },
                    { 33, "Cassandramouth", "Unde est et laborum provident quos qui ipsum quas alias dolores voluptates nisi accusamus asperiores perferendis praesentium nisi qui eius sed et sed et harum assumenda amet et quasi tempore.", "Wilbur.Bartoletti@hotmail.com", "Wilbur", "4ac66540-6b93-4790-adc0-e03b11b0f9ac", "695.206.2480", "https://picsum.photos/640/480/?image=495", "Bartoletti" },
                    { 34, "Quitzonbury", "Nostrum tempora debitis sit ex consequatur itaque sunt optio veniam quia sed amet sint esse hic recusandae debitis explicabo quisquam corporis molestiae earum aperiam ex at quo et voluptatem mollitia.", "Tyrone.Hoppe86@yahoo.com", "Tyrone", "e6fe39b0-7de2-4b32-be47-80ec42656460", "382.942.6858", "https://picsum.photos/640/480/?image=75", "Hoppe" },
                    { 35, "Dustinborough", "Nam in quas explicabo nobis ea numquam in vel omnis ipsam porro qui deleniti eum non velit repudiandae dolor minus nam ex sed quas officia facere aspernatur velit quia dolorum.", "Cary52@gmail.com", "Cary", "c682f983-87a1-4cfa-b38a-276df1c9ea7f", "1-949-667-7532 x86510", "https://picsum.photos/640/480/?image=891", "Bergstrom" },
                    { 36, "Mikelstad", "Deleniti quae dicta perferendis cupiditate cupiditate saepe tempora nulla officia eius sit iure consequuntur temporibus et rerum accusamus illo recusandae aut dolores repudiandae in eius sapiente accusamus nostrum qui provident.", "Ora.Nienow74@hotmail.com", "Ora", "ba59d2ed-1854-470e-a7fc-f5eb41dd4f65", "229-438-3195 x93817", "https://picsum.photos/640/480/?image=921", "Nienow" },
                    { 37, "West Sally", "Libero maiores qui id aliquam qui laboriosam impedit rerum est iure sit aperiam praesentium laboriosam illum optio necessitatibus rerum aut omnis et molestiae enim excepturi dolor quia quae qui perferendis.", "Dominic.Stanton66@yahoo.com", "Dominic", "aff0cc1e-f062-4169-9d55-842723f7aa12", "(299) 595-6915 x7566", "https://picsum.photos/640/480/?image=945", "Stanton" },
                    { 31, "West Ellen", "Enim tempore et aut labore repellendus officia ut omnis voluptate beatae voluptas quam non animi dolor et repellendus id aut quisquam ullam officiis ad dolores dolor cumque aut ab et.", "Andrew_Bogan31@hotmail.com", "Andrew", "d2618bd1-40dc-4a88-91f4-e17a8cc157ed", "910-546-9101 x100", "https://picsum.photos/640/480/?image=1033", "Bogan" },
                    { 39, "North Carastad", "Ut tempore ut rem hic beatae non est voluptas ullam ut quia et rem est quae consequatur inventore est at totam voluptatem et repellat nisi rem ad sunt veritatis et.", "Caroline_Beier@yahoo.com", "Caroline", "b10d398b-9a7d-4fc8-9222-ec8eed2d4df4", "1-601-661-8104", "https://picsum.photos/640/480/?image=687", "Beier" },
                    { 40, "New Daniela", "Illo dolor eaque non voluptatem molestiae similique aliquam dignissimos repellendus nobis voluptate voluptatem voluptates voluptatem aut voluptatum in fugit quidem rerum veritatis velit vero voluptatem eos nihil ad animi aut.", "Kerry.Ryan@gmail.com", "Kerry", "ec34fe9e-fe46-49ed-ab43-504aac0ca3df", "1-987-971-1491 x48358", "https://picsum.photos/640/480/?image=697", "Ryan" },
                    { 41, "Colefort", "Aut recusandae laudantium a voluptatem deleniti aperiam dolores ea nulla dolore iure praesentium voluptas enim aliquam asperiores occaecati optio rem qui perferendis quia et accusamus voluptatem eligendi facilis temporibus quidem.", "Kelly_Hettinger@hotmail.com", "Kelly", "ae16fdcb-f09a-4fa2-a637-46d257c864c6", "744.990.8399 x12102", "https://picsum.photos/640/480/?image=886", "Hettinger" },
                    { 42, "Aubreyburgh", "Maiores excepturi et dicta quo earum sed consequatur quod sequi perspiciatis et quas molestiae maiores eius et voluptas praesentium doloribus molestiae reiciendis aut a sed vitae facilis velit ab neque.", "Timmy_Grant95@gmail.com", "Timmy", "393da671-8524-4c8a-8596-6665bd064e1d", "1-698-222-9107 x9077", "https://picsum.photos/640/480/?image=636", "Grant" },
                    { 43, "Laylatown", "Quam quaerat laudantium corrupti occaecati et reprehenderit tempora et recusandae quia eveniet dolor ad corporis deleniti ad quae rerum nulla dolor totam impedit quo molestias dolorem velit autem quia in.", "Terrence.Krajcik17@yahoo.com", "Terrence", "0d48e17d-8c90-4949-a6f7-42c504a85f89", "1-517-444-5503 x1862", "https://picsum.photos/640/480/?image=949", "Krajcik" },
                    { 38, "Halieburgh", "Eius maxime repellat in rem voluptatum itaque reprehenderit adipisci eos inventore velit nihil rerum illo et magnam et porro placeat velit non laboriosam nam sequi voluptas eos eligendi aliquid ut.", "Eva_Graham35@gmail.com", "Eva", "3702243c-6e22-4505-b4b5-9cebab3db2c1", "837.681.8854", "https://picsum.photos/640/480/?image=166", "Graham" }
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
                    { 4, 3, 33, "Quis dolorem sed in commodi excepturi odit omnis sed. Optio voluptas placeat iure. Impedit sunt exercitationem rerum quam voluptatem magni iste voluptate doloribus. Neque placeat est. Voluptas quaerat quaerat. Quod et occaecati nihil tenetur.\n\nEsse dolorum iure modi dolorum qui. Sequi numquam voluptatem et velit corrupti laudantium labore. Magni officia voluptas ut ex. Velit esse iusto. Dolores est alias.\n\nNisi corporis delectus ut molestias ipsum. Consequatur blanditiis iusto deserunt. At delectus inventore est temporibus et.\n\nSed fuga ut aut sit nihil. Repellendus iste sunt beatae sequi doloremque assumenda blanditiis eveniet cupiditate. Minus aut earum eius officiis repudiandae voluptas. Nisi qui vel exercitationem nihil ratione aliquid. Voluptatem porro quasi et sunt dicta velit in vel." },
                    { 7, 16, 59, "Autem minima sed quisquam aut est exercitationem voluptas aut. Officia aliquam illum commodi adipisci velit est laudantium assumenda. Velit voluptatum porro pariatur dolorem. Quod ad corporis. Qui velit doloribus non suscipit qui rerum qui illo ut. Maiores eum autem in quas ut laudantium dolore adipisci inventore.\n\nOmnis praesentium ipsam error nobis saepe cumque aperiam voluptatem. Aperiam esse dolor voluptatem id doloremque quis. Qui velit accusamus ea nihil est. Enim voluptatem et minima accusantium odit sint repudiandae distinctio iusto.\n\nAliquam quaerat dolore. Et repudiandae ducimus autem vel. Labore et et officiis qui rem. Rerum voluptatem eaque. Rerum esse sunt fugiat facere asperiores iusto sed. Occaecati dolorem at aut sed quia.\n\nAlias quos aut. Perspiciatis officiis vitae ut nulla voluptatem autem dignissimos nulla. Quis quo aliquid laborum nulla tempore occaecati fugit sint. Tempore debitis aut." },
                    { 3, 18, 59, "At itaque placeat omnis vero sapiente voluptate laudantium ea dolorem. Cum vel maxime iusto tempore tempore rerum sapiente voluptatem iusto. Alias iure quasi est nostrum omnis doloribus voluptatem. Labore qui alias magnam unde aut autem. Eum sint quis reprehenderit error eligendi ratione necessitatibus ut. Dolores nobis enim fuga odio natus consequuntur itaque.\n\nIpsum tempore vero voluptatum explicabo ut quod veniam. Dolores necessitatibus similique exercitationem eos in. Et suscipit odio optio et quibusdam. Debitis quos culpa.\n\nTenetur dignissimos quia laborum quod est laborum. Veritatis saepe exercitationem voluptas hic et excepturi id. Non iure qui quae eaque dolores temporibus et nam. Quis et reiciendis maiores excepturi a quia voluptas recusandae.\n\nDolorem est dolore et nisi. Eaque aut maxime inventore. Voluptatem explicabo error adipisci dolorem. Sint rerum suscipit fugit architecto et labore." },
                    { 14, 28, 58, "Iusto quod quibusdam vitae molestias modi animi animi sapiente. Quod aliquid soluta est. Quas quod dolor ab. Deserunt illum et.\n\nEnim ullam quo omnis et voluptate. Et quos sequi eum. Officia enim possimus debitis eos repellendus totam numquam. Aperiam laborum aut est voluptas. Eos nemo dolorem et cum consectetur quidem velit et.\n\nNon quod error et amet dolorum iure consequatur sequi. Nostrum quia minus aperiam mollitia reprehenderit qui ad est. Voluptatem deserunt expedita ipsam laborum quia ut sequi et. Fugit quo doloribus voluptatem aliquam qui est accusamus nulla asperiores. Et nobis necessitatibus similique aut iusto. Beatae et dolores et incidunt inventore nobis.\n\nMagnam illum eos. Ut nemo quia. Blanditiis eius impedit omnis accusamus quod ad molestiae eligendi. Aliquid et voluptas maxime excepturi. Tenetur architecto cumque blanditiis consectetur id non suscipit quia rerum. Ab maiores repudiandae aliquam quos deleniti." },
                    { 2, 8, 57, "Culpa est temporibus sed. Optio et ut deserunt eveniet non voluptatum quo. Maxime atque perferendis dolore delectus enim alias.\n\nEt nesciunt sint quos voluptates alias ab quis aut. Accusamus omnis ut assumenda qui maiores sed quos ut. Nihil sit voluptas laudantium. Voluptatem occaecati qui rerum veniam maxime dolor mollitia minus. Ipsa quisquam sed sequi ut perspiciatis est aspernatur optio nulla. Omnis quo error quaerat et qui expedita repellendus qui.\n\nQui qui omnis deleniti et est. Aperiam est dolorem ut necessitatibus voluptate voluptatem sit suscipit. Et vel incidunt quasi dolorum reiciendis quis aut fugiat. Pariatur molestiae cupiditate consequatur minima corporis. Ut voluptatum qui inventore saepe a enim distinctio.\n\nPerspiciatis dolorem sequi repellat aut corrupti at. Rerum nisi voluptas fugiat. Reprehenderit tempore qui enim voluptatibus aut dolorem ex." },
                    { 11, 30, 56, "Quae voluptas nobis omnis officia qui voluptatem. Veritatis eos doloremque facere mollitia suscipit nulla nobis aliquid. Accusantium sed adipisci ut libero a. Ut optio ipsa cupiditate quos est aliquid ullam consequatur. Qui molestias ut accusamus animi consectetur a voluptas eaque consequatur.\n\nRecusandae et id quos vel. Atque ea dolor ipsum est et voluptatem quia voluptatibus corporis. Velit cum blanditiis tempora nisi voluptatem dolor.\n\nNihil molestiae labore itaque harum officia voluptas. Voluptas aut sint. Ut qui vel aut non velit dolor ut omnis voluptatum.\n\nFacere fuga est unde doloremque deserunt et molestiae. Dolor provident iste sed voluptas ut. Beatae enim ea consequatur." },
                    { 9, 25, 47, "Debitis qui officiis. Deserunt hic laudantium rem beatae veritatis voluptatem. Rerum voluptas ut magni sapiente laboriosam. Velit qui aliquid consequatur voluptas aut laboriosam. Dolorem ut aut consequuntur sed et dolorem molestiae.\n\nNon ea quam deleniti est fugiat ut illum. Vitae sed accusantium velit veritatis. Labore quos omnis cupiditate. Doloremque molestias magnam eius quidem sunt odit itaque sed. Inventore ut corporis corrupti aperiam voluptatibus quia porro est. Sunt voluptatem est quaerat consectetur quibusdam corrupti.\n\nSapiente consequuntur enim ut sequi est quam odit velit nulla. Est ullam optio quas. Quidem est et. Dolore et omnis. Consequatur sed aut vero doloribus doloremque quo vitae velit. Sequi minus temporibus.\n\nAut laborum officiis aut. In autem ad quia qui ut omnis architecto error. Et eveniet ut dignissimos saepe tenetur animi natus fugit ipsum. Et non quaerat. Est ut rerum culpa ipsa quam quis. Et magnam non." },
                    { 10, 21, 58, "Voluptatum omnis sint voluptatem eum aliquam eum nisi odit. Veniam ab possimus et. Molestias ut sit dolor consequatur alias repudiandae quos cupiditate. Veniam aut dignissimos adipisci soluta doloremque. Nulla ea optio dolore omnis quia debitis quis reprehenderit necessitatibus.\n\nPossimus consequatur laborum nostrum ipsa maxime. Voluptates et ut facere natus enim asperiores eos aut qui. Voluptatem nihil nesciunt consequatur sed in odit et a inventore. Quos aut aut vel. Assumenda sunt libero.\n\nDucimus id quia aut dolores est. Reiciendis iste ut est. Blanditiis quod aut tempora iure neque numquam sit nihil. Necessitatibus assumenda velit autem rerum sit neque modi est. Recusandae provident nihil est eaque ea.\n\nAut rerum in quo consequatur expedita occaecati quis enim. Vel molestiae qui sit reiciendis expedita nulla ex mollitia quia. Tenetur vel suscipit sunt suscipit ut et eaque nihil consectetur. Blanditiis nihil non. Reprehenderit dolor in possimus at ut repudiandae quis voluptas." },
                    { 8, 24, 43, "Cupiditate magni aut aut expedita veritatis consequatur aspernatur ut. Mollitia voluptates voluptas inventore tempore et. Ut qui expedita quas ea libero ut necessitatibus. Delectus sit nam asperiores libero praesentium nihil.\n\nIpsam quo saepe et est perspiciatis excepturi corporis dolor. Sed beatae tenetur alias tempora eos officiis harum voluptas aliquam. Laudantium totam asperiores dicta. Fuga iusto unde.\n\nCorrupti ducimus quia ea. Pariatur voluptates quos fugit doloribus illo corrupti dolorum nobis. Aut sit iusto at autem eum. Qui est pariatur consequatur ut ut omnis sint. Possimus aliquid dolor. Harum placeat rerum velit quis sapiente eos est.\n\nReiciendis pariatur nemo. Sunt dignissimos repellat eligendi aperiam nemo eum. Sint excepturi ducimus hic consequatur. Velit voluptates ullam eos quo delectus et voluptatem ut accusantium." },
                    { 12, 18, 42, "Rerum numquam magni pariatur qui. Ab hic porro qui sit consequatur ut exercitationem. Quia ipsum quos mollitia similique et aliquam saepe quis officiis.\n\nLabore sed quia ut sit. Voluptate et vel praesentium hic doloremque nam. Qui voluptas provident expedita provident ut repellendus sit. Fugiat necessitatibus reiciendis et. Iure quia omnis reiciendis facere voluptatum.\n\nMolestias voluptatem alias ducimus dolores iure neque quo eius. Recusandae quo veniam velit ea quo. Voluptate deleniti voluptates non quis. Sed inventore doloribus occaecati quos cumque. Ad amet et facere sit numquam et dicta quod qui. Voluptatum et molestiae quae.\n\nAut delectus quae rerum. Asperiores ut ut eos earum. Iure quas accusamus tempore perferendis dolore amet maxime repudiandae. Beatae qui inventore magnam nam vitae quod. Possimus hic nesciunt qui at unde." },
                    { 6, 6, 41, "Optio corrupti culpa. Qui et vero neque earum ipsum. Quaerat voluptatem ipsam id magni ut quis ad tenetur. Labore est facere et excepturi aut autem ab illo est. Consequuntur velit quam voluptatem itaque doloremque.\n\nRepellendus beatae tempora qui. Eveniet possimus quam deleniti. Minus doloribus et. Ratione blanditiis et dolorem sint architecto optio deleniti fugit. Ducimus velit magni est eveniet nisi adipisci labore cumque accusantium.\n\nPerferendis ut qui id facere nobis eveniet tenetur voluptatem. Quas quis ut sapiente praesentium aut aut animi. Corporis sapiente laboriosam consequatur facere assumenda voluptatem.\n\nUt dolores nostrum saepe. Quia dignissimos similique labore ipsam voluptatem perferendis. Nesciunt similique quo voluptates possimus laboriosam recusandae. Vitae magni aspernatur deleniti eos vero tempore tempora eum quo. Neque possimus illo dolorem odio est repellendus." },
                    { 5, 11, 41, "Dicta excepturi neque dolore tempora assumenda. Ducimus ut facere voluptatem suscipit porro beatae. Voluptate voluptatem eum non et labore quas. Eum distinctio asperiores est ut perspiciatis ea molestias.\n\nDolorem quaerat itaque numquam quae. Vel aut nisi commodi delectus placeat. At consequatur nobis asperiores omnis voluptatibus molestiae. Non culpa est suscipit officia incidunt quia facilis. Dolores dolore omnis aut omnis qui in consectetur numquam et.\n\nSaepe qui est beatae dolores eos rerum eius omnis at. Magni est a soluta dolorem aut praesentium. Quaerat nesciunt iusto accusamus. Doloribus sint corporis amet odit et suscipit beatae. Rerum ipsam odio repellat quaerat qui explicabo deleniti molestiae ex.\n\nEt quia mollitia qui velit enim possimus expedita. Quo praesentium ad illo dicta. Quo blanditiis fugit placeat sint qui aliquam. Rerum et ipsum. Consequatur sequi dolor minus vitae modi alias." },
                    { 1, 30, 36, "Omnis deserunt consequatur quia incidunt suscipit voluptatem nihil. Et et voluptas omnis et aut. Ut vel ut iure delectus eum quibusdam omnis assumenda et. Deserunt culpa asperiores eum beatae saepe culpa cumque quo et. Non corporis ipsam et.\n\nHic eaque alias accusantium ab provident molestiae. Voluptas consequuntur eligendi vel autem aliquam aliquid qui iusto. Voluptas iure fugit omnis rerum velit. Quae architecto facere ducimus. Architecto aliquid et ut animi qui et officiis perspiciatis ab.\n\nEnim assumenda rerum quia ipsa libero et. Accusamus necessitatibus est adipisci. In explicabo et consequatur consequatur blanditiis.\n\nQuo illo laboriosam in natus. Dolorum incidunt natus rerum temporibus voluptatem ut labore. Enim eveniet alias voluptate." },
                    { 15, 4, 35, "Consequatur quia veritatis eius dolores ut porro suscipit. Voluptatem quas nemo. Consequuntur neque est facere natus pariatur quis quis blanditiis incidunt. Tempora dignissimos omnis vitae eos. Et harum et nesciunt ratione et. Labore optio et non alias nostrum voluptatem saepe.\n\nTemporibus explicabo rerum. In voluptatem mollitia ex ex reiciendis quisquam doloribus. Omnis quidem voluptatum. Eligendi officiis cum vel voluptatibus exercitationem ut. Et repellendus architecto consequatur neque voluptates dignissimos.\n\nDoloribus doloribus aut optio ab consequatur. Et autem necessitatibus. Dolore facilis corporis in non est et voluptatem et velit. Et sint numquam quo deleniti occaecati doloribus consectetur et.\n\nDolorum est est et et rerum molestias. Aut amet ea illo ut eius atque dolores. Rem minima nihil quam incidunt dolor amet inventore atque. Rerum sint vel animi qui." },
                    { 13, 20, 46, "Adipisci voluptatem at adipisci ad at optio ut non dolores. Consequatur et corporis placeat est saepe. Maiores reprehenderit soluta voluptates neque dignissimos eum asperiores rerum. Et quia ratione ea sint aliquam unde necessitatibus cum rerum.\n\nOmnis molestiae iste et. Iure impedit vero facilis dolore et nihil nam earum dolore. Eos voluptate vel veniam non. Qui sed aliquid aut qui maiores facere vero. Consequatur tenetur dolor quo aliquam ex sint qui asperiores veniam. Ut voluptate libero odio eligendi reiciendis aut ut doloremque.\n\nOfficia asperiores nulla. Ex necessitatibus necessitatibus itaque quisquam aut repellendus ipsam est. Rerum aut asperiores non earum tenetur illum repellat nihil. Quia provident voluptates velit voluptatum.\n\nEum nam recusandae commodi repellendus doloribus. Repellat doloremque error inventore error nobis. Explicabo voluptatem est consequatur officiis perferendis suscipit. Enim aliquam officia. Corrupti libero qui reiciendis deleniti laudantium maxime. A est quo iure aspernatur aut qui." }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 27, 38, 982.26999999999998, 17 },
                    { 51, 45, 518.97000000000003, 19 },
                    { 40, 34, 190.97999999999999, 19 },
                    { 19, 55, 227.38999999999999, 19 },
                    { 69, 57, 239.24000000000001, 18 },
                    { 62, 49, 584.71000000000004, 18 },
                    { 76, 47, 275.5, 17 },
                    { 39, 56, 950.88999999999999, 17 },
                    { 25, 60, 502.31999999999999, 17 },
                    { 74, 34, 939.49000000000001, 14 },
                    { 90, 59, 896.72000000000003, 16 },
                    { 75, 54, 190.80000000000001, 16 },
                    { 14, 45, 288.44999999999999, 16 },
                    { 36, 42, 667.32000000000005, 15 },
                    { 13, 49, 905.73000000000002, 15 },
                    { 85, 38, 430.45999999999998, 14 },
                    { 26, 58, 503.23000000000002, 20 },
                    { 53, 39, 664.25999999999999, 14 },
                    { 63, 60, 778.74000000000001, 13 },
                    { 6, 52, 887.14999999999998, 17 },
                    { 66, 59, 903.45000000000005, 20 },
                    { 34, 43, 504.41000000000003, 24 },
                    { 68, 34, 831.27999999999997, 21 },
                    { 43, 44, 817.63999999999999, 28 },
                    { 20, 48, 839.27999999999997, 28 },
                    { 12, 59, 979.75999999999999, 28 },
                    { 67, 48, 671.38, 27 }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 59, 50, 917.76999999999998, 27 },
                    { 37, 40, 966.26999999999998, 27 },
                    { 16, 39, 803.47000000000003, 27 },
                    { 81, 41, 132.31999999999999, 26 },
                    { 9, 56, 994.41999999999996, 26 },
                    { 8, 33, 224.19, 26 },
                    { 3, 45, 340.91000000000003, 26 },
                    { 45, 41, 776.02999999999997, 25 },
                    { 17, 39, 438.85000000000002, 25 },
                    { 89, 57, 950.14999999999998, 24 },
                    { 42, 46, 86.900000000000006, 13 },
                    { 32, 32, 437.19999999999999, 23 },
                    { 5, 40, 164.88999999999999, 23 },
                    { 80, 57, 6.2199999999999998, 22 },
                    { 77, 33, 250.74000000000001, 22 },
                    { 2, 53, 726.10000000000002, 21 },
                    { 78, 31, 313.94, 12 },
                    { 56, 44, 549.86000000000001, 11 },
                    { 57, 48, 323.23000000000002, 12 },
                    { 44, 32, 516.23000000000002, 6 },
                    { 48, 45, 260.45999999999998, 5 },
                    { 33, 52, 137.93000000000001, 5 },
                    { 30, 44, 300.56, 5 },
                    { 28, 36, 454.39999999999998, 5 },
                    { 83, 46, 891.88, 4 },
                    { 65, 42, 307.10000000000002, 4 },
                    { 24, 36, 47.659999999999997, 4 },
                    { 84, 48, 410.12, 3 },
                    { 35, 60, 719.79999999999995, 3 },
                    { 21, 52, 564.20000000000005, 3 },
                    { 1, 51, 813.63999999999999, 3 },
                    { 88, 59, 579.94000000000005, 2 },
                    { 41, 42, 214.91, 2 },
                    { 52, 59, 708.73000000000002, 1 },
                    { 49, 41, 661.83000000000004, 1 },
                    { 31, 53, 594.88999999999999, 1 },
                    { 29, 50, 166.5, 1 },
                    { 7, 32, 210.86000000000001, 1 },
                    { 60, 59, 402.51999999999998, 6 },
                    { 58, 58, 382.12, 12 },
                    { 64, 33, 774.52999999999997, 6 },
                    { 22, 38, 563.90999999999997, 7 }
                });

            migrationBuilder.InsertData(
                table: "PetSupportServices",
                columns: new[] { "Id", "PetsitterId", "Price", "ServiceId" },
                values: new object[,]
                {
                    { 11, 45, 269.37, 12 },
                    { 87, 50, 38.770000000000003, 11 },
                    { 86, 52, 161.72, 11 },
                    { 71, 54, 247.80000000000001, 11 },
                    { 4, 52, 791.52999999999997, 29 },
                    { 38, 52, 351.50999999999999, 11 },
                    { 23, 46, 830.02999999999997, 11 },
                    { 15, 43, 989.89999999999998, 11 },
                    { 79, 52, 540.48000000000002, 10 },
                    { 82, 50, 853.30999999999995, 9 },
                    { 70, 35, 130.33000000000001, 9 },
                    { 10, 43, 76.560000000000002, 9 },
                    { 73, 57, 665.30999999999995, 8 },
                    { 55, 56, 690.90999999999997, 8 },
                    { 47, 53, 531.07000000000005, 8 },
                    { 72, 38, 731.02999999999997, 7 },
                    { 61, 43, 705.52999999999997, 7 },
                    { 50, 38, 208.34, 7 },
                    { 46, 45, 40.170000000000002, 7 },
                    { 18, 45, 811.55999999999995, 7 },
                    { 54, 50, 579.25999999999999, 29 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "BookingMessages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "PetSupportServices",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "Petsitters",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Clients",
                keyColumn: "Id",
                keyValue: 30);

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

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "Services",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Services",
                type: "float",
                nullable: false,
                defaultValue: 0.0);
        }
    }
}
