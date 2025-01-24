using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Lab3.Data.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    ProvinceCode = table.Column<string>(type: "TEXT", nullable: false),
                    ProvinceName = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.ProvinceCode);
                });

            migrationBuilder.CreateTable(
                name: "Cities",
                columns: table => new
                {
                    CityId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CityName = table.Column<string>(type: "TEXT", nullable: true),
                    Population = table.Column<int>(type: "INTEGER", nullable: false),
                    Province = table.Column<string>(type: "TEXT", nullable: true),
                    ProvinceCode = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cities", x => x.CityId);
                    table.ForeignKey(
                        name: "FK_Cities_Provinces_ProvinceCode",
                        column: x => x.ProvinceCode,
                        principalTable: "Provinces",
                        principalColumn: "ProvinceCode");
                });

            migrationBuilder.InsertData(
                table: "Cities",
                columns: new[] { "CityId", "CityName", "Population", "Province", "ProvinceCode" },
                values: new object[,]
                {
                    { 1, "Toronto", 2731571, "ON", null },
                    { 2, "Montreal", 1704694, "QC", null },
                    { 3, "Vancouver", 631486, "BC", null }
                });

            migrationBuilder.InsertData(
                table: "Provinces",
                columns: new[] { "ProvinceCode", "ProvinceName" },
                values: new object[,]
                {
                    { "BC", "British Columbia" },
                    { "ON", "Ontario" },
                    { "QC", "Quebec" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Cities_ProvinceCode",
                table: "Cities",
                column: "ProvinceCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cities");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
