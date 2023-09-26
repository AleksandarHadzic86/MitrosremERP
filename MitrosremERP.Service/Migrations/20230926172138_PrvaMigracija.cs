﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PrvaMigracija : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Pol",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolOsobe = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pol", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Zaposleni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JMBG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumRodjenja = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Profesija = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RadnoMesto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Grad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Fiksni = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Mobilni = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StepenStrucneSpremeId = table.Column<int>(type: "int", nullable: false),
                    PolOsobeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposleni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Zaposleni_Pol_PolOsobeId",
                        column: x => x.PolOsobeId,
                        principalTable: "Pol",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Zaposleni_StepenStrucneSpreme_StepenStrucneSpremeId",
                        column: x => x.StepenStrucneSpremeId,
                        principalTable: "StepenStrucneSpreme",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bolovanja",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PocetakBolovanja = table.Column<DateOnly>(type: "date", nullable: false),
                    ZakljucenoBolovanje = table.Column<DateOnly>(type: "date", nullable: true),
                    BrojDanaBolovanja = table.Column<int>(type: "int", nullable: true),
                    StatusBolovanja = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZaposleniId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bolovanja", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bolovanja_Zaposleni_ZaposleniId",
                        column: x => x.ZaposleniId,
                        principalTable: "Zaposleni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "GodisnjiOdmori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PocetakGodisnjegOdmora = table.Column<DateOnly>(type: "date", nullable: false),
                    ZavrsetakGodisnjegOdmora = table.Column<DateOnly>(type: "date", nullable: false),
                    BrojDanaGodisnjeg = table.Column<int>(type: "int", nullable: false),
                    StatusGodisnjeg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZaposleniId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GodisnjiOdmori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GodisnjiOdmori_Zaposleni_ZaposleniId",
                        column: x => x.ZaposleniId,
                        principalTable: "Zaposleni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ugovori",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BrojUgovora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TipUgovora = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumPocetka = table.Column<DateOnly>(type: "date", nullable: false),
                    DatumZavrsetka = table.Column<DateOnly>(type: "date", nullable: true),
                    BrojDanaGodisnjeg = table.Column<int>(type: "int", nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ZaposleniId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ugovori", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ugovori_Zaposleni_ZaposleniId",
                        column: x => x.ZaposleniId,
                        principalTable: "Zaposleni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Pol",
                columns: new[] { "Id", "PolOsobe" },
                values: new object[,]
                {
                    { 1, "Musko" },
                    { 2, "Zensko" }
                });

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
                columns: new[] { "Id", "Adresa", "DatumRodjenja", "Email", "Fiksni", "Grad", "ImageUrl", "Ime", "JMBG", "Mobilni", "Napomena", "PolOsobeId", "Prezime", "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[,]
                {
                    { 1, "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Aleksandar", "1702986890023", "0605574477", null, 1, "Hadzic", "Elektro Tehnicar", "Odrzavanje el.instalacija", 4 },
                    { 2, "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "Petar", "4302386890023", "06553427", null, 1, "Petrovic", "Masinski Tehnicar", "Odrzavanje masicna", 4 },
                    { 3, "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Jovan", "2132986890023", "0605574477", null, 1, "Jovanovic", "Diplomirani Tehnolog", "Tehnolog hrane", 6 },
                    { 4, "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Sreten", "3123986890023", "0605574477", null, 1, "Sretenovic", "System Administrator", "IT Administrator", 5 },
                    { 5, "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Goran", "1702986890023", "0605574477", null, 1, "Goranic", "Developer", "Programer", 5 },
                    { 6, "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "MIlan", "4302386890023", "06553427", null, 1, "Milanovic", "Master Ekonomista", "Finansije", 7 },
                    { 7, "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Zorana", "2132986890023", "0605574477", null, 1, "Zoranovic", "Diplomirani Ekonomista", "Racunovodstvo", 6 },
                    { 8, "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Stevan", "3123986890023", "0605574477", null, 1, "Stevanovic", "Trgovac", "Maloprodaja", 3 }
                });

            migrationBuilder.InsertData(
                table: "Ugovori",
                columns: new[] { "Id", "BrojDanaGodisnjeg", "BrojUgovora", "DatumPocetka", "DatumZavrsetka", "Napomena", "TipUgovora", "ZaposleniId" },
                values: new object[] { 1, 22, "MS0001", new DateOnly(1992, 2, 17), null, null, "Odredjeno", 1 });

            migrationBuilder.CreateIndex(
                name: "IX_Bolovanja_ZaposleniId",
                table: "Bolovanja",
                column: "ZaposleniId");

            migrationBuilder.CreateIndex(
                name: "IX_GodisnjiOdmori_ZaposleniId",
                table: "GodisnjiOdmori",
                column: "ZaposleniId");

            migrationBuilder.CreateIndex(
                name: "IX_Ugovori_ZaposleniId",
                table: "Ugovori",
                column: "ZaposleniId");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposleni_PolOsobeId",
                table: "Zaposleni",
                column: "PolOsobeId");

            migrationBuilder.CreateIndex(
                name: "IX_Zaposleni_StepenStrucneSpremeId",
                table: "Zaposleni",
                column: "StepenStrucneSpremeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bolovanja");

            migrationBuilder.DropTable(
                name: "GodisnjiOdmori");

            migrationBuilder.DropTable(
                name: "Ugovori");

            migrationBuilder.DropTable(
                name: "Zaposleni");

            migrationBuilder.DropTable(
                name: "Pol");

            migrationBuilder.DropTable(
                name: "StepenStrucneSpreme");
        }
    }
}