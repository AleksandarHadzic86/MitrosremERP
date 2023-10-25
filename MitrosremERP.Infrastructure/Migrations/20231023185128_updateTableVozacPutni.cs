using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateTableVozacPutni : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zaposleni_PutniNalog_PutniNalogId",
                table: "Zaposleni");

            migrationBuilder.DropIndex(
                name: "IX_Zaposleni_PutniNalogId",
                table: "Zaposleni");

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("1cc40884-917a-4820-8fdf-001955af0d03"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("2585f748-16bd-49ff-872d-31adf58474da"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("25f3c6cd-6afb-4b3e-b872-e66b550f27a8"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("5bf63d8f-3752-48b4-8e05-bbcbd7f0d6e9"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("98d22f70-b4c5-4f9d-a877-04452afc02a0"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("b8474746-2e59-4608-9561-e6607068b4f3"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("eb087ed1-8532-4120-a443-8c905e384e82"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("f7c25fc1-59fa-4085-8f73-e906f563a9b3"));

            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Zaposleni");

            migrationBuilder.DropColumn(
                name: "KarticaTahografaDo",
                table: "Zaposleni");

            migrationBuilder.DropColumn(
                name: "KvalifikacionaKarticaDo",
                table: "Zaposleni");

            migrationBuilder.DropColumn(
                name: "LekarskoUverenjeDo",
                table: "Zaposleni");

            migrationBuilder.DropColumn(
                name: "PutniNalogId",
                table: "Zaposleni");

            migrationBuilder.DropColumn(
                name: "SifraVozaca",
                table: "Zaposleni");

            migrationBuilder.DropColumn(
                name: "Vozacka",
                table: "Zaposleni");

            migrationBuilder.DropColumn(
                name: "VozackaDozvolaDo",
                table: "Zaposleni");

            migrationBuilder.CreateTable(
                name: "Vozaci",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SifraVozaca = table.Column<int>(type: "int", nullable: false),
                    LekarskoUverenjeDo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    VozackaDozvolaDo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KarticaTahografaDo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KvalifikacionaKarticaDo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Vozacka = table.Column<int>(type: "int", nullable: false),
                    ZaposleniId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozaci", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vozaci_Zaposleni_ZaposleniId",
                        column: x => x.ZaposleniId,
                        principalTable: "Zaposleni",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PutniNalogVozac",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PutniNalogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VozacId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VozaciId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PutniNalogVozac", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PutniNalogVozac_PutniNalog_PutniNalogId",
                        column: x => x.PutniNalogId,
                        principalTable: "PutniNalog",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PutniNalogVozac_Vozaci_VozaciId",
                        column: x => x.VozaciId,
                        principalTable: "Vozaci",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PutniNalogVozac_PutniNalogId",
                table: "PutniNalogVozac",
                column: "PutniNalogId");

            migrationBuilder.CreateIndex(
                name: "IX_PutniNalogVozac_VozaciId",
                table: "PutniNalogVozac",
                column: "VozaciId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozaci_ZaposleniId",
                table: "Vozaci",
                column: "ZaposleniId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PutniNalogVozac");

            migrationBuilder.DropTable(
                name: "Vozaci");

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

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Zaposleni",
                type: "nvarchar(13)",
                maxLength: 13,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "KarticaTahografaDo",
                table: "Zaposleni",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "KvalifikacionaKarticaDo",
                table: "Zaposleni",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "LekarskoUverenjeDo",
                table: "Zaposleni",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PutniNalogId",
                table: "Zaposleni",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "SifraVozaca",
                table: "Zaposleni",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Vozacka",
                table: "Zaposleni",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "VozackaDozvolaDo",
                table: "Zaposleni",
                type: "datetime2",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "Id", "Adresa", "DatumRodjenja", "Discriminator", "Email", "Fiksni", "Grad", "ImageUrl", "Ime", "JMBG", "Mobilni", "Napomena", "PolOsobe", "Prezime", "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[,]
                {
                    { new Guid("1cc40884-917a-4820-8fdf-001955af0d03"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaposleni", "mitrosrem@ad.rs", null, "Beograd", "", "Stevan", "3123986890023", "0605574477", null, 0, "Stevanovic", "Trgovac", "Maloprodaja", 6 },
                    { new Guid("2585f748-16bd-49ff-872d-31adf58474da"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaposleni", "mitrosrem@ad.rs", null, "Sabac", "", "Zorana", "2132986890023", "0605574477", null, 1, "Zoranovic", "Diplomirani Ekonomista", "Racunovodstvo", 6 },
                    { new Guid("25f3c6cd-6afb-4b3e-b872-e66b550f27a8"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaposleni", "mitrosrem@ad.rs", null, "Beograd", "", "Sreten", "3123986890023", "0605574477", null, 0, "Sretenovic", "System Administrator", "IT Administrator", 5 },
                    { new Guid("5bf63d8f-3752-48b4-8e05-bbcbd7f0d6e9"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaposleni", "mitrosrem@ad.rs", null, "Sid", "", "MIlan", "4302386890023", "06553427", null, 0, "Milanovic", "Master Ekonomista", "Finansije", 7 },
                    { new Guid("98d22f70-b4c5-4f9d-a877-04452afc02a0"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaposleni", "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Aleksandar", "1702986890023", "0605574477", null, 0, "Hadzic", "Strukovni inzenjer el. i racunara", "System Administrator", 4 },
                    { new Guid("b8474746-2e59-4608-9561-e6607068b4f3"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaposleni", "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Jelena", "1702986890023", "0605574477", null, 1, "Jovanovic", "Developer", "Programer", 5 },
                    { new Guid("eb087ed1-8532-4120-a443-8c905e384e82"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaposleni", "mitrosrem@ad.rs", null, "Sid", "", "Petra", "4302386890023", "06553427", null, 1, "Petrovic", "Masinski Tehnicar", "Odrzavanje masicna", 4 },
                    { new Guid("f7c25fc1-59fa-4085-8f73-e906f563a9b3"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Zaposleni", "mitrosrem@ad.rs", null, "Sabac", "", "Jovan", "2132986890023", "0605574477", null, 1, "Jovanovic", "Diplomirani Tehnolog", "Tehnolog hrane", 6 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zaposleni_PutniNalogId",
                table: "Zaposleni",
                column: "PutniNalogId");

            migrationBuilder.AddForeignKey(
                name: "FK_Zaposleni_PutniNalog_PutniNalogId",
                table: "Zaposleni",
                column: "PutniNalogId",
                principalTable: "PutniNalog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
