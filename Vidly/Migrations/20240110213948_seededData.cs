using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Vidly.Migrations
{
    /// <inheritdoc />
    public partial class seededData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "Name", "SignUpFee", "DurationInMonths", "DiscountRate" },
                values: new object[] { 1, "Free", 0, 0, 0 });

            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "Name", "SignUpFee", "DurationInMonths", "DiscountRate" },
                values: new object[] { 2, "Monthly", 30, 1, 10 });

            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "Name", "SignUpFee", "DurationInMonths", "DiscountRate" },
                values: new object[] { 3, "Quarterly", 90, 3, 15 });

            migrationBuilder.InsertData(
                table: "MembershipTypes",
                columns: new[] { "Id", "Name", "SignUpFee", "DurationInMonths", "DiscountRate" },
                values: new object[] { 4, "Annual", 300, 12, 20 });
        }



        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
