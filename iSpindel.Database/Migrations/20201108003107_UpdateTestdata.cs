using Microsoft.EntityFrameworkCore.Migrations;

namespace iSpindel.Database.Migrations
{
    public partial class UpdateTestdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "BeerCharacteristics",
                columns: new[] { "Id", "AddedSugar", "AdjustedAlcoholLevel", "AmountOfWort", "BeerStyle", "Bitterness", "BrewhouseEfficency", "ColorScale", "DataSeriesId", "EVG", "Notes", "TargetCarbonation", "YeastType" },
                values: new object[] { -1, 12.0, 3.0, 20.0, "Lambic", 10, 55.0, 5.4000000000000004, 1, 60.0, @"- Should have added more Citra Hops 
- Like the fruityness", 5.5, "Safale K-97" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BeerCharacteristics",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
