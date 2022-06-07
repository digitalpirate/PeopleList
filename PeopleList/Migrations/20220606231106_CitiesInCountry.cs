using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleIndex.Migrations
{
    public partial class CitiesInCountry : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CitiesInCountries",
                columns: table => new
                {
                    CountryId = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CitiesInCountries", x => new { x.CityId, x.CountryId });
                    table.ForeignKey(
                        name: "FK_CitiesInCountries_Countries_CityId",
                        column: x => x.CityId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CitiesInCountries_Cities_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CitiesInCountries_CountryId",
                table: "CitiesInCountries",
                column: "CountryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CitiesInCountries");
        }
    }
}
