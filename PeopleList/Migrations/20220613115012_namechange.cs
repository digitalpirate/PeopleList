using Microsoft.EntityFrameworkCore.Migrations;

namespace PeopleIndex.Migrations
{
    public partial class namechange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeopleWhoSpeakLanguages_Languages_Id",
                table: "PeopleWhoSpeakLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleWhoSpeakLanguages_People_LanguageId",
                table: "PeopleWhoSpeakLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PeopleWhoSpeakLanguages",
                table: "PeopleWhoSpeakLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Id",
                table: "PeopleWhoSpeakLanguages");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "PeopleWhoSpeakLanguages",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "PersonId",
                table: "People",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PeopleWhoSpeakLanguages",
                table: "PeopleWhoSpeakLanguages",
                columns: new[] { "PersonId", "LanguageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "PersonId");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "PersonId", "CityId", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 4, "Christian", "0123456789" },
                    { 2, 4, "Billy", "1234567890" },
                    { 3, 1, "Adam", "3456789012" },
                    { 4, 2, "Dennis", "3478956012" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleWhoSpeakLanguages_People_LanguageId",
                table: "PeopleWhoSpeakLanguages",
                column: "LanguageId",
                principalTable: "People",
                principalColumn: "PersonId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleWhoSpeakLanguages_Languages_PersonId",
                table: "PeopleWhoSpeakLanguages",
                column: "PersonId",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PeopleWhoSpeakLanguages_People_LanguageId",
                table: "PeopleWhoSpeakLanguages");

            migrationBuilder.DropForeignKey(
                name: "FK_PeopleWhoSpeakLanguages_Languages_PersonId",
                table: "PeopleWhoSpeakLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PeopleWhoSpeakLanguages",
                table: "PeopleWhoSpeakLanguages");

            migrationBuilder.DropPrimaryKey(
                name: "PK_People",
                table: "People");

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "People",
                keyColumn: "PersonId",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "PeopleWhoSpeakLanguages");

            migrationBuilder.DropColumn(
                name: "PersonId",
                table: "People");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "PeopleWhoSpeakLanguages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "People",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_PeopleWhoSpeakLanguages",
                table: "PeopleWhoSpeakLanguages",
                columns: new[] { "Id", "LanguageId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_People",
                table: "People",
                column: "Id");

            migrationBuilder.InsertData(
                table: "People",
                columns: new[] { "Id", "CityId", "Name", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, 4, "Christian", "0123456789" },
                    { 2, 4, "Billy", "1234567890" },
                    { 3, 1, "Adam", "3456789012" },
                    { 4, 2, "Dennis", "3478956012" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleWhoSpeakLanguages_Languages_Id",
                table: "PeopleWhoSpeakLanguages",
                column: "Id",
                principalTable: "Languages",
                principalColumn: "LanguageId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PeopleWhoSpeakLanguages_People_LanguageId",
                table: "PeopleWhoSpeakLanguages",
                column: "LanguageId",
                principalTable: "People",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
