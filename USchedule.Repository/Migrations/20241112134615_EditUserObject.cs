using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace USchedule.Repository.Migrations
{
    /// <inheritdoc />
    public partial class EditUserObject : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                keyValue: new Guid("0f1d0173-e751-4577-b350-b903a9080151"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("1844ec7e-1524-4882-b48f-3483889597e2"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("26ee99cb-df2f-42d2-acd6-6971e884f2d8"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("3ea69289-73a7-45c2-9095-89c6533823e7"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("8957d7b4-d97e-41f6-b6eb-960544916c3d"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("8a85dcbf-382d-4451-819f-d322ae4820ba"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("8c79ee87-392a-4450-aa8e-0f44c4146654"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("8dc8a7b6-7353-457c-bc39-c7b7c57448d8"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("8f37f310-efb0-4224-9b0b-1e9ccd32aeba"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("97fcf39b-9798-42d5-929a-404346cffb3f"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("99f7ba3a-b3ac-40b7-bdfa-2ec4066704a9"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("a29c8c9b-e75c-4040-8c29-82631c6bd350"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("a467a8ad-e975-4336-b22c-03e25a0ea7c9"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("a6dfea93-d7c3-4d7f-aaf8-9a1313d82273"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("c4aaaede-76a2-45fa-91ba-2db6b287357f"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("f015c386-0d5d-4555-87ed-9f72f0419ea8"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("f13ae862-bdbb-4cef-a27d-1be483f1c9d8"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("f67316de-0f13-4720-9e17-d69ad1d6501f"));

            migrationBuilder.DeleteData(
                table: "Faculties",
                keyColumn: "Id",
                keyValue: new Guid("fce366cf-ee8a-4fef-8ae2-7016933b62c0"));

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { new Guid("0f1d0173-e751-4577-b350-b903a9080151"), "вул. Університетська, 1, м. Львів, 79000, Україна", "Історичний факультет" },
                    { new Guid("1844ec7e-1524-4882-b48f-3483889597e2"), "проспект Свободи, 18, м. Львів, 79008, Україна", "Економічний факультет" },
                    { new Guid("26ee99cb-df2f-42d2-acd6-6971e884f2d8"), "вул. Січових Стрільців, 14, м. Львів, 79000, Україна", "Юридичний факультет" },
                    { new Guid("3ea69289-73a7-45c2-9095-89c6533823e7"), "вул. Університетська 1, м. Львів, 79000, Україна", "Факультет прикладної математики та інформатики" },
                    { new Guid("8957d7b4-d97e-41f6-b6eb-960544916c3d"), "вул. Драгоманова, 50, м. Львів, 79005, Україна", "Факультет електроніки та комп’ютерних технологій" },
                    { new Guid("8a85dcbf-382d-4451-819f-d322ae4820ba"), "вул. Кирила і Мефодія, 8, м. Львів, 79005, Україна", "Фізичний факультет" },
                    { new Guid("8c79ee87-392a-4450-aa8e-0f44c4146654"), "вул. Університетська 1/415, м. Львів, 79000, Україна", "Факультет іноземних мов" },
                    { new Guid("8dc8a7b6-7353-457c-bc39-c7b7c57448d8"), "вул. Грушевського, 4, м. Львів 79005, Україна", "Біологічний факультет" },
                    { new Guid("8f37f310-efb0-4224-9b0b-1e9ccd32aeba"), "вул. Університетська, 1 м. Львів, 79000, Україна", "Механіко-математичний факультет" },
                    { new Guid("97fcf39b-9798-42d5-929a-404346cffb3f"), "вул. Січових Стрільців, 19, м. Львів, 79000, Україна", "Факультет міжнародних відносин" },
                    { new Guid("99f7ba3a-b3ac-40b7-bdfa-2ec4066704a9"), "вул. Грушевського, 4, м. Львів 79005, Україна", "Геологічний факультет" },
                    { new Guid("a29c8c9b-e75c-4040-8c29-82631c6bd350"), "вул. Коперника, 3, м. Львів, 79000, Україна", "Факультет управління фінансами та бізнесу" },
                    { new Guid("a467a8ad-e975-4336-b22c-03e25a0ea7c9"), "вул. Кирила і Мефодія, 6, м. Львів, 79005, Україна", "Хімічний факультет" },
                    { new Guid("a6dfea93-d7c3-4d7f-aaf8-9a1313d82273"), "вул. Університетська, 1, м. Львів, 79001, Україна", "Філософський факультет" },
                    { new Guid("c4aaaede-76a2-45fa-91ba-2db6b287357f"), "вул. Туган-Барановського, 7, м. Львів, 79000, Україна", "Факультет педагогічної освіти" },
                    { new Guid("f015c386-0d5d-4555-87ed-9f72f0419ea8"), "вул. Університетська, 1, кімната 232, м. Львів, 79000, Україна", "Філологічний факультет" },
                    { new Guid("f13ae862-bdbb-4cef-a27d-1be483f1c9d8"), "вул. Генерала Чупринки, 49, м. Львів, 79044, Україна", "Факультет журналістики" },
                    { new Guid("f67316de-0f13-4720-9e17-d69ad1d6501f"), "вул. Валова,18, м. Львів, 79008, Україна", "Факультет культури і мистецтв" },
                    { new Guid("fce366cf-ee8a-4fef-8ae2-7016933b62c0"), "вул. Дорошенка, 41, м. Львів, 79000, Україна", "Географічний факультет" }
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
    }
}
