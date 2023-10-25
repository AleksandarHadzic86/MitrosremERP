using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class Rute : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("1247e043-c488-4978-bd76-edd9c14237f7"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("29dd38e5-85e3-48dd-9129-39c24b261d76"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("3137d7da-7120-425b-949c-4607daf90732"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("4c928b8a-94a5-421b-8303-f16e3518d39b"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("4e3bbb89-3859-4fdd-817b-360cc9c79747"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("9bfed578-1a3d-479e-a837-02b5a33c7e25"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("a9de6eb8-e59d-4520-9eea-fb113e41f8ba"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("ed6e3cc1-914f-4fcf-97f5-ae045cf807b4"));

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

            migrationBuilder.CreateTable(
                name: "KategorijaVozila",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NazivKategorije = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Vrednost = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KategorijaVozila", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Region",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SifraRegiona = table.Column<int>(type: "int", nullable: false),
                    NazivRegiona = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Vrednost = table.Column<int>(type: "int", nullable: false),
                    Dnevnica = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Region", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vozila",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SifraVozila = table.Column<int>(type: "int", nullable: false),
                    MarkaVozila = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ModelVozila = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    RegistarskeOznake = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    GodinaProizvodnje = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    RegistrovanDo = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Boja = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BrojSasije = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Gorivo = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    BrojSedista = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Nosivost = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Napomena = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KategorijaVozilaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vozila", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Vozila_KategorijaVozila_KategorijaVozilaId",
                        column: x => x.KategorijaVozilaId,
                        principalTable: "KategorijaVozila",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PutniNalog",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BrojPutnogNaloga = table.Column<int>(type: "int", nullable: false),
                    DatumPutnogNaloga = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BrojTovarnogLista = table.Column<int>(type: "int", nullable: false),
                    BrojIstovarnihMesta = table.Column<int>(type: "int", nullable: false),
                    NetoKg = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    StanjeKMsata = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NasutoLitara = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrPonetihLodni = table.Column<int>(type: "int", nullable: false),
                    BrVracenihLodni = table.Column<int>(type: "int", nullable: false),
                    BrPonetihPaleta = table.Column<int>(type: "int", nullable: false),
                    BrVracenihPaleta = table.Column<int>(type: "int", nullable: false),
                    VozilaId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RegionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PutniNalog", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PutniNalog_Region_RegionId",
                        column: x => x.RegionId,
                        principalTable: "Region",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PutniNalog_Vozila_VozilaId",
                        column: x => x.VozilaId,
                        principalTable: "Vozila",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_PutniNalog_RegionId",
                table: "PutniNalog",
                column: "RegionId");

            migrationBuilder.CreateIndex(
                name: "IX_PutniNalog_VozilaId",
                table: "PutniNalog",
                column: "VozilaId");

            migrationBuilder.CreateIndex(
                name: "IX_Vozila_KategorijaVozilaId",
                table: "Vozila",
                column: "KategorijaVozilaId");

            migrationBuilder.AddForeignKey(
                name: "FK_Zaposleni_PutniNalog_PutniNalogId",
                table: "Zaposleni",
                column: "PutniNalogId",
                principalTable: "PutniNalog",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zaposleni_PutniNalog_PutniNalogId",
                table: "Zaposleni");

            migrationBuilder.DropTable(
                name: "PutniNalog");

            migrationBuilder.DropTable(
                name: "Region");

            migrationBuilder.DropTable(
                name: "Vozila");

            migrationBuilder.DropTable(
                name: "KategorijaVozila");

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

            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "Id", "Adresa", "DatumRodjenja", "Email", "Fiksni", "Grad", "ImageUrl", "Ime", "JMBG", "Mobilni", "Napomena", "PolOsobe", "Prezime", "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[,]
                {
                    { new Guid("1247e043-c488-4978-bd76-edd9c14237f7"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "Petra", "4302386890023", "06553427", null, 1, "Petrovic", "Masinski Tehnicar", "Odrzavanje masicna", 4 },
                    { new Guid("29dd38e5-85e3-48dd-9129-39c24b261d76"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Jelena", "1702986890023", "0605574477", null, 1, "Jovanovic", "Developer", "Programer", 5 },
                    { new Guid("3137d7da-7120-425b-949c-4607daf90732"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "MIlan", "4302386890023", "06553427", null, 0, "Milanovic", "Master Ekonomista", "Finansije", 7 },
                    { new Guid("4c928b8a-94a5-421b-8303-f16e3518d39b"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Zorana", "2132986890023", "0605574477", null, 1, "Zoranovic", "Diplomirani Ekonomista", "Racunovodstvo", 6 },
                    { new Guid("4e3bbb89-3859-4fdd-817b-360cc9c79747"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Jovan", "2132986890023", "0605574477", null, 1, "Jovanovic", "Diplomirani Tehnolog", "Tehnolog hrane", 6 },
                    { new Guid("9bfed578-1a3d-479e-a837-02b5a33c7e25"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Sreten", "3123986890023", "0605574477", null, 0, "Sretenovic", "System Administrator", "IT Administrator", 5 },
                    { new Guid("a9de6eb8-e59d-4520-9eea-fb113e41f8ba"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Aleksandar", "1702986890023", "0605574477", null, 0, "Hadzic", "Strukovni inzenjer el. i racunara", "System Administrator", 4 },
                    { new Guid("ed6e3cc1-914f-4fcf-97f5-ae045cf807b4"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Stevan", "3123986890023", "0605574477", null, 0, "Stevanovic", "Trgovac", "Maloprodaja", 6 }
                });
        }
    }
}
