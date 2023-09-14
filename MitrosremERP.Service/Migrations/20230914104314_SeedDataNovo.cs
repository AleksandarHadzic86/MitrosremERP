using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataNovo : Migration
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
                columns: new[] { "Id", "Adresa", "Fiksni", "Grad", "Ime", "JMBG", "Mobilni", "Napomena", "Prezime", "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[,]
                {
                    { 1, "Stari Sor", null, "Sr.Mitrovica", "Aleksandar", 1702986890023m, "0605574477", null, "Hadzic", "Elektro Tehnicar", null, 4 },
                    { 2, "BB", null, "Sid", "Petar", 4302386890023m, "06553427", null, "Petrovic", "Elektro Tehnicar", null, 4 },
                    { 3, "BB", null, "Sabac", "Jovan", 2132986890023m, "0605574477", null, "Jovanovic", "Elektro Tehnicar", null, 4 },
                    { 4, "BB", null, "Beograd", "Sreten", 3123986890023m, "0605574477", null, "Sretenovic", "Elektro Tehnicar", null, 4 },
                    { 5, "Stari Sor", null, "Sr.Mitrovica", "Goran", 1702986890023m, "0605574477", null, "Goranic", "Elektro Tehnicar", null, 4 },
                    { 6, "BB", null, "Sid", "MIlan", 4302386890023m, "06553427", null, "Milanovic", "Elektro Tehnicar", null, 4 },
                    { 7, "BB", null, "Sabac", "Zoran", 2132986890023m, "0605574477", null, "Zoranovic", "Elektro Tehnicar", null, 4 },
                    { 8, "BB", null, "Beograd", "Stevan", 3123986890023m, "0605574477", null, "Stevanovic", "Elektro Tehnicar", null, 4 }
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
