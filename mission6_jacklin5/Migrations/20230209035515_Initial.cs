using Microsoft.EntityFrameworkCore.Migrations;

namespace mission6_jacklin5.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Movie",
                columns: table => new
                {
                    MovieID = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Category = table.Column<string>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Year = table.Column<ushort>(nullable: false),
                    Director = table.Column<string>(nullable: false),
                    Rating = table.Column<string>(nullable: false),
                    Edited = table.Column<bool>(nullable: false),
                    Lent = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(maxLength: 25, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movie", x => x.MovieID);
                });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 1, "Romance", "Rob Reiner", false, " ", "This is a great film!", "PG", "The Princess Bride", (ushort)1987 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 2, "Animated, Comedy", "Tom McGrath", false, "Brady Jacklin", "Too many baby bums", "PG", "Boss Baby", (ushort)2017 });

            migrationBuilder.InsertData(
                table: "Movie",
                columns: new[] { "MovieID", "Category", "Director", "Edited", "Lent", "Notes", "Rating", "Title", "Year" },
                values: new object[] { 3, "Animated, Comedy", "Rob Minkoff", false, "Kimball Shupe", "The greatest film in history", "PG", "Mr. Peabody and Sherman", (ushort)2014 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movie");
        }
    }
}
