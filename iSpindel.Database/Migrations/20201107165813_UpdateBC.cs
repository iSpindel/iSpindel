using Microsoft.EntityFrameworkCore.Migrations;

namespace iSpindel.Database.Migrations
{
    public partial class UpdateBC : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_BeerCharacteristics_DataSeriesId",
                table: "BeerCharacteristics");

            migrationBuilder.AddColumn<int>(
                name: "BeerCharacteristicsId",
                table: "DataSeries",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_DataSeries_BeerCharacteristicsId",
                table: "DataSeries",
                column: "BeerCharacteristicsId");

            migrationBuilder.CreateIndex(
                name: "IX_BeerCharacteristics_DataSeriesId",
                table: "BeerCharacteristics",
                column: "DataSeriesId");

            migrationBuilder.AddForeignKey(
                name: "FK_DataSeries_BeerCharacteristics_BeerCharacteristicsId",
                table: "DataSeries",
                column: "BeerCharacteristicsId",
                principalTable: "BeerCharacteristics",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_DataSeries_BeerCharacteristics_BeerCharacteristicsId",
                table: "DataSeries");

            migrationBuilder.DropIndex(
                name: "IX_DataSeries_BeerCharacteristicsId",
                table: "DataSeries");

            migrationBuilder.DropIndex(
                name: "IX_BeerCharacteristics_DataSeriesId",
                table: "BeerCharacteristics");

            migrationBuilder.DropColumn(
                name: "BeerCharacteristicsId",
                table: "DataSeries");

            migrationBuilder.CreateIndex(
                name: "IX_BeerCharacteristics_DataSeriesId",
                table: "BeerCharacteristics",
                column: "DataSeriesId",
                unique: true);
        }
    }
}
