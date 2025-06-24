using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace server.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class task2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Tests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "Type",
                table: "Tests",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 1,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 2,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 3,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 4,
                column: "Type",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 5,
                column: "Type",
                value: 0);

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "EnhancedAnswer", "Image", "Question", "Solved", "Title", "Total", "Type", "UserAnswer" },
                values: new object[,]
                {
                    { 6, "", null, "'People who do not use social media networks* will always fall behind in career development opportunities.'\r\nTo what extent do you feel that this is an accurate and important prediction?", false, "Social Media Networks", "", 1, "" },
                    { 7, "", null, "'People who do not use social media networks* will always fall behind in career development opportunities.'\r\nTo what extent do you feel that this is an accurate and important prediction?", false, "Houshould Waste Produced", "", 1, "" },
                    { 8, "", null, "In many countries, truancy* is a worrying problem for both parents and educators.\r\nWhat are the causes of truancy, and what may be the effects on the child and the wider community?", false, "Effect Of Truancy", "", 1, "" },
                    { 9, "", null, "Some employers are willing to give their workers a certain amount of unpaid sabbatical* time, believing this benefits the individual and the organisation. Other employers see no merit in this arrangement and discourage it.\r\nConsider the possible arguments for and against unpaid sabbatical leave, and reach a viewpoint of your own.", false, "Unpaid sabbatical leave", "", 1, "" },
                    { 10, "", null, "Some commentators feel that grandparents should live together with their children and grandchildren, while others say that elderly people should be encouraged to live independently.\r\nConsider the possible arguments on both sides of this debate, and reach your own conclusion.\r\n", false, "Gradparents residence argument", "", 1, "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tests",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DropColumn(
                name: "Type",
                table: "Tests");

            migrationBuilder.AlterColumn<string>(
                name: "Image",
                table: "Tests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);
        }
    }
}
