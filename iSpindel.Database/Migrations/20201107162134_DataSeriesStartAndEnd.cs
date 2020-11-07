using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace iSpindel.Database.Migrations
{
    public partial class DataSeriesStartAndEnd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DataSeries",
                keyColumn: "Id",
                keyValue: -1,
                column: "Start",
                value: new DateTime(2020, 5, 1, 23, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "DataSeries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2020, 5, 1, 23, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 23, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DataSeries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End", "Start" },
                values: new object[] { new DateTime(2020, 5, 2, 6, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2020, 5, 1, 23, 50, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "DataSeries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Start",
                value: new DateTime(2020, 5, 1, 23, 50, 0, 0, DateTimeKind.Unspecified));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "DataSeries",
                keyColumn: "Id",
                keyValue: -1,
                column: "Start",
                value: null);

            migrationBuilder.UpdateData(
                table: "DataSeries",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "End", "Start" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "DataSeries",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "End", "Start" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "DataSeries",
                keyColumn: "Id",
                keyValue: 3,
                column: "Start",
                value: null);
        }
    }
}
