using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace iSpindel.Database.Migrations
{
    public partial class initial_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DataSeries",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[] { -1, "This is the default Data Series for iSpindel Projects.", "Default Data Series" });

            migrationBuilder.InsertData(
                table: "DataPoints",
                columns: new[] { "Id", "Battery", "DataSeriesId", "Gravity", "RecordTime", "Temperature" },
                values: new object[,]
                {
                    { 1, 100.0, -1, 5.0, new DateTime(2020, 5, 1, 23, 0, 0, 0, DateTimeKind.Unspecified), 24.0 },
                    { 2, 100.0, -1, 5.0, new DateTime(2020, 5, 1, 23, 5, 0, 0, DateTimeKind.Unspecified), 25.0 },
                    { 3, 95.0, -1, 7.0, new DateTime(2020, 5, 1, 23, 10, 0, 0, DateTimeKind.Unspecified), 25.0 },
                    { 4, 95.0, -1, 7.0, new DateTime(2020, 5, 1, 23, 15, 0, 0, DateTimeKind.Unspecified), 26.0 },
                    { 5, 90.0, -1, 9.0, new DateTime(2020, 5, 1, 23, 20, 0, 0, DateTimeKind.Unspecified), 26.0 },
                    { 6, 90.0, -1, 9.0, new DateTime(2020, 5, 1, 23, 25, 0, 0, DateTimeKind.Unspecified), 26.0 },
                    { 7, 90.0, -1, 15.0, new DateTime(2020, 5, 1, 23, 30, 0, 0, DateTimeKind.Unspecified), 23.0 },
                    { 8, 90.0, -1, 15.0, new DateTime(2020, 5, 1, 23, 35, 0, 0, DateTimeKind.Unspecified), 22.0 },
                    { 9, 85.0, -1, 25.0, new DateTime(2020, 5, 1, 23, 40, 0, 0, DateTimeKind.Unspecified), 21.0 },
                    { 10, 80.0, -1, 25.0, new DateTime(2020, 5, 1, 23, 45, 0, 0, DateTimeKind.Unspecified), 24.0 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "DataSeries",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
