using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Lab3.Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Province",
                table: "Cities");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                column: "ProvinceCode",
                value: "ON");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                column: "ProvinceCode",
                value: "QC");

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                column: "ProvinceCode",
                value: "BC");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Province",
                table: "Cities",
                type: "TEXT",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 1,
                columns: new[] { "Province", "ProvinceCode" },
                values: new object[] { "ON", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 2,
                columns: new[] { "Province", "ProvinceCode" },
                values: new object[] { "QC", null });

            migrationBuilder.UpdateData(
                table: "Cities",
                keyColumn: "CityId",
                keyValue: 3,
                columns: new[] { "Province", "ProvinceCode" },
                values: new object[] { "BC", null });
        }
    }
}
