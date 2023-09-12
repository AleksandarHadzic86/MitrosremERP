using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class ModelsZaposleni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Zaposleni",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Ime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Prezime = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    JMBG = table.Column<decimal>(type: "decimal(20,0)", nullable: false),
                    Grad = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Adresa = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fiksni = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Mobilni = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Zaposleni", x => x.Id);
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
                    StatusBolovanja = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
                    BrojDanaGodisnjeg = table.Column<int>(type: "int", nullable: true),
                    StatusGodisnjeg = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
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
        }
    }
}
