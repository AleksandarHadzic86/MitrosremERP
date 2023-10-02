using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ExtendIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ugovori",
                keyColumn: "Id",
                keyValue: new Guid("6ed99881-b289-487d-ad66-c9252b6eb4b2"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("1856021b-0b09-449d-89c8-bcd4525ac57c"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("5949d85c-aed9-41e4-807a-2ae95d6229d1"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("6681b01b-6da9-4ce7-b60e-247d45760dbc"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("9c48d240-851b-42f2-87a6-b38dd05fd851"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("d8d12178-f05f-42d4-a7be-b5f2fb375b21"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("e88a732f-daec-4951-90b8-3445e7b54745"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("e8d83c5b-ee13-4fe6-bf63-1557c5c2ac33"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("6bfb7a57-5fd0-4ad0-b1ac-84d177a9b3aa"));

            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "Id", "Adresa", "DatumRodjenja", "Email", "Fiksni", "Grad", "ImageUrl", "Ime", "JMBG", "Mobilni", "Napomena", "PolOsobeId", "Prezime", "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[,]
                {
                    { new Guid("4207589f-973c-4d0c-b64f-27faaec07f94"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "MIlan", "4302386890023", "06553427", null, 1, "Milanovic", "Master Ekonomista", "Finansije", 7 },
                    { new Guid("4b8141ab-105d-448d-8a90-f83148b8ddf6"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Stevan", "3123986890023", "0605574477", null, 1, "Stevanovic", "Trgovac", "Maloprodaja", 6 },
                    { new Guid("7f4194fa-d2c2-4b37-9cd3-da909d03d908"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Aleksandar", "1702986890023", "0605574477", null, 1, "Hadzic", "Elektro Tehnicar", "Odrzavanje el.instalacija", 4 },
                    { new Guid("97f63497-9667-481e-98c2-464249946319"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Jovan", "2132986890023", "0605574477", null, 2, "Jovanovic", "Diplomirani Tehnolog", "Tehnolog hrane", 6 },
                    { new Guid("c78f028f-2fb2-4318-bd3b-0f3cfb8208d5"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Goran", "1702986890023", "0605574477", null, 1, "Goranic", "Developer", "Programer", 5 },
                    { new Guid("d19ef44f-c055-4200-a95a-ea0c3bfe52c5"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "Petar", "4302386890023", "06553427", null, 1, "Petrovic", "Masinski Tehnicar", "Odrzavanje masicna", 4 },
                    { new Guid("e379d8a7-b006-47b8-905d-7232d76486ab"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Sreten", "3123986890023", "0605574477", null, 1, "Sretenovic", "System Administrator", "IT Administrator", 5 },
                    { new Guid("ea32abcb-6b88-4a02-9b6d-12245121dd01"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Zorana", "2132986890023", "0605574477", null, 2, "Zoranovic", "Diplomirani Ekonomista", "Racunovodstvo", 6 }
                });

            migrationBuilder.InsertData(
                table: "Ugovori",
                columns: new[] { "Id", "BrojDanaGodisnjeg", "BrojUgovora", "DatumPocetka", "DatumZavrsetka", "Napomena", "TipUgovora", "ZaposleniId" },
                values: new object[] { new Guid("ce164626-a2c3-4328-bab2-935dc5f40d84"), 22, "MS0001", new DateOnly(1992, 2, 17), null, null, "Odredjeno", new Guid("7f4194fa-d2c2-4b37-9cd3-da909d03d908") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ugovori",
                keyColumn: "Id",
                keyValue: new Guid("ce164626-a2c3-4328-bab2-935dc5f40d84"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("4207589f-973c-4d0c-b64f-27faaec07f94"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("4b8141ab-105d-448d-8a90-f83148b8ddf6"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("97f63497-9667-481e-98c2-464249946319"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("c78f028f-2fb2-4318-bd3b-0f3cfb8208d5"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("d19ef44f-c055-4200-a95a-ea0c3bfe52c5"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("e379d8a7-b006-47b8-905d-7232d76486ab"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("ea32abcb-6b88-4a02-9b6d-12245121dd01"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("7f4194fa-d2c2-4b37-9cd3-da909d03d908"));

            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "Id", "Adresa", "DatumRodjenja", "Email", "Fiksni", "Grad", "ImageUrl", "Ime", "JMBG", "Mobilni", "Napomena", "PolOsobeId", "Prezime", "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[,]
                {
                    { new Guid("1856021b-0b09-449d-89c8-bcd4525ac57c"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Goran", "1702986890023", "0605574477", null, 1, "Goranic", "Developer", "Programer", 5 },
                    { new Guid("5949d85c-aed9-41e4-807a-2ae95d6229d1"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Zorana", "2132986890023", "0605574477", null, 2, "Zoranovic", "Diplomirani Ekonomista", "Racunovodstvo", 6 },
                    { new Guid("6681b01b-6da9-4ce7-b60e-247d45760dbc"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "MIlan", "4302386890023", "06553427", null, 1, "Milanovic", "Master Ekonomista", "Finansije", 7 },
                    { new Guid("6bfb7a57-5fd0-4ad0-b1ac-84d177a9b3aa"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Aleksandar", "1702986890023", "0605574477", null, 1, "Hadzic", "Elektro Tehnicar", "Odrzavanje el.instalacija", 4 },
                    { new Guid("9c48d240-851b-42f2-87a6-b38dd05fd851"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Stevan", "3123986890023", "0605574477", null, 1, "Stevanovic", "Trgovac", "Maloprodaja", 6 },
                    { new Guid("d8d12178-f05f-42d4-a7be-b5f2fb375b21"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Jovan", "2132986890023", "0605574477", null, 2, "Jovanovic", "Diplomirani Tehnolog", "Tehnolog hrane", 6 },
                    { new Guid("e88a732f-daec-4951-90b8-3445e7b54745"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "Petar", "4302386890023", "06553427", null, 1, "Petrovic", "Masinski Tehnicar", "Odrzavanje masicna", 4 },
                    { new Guid("e8d83c5b-ee13-4fe6-bf63-1557c5c2ac33"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Sreten", "3123986890023", "0605574477", null, 1, "Sretenovic", "System Administrator", "IT Administrator", 5 }
                });

            migrationBuilder.InsertData(
                table: "Ugovori",
                columns: new[] { "Id", "BrojDanaGodisnjeg", "BrojUgovora", "DatumPocetka", "DatumZavrsetka", "Napomena", "TipUgovora", "ZaposleniId" },
                values: new object[] { new Guid("6ed99881-b289-487d-ad66-c9252b6eb4b2"), 22, "MS0001", new DateOnly(1992, 2, 17), null, null, "Odredjeno", new Guid("6bfb7a57-5fd0-4ad0-b1ac-84d177a9b3aa") });
        }
    }
}
