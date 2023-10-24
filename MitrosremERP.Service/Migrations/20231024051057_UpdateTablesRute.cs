using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTablesRute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "RadnoMesto",
                table: "Zaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Profesija",
                table: "Zaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Zaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Mobilni",
                table: "Zaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "JMBG",
                table: "Zaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Zaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Grad",
                table: "Zaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Fiksni",
                table: "Zaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Zaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Adresa",
                table: "Zaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "PutanjaDokumenta",
                table: "DokumentiZaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "ImeDokumenta",
                table: "DokumentiZaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "Id", "Adresa", "DatumRodjenja", "Email", "Fiksni", "Grad", "ImageUrl", "Ime", "JMBG", "Mobilni", "Napomena", "PolOsobe", "Prezime", "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[,]
                {
                    { new Guid("2f14d0f2-060f-49aa-bfcb-96ecce88b7b6"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Jelena", "1702986890023", "0605574477", null, 1, "Jovanovic", "Developer", "Programer", 5 },
                    { new Guid("43a325a2-688f-4e55-93d3-ec92967b835b"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Zorana", "2132986890023", "0605574477", null, 1, "Zoranovic", "Diplomirani Ekonomista", "Racunovodstvo", 6 },
                    { new Guid("67d24601-64e6-4efd-b79e-cb4af41f18e3"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "MIlan", "4302386890023", "06553427", null, 0, "Milanovic", "Master Ekonomista", "Finansije", 7 },
                    { new Guid("a0e44833-07a3-492c-8c64-73e0ccedb5de"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Stevan", "3123986890023", "0605574477", null, 0, "Stevanovic", "Trgovac", "Maloprodaja", 6 },
                    { new Guid("a2e72847-2a4b-4637-a349-130cac331503"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "Petra", "4302386890023", "06553427", null, 1, "Petrovic", "Masinski Tehnicar", "Odrzavanje masicna", 4 },
                    { new Guid("ab563066-640d-4deb-9b86-dc9ea8e1e3bd"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Sreten", "3123986890023", "0605574477", null, 0, "Sretenovic", "System Administrator", "IT Administrator", 5 },
                    { new Guid("c58fc2d3-3bf0-43fd-9634-1df223c5db62"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Jovan", "2132986890023", "0605574477", null, 1, "Jovanovic", "Diplomirani Tehnolog", "Tehnolog hrane", 6 },
                    { new Guid("d2e806f5-ac65-4fd3-9ec9-6c716199f3bf"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Aleksandar", "1702986890023", "0605574477", null, 0, "Hadzic", "Strukovni inzenjer el. i racunara", "System Administrator", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("2f14d0f2-060f-49aa-bfcb-96ecce88b7b6"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("43a325a2-688f-4e55-93d3-ec92967b835b"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("67d24601-64e6-4efd-b79e-cb4af41f18e3"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("a0e44833-07a3-492c-8c64-73e0ccedb5de"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("a2e72847-2a4b-4637-a349-130cac331503"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("ab563066-640d-4deb-9b86-dc9ea8e1e3bd"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("c58fc2d3-3bf0-43fd-9634-1df223c5db62"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("d2e806f5-ac65-4fd3-9ec9-6c716199f3bf"));

            migrationBuilder.AlterColumn<string>(
                name: "RadnoMesto",
                table: "Zaposleni",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Profesija",
                table: "Zaposleni",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Prezime",
                table: "Zaposleni",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Mobilni",
                table: "Zaposleni",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "JMBG",
                table: "Zaposleni",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Ime",
                table: "Zaposleni",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Grad",
                table: "Zaposleni",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Fiksni",
                table: "Zaposleni",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Email",
                table: "Zaposleni",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Adresa",
                table: "Zaposleni",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "PutanjaDokumenta",
                table: "DokumentiZaposleni",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "ImeDokumenta",
                table: "DokumentiZaposleni",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

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
    }
}
