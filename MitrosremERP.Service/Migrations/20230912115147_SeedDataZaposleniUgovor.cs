using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataZaposleniUgovor : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "Id", "Adresa", "Fiksni", "Grad", "Ime", "JMBG", "Mobilni", "Napomena", "Prezime" },
                values: new object[,]
                {
                    { 1, "Stari Sor", null, "Sr.Mitrovica", "Aleksandar", 1702986890023m, "0605574477", null, "Hadzic" },
                    { 2, "BB", null, "Sid", "Petar", 4302386890023m, "06553427", null, "Petrovic" },
                    { 3, "BB", null, "Sabac", "Jovan", 2132986890023m, "0605574477", null, "Jovanovic" },
                    { 4, "BB", null, "Beograd", "Sreten", 3123986890023m, "0605574477", null, "Sretenovic" }
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
                keyValue: 1);
        }
    }
}
