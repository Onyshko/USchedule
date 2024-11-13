using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace USchedule.Repository.Migrations
{
    /// <inheritdoc />
    public partial class BugFixes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("0d04d34f-0364-427e-b7fc-b33ca742c04d"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("3acee6c8-1e92-4d1d-a38a-272372d24158"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("4da387f8-291b-43bb-ba3f-da11336f6555"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("5331a84b-d7ce-48e3-a630-02eb0551c829"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("6bcf2fbb-8f04-4d6f-81d7-2867e9a9c774"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("7f3b8aa3-d9b9-4fa5-a8ab-d4cf467c80f0"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("860e595b-e777-4e46-92b1-66c32b2c9b57"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("8ac83cbb-ae28-4c3e-af3c-3690540fc55d"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("916007a9-9553-4f97-85e7-04bb4a5a2877"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("96fb77c4-58ac-4170-8765-9b4f5b634f60"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("a4397c08-e509-4d89-903f-db3ff25107f6"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("bac595e9-9cf5-4122-be7b-ea1b2de88e8d"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("c6b26218-9406-4dc6-b084-ef2c3b6b1f08"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("d1db4f95-b3ca-410d-a683-9b3a0342d9de"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("e62bf165-d39c-4291-8277-cfe62a40c15f"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("e7116453-183f-44ce-8dd9-e5e3117fca09"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("e8ad3d33-2f15-4c4f-8ce3-d243489a9277"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("eb599993-72b9-4b53-bb57-60f142137c28"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("eff0bdf2-0d03-475c-8556-5440fa4c5773"));

            migrationBuilder.AddColumn<Guid>(
                name: "RoleId",
                table: "AspNetUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { new Guid("00d42ddf-e398-46ae-b5aa-7fe556628a55"), "вул. Дорошенка, 41, м. Львів, 79000, Україна", "Географічний факультет" },
                    { new Guid("17435162-6be8-4b46-ad32-ef002e9412f3"), "вул. Драгоманова, 50, м. Львів, 79005, Україна", "Факультет електроніки та комп’ютерних технологій" },
                    { new Guid("24246fdf-42d2-49cb-8701-c79451741da6"), "вул. Кирила і Мефодія, 6, м. Львів, 79005, Україна", "Хімічний факультет" },
                    { new Guid("2c7cadf6-b106-47c0-b1be-6eaab5c2aa15"), "вул. Грушевського, 4, м. Львів 79005, Україна", "Геологічний факультет" },
                    { new Guid("449979b9-718c-4855-b95b-41bed68d8efb"), "вул. Університетська, 1, кімната 232, м. Львів, 79000, Україна", "Філологічний факультет" },
                    { new Guid("528978b7-cd82-49fa-894b-cedf912586b6"), "вул. Валова,18, м. Львів, 79008, Україна", "Факультет культури і мистецтв" },
                    { new Guid("59ee1046-3248-4853-bc81-65252c28553e"), "вул. Грушевського, 4, м. Львів 79005, Україна", "Біологічний факультет" },
                    { new Guid("6012a580-0c3a-4c08-bacc-2523dbda8cc8"), "вул. Туган-Барановського, 7, м. Львів, 79000, Україна", "Факультет педагогічної освіти" },
                    { new Guid("64a2252c-a293-4bc6-b9ca-f88ad83a3238"), "вул. Коперника, 3, м. Львів, 79000, Україна", "Факультет управління фінансами та бізнесу" },
                    { new Guid("75ee959f-54db-4eaa-ba45-c6dede1e6655"), "вул. Кирила і Мефодія, 8, м. Львів, 79005, Україна", "Фізичний факультет" },
                    { new Guid("8114edc1-2c58-4eab-b064-51ba5cc3a733"), "вул. Університетська, 1, м. Львів, 79000, Україна", "Історичний факультет" },
                    { new Guid("a6cc5cbb-57b3-44dd-b114-f154be7e3c18"), "вул. Генерала Чупринки, 49, м. Львів, 79044, Україна", "Факультет журналістики" },
                    { new Guid("a8fdeb2f-1fc3-42a7-b35c-2a74d8cad926"), "вул. Січових Стрільців, 19, м. Львів, 79000, Україна", "Факультет міжнародних відносин" },
                    { new Guid("b3b1da37-a6b0-4c00-805c-13613f6e1e45"), "вул. Січових Стрільців, 14, м. Львів, 79000, Україна", "Юридичний факультет" },
                    { new Guid("d08caa39-9276-4216-bfa4-193f0842e2cf"), "вул. Університетська 1, м. Львів, 79000, Україна", "Факультет прикладної математики та інформатики" },
                    { new Guid("d248486a-cf13-4a67-a820-4781a5196a08"), "вул. Університетська, 1, м. Львів, 79001, Україна", "Філософський факультет" },
                    { new Guid("dbee3810-8fcf-4d4d-b4b3-5423be292fc8"), "проспект Свободи, 18, м. Львів, 79008, Україна", "Економічний факультет" },
                    { new Guid("e873f075-1ce5-436b-829e-5aa8b2c9a34a"), "вул. Університетська, 1 м. Львів, 79000, Україна", "Механіко-математичний факультет" },
                    { new Guid("f2fde27d-8fe7-4e08-b8b6-77caba6c2849"), "вул. Університетська 1/415, м. Львів, 79000, Україна", "Факультет іноземних мов" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_RoleId",
                table: "AspNetUsers",
                column: "RoleId");

            migrationBuilder.AddForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleId",
                table: "AspNetUsers",
                column: "RoleId",
                principalTable: "AspNetRoles",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AspNetUsers_AspNetRoles_RoleId",
                table: "AspNetUsers");

            migrationBuilder.DropIndex(
                name: "IX_AspNetUsers_RoleId",
                table: "AspNetUsers");

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("00d42ddf-e398-46ae-b5aa-7fe556628a55"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("17435162-6be8-4b46-ad32-ef002e9412f3"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("24246fdf-42d2-49cb-8701-c79451741da6"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("2c7cadf6-b106-47c0-b1be-6eaab5c2aa15"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("449979b9-718c-4855-b95b-41bed68d8efb"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("528978b7-cd82-49fa-894b-cedf912586b6"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("59ee1046-3248-4853-bc81-65252c28553e"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("6012a580-0c3a-4c08-bacc-2523dbda8cc8"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("64a2252c-a293-4bc6-b9ca-f88ad83a3238"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("75ee959f-54db-4eaa-ba45-c6dede1e6655"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("8114edc1-2c58-4eab-b064-51ba5cc3a733"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("a6cc5cbb-57b3-44dd-b114-f154be7e3c18"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("a8fdeb2f-1fc3-42a7-b35c-2a74d8cad926"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("b3b1da37-a6b0-4c00-805c-13613f6e1e45"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("d08caa39-9276-4216-bfa4-193f0842e2cf"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("d248486a-cf13-4a67-a820-4781a5196a08"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("dbee3810-8fcf-4d4d-b4b3-5423be292fc8"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("e873f075-1ce5-436b-829e-5aa8b2c9a34a"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("f2fde27d-8fe7-4e08-b8b6-77caba6c2849"));

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "AspNetUsers");

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesId, x.UsersId });
                    table.ForeignKey(
                        name: "FK_RoleUser_AspNetRoles_RolesId",
                        column: x => x.RolesId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_AspNetUsers_UsersId",
                        column: x => x.UsersId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Faculties",
                columns: new[] { "Id", "Address", "Name" },
                values: new object[,]
                {
                    { new Guid("0d04d34f-0364-427e-b7fc-b33ca742c04d"), "вул. Кирила і Мефодія, 6, м. Львів, 79005, Україна", "Хімічний факультет" },
                    { new Guid("3acee6c8-1e92-4d1d-a38a-272372d24158"), "вул. Університетська, 1, кімната 232, м. Львів, 79000, Україна", "Філологічний факультет" },
                    { new Guid("4da387f8-291b-43bb-ba3f-da11336f6555"), "вул. Університетська, 1 м. Львів, 79000, Україна", "Механіко-математичний факультет" },
                    { new Guid("5331a84b-d7ce-48e3-a630-02eb0551c829"), "вул. Туган-Барановського, 7, м. Львів, 79000, Україна", "Факультет педагогічної освіти" },
                    { new Guid("6bcf2fbb-8f04-4d6f-81d7-2867e9a9c774"), "вул. Січових Стрільців, 19, м. Львів, 79000, Україна", "Факультет міжнародних відносин" },
                    { new Guid("7f3b8aa3-d9b9-4fa5-a8ab-d4cf467c80f0"), "вул. Генерала Чупринки, 49, м. Львів, 79044, Україна", "Факультет журналістики" },
                    { new Guid("860e595b-e777-4e46-92b1-66c32b2c9b57"), "вул. Драгоманова, 50, м. Львів, 79005, Україна", "Факультет електроніки та комп’ютерних технологій" },
                    { new Guid("8ac83cbb-ae28-4c3e-af3c-3690540fc55d"), "вул. Грушевського, 4, м. Львів 79005, Україна", "Геологічний факультет" },
                    { new Guid("916007a9-9553-4f97-85e7-04bb4a5a2877"), "вул. Січових Стрільців, 14, м. Львів, 79000, Україна", "Юридичний факультет" },
                    { new Guid("96fb77c4-58ac-4170-8765-9b4f5b634f60"), "вул. Університетська, 1, м. Львів, 79000, Україна", "Історичний факультет" },
                    { new Guid("a4397c08-e509-4d89-903f-db3ff25107f6"), "вул. Коперника, 3, м. Львів, 79000, Україна", "Факультет управління фінансами та бізнесу" },
                    { new Guid("bac595e9-9cf5-4122-be7b-ea1b2de88e8d"), "проспект Свободи, 18, м. Львів, 79008, Україна", "Економічний факультет" },
                    { new Guid("c6b26218-9406-4dc6-b084-ef2c3b6b1f08"), "вул. Університетська 1, м. Львів, 79000, Україна", "Факультет прикладної математики та інформатики" },
                    { new Guid("d1db4f95-b3ca-410d-a683-9b3a0342d9de"), "вул. Університетська, 1, м. Львів, 79001, Україна", "Філософський факультет" },
                    { new Guid("e62bf165-d39c-4291-8277-cfe62a40c15f"), "вул. Університетська 1/415, м. Львів, 79000, Україна", "Факультет іноземних мов" },
                    { new Guid("e7116453-183f-44ce-8dd9-e5e3117fca09"), "вул. Валова,18, м. Львів, 79008, Україна", "Факультет культури і мистецтв" },
                    { new Guid("e8ad3d33-2f15-4c4f-8ce3-d243489a9277"), "вул. Дорошенка, 41, м. Львів, 79000, Україна", "Географічний факультет" },
                    { new Guid("eb599993-72b9-4b53-bb57-60f142137c28"), "вул. Грушевського, 4, м. Львів 79005, Україна", "Біологічний факультет" },
                    { new Guid("eff0bdf2-0d03-475c-8556-5440fa4c5773"), "вул. Кирила і Мефодія, 8, м. Львів, 79005, Україна", "Фізичний факультет" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersId",
                table: "RoleUser",
                column: "UsersId");
        }
    }
}
