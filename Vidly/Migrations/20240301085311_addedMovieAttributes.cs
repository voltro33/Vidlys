using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class addedMovieAttributes : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRemoved",
                table: "Movies",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MinuteLeft",
                table: "Movies",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinuteLeft",
                table: "Movies");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateRemoved",
                table: "Movies",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");
        }
    }
}
