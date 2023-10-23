using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PutniNalogVozacUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("057c7683-dcd3-4b41-a6c9-5cd348882d57"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("14a01c3f-6423-4a45-a32b-bab3dabfd952"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("1995542b-93bf-4c8d-a785-2061a97caf45"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("9767e93f-da56-48e1-8c50-ace63310c733"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("da6c990e-50a9-4952-bdd8-025df9abde2a"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("dca77f5e-5d8d-4c6b-9f86-45ebfeafbf09"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("ea0667fd-1320-41fc-9099-b10bd7c80a3b"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("ecf978f2-f930-4f30-85ae-20240cca2444"));

            migrationBuilder.DropColumn(
                name: "VozacId",
                table: "PutniNalogVozac");

            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "Id", "Adresa", "DatumRodjenja", "Email", "Fiksni", "Grad", "ImageUrl", "Ime", "JMBG", "Mobilni", "Napomena", "PolOsobe", "Prezime", "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[,]
                {
                    { new Guid("0b01c2a7-79e5-4dd2-b892-c452f00d1150"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Stevan", "3123986890023", "0605574477", null, 0, "Stevanovic", "Trgovac", "Maloprodaja", 6 },
                    { new Guid("0daa23a6-23d6-49ca-9561-5c2ae33513e1"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Jelena", "1702986890023", "0605574477", null, 1, "Jovanovic", "Developer", "Programer", 5 },
                    { new Guid("1d85f90c-b50c-47fc-b21e-fc9bac6117cb"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Aleksandar", "1702986890023", "0605574477", null, 0, "Hadzic", "Strukovni inzenjer el. i racunara", "System Administrator", 4 },
                    { new Guid("3817df57-2971-434b-a1b2-9ba52f32cbc2"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "Petra", "4302386890023", "06553427", null, 1, "Petrovic", "Masinski Tehnicar", "Odrzavanje masicna", 4 },
                    { new Guid("4481ad1a-dce6-4279-9c87-7bf043a42d08"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Sreten", "3123986890023", "0605574477", null, 0, "Sretenovic", "System Administrator", "IT Administrator", 5 },
                    { new Guid("7c9efa61-adde-4c9e-ae95-9ae037641e80"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Zorana", "2132986890023", "0605574477", null, 1, "Zoranovic", "Diplomirani Ekonomista", "Racunovodstvo", 6 },
                    { new Guid("82cd9bee-dd45-4e69-9c40-562c05a1afc0"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Jovan", "2132986890023", "0605574477", null, 1, "Jovanovic", "Diplomirani Tehnolog", "Tehnolog hrane", 6 },
                    { new Guid("c9ac591b-6b1b-4fbb-85a5-cc8f18609a3b"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "MIlan", "4302386890023", "06553427", null, 0, "Milanovic", "Master Ekonomista", "Finansije", 7 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("0b01c2a7-79e5-4dd2-b892-c452f00d1150"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("0daa23a6-23d6-49ca-9561-5c2ae33513e1"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("1d85f90c-b50c-47fc-b21e-fc9bac6117cb"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("3817df57-2971-434b-a1b2-9ba52f32cbc2"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("4481ad1a-dce6-4279-9c87-7bf043a42d08"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("7c9efa61-adde-4c9e-ae95-9ae037641e80"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("82cd9bee-dd45-4e69-9c40-562c05a1afc0"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("c9ac591b-6b1b-4fbb-85a5-cc8f18609a3b"));

            migrationBuilder.AddColumn<Guid>(
                name: "VozacId",
                table: "PutniNalogVozac",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "Id", "Adresa", "DatumRodjenja", "Email", "Fiksni", "Grad", "ImageUrl", "Ime", "JMBG", "Mobilni", "Napomena", "PolOsobe", "Prezime", "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[,]
                {
                    { new Guid("057c7683-dcd3-4b41-a6c9-5cd348882d57"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Stevan", "3123986890023", "0605574477", null, 0, "Stevanovic", "Trgovac", "Maloprodaja", 6 },
                    { new Guid("14a01c3f-6423-4a45-a32b-bab3dabfd952"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Sreten", "3123986890023", "0605574477", null, 0, "Sretenovic", "System Administrator", "IT Administrator", 5 },
                    { new Guid("1995542b-93bf-4c8d-a785-2061a97caf45"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Jovan", "2132986890023", "0605574477", null, 1, "Jovanovic", "Diplomirani Tehnolog", "Tehnolog hrane", 6 },
                    { new Guid("9767e93f-da56-48e1-8c50-ace63310c733"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "MIlan", "4302386890023", "06553427", null, 0, "Milanovic", "Master Ekonomista", "Finansije", 7 },
                    { new Guid("da6c990e-50a9-4952-bdd8-025df9abde2a"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "Petra", "4302386890023", "06553427", null, 1, "Petrovic", "Masinski Tehnicar", "Odrzavanje masicna", 4 },
                    { new Guid("dca77f5e-5d8d-4c6b-9f86-45ebfeafbf09"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Aleksandar", "1702986890023", "0605574477", null, 0, "Hadzic", "Strukovni inzenjer el. i racunara", "System Administrator", 4 },
                    { new Guid("ea0667fd-1320-41fc-9099-b10bd7c80a3b"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Zorana", "2132986890023", "0605574477", null, 1, "Zoranovic", "Diplomirani Ekonomista", "Racunovodstvo", 6 },
                    { new Guid("ecf978f2-f930-4f30-85ae-20240cca2444"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Jelena", "1702986890023", "0605574477", null, 1, "Jovanovic", "Developer", "Programer", 5 }
                });
        }
    }
}
