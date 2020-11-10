using Microsoft.EntityFrameworkCore.Migrations;

namespace iSpindel.Database.Migrations
{
    public partial class FixBeerCharacteristics : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeerCharacteristics_DataSeries_DataSeriesId",
                table: "BeerCharacteristics");

            migrationBuilder.AlterColumn<int>(
                name: "DataSeriesId",
                table: "BeerCharacteristics",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

            migrationBuilder.UpdateData(
                table: "BeerCharacteristics",
                keyColumn: "Id",
                keyValue: -1,
                column: "Notes",
                value: @"- Should have added more Citra Hops 
- Like the fruityness");

            migrationBuilder.UpdateData(
                table: "DataSeries",
                keyColumn: "Id",
                keyValue: 1,
                column: "BeerCharacteristicsId",
                value: -1);

            migrationBuilder.AddForeignKey(
                name: "FK_BeerCharacteristics_DataSeries_DataSeriesId",
                table: "BeerCharacteristics",
                column: "DataSeriesId",
                principalTable: "DataSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BeerCharacteristics_DataSeries_DataSeriesId",
                table: "BeerCharacteristics");

            migrationBuilder.AlterColumn<int>(
                name: "DataSeriesId",
                table: "BeerCharacteristics",
                type: "integer",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "BeerCharacteristics",
                keyColumn: "Id",
                keyValue: -1,
                column: "Notes",
                value: @"- Should have added more Citra Hops 
- Like the fruityness");

            migrationBuilder.UpdateData(
                table: "DataSeries",
                keyColumn: "Id",
                keyValue: 1,
                column: "BeerCharacteristicsId",
                value: null);

            migrationBuilder.AddForeignKey(
                name: "FK_BeerCharacteristics_DataSeries_DataSeriesId",
                table: "BeerCharacteristics",
                column: "DataSeriesId",
                principalTable: "DataSeries",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
