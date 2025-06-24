using Microsoft.EntityFrameworkCore;
using server.Domain.Entities;
using server.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace server.Infrastructure.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Test> Tests { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Test>().HasData(
                new Test
                {
                    Id = 1,
                    Title = "Average Cheese Consumption (1980–2020)",
                    Question = "Y-Axis: Average cheese consumption in kilograms\r\nX-Axis: Years (1980 to 2020)\r\nCountries Represented: England (blue), Scotland (red), Wales (yellow), Northern Ireland (green)\r\n\r\nDetails:\r\nEngland:\r\n\r\n1980: ~110 kg\r\n\r\nGradual decrease over time\r\n\r\n2020: ~85 kg\r\n\r\nScotland:\r\n\r\n1980: ~85 kg\r\n\r\nRose significantly to a peak of ~105 kg in 1990\r\n\r\nSteady decline afterward\r\n\r\n2020: ~58 kg\r\n\r\nWales:\r\n\r\n1980: ~45 kg\r\n\r\nGradual increase, peaking slightly above 75 kg by 2010\r\n\r\nSlight increase to 2020: ~76 kg\r\n\r\nNorthern Ireland:\r\n\r\n1980: ~10 kg\r\n\r\nContinuous increase over time\r\n\r\n2020: ~60 kg",
                    Image = "uploads/Test1.png",
                    Type = TypeEnum.Task1,
                },
                new Test
                {
                    Id = 2,
                    Title = "Rice Production and Consumption in 2020",
                    Question = "X-Axis: Quantity in tonnes\r\nCategories:\r\n\r\nBlue bars: Rice Production\r\n\r\nRed bars: Rice Consumption\r\n\r\nCountries and Data (Production vs. Consumption in tonnes):\r\nHungary:\r\n\r\nProduction: 540 tonnes\r\n\r\nConsumption: 532 tonnes\r\n\r\nPhilippines:\r\n\r\nProduction: 410 tonnes\r\n\r\nConsumption: 387 tonnes\r\n\r\nIndia:\r\n\r\nProduction: 106 tonnes\r\n\r\nConsumption: 104 tonnes\r\n\r\nQatar:\r\n\r\nProduction: 94 tonnes\r\n\r\nConsumption: 86 tonnes\r\n\r\nTunisia:\r\n\r\nProduction: 87 tonnes\r\n\r\nConsumption: 70 tonnes\r\n\r\nPakistan:\r\n\r\nProduction: 62 tonnes\r\n\r\nConsumption: 50 tonnes\r\n\r\nVietnam:\r\n\r\nProduction: 56 tonnes\r\n\r\nConsumption: 46 tonnes\r\n\r\nZambia:\r\n\r\nProduction: 53 tonnes\r\n\r\nConsumption: 46 tonnes\r\n\r\nBangladesh:\r\n\r\nProduction: 53 tonnes\r\n\r\nConsumption: 58 tonnes\r\n\r\nSouth Korea:\r\n\r\nProduction: 49 tonnes\r\n\r\nConsumption: 45 tonnes",
                    Image = "uploads/Test2.png",
                    Type = TypeEnum.Task1
                },
                new Test
                {
                    Id = 3,
                    Title = "Chart 3: Favourite Season by Age Group in Portugal",
                    Question = "Y-Axis: Percentage (%)\r\nX-Axis Categories:\r\n\r\nUnder 15 years old\r\n\r\n15–64 years\r\n\r\n65 years and older\r\nSeasons Represented:\r\n\r\nSpring (blue)\r\n\r\nSummer (green)\r\n\r\nAutumn (yellow)\r\n\r\nWinter (red)\r\n\r\nBreakdown by Age Group:\r\nUnder 15 years old:\r\n\r\nSpring: ~30%\r\n\r\nSummer: ~45%\r\n\r\nAutumn: ~12%\r\n\r\nWinter: ~12%\r\n\r\n15–64 years:\r\n\r\nSpring: ~32%\r\n\r\nSummer: ~36%\r\n\r\nAutumn: ~20%\r\n\r\nWinter: ~12%\r\n\r\n65 years and older:\r\n\r\nSpring: ~31%\r\n\r\nSummer: ~35%\r\n\r\nAutumn: ~27%\r\n\r\nWinter: ~7%",
                    Image = "uploads/Test3.png",
                    Type = TypeEnum.Task1
                },
                new Test
                {
                    Id = 4,
                    Title = "Revenue and Fan Age Distribution in International Football",
                    Question = "Pie Chart – Revenue Sources and Their Percentages:\r\nBroadcasting Rights (Blue): 52% – This is the largest source of revenue for international football teams.\r\n\r\nMatch Day Revenue (Red): 15% – Represents the income from ticket sales and stadium attendance.\r\n\r\nTransfers (Orange): 12% – Income generated from player transfers.\r\n\r\nPrize Money (Light Blue): 8% – Earnings from winning or participating in tournaments.\r\n\r\nMerchandise (Green): 8% – Revenue from selling team-branded items such as jerseys, scarves, and other fan gear.\r\n\r\nSponsorship (Yellow): 5% – Revenue from commercial partnerships and sponsors.\r\n\r\n",
                    Image = "uploads/Test4.png",
                    Type = TypeEnum.Task1
                },
                new Test
                {
                    Id = 5,
                    Title = "Revenue from 5 Industries in Togo (2000 vs 2050)",
                    Question = "2000 – Total Income: $97 billion\r\nRevenue by Industry (in billions):\r\n\r\nSoft Beverages Industry (Blue): 25\r\n\r\nReal Estate Development (Red): 20\r\n\r\nInformation Services (Yellow): 25\r\n\r\nLife Insurance (Green): 12\r\n\r\nSemiconductor Industry (Orange): 15\r\n\r\n2050 (Projected) – Total Income: $196 billion\r\nRevenue by Industry (in billions):\r\n\r\nSoft Beverages Industry (Blue): 25\r\n\r\nReal Estate Development (Red): 25\r\n\r\nInformation Services (Yellow): 10\r\n\r\nLife Insurance (Green): 10\r\n\r\nSemiconductor Industry (Orange): 126",
                    Image = "uploads/Test5.png",
                    Type = TypeEnum.Task1
                },
                new Test
                {
                    Id = 6,
                    Title = "Social Media Networks",
                    Question= "'People who do not use social media networks* will always fall behind in career development opportunities.'\r\nTo what extent do you feel that this is an accurate and important prediction?",
                    Type = TypeEnum.Task2
                },
                new Test
                {
                    Id =7,
                    Title = "Houshould Waste Produced",
                    Question = "Many people today are worried about the large quantities of waste produced by ordinary households.\r\nWhat problems are caused by household waste, and what solutions may be possible in both the short and the long term?",
                    Type = TypeEnum.Task2
                },
                new Test
                {
                    Id = 8,
                    Title = "Effect Of Truancy",
                    Question= "In many countries, truancy* is a worrying problem for both parents and educators.\r\nWhat are the causes of truancy, and what may be the effects on the child and the wider community?",
                    Type = TypeEnum.Task2
                },
                new Test
                {
                    Id = 9,
                    Title = "Unpaid sabbatical leave",
                    Question = "Some employers are willing to give their workers a certain amount of unpaid sabbatical* time, believing this benefits the individual and the organisation. Other employers see no merit in this arrangement and discourage it.\r\nConsider the possible arguments for and against unpaid sabbatical leave, and reach a viewpoint of your own.",
                    Type = TypeEnum.Task2
                },
                new Test
                {
                    Id = 10,
                    Title = "Gradparents residence argument",
                    Question= "Some commentators feel that grandparents should live together with their children and grandchildren, while others say that elderly people should be encouraged to live independently.\r\nConsider the possible arguments on both sides of this debate, and reach your own conclusion.\r\n",
                    Type = TypeEnum.Task2
                }
            );
        }
    }
}
