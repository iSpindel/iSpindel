using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace iSpindel.Database.Migrations
{
    public partial class additionalColumns : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "End",
                table: "DataSeries",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "Start",
                table: "DataSeries",
                nullable: true);

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
                columns: new[] { "RecordTime", "Temperature" },
                values: new object[] { new DateTime(2020, 10, 30, 2, 8, 22, 227, DateTimeKind.Local).AddTicks(8614), 18.45491502812526 });

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
                columns: new[] { "RecordTime", "Temperature" },
                values: new object[] { new DateTime(2020, 10, 31, 9, 48, 22, 228, DateTimeKind.Local).AddTicks(846), 23.365062567548865 });

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
                columns: new[] { "RecordTime", "Temperature" },
                values: new object[] { new DateTime(2020, 10, 31, 23, 8, 22, 228, DateTimeKind.Local).AddTicks(1061), 24.343157572190957 });

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
                columns: new[] { "RecordTime", "Temperature" },
                values: new object[] { new DateTime(2020, 11, 1, 5, 48, 22, 228, DateTimeKind.Local).AddTicks(1143), 24.677220154149335 });

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
                columns: new[] { "RecordTime", "Temperature" },
                values: new object[] { new DateTime(2020, 11, 3, 0, 48, 22, 228, DateTimeKind.Local).AddTicks(1769), 23.974721766937552 });

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
                columns: new[] { "RecordTime", "Temperature" },
                values: new object[] { new DateTime(2020, 11, 6, 11, 8, 22, 228, DateTimeKind.Local).AddTicks(3044), 15.736799178229541 });

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
                columns: new[] { "RecordTime", "Temperature" },
                values: new object[] { new DateTime(2020, 11, 9, 15, 48, 22, 228, DateTimeKind.Local).AddTicks(4134), 18.45491502812526 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "End",
                table: "DataSeries");

            migrationBuilder.DropColumn(
                name: "Start",
                table: "DataSeries");

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 11,
                column: "RecordTime",
                value: new DateTime(2020, 5, 31, 23, 13, 50, 610, DateTimeKind.Local).AddTicks(8360));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 12,
                column: "RecordTime",
                value: new DateTime(2020, 5, 31, 23, 33, 50, 613, DateTimeKind.Local).AddTicks(8051));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 13,
                column: "RecordTime",
                value: new DateTime(2020, 5, 31, 23, 53, 50, 613, DateTimeKind.Local).AddTicks(8187));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 14,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 0, 13, 50, 613, DateTimeKind.Local).AddTicks(8208));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 15,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 0, 33, 50, 613, DateTimeKind.Local).AddTicks(8220));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 16,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 0, 53, 50, 613, DateTimeKind.Local).AddTicks(8232));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 17,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 1, 13, 50, 613, DateTimeKind.Local).AddTicks(8245));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 18,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 1, 33, 50, 613, DateTimeKind.Local).AddTicks(8262));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 19,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 1, 53, 50, 613, DateTimeKind.Local).AddTicks(8358));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 20,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 2, 13, 50, 613, DateTimeKind.Local).AddTicks(8375));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 21,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 2, 33, 50, 613, DateTimeKind.Local).AddTicks(8549));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 22,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 2, 53, 50, 613, DateTimeKind.Local).AddTicks(8565));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 23,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 3, 13, 50, 613, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 24,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 3, 33, 50, 613, DateTimeKind.Local).AddTicks(8593));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 25,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 3, 53, 50, 613, DateTimeKind.Local).AddTicks(8605));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 26,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 4, 13, 50, 613, DateTimeKind.Local).AddTicks(8617));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 27,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 4, 33, 50, 613, DateTimeKind.Local).AddTicks(8629));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 28,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 4, 53, 50, 613, DateTimeKind.Local).AddTicks(8641));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 29,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 5, 13, 50, 613, DateTimeKind.Local).AddTicks(8653));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "RecordTime", "Temperature" },
                values: new object[] { new DateTime(2020, 6, 1, 5, 33, 50, 613, DateTimeKind.Local).AddTicks(8666), 18.454915028125264 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 31,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 5, 53, 50, 613, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 32,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 6, 13, 50, 613, DateTimeKind.Local).AddTicks(9843));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 33,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 6, 33, 50, 613, DateTimeKind.Local).AddTicks(9858));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 34,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(201));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 35,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(220));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 36,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(232));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 37,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(244));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 38,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(255));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 39,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(266));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 40,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(278));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 41,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(289));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 42,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(300));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 43,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(311));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 44,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(322));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 45,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(333));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 46,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(344));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 47,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(355));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 48,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 49,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(377));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 50,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(388));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 51,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(400));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 52,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(411));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 53,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(422));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 54,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(433));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 55,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(444));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 56,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(455));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 57,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(467));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 58,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(478));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 59,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(489));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 60,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(500));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 61,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(511));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 62,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(522));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 63,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 64,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(545));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 65,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(556));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 66,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(570));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 67,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(582));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 68,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(593));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 69,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(605));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 70,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(616));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 71,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(627));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 72,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(638));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 73,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(662));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 74,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(675));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 75,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(687));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 76,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(698));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 77,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(709));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 78,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(720));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 79,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(732));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 80,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(744));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 81,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(755));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 82,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(766));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 83,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(778));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 84,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(789));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 85,
                column: "RecordTime",
                value: new DateTime(2020, 6, 1, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(800));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 86,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(811));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 87,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(823));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 88,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(834));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 89,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(846));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 90,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(858));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 91,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(869));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 92,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(880));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 93,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(893));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 94,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(932));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 95,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(945));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 96,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(957));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 97,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(968));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 98,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(980));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 99,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(991));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 100,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(1002));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 101,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(1013));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 102,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(1024));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 103,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(1036));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 104,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(1047));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 105,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(1059));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 106,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(1070));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 107,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(1081));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 108,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(1093));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 109,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(1104));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 110,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(1115));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 111,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(1126));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 112,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(1166));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 113,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(1179));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 114,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(1190));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 115,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(1203));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 116,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(1214));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 117,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(1225));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 118,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(1236));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 119,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(1247));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 120,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(1258));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 121,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(1270));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 122,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(1281));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 123,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(1292));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 124,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(1303));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 125,
                columns: new[] { "RecordTime", "Temperature" },
                values: new object[] { new DateTime(2020, 6, 2, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(1314), 23.365062567548868 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 126,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(1447));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 127,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(1496));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 128,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(1520));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 129,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(1539));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 130,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(1580));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 131,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(1630));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 132,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(1648));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 133,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(1660));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 134,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 135,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(1750));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 136,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(1762));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 137,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(1773));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 138,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(1785));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 139,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(1796));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 140,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(1808));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 141,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 142,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(1831));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 143,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(1842));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 144,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(1853));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 145,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 146,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 147,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(1886));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 148,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(1897));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 149,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(1908));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 150,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(1919));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 151,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(1930));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 152,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(1942));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 153,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(1953));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 154,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(1964));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 155,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 156,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(1986));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 157,
                column: "RecordTime",
                value: new DateTime(2020, 6, 2, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(1997));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 158,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(2008));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 159,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 160,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(2031));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 161,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(2042));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 162,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(2053));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 163,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(2065));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 164,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 165,
                columns: new[] { "RecordTime", "Temperature" },
                values: new object[] { new DateTime(2020, 6, 3, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(2087), 24.343157572190954 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 166,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(2098));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 167,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(2109));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 168,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(2120));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 169,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(2131));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 170,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 171,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(2153));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 172,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(2164));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 173,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(2175));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 174,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(2186));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 175,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(2197));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 176,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 177,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(2219));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 178,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(2230));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 179,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(2241));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 180,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(2252));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 181,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(2263));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 182,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(2274));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 183,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 184,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(2296));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 185,
                columns: new[] { "RecordTime", "Temperature" },
                values: new object[] { new DateTime(2020, 6, 3, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(2308), 24.677220154149339 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 186,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(2319));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 187,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(2330));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 188,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(2341));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 189,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(2352));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 190,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(2363));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 191,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(2374));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 192,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(2385));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 193,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(2396));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 194,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(2407));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 195,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(2418));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 196,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(2429));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 197,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(2440));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 198,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(2451));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 199,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(2462));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 200,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(2473));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 201,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(2484));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 202,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(2495));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 203,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(2506));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 204,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(2517));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 205,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(2528));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 206,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(2539));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 207,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(2550));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 208,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(2561));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 209,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(2572));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 210,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(2584));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 211,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(2711));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 212,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 213,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(2738));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 214,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(2749));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 215,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(2760));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 216,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(2772));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 217,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(2783));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 218,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(2794));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 219,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(2805));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 220,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 221,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(2827));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 222,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(2838));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 223,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 224,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(2860));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 225,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(2872));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 226,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(2883));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 227,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(2894));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 228,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(2905));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 229,
                column: "RecordTime",
                value: new DateTime(2020, 6, 3, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(2916));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 230,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(2927));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 231,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(2938));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 232,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(2950));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 233,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(2961));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 234,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(2972));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 235,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(2983));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 236,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(2994));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 237,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(3005));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 238,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(3016));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 239,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(3027));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 240,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(3038));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 241,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(3049));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 242,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(3060));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 243,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(3071));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 244,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(3082));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 245,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(3093));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 246,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 247,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 248,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(3127));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 249,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(3138));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 250,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(3149));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 251,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(3160));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 252,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 253,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(3182));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 254,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(3193));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 255,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 256,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(3215));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 257,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(3226));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 258,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 259,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 260,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(3266));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 261,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(3277));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 262,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(3288));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 263,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(3299));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 264,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 265,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(3321));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 266,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(3339));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 267,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(3564));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 268,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 269,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(3605));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 270,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(3616));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 271,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(3628));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 272,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(3639));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 273,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(3651));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 274,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(3662));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 275,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(3674));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 276,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(3685));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 277,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(3697));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 278,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(3708));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 279,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(3719));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 280,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(3731));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 281,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(3743));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 282,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(3755));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 283,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(3766));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 284,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(3778));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 285,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(3789));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 286,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(3801));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 287,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(3812));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 288,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(3824));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 289,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(3835));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 290,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(3847));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 291,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(3858));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 292,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(3870));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 293,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(3881));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 294,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(3893));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 295,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 296,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(3916));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 297,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(3927));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 298,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(3938));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 299,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(3950));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 300,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(3961));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 301,
                column: "RecordTime",
                value: new DateTime(2020, 6, 4, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(3973));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 302,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(3984));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 303,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(3996));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 304,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(4007));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 305,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 306,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(4030));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 307,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(4042));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 308,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(4053));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 309,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(4065));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 310,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(4076));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 311,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(4088));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 312,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(4099));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 313,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(4111));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 314,
                columns: new[] { "RecordTime", "Temperature" },
                values: new object[] { new DateTime(2020, 6, 5, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(4123), 23.974721766937549 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 315,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(4134));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 316,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(4145));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 317,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(4157));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 318,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(4169));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 319,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(4180));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 320,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(4192));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 321,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(4203));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 322,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(4214));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 323,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(4226));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 324,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(4237));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 325,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(4249));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 326,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(4260));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 327,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(4272));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 328,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(4283));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 329,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(4295));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 330,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(4306));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 331,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(4318));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 332,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 333,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(4341));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 334,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(4352));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 335,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(4364));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 336,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(4375));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 337,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(4387));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 338,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(4398));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 339,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(4410));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 340,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(4423));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 341,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(4435));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 342,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(4446));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 343,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(4458));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 344,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(4470));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 345,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(4481));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 346,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(4493));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 347,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 348,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(4517));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 349,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(4529));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 350,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(4541));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 351,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(4553));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 352,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(4564));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 353,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(4576));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 354,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(4588));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 355,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(4599));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 356,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(4611));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 357,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(4623));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 358,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(4635));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 359,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(4646));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 360,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(4658));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 361,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(4669));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 362,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(4681));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 363,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(4693));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 364,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(4704));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 365,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(4716));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 366,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(4727));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 367,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(4739));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 368,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(4751));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 369,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(4762));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 370,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(4774));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 371,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(4785));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 372,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(4797));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 373,
                column: "RecordTime",
                value: new DateTime(2020, 6, 5, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(4809));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 374,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(4820));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 375,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(4832));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 376,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(4844));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 377,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(4855));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 378,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(4867));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 379,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(4878));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 380,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(4990));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 381,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(5006));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 382,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(5018));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 383,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(5030));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 384,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(5041));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 385,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(5053));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 386,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(5065));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 387,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(5077));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 388,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(5088));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 389,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(5100));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 390,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(5111));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 391,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(5123));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 392,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(5134));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 393,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(5145));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 394,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(5157));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 395,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(5168));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 396,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(5180));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 397,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(5191));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 398,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(5203));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 399,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(5214));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 400,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(5226));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 401,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 402,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(5249));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 403,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(5260));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 404,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(5272));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 405,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(5283));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 406,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(5295));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 407,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(5306));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 408,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(5317));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 409,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(5329));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 410,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(5341));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 411,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(5352));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 412,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(5364));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 413,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(5375));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 414,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(5386));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 415,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(5398));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 416,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(5410));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 417,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(5422));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 418,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(5433));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 419,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(5445));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 420,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(5456));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 421,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(5468));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 422,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(5479));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 423,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(5490));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 424,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(5502));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 425,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(5514));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 426,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(5525));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 427,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(5536));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 428,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(5547));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 429,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(5559));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 430,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(5570));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 431,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(5587));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 432,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(5599));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 433,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(5611));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 434,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(5622));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 435,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(5633));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 436,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(5645));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 437,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(5668));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 438,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(5680));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 439,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(5691));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 440,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(5702));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 441,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(5714));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 442,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(5725));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 443,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(5737));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 444,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(5748));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 445,
                column: "RecordTime",
                value: new DateTime(2020, 6, 6, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(5759));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 446,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(5771));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 447,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(5782));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 448,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(5794));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 449,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(5805));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 450,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(5817));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 451,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(5829));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 452,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(5840));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 453,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(5852));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 454,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(5863));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 455,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(5875));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 456,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(5886));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 457,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(5898));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 458,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(5909));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 459,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(5921));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 460,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(5932));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 461,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 462,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(5955));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 463,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(5966));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 464,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(5978));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 465,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(5989));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 466,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(6001));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 467,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(6012));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 468,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(6024));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 469,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(6035));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 470,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(6046));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 471,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(6058));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 472,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(6070));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 473,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(6081));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 474,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(6093));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 475,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(6104));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 476,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 477,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 478,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(6139));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 479,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(6150));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 480,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(6162));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 481,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 482,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(6185));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 483,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(6196));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 484,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(6208));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 485,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 486,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 487,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(6242));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 488,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(6253));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 489,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(6265));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 490,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(6276));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 491,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(6288));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 492,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(6299));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 493,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(6311));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 494,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(6438));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 495,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(6454));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 496,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 497,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(6478));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 498,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(6489));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 499,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(6501));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 500,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(6513));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 501,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(6525));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 502,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(6536));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 503,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(6548));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 504,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(6559));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 505,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(6571));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 506,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(6582));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 507,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(6594));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 508,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(6605));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 509,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 510,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(6628));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 511,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(6640));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 512,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 513,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(6663));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 514,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(6835));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 515,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(6850));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 516,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 517,
                column: "RecordTime",
                value: new DateTime(2020, 6, 7, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(6874));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 518,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(6886));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 519,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(6897));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 520,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(6909));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 521,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(6920));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 522,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(6932));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 523,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(6943));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 524,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 525,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(6966));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 526,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 527,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(6988));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 528,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(6999));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 529,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 530,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(7022));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 531,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(7033));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 532,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(7045));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 533,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(7056));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 534,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(7067));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 535,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(7079));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 536,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(7090));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 537,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(7101));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 538,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 539,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(7123));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 540,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(7134));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 541,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(7146));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 542,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(7157));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 543,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(7168));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 544,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(7180));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 545,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(7191));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 546,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(7202));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 547,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(7213));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 548,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(7225));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 549,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(7236));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 550,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(7247));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 551,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(7258));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 552,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(7270));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 553,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(7281));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 554,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(7292));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 555,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(7303));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 556,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(7315));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 557,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(7326));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 558,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(7337));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 559,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(7349));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 560,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(7360));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 561,
                columns: new[] { "RecordTime", "Temperature" },
                values: new object[] { new DateTime(2020, 6, 8, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(7371), 15.736799178229539 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 562,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(7382));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 563,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(7393));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 564,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(7405));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 565,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(7416));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 566,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(7427));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 567,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(7438));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 568,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(7450));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 569,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(7461));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 570,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 571,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 572,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(7495));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 573,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(7506));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 574,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(7517));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 575,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(7528));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 576,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(7539));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 577,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(7551));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 578,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(7562));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 579,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(7573));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 580,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 581,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(7595));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 582,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(7607));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 583,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(7618));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 584,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(7629));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 585,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(7640));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 586,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 587,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 588,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(7674));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 589,
                column: "RecordTime",
                value: new DateTime(2020, 6, 8, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(7685));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 590,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(7697));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 591,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(7708));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 592,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(7719));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 593,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(7730));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 594,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(7742));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 595,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(7753));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 596,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(7764));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 597,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(7775));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 598,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(7787));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 599,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(7798));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 600,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(7809));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 601,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(7820));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 602,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(7831));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 603,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(7843));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 604,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(7854));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 605,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(7865));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 606,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(7877));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 607,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(7963));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 608,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(7978));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 609,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(7990));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 610,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(8001));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 611,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(8013));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 612,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(8024));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 613,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(8035));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 614,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(8047));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 615,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(8058));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 616,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(8070));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 617,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(8081));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 618,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(8092));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 619,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(8103));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 620,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(8115));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 621,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(8126));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 622,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(8137));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 623,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 624,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(8160));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 625,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(8171));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 626,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(8182));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 627,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(8194));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 628,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(8205));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 629,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(8216));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 630,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(8228));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 631,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(8239));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 632,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(8250));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 633,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(8261));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 634,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(8273));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 635,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(8284));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 636,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(8295));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 637,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(8306));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 638,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(8318));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 639,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(8329));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 640,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(8340));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 641,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(8351));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 642,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(8363));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 643,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(8374));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 644,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(8385));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 645,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(8397));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 646,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(8408));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 647,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(8419));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 648,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(8431));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 649,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(8442));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 650,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(8453));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 651,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(8464));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 652,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(8476));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 653,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 654,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(8498));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 655,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(8509));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 656,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 657,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 658,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(8543));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 659,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(8554));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 660,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(8566));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 661,
                column: "RecordTime",
                value: new DateTime(2020, 6, 9, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(8577));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 662,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(8589));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 663,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(8600));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 664,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(8611));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 665,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(8622));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 666,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(8634));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 667,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(8645));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 668,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(8656));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 669,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(8668));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 670,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(8679));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 671,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 672,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 673,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(8712));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 674,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(8724));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 675,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(8735));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 676,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 677,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(8757));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 678,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(8769));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 679,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(8780));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 680,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(8791));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 681,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(8802));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 682,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 683,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(8825));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 684,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(8836));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 685,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(8847));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 686,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(8859));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 687,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 688,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(8881));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 689,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(8893));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 690,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(8904));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 691,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(8916));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 692,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(8927));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 693,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(8938));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 694,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(8949));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 695,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(8961));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 696,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(8972));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 697,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(8983));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 698,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(8995));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 699,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(9006));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 700,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 701,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 702,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(9040));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 703,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(9052));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 704,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(9063));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 705,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(9074));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 706,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(9085));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 707,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 708,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 709,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 710,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(9130));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 711,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(9142));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 712,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(9153));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 713,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(9164));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 714,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(9175));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 715,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 716,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(9198));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 717,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(9209));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 718,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(9220));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 719,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(9232));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 720,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(9502));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 721,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(9519));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 722,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(9531));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 723,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(9542));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 724,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 725,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 726,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(9577));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 727,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(9588));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 728,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(9599));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 729,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 730,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(9622));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 731,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(9633));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 732,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(9645));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 733,
                column: "RecordTime",
                value: new DateTime(2020, 6, 10, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(9656));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 734,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 735,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(9678));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 736,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(9690));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 737,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(9701));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 738,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(9712));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 739,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(9723));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 740,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 741,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 742,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(9758));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 743,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(9769));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 744,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(9780));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 745,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(9792));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 746,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(9803));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 747,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(9814));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 748,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(9825));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 749,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(9836));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 750,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(9848));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 751,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(9859));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 752,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(9870));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 753,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(9881));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 754,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(9893));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 755,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(9904));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 756,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(9915));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 757,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(9926));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 758,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(9937));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 759,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(9949));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 760,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(9960));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 761,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(9971));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 762,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(9982));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 763,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(9993));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 764,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 10, 13, 50, 615, DateTimeKind.Local).AddTicks(5));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 765,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 10, 33, 50, 615, DateTimeKind.Local).AddTicks(16));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 766,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 10, 53, 50, 615, DateTimeKind.Local).AddTicks(27));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 767,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 11, 13, 50, 615, DateTimeKind.Local).AddTicks(38));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 768,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 11, 33, 50, 615, DateTimeKind.Local).AddTicks(49));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 769,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 11, 53, 50, 615, DateTimeKind.Local).AddTicks(60));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 770,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 12, 13, 50, 615, DateTimeKind.Local).AddTicks(72));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 771,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 12, 33, 50, 615, DateTimeKind.Local).AddTicks(83));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 772,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 12, 53, 50, 615, DateTimeKind.Local).AddTicks(94));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 773,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 13, 13, 50, 615, DateTimeKind.Local).AddTicks(105));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 774,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 13, 33, 50, 615, DateTimeKind.Local).AddTicks(117));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 775,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 13, 53, 50, 615, DateTimeKind.Local).AddTicks(128));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 776,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 14, 13, 50, 615, DateTimeKind.Local).AddTicks(139));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 777,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 14, 33, 50, 615, DateTimeKind.Local).AddTicks(150));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 778,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 14, 53, 50, 615, DateTimeKind.Local).AddTicks(161));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 779,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 15, 13, 50, 615, DateTimeKind.Local).AddTicks(173));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 780,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 15, 33, 50, 615, DateTimeKind.Local).AddTicks(184));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 781,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 15, 53, 50, 615, DateTimeKind.Local).AddTicks(195));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 782,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 16, 13, 50, 615, DateTimeKind.Local).AddTicks(206));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 783,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 16, 33, 50, 615, DateTimeKind.Local).AddTicks(218));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 784,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 16, 53, 50, 615, DateTimeKind.Local).AddTicks(229));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 785,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 17, 13, 50, 615, DateTimeKind.Local).AddTicks(240));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 786,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 17, 33, 50, 615, DateTimeKind.Local).AddTicks(251));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 787,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 17, 53, 50, 615, DateTimeKind.Local).AddTicks(262));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 788,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 18, 13, 50, 615, DateTimeKind.Local).AddTicks(274));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 789,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 18, 33, 50, 615, DateTimeKind.Local).AddTicks(285));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 790,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 18, 53, 50, 615, DateTimeKind.Local).AddTicks(296));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 791,
                columns: new[] { "RecordTime", "Temperature" },
                values: new object[] { new DateTime(2020, 6, 11, 19, 13, 50, 615, DateTimeKind.Local).AddTicks(307), 18.454915028125264 });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 792,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 19, 33, 50, 615, DateTimeKind.Local).AddTicks(318));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 793,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 19, 53, 50, 615, DateTimeKind.Local).AddTicks(329));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 794,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 20, 13, 50, 615, DateTimeKind.Local).AddTicks(341));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 795,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 20, 33, 50, 615, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 796,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 20, 53, 50, 615, DateTimeKind.Local).AddTicks(363));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 797,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 21, 13, 50, 615, DateTimeKind.Local).AddTicks(374));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 798,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 21, 33, 50, 615, DateTimeKind.Local).AddTicks(385));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 799,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 21, 53, 50, 615, DateTimeKind.Local).AddTicks(397));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 800,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 22, 13, 50, 615, DateTimeKind.Local).AddTicks(408));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 801,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 22, 33, 50, 615, DateTimeKind.Local).AddTicks(419));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 802,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 22, 53, 50, 615, DateTimeKind.Local).AddTicks(430));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 803,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 23, 13, 50, 615, DateTimeKind.Local).AddTicks(441));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 804,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 23, 33, 50, 615, DateTimeKind.Local).AddTicks(453));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 805,
                column: "RecordTime",
                value: new DateTime(2020, 6, 11, 23, 53, 50, 615, DateTimeKind.Local).AddTicks(464));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 806,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 0, 13, 50, 615, DateTimeKind.Local).AddTicks(475));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 807,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 0, 33, 50, 615, DateTimeKind.Local).AddTicks(486));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 808,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 0, 53, 50, 615, DateTimeKind.Local).AddTicks(497));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 809,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 1, 13, 50, 615, DateTimeKind.Local).AddTicks(508));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 810,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 1, 33, 50, 615, DateTimeKind.Local).AddTicks(520));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 811,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 1, 53, 50, 615, DateTimeKind.Local).AddTicks(534));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 812,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 2, 13, 50, 615, DateTimeKind.Local).AddTicks(546));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 813,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 2, 33, 50, 615, DateTimeKind.Local).AddTicks(557));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 814,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 2, 53, 50, 615, DateTimeKind.Local).AddTicks(568));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 815,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 3, 13, 50, 615, DateTimeKind.Local).AddTicks(579));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 816,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 3, 33, 50, 615, DateTimeKind.Local).AddTicks(591));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 817,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 3, 53, 50, 615, DateTimeKind.Local).AddTicks(602));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 818,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 4, 13, 50, 615, DateTimeKind.Local).AddTicks(613));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 819,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 4, 33, 50, 615, DateTimeKind.Local).AddTicks(624));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 820,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 4, 53, 50, 615, DateTimeKind.Local).AddTicks(636));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 821,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 5, 13, 50, 615, DateTimeKind.Local).AddTicks(657));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 822,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 5, 33, 50, 615, DateTimeKind.Local).AddTicks(668));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 823,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 5, 53, 50, 615, DateTimeKind.Local).AddTicks(680));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 824,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 6, 13, 50, 615, DateTimeKind.Local).AddTicks(691));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 825,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 6, 33, 50, 615, DateTimeKind.Local).AddTicks(702));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 826,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 6, 53, 50, 615, DateTimeKind.Local).AddTicks(714));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 827,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 7, 13, 50, 615, DateTimeKind.Local).AddTicks(725));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 828,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 7, 33, 50, 615, DateTimeKind.Local).AddTicks(736));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 829,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 7, 53, 50, 615, DateTimeKind.Local).AddTicks(747));

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 830,
                column: "RecordTime",
                value: new DateTime(2020, 6, 12, 8, 13, 50, 615, DateTimeKind.Local).AddTicks(759));
        }
    }
}
