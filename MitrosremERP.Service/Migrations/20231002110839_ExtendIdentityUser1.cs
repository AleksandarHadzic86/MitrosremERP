using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ExtendIdentityUser1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Adresa",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "AspNetUsers",
                type: "nvarchar(21)",
                maxLength: 21,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Grad",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Ime",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Prezime",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "Id", "Adresa", "DatumRodjenja", "Email", "Fiksni", "Grad", "ImageUrl", "Ime", "JMBG", "Mobilni", "Napomena", "PolOsobeId", "Prezime", "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[,]
                {
                    { new Guid("024f0f62-1964-430f-9dbd-f46fc5f9a119"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Aleksandar", "1702986890023", "0605574477", null, 1, "Hadzic", "Elektro Tehnicar", "Odrzavanje el.instalacija", 4 },
                    { new Guid("4ad1be50-f025-4e82-b09e-89b453da738f"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Jovan", "2132986890023", "0605574477", null, 2, "Jovanovic", "Diplomirani Tehnolog", "Tehnolog hrane", 6 },
                    { new Guid("57c51060-9c5c-4443-975e-c46b6427b4d5"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "Petar", "4302386890023", "06553427", null, 1, "Petrovic", "Masinski Tehnicar", "Odrzavanje masicna", 4 },
                    { new Guid("7728393b-cba9-432c-88d4-182332918fd6"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Stevan", "3123986890023", "0605574477", null, 1, "Stevanovic", "Trgovac", "Maloprodaja", 6 },
                    { new Guid("873d003f-f0a8-4cc1-9b8f-7aff6643bff0"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Zorana", "2132986890023", "0605574477", null, 2, "Zoranovic", "Diplomirani Ekonomista", "Racunovodstvo", 6 },
                    { new Guid("9fced6e4-289a-4c50-9559-311da6fb1878"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Goran", "1702986890023", "0605574477", null, 1, "Goranic", "Developer", "Programer", 5 },
                    { new Guid("bff8b745-30b5-430d-914e-185e40a1f576"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "MIlan", "4302386890023", "06553427", null, 1, "Milanovic", "Master Ekonomista", "Finansije", 7 },
                    { new Guid("dad4ef07-78a2-4937-9313-9d4b488dd298"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Sreten", "3123986890023", "0605574477", null, 1, "Sretenovic", "System Administrator", "IT Administrator", 5 }
                });

            migrationBuilder.InsertData(
                table: "Ugovori",
                columns: new[] { "Id", "BrojDanaGodisnjeg", "BrojUgovora", "DatumPocetka", "DatumZavrsetka", "Napomena", "TipUgovora", "ZaposleniId" },
                values: new object[] { new Guid("bb4f958e-eda8-4435-94bb-2a3c7edc42ea"), 22, "MS0001", new DateOnly(1992, 2, 17), null, null, "Odredjeno", new Guid("024f0f62-1964-430f-9dbd-f46fc5f9a119") });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Ugovori",
                keyColumn: "Id",
                keyValue: new Guid("bb4f958e-eda8-4435-94bb-2a3c7edc42ea"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("4ad1be50-f025-4e82-b09e-89b453da738f"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("57c51060-9c5c-4443-975e-c46b6427b4d5"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("7728393b-cba9-432c-88d4-182332918fd6"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("873d003f-f0a8-4cc1-9b8f-7aff6643bff0"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("9fced6e4-289a-4c50-9559-311da6fb1878"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("bff8b745-30b5-430d-914e-185e40a1f576"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("dad4ef07-78a2-4937-9313-9d4b488dd298"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("024f0f62-1964-430f-9dbd-f46fc5f9a119"));

            migrationBuilder.DropColumn(
                name: "Adresa",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Grad",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Ime",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Prezime",
                table: "AspNetUsers");

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
    }
}
