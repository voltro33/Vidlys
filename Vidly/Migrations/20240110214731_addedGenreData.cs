using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class addedGenreData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
          
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (1, 'Action')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (2, 'Comedy')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (3, 'Drama')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (4, 'Science Fiction')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (5, 'Fantasy')");
            migrationBuilder.Sql("INSERT INTO Genres (Id, Name) VALUES (6, 'Romance')");
          
        }



        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
