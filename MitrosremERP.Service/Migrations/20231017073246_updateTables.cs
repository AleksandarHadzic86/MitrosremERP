using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class updateTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zaposleni_Pol_PolOsobeId",
                table: "Zaposleni");

            migrationBuilder.DropIndex(
                name: "IX_Zaposleni_PolOsobeId",
                table: "Zaposleni");

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("08ec171f-a776-4338-9d77-931d4adc01c8"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("2b3ef60c-a5e7-424b-93e5-eaa6092c03bc"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("51645c7b-2f9f-4209-b688-b3e4cdfa6ef3"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("9645359d-f211-4b37-ba6d-24f29072012b"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("a296f846-46f7-4cd0-a027-80d13e26fbcb"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("a2ea6c06-0ae7-4bc4-a5ef-9dd1d79e3f0a"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("d2f21dda-fccf-4aea-a4c8-b13d2e02e3f0"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("e959eb92-bf46-418e-b251-a6fc12175e1e"));

            migrationBuilder.DeleteData(
                table: "Pol",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Pol",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DropColumn(
                name: "PocetakGodisnjegOdmora",
                table: "GodisnjiOdmori");

            migrationBuilder.DropColumn(
                name: "StatusGodisnjeg",
                table: "GodisnjiOdmori");

            migrationBuilder.DropColumn(
                name: "ZavrsetakGodisnjegOdmora",
                table: "GodisnjiOdmori");

            migrationBuilder.DropColumn(
                name: "PocetakBolovanja",
                table: "Bolovanja");

            migrationBuilder.DropColumn(
                name: "StatusBolovanja",
                table: "Bolovanja");

            migrationBuilder.DropColumn(
                name: "ZakljucenoBolovanje",
                table: "Bolovanja");

            migrationBuilder.RenameColumn(
                name: "PolOsobeId",
                table: "Zaposleni",
                newName: "PolOsobe");

            migrationBuilder.AddColumn<int>(
                name: "PolId",
                table: "Zaposleni",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumPocetkaGodisnjeg",
                table: "GodisnjiOdmori",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumZavrsetkaGodisnjeg",
                table: "GodisnjiOdmori",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<int>(
                name: "StatusBolGod",
                table: "GodisnjiOdmori",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumPocetkaBolovanja",
                table: "Bolovanja",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "DatumZavrsetkaBolovanja",
                table: "Bolovanja",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "StatusBolGod",
                table: "Bolovanja",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "DokumentiZaposleni",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ImeDokumenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PutanjaDokumenta = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ZaposleniId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DokumentiZaposleni", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DokumentiZaposleni_Zaposleni_ZaposleniId",
                        column: x => x.ZaposleniId,
                        principalTable: "Zaposleni",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "Id", "Adresa", "DatumRodjenja", "Email", "Fiksni", "Grad", "ImageUrl", "Ime", "JMBG", "Mobilni", "Napomena", "PolId", "PolOsobe", "Prezime", "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[,]
                {
                    { new Guid("275d4843-576d-414f-aab1-b07929402aca"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Jovan", "2132986890023", "0605574477", null, null, 1, "Jovanovic", "Diplomirani Tehnolog", "Tehnolog hrane", 6 },
                    { new Guid("716b56d9-1c37-486c-a4d8-e0d39754a7e5"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Aleksandar", "1702986890023", "0605574477", null, null, 0, "Hadzic", "Elektro Tehnicar", "Odrzavanje el.instalacija", 4 },
                    { new Guid("944f38cd-156f-4974-bac0-6809dd9f9974"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "Petar", "4302386890023", "06553427", null, null, 0, "Petrovic", "Masinski Tehnicar", "Odrzavanje masicna", 4 },
                    { new Guid("bd7a3c77-b82f-4934-9236-a50c281999c0"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Goran", "1702986890023", "0605574477", null, null, 0, "Goranic", "Developer", "Programer", 5 },
                    { new Guid("c01b1826-eb31-49f2-90e6-de2eeacb3190"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Zorana", "2132986890023", "0605574477", null, null, 0, "Zoranovic", "Diplomirani Ekonomista", "Racunovodstvo", 6 },
                    { new Guid("c11d92a5-5315-4cc3-9b06-a3bcf9fb63c8"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Sreten", "3123986890023", "0605574477", null, null, 0, "Sretenovic", "System Administrator", "IT Administrator", 5 },
                    { new Guid("caedba00-4ff8-4d8c-aa51-ef769029d6d5"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Stevan", "3123986890023", "0605574477", null, null, 1, "Stevanovic", "Trgovac", "Maloprodaja", 6 },
                    { new Guid("fbbaa504-bfed-489f-b9b7-de6a37759978"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "MIlan", "4302386890023", "06553427", null, null, 0, "Milanovic", "Master Ekonomista", "Finansije", 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zaposleni_PolId",
                table: "Zaposleni",
                column: "PolId");

            migrationBuilder.CreateIndex(
                name: "IX_DokumentiZaposleni_ZaposleniId",
                table: "DokumentiZaposleni",
                column: "ZaposleniId");

            migrationBuilder.AddForeignKey(
                name: "FK_Zaposleni_Pol_PolId",
                table: "Zaposleni",
                column: "PolId",
                principalTable: "Pol",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Zaposleni_Pol_PolId",
                table: "Zaposleni");

            migrationBuilder.DropTable(
                name: "DokumentiZaposleni");

            migrationBuilder.DropIndex(
                name: "IX_Zaposleni_PolId",
                table: "Zaposleni");

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("275d4843-576d-414f-aab1-b07929402aca"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("716b56d9-1c37-486c-a4d8-e0d39754a7e5"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("944f38cd-156f-4974-bac0-6809dd9f9974"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("bd7a3c77-b82f-4934-9236-a50c281999c0"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("c01b1826-eb31-49f2-90e6-de2eeacb3190"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("c11d92a5-5315-4cc3-9b06-a3bcf9fb63c8"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("caedba00-4ff8-4d8c-aa51-ef769029d6d5"));

            migrationBuilder.DeleteData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: new Guid("fbbaa504-bfed-489f-b9b7-de6a37759978"));

            migrationBuilder.DropColumn(
                name: "PolId",
                table: "Zaposleni");

            migrationBuilder.DropColumn(
                name: "DatumPocetkaGodisnjeg",
                table: "GodisnjiOdmori");

            migrationBuilder.DropColumn(
                name: "DatumZavrsetkaGodisnjeg",
                table: "GodisnjiOdmori");

            migrationBuilder.DropColumn(
                name: "StatusBolGod",
                table: "GodisnjiOdmori");

            migrationBuilder.DropColumn(
                name: "DatumPocetkaBolovanja",
                table: "Bolovanja");

            migrationBuilder.DropColumn(
                name: "DatumZavrsetkaBolovanja",
                table: "Bolovanja");

            migrationBuilder.DropColumn(
                name: "StatusBolGod",
                table: "Bolovanja");

            migrationBuilder.RenameColumn(
                name: "PolOsobe",
                table: "Zaposleni",
                newName: "PolOsobeId");

            migrationBuilder.AddColumn<DateOnly>(
                name: "PocetakGodisnjegOdmora",
                table: "GodisnjiOdmori",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "StatusGodisnjeg",
                table: "GodisnjiOdmori",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "ZavrsetakGodisnjegOdmora",
                table: "GodisnjiOdmori",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<DateOnly>(
                name: "PocetakBolovanja",
                table: "Bolovanja",
                type: "date",
                nullable: false,
                defaultValue: new DateOnly(1, 1, 1));

            migrationBuilder.AddColumn<string>(
                name: "StatusBolovanja",
                table: "Bolovanja",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateOnly>(
                name: "ZakljucenoBolovanje",
                table: "Bolovanja",
                type: "date",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Pol",
                columns: new[] { "Id", "PolOsobe" },
                values: new object[,]
                {
                    { 1, "Musko" },
                    { 2, "Zensko" }
                });

            migrationBuilder.InsertData(
                table: "Zaposleni",
                columns: new[] { "Id", "Adresa", "DatumRodjenja", "Email", "Fiksni", "Grad", "ImageUrl", "Ime", "JMBG", "Mobilni", "Napomena", "PolOsobeId", "Prezime", "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[,]
                {
                    { new Guid("08ec171f-a776-4338-9d77-931d4adc01c8"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "Petar", "4302386890023", "06553427", null, 1, "Petrovic", "Masinski Tehnicar", "Odrzavanje masicna", 4 },
                    { new Guid("2b3ef60c-a5e7-424b-93e5-eaa6092c03bc"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Goran", "1702986890023", "0605574477", null, 1, "Goranic", "Developer", "Programer", 5 },
                    { new Guid("51645c7b-2f9f-4209-b688-b3e4cdfa6ef3"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Jovan", "2132986890023", "0605574477", null, 2, "Jovanovic", "Diplomirani Tehnolog", "Tehnolog hrane", 6 },
                    { new Guid("9645359d-f211-4b37-ba6d-24f29072012b"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Sreten", "3123986890023", "0605574477", null, 1, "Sretenovic", "System Administrator", "IT Administrator", 5 },
                    { new Guid("a296f846-46f7-4cd0-a027-80d13e26fbcb"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sabac", "", "Zorana", "2132986890023", "0605574477", null, 2, "Zoranovic", "Diplomirani Ekonomista", "Racunovodstvo", 6 },
                    { new Guid("a2ea6c06-0ae7-4bc4-a5ef-9dd1d79e3f0a"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Beograd", "", "Stevan", "3123986890023", "0605574477", null, 1, "Stevanovic", "Trgovac", "Maloprodaja", 6 },
                    { new Guid("d2f21dda-fccf-4aea-a4c8-b13d2e02e3f0"), "Stari Sor", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sr.Mitrovica", "", "Aleksandar", "1702986890023", "0605574477", null, 1, "Hadzic", "Elektro Tehnicar", "Odrzavanje el.instalacija", 4 },
                    { new Guid("e959eb92-bf46-418e-b251-a6fc12175e1e"), "BB", new DateTime(2000, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "mitrosrem@ad.rs", null, "Sid", "", "MIlan", "4302386890023", "06553427", null, 1, "Milanovic", "Master Ekonomista", "Finansije", 7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Zaposleni_PolOsobeId",
                table: "Zaposleni",
                column: "PolOsobeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Zaposleni_Pol_PolOsobeId",
                table: "Zaposleni",
                column: "PolOsobeId",
                principalTable: "Pol",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
