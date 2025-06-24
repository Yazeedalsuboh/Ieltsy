using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace server.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Tests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Question = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Solved = table.Column<bool>(type: "bit", nullable: false),
                    UserAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Total = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EnhancedAnswer = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tests", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Tests",
                columns: new[] { "Id", "EnhancedAnswer", "Image", "Question", "Solved", "Title", "Total", "UserAnswer" },
                values: new object[,]
                {
                    { 1, "", "uploads/Test1.png", "Y-Axis: Average cheese consumption in kilograms\r\nX-Axis: Years (1980 to 2020)\r\nCountries Represented: England (blue), Scotland (red), Wales (yellow), Northern Ireland (green)\r\n\r\nDetails:\r\nEngland:\r\n\r\n1980: ~110 kg\r\n\r\nGradual decrease over time\r\n\r\n2020: ~85 kg\r\n\r\nScotland:\r\n\r\n1980: ~85 kg\r\n\r\nRose significantly to a peak of ~105 kg in 1990\r\n\r\nSteady decline afterward\r\n\r\n2020: ~58 kg\r\n\r\nWales:\r\n\r\n1980: ~45 kg\r\n\r\nGradual increase, peaking slightly above 75 kg by 2010\r\n\r\nSlight increase to 2020: ~76 kg\r\n\r\nNorthern Ireland:\r\n\r\n1980: ~10 kg\r\n\r\nContinuous increase over time\r\n\r\n2020: ~60 kg", false, "Average Cheese Consumption (1980–2020)", "", "" },
                    { 2, "", "uploads/Test2.png", "X-Axis: Quantity in tonnes\r\nCategories:\r\n\r\nBlue bars: Rice Production\r\n\r\nRed bars: Rice Consumption\r\n\r\nCountries and Data (Production vs. Consumption in tonnes):\r\nHungary:\r\n\r\nProduction: 540 tonnes\r\n\r\nConsumption: 532 tonnes\r\n\r\nPhilippines:\r\n\r\nProduction: 410 tonnes\r\n\r\nConsumption: 387 tonnes\r\n\r\nIndia:\r\n\r\nProduction: 106 tonnes\r\n\r\nConsumption: 104 tonnes\r\n\r\nQatar:\r\n\r\nProduction: 94 tonnes\r\n\r\nConsumption: 86 tonnes\r\n\r\nTunisia:\r\n\r\nProduction: 87 tonnes\r\n\r\nConsumption: 70 tonnes\r\n\r\nPakistan:\r\n\r\nProduction: 62 tonnes\r\n\r\nConsumption: 50 tonnes\r\n\r\nVietnam:\r\n\r\nProduction: 56 tonnes\r\n\r\nConsumption: 46 tonnes\r\n\r\nZambia:\r\n\r\nProduction: 53 tonnes\r\n\r\nConsumption: 46 tonnes\r\n\r\nBangladesh:\r\n\r\nProduction: 53 tonnes\r\n\r\nConsumption: 58 tonnes\r\n\r\nSouth Korea:\r\n\r\nProduction: 49 tonnes\r\n\r\nConsumption: 45 tonnes", false, "Rice Production and Consumption in 2020", "", "" },
                    { 3, "", "uploads/Test3.png", "Y-Axis: Percentage (%)\r\nX-Axis Categories:\r\n\r\nUnder 15 years old\r\n\r\n15–64 years\r\n\r\n65 years and older\r\nSeasons Represented:\r\n\r\nSpring (blue)\r\n\r\nSummer (green)\r\n\r\nAutumn (yellow)\r\n\r\nWinter (red)\r\n\r\nBreakdown by Age Group:\r\nUnder 15 years old:\r\n\r\nSpring: ~30%\r\n\r\nSummer: ~45%\r\n\r\nAutumn: ~12%\r\n\r\nWinter: ~12%\r\n\r\n15–64 years:\r\n\r\nSpring: ~32%\r\n\r\nSummer: ~36%\r\n\r\nAutumn: ~20%\r\n\r\nWinter: ~12%\r\n\r\n65 years and older:\r\n\r\nSpring: ~31%\r\n\r\nSummer: ~35%\r\n\r\nAutumn: ~27%\r\n\r\nWinter: ~7%", false, "Chart 3: Favourite Season by Age Group in Portugal", "", "" },
                    { 4, "", "uploads/Test4.png", "Pie Chart – Revenue Sources and Their Percentages:\r\nBroadcasting Rights (Blue): 52% – This is the largest source of revenue for international football teams.\r\n\r\nMatch Day Revenue (Red): 15% – Represents the income from ticket sales and stadium attendance.\r\n\r\nTransfers (Orange): 12% – Income generated from player transfers.\r\n\r\nPrize Money (Light Blue): 8% – Earnings from winning or participating in tournaments.\r\n\r\nMerchandise (Green): 8% – Revenue from selling team-branded items such as jerseys, scarves, and other fan gear.\r\n\r\nSponsorship (Yellow): 5% – Revenue from commercial partnerships and sponsors.\r\n\r\n", false, "Revenue and Fan Age Distribution in International Football", "", "" },
                    { 5, "", "uploads/Test5.png", "2000 – Total Income: $97 billion\r\nRevenue by Industry (in billions):\r\n\r\nSoft Beverages Industry (Blue): 25\r\n\r\nReal Estate Development (Red): 20\r\n\r\nInformation Services (Yellow): 25\r\n\r\nLife Insurance (Green): 12\r\n\r\nSemiconductor Industry (Orange): 15\r\n\r\n2050 (Projected) – Total Income: $196 billion\r\nRevenue by Industry (in billions):\r\n\r\nSoft Beverages Industry (Blue): 25\r\n\r\nReal Estate Development (Red): 25\r\n\r\nInformation Services (Yellow): 10\r\n\r\nLife Insurance (Green): 10\r\n\r\nSemiconductor Industry (Orange): 126", false, "Revenue from 5 Industries in Togo (2000 vs 2050)", "", "" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tests");
        }
    }
}
