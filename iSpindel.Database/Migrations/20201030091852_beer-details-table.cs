using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace iSpindel.Database.Migrations
{
    public partial class beerdetailstable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BeerCharacteristics",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    DataSeriesId = table.Column<int>(nullable: false),
                    EVG = table.Column<double>(nullable: true),
                    Bitterness = table.Column<int>(nullable: true),
                    ColorScale = table.Column<double>(nullable: true),
                    BrewhouseEfficency = table.Column<double>(nullable: true),
                    AmountOfWort = table.Column<double>(nullable: true),
                    TargetCarbonation = table.Column<double>(nullable: true),
                    AddedSugar = table.Column<double>(nullable: true),
                    AdjustedAlcoholLevel = table.Column<double>(nullable: true),
                    YeastType = table.Column<string>(nullable: true),
                    Notes = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BeerCharacteristics", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BeerCharacteristics_DataSeries_DataSeriesId",
                        column: x => x.DataSeriesId,
                        principalTable: "DataSeries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 11,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 14, 18, 8, 949, DateTimeKind.Local).AddTicks(7181));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 12,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 14, 38, 8, 953, DateTimeKind.Local).AddTicks(4872));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 13,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 14, 58, 8, 953, DateTimeKind.Local).AddTicks(5035));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 14,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 15, 18, 8, 953, DateTimeKind.Local).AddTicks(5045));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 15,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 15, 38, 8, 953, DateTimeKind.Local).AddTicks(5050));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 16,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 15, 58, 8, 953, DateTimeKind.Local).AddTicks(5054));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 17,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 16, 18, 8, 953, DateTimeKind.Local).AddTicks(5059));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 18,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 16, 38, 8, 953, DateTimeKind.Local).AddTicks(5078));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 19,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 16, 58, 8, 953, DateTimeKind.Local).AddTicks(5083));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 20,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 17, 18, 8, 953, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 21,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 17, 38, 8, 953, DateTimeKind.Local).AddTicks(5092));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 22,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 17, 58, 8, 953, DateTimeKind.Local).AddTicks(5096));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 23,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 18, 18, 8, 953, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 24,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 18, 38, 8, 953, DateTimeKind.Local).AddTicks(5105));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 25,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 18, 58, 8, 953, DateTimeKind.Local).AddTicks(5109));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 26,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 19, 18, 8, 953, DateTimeKind.Local).AddTicks(5113));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 27,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 19, 38, 8, 953, DateTimeKind.Local).AddTicks(5117));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 28,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 19, 58, 8, 953, DateTimeKind.Local).AddTicks(5139));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 29,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 20, 18, 8, 953, DateTimeKind.Local).AddTicks(5144));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 30,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 20, 38, 8, 953, DateTimeKind.Local).AddTicks(5148));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 31,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 20, 58, 8, 953, DateTimeKind.Local).AddTicks(6580));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 32,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 21, 18, 8, 953, DateTimeKind.Local).AddTicks(6656));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 33,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 21, 38, 8, 953, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 34,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 21, 58, 8, 953, DateTimeKind.Local).AddTicks(6674));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 35,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 22, 18, 8, 953, DateTimeKind.Local).AddTicks(6679));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 36,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 22, 38, 8, 953, DateTimeKind.Local).AddTicks(6683));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 37,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 22, 58, 8, 953, DateTimeKind.Local).AddTicks(6687));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 38,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 23, 18, 8, 953, DateTimeKind.Local).AddTicks(6691));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 39,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 23, 38, 8, 953, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 40,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 23, 58, 8, 953, DateTimeKind.Local).AddTicks(6699));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 41,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 0, 18, 8, 953, DateTimeKind.Local).AddTicks(6703));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 42,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 0, 38, 8, 953, DateTimeKind.Local).AddTicks(6707));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 43,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 0, 58, 8, 953, DateTimeKind.Local).AddTicks(6712));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 44,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 1, 18, 8, 953, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 45,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 1, 38, 8, 953, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 46,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 1, 58, 8, 953, DateTimeKind.Local).AddTicks(6724));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 47,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 2, 18, 8, 953, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 48,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 2, 38, 8, 953, DateTimeKind.Local).AddTicks(6732));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 49,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 2, 58, 8, 953, DateTimeKind.Local).AddTicks(6736));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 50,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 3, 18, 8, 953, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 51,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 3, 38, 8, 953, DateTimeKind.Local).AddTicks(6744));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 52,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 3, 58, 8, 953, DateTimeKind.Local).AddTicks(6748));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 53,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 4, 18, 8, 953, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 54,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 4, 38, 8, 953, DateTimeKind.Local).AddTicks(6756));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 55,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 4, 58, 8, 953, DateTimeKind.Local).AddTicks(6760));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 56,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 5, 18, 8, 953, DateTimeKind.Local).AddTicks(6764));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 57,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 5, 38, 8, 953, DateTimeKind.Local).AddTicks(6768));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 58,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 5, 58, 8, 953, DateTimeKind.Local).AddTicks(6772));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 59,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 6, 18, 8, 953, DateTimeKind.Local).AddTicks(6776));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 60,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 6, 38, 8, 953, DateTimeKind.Local).AddTicks(6780));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 61,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 6, 58, 8, 953, DateTimeKind.Local).AddTicks(6784));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 62,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 7, 18, 8, 953, DateTimeKind.Local).AddTicks(6788));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 63,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 7, 38, 8, 953, DateTimeKind.Local).AddTicks(6793));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 64,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 7, 58, 8, 953, DateTimeKind.Local).AddTicks(6797));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 65,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 8, 18, 8, 953, DateTimeKind.Local).AddTicks(6801));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 66,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 8, 38, 8, 953, DateTimeKind.Local).AddTicks(6807));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 67,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 8, 58, 8, 953, DateTimeKind.Local).AddTicks(6811));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 68,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 9, 18, 8, 953, DateTimeKind.Local).AddTicks(6816));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 69,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 9, 38, 8, 953, DateTimeKind.Local).AddTicks(6820));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 70,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 9, 58, 8, 953, DateTimeKind.Local).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 71,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 10, 18, 8, 953, DateTimeKind.Local).AddTicks(6828));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 72,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 10, 38, 8, 953, DateTimeKind.Local).AddTicks(6832));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 73,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 10, 58, 8, 953, DateTimeKind.Local).AddTicks(6836));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 74,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 11, 18, 8, 953, DateTimeKind.Local).AddTicks(6840));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 75,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 11, 38, 8, 953, DateTimeKind.Local).AddTicks(6844));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 76,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 11, 58, 8, 953, DateTimeKind.Local).AddTicks(6848));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 77,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 12, 18, 8, 953, DateTimeKind.Local).AddTicks(6852));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 78,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 12, 38, 8, 953, DateTimeKind.Local).AddTicks(6856));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 79,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 12, 58, 8, 953, DateTimeKind.Local).AddTicks(6860));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 80,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 13, 18, 8, 953, DateTimeKind.Local).AddTicks(6864));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 81,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 13, 38, 8, 953, DateTimeKind.Local).AddTicks(6868));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 82,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 13, 58, 8, 953, DateTimeKind.Local).AddTicks(6872));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 83,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 14, 18, 8, 953, DateTimeKind.Local).AddTicks(6876));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 84,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 14, 38, 8, 953, DateTimeKind.Local).AddTicks(6880));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 85,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 14, 58, 8, 953, DateTimeKind.Local).AddTicks(6884));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 86,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 15, 18, 8, 953, DateTimeKind.Local).AddTicks(6888));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 87,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 15, 38, 8, 953, DateTimeKind.Local).AddTicks(6892));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 88,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 15, 58, 8, 953, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 89,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 16, 18, 8, 953, DateTimeKind.Local).AddTicks(6992));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 90,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 16, 38, 8, 953, DateTimeKind.Local).AddTicks(6998));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 91,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 16, 58, 8, 953, DateTimeKind.Local).AddTicks(7002));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 92,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 17, 18, 8, 953, DateTimeKind.Local).AddTicks(7006));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 93,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 17, 38, 8, 953, DateTimeKind.Local).AddTicks(7010));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 94,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 17, 58, 8, 953, DateTimeKind.Local).AddTicks(7014));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 95,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 18, 18, 8, 953, DateTimeKind.Local).AddTicks(7018));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 96,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 18, 38, 8, 953, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 97,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 18, 58, 8, 953, DateTimeKind.Local).AddTicks(7026));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 98,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 19, 18, 8, 953, DateTimeKind.Local).AddTicks(7030));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 99,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 19, 38, 8, 953, DateTimeKind.Local).AddTicks(7034));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 100,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 19, 58, 8, 953, DateTimeKind.Local).AddTicks(7038));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 101,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 20, 18, 8, 953, DateTimeKind.Local).AddTicks(7042));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 102,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 20, 38, 8, 953, DateTimeKind.Local).AddTicks(7046));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 103,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 20, 58, 8, 953, DateTimeKind.Local).AddTicks(7050));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 104,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 21, 18, 8, 953, DateTimeKind.Local).AddTicks(7054));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 105,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 21, 38, 8, 953, DateTimeKind.Local).AddTicks(7058));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 106,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 21, 58, 8, 953, DateTimeKind.Local).AddTicks(7062));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 107,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 22, 18, 8, 953, DateTimeKind.Local).AddTicks(7066));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 108,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 22, 38, 8, 953, DateTimeKind.Local).AddTicks(7070));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 109,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 22, 58, 8, 953, DateTimeKind.Local).AddTicks(7075));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 110,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 23, 18, 8, 953, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 111,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 23, 38, 8, 953, DateTimeKind.Local).AddTicks(7083));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 112,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 23, 58, 8, 953, DateTimeKind.Local).AddTicks(7153));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 113,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 0, 18, 8, 953, DateTimeKind.Local).AddTicks(7159));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 114,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 0, 38, 8, 953, DateTimeKind.Local).AddTicks(7164));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 115,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 0, 58, 8, 953, DateTimeKind.Local).AddTicks(7169));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 116,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 1, 18, 8, 953, DateTimeKind.Local).AddTicks(7175));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 117,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 1, 38, 8, 953, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 118,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 1, 58, 8, 953, DateTimeKind.Local).AddTicks(7186));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 119,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 2, 18, 8, 953, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 120,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 2, 38, 8, 953, DateTimeKind.Local).AddTicks(7197));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 121,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 2, 58, 8, 953, DateTimeKind.Local).AddTicks(7203));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 122,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 3, 18, 8, 953, DateTimeKind.Local).AddTicks(7209));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 123,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 3, 38, 8, 953, DateTimeKind.Local).AddTicks(7215));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 124,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 3, 58, 8, 953, DateTimeKind.Local).AddTicks(7221));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 125,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 4, 18, 8, 953, DateTimeKind.Local).AddTicks(7227));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 126,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 4, 38, 8, 953, DateTimeKind.Local).AddTicks(7233));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 127,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 4, 58, 8, 953, DateTimeKind.Local).AddTicks(7238));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 128,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 5, 18, 8, 953, DateTimeKind.Local).AddTicks(7243));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 129,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 5, 38, 8, 953, DateTimeKind.Local).AddTicks(7249));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 130,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 5, 58, 8, 953, DateTimeKind.Local).AddTicks(7259));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 131,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 6, 18, 8, 953, DateTimeKind.Local).AddTicks(7266));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 132,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 6, 38, 8, 953, DateTimeKind.Local).AddTicks(7274));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 133,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 6, 58, 8, 953, DateTimeKind.Local).AddTicks(7280));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 134,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 7, 18, 8, 953, DateTimeKind.Local).AddTicks(7286));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 135,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 7, 38, 8, 953, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 136,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 7, 58, 8, 953, DateTimeKind.Local).AddTicks(7298));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 137,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 8, 18, 8, 953, DateTimeKind.Local).AddTicks(7304));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 138,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 8, 38, 8, 953, DateTimeKind.Local).AddTicks(7310));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 139,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 8, 58, 8, 953, DateTimeKind.Local).AddTicks(7317));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 140,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 9, 18, 8, 953, DateTimeKind.Local).AddTicks(7386));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 141,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 9, 38, 8, 953, DateTimeKind.Local).AddTicks(7392));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 142,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 9, 58, 8, 953, DateTimeKind.Local).AddTicks(7399));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 143,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 10, 18, 8, 953, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 144,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 10, 38, 8, 953, DateTimeKind.Local).AddTicks(7411));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 145,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 10, 58, 8, 953, DateTimeKind.Local).AddTicks(7417));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 146,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 11, 18, 8, 953, DateTimeKind.Local).AddTicks(7425));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 147,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 11, 38, 8, 953, DateTimeKind.Local).AddTicks(7429));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 148,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 11, 58, 8, 953, DateTimeKind.Local).AddTicks(7433));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 149,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 12, 18, 8, 953, DateTimeKind.Local).AddTicks(7437));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 150,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 12, 38, 8, 953, DateTimeKind.Local).AddTicks(7441));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 151,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 12, 58, 8, 953, DateTimeKind.Local).AddTicks(7445));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 152,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 13, 18, 8, 953, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 153,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 13, 38, 8, 953, DateTimeKind.Local).AddTicks(7454));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 154,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 13, 58, 8, 953, DateTimeKind.Local).AddTicks(7458));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 155,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 14, 18, 8, 953, DateTimeKind.Local).AddTicks(7462));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 156,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 14, 38, 8, 953, DateTimeKind.Local).AddTicks(7466));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 157,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 14, 58, 8, 953, DateTimeKind.Local).AddTicks(7471));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 158,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 15, 18, 8, 953, DateTimeKind.Local).AddTicks(7475));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 159,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 15, 38, 8, 953, DateTimeKind.Local).AddTicks(7479));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 160,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 15, 58, 8, 953, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 161,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 16, 18, 8, 953, DateTimeKind.Local).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 162,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 16, 38, 8, 953, DateTimeKind.Local).AddTicks(7492));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 163,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 16, 58, 8, 953, DateTimeKind.Local).AddTicks(7496));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 164,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 17, 18, 8, 953, DateTimeKind.Local).AddTicks(7500));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 165,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 17, 38, 8, 953, DateTimeKind.Local).AddTicks(7504));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 166,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 17, 58, 8, 953, DateTimeKind.Local).AddTicks(7508));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 167,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 18, 18, 8, 953, DateTimeKind.Local).AddTicks(7512));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 168,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 18, 38, 8, 953, DateTimeKind.Local).AddTicks(7516));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 169,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 18, 58, 8, 953, DateTimeKind.Local).AddTicks(7520));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 170,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 19, 18, 8, 953, DateTimeKind.Local).AddTicks(7524));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 171,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 19, 38, 8, 953, DateTimeKind.Local).AddTicks(7529));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 172,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 19, 58, 8, 953, DateTimeKind.Local).AddTicks(7533));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 173,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 20, 18, 8, 953, DateTimeKind.Local).AddTicks(7537));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 174,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 20, 38, 8, 953, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 175,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 20, 58, 8, 953, DateTimeKind.Local).AddTicks(7600));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 176,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 21, 18, 8, 953, DateTimeKind.Local).AddTicks(7604));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 177,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 21, 38, 8, 953, DateTimeKind.Local).AddTicks(7608));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 178,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 21, 58, 8, 953, DateTimeKind.Local).AddTicks(7612));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 179,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 22, 18, 8, 953, DateTimeKind.Local).AddTicks(7616));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 180,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 22, 38, 8, 953, DateTimeKind.Local).AddTicks(7620));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 181,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 22, 58, 8, 953, DateTimeKind.Local).AddTicks(7624));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 182,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 23, 18, 8, 953, DateTimeKind.Local).AddTicks(7628));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 183,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 23, 38, 8, 953, DateTimeKind.Local).AddTicks(7633));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 184,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 23, 58, 8, 953, DateTimeKind.Local).AddTicks(7637));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 185,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 0, 18, 8, 953, DateTimeKind.Local).AddTicks(7641));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 186,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 0, 38, 8, 953, DateTimeKind.Local).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 187,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 0, 58, 8, 953, DateTimeKind.Local).AddTicks(7649));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 188,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 1, 18, 8, 953, DateTimeKind.Local).AddTicks(7653));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 189,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 1, 38, 8, 953, DateTimeKind.Local).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 190,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 1, 58, 8, 953, DateTimeKind.Local).AddTicks(7662));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 191,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 2, 18, 8, 953, DateTimeKind.Local).AddTicks(7666));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 192,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 2, 38, 8, 953, DateTimeKind.Local).AddTicks(7670));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 193,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 2, 58, 8, 953, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 194,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 3, 18, 8, 953, DateTimeKind.Local).AddTicks(7678));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 195,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 3, 38, 8, 953, DateTimeKind.Local).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 196,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 3, 58, 8, 953, DateTimeKind.Local).AddTicks(7686));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 197,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 4, 18, 8, 953, DateTimeKind.Local).AddTicks(7690));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 198,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 4, 38, 8, 953, DateTimeKind.Local).AddTicks(7695));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 199,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 4, 58, 8, 953, DateTimeKind.Local).AddTicks(7699));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 200,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 5, 18, 8, 953, DateTimeKind.Local).AddTicks(7703));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 201,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 5, 38, 8, 953, DateTimeKind.Local).AddTicks(7707));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 202,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 5, 58, 8, 953, DateTimeKind.Local).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 203,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 6, 18, 8, 953, DateTimeKind.Local).AddTicks(7715));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 204,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 6, 38, 8, 953, DateTimeKind.Local).AddTicks(7720));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 205,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 6, 58, 8, 953, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 206,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 7, 18, 8, 953, DateTimeKind.Local).AddTicks(7728));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 207,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 7, 38, 8, 953, DateTimeKind.Local).AddTicks(7732));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 208,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 7, 58, 8, 953, DateTimeKind.Local).AddTicks(7736));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 209,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 8, 18, 8, 953, DateTimeKind.Local).AddTicks(7740));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 210,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 8, 38, 8, 953, DateTimeKind.Local).AddTicks(7744));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 211,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 8, 58, 8, 953, DateTimeKind.Local).AddTicks(7748));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 212,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 9, 18, 8, 953, DateTimeKind.Local).AddTicks(7752));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 213,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 9, 38, 8, 953, DateTimeKind.Local).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 214,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 9, 58, 8, 953, DateTimeKind.Local).AddTicks(7760));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 215,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 10, 18, 8, 953, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 216,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 10, 38, 8, 953, DateTimeKind.Local).AddTicks(7769));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 217,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 10, 58, 8, 953, DateTimeKind.Local).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 218,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 11, 18, 8, 953, DateTimeKind.Local).AddTicks(7777));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 219,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 11, 38, 8, 953, DateTimeKind.Local).AddTicks(7781));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 220,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 11, 58, 8, 953, DateTimeKind.Local).AddTicks(7785));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 221,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 12, 18, 8, 953, DateTimeKind.Local).AddTicks(7789));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 222,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 12, 38, 8, 953, DateTimeKind.Local).AddTicks(7793));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 223,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 12, 58, 8, 953, DateTimeKind.Local).AddTicks(7797));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 224,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 13, 18, 8, 953, DateTimeKind.Local).AddTicks(7801));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 225,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 13, 38, 8, 953, DateTimeKind.Local).AddTicks(7806));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 226,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 13, 58, 8, 953, DateTimeKind.Local).AddTicks(7810));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 227,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 14, 18, 8, 953, DateTimeKind.Local).AddTicks(7814));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 228,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 14, 38, 8, 953, DateTimeKind.Local).AddTicks(7818));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 229,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 14, 58, 8, 953, DateTimeKind.Local).AddTicks(7822));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 230,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 15, 18, 8, 953, DateTimeKind.Local).AddTicks(7826));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 231,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 15, 38, 8, 953, DateTimeKind.Local).AddTicks(7830));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 232,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 15, 58, 8, 953, DateTimeKind.Local).AddTicks(7834));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 233,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 16, 18, 8, 953, DateTimeKind.Local).AddTicks(7838));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 234,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 16, 38, 8, 953, DateTimeKind.Local).AddTicks(7842));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 235,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 16, 58, 8, 953, DateTimeKind.Local).AddTicks(7847));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 236,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 17, 18, 8, 953, DateTimeKind.Local).AddTicks(7851));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 237,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 17, 38, 8, 953, DateTimeKind.Local).AddTicks(7855));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 238,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 17, 58, 8, 953, DateTimeKind.Local).AddTicks(7859));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 239,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 18, 18, 8, 953, DateTimeKind.Local).AddTicks(7863));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 240,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 18, 38, 8, 953, DateTimeKind.Local).AddTicks(7867));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 241,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 18, 58, 8, 953, DateTimeKind.Local).AddTicks(7871));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 242,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 19, 18, 8, 953, DateTimeKind.Local).AddTicks(7875));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 243,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 19, 38, 8, 953, DateTimeKind.Local).AddTicks(7879));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 244,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 19, 58, 8, 953, DateTimeKind.Local).AddTicks(7883));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 245,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 20, 18, 8, 953, DateTimeKind.Local).AddTicks(7888));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 246,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 20, 38, 8, 953, DateTimeKind.Local).AddTicks(7892));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 247,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 20, 58, 8, 953, DateTimeKind.Local).AddTicks(7896));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 248,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 21, 18, 8, 953, DateTimeKind.Local).AddTicks(7900));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 249,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 21, 38, 8, 953, DateTimeKind.Local).AddTicks(7904));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 250,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 21, 58, 8, 953, DateTimeKind.Local).AddTicks(7908));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 251,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 22, 18, 8, 953, DateTimeKind.Local).AddTicks(7912));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 252,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 22, 38, 8, 953, DateTimeKind.Local).AddTicks(7916));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 253,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 22, 58, 8, 953, DateTimeKind.Local).AddTicks(7920));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 254,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 23, 18, 8, 953, DateTimeKind.Local).AddTicks(7925));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 255,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 23, 38, 8, 953, DateTimeKind.Local).AddTicks(7929));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 256,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 23, 58, 8, 953, DateTimeKind.Local).AddTicks(7933));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 257,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 0, 18, 8, 953, DateTimeKind.Local).AddTicks(7937));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 258,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 0, 38, 8, 953, DateTimeKind.Local).AddTicks(8030));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 259,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 0, 58, 8, 953, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 260,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 1, 18, 8, 953, DateTimeKind.Local).AddTicks(8039));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 261,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 1, 38, 8, 953, DateTimeKind.Local).AddTicks(8043));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 262,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 1, 58, 8, 953, DateTimeKind.Local).AddTicks(8048));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 263,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 2, 18, 8, 953, DateTimeKind.Local).AddTicks(8052));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 264,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 2, 38, 8, 953, DateTimeKind.Local).AddTicks(8056));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 265,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 2, 58, 8, 953, DateTimeKind.Local).AddTicks(8060));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 266,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 3, 18, 8, 953, DateTimeKind.Local).AddTicks(8064));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 267,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 3, 38, 8, 953, DateTimeKind.Local).AddTicks(8068));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 268,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 3, 58, 8, 953, DateTimeKind.Local).AddTicks(8072));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 269,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 4, 18, 8, 953, DateTimeKind.Local).AddTicks(8076));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 270,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 4, 38, 8, 953, DateTimeKind.Local).AddTicks(8080));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 271,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 4, 58, 8, 953, DateTimeKind.Local).AddTicks(8084));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 272,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 5, 18, 8, 953, DateTimeKind.Local).AddTicks(8089));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 273,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 5, 38, 8, 953, DateTimeKind.Local).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 274,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 5, 58, 8, 953, DateTimeKind.Local).AddTicks(8097));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 275,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 6, 18, 8, 953, DateTimeKind.Local).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 276,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 6, 38, 8, 953, DateTimeKind.Local).AddTicks(8105));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 277,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 6, 58, 8, 953, DateTimeKind.Local).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 278,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 7, 18, 8, 953, DateTimeKind.Local).AddTicks(8113));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 279,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 7, 38, 8, 953, DateTimeKind.Local).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 280,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 7, 58, 8, 953, DateTimeKind.Local).AddTicks(8122));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 281,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 8, 18, 8, 953, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 282,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 8, 38, 8, 953, DateTimeKind.Local).AddTicks(8130));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 283,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 8, 58, 8, 953, DateTimeKind.Local).AddTicks(8134));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 284,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 9, 18, 8, 953, DateTimeKind.Local).AddTicks(8138));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 285,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 9, 38, 8, 953, DateTimeKind.Local).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 286,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 9, 58, 8, 953, DateTimeKind.Local).AddTicks(8146));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 287,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 10, 18, 8, 953, DateTimeKind.Local).AddTicks(8150));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 288,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 10, 38, 8, 953, DateTimeKind.Local).AddTicks(8155));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 289,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 10, 58, 8, 953, DateTimeKind.Local).AddTicks(8159));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 290,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 11, 18, 8, 953, DateTimeKind.Local).AddTicks(8163));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 291,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 11, 38, 8, 953, DateTimeKind.Local).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 292,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 11, 58, 8, 953, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 293,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 12, 18, 8, 953, DateTimeKind.Local).AddTicks(8175));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 294,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 12, 38, 8, 953, DateTimeKind.Local).AddTicks(8179));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 295,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 12, 58, 8, 953, DateTimeKind.Local).AddTicks(8183));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 296,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 13, 18, 8, 953, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 297,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 13, 38, 8, 953, DateTimeKind.Local).AddTicks(8192));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 298,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 13, 58, 8, 953, DateTimeKind.Local).AddTicks(8196));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 299,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 14, 18, 8, 953, DateTimeKind.Local).AddTicks(8200));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 300,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 14, 38, 8, 953, DateTimeKind.Local).AddTicks(8204));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 301,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 14, 58, 8, 953, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 302,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 15, 18, 8, 953, DateTimeKind.Local).AddTicks(8212));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 303,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 15, 38, 8, 953, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 304,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 15, 58, 8, 953, DateTimeKind.Local).AddTicks(8221));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 305,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 16, 18, 8, 953, DateTimeKind.Local).AddTicks(8225));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 306,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 16, 38, 8, 953, DateTimeKind.Local).AddTicks(8229));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 307,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 16, 58, 8, 953, DateTimeKind.Local).AddTicks(8233));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 308,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 17, 18, 8, 953, DateTimeKind.Local).AddTicks(8237));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 309,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 17, 38, 8, 953, DateTimeKind.Local).AddTicks(8241));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 310,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 17, 58, 8, 953, DateTimeKind.Local).AddTicks(8246));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 311,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 18, 18, 8, 953, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 312,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 18, 38, 8, 953, DateTimeKind.Local).AddTicks(8254));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 313,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 18, 58, 8, 953, DateTimeKind.Local).AddTicks(8258));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 314,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 19, 18, 8, 953, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 315,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 19, 38, 8, 953, DateTimeKind.Local).AddTicks(8266));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 316,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 19, 58, 8, 953, DateTimeKind.Local).AddTicks(8270));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 317,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 20, 18, 8, 953, DateTimeKind.Local).AddTicks(8274));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 318,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 20, 38, 8, 953, DateTimeKind.Local).AddTicks(8278));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 319,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 20, 58, 8, 953, DateTimeKind.Local).AddTicks(8282));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 320,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 21, 18, 8, 953, DateTimeKind.Local).AddTicks(8286));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 321,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 21, 38, 8, 953, DateTimeKind.Local).AddTicks(8291));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 322,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 21, 58, 8, 953, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 323,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 22, 18, 8, 953, DateTimeKind.Local).AddTicks(8299));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 324,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 22, 38, 8, 953, DateTimeKind.Local).AddTicks(8303));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 325,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 22, 58, 8, 953, DateTimeKind.Local).AddTicks(8307));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 326,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 23, 18, 8, 953, DateTimeKind.Local).AddTicks(8311));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 327,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 23, 38, 8, 953, DateTimeKind.Local).AddTicks(8315));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 328,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 23, 58, 8, 953, DateTimeKind.Local).AddTicks(8319));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 329,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 0, 18, 8, 953, DateTimeKind.Local).AddTicks(8323));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 330,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 0, 38, 8, 953, DateTimeKind.Local).AddTicks(8327));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 331,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 0, 58, 8, 953, DateTimeKind.Local).AddTicks(8332));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 332,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 1, 18, 8, 953, DateTimeKind.Local).AddTicks(8336));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 333,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 1, 38, 8, 953, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 334,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 1, 58, 8, 953, DateTimeKind.Local).AddTicks(8344));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 335,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 2, 18, 8, 953, DateTimeKind.Local).AddTicks(8348));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 336,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 2, 38, 8, 953, DateTimeKind.Local).AddTicks(8352));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 337,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 2, 58, 8, 953, DateTimeKind.Local).AddTicks(8357));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 338,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 3, 18, 8, 953, DateTimeKind.Local).AddTicks(8361));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 339,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 3, 38, 8, 953, DateTimeKind.Local).AddTicks(8365));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 340,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 3, 58, 8, 953, DateTimeKind.Local).AddTicks(8369));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 341,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 4, 18, 8, 953, DateTimeKind.Local).AddTicks(8373));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 342,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 4, 38, 8, 953, DateTimeKind.Local).AddTicks(8377));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 343,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 4, 58, 8, 953, DateTimeKind.Local).AddTicks(8381));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 344,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 5, 18, 8, 953, DateTimeKind.Local).AddTicks(8449));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 345,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 5, 38, 8, 953, DateTimeKind.Local).AddTicks(8454));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 346,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 5, 58, 8, 953, DateTimeKind.Local).AddTicks(8458));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 347,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 6, 18, 8, 953, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 348,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 6, 38, 8, 953, DateTimeKind.Local).AddTicks(8466));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 349,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 6, 58, 8, 953, DateTimeKind.Local).AddTicks(8471));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 350,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 7, 18, 8, 953, DateTimeKind.Local).AddTicks(8475));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 351,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 7, 38, 8, 953, DateTimeKind.Local).AddTicks(8479));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 352,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 7, 58, 8, 953, DateTimeKind.Local).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 353,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 8, 18, 8, 953, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 354,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 8, 38, 8, 953, DateTimeKind.Local).AddTicks(8491));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 355,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 8, 58, 8, 953, DateTimeKind.Local).AddTicks(8495));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 356,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 9, 18, 8, 953, DateTimeKind.Local).AddTicks(8500));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 357,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 9, 38, 8, 953, DateTimeKind.Local).AddTicks(8504));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 358,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 9, 58, 8, 953, DateTimeKind.Local).AddTicks(8508));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 359,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 10, 18, 8, 953, DateTimeKind.Local).AddTicks(8512));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 360,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 10, 38, 8, 953, DateTimeKind.Local).AddTicks(8516));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 361,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 10, 58, 8, 953, DateTimeKind.Local).AddTicks(8520));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 362,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 11, 18, 8, 953, DateTimeKind.Local).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 363,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 11, 38, 8, 953, DateTimeKind.Local).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 364,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 11, 58, 8, 953, DateTimeKind.Local).AddTicks(8533));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 365,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 12, 18, 8, 953, DateTimeKind.Local).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 366,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 12, 38, 8, 953, DateTimeKind.Local).AddTicks(8541));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 367,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 12, 58, 8, 953, DateTimeKind.Local).AddTicks(8545));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 368,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 13, 18, 8, 953, DateTimeKind.Local).AddTicks(8550));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 369,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 13, 38, 8, 953, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 370,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 13, 58, 8, 953, DateTimeKind.Local).AddTicks(8558));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 371,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 14, 18, 8, 953, DateTimeKind.Local).AddTicks(8562));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 372,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 14, 38, 8, 953, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 373,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 14, 58, 8, 953, DateTimeKind.Local).AddTicks(8570));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 374,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 15, 18, 8, 953, DateTimeKind.Local).AddTicks(8574));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 375,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 15, 38, 8, 953, DateTimeKind.Local).AddTicks(8578));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 376,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 15, 58, 8, 953, DateTimeKind.Local).AddTicks(8583));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 377,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 16, 18, 8, 953, DateTimeKind.Local).AddTicks(8587));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 378,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 16, 38, 8, 953, DateTimeKind.Local).AddTicks(8591));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 379,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 16, 58, 8, 953, DateTimeKind.Local).AddTicks(8595));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 380,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 17, 18, 8, 953, DateTimeKind.Local).AddTicks(8599));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 381,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 17, 38, 8, 953, DateTimeKind.Local).AddTicks(8603));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 382,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 17, 58, 8, 953, DateTimeKind.Local).AddTicks(8608));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 383,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 18, 18, 8, 953, DateTimeKind.Local).AddTicks(8612));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 384,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 18, 38, 8, 953, DateTimeKind.Local).AddTicks(8616));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 385,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 18, 58, 8, 953, DateTimeKind.Local).AddTicks(8620));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 386,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 19, 18, 8, 953, DateTimeKind.Local).AddTicks(8624));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 387,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 19, 38, 8, 953, DateTimeKind.Local).AddTicks(8628));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 388,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 19, 58, 8, 953, DateTimeKind.Local).AddTicks(8633));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 389,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 20, 18, 8, 953, DateTimeKind.Local).AddTicks(8637));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 390,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 20, 38, 8, 953, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 391,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 20, 58, 8, 953, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 392,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 21, 18, 8, 953, DateTimeKind.Local).AddTicks(8649));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 393,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 21, 38, 8, 953, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 394,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 21, 58, 8, 953, DateTimeKind.Local).AddTicks(8657));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 395,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 22, 18, 8, 953, DateTimeKind.Local).AddTicks(8661));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 396,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 22, 38, 8, 953, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 397,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 22, 58, 8, 953, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 398,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 23, 18, 8, 953, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 399,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 23, 38, 8, 953, DateTimeKind.Local).AddTicks(8678));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 400,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 23, 58, 8, 953, DateTimeKind.Local).AddTicks(8682));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 401,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 0, 18, 8, 953, DateTimeKind.Local).AddTicks(8687));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 402,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 0, 38, 8, 953, DateTimeKind.Local).AddTicks(8691));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 403,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 0, 58, 8, 953, DateTimeKind.Local).AddTicks(8695));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 404,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 1, 18, 8, 953, DateTimeKind.Local).AddTicks(8699));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 405,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 1, 38, 8, 953, DateTimeKind.Local).AddTicks(8703));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 406,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 1, 58, 8, 953, DateTimeKind.Local).AddTicks(8707));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 407,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 2, 18, 8, 953, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 408,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 2, 38, 8, 953, DateTimeKind.Local).AddTicks(8716));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 409,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 2, 58, 8, 953, DateTimeKind.Local).AddTicks(8720));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 410,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 3, 18, 8, 953, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 411,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 3, 38, 8, 953, DateTimeKind.Local).AddTicks(8728));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 412,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 3, 58, 8, 953, DateTimeKind.Local).AddTicks(8732));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 413,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 4, 18, 8, 953, DateTimeKind.Local).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 414,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 4, 38, 8, 953, DateTimeKind.Local).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 415,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 4, 58, 8, 953, DateTimeKind.Local).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 416,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 5, 18, 8, 953, DateTimeKind.Local).AddTicks(8749));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 417,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 5, 38, 8, 953, DateTimeKind.Local).AddTicks(8753));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 418,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 5, 58, 8, 953, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 419,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 6, 18, 8, 953, DateTimeKind.Local).AddTicks(8761));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 420,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 6, 38, 8, 953, DateTimeKind.Local).AddTicks(8765));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 421,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 6, 58, 8, 953, DateTimeKind.Local).AddTicks(8770));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 422,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 7, 18, 8, 953, DateTimeKind.Local).AddTicks(8774));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 423,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 7, 38, 8, 953, DateTimeKind.Local).AddTicks(8778));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 424,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 7, 58, 8, 953, DateTimeKind.Local).AddTicks(8782));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 425,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 8, 18, 8, 953, DateTimeKind.Local).AddTicks(8786));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 426,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 8, 38, 8, 953, DateTimeKind.Local).AddTicks(8790));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 427,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 8, 58, 8, 953, DateTimeKind.Local).AddTicks(8795));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 428,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 9, 18, 8, 953, DateTimeKind.Local).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 429,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 9, 38, 8, 953, DateTimeKind.Local).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 430,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 9, 58, 8, 953, DateTimeKind.Local).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 431,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 10, 18, 8, 953, DateTimeKind.Local).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 432,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 10, 38, 8, 953, DateTimeKind.Local).AddTicks(8815));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 433,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 10, 58, 8, 953, DateTimeKind.Local).AddTicks(8819));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 434,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 11, 18, 8, 953, DateTimeKind.Local).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 435,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 11, 38, 8, 953, DateTimeKind.Local).AddTicks(8828));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 436,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 11, 58, 8, 953, DateTimeKind.Local).AddTicks(8832));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 437,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 12, 18, 8, 953, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 438,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 12, 38, 8, 953, DateTimeKind.Local).AddTicks(8840));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 439,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 12, 58, 8, 953, DateTimeKind.Local).AddTicks(8844));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 440,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 13, 18, 8, 953, DateTimeKind.Local).AddTicks(8848));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 441,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 13, 38, 8, 953, DateTimeKind.Local).AddTicks(8852));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 442,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 13, 58, 8, 953, DateTimeKind.Local).AddTicks(8856));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 443,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 14, 18, 8, 953, DateTimeKind.Local).AddTicks(8861));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 444,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 14, 38, 8, 953, DateTimeKind.Local).AddTicks(8865));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 445,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 14, 58, 8, 953, DateTimeKind.Local).AddTicks(8869));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 446,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 15, 18, 8, 953, DateTimeKind.Local).AddTicks(8873));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 447,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 15, 38, 8, 953, DateTimeKind.Local).AddTicks(8877));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 448,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 15, 58, 8, 953, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 449,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 16, 18, 8, 953, DateTimeKind.Local).AddTicks(8886));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 450,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 16, 38, 8, 953, DateTimeKind.Local).AddTicks(8890));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 451,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 16, 58, 8, 953, DateTimeKind.Local).AddTicks(8894));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 452,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 17, 18, 8, 953, DateTimeKind.Local).AddTicks(8898));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 453,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 17, 38, 8, 953, DateTimeKind.Local).AddTicks(8902));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 454,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 17, 58, 8, 953, DateTimeKind.Local).AddTicks(8906));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 455,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 18, 18, 8, 953, DateTimeKind.Local).AddTicks(8910));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 456,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 18, 38, 8, 953, DateTimeKind.Local).AddTicks(8915));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 457,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 18, 58, 8, 953, DateTimeKind.Local).AddTicks(8966));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 458,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 19, 18, 8, 953, DateTimeKind.Local).AddTicks(8971));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 459,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 19, 38, 8, 953, DateTimeKind.Local).AddTicks(8975));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 460,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 19, 58, 8, 953, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 461,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 20, 18, 8, 953, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 462,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 20, 38, 8, 953, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 463,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 20, 58, 8, 953, DateTimeKind.Local).AddTicks(8992));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 464,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 21, 18, 8, 953, DateTimeKind.Local).AddTicks(8996));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 465,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 21, 38, 8, 953, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 466,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 21, 58, 8, 953, DateTimeKind.Local).AddTicks(9004));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 467,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 22, 18, 8, 953, DateTimeKind.Local).AddTicks(9009));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 468,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 22, 38, 8, 953, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 469,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 22, 58, 8, 953, DateTimeKind.Local).AddTicks(9017));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 470,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 23, 18, 8, 953, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 471,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 23, 38, 8, 953, DateTimeKind.Local).AddTicks(9025));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 472,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 23, 58, 8, 953, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 473,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 0, 18, 8, 953, DateTimeKind.Local).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 474,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 0, 38, 8, 953, DateTimeKind.Local).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 475,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 0, 58, 8, 953, DateTimeKind.Local).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 476,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 1, 18, 8, 953, DateTimeKind.Local).AddTicks(9046));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 477,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 1, 38, 8, 953, DateTimeKind.Local).AddTicks(9050));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 478,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 1, 58, 8, 953, DateTimeKind.Local).AddTicks(9054));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 479,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 2, 18, 8, 953, DateTimeKind.Local).AddTicks(9058));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 480,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 2, 38, 8, 953, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 481,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 2, 58, 8, 953, DateTimeKind.Local).AddTicks(9067));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 482,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 3, 18, 8, 953, DateTimeKind.Local).AddTicks(9071));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 483,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 3, 38, 8, 953, DateTimeKind.Local).AddTicks(9075));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 484,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 3, 58, 8, 953, DateTimeKind.Local).AddTicks(9079));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 485,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 4, 18, 8, 953, DateTimeKind.Local).AddTicks(9083));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 486,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 4, 38, 8, 953, DateTimeKind.Local).AddTicks(9088));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 487,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 4, 58, 8, 953, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 488,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 5, 18, 8, 953, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 489,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 5, 38, 8, 953, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 490,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 5, 58, 8, 953, DateTimeKind.Local).AddTicks(9104));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 491,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 6, 18, 8, 953, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 492,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 6, 38, 8, 953, DateTimeKind.Local).AddTicks(9112));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 493,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 6, 58, 8, 953, DateTimeKind.Local).AddTicks(9116));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 494,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 7, 18, 8, 953, DateTimeKind.Local).AddTicks(9121));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 495,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 7, 38, 8, 953, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 496,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 7, 58, 8, 953, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 497,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 8, 18, 8, 953, DateTimeKind.Local).AddTicks(9133));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 498,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 8, 38, 8, 953, DateTimeKind.Local).AddTicks(9138));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 499,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 8, 58, 8, 953, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 500,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 9, 18, 8, 953, DateTimeKind.Local).AddTicks(9146));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 501,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 9, 38, 8, 953, DateTimeKind.Local).AddTicks(9150));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 502,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 9, 58, 8, 953, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 503,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 10, 18, 8, 953, DateTimeKind.Local).AddTicks(9158));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 504,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 10, 38, 8, 953, DateTimeKind.Local).AddTicks(9163));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 505,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 10, 58, 8, 953, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 506,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 11, 18, 8, 953, DateTimeKind.Local).AddTicks(9171));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 507,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 11, 38, 8, 953, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 508,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 11, 58, 8, 953, DateTimeKind.Local).AddTicks(9179));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 509,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 12, 18, 8, 953, DateTimeKind.Local).AddTicks(9183));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 510,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 12, 38, 8, 953, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 511,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 12, 58, 8, 953, DateTimeKind.Local).AddTicks(9192));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 512,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 13, 18, 8, 953, DateTimeKind.Local).AddTicks(9196));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 513,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 13, 38, 8, 953, DateTimeKind.Local).AddTicks(9200));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 514,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 13, 58, 8, 953, DateTimeKind.Local).AddTicks(9275));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 515,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 14, 18, 8, 953, DateTimeKind.Local).AddTicks(9280));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 516,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 14, 38, 8, 953, DateTimeKind.Local).AddTicks(9285));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 517,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 14, 58, 8, 953, DateTimeKind.Local).AddTicks(9289));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 518,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 15, 18, 8, 953, DateTimeKind.Local).AddTicks(9293));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 519,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 15, 38, 8, 953, DateTimeKind.Local).AddTicks(9297));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 520,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 15, 58, 8, 953, DateTimeKind.Local).AddTicks(9302));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 521,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 16, 18, 8, 953, DateTimeKind.Local).AddTicks(9306));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 522,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 16, 38, 8, 953, DateTimeKind.Local).AddTicks(9310));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 523,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 16, 58, 8, 953, DateTimeKind.Local).AddTicks(9314));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 524,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 17, 18, 8, 953, DateTimeKind.Local).AddTicks(9319));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 525,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 17, 38, 8, 953, DateTimeKind.Local).AddTicks(9323));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 526,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 17, 58, 8, 953, DateTimeKind.Local).AddTicks(9327));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 527,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 18, 18, 8, 953, DateTimeKind.Local).AddTicks(9331));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 528,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 18, 38, 8, 953, DateTimeKind.Local).AddTicks(9335));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 529,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 18, 58, 8, 953, DateTimeKind.Local).AddTicks(9339));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 530,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 19, 18, 8, 953, DateTimeKind.Local).AddTicks(9343));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 531,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 19, 38, 8, 953, DateTimeKind.Local).AddTicks(9348));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 532,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 19, 58, 8, 953, DateTimeKind.Local).AddTicks(9352));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 533,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 20, 18, 8, 953, DateTimeKind.Local).AddTicks(9356));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 534,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 20, 38, 8, 953, DateTimeKind.Local).AddTicks(9360));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 535,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 20, 58, 8, 953, DateTimeKind.Local).AddTicks(9364));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 536,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 21, 18, 8, 953, DateTimeKind.Local).AddTicks(9368));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 537,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 21, 38, 8, 953, DateTimeKind.Local).AddTicks(9372));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 538,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 21, 58, 8, 953, DateTimeKind.Local).AddTicks(9377));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 539,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 22, 18, 8, 953, DateTimeKind.Local).AddTicks(9381));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 540,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 22, 38, 8, 953, DateTimeKind.Local).AddTicks(9385));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 541,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 22, 58, 8, 953, DateTimeKind.Local).AddTicks(9389));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 542,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 23, 18, 8, 953, DateTimeKind.Local).AddTicks(9393));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 543,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 23, 38, 8, 953, DateTimeKind.Local).AddTicks(9397));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 544,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 23, 58, 8, 953, DateTimeKind.Local).AddTicks(9401));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 545,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 0, 18, 8, 953, DateTimeKind.Local).AddTicks(9405));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 546,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 0, 38, 8, 953, DateTimeKind.Local).AddTicks(9410));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 547,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 0, 58, 8, 953, DateTimeKind.Local).AddTicks(9414));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 548,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 1, 18, 8, 953, DateTimeKind.Local).AddTicks(9418));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 549,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 1, 38, 8, 953, DateTimeKind.Local).AddTicks(9422));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 550,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 1, 58, 8, 953, DateTimeKind.Local).AddTicks(9426));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 551,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 2, 18, 8, 953, DateTimeKind.Local).AddTicks(9430));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 552,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 2, 38, 8, 953, DateTimeKind.Local).AddTicks(9434));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 553,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 2, 58, 8, 953, DateTimeKind.Local).AddTicks(9438));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 554,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 3, 18, 8, 953, DateTimeKind.Local).AddTicks(9442));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 555,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 3, 38, 8, 953, DateTimeKind.Local).AddTicks(9446));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 556,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 3, 58, 8, 953, DateTimeKind.Local).AddTicks(9450));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 557,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 4, 18, 8, 953, DateTimeKind.Local).AddTicks(9454));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 558,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 4, 38, 8, 953, DateTimeKind.Local).AddTicks(9459));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 559,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 4, 58, 8, 953, DateTimeKind.Local).AddTicks(9463));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 560,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 5, 18, 8, 953, DateTimeKind.Local).AddTicks(9467));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 561,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 5, 38, 8, 953, DateTimeKind.Local).AddTicks(9471));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 562,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 5, 58, 8, 953, DateTimeKind.Local).AddTicks(9475));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 563,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 6, 18, 8, 953, DateTimeKind.Local).AddTicks(9479));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 564,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 6, 38, 8, 953, DateTimeKind.Local).AddTicks(9483));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 565,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 6, 58, 8, 953, DateTimeKind.Local).AddTicks(9487));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 566,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 7, 18, 8, 953, DateTimeKind.Local).AddTicks(9491));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 567,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 7, 38, 8, 953, DateTimeKind.Local).AddTicks(9496));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 568,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 7, 58, 8, 953, DateTimeKind.Local).AddTicks(9500));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 569,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 8, 18, 8, 953, DateTimeKind.Local).AddTicks(9504));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 570,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 8, 38, 8, 953, DateTimeKind.Local).AddTicks(9508));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 571,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 8, 58, 8, 953, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 572,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 9, 18, 8, 953, DateTimeKind.Local).AddTicks(9546));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 573,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 9, 38, 8, 953, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 574,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 9, 58, 8, 953, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 575,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 10, 18, 8, 953, DateTimeKind.Local).AddTicks(9559));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 576,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 10, 38, 8, 953, DateTimeKind.Local).AddTicks(9563));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 577,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 10, 58, 8, 953, DateTimeKind.Local).AddTicks(9567));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 578,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 11, 18, 8, 953, DateTimeKind.Local).AddTicks(9572));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 579,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 11, 38, 8, 953, DateTimeKind.Local).AddTicks(9576));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 580,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 11, 58, 8, 953, DateTimeKind.Local).AddTicks(9580));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 581,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 12, 18, 8, 953, DateTimeKind.Local).AddTicks(9584));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 582,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 12, 38, 8, 953, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 583,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 12, 58, 8, 953, DateTimeKind.Local).AddTicks(9592));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 584,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 13, 18, 8, 953, DateTimeKind.Local).AddTicks(9596));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 585,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 13, 38, 8, 953, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 586,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 13, 58, 8, 953, DateTimeKind.Local).AddTicks(9604));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 587,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 14, 18, 8, 953, DateTimeKind.Local).AddTicks(9608));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 588,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 14, 38, 8, 953, DateTimeKind.Local).AddTicks(9613));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 589,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 14, 58, 8, 953, DateTimeKind.Local).AddTicks(9617));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 590,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 15, 18, 8, 953, DateTimeKind.Local).AddTicks(9621));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 591,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 15, 38, 8, 953, DateTimeKind.Local).AddTicks(9625));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 592,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 15, 58, 8, 953, DateTimeKind.Local).AddTicks(9629));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 593,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 16, 18, 8, 953, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 594,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 16, 38, 8, 953, DateTimeKind.Local).AddTicks(9637));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 595,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 16, 58, 8, 953, DateTimeKind.Local).AddTicks(9641));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 596,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 17, 18, 8, 953, DateTimeKind.Local).AddTicks(9646));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 597,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 17, 38, 8, 953, DateTimeKind.Local).AddTicks(9650));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 598,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 17, 58, 8, 953, DateTimeKind.Local).AddTicks(9654));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 599,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 18, 18, 8, 953, DateTimeKind.Local).AddTicks(9658));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 600,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 18, 38, 8, 953, DateTimeKind.Local).AddTicks(9662));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 601,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 18, 58, 8, 953, DateTimeKind.Local).AddTicks(9666));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 602,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 19, 18, 8, 953, DateTimeKind.Local).AddTicks(9670));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 603,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 19, 38, 8, 953, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 604,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 19, 58, 8, 953, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 605,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 20, 18, 8, 953, DateTimeKind.Local).AddTicks(9682));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 606,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 20, 38, 8, 953, DateTimeKind.Local).AddTicks(9686));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 607,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 20, 58, 8, 953, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 608,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 21, 18, 8, 953, DateTimeKind.Local).AddTicks(9694));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 609,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 21, 38, 8, 953, DateTimeKind.Local).AddTicks(9699));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 610,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 21, 58, 8, 953, DateTimeKind.Local).AddTicks(9703));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 611,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 22, 18, 8, 953, DateTimeKind.Local).AddTicks(9707));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 612,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 22, 38, 8, 953, DateTimeKind.Local).AddTicks(9711));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 613,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 22, 58, 8, 953, DateTimeKind.Local).AddTicks(9715));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 614,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 23, 18, 8, 953, DateTimeKind.Local).AddTicks(9719));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 615,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 23, 38, 8, 953, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 616,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 23, 58, 8, 953, DateTimeKind.Local).AddTicks(9727));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 617,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 0, 18, 8, 953, DateTimeKind.Local).AddTicks(9731));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 618,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 0, 38, 8, 953, DateTimeKind.Local).AddTicks(9736));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 619,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 0, 58, 8, 953, DateTimeKind.Local).AddTicks(9740));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 620,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 1, 18, 8, 953, DateTimeKind.Local).AddTicks(9744));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 621,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 1, 38, 8, 953, DateTimeKind.Local).AddTicks(9748));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 622,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 1, 58, 8, 953, DateTimeKind.Local).AddTicks(9752));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 623,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 2, 18, 8, 953, DateTimeKind.Local).AddTicks(9756));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 624,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 2, 38, 8, 953, DateTimeKind.Local).AddTicks(9760));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 625,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 2, 58, 8, 953, DateTimeKind.Local).AddTicks(9764));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 626,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 3, 18, 8, 953, DateTimeKind.Local).AddTicks(9768));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 627,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 3, 38, 8, 953, DateTimeKind.Local).AddTicks(9772));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 628,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 3, 58, 8, 953, DateTimeKind.Local).AddTicks(9776));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 629,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 4, 18, 8, 953, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 630,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 4, 38, 8, 953, DateTimeKind.Local).AddTicks(9784));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 631,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 4, 58, 8, 953, DateTimeKind.Local).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 632,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 5, 18, 8, 953, DateTimeKind.Local).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 633,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 5, 38, 8, 953, DateTimeKind.Local).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 634,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 5, 58, 8, 953, DateTimeKind.Local).AddTicks(9801));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 635,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 6, 18, 8, 953, DateTimeKind.Local).AddTicks(9805));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 636,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 6, 38, 8, 953, DateTimeKind.Local).AddTicks(9809));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 637,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 6, 58, 8, 953, DateTimeKind.Local).AddTicks(9813));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 638,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 7, 18, 8, 953, DateTimeKind.Local).AddTicks(9817));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 639,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 7, 38, 8, 953, DateTimeKind.Local).AddTicks(9821));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 640,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 7, 58, 8, 953, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 641,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 8, 18, 8, 953, DateTimeKind.Local).AddTicks(9830));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 642,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 8, 38, 8, 953, DateTimeKind.Local).AddTicks(9834));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 643,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 8, 58, 8, 953, DateTimeKind.Local).AddTicks(9838));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 644,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 9, 18, 8, 953, DateTimeKind.Local).AddTicks(9842));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 645,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 9, 38, 8, 953, DateTimeKind.Local).AddTicks(9846));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 646,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 9, 58, 8, 953, DateTimeKind.Local).AddTicks(9850));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 647,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 10, 18, 8, 953, DateTimeKind.Local).AddTicks(9854));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 648,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 10, 38, 8, 953, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 649,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 10, 58, 8, 953, DateTimeKind.Local).AddTicks(9862));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 650,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 11, 18, 8, 953, DateTimeKind.Local).AddTicks(9866));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 651,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 11, 38, 8, 953, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 652,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 11, 58, 8, 953, DateTimeKind.Local).AddTicks(9875));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 653,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 12, 18, 8, 953, DateTimeKind.Local).AddTicks(9879));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 654,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 12, 38, 8, 953, DateTimeKind.Local).AddTicks(9883));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 655,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 12, 58, 8, 953, DateTimeKind.Local).AddTicks(9887));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 656,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 13, 18, 8, 953, DateTimeKind.Local).AddTicks(9891));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 657,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 13, 38, 8, 953, DateTimeKind.Local).AddTicks(9895));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 658,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 13, 58, 8, 953, DateTimeKind.Local).AddTicks(9899));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 659,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 14, 18, 8, 953, DateTimeKind.Local).AddTicks(9903));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 660,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 14, 38, 8, 953, DateTimeKind.Local).AddTicks(9908));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 661,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 14, 58, 8, 953, DateTimeKind.Local).AddTicks(9912));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 662,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 15, 18, 8, 953, DateTimeKind.Local).AddTicks(9916));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 663,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 15, 38, 8, 953, DateTimeKind.Local).AddTicks(9920));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 664,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 15, 58, 8, 953, DateTimeKind.Local).AddTicks(9924));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 665,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 16, 18, 8, 953, DateTimeKind.Local).AddTicks(9928));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 666,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 16, 38, 8, 953, DateTimeKind.Local).AddTicks(9932));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 667,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 16, 58, 8, 953, DateTimeKind.Local).AddTicks(9936));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 668,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 17, 18, 8, 953, DateTimeKind.Local).AddTicks(9940));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 669,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 17, 38, 8, 953, DateTimeKind.Local).AddTicks(9944));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 670,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 17, 58, 8, 953, DateTimeKind.Local).AddTicks(9948));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 671,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 18, 18, 8, 953, DateTimeKind.Local).AddTicks(9952));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 672,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 18, 38, 8, 953, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 673,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 18, 58, 8, 953, DateTimeKind.Local).AddTicks(9961));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 674,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 19, 18, 8, 953, DateTimeKind.Local).AddTicks(9965));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 675,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 19, 38, 8, 953, DateTimeKind.Local).AddTicks(9969));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 676,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 19, 58, 8, 953, DateTimeKind.Local).AddTicks(9973));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 677,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 20, 18, 8, 953, DateTimeKind.Local).AddTicks(9977));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 678,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 20, 38, 8, 953, DateTimeKind.Local).AddTicks(9981));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 679,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 20, 58, 8, 953, DateTimeKind.Local).AddTicks(9985));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 680,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 21, 18, 8, 953, DateTimeKind.Local).AddTicks(9990));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 681,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 21, 38, 8, 953, DateTimeKind.Local).AddTicks(9994));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 682,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 21, 58, 8, 953, DateTimeKind.Local).AddTicks(9998));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 683,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 22, 18, 8, 954, DateTimeKind.Local).AddTicks(88));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 684,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 22, 38, 8, 954, DateTimeKind.Local).AddTicks(93));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 685,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 22, 58, 8, 954, DateTimeKind.Local).AddTicks(97));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 686,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 23, 18, 8, 954, DateTimeKind.Local).AddTicks(101));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 687,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 23, 38, 8, 954, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 688,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 23, 58, 8, 954, DateTimeKind.Local).AddTicks(109));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 689,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 0, 18, 8, 954, DateTimeKind.Local).AddTicks(113));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 690,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 0, 38, 8, 954, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 691,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 0, 58, 8, 954, DateTimeKind.Local).AddTicks(121));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 692,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 1, 18, 8, 954, DateTimeKind.Local).AddTicks(125));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 693,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 1, 38, 8, 954, DateTimeKind.Local).AddTicks(130));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 694,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 1, 58, 8, 954, DateTimeKind.Local).AddTicks(134));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 695,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 2, 18, 8, 954, DateTimeKind.Local).AddTicks(138));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 696,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 2, 38, 8, 954, DateTimeKind.Local).AddTicks(142));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 697,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 2, 58, 8, 954, DateTimeKind.Local).AddTicks(146));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 698,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 3, 18, 8, 954, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 699,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 3, 38, 8, 954, DateTimeKind.Local).AddTicks(154));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 700,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 3, 58, 8, 954, DateTimeKind.Local).AddTicks(158));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 701,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 4, 18, 8, 954, DateTimeKind.Local).AddTicks(163));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 702,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 4, 38, 8, 954, DateTimeKind.Local).AddTicks(167));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 703,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 4, 58, 8, 954, DateTimeKind.Local).AddTicks(171));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 704,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 5, 18, 8, 954, DateTimeKind.Local).AddTicks(175));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 705,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 5, 38, 8, 954, DateTimeKind.Local).AddTicks(179));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 706,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 5, 58, 8, 954, DateTimeKind.Local).AddTicks(183));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 707,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 6, 18, 8, 954, DateTimeKind.Local).AddTicks(187));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 708,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 6, 38, 8, 954, DateTimeKind.Local).AddTicks(191));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 709,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 6, 58, 8, 954, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 710,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 7, 18, 8, 954, DateTimeKind.Local).AddTicks(200));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 711,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 7, 38, 8, 954, DateTimeKind.Local).AddTicks(204));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 712,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 7, 58, 8, 954, DateTimeKind.Local).AddTicks(208));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 713,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 8, 18, 8, 954, DateTimeKind.Local).AddTicks(212));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 714,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 8, 38, 8, 954, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 715,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 8, 58, 8, 954, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 716,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 9, 18, 8, 954, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 717,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 9, 38, 8, 954, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 718,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 9, 58, 8, 954, DateTimeKind.Local).AddTicks(233));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 719,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 10, 18, 8, 954, DateTimeKind.Local).AddTicks(237));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 720,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 10, 38, 8, 954, DateTimeKind.Local).AddTicks(241));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 721,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 10, 58, 8, 954, DateTimeKind.Local).AddTicks(245));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 722,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 11, 18, 8, 954, DateTimeKind.Local).AddTicks(249));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 723,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 11, 38, 8, 954, DateTimeKind.Local).AddTicks(254));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 724,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 11, 58, 8, 954, DateTimeKind.Local).AddTicks(258));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 725,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 12, 18, 8, 954, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 726,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 12, 38, 8, 954, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 727,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 12, 58, 8, 954, DateTimeKind.Local).AddTicks(270));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 728,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 13, 18, 8, 954, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 729,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 13, 38, 8, 954, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 730,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 13, 58, 8, 954, DateTimeKind.Local).AddTicks(282));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 731,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 14, 18, 8, 954, DateTimeKind.Local).AddTicks(286));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 732,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 14, 38, 8, 954, DateTimeKind.Local).AddTicks(291));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 733,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 14, 58, 8, 954, DateTimeKind.Local).AddTicks(295));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 734,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 15, 18, 8, 954, DateTimeKind.Local).AddTicks(299));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 735,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 15, 38, 8, 954, DateTimeKind.Local).AddTicks(303));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 736,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 15, 58, 8, 954, DateTimeKind.Local).AddTicks(307));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 737,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 16, 18, 8, 954, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 738,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 16, 38, 8, 954, DateTimeKind.Local).AddTicks(316));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 739,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 16, 58, 8, 954, DateTimeKind.Local).AddTicks(320));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 740,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 17, 18, 8, 954, DateTimeKind.Local).AddTicks(324));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 741,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 17, 38, 8, 954, DateTimeKind.Local).AddTicks(328));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 742,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 17, 58, 8, 954, DateTimeKind.Local).AddTicks(332));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 743,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 18, 18, 8, 954, DateTimeKind.Local).AddTicks(336));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 744,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 18, 38, 8, 954, DateTimeKind.Local).AddTicks(340));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 745,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 18, 58, 8, 954, DateTimeKind.Local).AddTicks(345));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 746,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 19, 18, 8, 954, DateTimeKind.Local).AddTicks(349));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 747,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 19, 38, 8, 954, DateTimeKind.Local).AddTicks(353));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 748,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 19, 58, 8, 954, DateTimeKind.Local).AddTicks(357));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 749,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 20, 18, 8, 954, DateTimeKind.Local).AddTicks(361));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 750,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 20, 38, 8, 954, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 751,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 20, 58, 8, 954, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 752,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 21, 18, 8, 954, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 753,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 21, 38, 8, 954, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 754,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 21, 58, 8, 954, DateTimeKind.Local).AddTicks(382));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 755,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 22, 18, 8, 954, DateTimeKind.Local).AddTicks(386));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 756,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 22, 38, 8, 954, DateTimeKind.Local).AddTicks(390));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 757,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 22, 58, 8, 954, DateTimeKind.Local).AddTicks(394));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 758,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 23, 18, 8, 954, DateTimeKind.Local).AddTicks(398));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 759,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 23, 38, 8, 954, DateTimeKind.Local).AddTicks(402));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 760,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 23, 58, 8, 954, DateTimeKind.Local).AddTicks(407));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 761,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 0, 18, 8, 954, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 762,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 0, 38, 8, 954, DateTimeKind.Local).AddTicks(415));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 763,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 0, 58, 8, 954, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 764,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 1, 18, 8, 954, DateTimeKind.Local).AddTicks(423));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 765,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 1, 38, 8, 954, DateTimeKind.Local).AddTicks(427));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 766,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 1, 58, 8, 954, DateTimeKind.Local).AddTicks(431));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 767,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 2, 18, 8, 954, DateTimeKind.Local).AddTicks(436));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 768,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 2, 38, 8, 954, DateTimeKind.Local).AddTicks(440));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 769,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 2, 58, 8, 954, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 770,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 3, 18, 8, 954, DateTimeKind.Local).AddTicks(448));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 771,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 3, 38, 8, 954, DateTimeKind.Local).AddTicks(452));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 772,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 3, 58, 8, 954, DateTimeKind.Local).AddTicks(456));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 773,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 4, 18, 8, 954, DateTimeKind.Local).AddTicks(461));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 774,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 4, 38, 8, 954, DateTimeKind.Local).AddTicks(465));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 775,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 4, 58, 8, 954, DateTimeKind.Local).AddTicks(469));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 776,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 5, 18, 8, 954, DateTimeKind.Local).AddTicks(473));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 777,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 5, 38, 8, 954, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 778,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 5, 58, 8, 954, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 779,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 6, 18, 8, 954, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 780,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 6, 38, 8, 954, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 781,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 6, 58, 8, 954, DateTimeKind.Local).AddTicks(495));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 782,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 7, 18, 8, 954, DateTimeKind.Local).AddTicks(499));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 783,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 7, 38, 8, 954, DateTimeKind.Local).AddTicks(503));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 784,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 7, 58, 8, 954, DateTimeKind.Local).AddTicks(507));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 785,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 8, 18, 8, 954, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 786,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 8, 38, 8, 954, DateTimeKind.Local).AddTicks(516));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 787,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 8, 58, 8, 954, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 788,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 9, 18, 8, 954, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 789,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 9, 38, 8, 954, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 790,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 9, 58, 8, 954, DateTimeKind.Local).AddTicks(533));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 791,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 10, 18, 8, 954, DateTimeKind.Local).AddTicks(537));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 792,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 10, 38, 8, 954, DateTimeKind.Local).AddTicks(541));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 793,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 10, 58, 8, 954, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 794,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 11, 18, 8, 954, DateTimeKind.Local).AddTicks(550));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 795,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 11, 38, 8, 954, DateTimeKind.Local).AddTicks(554));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 796,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 11, 58, 8, 954, DateTimeKind.Local).AddTicks(558));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 797,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 12, 18, 8, 954, DateTimeKind.Local).AddTicks(610));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 798,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 12, 38, 8, 954, DateTimeKind.Local).AddTicks(615));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 799,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 12, 58, 8, 954, DateTimeKind.Local).AddTicks(619));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 800,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 13, 18, 8, 954, DateTimeKind.Local).AddTicks(623));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 801,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 13, 38, 8, 954, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 802,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 13, 58, 8, 954, DateTimeKind.Local).AddTicks(631));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 803,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 14, 18, 8, 954, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 804,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 14, 38, 8, 954, DateTimeKind.Local).AddTicks(640));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 805,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 14, 58, 8, 954, DateTimeKind.Local).AddTicks(644));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 806,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 15, 18, 8, 954, DateTimeKind.Local).AddTicks(648));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 807,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 15, 38, 8, 954, DateTimeKind.Local).AddTicks(652));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 808,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 15, 58, 8, 954, DateTimeKind.Local).AddTicks(656));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 809,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 16, 18, 8, 954, DateTimeKind.Local).AddTicks(660));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 810,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 16, 38, 8, 954, DateTimeKind.Local).AddTicks(665));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 811,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 16, 58, 8, 954, DateTimeKind.Local).AddTicks(669));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 812,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 17, 18, 8, 954, DateTimeKind.Local).AddTicks(673));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 813,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 17, 38, 8, 954, DateTimeKind.Local).AddTicks(677));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 814,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 17, 58, 8, 954, DateTimeKind.Local).AddTicks(681));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 815,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 18, 18, 8, 954, DateTimeKind.Local).AddTicks(685));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 816,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 18, 38, 8, 954, DateTimeKind.Local).AddTicks(689));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 817,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 18, 58, 8, 954, DateTimeKind.Local).AddTicks(693));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 818,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 19, 18, 8, 954, DateTimeKind.Local).AddTicks(697));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 819,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 19, 38, 8, 954, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 820,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 19, 58, 8, 954, DateTimeKind.Local).AddTicks(706));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 821,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 20, 18, 8, 954, DateTimeKind.Local).AddTicks(710));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 822,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 20, 38, 8, 954, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 823,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 20, 58, 8, 954, DateTimeKind.Local).AddTicks(718));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 824,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 21, 18, 8, 954, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 825,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 21, 38, 8, 954, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 826,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 21, 58, 8, 954, DateTimeKind.Local).AddTicks(731));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 827,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 22, 18, 8, 954, DateTimeKind.Local).AddTicks(735));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 828,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 22, 38, 8, 954, DateTimeKind.Local).AddTicks(739));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 829,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 22, 58, 8, 954, DateTimeKind.Local).AddTicks(743));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 830,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 23, 18, 8, 954, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.CreateIndex(
                name: "IX_BeerCharacteristics_DataSeriesId",
                table: "BeerCharacteristics",
                column: "DataSeriesId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BeerCharacteristics");

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 11,
                column: "RecordTime",
                value: new DateTime(2020, 10, 29, 19, 48, 22, 224, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 12,
                column: "RecordTime",
                value: new DateTime(2020, 10, 29, 20, 8, 22, 227, DateTimeKind.Local).AddTicks(8399));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 13,
                column: "RecordTime",
                value: new DateTime(2020, 10, 29, 20, 28, 22, 227, DateTimeKind.Local).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 14,
                column: "RecordTime",
                value: new DateTime(2020, 10, 29, 20, 48, 22, 227, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 15,
                column: "RecordTime",
                value: new DateTime(2020, 10, 29, 21, 8, 22, 227, DateTimeKind.Local).AddTicks(8526));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 16,
                column: "RecordTime",
                value: new DateTime(2020, 10, 29, 21, 28, 22, 227, DateTimeKind.Local).AddTicks(8530));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 17,
                column: "RecordTime",
                value: new DateTime(2020, 10, 29, 21, 48, 22, 227, DateTimeKind.Local).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 18,
                column: "RecordTime",
                value: new DateTime(2020, 10, 29, 22, 8, 22, 227, DateTimeKind.Local).AddTicks(8563));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 19,
                column: "RecordTime",
                value: new DateTime(2020, 10, 29, 22, 28, 22, 227, DateTimeKind.Local).AddTicks(8568));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 20,
                column: "RecordTime",
                value: new DateTime(2020, 10, 29, 22, 48, 22, 227, DateTimeKind.Local).AddTicks(8572));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 21,
                column: "RecordTime",
                value: new DateTime(2020, 10, 29, 23, 8, 22, 227, DateTimeKind.Local).AddTicks(8576));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 22,
                column: "RecordTime",
                value: new DateTime(2020, 10, 29, 23, 28, 22, 227, DateTimeKind.Local).AddTicks(8580));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 23,
                column: "RecordTime",
                value: new DateTime(2020, 10, 29, 23, 48, 22, 227, DateTimeKind.Local).AddTicks(8585));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 24,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 0, 8, 22, 227, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 25,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 0, 28, 22, 227, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 26,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 0, 48, 22, 227, DateTimeKind.Local).AddTicks(8597));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 27,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 1, 8, 22, 227, DateTimeKind.Local).AddTicks(8601));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 28,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 1, 28, 22, 227, DateTimeKind.Local).AddTicks(8606));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 29,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 1, 48, 22, 227, DateTimeKind.Local).AddTicks(8610));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 30,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 2, 8, 22, 227, DateTimeKind.Local).AddTicks(8614));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 31,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 2, 28, 22, 228, DateTimeKind.Local).AddTicks(149));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 32,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 2, 48, 22, 228, DateTimeKind.Local).AddTicks(192));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 33,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 3, 8, 22, 228, DateTimeKind.Local).AddTicks(198));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 34,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 3, 28, 22, 228, DateTimeKind.Local).AddTicks(211));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 35,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 3, 48, 22, 228, DateTimeKind.Local).AddTicks(216));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 36,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 4, 8, 22, 228, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 37,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 4, 28, 22, 228, DateTimeKind.Local).AddTicks(224));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 38,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 4, 48, 22, 228, DateTimeKind.Local).AddTicks(228));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 39,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 5, 8, 22, 228, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 40,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 5, 28, 22, 228, DateTimeKind.Local).AddTicks(236));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 41,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 5, 48, 22, 228, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 42,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 6, 8, 22, 228, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 43,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 6, 28, 22, 228, DateTimeKind.Local).AddTicks(248));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 44,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 6, 48, 22, 228, DateTimeKind.Local).AddTicks(252));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 45,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 7, 8, 22, 228, DateTimeKind.Local).AddTicks(256));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 46,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 7, 28, 22, 228, DateTimeKind.Local).AddTicks(261));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 47,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 7, 48, 22, 228, DateTimeKind.Local).AddTicks(265));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 48,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 8, 8, 22, 228, DateTimeKind.Local).AddTicks(269));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 49,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 8, 28, 22, 228, DateTimeKind.Local).AddTicks(272));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 50,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 8, 48, 22, 228, DateTimeKind.Local).AddTicks(277));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 51,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 9, 8, 22, 228, DateTimeKind.Local).AddTicks(280));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 52,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 9, 28, 22, 228, DateTimeKind.Local).AddTicks(284));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 53,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 9, 48, 22, 228, DateTimeKind.Local).AddTicks(288));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 54,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 10, 8, 22, 228, DateTimeKind.Local).AddTicks(468));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 55,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 10, 28, 22, 228, DateTimeKind.Local).AddTicks(474));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 56,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 10, 48, 22, 228, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 57,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 11, 8, 22, 228, DateTimeKind.Local).AddTicks(482));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 58,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 11, 28, 22, 228, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 59,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 11, 48, 22, 228, DateTimeKind.Local).AddTicks(490));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 60,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 12, 8, 22, 228, DateTimeKind.Local).AddTicks(494));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 61,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 12, 28, 22, 228, DateTimeKind.Local).AddTicks(498));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 62,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 12, 48, 22, 228, DateTimeKind.Local).AddTicks(502));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 63,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 13, 8, 22, 228, DateTimeKind.Local).AddTicks(506));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 64,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 13, 28, 22, 228, DateTimeKind.Local).AddTicks(510));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 65,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 13, 48, 22, 228, DateTimeKind.Local).AddTicks(514));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 66,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 14, 8, 22, 228, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 67,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 14, 28, 22, 228, DateTimeKind.Local).AddTicks(524));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 68,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 14, 48, 22, 228, DateTimeKind.Local).AddTicks(528));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 69,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 15, 8, 22, 228, DateTimeKind.Local).AddTicks(532));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 70,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 15, 28, 22, 228, DateTimeKind.Local).AddTicks(536));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 71,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 15, 48, 22, 228, DateTimeKind.Local).AddTicks(540));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 72,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 16, 8, 22, 228, DateTimeKind.Local).AddTicks(544));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 73,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 16, 28, 22, 228, DateTimeKind.Local).AddTicks(548));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 74,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 16, 48, 22, 228, DateTimeKind.Local).AddTicks(552));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 75,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 17, 8, 22, 228, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 76,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 17, 28, 22, 228, DateTimeKind.Local).AddTicks(560));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 77,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 17, 48, 22, 228, DateTimeKind.Local).AddTicks(564));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 78,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 18, 8, 22, 228, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 79,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 18, 28, 22, 228, DateTimeKind.Local).AddTicks(572));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 80,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 18, 48, 22, 228, DateTimeKind.Local).AddTicks(576));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 81,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 19, 8, 22, 228, DateTimeKind.Local).AddTicks(580));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 82,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 19, 28, 22, 228, DateTimeKind.Local).AddTicks(584));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 83,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 19, 48, 22, 228, DateTimeKind.Local).AddTicks(588));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 84,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 20, 8, 22, 228, DateTimeKind.Local).AddTicks(592));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 85,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 20, 28, 22, 228, DateTimeKind.Local).AddTicks(596));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 86,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 20, 48, 22, 228, DateTimeKind.Local).AddTicks(600));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 87,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 21, 8, 22, 228, DateTimeKind.Local).AddTicks(604));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 88,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 21, 28, 22, 228, DateTimeKind.Local).AddTicks(608));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 89,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 21, 48, 22, 228, DateTimeKind.Local).AddTicks(612));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 90,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 22, 8, 22, 228, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 91,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 22, 28, 22, 228, DateTimeKind.Local).AddTicks(621));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 92,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 22, 48, 22, 228, DateTimeKind.Local).AddTicks(625));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 93,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 23, 8, 22, 228, DateTimeKind.Local).AddTicks(629));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 94,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 23, 28, 22, 228, DateTimeKind.Local).AddTicks(682));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 95,
                column: "RecordTime",
                value: new DateTime(2020, 10, 30, 23, 48, 22, 228, DateTimeKind.Local).AddTicks(686));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 96,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 0, 8, 22, 228, DateTimeKind.Local).AddTicks(690));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 97,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 0, 28, 22, 228, DateTimeKind.Local).AddTicks(694));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 98,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 0, 48, 22, 228, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 99,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 1, 8, 22, 228, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 100,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 1, 28, 22, 228, DateTimeKind.Local).AddTicks(707));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 101,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 1, 48, 22, 228, DateTimeKind.Local).AddTicks(711));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 102,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 2, 8, 22, 228, DateTimeKind.Local).AddTicks(715));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 103,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 2, 28, 22, 228, DateTimeKind.Local).AddTicks(719));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 104,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 2, 48, 22, 228, DateTimeKind.Local).AddTicks(722));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 105,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 3, 8, 22, 228, DateTimeKind.Local).AddTicks(726));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 106,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 3, 28, 22, 228, DateTimeKind.Local).AddTicks(730));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 107,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 3, 48, 22, 228, DateTimeKind.Local).AddTicks(734));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 108,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 4, 8, 22, 228, DateTimeKind.Local).AddTicks(738));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 109,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 4, 28, 22, 228, DateTimeKind.Local).AddTicks(742));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 110,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 4, 48, 22, 228, DateTimeKind.Local).AddTicks(746));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 111,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 5, 8, 22, 228, DateTimeKind.Local).AddTicks(750));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 112,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 5, 28, 22, 228, DateTimeKind.Local).AddTicks(793));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 113,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 5, 48, 22, 228, DateTimeKind.Local).AddTicks(798));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 114,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 6, 8, 22, 228, DateTimeKind.Local).AddTicks(802));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 115,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 6, 28, 22, 228, DateTimeKind.Local).AddTicks(806));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 116,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 6, 48, 22, 228, DateTimeKind.Local).AddTicks(810));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 117,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 7, 8, 22, 228, DateTimeKind.Local).AddTicks(814));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 118,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 7, 28, 22, 228, DateTimeKind.Local).AddTicks(818));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 119,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 7, 48, 22, 228, DateTimeKind.Local).AddTicks(822));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 120,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 8, 8, 22, 228, DateTimeKind.Local).AddTicks(826));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 121,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 8, 28, 22, 228, DateTimeKind.Local).AddTicks(831));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 122,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 8, 48, 22, 228, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 123,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 9, 8, 22, 228, DateTimeKind.Local).AddTicks(838));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 124,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 9, 28, 22, 228, DateTimeKind.Local).AddTicks(842));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 125,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 9, 48, 22, 228, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 126,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 10, 8, 22, 228, DateTimeKind.Local).AddTicks(850));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 127,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 10, 28, 22, 228, DateTimeKind.Local).AddTicks(855));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 128,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 10, 48, 22, 228, DateTimeKind.Local).AddTicks(859));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 129,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 11, 8, 22, 228, DateTimeKind.Local).AddTicks(863));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 130,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 11, 28, 22, 228, DateTimeKind.Local).AddTicks(918));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 131,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 11, 48, 22, 228, DateTimeKind.Local).AddTicks(923));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 132,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 12, 8, 22, 228, DateTimeKind.Local).AddTicks(927));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 133,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 12, 28, 22, 228, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 134,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 12, 48, 22, 228, DateTimeKind.Local).AddTicks(936));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 135,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 13, 8, 22, 228, DateTimeKind.Local).AddTicks(940));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 136,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 13, 28, 22, 228, DateTimeKind.Local).AddTicks(944));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 137,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 13, 48, 22, 228, DateTimeKind.Local).AddTicks(948));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 138,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 14, 8, 22, 228, DateTimeKind.Local).AddTicks(952));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 139,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 14, 28, 22, 228, DateTimeKind.Local).AddTicks(956));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 140,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 14, 48, 22, 228, DateTimeKind.Local).AddTicks(960));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 141,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 15, 8, 22, 228, DateTimeKind.Local).AddTicks(964));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 142,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 15, 28, 22, 228, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 143,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 15, 48, 22, 228, DateTimeKind.Local).AddTicks(972));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 144,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 16, 8, 22, 228, DateTimeKind.Local).AddTicks(976));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 145,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 16, 28, 22, 228, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 146,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 16, 48, 22, 228, DateTimeKind.Local).AddTicks(984));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 147,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 17, 8, 22, 228, DateTimeKind.Local).AddTicks(988));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 148,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 17, 28, 22, 228, DateTimeKind.Local).AddTicks(992));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 149,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 17, 48, 22, 228, DateTimeKind.Local).AddTicks(996));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 150,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 18, 8, 22, 228, DateTimeKind.Local).AddTicks(1000));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 151,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 18, 28, 22, 228, DateTimeKind.Local).AddTicks(1004));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 152,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 18, 48, 22, 228, DateTimeKind.Local).AddTicks(1008));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 153,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 19, 8, 22, 228, DateTimeKind.Local).AddTicks(1012));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 154,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 19, 28, 22, 228, DateTimeKind.Local).AddTicks(1016));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 155,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 19, 48, 22, 228, DateTimeKind.Local).AddTicks(1021));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 156,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 20, 8, 22, 228, DateTimeKind.Local).AddTicks(1025));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 157,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 20, 28, 22, 228, DateTimeKind.Local).AddTicks(1029));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 158,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 20, 48, 22, 228, DateTimeKind.Local).AddTicks(1033));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 159,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 21, 8, 22, 228, DateTimeKind.Local).AddTicks(1037));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 160,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 21, 28, 22, 228, DateTimeKind.Local).AddTicks(1041));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 161,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 21, 48, 22, 228, DateTimeKind.Local).AddTicks(1045));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 162,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 22, 8, 22, 228, DateTimeKind.Local).AddTicks(1049));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 163,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 22, 28, 22, 228, DateTimeKind.Local).AddTicks(1053));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 164,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 22, 48, 22, 228, DateTimeKind.Local).AddTicks(1057));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 165,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 23, 8, 22, 228, DateTimeKind.Local).AddTicks(1061));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 166,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 23, 28, 22, 228, DateTimeKind.Local).AddTicks(1065));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 167,
                column: "RecordTime",
                value: new DateTime(2020, 10, 31, 23, 48, 22, 228, DateTimeKind.Local).AddTicks(1069));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 168,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 0, 8, 22, 228, DateTimeKind.Local).AddTicks(1073));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 169,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 0, 28, 22, 228, DateTimeKind.Local).AddTicks(1078));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 170,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 0, 48, 22, 228, DateTimeKind.Local).AddTicks(1082));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 171,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 1, 8, 22, 228, DateTimeKind.Local).AddTicks(1086));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 172,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 1, 28, 22, 228, DateTimeKind.Local).AddTicks(1090));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 173,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 1, 48, 22, 228, DateTimeKind.Local).AddTicks(1094));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 174,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 2, 8, 22, 228, DateTimeKind.Local).AddTicks(1099));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 175,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 2, 28, 22, 228, DateTimeKind.Local).AddTicks(1103));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 176,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 2, 48, 22, 228, DateTimeKind.Local).AddTicks(1107));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 177,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 3, 8, 22, 228, DateTimeKind.Local).AddTicks(1111));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 178,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 3, 28, 22, 228, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 179,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 3, 48, 22, 228, DateTimeKind.Local).AddTicks(1119));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 180,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 4, 8, 22, 228, DateTimeKind.Local).AddTicks(1123));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 181,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 4, 28, 22, 228, DateTimeKind.Local).AddTicks(1127));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 182,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 4, 48, 22, 228, DateTimeKind.Local).AddTicks(1131));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 183,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 5, 8, 22, 228, DateTimeKind.Local).AddTicks(1135));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 184,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 5, 28, 22, 228, DateTimeKind.Local).AddTicks(1139));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 185,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 5, 48, 22, 228, DateTimeKind.Local).AddTicks(1143));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 186,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 6, 8, 22, 228, DateTimeKind.Local).AddTicks(1148));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 187,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 6, 28, 22, 228, DateTimeKind.Local).AddTicks(1152));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 188,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 6, 48, 22, 228, DateTimeKind.Local).AddTicks(1156));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 189,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 7, 8, 22, 228, DateTimeKind.Local).AddTicks(1160));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 190,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 7, 28, 22, 228, DateTimeKind.Local).AddTicks(1164));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 191,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 7, 48, 22, 228, DateTimeKind.Local).AddTicks(1168));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 192,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 8, 8, 22, 228, DateTimeKind.Local).AddTicks(1172));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 193,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 8, 28, 22, 228, DateTimeKind.Local).AddTicks(1176));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 194,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 8, 48, 22, 228, DateTimeKind.Local).AddTicks(1180));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 195,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 9, 8, 22, 228, DateTimeKind.Local).AddTicks(1184));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 196,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 9, 28, 22, 228, DateTimeKind.Local).AddTicks(1188));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 197,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 9, 48, 22, 228, DateTimeKind.Local).AddTicks(1193));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 198,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 10, 8, 22, 228, DateTimeKind.Local).AddTicks(1197));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 199,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 10, 28, 22, 228, DateTimeKind.Local).AddTicks(1201));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 200,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 10, 48, 22, 228, DateTimeKind.Local).AddTicks(1205));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 201,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 11, 8, 22, 228, DateTimeKind.Local).AddTicks(1209));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 202,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 11, 28, 22, 228, DateTimeKind.Local).AddTicks(1213));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 203,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 11, 48, 22, 228, DateTimeKind.Local).AddTicks(1217));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 204,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 12, 8, 22, 228, DateTimeKind.Local).AddTicks(1221));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 205,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 12, 28, 22, 228, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 206,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 12, 48, 22, 228, DateTimeKind.Local).AddTicks(1229));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 207,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 13, 8, 22, 228, DateTimeKind.Local).AddTicks(1233));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 208,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 13, 28, 22, 228, DateTimeKind.Local).AddTicks(1237));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 209,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 13, 48, 22, 228, DateTimeKind.Local).AddTicks(1241));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 210,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 14, 8, 22, 228, DateTimeKind.Local).AddTicks(1245));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 211,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 14, 28, 22, 228, DateTimeKind.Local).AddTicks(1249));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 212,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 14, 48, 22, 228, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 213,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 15, 8, 22, 228, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 214,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 15, 28, 22, 228, DateTimeKind.Local).AddTicks(1262));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 215,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 15, 48, 22, 228, DateTimeKind.Local).AddTicks(1266));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 216,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 16, 8, 22, 228, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 217,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 16, 28, 22, 228, DateTimeKind.Local).AddTicks(1275));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 218,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 16, 48, 22, 228, DateTimeKind.Local).AddTicks(1279));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 219,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 17, 8, 22, 228, DateTimeKind.Local).AddTicks(1283));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 220,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 17, 28, 22, 228, DateTimeKind.Local).AddTicks(1287));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 221,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 17, 48, 22, 228, DateTimeKind.Local).AddTicks(1291));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 222,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 18, 8, 22, 228, DateTimeKind.Local).AddTicks(1295));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 223,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 18, 28, 22, 228, DateTimeKind.Local).AddTicks(1299));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 224,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 18, 48, 22, 228, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 225,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 19, 8, 22, 228, DateTimeKind.Local).AddTicks(1307));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 226,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 19, 28, 22, 228, DateTimeKind.Local).AddTicks(1311));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 227,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 19, 48, 22, 228, DateTimeKind.Local).AddTicks(1315));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 228,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 20, 8, 22, 228, DateTimeKind.Local).AddTicks(1319));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 229,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 20, 28, 22, 228, DateTimeKind.Local).AddTicks(1323));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 230,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 20, 48, 22, 228, DateTimeKind.Local).AddTicks(1327));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 231,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 21, 8, 22, 228, DateTimeKind.Local).AddTicks(1331));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 232,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 21, 28, 22, 228, DateTimeKind.Local).AddTicks(1336));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 233,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 21, 48, 22, 228, DateTimeKind.Local).AddTicks(1340));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 234,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 22, 8, 22, 228, DateTimeKind.Local).AddTicks(1344));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 235,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 22, 28, 22, 228, DateTimeKind.Local).AddTicks(1348));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 236,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 22, 48, 22, 228, DateTimeKind.Local).AddTicks(1352));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 237,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 23, 8, 22, 228, DateTimeKind.Local).AddTicks(1403));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 238,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 23, 28, 22, 228, DateTimeKind.Local).AddTicks(1409));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 239,
                column: "RecordTime",
                value: new DateTime(2020, 11, 1, 23, 48, 22, 228, DateTimeKind.Local).AddTicks(1413));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 240,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 0, 8, 22, 228, DateTimeKind.Local).AddTicks(1417));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 241,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 0, 28, 22, 228, DateTimeKind.Local).AddTicks(1421));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 242,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 0, 48, 22, 228, DateTimeKind.Local).AddTicks(1425));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 243,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 1, 8, 22, 228, DateTimeKind.Local).AddTicks(1429));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 244,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 1, 28, 22, 228, DateTimeKind.Local).AddTicks(1433));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 245,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 1, 48, 22, 228, DateTimeKind.Local).AddTicks(1437));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 246,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 2, 8, 22, 228, DateTimeKind.Local).AddTicks(1441));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 247,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 2, 28, 22, 228, DateTimeKind.Local).AddTicks(1445));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 248,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 2, 48, 22, 228, DateTimeKind.Local).AddTicks(1449));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 249,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 3, 8, 22, 228, DateTimeKind.Local).AddTicks(1453));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 250,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 3, 28, 22, 228, DateTimeKind.Local).AddTicks(1457));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 251,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 3, 48, 22, 228, DateTimeKind.Local).AddTicks(1461));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 252,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 4, 8, 22, 228, DateTimeKind.Local).AddTicks(1465));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 253,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 4, 28, 22, 228, DateTimeKind.Local).AddTicks(1469));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 254,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 4, 48, 22, 228, DateTimeKind.Local).AddTicks(1473));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 255,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 5, 8, 22, 228, DateTimeKind.Local).AddTicks(1477));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 256,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 5, 28, 22, 228, DateTimeKind.Local).AddTicks(1482));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 257,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 5, 48, 22, 228, DateTimeKind.Local).AddTicks(1486));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 258,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 6, 8, 22, 228, DateTimeKind.Local).AddTicks(1492));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 259,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 6, 28, 22, 228, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 260,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 6, 48, 22, 228, DateTimeKind.Local).AddTicks(1500));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 261,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 7, 8, 22, 228, DateTimeKind.Local).AddTicks(1504));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 262,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 7, 28, 22, 228, DateTimeKind.Local).AddTicks(1508));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 263,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 7, 48, 22, 228, DateTimeKind.Local).AddTicks(1512));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 264,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 8, 8, 22, 228, DateTimeKind.Local).AddTicks(1516));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 265,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 8, 28, 22, 228, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 266,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 8, 48, 22, 228, DateTimeKind.Local).AddTicks(1525));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 267,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 9, 8, 22, 228, DateTimeKind.Local).AddTicks(1529));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 268,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 9, 28, 22, 228, DateTimeKind.Local).AddTicks(1533));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 269,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 9, 48, 22, 228, DateTimeKind.Local).AddTicks(1537));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 270,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 10, 8, 22, 228, DateTimeKind.Local).AddTicks(1541));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 271,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 10, 28, 22, 228, DateTimeKind.Local).AddTicks(1545));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 272,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 10, 48, 22, 228, DateTimeKind.Local).AddTicks(1549));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 273,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 11, 8, 22, 228, DateTimeKind.Local).AddTicks(1553));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 274,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 11, 28, 22, 228, DateTimeKind.Local).AddTicks(1557));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 275,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 11, 48, 22, 228, DateTimeKind.Local).AddTicks(1561));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 276,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 12, 8, 22, 228, DateTimeKind.Local).AddTicks(1565));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 277,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 12, 28, 22, 228, DateTimeKind.Local).AddTicks(1570));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 278,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 12, 48, 22, 228, DateTimeKind.Local).AddTicks(1574));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 279,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 13, 8, 22, 228, DateTimeKind.Local).AddTicks(1578));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 280,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 13, 28, 22, 228, DateTimeKind.Local).AddTicks(1582));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 281,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 13, 48, 22, 228, DateTimeKind.Local).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 282,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 14, 8, 22, 228, DateTimeKind.Local).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 283,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 14, 28, 22, 228, DateTimeKind.Local).AddTicks(1594));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 284,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 14, 48, 22, 228, DateTimeKind.Local).AddTicks(1598));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 285,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 15, 8, 22, 228, DateTimeKind.Local).AddTicks(1602));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 286,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 15, 28, 22, 228, DateTimeKind.Local).AddTicks(1606));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 287,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 15, 48, 22, 228, DateTimeKind.Local).AddTicks(1610));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 288,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 16, 8, 22, 228, DateTimeKind.Local).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 289,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 16, 28, 22, 228, DateTimeKind.Local).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 290,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 16, 48, 22, 228, DateTimeKind.Local).AddTicks(1622));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 291,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 17, 8, 22, 228, DateTimeKind.Local).AddTicks(1626));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 292,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 17, 28, 22, 228, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 293,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 17, 48, 22, 228, DateTimeKind.Local).AddTicks(1634));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 294,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 18, 8, 22, 228, DateTimeKind.Local).AddTicks(1687));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 295,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 18, 28, 22, 228, DateTimeKind.Local).AddTicks(1692));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 296,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 18, 48, 22, 228, DateTimeKind.Local).AddTicks(1696));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 297,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 19, 8, 22, 228, DateTimeKind.Local).AddTicks(1700));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 298,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 19, 28, 22, 228, DateTimeKind.Local).AddTicks(1704));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 299,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 19, 48, 22, 228, DateTimeKind.Local).AddTicks(1708));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 300,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 20, 8, 22, 228, DateTimeKind.Local).AddTicks(1712));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 301,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 20, 28, 22, 228, DateTimeKind.Local).AddTicks(1716));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 302,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 20, 48, 22, 228, DateTimeKind.Local).AddTicks(1720));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 303,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 21, 8, 22, 228, DateTimeKind.Local).AddTicks(1724));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 304,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 21, 28, 22, 228, DateTimeKind.Local).AddTicks(1728));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 305,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 21, 48, 22, 228, DateTimeKind.Local).AddTicks(1732));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 306,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 22, 8, 22, 228, DateTimeKind.Local).AddTicks(1736));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 307,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 22, 28, 22, 228, DateTimeKind.Local).AddTicks(1741));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 308,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 22, 48, 22, 228, DateTimeKind.Local).AddTicks(1745));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 309,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 23, 8, 22, 228, DateTimeKind.Local).AddTicks(1749));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 310,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 23, 28, 22, 228, DateTimeKind.Local).AddTicks(1753));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 311,
                column: "RecordTime",
                value: new DateTime(2020, 11, 2, 23, 48, 22, 228, DateTimeKind.Local).AddTicks(1757));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 312,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 0, 8, 22, 228, DateTimeKind.Local).AddTicks(1761));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 313,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 0, 28, 22, 228, DateTimeKind.Local).AddTicks(1765));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 314,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 0, 48, 22, 228, DateTimeKind.Local).AddTicks(1769));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 315,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 1, 8, 22, 228, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 316,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 1, 28, 22, 228, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 317,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 1, 48, 22, 228, DateTimeKind.Local).AddTicks(1781));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 318,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 2, 8, 22, 228, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 319,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 2, 28, 22, 228, DateTimeKind.Local).AddTicks(1790));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 320,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 2, 48, 22, 228, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 321,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 3, 8, 22, 228, DateTimeKind.Local).AddTicks(1798));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 322,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 3, 28, 22, 228, DateTimeKind.Local).AddTicks(1802));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 323,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 3, 48, 22, 228, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 324,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 4, 8, 22, 228, DateTimeKind.Local).AddTicks(1810));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 325,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 4, 28, 22, 228, DateTimeKind.Local).AddTicks(1814));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 326,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 4, 48, 22, 228, DateTimeKind.Local).AddTicks(1818));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 327,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 5, 8, 22, 228, DateTimeKind.Local).AddTicks(1822));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 328,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 5, 28, 22, 228, DateTimeKind.Local).AddTicks(1826));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 329,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 5, 48, 22, 228, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 330,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 6, 8, 22, 228, DateTimeKind.Local).AddTicks(1834));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 331,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 6, 28, 22, 228, DateTimeKind.Local).AddTicks(1838));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 332,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 6, 48, 22, 228, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 333,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 7, 8, 22, 228, DateTimeKind.Local).AddTicks(1847));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 334,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 7, 28, 22, 228, DateTimeKind.Local).AddTicks(1851));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 335,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 7, 48, 22, 228, DateTimeKind.Local).AddTicks(1855));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 336,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 8, 8, 22, 228, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 337,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 8, 28, 22, 228, DateTimeKind.Local).AddTicks(1863));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 338,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 8, 48, 22, 228, DateTimeKind.Local).AddTicks(1868));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 339,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 9, 8, 22, 228, DateTimeKind.Local).AddTicks(1872));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 340,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 9, 28, 22, 228, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 341,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 9, 48, 22, 228, DateTimeKind.Local).AddTicks(1880));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 342,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 10, 8, 22, 228, DateTimeKind.Local).AddTicks(1884));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 343,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 10, 28, 22, 228, DateTimeKind.Local).AddTicks(1888));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 344,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 10, 48, 22, 228, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 345,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 11, 8, 22, 228, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 346,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 11, 28, 22, 228, DateTimeKind.Local).AddTicks(1901));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 347,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 11, 48, 22, 228, DateTimeKind.Local).AddTicks(1905));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 348,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 12, 8, 22, 228, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 349,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 12, 28, 22, 228, DateTimeKind.Local).AddTicks(1913));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 350,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 12, 48, 22, 228, DateTimeKind.Local).AddTicks(1917));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 351,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 13, 8, 22, 228, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 352,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 13, 28, 22, 228, DateTimeKind.Local).AddTicks(1925));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 353,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 13, 48, 22, 228, DateTimeKind.Local).AddTicks(1929));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 354,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 14, 8, 22, 228, DateTimeKind.Local).AddTicks(1933));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 355,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 14, 28, 22, 228, DateTimeKind.Local).AddTicks(1938));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 356,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 14, 48, 22, 228, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 357,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 15, 8, 22, 228, DateTimeKind.Local).AddTicks(1946));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 358,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 15, 28, 22, 228, DateTimeKind.Local).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 359,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 15, 48, 22, 228, DateTimeKind.Local).AddTicks(1954));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 360,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 16, 8, 22, 228, DateTimeKind.Local).AddTicks(1958));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 361,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 16, 28, 22, 228, DateTimeKind.Local).AddTicks(1962));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 362,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 16, 48, 22, 228, DateTimeKind.Local).AddTicks(1966));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 363,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 17, 8, 22, 228, DateTimeKind.Local).AddTicks(1970));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 364,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 17, 28, 22, 228, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 365,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 17, 48, 22, 228, DateTimeKind.Local).AddTicks(1979));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 366,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 18, 8, 22, 228, DateTimeKind.Local).AddTicks(1983));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 367,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 18, 28, 22, 228, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 368,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 18, 48, 22, 228, DateTimeKind.Local).AddTicks(1991));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 369,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 19, 8, 22, 228, DateTimeKind.Local).AddTicks(1995));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 370,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 19, 28, 22, 228, DateTimeKind.Local).AddTicks(1999));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 371,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 19, 48, 22, 228, DateTimeKind.Local).AddTicks(2003));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 372,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 20, 8, 22, 228, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 373,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 20, 28, 22, 228, DateTimeKind.Local).AddTicks(2012));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 374,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 20, 48, 22, 228, DateTimeKind.Local).AddTicks(2016));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 375,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 21, 8, 22, 228, DateTimeKind.Local).AddTicks(2020));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 376,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 21, 28, 22, 228, DateTimeKind.Local).AddTicks(2024));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 377,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 21, 48, 22, 228, DateTimeKind.Local).AddTicks(2028));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 378,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 22, 8, 22, 228, DateTimeKind.Local).AddTicks(2032));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 379,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 22, 28, 22, 228, DateTimeKind.Local).AddTicks(2037));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 380,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 22, 48, 22, 228, DateTimeKind.Local).AddTicks(2041));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 381,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 23, 8, 22, 228, DateTimeKind.Local).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 382,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 23, 28, 22, 228, DateTimeKind.Local).AddTicks(2049));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 383,
                column: "RecordTime",
                value: new DateTime(2020, 11, 3, 23, 48, 22, 228, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 384,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 0, 8, 22, 228, DateTimeKind.Local).AddTicks(2057));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 385,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 0, 28, 22, 228, DateTimeKind.Local).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 386,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 0, 48, 22, 228, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 387,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 1, 8, 22, 228, DateTimeKind.Local).AddTicks(2069));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 388,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 1, 28, 22, 228, DateTimeKind.Local).AddTicks(2074));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 389,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 1, 48, 22, 228, DateTimeKind.Local).AddTicks(2078));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 390,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 2, 8, 22, 228, DateTimeKind.Local).AddTicks(2082));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 391,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 2, 28, 22, 228, DateTimeKind.Local).AddTicks(2086));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 392,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 2, 48, 22, 228, DateTimeKind.Local).AddTicks(2090));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 393,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 3, 8, 22, 228, DateTimeKind.Local).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 394,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 3, 28, 22, 228, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 395,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 3, 48, 22, 228, DateTimeKind.Local).AddTicks(2102));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 396,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 4, 8, 22, 228, DateTimeKind.Local).AddTicks(2106));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 397,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 4, 28, 22, 228, DateTimeKind.Local).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 398,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 4, 48, 22, 228, DateTimeKind.Local).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 399,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 5, 8, 22, 228, DateTimeKind.Local).AddTicks(2119));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 400,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 5, 28, 22, 228, DateTimeKind.Local).AddTicks(2123));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 401,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 5, 48, 22, 228, DateTimeKind.Local).AddTicks(2127));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 402,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 6, 8, 22, 228, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 403,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 6, 28, 22, 228, DateTimeKind.Local).AddTicks(2135));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 404,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 6, 48, 22, 228, DateTimeKind.Local).AddTicks(2140));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 405,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 7, 8, 22, 228, DateTimeKind.Local).AddTicks(2144));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 406,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 7, 28, 22, 228, DateTimeKind.Local).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 407,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 7, 48, 22, 228, DateTimeKind.Local).AddTicks(2269));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 408,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 8, 8, 22, 228, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 409,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 8, 28, 22, 228, DateTimeKind.Local).AddTicks(2278));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 410,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 8, 48, 22, 228, DateTimeKind.Local).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 411,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 9, 8, 22, 228, DateTimeKind.Local).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 412,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 9, 28, 22, 228, DateTimeKind.Local).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 413,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 9, 48, 22, 228, DateTimeKind.Local).AddTicks(2295));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 414,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 10, 8, 22, 228, DateTimeKind.Local).AddTicks(2299));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 415,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 10, 28, 22, 228, DateTimeKind.Local).AddTicks(2303));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 416,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 10, 48, 22, 228, DateTimeKind.Local).AddTicks(2307));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 417,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 11, 8, 22, 228, DateTimeKind.Local).AddTicks(2311));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 418,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 11, 28, 22, 228, DateTimeKind.Local).AddTicks(2315));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 419,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 11, 48, 22, 228, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 420,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 12, 8, 22, 228, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 421,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 12, 28, 22, 228, DateTimeKind.Local).AddTicks(2327));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 422,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 12, 48, 22, 228, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 423,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 13, 8, 22, 228, DateTimeKind.Local).AddTicks(2336));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 424,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 13, 28, 22, 228, DateTimeKind.Local).AddTicks(2340));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 425,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 13, 48, 22, 228, DateTimeKind.Local).AddTicks(2344));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 426,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 14, 8, 22, 228, DateTimeKind.Local).AddTicks(2348));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 427,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 14, 28, 22, 228, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 428,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 14, 48, 22, 228, DateTimeKind.Local).AddTicks(2356));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 429,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 15, 8, 22, 228, DateTimeKind.Local).AddTicks(2360));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 430,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 15, 28, 22, 228, DateTimeKind.Local).AddTicks(2364));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 431,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 15, 48, 22, 228, DateTimeKind.Local).AddTicks(2368));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 432,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 16, 8, 22, 228, DateTimeKind.Local).AddTicks(2372));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 433,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 16, 28, 22, 228, DateTimeKind.Local).AddTicks(2376));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 434,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 16, 48, 22, 228, DateTimeKind.Local).AddTicks(2381));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 435,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 17, 8, 22, 228, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 436,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 17, 28, 22, 228, DateTimeKind.Local).AddTicks(2389));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 437,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 17, 48, 22, 228, DateTimeKind.Local).AddTicks(2393));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 438,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 18, 8, 22, 228, DateTimeKind.Local).AddTicks(2397));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 439,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 18, 28, 22, 228, DateTimeKind.Local).AddTicks(2401));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 440,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 18, 48, 22, 228, DateTimeKind.Local).AddTicks(2405));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 441,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 19, 8, 22, 228, DateTimeKind.Local).AddTicks(2410));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 442,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 19, 28, 22, 228, DateTimeKind.Local).AddTicks(2414));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 443,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 19, 48, 22, 228, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 444,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 20, 8, 22, 228, DateTimeKind.Local).AddTicks(2422));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 445,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 20, 28, 22, 228, DateTimeKind.Local).AddTicks(2426));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 446,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 20, 48, 22, 228, DateTimeKind.Local).AddTicks(2430));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 447,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 21, 8, 22, 228, DateTimeKind.Local).AddTicks(2434));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 448,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 21, 28, 22, 228, DateTimeKind.Local).AddTicks(2438));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 449,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 21, 48, 22, 228, DateTimeKind.Local).AddTicks(2442));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 450,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 22, 8, 22, 228, DateTimeKind.Local).AddTicks(2447));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 451,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 22, 28, 22, 228, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 452,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 22, 48, 22, 228, DateTimeKind.Local).AddTicks(2455));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 453,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 23, 8, 22, 228, DateTimeKind.Local).AddTicks(2459));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 454,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 23, 28, 22, 228, DateTimeKind.Local).AddTicks(2463));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 455,
                column: "RecordTime",
                value: new DateTime(2020, 11, 4, 23, 48, 22, 228, DateTimeKind.Local).AddTicks(2467));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 456,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 0, 8, 22, 228, DateTimeKind.Local).AddTicks(2471));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 457,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 0, 28, 22, 228, DateTimeKind.Local).AddTicks(2475));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 458,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 0, 48, 22, 228, DateTimeKind.Local).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 459,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 1, 8, 22, 228, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 460,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 1, 28, 22, 228, DateTimeKind.Local).AddTicks(2488));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 461,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 1, 48, 22, 228, DateTimeKind.Local).AddTicks(2492));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 462,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 2, 8, 22, 228, DateTimeKind.Local).AddTicks(2496));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 463,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 2, 28, 22, 228, DateTimeKind.Local).AddTicks(2500));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 464,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 2, 48, 22, 228, DateTimeKind.Local).AddTicks(2504));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 465,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 3, 8, 22, 228, DateTimeKind.Local).AddTicks(2508));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 466,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 3, 28, 22, 228, DateTimeKind.Local).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 467,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 3, 48, 22, 228, DateTimeKind.Local).AddTicks(2516));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 468,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 4, 8, 22, 228, DateTimeKind.Local).AddTicks(2521));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 469,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 4, 28, 22, 228, DateTimeKind.Local).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 470,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 4, 48, 22, 228, DateTimeKind.Local).AddTicks(2529));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 471,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 5, 8, 22, 228, DateTimeKind.Local).AddTicks(2533));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 472,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 5, 28, 22, 228, DateTimeKind.Local).AddTicks(2537));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 473,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 5, 48, 22, 228, DateTimeKind.Local).AddTicks(2541));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 474,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 6, 8, 22, 228, DateTimeKind.Local).AddTicks(2545));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 475,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 6, 28, 22, 228, DateTimeKind.Local).AddTicks(2549));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 476,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 6, 48, 22, 228, DateTimeKind.Local).AddTicks(2553));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 477,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 7, 8, 22, 228, DateTimeKind.Local).AddTicks(2558));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 478,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 7, 28, 22, 228, DateTimeKind.Local).AddTicks(2562));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 479,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 7, 48, 22, 228, DateTimeKind.Local).AddTicks(2566));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 480,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 8, 8, 22, 228, DateTimeKind.Local).AddTicks(2570));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 481,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 8, 28, 22, 228, DateTimeKind.Local).AddTicks(2574));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 482,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 8, 48, 22, 228, DateTimeKind.Local).AddTicks(2578));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 483,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 9, 8, 22, 228, DateTimeKind.Local).AddTicks(2582));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 484,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 9, 28, 22, 228, DateTimeKind.Local).AddTicks(2586));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 485,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 9, 48, 22, 228, DateTimeKind.Local).AddTicks(2590));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 486,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 10, 8, 22, 228, DateTimeKind.Local).AddTicks(2594));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 487,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 10, 28, 22, 228, DateTimeKind.Local).AddTicks(2599));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 488,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 10, 48, 22, 228, DateTimeKind.Local).AddTicks(2603));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 489,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 11, 8, 22, 228, DateTimeKind.Local).AddTicks(2607));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 490,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 11, 28, 22, 228, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 491,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 11, 48, 22, 228, DateTimeKind.Local).AddTicks(2615));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 492,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 12, 8, 22, 228, DateTimeKind.Local).AddTicks(2619));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 493,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 12, 28, 22, 228, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 494,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 12, 48, 22, 228, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 495,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 13, 8, 22, 228, DateTimeKind.Local).AddTicks(2631));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 496,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 13, 28, 22, 228, DateTimeKind.Local).AddTicks(2635));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 497,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 13, 48, 22, 228, DateTimeKind.Local).AddTicks(2639));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 498,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 14, 8, 22, 228, DateTimeKind.Local).AddTicks(2644));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 499,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 14, 28, 22, 228, DateTimeKind.Local).AddTicks(2648));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 500,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 14, 48, 22, 228, DateTimeKind.Local).AddTicks(2652));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 501,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 15, 8, 22, 228, DateTimeKind.Local).AddTicks(2656));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 502,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 15, 28, 22, 228, DateTimeKind.Local).AddTicks(2660));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 503,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 15, 48, 22, 228, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 504,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 16, 8, 22, 228, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 505,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 16, 28, 22, 228, DateTimeKind.Local).AddTicks(2673));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 506,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 16, 48, 22, 228, DateTimeKind.Local).AddTicks(2677));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 507,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 17, 8, 22, 228, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 508,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 17, 28, 22, 228, DateTimeKind.Local).AddTicks(2685));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 509,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 17, 48, 22, 228, DateTimeKind.Local).AddTicks(2689));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 510,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 18, 8, 22, 228, DateTimeKind.Local).AddTicks(2693));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 511,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 18, 28, 22, 228, DateTimeKind.Local).AddTicks(2697));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 512,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 18, 48, 22, 228, DateTimeKind.Local).AddTicks(2701));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 513,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 19, 8, 22, 228, DateTimeKind.Local).AddTicks(2705));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 514,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 19, 28, 22, 228, DateTimeKind.Local).AddTicks(2782));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 515,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 19, 48, 22, 228, DateTimeKind.Local).AddTicks(2787));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 516,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 20, 8, 22, 228, DateTimeKind.Local).AddTicks(2791));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 517,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 20, 28, 22, 228, DateTimeKind.Local).AddTicks(2795));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 518,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 20, 48, 22, 228, DateTimeKind.Local).AddTicks(2799));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 519,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 21, 8, 22, 228, DateTimeKind.Local).AddTicks(2803));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 520,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 21, 28, 22, 228, DateTimeKind.Local).AddTicks(2807));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 521,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 21, 48, 22, 228, DateTimeKind.Local).AddTicks(2879));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 522,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 22, 8, 22, 228, DateTimeKind.Local).AddTicks(2884));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 523,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 22, 28, 22, 228, DateTimeKind.Local).AddTicks(2888));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 524,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 22, 48, 22, 228, DateTimeKind.Local).AddTicks(2892));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 525,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 23, 8, 22, 228, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 526,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 23, 28, 22, 228, DateTimeKind.Local).AddTicks(2901));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 527,
                column: "RecordTime",
                value: new DateTime(2020, 11, 5, 23, 48, 22, 228, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 528,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 0, 8, 22, 228, DateTimeKind.Local).AddTicks(2909));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 529,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 0, 28, 22, 228, DateTimeKind.Local).AddTicks(2913));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 530,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 0, 48, 22, 228, DateTimeKind.Local).AddTicks(2917));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 531,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 1, 8, 22, 228, DateTimeKind.Local).AddTicks(2921));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 532,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 1, 28, 22, 228, DateTimeKind.Local).AddTicks(2926));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 533,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 1, 48, 22, 228, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 534,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 2, 8, 22, 228, DateTimeKind.Local).AddTicks(2934));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 535,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 2, 28, 22, 228, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 536,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 2, 48, 22, 228, DateTimeKind.Local).AddTicks(2942));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 537,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 3, 8, 22, 228, DateTimeKind.Local).AddTicks(2946));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 538,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 3, 28, 22, 228, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 539,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 3, 48, 22, 228, DateTimeKind.Local).AddTicks(2954));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 540,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 4, 8, 22, 228, DateTimeKind.Local).AddTicks(2958));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 541,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 4, 28, 22, 228, DateTimeKind.Local).AddTicks(2962));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 542,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 4, 48, 22, 228, DateTimeKind.Local).AddTicks(2967));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 543,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 5, 8, 22, 228, DateTimeKind.Local).AddTicks(2971));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 544,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 5, 28, 22, 228, DateTimeKind.Local).AddTicks(2975));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 545,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 5, 48, 22, 228, DateTimeKind.Local).AddTicks(2979));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 546,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 6, 8, 22, 228, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 547,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 6, 28, 22, 228, DateTimeKind.Local).AddTicks(2987));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 548,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 6, 48, 22, 228, DateTimeKind.Local).AddTicks(2991));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 549,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 7, 8, 22, 228, DateTimeKind.Local).AddTicks(2995));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 550,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 7, 28, 22, 228, DateTimeKind.Local).AddTicks(2999));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 551,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 7, 48, 22, 228, DateTimeKind.Local).AddTicks(3003));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 552,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 8, 8, 22, 228, DateTimeKind.Local).AddTicks(3008));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 553,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 8, 28, 22, 228, DateTimeKind.Local).AddTicks(3012));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 554,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 8, 48, 22, 228, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 555,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 9, 8, 22, 228, DateTimeKind.Local).AddTicks(3020));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 556,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 9, 28, 22, 228, DateTimeKind.Local).AddTicks(3024));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 557,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 9, 48, 22, 228, DateTimeKind.Local).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 558,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 10, 8, 22, 228, DateTimeKind.Local).AddTicks(3032));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 559,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 10, 28, 22, 228, DateTimeKind.Local).AddTicks(3036));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 560,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 10, 48, 22, 228, DateTimeKind.Local).AddTicks(3040));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 561,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 11, 8, 22, 228, DateTimeKind.Local).AddTicks(3044));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 562,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 11, 28, 22, 228, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 563,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 11, 48, 22, 228, DateTimeKind.Local).AddTicks(3053));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 564,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 12, 8, 22, 228, DateTimeKind.Local).AddTicks(3057));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 565,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 12, 28, 22, 228, DateTimeKind.Local).AddTicks(3061));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 566,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 12, 48, 22, 228, DateTimeKind.Local).AddTicks(3065));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 567,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 13, 8, 22, 228, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 568,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 13, 28, 22, 228, DateTimeKind.Local).AddTicks(3073));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 569,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 13, 48, 22, 228, DateTimeKind.Local).AddTicks(3077));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 570,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 14, 8, 22, 228, DateTimeKind.Local).AddTicks(3081));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 571,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 14, 28, 22, 228, DateTimeKind.Local).AddTicks(3086));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 572,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 14, 48, 22, 228, DateTimeKind.Local).AddTicks(3090));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 573,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 15, 8, 22, 228, DateTimeKind.Local).AddTicks(3094));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 574,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 15, 28, 22, 228, DateTimeKind.Local).AddTicks(3098));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 575,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 15, 48, 22, 228, DateTimeKind.Local).AddTicks(3102));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 576,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 16, 8, 22, 228, DateTimeKind.Local).AddTicks(3106));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 577,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 16, 28, 22, 228, DateTimeKind.Local).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 578,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 16, 48, 22, 228, DateTimeKind.Local).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 579,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 17, 8, 22, 228, DateTimeKind.Local).AddTicks(3119));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 580,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 17, 28, 22, 228, DateTimeKind.Local).AddTicks(3123));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 581,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 17, 48, 22, 228, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 582,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 18, 8, 22, 228, DateTimeKind.Local).AddTicks(3131));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 583,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 18, 28, 22, 228, DateTimeKind.Local).AddTicks(3135));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 584,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 18, 48, 22, 228, DateTimeKind.Local).AddTicks(3139));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 585,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 19, 8, 22, 228, DateTimeKind.Local).AddTicks(3143));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 586,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 19, 28, 22, 228, DateTimeKind.Local).AddTicks(3147));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 587,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 19, 48, 22, 228, DateTimeKind.Local).AddTicks(3151));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 588,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 20, 8, 22, 228, DateTimeKind.Local).AddTicks(3155));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 589,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 20, 28, 22, 228, DateTimeKind.Local).AddTicks(3159));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 590,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 20, 48, 22, 228, DateTimeKind.Local).AddTicks(3163));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 591,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 21, 8, 22, 228, DateTimeKind.Local).AddTicks(3167));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 592,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 21, 28, 22, 228, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 593,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 21, 48, 22, 228, DateTimeKind.Local).AddTicks(3175));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 594,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 22, 8, 22, 228, DateTimeKind.Local).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 595,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 22, 28, 22, 228, DateTimeKind.Local).AddTicks(3183));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 596,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 22, 48, 22, 228, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 597,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 23, 8, 22, 228, DateTimeKind.Local).AddTicks(3191));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 598,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 23, 28, 22, 228, DateTimeKind.Local).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 599,
                column: "RecordTime",
                value: new DateTime(2020, 11, 6, 23, 48, 22, 228, DateTimeKind.Local).AddTicks(3200));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 600,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 0, 8, 22, 228, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 601,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 0, 28, 22, 228, DateTimeKind.Local).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 602,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 0, 48, 22, 228, DateTimeKind.Local).AddTicks(3212));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 603,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 1, 8, 22, 228, DateTimeKind.Local).AddTicks(3216));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 604,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 1, 28, 22, 228, DateTimeKind.Local).AddTicks(3220));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 605,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 1, 48, 22, 228, DateTimeKind.Local).AddTicks(3224));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 606,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 2, 8, 22, 228, DateTimeKind.Local).AddTicks(3228));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 607,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 2, 28, 22, 228, DateTimeKind.Local).AddTicks(3232));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 608,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 2, 48, 22, 228, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 609,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 3, 8, 22, 228, DateTimeKind.Local).AddTicks(3240));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 610,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 3, 28, 22, 228, DateTimeKind.Local).AddTicks(3244));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 611,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 3, 48, 22, 228, DateTimeKind.Local).AddTicks(3248));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 612,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 4, 8, 22, 228, DateTimeKind.Local).AddTicks(3252));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 613,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 4, 28, 22, 228, DateTimeKind.Local).AddTicks(3256));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 614,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 4, 48, 22, 228, DateTimeKind.Local).AddTicks(3260));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 615,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 5, 8, 22, 228, DateTimeKind.Local).AddTicks(3264));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 616,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 5, 28, 22, 228, DateTimeKind.Local).AddTicks(3268));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 617,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 5, 48, 22, 228, DateTimeKind.Local).AddTicks(3272));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 618,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 6, 8, 22, 228, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 619,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 6, 28, 22, 228, DateTimeKind.Local).AddTicks(3281));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 620,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 6, 48, 22, 228, DateTimeKind.Local).AddTicks(3285));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 621,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 7, 8, 22, 228, DateTimeKind.Local).AddTicks(3289));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 622,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 7, 28, 22, 228, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 623,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 7, 48, 22, 228, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 624,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 8, 8, 22, 228, DateTimeKind.Local).AddTicks(3301));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 625,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 8, 28, 22, 228, DateTimeKind.Local).AddTicks(3305));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 626,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 8, 48, 22, 228, DateTimeKind.Local).AddTicks(3309));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 627,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 9, 8, 22, 228, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 628,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 9, 28, 22, 228, DateTimeKind.Local).AddTicks(3317));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 629,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 9, 48, 22, 228, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 630,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 10, 8, 22, 228, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 631,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 10, 28, 22, 228, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 632,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 10, 48, 22, 228, DateTimeKind.Local).AddTicks(3334));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 633,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 11, 8, 22, 228, DateTimeKind.Local).AddTicks(3338));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 634,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 11, 28, 22, 228, DateTimeKind.Local).AddTicks(3389));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 635,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 11, 48, 22, 228, DateTimeKind.Local).AddTicks(3394));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 636,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 12, 8, 22, 228, DateTimeKind.Local).AddTicks(3398));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 637,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 12, 28, 22, 228, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 638,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 12, 48, 22, 228, DateTimeKind.Local).AddTicks(3406));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 639,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 13, 8, 22, 228, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 640,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 13, 28, 22, 228, DateTimeKind.Local).AddTicks(3414));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 641,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 13, 48, 22, 228, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 642,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 14, 8, 22, 228, DateTimeKind.Local).AddTicks(3422));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 643,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 14, 28, 22, 228, DateTimeKind.Local).AddTicks(3427));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 644,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 14, 48, 22, 228, DateTimeKind.Local).AddTicks(3431));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 645,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 15, 8, 22, 228, DateTimeKind.Local).AddTicks(3435));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 646,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 15, 28, 22, 228, DateTimeKind.Local).AddTicks(3439));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 647,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 15, 48, 22, 228, DateTimeKind.Local).AddTicks(3443));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 648,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 16, 8, 22, 228, DateTimeKind.Local).AddTicks(3447));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 649,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 16, 28, 22, 228, DateTimeKind.Local).AddTicks(3451));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 650,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 16, 48, 22, 228, DateTimeKind.Local).AddTicks(3455));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 651,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 17, 8, 22, 228, DateTimeKind.Local).AddTicks(3459));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 652,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 17, 28, 22, 228, DateTimeKind.Local).AddTicks(3463));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 653,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 17, 48, 22, 228, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 654,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 18, 8, 22, 228, DateTimeKind.Local).AddTicks(3472));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 655,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 18, 28, 22, 228, DateTimeKind.Local).AddTicks(3476));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 656,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 18, 48, 22, 228, DateTimeKind.Local).AddTicks(3480));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 657,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 19, 8, 22, 228, DateTimeKind.Local).AddTicks(3484));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 658,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 19, 28, 22, 228, DateTimeKind.Local).AddTicks(3488));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 659,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 19, 48, 22, 228, DateTimeKind.Local).AddTicks(3492));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 660,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 20, 8, 22, 228, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 661,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 20, 28, 22, 228, DateTimeKind.Local).AddTicks(3500));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 662,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 20, 48, 22, 228, DateTimeKind.Local).AddTicks(3504));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 663,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 21, 8, 22, 228, DateTimeKind.Local).AddTicks(3508));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 664,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 21, 28, 22, 228, DateTimeKind.Local).AddTicks(3512));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 665,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 21, 48, 22, 228, DateTimeKind.Local).AddTicks(3516));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 666,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 22, 8, 22, 228, DateTimeKind.Local).AddTicks(3521));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 667,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 22, 28, 22, 228, DateTimeKind.Local).AddTicks(3525));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 668,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 22, 48, 22, 228, DateTimeKind.Local).AddTicks(3529));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 669,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 23, 8, 22, 228, DateTimeKind.Local).AddTicks(3533));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 670,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 23, 28, 22, 228, DateTimeKind.Local).AddTicks(3537));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 671,
                column: "RecordTime",
                value: new DateTime(2020, 11, 7, 23, 48, 22, 228, DateTimeKind.Local).AddTicks(3541));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 672,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 0, 8, 22, 228, DateTimeKind.Local).AddTicks(3545));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 673,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 0, 28, 22, 228, DateTimeKind.Local).AddTicks(3549));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 674,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 0, 48, 22, 228, DateTimeKind.Local).AddTicks(3553));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 675,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 1, 8, 22, 228, DateTimeKind.Local).AddTicks(3557));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 676,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 1, 28, 22, 228, DateTimeKind.Local).AddTicks(3561));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 677,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 1, 48, 22, 228, DateTimeKind.Local).AddTicks(3565));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 678,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 2, 8, 22, 228, DateTimeKind.Local).AddTicks(3569));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 679,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 2, 28, 22, 228, DateTimeKind.Local).AddTicks(3573));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 680,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 2, 48, 22, 228, DateTimeKind.Local).AddTicks(3578));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 681,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 3, 8, 22, 228, DateTimeKind.Local).AddTicks(3582));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 682,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 3, 28, 22, 228, DateTimeKind.Local).AddTicks(3586));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 683,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 3, 48, 22, 228, DateTimeKind.Local).AddTicks(3590));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 684,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 4, 8, 22, 228, DateTimeKind.Local).AddTicks(3594));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 685,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 4, 28, 22, 228, DateTimeKind.Local).AddTicks(3598));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 686,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 4, 48, 22, 228, DateTimeKind.Local).AddTicks(3602));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 687,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 5, 8, 22, 228, DateTimeKind.Local).AddTicks(3606));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 688,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 5, 28, 22, 228, DateTimeKind.Local).AddTicks(3610));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 689,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 5, 48, 22, 228, DateTimeKind.Local).AddTicks(3614));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 690,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 6, 8, 22, 228, DateTimeKind.Local).AddTicks(3619));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 691,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 6, 28, 22, 228, DateTimeKind.Local).AddTicks(3623));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 692,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 6, 48, 22, 228, DateTimeKind.Local).AddTicks(3627));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 693,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 7, 8, 22, 228, DateTimeKind.Local).AddTicks(3631));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 694,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 7, 28, 22, 228, DateTimeKind.Local).AddTicks(3635));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 695,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 7, 48, 22, 228, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 696,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 8, 8, 22, 228, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 697,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 8, 28, 22, 228, DateTimeKind.Local).AddTicks(3647));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 698,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 8, 48, 22, 228, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 699,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 9, 8, 22, 228, DateTimeKind.Local).AddTicks(3655));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 700,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 9, 28, 22, 228, DateTimeKind.Local).AddTicks(3659));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 701,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 9, 48, 22, 228, DateTimeKind.Local).AddTicks(3663));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 702,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 10, 8, 22, 228, DateTimeKind.Local).AddTicks(3667));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 703,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 10, 28, 22, 228, DateTimeKind.Local).AddTicks(3671));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 704,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 10, 48, 22, 228, DateTimeKind.Local).AddTicks(3675));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 705,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 11, 8, 22, 228, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 706,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 11, 28, 22, 228, DateTimeKind.Local).AddTicks(3683));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 707,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 11, 48, 22, 228, DateTimeKind.Local).AddTicks(3687));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 708,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 12, 8, 22, 228, DateTimeKind.Local).AddTicks(3692));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 709,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 12, 28, 22, 228, DateTimeKind.Local).AddTicks(3696));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 710,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 12, 48, 22, 228, DateTimeKind.Local).AddTicks(3700));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 711,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 13, 8, 22, 228, DateTimeKind.Local).AddTicks(3704));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 712,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 13, 28, 22, 228, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 713,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 13, 48, 22, 228, DateTimeKind.Local).AddTicks(3712));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 714,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 14, 8, 22, 228, DateTimeKind.Local).AddTicks(3716));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 715,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 14, 28, 22, 228, DateTimeKind.Local).AddTicks(3720));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 716,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 14, 48, 22, 228, DateTimeKind.Local).AddTicks(3724));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 717,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 15, 8, 22, 228, DateTimeKind.Local).AddTicks(3728));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 718,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 15, 28, 22, 228, DateTimeKind.Local).AddTicks(3732));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 719,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 15, 48, 22, 228, DateTimeKind.Local).AddTicks(3737));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 720,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 16, 8, 22, 228, DateTimeKind.Local).AddTicks(3741));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 721,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 16, 28, 22, 228, DateTimeKind.Local).AddTicks(3745));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 722,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 16, 48, 22, 228, DateTimeKind.Local).AddTicks(3749));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 723,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 17, 8, 22, 228, DateTimeKind.Local).AddTicks(3753));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 724,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 17, 28, 22, 228, DateTimeKind.Local).AddTicks(3757));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 725,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 17, 48, 22, 228, DateTimeKind.Local).AddTicks(3761));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 726,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 18, 8, 22, 228, DateTimeKind.Local).AddTicks(3765));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 727,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 18, 28, 22, 228, DateTimeKind.Local).AddTicks(3770));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 728,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 18, 48, 22, 228, DateTimeKind.Local).AddTicks(3774));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 729,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 19, 8, 22, 228, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 730,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 19, 28, 22, 228, DateTimeKind.Local).AddTicks(3782));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 731,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 19, 48, 22, 228, DateTimeKind.Local).AddTicks(3786));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 732,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 20, 8, 22, 228, DateTimeKind.Local).AddTicks(3790));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 733,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 20, 28, 22, 228, DateTimeKind.Local).AddTicks(3795));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 734,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 20, 48, 22, 228, DateTimeKind.Local).AddTicks(3799));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 735,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 21, 8, 22, 228, DateTimeKind.Local).AddTicks(3803));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 736,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 21, 28, 22, 228, DateTimeKind.Local).AddTicks(3807));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 737,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 21, 48, 22, 228, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 738,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 22, 8, 22, 228, DateTimeKind.Local).AddTicks(3816));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 739,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 22, 28, 22, 228, DateTimeKind.Local).AddTicks(3820));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 740,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 22, 48, 22, 228, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 741,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 23, 8, 22, 228, DateTimeKind.Local).AddTicks(3828));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 742,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 23, 28, 22, 228, DateTimeKind.Local).AddTicks(3832));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 743,
                column: "RecordTime",
                value: new DateTime(2020, 11, 8, 23, 48, 22, 228, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 744,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 0, 8, 22, 228, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 745,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 0, 28, 22, 228, DateTimeKind.Local).AddTicks(3844));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 746,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 0, 48, 22, 228, DateTimeKind.Local).AddTicks(3848));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 747,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 1, 8, 22, 228, DateTimeKind.Local).AddTicks(3953));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 748,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 1, 28, 22, 228, DateTimeKind.Local).AddTicks(3958));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 749,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 1, 48, 22, 228, DateTimeKind.Local).AddTicks(3962));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 750,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 2, 8, 22, 228, DateTimeKind.Local).AddTicks(3966));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 751,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 2, 28, 22, 228, DateTimeKind.Local).AddTicks(3970));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 752,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 2, 48, 22, 228, DateTimeKind.Local).AddTicks(3974));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 753,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 3, 8, 22, 228, DateTimeKind.Local).AddTicks(3978));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 754,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 3, 28, 22, 228, DateTimeKind.Local).AddTicks(3982));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 755,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 3, 48, 22, 228, DateTimeKind.Local).AddTicks(3987));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 756,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 4, 8, 22, 228, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 757,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 4, 28, 22, 228, DateTimeKind.Local).AddTicks(3995));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 758,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 4, 48, 22, 228, DateTimeKind.Local).AddTicks(3999));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 759,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 5, 8, 22, 228, DateTimeKind.Local).AddTicks(4003));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 760,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 5, 28, 22, 228, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 761,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 5, 48, 22, 228, DateTimeKind.Local).AddTicks(4011));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 762,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 6, 8, 22, 228, DateTimeKind.Local).AddTicks(4015));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 763,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 6, 28, 22, 228, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 764,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 6, 48, 22, 228, DateTimeKind.Local).AddTicks(4023));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 765,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 7, 8, 22, 228, DateTimeKind.Local).AddTicks(4027));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 766,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 7, 28, 22, 228, DateTimeKind.Local).AddTicks(4032));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 767,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 7, 48, 22, 228, DateTimeKind.Local).AddTicks(4036));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 768,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 8, 8, 22, 228, DateTimeKind.Local).AddTicks(4040));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 769,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 8, 28, 22, 228, DateTimeKind.Local).AddTicks(4044));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 770,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 8, 48, 22, 228, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 771,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 9, 8, 22, 228, DateTimeKind.Local).AddTicks(4052));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 772,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 9, 28, 22, 228, DateTimeKind.Local).AddTicks(4056));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 773,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 9, 48, 22, 228, DateTimeKind.Local).AddTicks(4060));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 774,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 10, 8, 22, 228, DateTimeKind.Local).AddTicks(4064));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 775,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 10, 28, 22, 228, DateTimeKind.Local).AddTicks(4068));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 776,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 10, 48, 22, 228, DateTimeKind.Local).AddTicks(4072));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 777,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 11, 8, 22, 228, DateTimeKind.Local).AddTicks(4077));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 778,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 11, 28, 22, 228, DateTimeKind.Local).AddTicks(4081));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 779,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 11, 48, 22, 228, DateTimeKind.Local).AddTicks(4085));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 780,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 12, 8, 22, 228, DateTimeKind.Local).AddTicks(4089));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 781,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 12, 28, 22, 228, DateTimeKind.Local).AddTicks(4093));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 782,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 12, 48, 22, 228, DateTimeKind.Local).AddTicks(4097));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 783,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 13, 8, 22, 228, DateTimeKind.Local).AddTicks(4101));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 784,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 13, 28, 22, 228, DateTimeKind.Local).AddTicks(4106));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 785,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 13, 48, 22, 228, DateTimeKind.Local).AddTicks(4110));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 786,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 14, 8, 22, 228, DateTimeKind.Local).AddTicks(4114));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 787,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 14, 28, 22, 228, DateTimeKind.Local).AddTicks(4118));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 788,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 14, 48, 22, 228, DateTimeKind.Local).AddTicks(4122));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 789,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 15, 8, 22, 228, DateTimeKind.Local).AddTicks(4126));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 790,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 15, 28, 22, 228, DateTimeKind.Local).AddTicks(4130));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 791,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 15, 48, 22, 228, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 792,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 16, 8, 22, 228, DateTimeKind.Local).AddTicks(4138));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 793,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 16, 28, 22, 228, DateTimeKind.Local).AddTicks(4142));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 794,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 16, 48, 22, 228, DateTimeKind.Local).AddTicks(4146));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 795,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 17, 8, 22, 228, DateTimeKind.Local).AddTicks(4151));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 796,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 17, 28, 22, 228, DateTimeKind.Local).AddTicks(4155));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 797,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 17, 48, 22, 228, DateTimeKind.Local).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 798,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 18, 8, 22, 228, DateTimeKind.Local).AddTicks(4163));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 799,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 18, 28, 22, 228, DateTimeKind.Local).AddTicks(4167));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 800,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 18, 48, 22, 228, DateTimeKind.Local).AddTicks(4171));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 801,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 19, 8, 22, 228, DateTimeKind.Local).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 802,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 19, 28, 22, 228, DateTimeKind.Local).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 803,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 19, 48, 22, 228, DateTimeKind.Local).AddTicks(4183));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 804,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 20, 8, 22, 228, DateTimeKind.Local).AddTicks(4187));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 805,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 20, 28, 22, 228, DateTimeKind.Local).AddTicks(4191));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 806,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 20, 48, 22, 228, DateTimeKind.Local).AddTicks(4195));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 807,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 21, 8, 22, 228, DateTimeKind.Local).AddTicks(4199));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 808,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 21, 28, 22, 228, DateTimeKind.Local).AddTicks(4204));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 809,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 21, 48, 22, 228, DateTimeKind.Local).AddTicks(4208));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 810,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 22, 8, 22, 228, DateTimeKind.Local).AddTicks(4212));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 811,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 22, 28, 22, 228, DateTimeKind.Local).AddTicks(4216));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 812,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 22, 48, 22, 228, DateTimeKind.Local).AddTicks(4220));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 813,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 23, 8, 22, 228, DateTimeKind.Local).AddTicks(4224));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 814,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 23, 28, 22, 228, DateTimeKind.Local).AddTicks(4228));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 815,
                column: "RecordTime",
                value: new DateTime(2020, 11, 9, 23, 48, 22, 228, DateTimeKind.Local).AddTicks(4233));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 816,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 0, 8, 22, 228, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 817,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 0, 28, 22, 228, DateTimeKind.Local).AddTicks(4241));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 818,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 0, 48, 22, 228, DateTimeKind.Local).AddTicks(4245));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 819,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 1, 8, 22, 228, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 820,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 1, 28, 22, 228, DateTimeKind.Local).AddTicks(4253));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 821,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 1, 48, 22, 228, DateTimeKind.Local).AddTicks(4257));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 822,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 2, 8, 22, 228, DateTimeKind.Local).AddTicks(4261));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 823,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 2, 28, 22, 228, DateTimeKind.Local).AddTicks(4265));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 824,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 2, 48, 22, 228, DateTimeKind.Local).AddTicks(4269));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 825,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 3, 8, 22, 228, DateTimeKind.Local).AddTicks(4274));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 826,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 3, 28, 22, 228, DateTimeKind.Local).AddTicks(4278));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 827,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 3, 48, 22, 228, DateTimeKind.Local).AddTicks(4282));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 828,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 4, 8, 22, 228, DateTimeKind.Local).AddTicks(4286));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 829,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 4, 28, 22, 228, DateTimeKind.Local).AddTicks(4290));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 830,
                column: "RecordTime",
                value: new DateTime(2020, 11, 10, 4, 48, 22, 228, DateTimeKind.Local).AddTicks(4294));
        }
    }
}
