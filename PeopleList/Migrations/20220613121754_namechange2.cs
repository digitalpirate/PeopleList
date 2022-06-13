using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleIndex.Migrations
{
    public partial class namechange2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PeopleWhoSpeakLanguages");

            migrationBuilder.CreateTable(
                name: "Personlanguage",
                columns: table => new
                {
                    PersonId = table.Column<int>(nullable: false),
                    LanguageId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Personlanguage", x => new { x.PersonId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_Personlanguage_People_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Personlanguage_Languages_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Personlanguage_LanguageId",
                table: "Personlanguage",
                column: "LanguageId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Personlanguage");

            migrationBuilder.CreateTable(
                name: "PeopleWhoSpeakLanguages",
                columns: table => new
                {
                    PersonId = table.Column<int>(type: "int", nullable: false),
                    LanguageId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeopleWhoSpeakLanguages", x => new { x.PersonId, x.LanguageId });
                    table.ForeignKey(
                        name: "FK_PeopleWhoSpeakLanguages_People_LanguageId",
                        column: x => x.LanguageId,
                        principalTable: "People",
                        principalColumn: "PersonId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PeopleWhoSpeakLanguages_Languages_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Languages",
                        principalColumn: "LanguageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_PeopleWhoSpeakLanguages_LanguageId",
                table: "PeopleWhoSpeakLanguages",
                column: "LanguageId");
        }
    }
}
