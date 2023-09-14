using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class moreEmploye : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "Id", "Adresa", "Fiksni", "Grad", "Ime", "JMBG", "Mobilni", "Napomena", "Prezime" },
                values: new object[,]
                {
                    { 5, "Stari Sor", null, "Sr.Mitrovica", "Goran", 1702986890023m, "0605574477", null, "Goranic" },
                    { 6, "BB", null, "Sid", "MIlan", 4302386890023m, "06553427", null, "Milanovic" },
                    { 7, "BB", null, "Sabac", "Zoran", 2132986890023m, "0605574477", null, "Zoranovic" },
                    { 8, "BB", null, "Beograd", "Stevan", 3123986890023m, "0605574477", null, "Stevanovic" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
