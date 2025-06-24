using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace server.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class seedingerror : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Question",
                value: "Many people today are worried about the large quantities of waste produced by ordinary households.\r\nWhat problems are caused by household waste, and what solutions may be possible in both the short and the long term?");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7,
                column: "Question",
                value: "'People who do not use social media networks* will always fall behind in career development opportunities.'\r\nTo what extent do you feel that this is an accurate and important prediction?");
        }
    }
}
