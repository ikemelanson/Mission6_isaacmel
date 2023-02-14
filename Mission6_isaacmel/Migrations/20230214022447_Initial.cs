using Microsoft.EntityFrameworkCore.Migrations;

namespace Mission6_isaacmel.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "responses",
                columns: table => new
                {
                    ApplicationId = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<int>(nullable: false),
                    DirectorFirstName = table.Column<string>(nullable: false),
                    DirectoryLastName = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    LentTo = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_responses", x => x.ApplicationId);
                });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "Category", "DirectorFirstName", "DirectoryLastName", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Action/Adventure", "Gary", "Gray", false, null, null, "PG-13", "Italian Job, The", 2003 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "Category", "DirectorFirstName", "DirectoryLastName", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Action/Adventure", "Christopher", "Nolan", false, null, null, "PG-13", "Batman Begins", 2005 });

            migrationBuilder.InsertData(
                table: "responses",
                columns: new[] { "ApplicationId", "Category", "DirectorFirstName", "DirectoryLastName", "Edited", "LentTo", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Action/Adventure", "Andrew", "Davis", false, null, null, "PG-13", "The Fugitive", 1993 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "responses");
        }
    }
}
