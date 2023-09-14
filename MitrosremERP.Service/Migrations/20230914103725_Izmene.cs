using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Izmene : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Grad",
                table: "Zaposleni",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "Profesija",
                table: "Zaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "RadnoMesto",
                table: "Zaposleni",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StepenStrucneSpremeId",
                table: "Zaposleni",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "StepenStrucneSpreme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StepenObrazovanja = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StepenStrucneSpreme", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zaposleni_StepenStrucneSpremeId",
                table: "Zaposleni",
                column: "StepenStrucneSpremeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Zaposleni_StepenStrucneSpreme_StepenStrucneSpremeId",
                table: "Zaposleni",
                column: "StepenStrucneSpremeId",
                principalTable: "StepenStrucneSpreme",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zaposleni_StepenStrucneSpreme_StepenStrucneSpremeId",
                table: "Zaposleni");

            migrationBuilder.DropTable(
                name: "StepenStrucneSpreme");

            migrationBuilder.DropIndex(
                name: "IX_Zaposleni_StepenStrucneSpremeId",
                table: "Zaposleni");

            migrationBuilder.DropColumn(
                name: "Profesija",
                table: "Zaposleni");

            migrationBuilder.DropColumn(
                name: "RadnoMesto",
                table: "Zaposleni");

            migrationBuilder.DropColumn(
                name: "StepenStrucneSpremeId",
                table: "Zaposleni");

            migrationBuilder.AlterColumn<string>(
                name: "Grad",
                table: "Zaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "Id", "Adresa", "Fiksni", "Grad", "Ime", "JMBG", "Mobilni", "Napomena", "Prezime" },
                values: new object[,]
                {
                    { 1, "Stari Sor", null, "Sr.Mitrovica", "Aleksandar", 1702986890023m, "0605574477", null, "Hadzic" },
                    { 2, "BB", null, "Sid", "Petar", 4302386890023m, "06553427", null, "Petrovic" },
                    { 3, "BB", null, "Sabac", "Jovan", 2132986890023m, "0605574477", null, "Jovanovic" },
                    { 4, "BB", null, "Beograd", "Sreten", 3123986890023m, "0605574477", null, "Sretenovic" },
                    { 5, "Stari Sor", null, "Sr.Mitrovica", "Goran", 1702986890023m, "0605574477", null, "Goranic" },
                    { 6, "BB", null, "Sid", "MIlan", 4302386890023m, "06553427", null, "Milanovic" },
                    { 7, "BB", null, "Sabac", "Zoran", 2132986890023m, "0605574477", null, "Zoranovic" },
                    { 8, "BB", null, "Beograd", "Stevan", 3123986890023m, "0605574477", null, "Stevanovic" }
                });

            migrationBuilder.InsertData(
                table: "Ugovori",
                columns: new[] { "Id", "BrojDanaGodisnjeg", "BrojUgovora", "DatumPocetka", "DatumZavrsetka", "Napomena", "TipUgovora", "ZaposleniId" },
                values: new object[] { 1, 22, "MS0001", new DateOnly(1992, 2, 17), null, null, "Odredjeno", 1 });
        }
    }
}
