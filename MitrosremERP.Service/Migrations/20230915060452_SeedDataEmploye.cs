using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MitrosremERP.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedDataEmploye : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Profesija",
                table: "Zaposleni",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Grad",
                table: "Zaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 1,
                column: "RadnoMesto",
                value: "Odrzavanje el.instalacija");

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Profesija", "RadnoMesto" },
                values: new object[] { "Masinski Tehnicar", "Odrzavanje masicna" });

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[] { "Diplomirani Tehnolog", "Tehnolog hrane", 6 });

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[] { "System Administrator", "IT Administrator", 5 });

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[] { "Developer", "Programer", 5 });

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[] { "Master Ekonomista", "Finansije", 7 });

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[] { "Diplomirani Ekonomista", "Racunovodstvo", 6 });

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[] { "Trgovac", "Maloprodaja", 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Profesija",
                table: "Zaposleni",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Grad",
                table: "Zaposleni",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 1,
                column: "RadnoMesto",
                value: null);

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Profesija", "RadnoMesto" },
                values: new object[] { "Elektro Tehnicar", null });

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[] { "Elektro Tehnicar", null, 4 });

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[] { "Elektro Tehnicar", null, 4 });

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[] { "Elektro Tehnicar", null, 4 });

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[] { "Elektro Tehnicar", null, 4 });

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[] { "Elektro Tehnicar", null, 4 });

            migrationBuilder.UpdateData(
                table: "Zaposleni",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Profesija", "RadnoMesto", "StepenStrucneSpremeId" },
                values: new object[] { "Elektro Tehnicar", null, 4 });
        }
    }
}
