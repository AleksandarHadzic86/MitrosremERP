using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class PrvaMigracija : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "StepenStrucneSpreme",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StepenObrazovanja = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false)
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
                    Ime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JMBG = table.Column<long>(type: "bigint", nullable: false),
                    Pol = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Profesija = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RadnoMesto = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Grad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fiksni = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobilni = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StepenStrucneSpremeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposleni", x => x.Id);
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
                    BrojDanaBolovanja = table.Column<int>(type: "int", nullable: false),
                    StatusBolovanja = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
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
                    StatusGodisnjeg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
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
                    BrojUgovora = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    TipUgovora = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                name: "StepenStrucneSpreme");
        }
    }
}
