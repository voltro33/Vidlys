using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class addedDateRemoved : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "DateRemoved",
                table: "Movies",
                type: "datetime2",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DateRemoved",
                table: "Movies");
        }
    }
}
