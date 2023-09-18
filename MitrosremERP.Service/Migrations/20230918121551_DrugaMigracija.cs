using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class DrugaMigracija : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "StepenStrucneSpreme",
                columns: new[] { "Id", "StepenObrazovanja" },
                values: new object[,]
                {
                    { 1, "I Stepen - Osnovno Obrazovanje." },
                    { 2, "II Stepen - Strucno osposobljavanje u trajanju do 1 godine." },
                    { 3, "III Stepen - Srednje strucno obrazovanje 3 godine." },
                    { 4, "IV Stepen - Srednje strucno obrazovanje 4 godine." },
                    { 5, "VI-1 Stepen - Osnovne strukovne studije." },
                    { 6, "VI-2 Stepen - Osnovne akademske i Specijalisticke strukovne studije." },
                    { 7, "VII-1 Stepen - Master akademske i master strukovne studije" },
                    { 8, "VIII Stepen - Doktorske studije" }
                });

            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "Id", "Adresa", "Fiksni", "Grad", "ImageUrl", "Ime", "JMBG", "Mobilni", "Napomena", "Pol", "Prezime", "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[,]
                {
                    { 1, "Stari Sor", null, "Sr.Mitrovica", "", "Aleksandar", 1702986890023L, "0605574477", null, "Musko", "Hadzic", "Elektro Tehnicar", "Odrzavanje el.instalacija", 4 },
                    { 2, "BB", null, "Sid", "", "Petar", 4302386890023L, "06553427", null, "Musko", "Petrovic", "Masinski Tehnicar", "Odrzavanje masicna", 4 },
                    { 3, "BB", null, "Sabac", "", "Jovan", 2132986890023L, "0605574477", null, "Musko", "Jovanovic", "Diplomirani Tehnolog", "Tehnolog hrane", 6 },
                    { 4, "BB", null, "Beograd", "", "Sreten", 3123986890023L, "0605574477", null, "Musko", "Sretenovic", "System Administrator", "IT Administrator", 5 },
                    { 5, "Stari Sor", null, "Sr.Mitrovica", "", "Goran", 1702986890023L, "0605574477", null, "Musko", "Goranic", "Developer", "Programer", 5 },
                    { 6, "BB", null, "Sid", "", "MIlan", 4302386890023L, "06553427", null, "Musko", "Milanovic", "Master Ekonomista", "Finansije", 7 },
                    { 7, "BB", null, "Sabac", "", "Zoran", 2132986890023L, "0605574477", null, "Musko", "Zoranovic", "Diplomirani Ekonomista", "Racunovodstvo", 6 },
                    { 8, "BB", null, "Beograd", "", "Stevan", 3123986890023L, "0605574477", null, "Musko", "Stevanovic", "Trgovac", "Maloprodaja", 3 }
                });

            migrationBuilder.InsertData(
                table: "Ugovori",
                columns: new[] { "Id", "BrojDanaGodisnjeg", "BrojUgovora", "DatumPocetka", "DatumZavrsetka", "Napomena", "TipUgovora", "ZaposleniId" },
                values: new object[] { 1, 22, "MS0001", new DateOnly(1992, 2, 17), null, null, "Odredjeno", 1 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StepenStrucneSpreme",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StepenStrucneSpreme",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "StepenStrucneSpreme",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Ugovori",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "StepenStrucneSpreme",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "StepenStrucneSpreme",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "StepenStrucneSpreme",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "StepenStrucneSpreme",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "StepenStrucneSpreme",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
