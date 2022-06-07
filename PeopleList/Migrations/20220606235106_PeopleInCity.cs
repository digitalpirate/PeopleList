using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleIndex.Migrations
{
    public partial class PeopleInCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CitiesInCountries_Cities_CountryId",
                table: "CitiesInCountries");

            migrationBuilder.DropIndex(
                name: "IX_CitiesInCountries_CountryId",
                table: "CitiesInCountries");

            migrationBuilder.AddColumn<int>(
                name: "CityId1",
                table: "CitiesInCountries",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "PeopleInCities",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false),
                    CityId = table.Column<int>(nullable: false),
                    PeopleId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleInCities", x => new { x.Id, x.CityId });
                    table.ForeignKey(
                        name: "FK_PeopleInCities_Cities_CityId",
                        column: x => x.CityId,
                        principalTable: "Cities",
                        principalColumn: "CityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeopleInCities_People_PeopleId",
                        column: x => x.PeopleId,
                        principalTable: "People",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CitiesInCountries_CityId1",
                table: "CitiesInCountries",
                column: "CityId1");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleInCities_CityId",
                table: "PeopleInCities",
                column: "CityId");

            migrationBuilder.CreateIndex(
                name: "IX_PeopleInCities_PeopleId",
                table: "PeopleInCities",
                column: "PeopleId");

            migrationBuilder.AddForeignKey(
                name: "FK_CitiesInCountries_Cities_CityId1",
                table: "CitiesInCountries",
                column: "CityId1",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CitiesInCountries_Cities_CityId1",
                table: "CitiesInCountries");

            migrationBuilder.DropTable(
                name: "PeopleInCities");

            migrationBuilder.DropIndex(
                name: "IX_CitiesInCountries_CityId1",
                table: "CitiesInCountries");

            migrationBuilder.DropColumn(
                name: "CityId1",
                table: "CitiesInCountries");

            migrationBuilder.CreateIndex(
                name: "IX_CitiesInCountries_CountryId",
                table: "CitiesInCountries",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_CitiesInCountries_Cities_CountryId",
                table: "CitiesInCountries",
                column: "CountryId",
                principalTable: "Cities",
                principalColumn: "CityId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
