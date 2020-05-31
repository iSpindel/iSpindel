using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace iSpindel.Database.Migrations
{
    public partial class more_test_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DataSeries",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "This is the first test dataset", "Test Series 1" },
                    { 2, "This is the second test dataset", "Test Series 2" },
                    { 3, "This is the third test dataset", "Test Series 3" }
                });

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataSeriesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataSeriesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataSeriesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataSeriesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataSeriesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataSeriesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataSeriesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataSeriesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataSeriesId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataSeriesId",
                value: 1);

            migrationBuilder.InsertData(
                table: "DataPoints",
                columns: new[] { "Id", "Battery", "DataSeriesId", "Gravity", "RecordTime", "Temperature" },
                values: new object[,]
                {
                    { 551, 3.5500000000000003, 3, 6.5, new DateTime(2020, 6, 8, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(7258), 15.954915028125264 },
                    { 552, 3.5487500000000001, 3, 6.5125000000000002, new DateTime(2020, 6, 8, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(7270), 15.931957752496064 },
                    { 553, 3.5475000000000003, 3, 6.5249999999999995, new DateTime(2020, 6, 8, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(7281), 15.909251412874884 },
                    { 554, 3.5462500000000001, 3, 6.5375000000000005, new DateTime(2020, 6, 8, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(7292), 15.886797409895699 },
                    { 555, 3.5449999999999999, 3, 6.5500000000000007, new DateTime(2020, 6, 8, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(7303), 15.864597128627192 },
                    { 556, 3.5437500000000002, 3, 6.5625, new DateTime(2020, 6, 8, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(7315), 15.842651938487274 },
                    { 557, 3.5425000000000004, 3, 6.5749999999999993, new DateTime(2020, 6, 8, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(7326), 15.820963193158651 },
                    { 558, 3.5412500000000002, 3, 6.5874999999999995, new DateTime(2020, 6, 8, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(7337), 15.799532230505292 },
                    { 559, 3.54, 3, 6.6000000000000005, new DateTime(2020, 6, 8, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(7349), 15.778360372489924 },
                    { 560, 3.5387500000000003, 3, 6.6124999999999998, new DateTime(2020, 6, 8, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(7360), 15.757448925092483 },
                    { 565, 3.5325000000000002, 3, 6.6749999999999998, new DateTime(2020, 6, 8, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(7416), 15.656842427809043 },
                    { 562, 3.5362500000000003, 3, 6.6374999999999993, new DateTime(2020, 6, 8, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(7382), 15.716412405674753 },
                    { 563, 3.5350000000000001, 3, 6.6500000000000004, new DateTime(2020, 6, 8, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(7393), 15.696289864980281 },
                    { 564, 3.5337500000000004, 3, 6.6624999999999996, new DateTime(2020, 6, 8, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(7405), 15.676432797399226 },
                    { 550, 3.55125, 3, 6.4875000000000007, new DateTime(2020, 6, 8, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(7247), 15.978121823649577 },
                    { 566, 3.53125, 3, 6.6875, new DateTime(2020, 6, 8, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(7427), 15.637519964636015 },
                    { 567, 3.5300000000000002, 3, 6.7000000000000002, new DateTime(2020, 6, 8, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(7438), 15.618466599780682 },
                    { 568, 3.5287500000000001, 3, 6.7125000000000004, new DateTime(2020, 6, 8, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(7450), 15.599683508544341 },
                    { 569, 3.5275000000000003, 3, 6.7249999999999996, new DateTime(2020, 6, 8, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(7461), 15.581171849556533 },
                    { 570, 3.5262500000000001, 3, 6.7374999999999998, new DateTime(2020, 6, 8, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(7472), 15.562932764703586 },
                    { 571, 3.5250000000000004, 3, 6.75, new DateTime(2020, 6, 8, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(7483), 15.544967379058161 },
                    { 561, 3.5375000000000001, 3, 6.625, new DateTime(2020, 6, 8, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(7371), 15.736799178229539 },
                    { 549, 3.5525000000000002, 3, 6.4749999999999996, new DateTime(2020, 6, 8, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(7236), 16.001576707564546 },
                    { 544, 3.5587500000000003, 3, 6.4124999999999996, new DateTime(2020, 6, 8, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(7180), 16.122521284138827 },
                    { 547, 3.5550000000000002, 3, 6.4500000000000002, new DateTime(2020, 6, 8, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(7213), 16.049224938121547 },
                    { 525, 3.5825, 3, 6.1750000000000007, new DateTime(2020, 6, 8, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(6966), 16.634937432451132 },
                    { 526, 3.5812500000000003, 3, 6.1875, new DateTime(2020, 6, 8, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(6977), 16.60599627233529 },
                    { 527, 3.5800000000000001, 3, 6.2000000000000002, new DateTime(2020, 6, 8, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(6988), 16.577264470356557 },
                    { 528, 3.5787500000000003, 3, 6.2124999999999995, new DateTime(2020, 6, 8, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(6999), 16.548743798827815 },
                    { 529, 3.5775000000000001, 3, 6.2250000000000005, new DateTime(2020, 6, 8, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(7011), 16.520436017038428 },
                    { 530, 3.5762499999999999, 3, 6.2375000000000007, new DateTime(2020, 6, 8, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(7022), 16.492342871145723 },
                    { 531, 3.5750000000000002, 3, 6.25, new DateTime(2020, 6, 8, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(7033), 16.464466094067262 },
                    { 532, 3.5737500000000004, 3, 6.2624999999999993, new DateTime(2020, 6, 8, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(7045), 16.436807405373973 },
                    { 533, 3.5725000000000002, 3, 6.2749999999999995, new DateTime(2020, 6, 8, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(7056), 16.409368511184059 },
                    { 534, 3.57125, 3, 6.2875000000000005, new DateTime(2020, 6, 8, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(7067), 16.382151104057755 },
                    { 548, 3.55375, 3, 6.4625000000000004, new DateTime(2020, 6, 8, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(7225), 16.025278233062451 },
                    { 535, 3.5700000000000003, 3, 6.2999999999999998, new DateTime(2020, 6, 8, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(7079), 16.355156862892944 },
                    { 537, 3.5675000000000003, 3, 6.3249999999999993, new DateTime(2020, 6, 8, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(7101), 16.301844525106951 },
                    { 538, 3.5662500000000001, 3, 6.3375000000000004, new DateTime(2020, 6, 8, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(7112), 16.275529717041891 },
                    { 539, 3.5650000000000004, 3, 6.3499999999999996, new DateTime(2020, 6, 8, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(7123), 16.249444651847703 },
                    { 540, 3.5637500000000002, 3, 6.3624999999999998, new DateTime(2020, 6, 8, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(7134), 16.223590938574084 },
                    { 541, 3.5625, 3, 6.375, new DateTime(2020, 6, 8, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(7146), 16.197970171999849 },
                    { 542, 3.5612500000000002, 3, 6.3875000000000002, new DateTime(2020, 6, 8, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(7157), 16.172583932534561 },
                    { 543, 3.5600000000000001, 3, 6.4000000000000004, new DateTime(2020, 6, 8, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(7168), 16.147433786121052 },
                    { 572, 3.5237500000000002, 3, 6.7625000000000002, new DateTime(2020, 6, 8, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(7495), 15.527276800809874 },
                    { 545, 3.5575000000000001, 3, 6.4249999999999998, new DateTime(2020, 6, 8, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(7191), 16.097847963308354 },
                    { 546, 3.5562500000000004, 3, 6.4375, new DateTime(2020, 6, 8, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(7202), 16.073415345596274 },
                    { 536, 3.5687500000000001, 3, 6.3125, new DateTime(2020, 6, 8, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(7090), 16.328387452821573 },
                    { 573, 3.5225, 3, 6.7750000000000004, new DateTime(2020, 6, 8, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(7506), 15.509862121196923 },
                    { 578, 3.5162500000000003, 3, 6.8374999999999995, new DateTime(2020, 6, 8, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(7562), 15.426964201006932 },
                    { 575, 3.52, 3, 6.8000000000000007, new DateTime(2020, 6, 8, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(7528), 15.475864737669902 },
                    { 602, 3.4862500000000001, 3, 7.1375000000000002, new DateTime(2020, 6, 9, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(7831), 15.129133065150754 },
                    { 603, 3.4850000000000003, 3, 7.1499999999999995, new DateTime(2020, 6, 9, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(7843), 15.120416190306264 },
                    { 604, 3.4837500000000001, 3, 7.1625000000000005, new DateTime(2020, 6, 9, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(7854), 15.112000311176047 },
                    { 605, 3.4824999999999999, 3, 7.1750000000000007, new DateTime(2020, 6, 9, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(7865), 15.103885946891172 },
                    { 606, 3.4812500000000002, 3, 7.1875, new DateTime(2020, 6, 9, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(7877), 15.09607359798385 },
                    { 607, 3.4800000000000004, 3, 7.1999999999999993, new DateTime(2020, 6, 9, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(7963), 15.088563746356556 },
                    { 608, 3.4787500000000002, 3, 7.2124999999999995, new DateTime(2020, 6, 9, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(7978), 15.08135685525232 },
                    { 609, 3.4775, 3, 7.2250000000000005, new DateTime(2020, 6, 9, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(7990), 15.074453369226131 },
                    { 610, 3.4762500000000003, 3, 7.2374999999999998, new DateTime(2020, 6, 9, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(8001), 15.067853714117522 },
                    { 611, 3.4750000000000001, 3, 7.25, new DateTime(2020, 6, 9, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(8013), 15.061558297024312 },
                    { 612, 3.4737500000000003, 3, 7.2624999999999993, new DateTime(2020, 6, 9, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(8024), 15.055567506277477 },
                    { 613, 3.4725000000000001, 3, 7.2750000000000004, new DateTime(2020, 6, 9, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(8035), 15.049881711417212 },
                    { 614, 3.4712500000000004, 3, 7.2874999999999996, new DateTime(2020, 6, 9, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(8047), 15.044501263170126 },
                    { 615, 3.4700000000000002, 3, 7.2999999999999998, new DateTime(2020, 6, 9, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(8058), 15.039426493427612 },
                    { 616, 3.46875, 3, 7.3125, new DateTime(2020, 6, 9, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(8070), 15.034657715225368 },
                    { 617, 3.4675000000000002, 3, 7.3250000000000002, new DateTime(2020, 6, 9, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(8081), 15.030195222724101 },
                    { 618, 3.4662500000000001, 3, 7.3375000000000004, new DateTime(2020, 6, 9, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(8092), 15.026039291191367 },
                    { 619, 3.4650000000000003, 3, 7.3499999999999996, new DateTime(2020, 6, 9, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(8103), 15.0221901769846 },
                    { 620, 3.4637500000000001, 3, 7.3624999999999998, new DateTime(2020, 6, 9, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(8115), 15.018648117535294 },
                    { 621, 3.4625000000000004, 3, 7.375, new DateTime(2020, 6, 9, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(8126), 15.015413331334361 },
                    { 622, 3.4612500000000002, 3, 7.3875000000000002, new DateTime(2020, 6, 9, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(8137), 15.012486017918651 },
                    { 601, 3.4875000000000003, 3, 7.125, new DateTime(2020, 6, 9, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(7820), 15.138150398011618 },
                    { 600, 3.48875, 3, 7.1125000000000007, new DateTime(2020, 6, 9, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(7809), 15.147467632657287 },
                    { 599, 3.4900000000000002, 3, 7.0999999999999996, new DateTime(2020, 6, 9, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(7798), 15.157084194356845 },
                    { 598, 3.49125, 3, 7.0875000000000004, new DateTime(2020, 6, 9, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(7787), 15.166999489915463 },
                    { 576, 3.5187500000000003, 3, 6.8125, new DateTime(2020, 6, 8, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(7539), 15.459284130874593 },
                    { 577, 3.5175000000000001, 3, 6.8250000000000002, new DateTime(2020, 6, 8, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(7551), 15.442983616822776 },
                    { 524, 3.5837500000000002, 3, 6.1624999999999996, new DateTime(2020, 6, 8, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(6954), 16.664086165477002 },
                    { 579, 3.5150000000000001, 3, 6.8500000000000005, new DateTime(2020, 6, 8, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(7573), 15.411226871580094 },
                    { 580, 3.5137499999999999, 3, 6.8625000000000007, new DateTime(2020, 6, 8, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(7584), 15.395772599294869 },
                    { 581, 3.5125000000000002, 3, 6.875, new DateTime(2020, 6, 8, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(7595), 15.380602337443568 },
                    { 582, 3.5112500000000004, 3, 6.8874999999999993, new DateTime(2020, 6, 8, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(7607), 15.365717021799396 },
                    { 583, 3.5100000000000002, 3, 6.8999999999999995, new DateTime(2020, 6, 8, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(7618), 15.351117570558745 },
                    { 584, 3.50875, 3, 6.9125000000000005, new DateTime(2020, 6, 8, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(7629), 15.336804884284529 },
                    { 585, 3.5075000000000003, 3, 6.9249999999999998, new DateTime(2020, 6, 8, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(7640), 15.322779845850663 },
                    { 574, 3.5212500000000002, 3, 6.7874999999999996, new DateTime(2020, 6, 8, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(7517), 15.492724414438772 },
                    { 586, 3.5062500000000001, 3, 6.9375, new DateTime(2020, 6, 8, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(7652), 15.30904332038758 },
                    { 588, 3.5037500000000001, 3, 6.9625000000000004, new DateTime(2020, 6, 8, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(7674), 15.282439179859033 },
                    { 589, 3.5025000000000004, 3, 6.9749999999999996, new DateTime(2020, 6, 8, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(7685), 15.269573205862272 },
                    { 590, 3.5012500000000002, 3, 6.9874999999999998, new DateTime(2020, 6, 9, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(7697), 15.256999026872478 },
                    { 591, 3.5, 3, 7.0, new DateTime(2020, 6, 9, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(7708), 15.244717418524232 },
                    { 592, 3.4987500000000002, 3, 7.0125000000000002, new DateTime(2020, 6, 9, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(7719), 15.232729138404993 },
                    { 593, 3.4975000000000001, 3, 7.0250000000000004, new DateTime(2020, 6, 9, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(7730), 15.22103492600835 },
                    { 594, 3.4962500000000003, 3, 7.0374999999999996, new DateTime(2020, 6, 9, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(7742), 15.209635502688403 },
                    { 595, 3.4950000000000001, 3, 7.0499999999999998, new DateTime(2020, 6, 9, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(7753), 15.198531571615284 },
                    { 596, 3.4937500000000004, 3, 7.0625, new DateTime(2020, 6, 9, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(7764), 15.187723817731763 },
                    { 597, 3.4925000000000002, 3, 7.0750000000000002, new DateTime(2020, 6, 9, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(7775), 15.177212907711009 },
                    { 587, 3.5050000000000003, 3, 6.9499999999999993, new DateTime(2020, 6, 8, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(7663), 15.295596155228875 },
                    { 523, 3.585, 3, 6.1500000000000004, new DateTime(2020, 6, 8, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(6943), 16.69344067338174 },
                    { 518, 3.5912500000000001, 3, 6.0875000000000004, new DateTime(2020, 6, 8, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(6886), 16.843236022753111 },
                    { 521, 3.5875000000000004, 3, 6.125, new DateTime(2020, 6, 8, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(6920), 16.752759758349079 },
                    { 448, 3.67875, 3, 5.2125000000000004, new DateTime(2020, 6, 7, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(5794), 19.33439330736724 },
                    { 449, 3.6775000000000002, 3, 5.2249999999999996, new DateTime(2020, 6, 7, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(5805), 19.295493840312091 },
                    { 450, 3.67625, 3, 5.2375000000000007, new DateTime(2020, 6, 7, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(5817), 19.256637830515384 },
                    { 451, 3.6750000000000003, 3, 5.25, new DateTime(2020, 6, 7, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(5829), 19.217827674798848 },
                    { 452, 3.6737500000000001, 3, 5.2625000000000002, new DateTime(2020, 6, 7, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(5840), 19.179065767155688 },
                    { 453, 3.6725000000000003, 3, 5.2749999999999995, new DateTime(2020, 6, 7, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(5852), 19.140354498602953 },
                    { 454, 3.6712500000000001, 3, 5.2875000000000005, new DateTime(2020, 6, 7, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(5863), 19.101696257034035 },
                    { 455, 3.6699999999999999, 3, 5.3000000000000007, new DateTime(2020, 6, 7, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(5875), 19.063093427071376 },
                    { 456, 3.6687500000000002, 3, 5.3125, new DateTime(2020, 6, 7, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(5886), 19.024548389919357 },
                    { 457, 3.6675000000000004, 3, 5.3249999999999993, new DateTime(2020, 6, 7, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(5898), 18.986063523217439 },
                    { 458, 3.6662500000000002, 3, 5.3374999999999995, new DateTime(2020, 6, 7, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(5909), 18.947641200893475 },
                    { 459, 3.665, 3, 5.3500000000000005, new DateTime(2020, 6, 7, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(5921), 18.909283793017288 },
                    { 460, 3.6637500000000003, 3, 5.3624999999999998, new DateTime(2020, 6, 7, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(5932), 18.870993665654481 },
                    { 461, 3.6625000000000001, 3, 5.375, new DateTime(2020, 6, 7, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(5943), 18.832773180720473 },
                    { 462, 3.6612500000000003, 3, 5.3874999999999993, new DateTime(2020, 6, 7, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(5955), 18.794624695834809 },
                    { 463, 3.6600000000000001, 3, 5.4000000000000004, new DateTime(2020, 6, 7, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(5966), 18.756550564175726 },
                    { 464, 3.6587500000000004, 3, 5.4124999999999996, new DateTime(2020, 6, 7, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(5978), 18.718553134335018 },
                    { 465, 3.6575000000000002, 3, 5.4249999999999998, new DateTime(2020, 6, 7, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(5989), 18.680634750173137 },
                    { 466, 3.65625, 3, 5.4375, new DateTime(2020, 6, 7, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(6001), 18.642797750674632 },
                    { 467, 3.6550000000000002, 3, 5.4500000000000002, new DateTime(2020, 6, 7, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(6012), 18.605044469803854 },
                    { 468, 3.6537500000000001, 3, 5.4625000000000004, new DateTime(2020, 6, 7, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(6024), 18.567377236361008 },
                    { 447, 3.6800000000000002, 3, 5.2000000000000002, new DateTime(2020, 6, 7, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(5782), 19.373333832178478 },
                    { 446, 3.6812500000000004, 3, 5.1875, new DateTime(2020, 6, 7, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(5771), 19.412313012710811 },
                    { 445, 3.6825000000000001, 3, 5.1749999999999998, new DateTime(2020, 6, 6, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(5759), 19.451328444544774 },
                    { 444, 3.6837500000000003, 3, 5.1624999999999996, new DateTime(2020, 6, 6, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(5748), 19.49037772102475 },
                    { 422, 3.7112500000000002, 3, 4.8875000000000002, new DateTime(2020, 6, 6, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(5479), 20.353134929655834 },
                    { 423, 3.71, 3, 4.9000000000000004, new DateTime(2020, 6, 6, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(5490), 20.313952597646569 },
                    { 424, 3.7087500000000002, 3, 4.9125000000000005, new DateTime(2020, 6, 6, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(5502), 20.274750899562228 },
                    { 425, 3.7075, 3, 4.9249999999999998, new DateTime(2020, 6, 6, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(5514), 20.235532253548214 },
                    { 426, 3.7062500000000003, 3, 4.9375, new DateTime(2020, 6, 6, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(5525), 20.196299078795342 },
                    { 427, 3.7050000000000001, 3, 4.9500000000000002, new DateTime(2020, 6, 6, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(5536), 20.157053795390642 },
                    { 428, 3.7037500000000003, 3, 4.9625000000000004, new DateTime(2020, 6, 6, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(5547), 20.117798824168052 },
                    { 429, 3.7025000000000001, 3, 4.9749999999999996, new DateTime(2020, 6, 6, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(5559), 20.078536586559103 },
                    { 430, 3.7012499999999999, 3, 4.9875000000000007, new DateTime(2020, 6, 6, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(5570), 20.039269504443556 },
                    { 431, 3.7000000000000002, 3, 5.0, new DateTime(2020, 6, 6, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(5587), 20.0 },
                    { 469, 3.6525000000000003, 3, 5.4749999999999996, new DateTime(2020, 6, 7, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(6035), 18.529798373838481 },
                    { 432, 3.6987500000000004, 3, 5.0124999999999993, new DateTime(2020, 6, 6, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(5599), 19.960730495556444 },
                    { 434, 3.69625, 3, 5.0375000000000005, new DateTime(2020, 6, 6, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(5622), 19.882201175831948 },
                    { 435, 3.6950000000000003, 3, 5.0499999999999998, new DateTime(2020, 6, 6, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(5633), 19.842946204609358 },
                    { 436, 3.6937500000000001, 3, 5.0625, new DateTime(2020, 6, 6, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(5645), 19.803700921204658 },
                    { 437, 3.6925000000000003, 3, 5.0749999999999993, new DateTime(2020, 6, 6, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(5668), 19.764467746451789 },
                    { 438, 3.6912500000000001, 3, 5.0875000000000004, new DateTime(2020, 6, 6, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(5680), 19.725249100437772 },
                    { 439, 3.6900000000000004, 3, 5.0999999999999996, new DateTime(2020, 6, 6, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(5691), 19.686047402353434 },
                    { 440, 3.6887500000000002, 3, 5.1124999999999998, new DateTime(2020, 6, 6, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(5702), 19.646865070344166 },
                    { 441, 3.6875, 3, 5.125, new DateTime(2020, 6, 6, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(5714), 19.607704521360777 },
                    { 442, 3.6862500000000002, 3, 5.1375000000000002, new DateTime(2020, 6, 6, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(5725), 19.56856817101038 },
                    { 443, 3.6850000000000001, 3, 5.1500000000000004, new DateTime(2020, 6, 6, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(5737), 19.529458433407431 },
                    { 433, 3.6975000000000002, 3, 5.0249999999999995, new DateTime(2020, 6, 6, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(5611), 19.9214634134409 },
                    { 470, 3.6512500000000001, 3, 5.4874999999999998, new DateTime(2020, 6, 7, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(6046), 18.492310200277522 },
                    { 471, 3.6500000000000004, 3, 5.5, new DateTime(2020, 6, 7, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(6058), 18.45491502812526 },
                    { 472, 3.6487500000000002, 3, 5.5125000000000002, new DateTime(2020, 6, 7, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(6070), 18.417615164092069 },
                    { 499, 3.6150000000000002, 3, 5.8499999999999996, new DateTime(2020, 6, 7, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(6501), 17.454792921248146 },
                    { 500, 3.61375, 3, 5.8625000000000007, new DateTime(2020, 6, 7, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(6513), 17.421070508574761 },
                    { 501, 3.6125000000000003, 3, 5.875, new DateTime(2020, 6, 7, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(6525), 17.387507176420257 },
                    { 502, 3.6112500000000001, 3, 5.8875000000000002, new DateTime(2020, 6, 7, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(6536), 17.354104995129049 },
                    { 503, 3.6100000000000003, 3, 5.8999999999999995, new DateTime(2020, 6, 7, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(6548), 17.320866025105019 },
                    { 504, 3.6087500000000001, 3, 5.9125000000000005, new DateTime(2020, 6, 7, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(6559), 17.287792316684406 },
                    { 505, 3.6074999999999999, 3, 5.9250000000000007, new DateTime(2020, 6, 7, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(6571), 17.254885910009342 },
                    { 506, 3.6062500000000002, 3, 5.9375, new DateTime(2020, 6, 7, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(6582), 17.22214883490199 },
                    { 507, 3.6050000000000004, 3, 5.9499999999999993, new DateTime(2020, 6, 7, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(6594), 17.189583110739349 },
                    { 508, 3.6037500000000002, 3, 5.9624999999999995, new DateTime(2020, 6, 7, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(6605), 17.157190746328681 },
                    { 498, 3.61625, 3, 5.8375000000000004, new DateTime(2020, 6, 7, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(6489), 17.488672334283137 },
                    { 509, 3.6025, 3, 5.9750000000000005, new DateTime(2020, 6, 7, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(6617), 17.124973739783606 },
                    { 511, 3.6000000000000001, 3, 6.0, new DateTime(2020, 6, 7, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(6640), 17.061073738537637 },
                    { 512, 3.5987500000000003, 3, 6.0124999999999993, new DateTime(2020, 6, 7, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(6651), 17.029394685489809 },
                    { 513, 3.5975000000000001, 3, 6.0250000000000004, new DateTime(2020, 6, 7, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(6663), 16.99789887337058 },
                    { 514, 3.5962500000000004, 3, 6.0374999999999996, new DateTime(2020, 6, 7, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(6835), 16.966588244990003 },
                    { 515, 3.5950000000000002, 3, 6.0499999999999998, new DateTime(2020, 6, 7, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(6850), 16.93546473173512 },
                    { 516, 3.59375, 3, 6.0625, new DateTime(2020, 6, 7, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(6863), 16.904530253450829 },
                    { 517, 3.5925000000000002, 3, 6.0750000000000002, new DateTime(2020, 6, 7, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(6874), 16.873786718321476 },
                    { 623, 3.46, 3, 7.4000000000000004, new DateTime(2020, 6, 9, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(8149), 15.009866357858641 },
                    { 519, 3.5900000000000003, 3, 6.0999999999999996, new DateTime(2020, 6, 8, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(6897), 16.812880051256553 },
                    { 520, 3.5887500000000001, 3, 6.1124999999999998, new DateTime(2020, 6, 8, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(6909), 16.78272067633111 },
                    { 510, 3.6012500000000003, 3, 5.9874999999999998, new DateTime(2020, 6, 7, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(6628), 17.092934078400848 },
                    { 522, 3.5862500000000002, 3, 6.1375000000000002, new DateTime(2020, 6, 8, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(6932), 16.72299914544103 },
                    { 497, 3.6175000000000002, 3, 5.8250000000000002, new DateTime(2020, 6, 7, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(6478), 17.522706657837961 },
                    { 495, 3.6200000000000001, 3, 5.7999999999999998, new DateTime(2020, 6, 7, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(6454), 17.591231629491425 },
                    { 473, 3.6475, 3, 5.5250000000000004, new DateTime(2020, 6, 7, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(6081), 18.380412909009255 },
                    { 474, 3.6462500000000002, 3, 5.5374999999999996, new DateTime(2020, 6, 7, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(6093), 18.343310557687147 },
                    { 475, 3.645, 3, 5.5500000000000007, new DateTime(2020, 6, 7, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(6104), 18.306310398773544 },
                    { 476, 3.6437500000000003, 3, 5.5625, new DateTime(2020, 6, 7, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(6116), 18.269414714612534 },
                    { 477, 3.6425000000000001, 3, 5.5750000000000002, new DateTime(2020, 6, 7, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(6127), 18.232625781103714 },
                    { 478, 3.6412500000000003, 3, 5.5874999999999995, new DateTime(2020, 6, 7, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(6139), 18.195945867561793 },
                    { 479, 3.6400000000000001, 3, 5.6000000000000005, new DateTime(2020, 6, 7, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(6150), 18.15937723657661 },
                    { 480, 3.6387499999999999, 3, 5.6125000000000007, new DateTime(2020, 6, 7, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(6162), 18.122922143873584 },
                    { 481, 3.6375000000000002, 3, 5.625, new DateTime(2020, 6, 7, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(6173), 18.08658283817455 },
                    { 482, 3.6362500000000004, 3, 5.6374999999999993, new DateTime(2020, 6, 7, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(6185), 18.050361561059059 },
                    { 496, 3.6187500000000004, 3, 5.8125, new DateTime(2020, 6, 7, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(6466), 17.556893792515226 },
                    { 483, 3.6350000000000002, 3, 5.6499999999999995, new DateTime(2020, 6, 7, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(6196), 18.014260546826101 },
                    { 485, 3.6325000000000003, 3, 5.6749999999999998, new DateTime(2020, 6, 7, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(6219), 17.942428206974459 },
                    { 486, 3.6312500000000001, 3, 5.6875, new DateTime(2020, 6, 7, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(6230), 17.906701312312862 },
                    { 487, 3.6300000000000003, 3, 5.6999999999999993, new DateTime(2020, 6, 7, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(6242), 17.871103542174637 },
                    { 488, 3.6287500000000001, 3, 5.7125000000000004, new DateTime(2020, 6, 7, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(6253), 17.835637092397931 },
                    { 489, 3.6275000000000004, 3, 5.7249999999999996, new DateTime(2020, 6, 7, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(6265), 17.800304150720425 },
                    { 490, 3.6262500000000002, 3, 5.7374999999999998, new DateTime(2020, 6, 7, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(6276), 17.765106896644394 },
                    { 491, 3.625, 3, 5.75, new DateTime(2020, 6, 7, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(6288), 17.73004750130227 },
                    { 492, 3.6237500000000002, 3, 5.7625000000000002, new DateTime(2020, 6, 7, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(6299), 17.695128127322686 },
                    { 493, 3.6225000000000001, 3, 5.7750000000000004, new DateTime(2020, 6, 7, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(6311), 17.660350928697135 },
                    { 494, 3.6212500000000003, 3, 5.7874999999999996, new DateTime(2020, 6, 7, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(6438), 17.625718050647027 },
                    { 484, 3.63375, 3, 5.6625000000000005, new DateTime(2020, 6, 7, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(6208), 17.978282022356275 },
                    { 624, 3.4587500000000002, 3, 7.4124999999999996, new DateTime(2020, 6, 9, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(8160), 15.00755451274731 },
                    { 629, 3.4525000000000001, 3, 7.4750000000000005, new DateTime(2020, 6, 9, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(8216), 15.000616837591696 },
                    { 626, 3.4562500000000003, 3, 7.4375, new DateTime(2020, 6, 9, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(8182), 15.003854818796386 },
                    { 756, 3.2937500000000002, 3, 9.0625, new DateTime(2020, 6, 11, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(9915), 17.22214883490199 },
                    { 757, 3.2925000000000004, 3, 9.0749999999999993, new DateTime(2020, 6, 11, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(9926), 17.254885910009339 },
                    { 758, 3.2912500000000002, 3, 9.0874999999999986, new DateTime(2020, 6, 11, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(9937), 17.287792316684403 },
                    { 759, 3.29, 3, 9.0999999999999996, new DateTime(2020, 6, 11, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(9949), 17.320866025105019 },
                    { 760, 3.2887500000000003, 3, 9.1125000000000007, new DateTime(2020, 6, 11, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(9960), 17.354104995129045 },
                    { 761, 3.2875000000000001, 3, 9.125, new DateTime(2020, 6, 11, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(9971), 17.387507176420254 },
                    { 762, 3.2862500000000003, 3, 9.1374999999999993, new DateTime(2020, 6, 11, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(9982), 17.421070508574761 },
                    { 763, 3.2850000000000001, 3, 9.1500000000000004, new DateTime(2020, 6, 11, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(9993), 17.454792921248142 },
                    { 764, 3.2837500000000004, 3, 9.1624999999999996, new DateTime(2020, 6, 11, 10, 13, 50, 615, DateTimeKind.Local).AddTicks(5), 17.488672334283137 },
                    { 765, 3.2825000000000002, 3, 9.1750000000000007, new DateTime(2020, 6, 11, 10, 33, 50, 615, DateTimeKind.Local).AddTicks(16), 17.522706657837961 },
                    { 766, 3.28125, 3, 9.1875, new DateTime(2020, 6, 11, 10, 53, 50, 615, DateTimeKind.Local).AddTicks(27), 17.556893792515222 },
                    { 767, 3.2800000000000002, 3, 9.2000000000000011, new DateTime(2020, 6, 11, 11, 13, 50, 615, DateTimeKind.Local).AddTicks(38), 17.591231629491425 },
                    { 768, 3.2787500000000001, 3, 9.2125000000000004, new DateTime(2020, 6, 11, 11, 33, 50, 615, DateTimeKind.Local).AddTicks(49), 17.625718050647023 },
                    { 769, 3.2775000000000003, 3, 9.2249999999999996, new DateTime(2020, 6, 11, 11, 53, 50, 615, DateTimeKind.Local).AddTicks(60), 17.660350928697131 },
                    { 770, 3.2762500000000001, 3, 9.2374999999999989, new DateTime(2020, 6, 11, 12, 13, 50, 615, DateTimeKind.Local).AddTicks(72), 17.695128127322686 },
                    { 771, 3.2750000000000004, 3, 9.25, new DateTime(2020, 6, 11, 12, 33, 50, 615, DateTimeKind.Local).AddTicks(83), 17.730047501302266 },
                    { 772, 3.2737500000000002, 3, 9.2624999999999993, new DateTime(2020, 6, 11, 12, 53, 50, 615, DateTimeKind.Local).AddTicks(94), 17.765106896644397 },
                    { 773, 3.2725, 3, 9.2750000000000004, new DateTime(2020, 6, 11, 13, 13, 50, 615, DateTimeKind.Local).AddTicks(105), 17.800304150720422 },
                    { 774, 3.2712500000000002, 3, 9.2874999999999996, new DateTime(2020, 6, 11, 13, 33, 50, 615, DateTimeKind.Local).AddTicks(117), 17.835637092397928 },
                    { 775, 3.27, 3, 9.3000000000000007, new DateTime(2020, 6, 11, 13, 53, 50, 615, DateTimeKind.Local).AddTicks(128), 17.871103542174637 },
                    { 776, 3.2687500000000003, 3, 9.3125, new DateTime(2020, 6, 11, 14, 13, 50, 615, DateTimeKind.Local).AddTicks(139), 17.906701312312858 },
                    { 755, 3.2949999999999999, 3, 9.0500000000000007, new DateTime(2020, 6, 11, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(9904), 17.189583110739346 },
                    { 754, 3.2962500000000001, 3, 9.0375000000000014, new DateTime(2020, 6, 11, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(9893), 17.157190746328681 },
                    { 753, 3.2975000000000003, 3, 9.0250000000000004, new DateTime(2020, 6, 11, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(9881), 17.124973739783606 },
                    { 752, 3.2987500000000001, 3, 9.0124999999999993, new DateTime(2020, 6, 11, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(9870), 17.092934078400848 },
                    { 730, 3.3262499999999999, 3, 8.7375000000000007, new DateTime(2020, 6, 10, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(9622), 16.436807405373973 },
                    { 731, 3.3250000000000002, 3, 8.75, new DateTime(2020, 6, 10, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(9633), 16.464466094067262 },
                    { 732, 3.3237500000000004, 3, 8.7624999999999993, new DateTime(2020, 6, 10, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(9645), 16.49234287114572 },
                    { 733, 3.3225000000000002, 3, 8.7749999999999986, new DateTime(2020, 6, 10, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(9656), 16.520436017038428 },
                    { 734, 3.32125, 3, 8.7874999999999996, new DateTime(2020, 6, 11, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(9667), 16.548743798827815 },
                    { 735, 3.3200000000000003, 3, 8.8000000000000007, new DateTime(2020, 6, 11, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(9678), 16.577264470356553 },
                    { 736, 3.3187500000000001, 3, 8.8125, new DateTime(2020, 6, 11, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(9690), 16.60599627233529 },
                    { 737, 3.3175000000000003, 3, 8.8249999999999993, new DateTime(2020, 6, 11, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(9701), 16.634937432451132 },
                    { 738, 3.3162500000000001, 3, 8.8375000000000004, new DateTime(2020, 6, 11, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(9712), 16.664086165477002 },
                    { 739, 3.3150000000000004, 3, 8.8499999999999996, new DateTime(2020, 6, 11, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(9723), 16.693440673381737 },
                    { 777, 3.2675000000000001, 3, 9.3249999999999993, new DateTime(2020, 6, 11, 14, 33, 50, 615, DateTimeKind.Local).AddTicks(150), 17.942428206974455 },
                    { 740, 3.3137500000000002, 3, 8.8625000000000007, new DateTime(2020, 6, 11, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(9735), 16.72299914544103 },
                    { 742, 3.3112500000000002, 3, 8.8875000000000011, new DateTime(2020, 6, 11, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(9758), 16.782720676331103 },
                    { 743, 3.3100000000000001, 3, 8.9000000000000004, new DateTime(2020, 6, 11, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(9769), 16.812880051256553 },
                    { 744, 3.3087500000000003, 3, 8.9124999999999996, new DateTime(2020, 6, 11, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(9780), 16.843236022753111 },
                    { 745, 3.3075000000000001, 3, 8.9249999999999989, new DateTime(2020, 6, 11, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(9792), 16.873786718321469 },
                    { 746, 3.3062500000000004, 3, 8.9375, new DateTime(2020, 6, 11, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(9803), 16.904530253450833 },
                    { 747, 3.3050000000000002, 3, 8.9499999999999993, new DateTime(2020, 6, 11, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(9814), 16.935464731735117 },
                    { 748, 3.30375, 3, 8.9625000000000004, new DateTime(2020, 6, 11, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(9825), 16.96658824499 },
                    { 749, 3.3025000000000002, 3, 8.9749999999999996, new DateTime(2020, 6, 11, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(9836), 16.99789887337058 },
                    { 750, 3.30125, 3, 8.9875000000000007, new DateTime(2020, 6, 11, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(9848), 17.029394685489809 },
                    { 751, 3.3000000000000003, 3, 9.0, new DateTime(2020, 6, 11, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(9859), 17.061073738537633 },
                    { 741, 3.3125, 3, 8.875, new DateTime(2020, 6, 11, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(9746), 16.752759758349079 },
                    { 778, 3.2662500000000003, 3, 9.3375000000000004, new DateTime(2020, 6, 11, 14, 53, 50, 615, DateTimeKind.Local).AddTicks(161), 17.978282022356275 },
                    { 779, 3.2650000000000001, 3, 9.3500000000000014, new DateTime(2020, 6, 11, 15, 13, 50, 615, DateTimeKind.Local).AddTicks(173), 18.014260546826097 },
                    { 780, 3.2637499999999999, 3, 9.3625000000000007, new DateTime(2020, 6, 11, 15, 33, 50, 615, DateTimeKind.Local).AddTicks(184), 18.050361561059059 },
                    { 807, 3.2300000000000004, 3, 9.6999999999999993, new DateTime(2020, 6, 12, 0, 33, 50, 615, DateTimeKind.Local).AddTicks(486), 19.063093427071376 },
                    { 808, 3.2287500000000002, 3, 9.7124999999999986, new DateTime(2020, 6, 12, 0, 53, 50, 615, DateTimeKind.Local).AddTicks(497), 19.101696257034035 },
                    { 809, 3.2275, 3, 9.7249999999999996, new DateTime(2020, 6, 12, 1, 13, 50, 615, DateTimeKind.Local).AddTicks(508), 19.140354498602953 },
                    { 810, 3.2262500000000003, 3, 9.7375000000000007, new DateTime(2020, 6, 12, 1, 33, 50, 615, DateTimeKind.Local).AddTicks(520), 19.179065767155681 },
                    { 811, 3.2250000000000001, 3, 9.75, new DateTime(2020, 6, 12, 1, 53, 50, 615, DateTimeKind.Local).AddTicks(534), 19.217827674798844 },
                    { 812, 3.2237500000000003, 3, 9.7624999999999993, new DateTime(2020, 6, 12, 2, 13, 50, 615, DateTimeKind.Local).AddTicks(546), 19.25663783051538 },
                    { 813, 3.2225000000000001, 3, 9.7750000000000004, new DateTime(2020, 6, 12, 2, 33, 50, 615, DateTimeKind.Local).AddTicks(557), 19.295493840312083 },
                    { 814, 3.2212500000000004, 3, 9.7874999999999996, new DateTime(2020, 6, 12, 2, 53, 50, 615, DateTimeKind.Local).AddTicks(568), 19.33439330736724 },
                    { 815, 3.2200000000000002, 3, 9.8000000000000007, new DateTime(2020, 6, 12, 3, 13, 50, 615, DateTimeKind.Local).AddTicks(579), 19.373333832178478 },
                    { 816, 3.21875, 3, 9.8125, new DateTime(2020, 6, 12, 3, 33, 50, 615, DateTimeKind.Local).AddTicks(591), 19.412313012710808 },
                    { 806, 3.2312500000000002, 3, 9.6875, new DateTime(2020, 6, 12, 0, 13, 50, 615, DateTimeKind.Local).AddTicks(475), 19.024548389919357 },
                    { 817, 3.2175000000000002, 3, 9.8250000000000011, new DateTime(2020, 6, 12, 3, 53, 50, 615, DateTimeKind.Local).AddTicks(602), 19.451328444544774 },
                    { 819, 3.2150000000000003, 3, 9.8499999999999996, new DateTime(2020, 6, 12, 4, 33, 50, 615, DateTimeKind.Local).AddTicks(624), 19.529458433407427 },
                    { 820, 3.2137500000000001, 3, 9.8624999999999989, new DateTime(2020, 6, 12, 4, 53, 50, 615, DateTimeKind.Local).AddTicks(636), 19.568568171010384 },
                    { 821, 3.2125000000000004, 3, 9.875, new DateTime(2020, 6, 12, 5, 13, 50, 615, DateTimeKind.Local).AddTicks(657), 19.607704521360777 },
                    { 822, 3.2112500000000002, 3, 9.8874999999999993, new DateTime(2020, 6, 12, 5, 33, 50, 615, DateTimeKind.Local).AddTicks(668), 19.646865070344166 },
                    { 823, 3.21, 3, 9.9000000000000004, new DateTime(2020, 6, 12, 5, 53, 50, 615, DateTimeKind.Local).AddTicks(680), 19.686047402353434 },
                    { 824, 3.2087500000000002, 3, 9.9124999999999996, new DateTime(2020, 6, 12, 6, 13, 50, 615, DateTimeKind.Local).AddTicks(691), 19.725249100437768 },
                    { 825, 3.2075, 3, 9.9250000000000007, new DateTime(2020, 6, 12, 6, 33, 50, 615, DateTimeKind.Local).AddTicks(702), 19.764467746451786 },
                    { 826, 3.2062500000000003, 3, 9.9375, new DateTime(2020, 6, 12, 6, 53, 50, 615, DateTimeKind.Local).AddTicks(714), 19.803700921204655 },
                    { 827, 3.2050000000000001, 3, 9.9499999999999993, new DateTime(2020, 6, 12, 7, 13, 50, 615, DateTimeKind.Local).AddTicks(725), 19.842946204609358 },
                    { 828, 3.2037500000000003, 3, 9.9625000000000004, new DateTime(2020, 6, 12, 7, 33, 50, 615, DateTimeKind.Local).AddTicks(736), 19.882201175831945 },
                    { 818, 3.2162500000000001, 3, 9.8375000000000004, new DateTime(2020, 6, 12, 4, 13, 50, 615, DateTimeKind.Local).AddTicks(613), 19.49037772102475 },
                    { 729, 3.3275000000000001, 3, 8.7250000000000014, new DateTime(2020, 6, 10, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(9610), 16.409368511184056 },
                    { 805, 3.2324999999999999, 3, 9.6750000000000007, new DateTime(2020, 6, 11, 23, 53, 50, 615, DateTimeKind.Local).AddTicks(464), 18.986063523217439 },
                    { 803, 3.2350000000000003, 3, 9.6500000000000004, new DateTime(2020, 6, 11, 23, 13, 50, 615, DateTimeKind.Local).AddTicks(441), 18.909283793017284 },
                    { 781, 3.2625000000000002, 3, 9.375, new DateTime(2020, 6, 11, 15, 53, 50, 615, DateTimeKind.Local).AddTicks(195), 18.086582838174547 },
                    { 782, 3.2612500000000004, 3, 9.3874999999999993, new DateTime(2020, 6, 11, 16, 13, 50, 615, DateTimeKind.Local).AddTicks(206), 18.122922143873584 },
                    { 783, 3.2600000000000002, 3, 9.3999999999999986, new DateTime(2020, 6, 11, 16, 33, 50, 615, DateTimeKind.Local).AddTicks(218), 18.159377236576606 },
                    { 784, 3.25875, 3, 9.4124999999999996, new DateTime(2020, 6, 11, 16, 53, 50, 615, DateTimeKind.Local).AddTicks(229), 18.19594586756179 },
                    { 785, 3.2575000000000003, 3, 9.4250000000000007, new DateTime(2020, 6, 11, 17, 13, 50, 615, DateTimeKind.Local).AddTicks(240), 18.232625781103714 },
                    { 786, 3.2562500000000001, 3, 9.4375, new DateTime(2020, 6, 11, 17, 33, 50, 615, DateTimeKind.Local).AddTicks(251), 18.269414714612534 },
                    { 787, 3.2550000000000003, 3, 9.4499999999999993, new DateTime(2020, 6, 11, 17, 53, 50, 615, DateTimeKind.Local).AddTicks(262), 18.30631039877354 },
                    { 788, 3.2537500000000001, 3, 9.4625000000000004, new DateTime(2020, 6, 11, 18, 13, 50, 615, DateTimeKind.Local).AddTicks(274), 18.343310557687147 },
                    { 789, 3.2525000000000004, 3, 9.4749999999999996, new DateTime(2020, 6, 11, 18, 33, 50, 615, DateTimeKind.Local).AddTicks(285), 18.380412909009252 },
                    { 790, 3.2512500000000002, 3, 9.4875000000000007, new DateTime(2020, 6, 11, 18, 53, 50, 615, DateTimeKind.Local).AddTicks(296), 18.417615164092066 },
                    { 804, 3.2337500000000001, 3, 9.6625000000000014, new DateTime(2020, 6, 11, 23, 33, 50, 615, DateTimeKind.Local).AddTicks(453), 18.947641200893475 },
                    { 791, 3.25, 3, 9.5, new DateTime(2020, 6, 11, 19, 13, 50, 615, DateTimeKind.Local).AddTicks(307), 18.454915028125264 },
                    { 793, 3.2475000000000001, 3, 9.5250000000000004, new DateTime(2020, 6, 11, 19, 53, 50, 615, DateTimeKind.Local).AddTicks(329), 18.529798373838478 },
                    { 794, 3.2462500000000003, 3, 9.5374999999999996, new DateTime(2020, 6, 11, 20, 13, 50, 615, DateTimeKind.Local).AddTicks(341), 18.567377236361008 },
                    { 795, 3.2450000000000001, 3, 9.5499999999999989, new DateTime(2020, 6, 11, 20, 33, 50, 615, DateTimeKind.Local).AddTicks(352), 18.60504446980385 },
                    { 796, 3.2437500000000004, 3, 9.5625, new DateTime(2020, 6, 11, 20, 53, 50, 615, DateTimeKind.Local).AddTicks(363), 18.642797750674628 },
                    { 797, 3.2425000000000002, 3, 9.5749999999999993, new DateTime(2020, 6, 11, 21, 13, 50, 615, DateTimeKind.Local).AddTicks(374), 18.680634750173134 },
                    { 798, 3.24125, 3, 9.5875000000000004, new DateTime(2020, 6, 11, 21, 33, 50, 615, DateTimeKind.Local).AddTicks(385), 18.718553134335018 },
                    { 799, 3.2400000000000002, 3, 9.5999999999999996, new DateTime(2020, 6, 11, 21, 53, 50, 615, DateTimeKind.Local).AddTicks(397), 18.756550564175722 },
                    { 800, 3.23875, 3, 9.6125000000000007, new DateTime(2020, 6, 11, 22, 13, 50, 615, DateTimeKind.Local).AddTicks(408), 18.794624695834806 },
                    { 801, 3.2375000000000003, 3, 9.625, new DateTime(2020, 6, 11, 22, 33, 50, 615, DateTimeKind.Local).AddTicks(419), 18.832773180720473 },
                    { 802, 3.2362500000000001, 3, 9.6374999999999993, new DateTime(2020, 6, 11, 22, 53, 50, 615, DateTimeKind.Local).AddTicks(430), 18.870993665654481 },
                    { 792, 3.2487500000000002, 3, 9.5125000000000011, new DateTime(2020, 6, 11, 19, 33, 50, 615, DateTimeKind.Local).AddTicks(318), 18.492310200277522 },
                    { 625, 3.4575, 3, 7.4250000000000007, new DateTime(2020, 6, 9, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(8171), 15.00555062519015 },
                    { 728, 3.3287500000000003, 3, 8.7125000000000004, new DateTime(2020, 6, 10, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(9599), 16.382151104057751 },
                    { 726, 3.3312500000000003, 3, 8.6875, new DateTime(2020, 6, 10, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(9577), 16.32838745282157 },
                    { 653, 3.4225000000000003, 3, 7.7749999999999995, new DateTime(2020, 6, 9, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(8487), 15.074453369226131 },
                    { 654, 3.4212500000000001, 3, 7.7875000000000005, new DateTime(2020, 6, 9, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(8498), 15.08135685525232 },
                    { 655, 3.4199999999999999, 3, 7.8000000000000007, new DateTime(2020, 6, 9, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(8509), 15.088563746356556 },
                    { 656, 3.4187500000000002, 3, 7.8125, new DateTime(2020, 6, 9, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(8521), 15.096073597983848 },
                    { 657, 3.4175000000000004, 3, 7.8249999999999993, new DateTime(2020, 6, 9, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(8532), 15.103885946891172 },
                    { 658, 3.4162500000000002, 3, 7.8374999999999995, new DateTime(2020, 6, 9, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(8543), 15.112000311176045 },
                    { 659, 3.415, 3, 7.8500000000000005, new DateTime(2020, 6, 9, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(8554), 15.120416190306264 },
                    { 660, 3.4137500000000003, 3, 7.8624999999999998, new DateTime(2020, 6, 9, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(8566), 15.129133065150754 },
                    { 661, 3.4125000000000001, 3, 7.875, new DateTime(2020, 6, 9, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(8577), 15.138150398011616 },
                    { 662, 3.4112500000000003, 3, 7.8874999999999993, new DateTime(2020, 6, 10, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(8589), 15.147467632657287 },
                    { 663, 3.4100000000000001, 3, 7.9000000000000004, new DateTime(2020, 6, 10, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(8600), 15.157084194356845 },
                    { 664, 3.4087500000000004, 3, 7.9124999999999996, new DateTime(2020, 6, 10, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(8611), 15.166999489915463 },
                    { 665, 3.4075000000000002, 3, 7.9249999999999998, new DateTime(2020, 6, 10, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(8622), 15.177212907711009 },
                    { 666, 3.40625, 3, 7.9375, new DateTime(2020, 6, 10, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(8634), 15.187723817731763 },
                    { 667, 3.4050000000000002, 3, 7.9500000000000002, new DateTime(2020, 6, 10, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(8645), 15.198531571615284 },
                    { 668, 3.4037500000000001, 3, 7.9625000000000004, new DateTime(2020, 6, 10, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(8656), 15.209635502688403 },
                    { 669, 3.4025000000000003, 3, 7.9749999999999996, new DateTime(2020, 6, 10, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(8668), 15.22103492600835 },
                    { 670, 3.4012500000000001, 3, 7.9874999999999998, new DateTime(2020, 6, 10, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(8679), 15.232729138404993 },
                    { 671, 3.4000000000000004, 3, 8.0, new DateTime(2020, 6, 10, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(8690), 15.244717418524232 },
                    { 672, 3.3987500000000002, 3, 8.0124999999999993, new DateTime(2020, 6, 10, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(8701), 15.256999026872478 },
                    { 673, 3.3975, 3, 8.0250000000000004, new DateTime(2020, 6, 10, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(8712), 15.269573205862272 },
                    { 652, 3.4237500000000001, 3, 7.7625000000000002, new DateTime(2020, 6, 9, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(8476), 15.067853714117522 },
                    { 651, 3.4250000000000003, 3, 7.75, new DateTime(2020, 6, 9, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(8464), 15.061558297024311 },
                    { 650, 3.42625, 3, 7.7375000000000007, new DateTime(2020, 6, 9, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(8453), 15.055567506277477 },
                    { 649, 3.4275000000000002, 3, 7.7249999999999996, new DateTime(2020, 6, 9, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(8442), 15.049881711417212 },
                    { 627, 3.4550000000000001, 3, 7.4500000000000002, new DateTime(2020, 6, 9, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(8194), 15.002467198171342 },
                    { 628, 3.4537500000000003, 3, 7.4624999999999995, new DateTime(2020, 6, 9, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(8205), 15.001387848909998 },
                    { 421, 3.7125000000000004, 3, 4.875, new DateTime(2020, 6, 6, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(5468), 20.392295478639227 },
                    { 630, 3.4512499999999999, 3, 7.4875000000000007, new DateTime(2020, 6, 9, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(8228), 15.000154211776053 },
                    { 631, 3.4500000000000002, 3, 7.5, new DateTime(2020, 6, 9, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(8239), 15.0 },
                    { 632, 3.4487500000000004, 3, 7.5124999999999993, new DateTime(2020, 6, 9, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(8250), 15.000154211776053 },
                    { 633, 3.4475000000000002, 3, 7.5249999999999995, new DateTime(2020, 6, 9, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(8261), 15.000616837591696 },
                    { 634, 3.44625, 3, 7.5375000000000005, new DateTime(2020, 6, 9, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(8273), 15.001387848909998 },
                    { 635, 3.4450000000000003, 3, 7.5499999999999998, new DateTime(2020, 6, 9, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(8284), 15.002467198171342 },
                    { 636, 3.4437500000000001, 3, 7.5625, new DateTime(2020, 6, 9, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(8295), 15.003854818796386 },
                    { 674, 3.3962500000000002, 3, 8.0374999999999996, new DateTime(2020, 6, 10, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(8724), 15.282439179859031 },
                    { 637, 3.4425000000000003, 3, 7.5749999999999993, new DateTime(2020, 6, 9, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(8306), 15.00555062519015 },
                    { 639, 3.4400000000000004, 3, 7.5999999999999996, new DateTime(2020, 6, 9, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(8329), 15.009866357858641 },
                    { 640, 3.4387500000000002, 3, 7.6124999999999998, new DateTime(2020, 6, 9, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(8340), 15.012486017918649 },
                    { 641, 3.4375, 3, 7.625, new DateTime(2020, 6, 9, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(8351), 15.01541333133436 },
                    { 642, 3.4362500000000002, 3, 7.6375000000000002, new DateTime(2020, 6, 9, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(8363), 15.018648117535294 },
                    { 643, 3.4350000000000001, 3, 7.6500000000000004, new DateTime(2020, 6, 9, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(8374), 15.0221901769846 },
                    { 644, 3.4337500000000003, 3, 7.6624999999999996, new DateTime(2020, 6, 9, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(8385), 15.026039291191367 },
                    { 645, 3.4325000000000001, 3, 7.6749999999999998, new DateTime(2020, 6, 9, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(8397), 15.030195222724101 },
                    { 646, 3.4312500000000004, 3, 7.6875, new DateTime(2020, 6, 9, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(8408), 15.034657715225368 },
                    { 647, 3.4300000000000002, 3, 7.7000000000000002, new DateTime(2020, 6, 9, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(8419), 15.039426493427611 },
                    { 648, 3.42875, 3, 7.7125000000000004, new DateTime(2020, 6, 9, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(8431), 15.044501263170126 },
                    { 638, 3.4412500000000001, 3, 7.5875000000000004, new DateTime(2020, 6, 9, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(8318), 15.00755451274731 },
                    { 675, 3.395, 3, 8.0500000000000007, new DateTime(2020, 6, 10, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(8735), 15.295596155228873 },
                    { 676, 3.3937500000000003, 3, 8.0625, new DateTime(2020, 6, 10, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(8746), 15.30904332038758 },
                    { 677, 3.3925000000000001, 3, 8.0749999999999993, new DateTime(2020, 6, 10, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(8757), 15.322779845850663 },
                    { 704, 3.3587500000000001, 3, 8.4125000000000014, new DateTime(2020, 6, 10, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(9063), 15.799532230505292 },
                    { 705, 3.3574999999999999, 3, 8.4250000000000007, new DateTime(2020, 6, 10, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(9074), 15.820963193158649 },
                    { 706, 3.3562500000000002, 3, 8.4375, new DateTime(2020, 6, 10, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(9085), 15.842651938487272 },
                    { 707, 3.3550000000000004, 3, 8.4499999999999993, new DateTime(2020, 6, 10, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(9097), 15.864597128627191 },
                    { 708, 3.3537500000000002, 3, 8.4624999999999986, new DateTime(2020, 6, 10, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(9108), 15.886797409895699 },
                    { 709, 3.3525, 3, 8.4749999999999996, new DateTime(2020, 6, 10, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(9119), 15.909251412874882 },
                    { 710, 3.3512500000000003, 3, 8.4875000000000007, new DateTime(2020, 6, 10, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(9130), 15.931957752496064 },
                    { 711, 3.3500000000000001, 3, 8.5, new DateTime(2020, 6, 10, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(9142), 15.954915028125262 },
                    { 712, 3.3487500000000003, 3, 8.5124999999999993, new DateTime(2020, 6, 10, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(9153), 15.978121823649575 },
                    { 713, 3.3475000000000001, 3, 8.5250000000000004, new DateTime(2020, 6, 10, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(9164), 16.001576707564546 },
                    { 703, 3.3600000000000003, 3, 8.4000000000000004, new DateTime(2020, 6, 10, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(9052), 15.778360372489923 },
                    { 714, 3.3462500000000004, 3, 8.5374999999999996, new DateTime(2020, 6, 10, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(9175), 16.025278233062451 },
                    { 716, 3.34375, 3, 8.5625, new DateTime(2020, 6, 10, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(9198), 16.073415345596274 },
                    { 717, 3.3425000000000002, 3, 8.5750000000000011, new DateTime(2020, 6, 10, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(9209), 16.097847963308354 },
                    { 718, 3.3412500000000001, 3, 8.5875000000000004, new DateTime(2020, 6, 10, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(9220), 16.122521284138827 },
                    { 719, 3.3400000000000003, 3, 8.5999999999999996, new DateTime(2020, 6, 10, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(9232), 16.147433786121052 },
                    { 720, 3.3387500000000001, 3, 8.6124999999999989, new DateTime(2020, 6, 10, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(9502), 16.172583932534558 },
                    { 721, 3.3375000000000004, 3, 8.625, new DateTime(2020, 6, 10, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(9519), 16.197970171999845 },
                    { 722, 3.3362500000000002, 3, 8.6374999999999993, new DateTime(2020, 6, 10, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(9531), 16.22359093857408 },
                    { 723, 3.335, 3, 8.6500000000000004, new DateTime(2020, 6, 10, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(9542), 16.249444651847703 },
                    { 724, 3.3337500000000002, 3, 8.6624999999999996, new DateTime(2020, 6, 10, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(9554), 16.275529717041888 },
                    { 725, 3.3325, 3, 8.6750000000000007, new DateTime(2020, 6, 10, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(9565), 16.301844525106951 },
                    { 715, 3.3450000000000002, 3, 8.5500000000000007, new DateTime(2020, 6, 10, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(9187), 16.049224938121547 },
                    { 727, 3.3300000000000001, 3, 8.6999999999999993, new DateTime(2020, 6, 10, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(9588), 16.35515686289294 },
                    { 702, 3.3612500000000001, 3, 8.3874999999999993, new DateTime(2020, 6, 10, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(9040), 15.757448925092481 },
                    { 700, 3.36375, 3, 8.3625000000000007, new DateTime(2020, 6, 10, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(9018), 15.716412405674751 },
                    { 678, 3.3912500000000003, 3, 8.0875000000000004, new DateTime(2020, 6, 10, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(8769), 15.336804884284529 },
                    { 679, 3.3900000000000001, 3, 8.1000000000000014, new DateTime(2020, 6, 10, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(8780), 15.351117570558744 },
                    { 680, 3.3887499999999999, 3, 8.1125000000000007, new DateTime(2020, 6, 10, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(8791), 15.365717021799394 },
                    { 681, 3.3875000000000002, 3, 8.125, new DateTime(2020, 6, 10, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(8802), 15.380602337443566 },
                    { 682, 3.3862500000000004, 3, 8.1374999999999993, new DateTime(2020, 6, 10, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(8814), 15.395772599294869 },
                    { 683, 3.3850000000000002, 3, 8.1499999999999986, new DateTime(2020, 6, 10, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(8825), 15.411226871580093 },
                    { 684, 3.38375, 3, 8.1624999999999996, new DateTime(2020, 6, 10, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(8836), 15.426964201006932 },
                    { 685, 3.3825000000000003, 3, 8.1750000000000007, new DateTime(2020, 6, 10, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(8847), 15.442983616822774 },
                    { 686, 3.3812500000000001, 3, 8.1875, new DateTime(2020, 6, 10, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(8859), 15.459284130874593 },
                    { 687, 3.3800000000000003, 3, 8.1999999999999993, new DateTime(2020, 6, 10, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(8870), 15.475864737669902 },
                    { 701, 3.3625000000000003, 3, 8.375, new DateTime(2020, 6, 10, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(9029), 15.736799178229539 },
                    { 688, 3.3787500000000001, 3, 8.2125000000000004, new DateTime(2020, 6, 10, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(8881), 15.492724414438772 },
                    { 690, 3.3762500000000002, 3, 8.2375000000000007, new DateTime(2020, 6, 10, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(8904), 15.527276800809872 },
                    { 691, 3.375, 3, 8.25, new DateTime(2020, 6, 10, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(8916), 15.544967379058161 },
                    { 692, 3.3737500000000002, 3, 8.2625000000000011, new DateTime(2020, 6, 10, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(8927), 15.562932764703584 },
                    { 693, 3.3725000000000001, 3, 8.2750000000000004, new DateTime(2020, 6, 10, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(8938), 15.581171849556533 },
                    { 694, 3.3712500000000003, 3, 8.2874999999999996, new DateTime(2020, 6, 10, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(8949), 15.599683508544341 },
                    { 695, 3.3700000000000001, 3, 8.2999999999999989, new DateTime(2020, 6, 10, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(8961), 15.618466599780682 },
                    { 696, 3.3687500000000004, 3, 8.3125, new DateTime(2020, 6, 10, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(8972), 15.637519964636015 },
                    { 697, 3.3675000000000002, 3, 8.3249999999999993, new DateTime(2020, 6, 10, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(8983), 15.656842427809043 },
                    { 698, 3.36625, 3, 8.3375000000000004, new DateTime(2020, 6, 10, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(8995), 15.676432797399224 },
                    { 699, 3.3650000000000002, 3, 8.3499999999999996, new DateTime(2020, 6, 10, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(9006), 15.69628986498028 },
                    { 689, 3.3775000000000004, 3, 8.2249999999999996, new DateTime(2020, 6, 10, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(8893), 15.509862121196921 },
                    { 420, 3.7137500000000001, 3, 4.8624999999999998, new DateTime(2020, 6, 6, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(5456), 20.431431828989616 },
                    { 415, 3.7200000000000002, 3, 4.7999999999999998, new DateTime(2020, 6, 6, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(5398), 20.626666167821522 },
                    { 418, 3.7162500000000001, 3, 4.8375000000000004, new DateTime(2020, 6, 6, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(5433), 20.50962227897525 },
                    { 140, 4.0637499999999998, 3, 1.3625, new DateTime(2020, 6, 2, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(1808), 23.77640906142592 },
                    { 141, 4.0625, 3, 1.375, new DateTime(2020, 6, 2, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(1819), 23.802029828000155 },
                    { 142, 4.0612500000000002, 3, 1.3875000000000002, new DateTime(2020, 6, 2, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(1831), 23.827416067465442 },
                    { 143, 4.0600000000000005, 3, 1.4000000000000001, new DateTime(2020, 6, 2, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(1842), 23.852566213878944 },
                    { 144, 4.0587499999999999, 3, 1.4124999999999999, new DateTime(2020, 6, 2, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(1853), 23.877478715861173 },
                    { 145, 4.0575000000000001, 3, 1.4249999999999998, new DateTime(2020, 6, 2, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(1864), 23.90215203669165 },
                    { 146, 4.0562500000000004, 3, 1.4375, new DateTime(2020, 6, 2, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(1875), 23.926584654403726 },
                    { 147, 4.0550000000000006, 3, 1.45, new DateTime(2020, 6, 2, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(1886), 23.950775061878453 },
                    { 148, 4.05375, 3, 1.4624999999999999, new DateTime(2020, 6, 2, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(1897), 23.974721766937549 },
                    { 149, 4.0525000000000002, 3, 1.4749999999999999, new DateTime(2020, 6, 2, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(1908), 23.998423292435454 },
                    { 150, 4.0512500000000005, 3, 1.4874999999999998, new DateTime(2020, 6, 2, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(1919), 24.02187817635042 },
                    { 151, 4.0499999999999998, 3, 1.5, new DateTime(2020, 6, 2, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(1930), 24.045084971874736 },
                    { 152, 4.0487500000000001, 3, 1.5125, new DateTime(2020, 6, 2, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(1942), 24.068042247503936 },
                    { 153, 4.0475000000000003, 3, 1.5249999999999999, new DateTime(2020, 6, 2, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(1953), 24.090748587125116 },
                    { 154, 4.0462500000000006, 3, 1.5375000000000001, new DateTime(2020, 6, 2, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(1964), 24.113202590104301 },
                    { 155, 4.0449999999999999, 3, 1.55, new DateTime(2020, 6, 2, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(1975), 24.135402871372811 },
                    { 156, 4.0437500000000002, 3, 1.5625, new DateTime(2020, 6, 2, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(1986), 24.157348061512728 },
                    { 157, 4.0425000000000004, 3, 1.575, new DateTime(2020, 6, 2, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(1997), 24.179036806841353 },
                    { 158, 4.0412499999999998, 3, 1.5874999999999999, new DateTime(2020, 6, 3, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(2008), 24.200467769494708 },
                    { 159, 4.04, 3, 1.6000000000000001, new DateTime(2020, 6, 3, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(2019), 24.221639627510076 },
                    { 160, 4.0387500000000003, 3, 1.6125, new DateTime(2020, 6, 3, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(2031), 24.242551074907517 },
                    { 139, 4.0650000000000004, 3, 1.3500000000000001, new DateTime(2020, 6, 2, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(1796), 23.750555348152297 },
                    { 138, 4.0662500000000001, 3, 1.3375000000000001, new DateTime(2020, 6, 2, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(1785), 23.724470282958109 },
                    { 137, 4.0674999999999999, 3, 1.3250000000000002, new DateTime(2020, 6, 2, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(1773), 23.698155474893049 },
                    { 136, 4.0687500000000005, 3, 1.3125, new DateTime(2020, 6, 2, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(1762), 23.671612547178427 },
                    { 114, 4.0962500000000004, 3, 1.0374999999999999, new DateTime(2020, 6, 2, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(1190), 23.033411755009997 },
                    { 115, 4.0949999999999998, 3, 1.05, new DateTime(2020, 6, 2, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(1203), 23.064535268264883 },
                    { 116, 4.09375, 3, 1.0625, new DateTime(2020, 6, 2, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(1214), 23.095469746549171 },
                    { 117, 4.0925000000000002, 3, 1.075, new DateTime(2020, 6, 2, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(1225), 23.126213281678524 },
                    { 118, 4.0912500000000005, 3, 1.0874999999999999, new DateTime(2020, 6, 2, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(1236), 23.156763977246889 },
                    { 119, 4.0899999999999999, 3, 1.1000000000000001, new DateTime(2020, 6, 2, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(1247), 23.187119948743447 },
                    { 120, 4.0887500000000001, 3, 1.1125, new DateTime(2020, 6, 2, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(1258), 23.217279323668894 },
                    { 121, 4.0875000000000004, 3, 1.125, new DateTime(2020, 6, 2, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(1270), 23.247240241650918 },
                    { 122, 4.0862500000000006, 3, 1.1375, new DateTime(2020, 6, 2, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(1281), 23.27700085455897 },
                    { 123, 4.085, 3, 1.1500000000000001, new DateTime(2020, 6, 2, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(1292), 23.30655932661826 },
                    { 161, 4.0375000000000005, 3, 1.625, new DateTime(2020, 6, 3, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(2042), 24.263200821770461 },
                    { 124, 4.0837500000000002, 3, 1.1625000000000001, new DateTime(2020, 6, 2, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(1303), 23.335913834522998 },
                    { 126, 4.0812499999999998, 3, 1.1875, new DateTime(2020, 6, 2, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(1447), 23.39400372766471 },
                    { 127, 4.0800000000000001, 3, 1.2, new DateTime(2020, 6, 2, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(1496), 23.422735529643443 },
                    { 128, 4.0787500000000003, 3, 1.2124999999999999, new DateTime(2020, 6, 2, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(1520), 23.451256201172185 },
                    { 129, 4.0775000000000006, 3, 1.2250000000000001, new DateTime(2020, 6, 2, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(1539), 23.479563982961572 },
                    { 130, 4.0762499999999999, 3, 1.2375, new DateTime(2020, 6, 2, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(1580), 23.507657128854277 },
                    { 131, 4.0750000000000002, 3, 1.25, new DateTime(2020, 6, 2, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(1630), 23.535533905932738 },
                    { 132, 4.0737500000000004, 3, 1.2625, new DateTime(2020, 6, 2, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(1648), 23.563192594626027 },
                    { 133, 4.0724999999999998, 3, 1.2749999999999999, new DateTime(2020, 6, 2, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(1660), 23.590631488815944 },
                    { 134, 4.07125, 3, 1.2875000000000001, new DateTime(2020, 6, 2, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(1735), 23.617848895942245 },
                    { 135, 4.0700000000000003, 3, 1.3, new DateTime(2020, 6, 2, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(1750), 23.64484313710706 },
                    { 125, 4.0825000000000005, 3, 1.1749999999999998, new DateTime(2020, 6, 2, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(1314), 23.365062567548868 },
                    { 113, 4.0975000000000001, 3, 1.0249999999999999, new DateTime(2020, 6, 2, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(1179), 23.00210112662942 },
                    { 162, 4.0362499999999999, 3, 1.6375000000000002, new DateTime(2020, 6, 3, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(2053), 24.283587594325247 },
                    { 164, 4.0337500000000004, 3, 1.6625000000000001, new DateTime(2020, 6, 3, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(2076), 24.323567202600778 },
                    { 191, 4.0, 3, 2.0, new DateTime(2020, 6, 3, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(2374), 24.755282581475768 },
                    { 192, 3.9987500000000002, 3, 2.0125000000000002, new DateTime(2020, 6, 3, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(2385), 24.767270861595009 },
                    { 193, 3.9975000000000001, 3, 2.0250000000000004, new DateTime(2020, 6, 3, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(2396), 24.77896507399165 },
                    { 194, 3.9962500000000003, 3, 2.0374999999999996, new DateTime(2020, 6, 3, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(2407), 24.790364497311597 },
                    { 195, 3.9950000000000001, 3, 2.0499999999999998, new DateTime(2020, 6, 3, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(2418), 24.801468428384716 },
                    { 196, 3.9937500000000004, 3, 2.0625, new DateTime(2020, 6, 3, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(2429), 24.812276182268235 },
                    { 197, 3.9925000000000002, 3, 2.0749999999999997, new DateTime(2020, 6, 3, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(2440), 24.822787092288991 },
                    { 198, 3.99125, 3, 2.0874999999999999, new DateTime(2020, 6, 3, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(2451), 24.833000510084538 },
                    { 199, 3.9900000000000002, 3, 2.1000000000000001, new DateTime(2020, 6, 3, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(2462), 24.842915805643155 },
                    { 200, 3.98875, 3, 2.1124999999999998, new DateTime(2020, 6, 3, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(2473), 24.852532367342711 },
                    { 201, 3.9875000000000003, 3, 2.125, new DateTime(2020, 6, 3, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(2484), 24.861849601988382 },
                    { 202, 3.9862500000000001, 3, 2.1375000000000002, new DateTime(2020, 6, 3, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(2495), 24.870866934849246 },
                    { 203, 3.9850000000000003, 3, 2.1499999999999999, new DateTime(2020, 6, 3, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(2506), 24.879583809693735 },
                    { 204, 3.9837500000000001, 3, 2.1625000000000001, new DateTime(2020, 6, 3, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(2517), 24.887999688823953 },
                    { 205, 3.9825000000000004, 3, 2.1749999999999998, new DateTime(2020, 6, 3, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(2528), 24.896114053108828 },
                    { 206, 3.9812500000000002, 3, 2.1875, new DateTime(2020, 6, 3, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(2539), 24.903926402016154 },
                    { 207, 3.98, 3, 2.2000000000000002, new DateTime(2020, 6, 3, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(2550), 24.911436253643444 },
                    { 208, 3.9787500000000002, 3, 2.2124999999999999, new DateTime(2020, 6, 3, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(2561), 24.91864314474768 },
                    { 209, 3.9775, 3, 2.2250000000000001, new DateTime(2020, 6, 3, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(2572), 24.925546630773869 },
                    { 210, 3.9762500000000003, 3, 2.2374999999999998, new DateTime(2020, 6, 3, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(2584), 24.932146285882478 },
                    { 211, 3.9750000000000001, 3, 2.25, new DateTime(2020, 6, 3, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(2711), 24.938441702975688 },
                    { 190, 4.0012499999999998, 3, 1.9875, new DateTime(2020, 6, 3, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(2363), 24.743000973127522 },
                    { 189, 4.0025000000000004, 3, 1.9750000000000001, new DateTime(2020, 6, 3, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(2352), 24.730426794137728 },
                    { 188, 4.0037500000000001, 3, 1.9625000000000001, new DateTime(2020, 6, 3, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(2341), 24.717560820140967 },
                    { 187, 4.0049999999999999, 3, 1.9500000000000002, new DateTime(2020, 6, 3, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(2330), 24.704403844771129 },
                    { 165, 4.0324999999999998, 3, 1.675, new DateTime(2020, 6, 3, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(2087), 24.343157572190954 },
                    { 166, 4.03125, 3, 1.6875, new DateTime(2020, 6, 3, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(2098), 24.362480035363987 },
                    { 167, 4.0300000000000002, 3, 1.7000000000000002, new DateTime(2020, 6, 3, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(2109), 24.381533400219318 },
                    { 168, 4.0287500000000005, 3, 1.7125000000000001, new DateTime(2020, 6, 3, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(2120), 24.400316491455659 },
                    { 169, 4.0274999999999999, 3, 1.7249999999999999, new DateTime(2020, 6, 3, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(2131), 24.418828150443467 },
                    { 170, 4.0262500000000001, 3, 1.7374999999999998, new DateTime(2020, 6, 3, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(2142), 24.437067235296418 },
                    { 171, 4.0250000000000004, 3, 1.75, new DateTime(2020, 6, 3, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(2153), 24.455032620941839 },
                    { 172, 4.0237500000000006, 3, 1.7625, new DateTime(2020, 6, 3, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(2164), 24.472723199190124 },
                    { 173, 4.0225, 3, 1.7749999999999999, new DateTime(2020, 6, 3, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(2175), 24.490137878803075 },
                    { 174, 4.0212500000000002, 3, 1.7874999999999999, new DateTime(2020, 6, 3, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(2186), 24.507275585561228 },
                    { 163, 4.0350000000000001, 3, 1.6500000000000001, new DateTime(2020, 6, 3, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(2065), 24.30371013501972 },
                    { 175, 4.0200000000000005, 3, 1.7999999999999998, new DateTime(2020, 6, 3, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(2197), 24.524135262330098 },
                    { 177, 4.0175000000000001, 3, 1.825, new DateTime(2020, 6, 3, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(2219), 24.557016383177228 },
                    { 178, 4.0162500000000003, 3, 1.8374999999999999, new DateTime(2020, 6, 3, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(2230), 24.573035798993068 },
                    { 179, 4.0150000000000006, 3, 1.8500000000000001, new DateTime(2020, 6, 3, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(2241), 24.588773128419906 },
                    { 180, 4.0137499999999999, 3, 1.8625, new DateTime(2020, 6, 3, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(2252), 24.604227400705131 },
                    { 181, 4.0125000000000002, 3, 1.875, new DateTime(2020, 6, 3, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(2263), 24.619397662556434 },
                    { 182, 4.0112500000000004, 3, 1.8875, new DateTime(2020, 6, 3, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(2274), 24.634282978200602 },
                    { 183, 4.0099999999999998, 3, 1.8999999999999999, new DateTime(2020, 6, 3, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(2285), 24.648882429441258 },
                    { 184, 4.00875, 3, 1.9125000000000001, new DateTime(2020, 6, 3, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(2296), 24.663195115715471 },
                    { 185, 4.0075000000000003, 3, 1.925, new DateTime(2020, 6, 3, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(2308), 24.677220154149339 },
                    { 186, 4.0062500000000005, 3, 1.9375, new DateTime(2020, 6, 3, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(2319), 24.69095667961242 },
                    { 176, 4.0187499999999998, 3, 1.8125, new DateTime(2020, 6, 3, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(2208), 24.540715869125407 },
                    { 112, 4.0987499999999999, 3, 1.0125000000000002, new DateTime(2020, 6, 2, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(1166), 22.970605314510195 },
                    { 111, 4.1000000000000005, 3, 1.0, new DateTime(2020, 6, 2, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(1126), 22.938926261462367 },
                    { 110, 4.1012500000000003, 3, 0.98750000000000004, new DateTime(2020, 6, 2, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(1115), 22.907065921599152 },
                    { 37, 4.1924999999999999, 3, 0.074999999999999997, new DateTime(2020, 6, 1, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(244), 20.235532253548214 },
                    { 38, 4.1912500000000001, 3, 0.087500000000000008, new DateTime(2020, 6, 1, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(255), 20.274750899562228 },
                    { 39, 4.1900000000000004, 3, 0.10000000000000001, new DateTime(2020, 6, 1, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(266), 20.313952597646566 },
                    { 40, 4.1887499999999998, 3, 0.11249999999999999, new DateTime(2020, 6, 1, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(278), 20.353134929655834 },
                    { 41, 4.1875, 3, 0.125, new DateTime(2020, 6, 1, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(289), 20.392295478639223 },
                    { 42, 4.1862500000000002, 3, 0.13750000000000001, new DateTime(2020, 6, 1, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(300), 20.431431828989616 },
                    { 43, 4.1850000000000005, 3, 0.14999999999999999, new DateTime(2020, 6, 1, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(311), 20.470541566592573 },
                    { 44, 4.1837499999999999, 3, 0.16250000000000001, new DateTime(2020, 6, 1, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(322), 20.50962227897525 },
                    { 45, 4.1825000000000001, 3, 0.17500000000000002, new DateTime(2020, 6, 1, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(333), 20.548671555455226 },
                    { 46, 4.1812500000000004, 3, 0.1875, new DateTime(2020, 6, 1, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(344), 20.587686987289189 },
                    { 47, 4.1800000000000006, 3, 0.20000000000000001, new DateTime(2020, 6, 1, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(355), 20.626666167821522 },
                    { 48, 4.17875, 3, 0.21250000000000002, new DateTime(2020, 6, 1, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(366), 20.66560669263276 },
                    { 49, 4.1775000000000002, 3, 0.22499999999999998, new DateTime(2020, 6, 1, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(377), 20.704506159687913 },
                    { 50, 4.1762500000000005, 3, 0.23749999999999999, new DateTime(2020, 6, 1, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(388), 20.743362169484616 },
                    { 51, 4.1749999999999998, 3, 0.25, new DateTime(2020, 6, 1, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(400), 20.782172325201156 },
                    { 52, 4.1737500000000001, 3, 0.26250000000000001, new DateTime(2020, 6, 1, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(411), 20.820934232844316 },
                    { 53, 4.1725000000000003, 3, 0.27500000000000002, new DateTime(2020, 6, 1, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(422), 20.859645501397047 },
                    { 54, 4.1712500000000006, 3, 0.28750000000000003, new DateTime(2020, 6, 1, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(433), 20.898303742965961 },
                    { 55, 4.1699999999999999, 3, 0.29999999999999999, new DateTime(2020, 6, 1, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(444), 20.936906572928624 },
                    { 56, 4.1687500000000002, 3, 0.3125, new DateTime(2020, 6, 1, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(455), 20.97545161008064 },
                    { 57, 4.1675000000000004, 3, 0.32500000000000001, new DateTime(2020, 6, 1, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(467), 21.013936476782561 },
                    { 36, 4.1937500000000005, 3, 0.0625, new DateTime(2020, 6, 1, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(232), 20.196299078795342 },
                    { 35, 4.1950000000000003, 3, 0.050000000000000003, new DateTime(2020, 6, 1, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(220), 20.157053795390642 },
                    { 34, 4.19625, 3, 0.037499999999999999, new DateTime(2020, 6, 1, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(201), 20.117798824168052 },
                    { 33, 4.1974999999999998, 3, 0.025000000000000001, new DateTime(2020, 6, 1, 6, 33, 50, 613, DateTimeKind.Local).AddTicks(9858), 20.078536586559103 },
                    { 11, 4.2000000000000002, 2, 0.0, new DateTime(2020, 5, 31, 23, 13, 50, 610, DateTimeKind.Local).AddTicks(8360), 20.0 },
                    { 12, 4.1500000000000004, 2, 0.5, new DateTime(2020, 5, 31, 23, 33, 50, 613, DateTimeKind.Local).AddTicks(8051), 21.545084971874736 },
                    { 13, 4.1000000000000005, 2, 1.0, new DateTime(2020, 5, 31, 23, 53, 50, 613, DateTimeKind.Local).AddTicks(8187), 22.938926261462367 },
                    { 14, 4.0499999999999998, 2, 1.5, new DateTime(2020, 6, 1, 0, 13, 50, 613, DateTimeKind.Local).AddTicks(8208), 24.045084971874736 },
                    { 15, 4.0, 2, 2.0, new DateTime(2020, 6, 1, 0, 33, 50, 613, DateTimeKind.Local).AddTicks(8220), 24.755282581475768 },
                    { 16, 3.9500000000000002, 2, 2.5, new DateTime(2020, 6, 1, 0, 53, 50, 613, DateTimeKind.Local).AddTicks(8232), 25.0 },
                    { 17, 3.9000000000000004, 2, 3.0, new DateTime(2020, 6, 1, 1, 13, 50, 613, DateTimeKind.Local).AddTicks(8245), 24.755282581475768 },
                    { 18, 3.8500000000000001, 2, 3.5, new DateTime(2020, 6, 1, 1, 33, 50, 613, DateTimeKind.Local).AddTicks(8262), 24.045084971874736 },
                    { 19, 3.8000000000000003, 2, 4.0, new DateTime(2020, 6, 1, 1, 53, 50, 613, DateTimeKind.Local).AddTicks(8358), 22.938926261462367 },
                    { 20, 3.75, 2, 4.5, new DateTime(2020, 6, 1, 2, 13, 50, 613, DateTimeKind.Local).AddTicks(8375), 21.545084971874736 },
                    { 58, 4.1662499999999998, 3, 0.33750000000000002, new DateTime(2020, 6, 1, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(478), 21.052358799106528 },
                    { 21, 3.7000000000000002, 2, 5.0, new DateTime(2020, 6, 1, 2, 33, 50, 613, DateTimeKind.Local).AddTicks(8549), 20.0 },
                    { 23, 3.6000000000000001, 2, 6.0, new DateTime(2020, 6, 1, 3, 13, 50, 613, DateTimeKind.Local).AddTicks(8577), 17.061073738537637 },
                    { 24, 3.5500000000000003, 2, 6.5, new DateTime(2020, 6, 1, 3, 33, 50, 613, DateTimeKind.Local).AddTicks(8593), 15.954915028125264 },
                    { 25, 3.5, 2, 7.0, new DateTime(2020, 6, 1, 3, 53, 50, 613, DateTimeKind.Local).AddTicks(8605), 15.244717418524232 },
                    { 26, 3.4500000000000002, 2, 7.5, new DateTime(2020, 6, 1, 4, 13, 50, 613, DateTimeKind.Local).AddTicks(8617), 15.0 },
                    { 27, 3.4000000000000004, 2, 8.0, new DateTime(2020, 6, 1, 4, 33, 50, 613, DateTimeKind.Local).AddTicks(8629), 15.244717418524232 },
                    { 28, 3.3500000000000001, 2, 8.5, new DateTime(2020, 6, 1, 4, 53, 50, 613, DateTimeKind.Local).AddTicks(8641), 15.954915028125262 },
                    { 29, 3.3000000000000003, 2, 9.0, new DateTime(2020, 6, 1, 5, 13, 50, 613, DateTimeKind.Local).AddTicks(8653), 17.061073738537633 },
                    { 30, 3.25, 2, 9.5, new DateTime(2020, 6, 1, 5, 33, 50, 613, DateTimeKind.Local).AddTicks(8666), 18.454915028125264 },
                    { 31, 4.2000000000000002, 3, 0.0, new DateTime(2020, 6, 1, 5, 53, 50, 613, DateTimeKind.Local).AddTicks(9792), 20.0 },
                    { 32, 4.1987500000000004, 3, 0.012500000000000001, new DateTime(2020, 6, 1, 6, 13, 50, 613, DateTimeKind.Local).AddTicks(9843), 20.039269504443556 },
                    { 22, 3.6500000000000004, 2, 5.5, new DateTime(2020, 6, 1, 2, 53, 50, 613, DateTimeKind.Local).AddTicks(8565), 18.45491502812526 },
                    { 59, 4.165, 3, 0.35000000000000003, new DateTime(2020, 6, 1, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(489), 21.090716206982712 },
                    { 60, 4.1637500000000003, 3, 0.36249999999999999, new DateTime(2020, 6, 1, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(500), 21.129006334345519 },
                    { 61, 4.1625000000000005, 3, 0.375, new DateTime(2020, 6, 1, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(511), 21.167226819279527 },
                    { 88, 4.1287500000000001, 3, 0.71249999999999991, new DateTime(2020, 6, 2, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(834), 22.164362907602069 },
                    { 89, 4.1275000000000004, 3, 0.72499999999999998, new DateTime(2020, 6, 2, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(846), 22.199695849279575 },
                    { 90, 4.1262499999999998, 3, 0.73749999999999993, new DateTime(2020, 6, 2, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(858), 22.234893103355606 },
                    { 91, 4.125, 3, 0.75, new DateTime(2020, 6, 2, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(869), 22.269952498697734 },
                    { 92, 4.1237500000000002, 3, 0.76249999999999996, new DateTime(2020, 6, 2, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(880), 22.30487187267731 },
                    { 93, 4.1225000000000005, 3, 0.77500000000000002, new DateTime(2020, 6, 2, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(893), 22.339649071302865 },
                    { 94, 4.1212499999999999, 3, 0.78749999999999998, new DateTime(2020, 6, 2, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(932), 22.374281949352973 },
                    { 95, 4.1200000000000001, 3, 0.80000000000000004, new DateTime(2020, 6, 2, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(945), 22.408768370508575 },
                    { 96, 4.1187500000000004, 3, 0.8125, new DateTime(2020, 6, 2, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(957), 22.443106207484774 },
                    { 97, 4.1175000000000006, 3, 0.82500000000000007, new DateTime(2020, 6, 2, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(968), 22.477293342162039 },
                    { 87, 4.1299999999999999, 3, 0.70000000000000007, new DateTime(2020, 6, 2, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(823), 22.128896457825363 },
                    { 98, 4.11625, 3, 0.83750000000000002, new DateTime(2020, 6, 2, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(980), 22.511327665716863 },
                    { 100, 4.1137500000000005, 3, 0.86249999999999993, new DateTime(2020, 6, 2, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(1002), 22.578929491425235 },
                    { 101, 4.1124999999999998, 3, 0.875, new DateTime(2020, 6, 2, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(1013), 22.612492823579743 },
                    { 102, 4.1112500000000001, 3, 0.88749999999999996, new DateTime(2020, 6, 2, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(1024), 22.645895004870951 },
                    { 103, 4.1100000000000003, 3, 0.89999999999999991, new DateTime(2020, 6, 2, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(1036), 22.679133974894985 },
                    { 104, 4.1087500000000006, 3, 0.91249999999999998, new DateTime(2020, 6, 2, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(1047), 22.712207683315594 },
                    { 105, 4.1074999999999999, 3, 0.92500000000000004, new DateTime(2020, 6, 2, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(1059), 22.745114089990658 },
                    { 106, 4.1062500000000002, 3, 0.9375, new DateTime(2020, 6, 2, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(1070), 22.77785116509801 },
                    { 107, 4.1050000000000004, 3, 0.94999999999999996, new DateTime(2020, 6, 2, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(1081), 22.810416889260651 },
                    { 108, 4.1037499999999998, 3, 0.96250000000000002, new DateTime(2020, 6, 2, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(1093), 22.842809253671319 },
                    { 109, 4.1025, 3, 0.97500000000000009, new DateTime(2020, 6, 2, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(1104), 22.875026260216394 },
                    { 99, 4.1150000000000002, 3, 0.85000000000000009, new DateTime(2020, 6, 2, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(991), 22.545207078751858 },
                    { 212, 3.9737500000000003, 3, 2.2625000000000002, new DateTime(2020, 6, 3, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(2726), 24.944432493722523 },
                    { 86, 4.1312500000000005, 3, 0.6875, new DateTime(2020, 6, 2, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(811), 22.093298687687142 },
                    { 84, 4.13375, 3, 0.66250000000000009, new DateTime(2020, 6, 1, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(789), 22.021717977643725 },
                    { 62, 4.1612499999999999, 3, 0.38750000000000001, new DateTime(2020, 6, 1, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(522), 21.205375304165194 },
                    { 63, 4.1600000000000001, 3, 0.40000000000000002, new DateTime(2020, 6, 1, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(534), 21.243449435824274 },
                    { 64, 4.1587500000000004, 3, 0.41250000000000003, new DateTime(2020, 6, 1, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(545), 21.281446865664982 },
                    { 65, 4.1574999999999998, 3, 0.42500000000000004, new DateTime(2020, 6, 1, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(556), 21.319365249826866 },
                    { 66, 4.15625, 3, 0.4375, new DateTime(2020, 6, 1, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(570), 21.357202249325372 },
                    { 67, 4.1550000000000002, 3, 0.44999999999999996, new DateTime(2020, 6, 1, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(582), 21.394955530196146 },
                    { 68, 4.1537500000000005, 3, 0.46250000000000002, new DateTime(2020, 6, 1, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(593), 21.432622763638992 },
                    { 69, 4.1524999999999999, 3, 0.47499999999999998, new DateTime(2020, 6, 1, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(605), 21.470201626161519 },
                    { 70, 4.1512500000000001, 3, 0.48750000000000004, new DateTime(2020, 6, 1, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(616), 21.507689799722478 },
                    { 71, 4.1500000000000004, 3, 0.5, new DateTime(2020, 6, 1, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(627), 21.545084971874736 },
                    { 85, 4.1325000000000003, 3, 0.67500000000000004, new DateTime(2020, 6, 1, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(800), 22.057571793025545 },
                    { 72, 4.1487500000000006, 3, 0.51249999999999996, new DateTime(2020, 6, 1, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(638), 21.582384835907931 },
                    { 74, 4.1462500000000002, 3, 0.53749999999999998, new DateTime(2020, 6, 1, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(675), 21.656689442312853 },
                    { 75, 4.1450000000000005, 3, 0.55000000000000004, new DateTime(2020, 6, 1, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(687), 21.693689601226456 },
                    { 76, 4.1437499999999998, 3, 0.5625, new DateTime(2020, 6, 1, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(698), 21.730585285387466 },
                    { 77, 4.1425000000000001, 3, 0.57500000000000007, new DateTime(2020, 6, 1, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(709), 21.767374218896286 },
                    { 78, 4.1412500000000003, 3, 0.58749999999999991, new DateTime(2020, 6, 1, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(720), 21.80405413243821 },
                    { 79, 4.1400000000000006, 3, 0.59999999999999998, new DateTime(2020, 6, 1, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(732), 21.84062276342339 },
                    { 80, 4.1387499999999999, 3, 0.61250000000000004, new DateTime(2020, 6, 1, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(744), 21.877077856126416 },
                    { 81, 4.1375000000000002, 3, 0.625, new DateTime(2020, 6, 1, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(755), 21.91341716182545 },
                    { 82, 4.1362500000000004, 3, 0.63749999999999996, new DateTime(2020, 6, 1, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(766), 21.949638438940941 },
                    { 83, 4.1349999999999998, 3, 0.65000000000000002, new DateTime(2020, 6, 1, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(778), 21.985739453173903 },
                    { 73, 4.1475, 3, 0.52500000000000002, new DateTime(2020, 6, 1, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(662), 21.619587090990748 },
                    { 213, 3.9725000000000001, 3, 2.2749999999999999, new DateTime(2020, 6, 3, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(2738), 24.950118288582786 },
                    { 214, 3.9712500000000004, 3, 2.2875000000000001, new DateTime(2020, 6, 3, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(2749), 24.955498736829874 },
                    { 215, 3.9700000000000002, 3, 2.3000000000000003, new DateTime(2020, 6, 3, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(2760), 24.960573506572388 },
                    { 345, 3.8075000000000001, 3, 3.9250000000000003, new DateTime(2020, 6, 5, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(4481), 23.126213281678524 },
                    { 346, 3.8062500000000004, 3, 3.9375, new DateTime(2020, 6, 5, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(4493), 23.095469746549171 },
                    { 347, 3.8050000000000002, 3, 3.9500000000000002, new DateTime(2020, 6, 5, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(4505), 23.064535268264883 },
                    { 348, 3.80375, 3, 3.9624999999999999, new DateTime(2020, 6, 5, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(4517), 23.033411755009997 },
                    { 349, 3.8025000000000002, 3, 3.9750000000000001, new DateTime(2020, 6, 5, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(4529), 23.00210112662942 },
                    { 350, 3.80125, 3, 3.9874999999999998, new DateTime(2020, 6, 5, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(4541), 22.970605314510195 },
                    { 351, 3.8000000000000003, 3, 4.0, new DateTime(2020, 6, 5, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(4553), 22.938926261462367 },
                    { 352, 3.7987500000000001, 3, 4.0125000000000002, new DateTime(2020, 6, 5, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(4564), 22.907065921599155 },
                    { 353, 3.7975000000000003, 3, 4.0250000000000004, new DateTime(2020, 6, 5, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(4576), 22.875026260216391 },
                    { 354, 3.7962500000000001, 3, 4.0374999999999996, new DateTime(2020, 6, 5, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(4588), 22.842809253671319 },
                    { 355, 3.7949999999999999, 3, 4.0500000000000007, new DateTime(2020, 6, 5, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(4599), 22.810416889260651 },
                    { 356, 3.7937500000000002, 3, 4.0625, new DateTime(2020, 6, 5, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(4611), 22.77785116509801 },
                    { 357, 3.7925000000000004, 3, 4.0749999999999993, new DateTime(2020, 6, 5, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(4623), 22.745114089990661 },
                    { 358, 3.7912500000000002, 3, 4.0875000000000004, new DateTime(2020, 6, 5, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(4635), 22.712207683315594 },
                    { 359, 3.79, 3, 4.0999999999999996, new DateTime(2020, 6, 5, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(4646), 22.679133974894985 },
                    { 360, 3.7887500000000003, 3, 4.1124999999999998, new DateTime(2020, 6, 5, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(4658), 22.645895004870955 },
                    { 361, 3.7875000000000001, 3, 4.125, new DateTime(2020, 6, 5, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(4669), 22.612492823579743 },
                    { 362, 3.7862500000000003, 3, 4.1375000000000002, new DateTime(2020, 6, 5, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(4681), 22.578929491425239 },
                    { 363, 3.7850000000000001, 3, 4.1499999999999995, new DateTime(2020, 6, 5, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(4693), 22.545207078751858 },
                    { 364, 3.7837500000000004, 3, 4.1624999999999996, new DateTime(2020, 6, 5, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(4704), 22.511327665716863 },
                    { 365, 3.7825000000000002, 3, 4.1749999999999998, new DateTime(2020, 6, 5, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(4716), 22.477293342162039 },
                    { 344, 3.8087500000000003, 3, 3.9124999999999996, new DateTime(2020, 6, 5, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(4470), 23.156763977246889 },
                    { 343, 3.8100000000000001, 3, 3.9000000000000004, new DateTime(2020, 6, 5, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(4458), 23.187119948743451 },
                    { 342, 3.8112500000000002, 3, 3.8874999999999997, new DateTime(2020, 6, 5, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(4446), 23.217279323668894 },
                    { 341, 3.8125, 3, 3.875, new DateTime(2020, 6, 5, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(4435), 23.247240241650918 },
                    { 319, 3.8400000000000003, 3, 3.5999999999999996, new DateTime(2020, 6, 5, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(4180), 23.852566213878944 },
                    { 320, 3.8387500000000001, 3, 3.6125000000000003, new DateTime(2020, 6, 5, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(4192), 23.827416067465442 },
                    { 321, 3.8375000000000004, 3, 3.625, new DateTime(2020, 6, 5, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(4203), 23.802029828000155 },
                    { 322, 3.8362500000000002, 3, 3.6375000000000002, new DateTime(2020, 6, 5, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(4214), 23.77640906142592 },
                    { 323, 3.835, 3, 3.6499999999999999, new DateTime(2020, 6, 5, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(4226), 23.750555348152297 },
                    { 324, 3.8337500000000002, 3, 3.6625000000000001, new DateTime(2020, 6, 5, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(4237), 23.724470282958109 },
                    { 325, 3.8325, 3, 3.6749999999999998, new DateTime(2020, 6, 5, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(4249), 23.698155474893049 },
                    { 326, 3.8312500000000003, 3, 3.6875, new DateTime(2020, 6, 5, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(4260), 23.671612547178427 },
                    { 327, 3.8300000000000001, 3, 3.7000000000000002, new DateTime(2020, 6, 5, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(4272), 23.644843137107056 },
                    { 328, 3.8287500000000003, 3, 3.7125000000000004, new DateTime(2020, 6, 5, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(4283), 23.617848895942245 },
                    { 366, 3.78125, 3, 4.1875, new DateTime(2020, 6, 5, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(4727), 22.443106207484774 },
                    { 329, 3.8275000000000001, 3, 3.7250000000000001, new DateTime(2020, 6, 5, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(4295), 23.590631488815944 },
                    { 331, 3.8250000000000002, 3, 3.75, new DateTime(2020, 6, 5, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(4318), 23.535533905932738 },
                    { 332, 3.8237500000000004, 3, 3.7624999999999997, new DateTime(2020, 6, 5, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(4329), 23.50765712885428 },
                    { 333, 3.8225000000000002, 3, 3.7749999999999999, new DateTime(2020, 6, 5, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(4341), 23.479563982961572 },
                    { 334, 3.82125, 3, 3.7874999999999996, new DateTime(2020, 6, 5, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(4352), 23.451256201172185 },
                    { 335, 3.8200000000000003, 3, 3.7999999999999998, new DateTime(2020, 6, 5, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(4364), 23.422735529643443 },
                    { 336, 3.8187500000000001, 3, 3.8125, new DateTime(2020, 6, 5, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(4375), 23.39400372766471 },
                    { 337, 3.8175000000000003, 3, 3.8250000000000002, new DateTime(2020, 6, 5, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(4387), 23.365062567548868 },
                    { 338, 3.8162500000000001, 3, 3.8374999999999999, new DateTime(2020, 6, 5, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(4398), 23.335913834522998 },
                    { 339, 3.8150000000000004, 3, 3.8500000000000001, new DateTime(2020, 6, 5, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(4410), 23.30655932661826 },
                    { 340, 3.8137500000000002, 3, 3.8624999999999998, new DateTime(2020, 6, 5, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(4423), 23.27700085455897 },
                    { 330, 3.8262499999999999, 3, 3.7375000000000003, new DateTime(2020, 6, 5, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(4306), 23.563192594626027 },
                    { 367, 3.7800000000000002, 3, 4.2000000000000002, new DateTime(2020, 6, 5, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(4739), 22.408768370508579 },
                    { 368, 3.7787500000000001, 3, 4.2125000000000004, new DateTime(2020, 6, 5, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(4751), 22.374281949352973 },
                    { 369, 3.7775000000000003, 3, 4.2249999999999996, new DateTime(2020, 6, 5, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(4762), 22.339649071302865 },
                    { 396, 3.7437500000000004, 3, 4.5625, new DateTime(2020, 6, 6, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(5180), 21.357202249325372 },
                    { 397, 3.7425000000000002, 3, 4.5750000000000002, new DateTime(2020, 6, 6, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(5191), 21.319365249826863 },
                    { 398, 3.74125, 3, 4.5875000000000004, new DateTime(2020, 6, 6, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(5203), 21.281446865664982 },
                    { 399, 3.7400000000000002, 3, 4.6000000000000005, new DateTime(2020, 6, 6, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(5214), 21.243449435824274 },
                    { 400, 3.73875, 3, 4.6124999999999998, new DateTime(2020, 6, 6, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(5226), 21.205375304165194 },
                    { 401, 3.7375000000000003, 3, 4.625, new DateTime(2020, 6, 6, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(5237), 21.167226819279527 },
                    { 402, 3.7362500000000001, 3, 4.6375000000000002, new DateTime(2020, 6, 6, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(5249), 21.129006334345519 },
                    { 403, 3.7350000000000003, 3, 4.6500000000000004, new DateTime(2020, 6, 6, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(5260), 21.090716206982712 },
                    { 404, 3.7337500000000001, 3, 4.6624999999999996, new DateTime(2020, 6, 6, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(5272), 21.052358799106528 },
                    { 405, 3.7324999999999999, 3, 4.6750000000000007, new DateTime(2020, 6, 6, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(5283), 21.013936476782561 },
                    { 395, 3.7450000000000001, 3, 4.5499999999999998, new DateTime(2020, 6, 6, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(5168), 21.394955530196146 },
                    { 406, 3.7312500000000002, 3, 4.6875, new DateTime(2020, 6, 6, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(5295), 20.975451610080643 },
                    { 408, 3.7287500000000002, 3, 4.7125000000000004, new DateTime(2020, 6, 6, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(5317), 20.898303742965961 },
                    { 409, 3.7275, 3, 4.7249999999999996, new DateTime(2020, 6, 6, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(5329), 20.859645501397051 },
                    { 410, 3.7262500000000003, 3, 4.7374999999999998, new DateTime(2020, 6, 6, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(5341), 20.820934232844316 },
                    { 411, 3.7250000000000001, 3, 4.75, new DateTime(2020, 6, 6, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(5352), 20.782172325201156 },
                    { 412, 3.7237500000000003, 3, 4.7625000000000002, new DateTime(2020, 6, 6, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(5364), 20.743362169484616 },
                    { 413, 3.7225000000000001, 3, 4.7749999999999995, new DateTime(2020, 6, 6, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(5375), 20.704506159687913 },
                    { 414, 3.7212500000000004, 3, 4.7874999999999996, new DateTime(2020, 6, 6, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(5386), 20.665606692632764 },
                    { 829, 3.2025000000000001, 3, 9.9750000000000014, new DateTime(2020, 6, 12, 7, 53, 50, 615, DateTimeKind.Local).AddTicks(747), 19.921463413440897 },
                    { 416, 3.71875, 3, 4.8125, new DateTime(2020, 6, 6, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(5410), 20.587686987289189 },
                    { 417, 3.7175000000000002, 3, 4.8250000000000002, new DateTime(2020, 6, 6, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(5422), 20.548671555455229 },
                    { 407, 3.7300000000000004, 3, 4.6999999999999993, new DateTime(2020, 6, 6, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(5306), 20.936906572928624 },
                    { 318, 3.8412500000000001, 3, 3.5875000000000004, new DateTime(2020, 6, 5, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(4169), 23.877478715861173 },
                    { 394, 3.7462500000000003, 3, 4.5374999999999996, new DateTime(2020, 6, 6, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(5157), 21.432622763638992 },
                    { 392, 3.7487500000000002, 3, 4.5125000000000002, new DateTime(2020, 6, 6, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(5134), 21.507689799722478 },
                    { 370, 3.7762500000000001, 3, 4.2374999999999998, new DateTime(2020, 6, 5, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(4774), 22.30487187267731 },
                    { 371, 3.7750000000000004, 3, 4.25, new DateTime(2020, 6, 5, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(4785), 22.269952498697734 },
                    { 372, 3.7737500000000002, 3, 4.2625000000000002, new DateTime(2020, 6, 5, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(4797), 22.234893103355606 },
                    { 373, 3.7725, 3, 4.2750000000000004, new DateTime(2020, 6, 5, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(4809), 22.199695849279578 },
                    { 374, 3.7712500000000002, 3, 4.2875000000000005, new DateTime(2020, 6, 6, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(4820), 22.164362907602069 },
                    { 375, 3.77, 3, 4.2999999999999998, new DateTime(2020, 6, 6, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(4832), 22.128896457825363 },
                    { 376, 3.7687500000000003, 3, 4.3125, new DateTime(2020, 6, 6, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(4844), 22.093298687687138 },
                    { 377, 3.7675000000000001, 3, 4.3250000000000002, new DateTime(2020, 6, 6, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(4855), 22.057571793025545 },
                    { 378, 3.7662500000000003, 3, 4.3375000000000004, new DateTime(2020, 6, 6, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(4867), 22.021717977643725 },
                    { 379, 3.7650000000000001, 3, 4.3499999999999996, new DateTime(2020, 6, 6, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(4878), 21.985739453173903 },
                    { 393, 3.7475000000000001, 3, 4.5250000000000004, new DateTime(2020, 6, 6, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(5145), 21.470201626161522 },
                    { 380, 3.7637499999999999, 3, 4.3625000000000007, new DateTime(2020, 6, 6, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(4990), 21.949638438940941 },
                    { 382, 3.7612500000000004, 3, 4.3874999999999993, new DateTime(2020, 6, 6, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(5018), 21.877077856126416 },
                    { 383, 3.7600000000000002, 3, 4.4000000000000004, new DateTime(2020, 6, 6, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(5030), 21.84062276342339 },
                    { 384, 3.75875, 3, 4.4124999999999996, new DateTime(2020, 6, 6, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(5041), 21.80405413243821 },
                    { 385, 3.7575000000000003, 3, 4.4249999999999998, new DateTime(2020, 6, 6, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(5053), 21.767374218896286 },
                    { 386, 3.7562500000000001, 3, 4.4375, new DateTime(2020, 6, 6, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(5065), 21.730585285387466 },
                    { 387, 3.7550000000000003, 3, 4.4500000000000002, new DateTime(2020, 6, 6, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(5077), 21.693689601226456 },
                    { 388, 3.7537500000000001, 3, 4.4624999999999995, new DateTime(2020, 6, 6, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(5088), 21.656689442312857 },
                    { 389, 3.7525000000000004, 3, 4.4749999999999996, new DateTime(2020, 6, 6, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(5100), 21.619587090990748 },
                    { 390, 3.7512500000000002, 3, 4.4874999999999998, new DateTime(2020, 6, 6, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(5111), 21.582384835907931 },
                    { 391, 3.75, 3, 4.5, new DateTime(2020, 6, 6, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(5123), 21.545084971874736 },
                    { 381, 3.7625000000000002, 3, 4.375, new DateTime(2020, 6, 6, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(5006), 21.91341716182545 },
                    { 419, 3.7150000000000003, 3, 4.8499999999999996, new DateTime(2020, 6, 6, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(5445), 20.470541566592573 },
                    { 317, 3.8425000000000002, 3, 3.5749999999999997, new DateTime(2020, 6, 5, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(4157), 23.90215203669165 },
                    { 315, 3.8450000000000002, 3, 3.5499999999999998, new DateTime(2020, 6, 5, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(4134), 23.950775061878453 },
                    { 242, 3.9362500000000002, 3, 2.6374999999999997, new DateTime(2020, 6, 4, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(3060), 24.981351882464708 },
                    { 243, 3.9350000000000001, 3, 2.6500000000000004, new DateTime(2020, 6, 4, 4, 33, 50, 614, DateTimeKind.Local).AddTicks(3071), 24.977809823015399 },
                    { 244, 3.9337500000000003, 3, 2.6624999999999996, new DateTime(2020, 6, 4, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(3082), 24.973960708808633 },
                    { 245, 3.9325000000000001, 3, 2.6750000000000003, new DateTime(2020, 6, 4, 5, 13, 50, 614, DateTimeKind.Local).AddTicks(3093), 24.969804777275897 },
                    { 246, 3.9312500000000004, 3, 2.6875, new DateTime(2020, 6, 4, 5, 33, 50, 614, DateTimeKind.Local).AddTicks(3105), 24.965342284774632 },
                    { 247, 3.9300000000000002, 3, 2.7000000000000002, new DateTime(2020, 6, 4, 5, 53, 50, 614, DateTimeKind.Local).AddTicks(3116), 24.960573506572388 },
                    { 248, 3.92875, 3, 2.7124999999999999, new DateTime(2020, 6, 4, 6, 13, 50, 614, DateTimeKind.Local).AddTicks(3127), 24.955498736829874 },
                    { 249, 3.9275000000000002, 3, 2.7250000000000001, new DateTime(2020, 6, 4, 6, 33, 50, 614, DateTimeKind.Local).AddTicks(3138), 24.950118288582786 },
                    { 250, 3.92625, 3, 2.7374999999999998, new DateTime(2020, 6, 4, 6, 53, 50, 614, DateTimeKind.Local).AddTicks(3149), 24.944432493722523 },
                    { 251, 3.9250000000000003, 3, 2.75, new DateTime(2020, 6, 4, 7, 13, 50, 614, DateTimeKind.Local).AddTicks(3160), 24.938441702975688 },
                    { 252, 3.9237500000000001, 3, 2.7625000000000002, new DateTime(2020, 6, 4, 7, 33, 50, 614, DateTimeKind.Local).AddTicks(3171), 24.932146285882478 },
                    { 253, 3.9225000000000003, 3, 2.7750000000000004, new DateTime(2020, 6, 4, 7, 53, 50, 614, DateTimeKind.Local).AddTicks(3182), 24.925546630773869 },
                    { 254, 3.9212500000000001, 3, 2.7875000000000001, new DateTime(2020, 6, 4, 8, 13, 50, 614, DateTimeKind.Local).AddTicks(3193), 24.91864314474768 },
                    { 255, 3.9199999999999999, 3, 2.8000000000000003, new DateTime(2020, 6, 4, 8, 33, 50, 614, DateTimeKind.Local).AddTicks(3204), 24.911436253643444 },
                    { 256, 3.9187500000000002, 3, 2.8125, new DateTime(2020, 6, 4, 8, 53, 50, 614, DateTimeKind.Local).AddTicks(3215), 24.903926402016154 },
                    { 257, 3.9175000000000004, 3, 2.8249999999999997, new DateTime(2020, 6, 4, 9, 13, 50, 614, DateTimeKind.Local).AddTicks(3226), 24.896114053108828 },
                    { 258, 3.9162500000000002, 3, 2.8374999999999999, new DateTime(2020, 6, 4, 9, 33, 50, 614, DateTimeKind.Local).AddTicks(3243), 24.887999688823953 },
                    { 259, 3.915, 3, 2.8499999999999996, new DateTime(2020, 6, 4, 9, 53, 50, 614, DateTimeKind.Local).AddTicks(3255), 24.879583809693738 },
                    { 260, 3.9137500000000003, 3, 2.8624999999999998, new DateTime(2020, 6, 4, 10, 13, 50, 614, DateTimeKind.Local).AddTicks(3266), 24.870866934849246 },
                    { 261, 3.9125000000000001, 3, 2.875, new DateTime(2020, 6, 4, 10, 33, 50, 614, DateTimeKind.Local).AddTicks(3277), 24.861849601988382 },
                    { 262, 3.9112500000000003, 3, 2.8875000000000002, new DateTime(2020, 6, 4, 10, 53, 50, 614, DateTimeKind.Local).AddTicks(3288), 24.852532367342711 },
                    { 241, 3.9375, 3, 2.625, new DateTime(2020, 6, 4, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(3049), 24.984586668665639 },
                    { 240, 3.9387500000000002, 3, 2.6124999999999998, new DateTime(2020, 6, 4, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(3038), 24.987513982081353 },
                    { 239, 3.9400000000000004, 3, 2.6000000000000001, new DateTime(2020, 6, 4, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(3027), 24.990133642141359 },
                    { 238, 3.9412500000000001, 3, 2.5874999999999999, new DateTime(2020, 6, 4, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(3016), 24.992445487252688 },
                    { 216, 3.96875, 3, 2.3125, new DateTime(2020, 6, 3, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(2772), 24.965342284774632 },
                    { 217, 3.9675000000000002, 3, 2.3250000000000002, new DateTime(2020, 6, 3, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(2783), 24.969804777275897 },
                    { 218, 3.9662500000000001, 3, 2.3375000000000004, new DateTime(2020, 6, 3, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(2794), 24.973960708808633 },
                    { 219, 3.9650000000000003, 3, 2.3499999999999996, new DateTime(2020, 6, 3, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(2805), 24.977809823015399 },
                    { 220, 3.9637500000000001, 3, 2.3624999999999998, new DateTime(2020, 6, 3, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(2816), 24.981351882464708 },
                    { 221, 3.9625000000000004, 3, 2.375, new DateTime(2020, 6, 3, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(2827), 24.984586668665639 },
                    { 222, 3.9612500000000002, 3, 2.3874999999999997, new DateTime(2020, 6, 3, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(2838), 24.987513982081349 },
                    { 223, 3.96, 3, 2.3999999999999999, new DateTime(2020, 6, 3, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(2849), 24.990133642141359 },
                    { 224, 3.9587500000000002, 3, 2.4125000000000001, new DateTime(2020, 6, 3, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(2860), 24.992445487252688 },
                    { 225, 3.9575, 3, 2.4249999999999998, new DateTime(2020, 6, 3, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(2872), 24.99444937480985 },
                    { 263, 3.9100000000000001, 3, 2.8999999999999999, new DateTime(2020, 6, 4, 11, 13, 50, 614, DateTimeKind.Local).AddTicks(3299), 24.842915805643155 },
                    { 226, 3.9562500000000003, 3, 2.4375, new DateTime(2020, 6, 3, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(2883), 24.996145181203616 },
                    { 228, 3.9537500000000003, 3, 2.4624999999999999, new DateTime(2020, 6, 3, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(2905), 24.998612151090001 },
                    { 229, 3.9525000000000001, 3, 2.4750000000000001, new DateTime(2020, 6, 3, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(2916), 24.999383162408304 },
                    { 230, 3.9512500000000004, 3, 2.4874999999999998, new DateTime(2020, 6, 4, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(2927), 24.999845788223947 },
                    { 231, 3.9500000000000002, 3, 2.5, new DateTime(2020, 6, 4, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(2938), 25.0 },
                    { 232, 3.9487500000000004, 3, 2.5124999999999997, new DateTime(2020, 6, 4, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(2950), 24.999845788223947 },
                    { 233, 3.9475000000000002, 3, 2.5249999999999999, new DateTime(2020, 6, 4, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(2961), 24.999383162408304 },
                    { 234, 3.94625, 3, 2.5374999999999996, new DateTime(2020, 6, 4, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(2972), 24.998612151090001 },
                    { 235, 3.9450000000000003, 3, 2.5499999999999998, new DateTime(2020, 6, 4, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(2983), 24.997532801828658 },
                    { 236, 3.9437500000000001, 3, 2.5625, new DateTime(2020, 6, 4, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(2994), 24.996145181203616 },
                    { 237, 3.9425000000000003, 3, 2.5750000000000002, new DateTime(2020, 6, 4, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(3005), 24.99444937480985 },
                    { 227, 3.9550000000000001, 3, 2.4500000000000002, new DateTime(2020, 6, 3, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(2894), 24.997532801828658 },
                    { 264, 3.9087500000000004, 3, 2.9125000000000001, new DateTime(2020, 6, 4, 11, 33, 50, 614, DateTimeKind.Local).AddTicks(3310), 24.833000510084538 },
                    { 265, 3.9075000000000002, 3, 2.9249999999999998, new DateTime(2020, 6, 4, 11, 53, 50, 614, DateTimeKind.Local).AddTicks(3321), 24.822787092288991 },
                    { 266, 3.90625, 3, 2.9375, new DateTime(2020, 6, 4, 12, 13, 50, 614, DateTimeKind.Local).AddTicks(3339), 24.812276182268235 },
                    { 293, 3.8725000000000001, 3, 3.2750000000000004, new DateTime(2020, 6, 4, 21, 13, 50, 614, DateTimeKind.Local).AddTicks(3881), 24.418828150443467 },
                    { 294, 3.8712500000000003, 3, 3.2874999999999996, new DateTime(2020, 6, 4, 21, 33, 50, 614, DateTimeKind.Local).AddTicks(3893), 24.400316491455662 },
                    { 295, 3.8700000000000001, 3, 3.3000000000000003, new DateTime(2020, 6, 4, 21, 53, 50, 614, DateTimeKind.Local).AddTicks(3904), 24.381533400219318 },
                    { 296, 3.8687500000000004, 3, 3.3125, new DateTime(2020, 6, 4, 22, 13, 50, 614, DateTimeKind.Local).AddTicks(3916), 24.362480035363987 },
                    { 297, 3.8675000000000002, 3, 3.3250000000000002, new DateTime(2020, 6, 4, 22, 33, 50, 614, DateTimeKind.Local).AddTicks(3927), 24.343157572190954 },
                    { 298, 3.86625, 3, 3.3374999999999999, new DateTime(2020, 6, 4, 22, 53, 50, 614, DateTimeKind.Local).AddTicks(3938), 24.323567202600778 },
                    { 299, 3.8650000000000002, 3, 3.3500000000000001, new DateTime(2020, 6, 4, 23, 13, 50, 614, DateTimeKind.Local).AddTicks(3950), 24.30371013501972 },
                    { 300, 3.86375, 3, 3.3624999999999998, new DateTime(2020, 6, 4, 23, 33, 50, 614, DateTimeKind.Local).AddTicks(3961), 24.283587594325247 },
                    { 301, 3.8625000000000003, 3, 3.375, new DateTime(2020, 6, 4, 23, 53, 50, 614, DateTimeKind.Local).AddTicks(3973), 24.263200821770461 },
                    { 302, 3.8612500000000001, 3, 3.3875000000000002, new DateTime(2020, 6, 5, 0, 13, 50, 614, DateTimeKind.Local).AddTicks(3984), 24.242551074907517 },
                    { 292, 3.8737500000000002, 3, 3.2624999999999997, new DateTime(2020, 6, 4, 20, 53, 50, 614, DateTimeKind.Local).AddTicks(3870), 24.437067235296418 },
                    { 303, 3.8600000000000003, 3, 3.4000000000000004, new DateTime(2020, 6, 5, 0, 33, 50, 614, DateTimeKind.Local).AddTicks(3996), 24.221639627510076 },
                    { 305, 3.8574999999999999, 3, 3.4250000000000003, new DateTime(2020, 6, 5, 1, 13, 50, 614, DateTimeKind.Local).AddTicks(4019), 24.179036806841353 },
                    { 306, 3.8562500000000002, 3, 3.4375, new DateTime(2020, 6, 5, 1, 33, 50, 614, DateTimeKind.Local).AddTicks(4030), 24.157348061512728 },
                    { 307, 3.8550000000000004, 3, 3.4499999999999997, new DateTime(2020, 6, 5, 1, 53, 50, 614, DateTimeKind.Local).AddTicks(4042), 24.135402871372811 },
                    { 308, 3.8537500000000002, 3, 3.4624999999999999, new DateTime(2020, 6, 5, 2, 13, 50, 614, DateTimeKind.Local).AddTicks(4053), 24.113202590104301 },
                    { 309, 3.8525, 3, 3.4749999999999996, new DateTime(2020, 6, 5, 2, 33, 50, 614, DateTimeKind.Local).AddTicks(4065), 24.09074858712512 },
                    { 310, 3.8512500000000003, 3, 3.4874999999999998, new DateTime(2020, 6, 5, 2, 53, 50, 614, DateTimeKind.Local).AddTicks(4076), 24.068042247503936 },
                    { 311, 3.8500000000000001, 3, 3.5, new DateTime(2020, 6, 5, 3, 13, 50, 614, DateTimeKind.Local).AddTicks(4088), 24.045084971874736 },
                    { 312, 3.8487500000000003, 3, 3.5125000000000002, new DateTime(2020, 6, 5, 3, 33, 50, 614, DateTimeKind.Local).AddTicks(4099), 24.021878176350423 },
                    { 313, 3.8475000000000001, 3, 3.5249999999999999, new DateTime(2020, 6, 5, 3, 53, 50, 614, DateTimeKind.Local).AddTicks(4111), 23.998423292435454 },
                    { 314, 3.8462500000000004, 3, 3.5375000000000001, new DateTime(2020, 6, 5, 4, 13, 50, 614, DateTimeKind.Local).AddTicks(4123), 23.974721766937549 },
                    { 304, 3.8587500000000001, 3, 3.4125000000000001, new DateTime(2020, 6, 5, 0, 53, 50, 614, DateTimeKind.Local).AddTicks(4007), 24.200467769494711 },
                    { 316, 3.84375, 3, 3.5625, new DateTime(2020, 6, 5, 4, 53, 50, 614, DateTimeKind.Local).AddTicks(4145), 23.926584654403726 },
                    { 291, 3.875, 3, 3.25, new DateTime(2020, 6, 4, 20, 33, 50, 614, DateTimeKind.Local).AddTicks(3858), 24.455032620941839 },
                    { 289, 3.8775000000000004, 3, 3.2250000000000001, new DateTime(2020, 6, 4, 19, 53, 50, 614, DateTimeKind.Local).AddTicks(3835), 24.490137878803079 },
                    { 267, 3.9050000000000002, 3, 2.9499999999999997, new DateTime(2020, 6, 4, 12, 33, 50, 614, DateTimeKind.Local).AddTicks(3564), 24.801468428384716 },
                    { 268, 3.9037500000000001, 3, 2.9625000000000004, new DateTime(2020, 6, 4, 12, 53, 50, 614, DateTimeKind.Local).AddTicks(3593), 24.790364497311597 },
                    { 269, 3.9025000000000003, 3, 2.9749999999999996, new DateTime(2020, 6, 4, 13, 13, 50, 614, DateTimeKind.Local).AddTicks(3605), 24.77896507399165 },
                    { 270, 3.9012500000000001, 3, 2.9875000000000003, new DateTime(2020, 6, 4, 13, 33, 50, 614, DateTimeKind.Local).AddTicks(3616), 24.767270861595005 },
                    { 271, 3.9000000000000004, 3, 3.0, new DateTime(2020, 6, 4, 13, 53, 50, 614, DateTimeKind.Local).AddTicks(3628), 24.755282581475768 },
                    { 272, 3.8987500000000002, 3, 3.0125000000000002, new DateTime(2020, 6, 4, 14, 13, 50, 614, DateTimeKind.Local).AddTicks(3639), 24.743000973127522 },
                    { 273, 3.8975, 3, 3.0249999999999999, new DateTime(2020, 6, 4, 14, 33, 50, 614, DateTimeKind.Local).AddTicks(3651), 24.730426794137728 },
                    { 274, 3.8962500000000002, 3, 3.0375000000000001, new DateTime(2020, 6, 4, 14, 53, 50, 614, DateTimeKind.Local).AddTicks(3662), 24.717560820140967 },
                    { 275, 3.895, 3, 3.0499999999999998, new DateTime(2020, 6, 4, 15, 13, 50, 614, DateTimeKind.Local).AddTicks(3674), 24.704403844771129 },
                    { 276, 3.8937500000000003, 3, 3.0625, new DateTime(2020, 6, 4, 15, 33, 50, 614, DateTimeKind.Local).AddTicks(3685), 24.69095667961242 },
                    { 290, 3.8762500000000002, 3, 3.2374999999999998, new DateTime(2020, 6, 4, 20, 13, 50, 614, DateTimeKind.Local).AddTicks(3847), 24.472723199190128 },
                    { 277, 3.8925000000000001, 3, 3.0750000000000002, new DateTime(2020, 6, 4, 15, 53, 50, 614, DateTimeKind.Local).AddTicks(3697), 24.677220154149339 },
                    { 279, 3.8900000000000001, 3, 3.1000000000000001, new DateTime(2020, 6, 4, 16, 33, 50, 614, DateTimeKind.Local).AddTicks(3719), 24.648882429441258 },
                    { 280, 3.8887499999999999, 3, 3.1125000000000003, new DateTime(2020, 6, 4, 16, 53, 50, 614, DateTimeKind.Local).AddTicks(3731), 24.634282978200602 },
                    { 281, 3.8875000000000002, 3, 3.125, new DateTime(2020, 6, 4, 17, 13, 50, 614, DateTimeKind.Local).AddTicks(3743), 24.619397662556434 },
                    { 282, 3.8862500000000004, 3, 3.1374999999999997, new DateTime(2020, 6, 4, 17, 33, 50, 614, DateTimeKind.Local).AddTicks(3755), 24.604227400705131 },
                    { 283, 3.8850000000000002, 3, 3.1499999999999999, new DateTime(2020, 6, 4, 17, 53, 50, 614, DateTimeKind.Local).AddTicks(3766), 24.588773128419906 },
                    { 284, 3.88375, 3, 3.1624999999999996, new DateTime(2020, 6, 4, 18, 13, 50, 614, DateTimeKind.Local).AddTicks(3778), 24.573035798993068 },
                    { 285, 3.8825000000000003, 3, 3.1749999999999998, new DateTime(2020, 6, 4, 18, 33, 50, 614, DateTimeKind.Local).AddTicks(3789), 24.557016383177228 },
                    { 286, 3.8812500000000001, 3, 3.1875, new DateTime(2020, 6, 4, 18, 53, 50, 614, DateTimeKind.Local).AddTicks(3801), 24.540715869125407 },
                    { 287, 3.8800000000000003, 3, 3.2000000000000002, new DateTime(2020, 6, 4, 19, 13, 50, 614, DateTimeKind.Local).AddTicks(3812), 24.524135262330098 },
                    { 288, 3.8787500000000001, 3, 3.2124999999999999, new DateTime(2020, 6, 4, 19, 33, 50, 614, DateTimeKind.Local).AddTicks(3824), 24.507275585561231 },
                    { 278, 3.8912500000000003, 3, 3.0875000000000004, new DateTime(2020, 6, 4, 16, 13, 50, 614, DateTimeKind.Local).AddTicks(3708), 24.663195115715471 },
                    { 830, 3.2012499999999999, 3, 9.9875000000000007, new DateTime(2020, 6, 12, 8, 13, 50, 615, DateTimeKind.Local).AddTicks(759), 19.960730495556444 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 65);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 66);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 67);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 68);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 69);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 70);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 71);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 72);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 73);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 74);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 75);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 76);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 77);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 78);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 79);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 80);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 81);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 82);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 83);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 84);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 85);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 86);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 87);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 88);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 89);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 90);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 91);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 92);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 93);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 94);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 95);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 96);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 97);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 98);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 99);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 100);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 101);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 102);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 103);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 104);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 105);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 106);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 107);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 108);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 109);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 110);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 111);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 112);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 113);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 114);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 115);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 116);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 117);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 118);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 119);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 120);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 121);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 122);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 123);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 124);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 125);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 126);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 127);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 128);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 129);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 130);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 131);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 132);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 133);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 134);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 135);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 136);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 137);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 138);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 139);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 140);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 141);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 142);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 143);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 144);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 145);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 146);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 147);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 148);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 149);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 150);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 151);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 152);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 153);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 154);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 155);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 156);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 157);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 158);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 159);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 160);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 161);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 162);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 163);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 164);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 165);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 166);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 167);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 168);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 169);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 170);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 171);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 172);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 173);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 174);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 175);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 176);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 177);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 178);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 179);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 180);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 181);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 182);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 183);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 184);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 185);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 186);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 187);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 188);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 189);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 190);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 191);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 192);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 193);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 194);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 195);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 196);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 197);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 198);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 199);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 200);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 201);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 202);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 203);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 204);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 205);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 206);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 207);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 208);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 209);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 210);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 211);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 212);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 213);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 214);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 215);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 216);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 217);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 218);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 219);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 220);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 221);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 222);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 223);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 224);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 225);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 226);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 227);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 228);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 229);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 230);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 231);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 232);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 233);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 234);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 235);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 236);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 237);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 238);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 239);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 240);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 241);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 242);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 243);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 244);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 245);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 246);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 247);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 248);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 249);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 250);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 251);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 252);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 253);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 254);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 255);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 256);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 257);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 258);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 259);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 260);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 261);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 262);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 263);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 264);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 265);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 266);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 267);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 268);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 269);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 270);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 271);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 272);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 273);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 274);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 275);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 276);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 277);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 278);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 279);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 280);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 281);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 282);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 283);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 284);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 285);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 286);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 287);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 288);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 289);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 290);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 291);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 292);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 293);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 294);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 295);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 296);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 297);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 298);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 299);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 300);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 301);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 302);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 303);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 304);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 305);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 306);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 307);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 308);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 309);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 310);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 311);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 312);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 313);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 314);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 315);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 316);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 317);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 318);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 319);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 320);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 321);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 322);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 323);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 324);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 325);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 326);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 327);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 328);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 329);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 330);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 331);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 332);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 333);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 334);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 335);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 336);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 337);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 338);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 339);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 340);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 341);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 342);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 343);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 344);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 345);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 346);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 347);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 348);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 349);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 350);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 351);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 352);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 353);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 354);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 355);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 356);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 357);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 358);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 359);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 360);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 361);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 362);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 363);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 364);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 365);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 366);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 367);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 368);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 369);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 370);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 371);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 372);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 373);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 374);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 375);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 376);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 377);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 378);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 379);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 380);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 381);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 382);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 383);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 384);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 385);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 386);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 387);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 388);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 389);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 390);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 391);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 392);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 393);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 395);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 396);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 397);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 398);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 399);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 400);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 401);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 402);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 403);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 404);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 405);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 406);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 407);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 408);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 409);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 410);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 411);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 412);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 413);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 414);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 415);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 416);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 417);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 418);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 419);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 420);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 421);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 422);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 423);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 424);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 425);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 426);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 427);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 428);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 429);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 430);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 431);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 432);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 433);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 434);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 435);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 436);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 437);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 438);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 439);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 440);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 441);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 442);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 443);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 444);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 445);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 446);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 447);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 448);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 449);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 450);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 451);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 452);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 453);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 454);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 455);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 456);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 457);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 458);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 459);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 460);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 461);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 462);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 463);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 464);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 465);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 466);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 467);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 468);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 469);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 470);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 471);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 472);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 473);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 474);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 475);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 476);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 477);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 478);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 479);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 480);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 481);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 482);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 483);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 484);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 485);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 486);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 487);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 488);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 489);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 490);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 491);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 492);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 493);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 494);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 495);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 496);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 497);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 498);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 499);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 500);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 501);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 502);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 503);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 504);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 505);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 506);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 507);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 508);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 509);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 510);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 511);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 512);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 513);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 514);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 515);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 516);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 517);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 518);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 519);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 520);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 521);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 522);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 523);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 524);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 525);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 526);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 527);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 528);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 529);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 530);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 531);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 532);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 533);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 534);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 535);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 536);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 537);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 538);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 539);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 540);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 541);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 542);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 543);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 544);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 545);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 546);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 547);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 548);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 549);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 550);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 551);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 552);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 554);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 555);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 556);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 557);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 558);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 559);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 560);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 561);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 562);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 563);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 564);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 565);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 566);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 567);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 568);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 569);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 570);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 571);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 572);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 573);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 574);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 575);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 576);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 577);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 578);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 579);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 580);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 581);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 582);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 583);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 584);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 585);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 586);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 587);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 588);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 589);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 590);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 591);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 592);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 593);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 594);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 595);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 596);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 597);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 598);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 599);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 600);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 601);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 602);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 603);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 604);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 605);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 606);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 607);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 608);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 609);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 610);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 611);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 612);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 613);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 614);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 615);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 616);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 617);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 618);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 619);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 620);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 621);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 622);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 623);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 624);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 625);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 626);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 627);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 628);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 629);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 630);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 631);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 632);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 633);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 634);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 635);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 636);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 637);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 638);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 639);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 640);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 641);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 642);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 643);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 644);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 645);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 646);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 647);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 648);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 649);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 650);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 651);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 652);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 653);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 654);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 655);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 656);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 658);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 659);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 660);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 661);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 662);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 663);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 664);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 665);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 666);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 667);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 668);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 669);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 670);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 671);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 672);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 673);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 674);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 675);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 676);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 677);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 678);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 679);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 680);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 681);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 682);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 683);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 684);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 685);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 686);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 687);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 688);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 689);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 690);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 691);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 692);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 693);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 694);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 695);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 696);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 697);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 698);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 699);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 700);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 701);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 702);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 703);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 704);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 705);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 706);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 707);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 708);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 709);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 710);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 711);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 712);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 713);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 714);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 715);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 716);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 717);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 719);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 720);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 721);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 722);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 723);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 724);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 725);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 726);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 727);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 728);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 729);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 730);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 731);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 732);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 733);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 734);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 736);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 737);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 738);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 739);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 740);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 741);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 742);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 743);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 744);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 745);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 746);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 747);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 748);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 749);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 750);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 751);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 752);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 753);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 754);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 755);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 756);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 757);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 758);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 759);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 760);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 761);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 762);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 763);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 764);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 765);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 766);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 767);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 768);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 769);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 770);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 771);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 772);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 773);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 774);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 776);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 777);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 778);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 779);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 780);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 781);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 782);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 783);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 784);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 785);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 786);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 787);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 788);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 789);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 790);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 791);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 792);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 793);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 794);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 795);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 796);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 797);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 798);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 799);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 800);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 801);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 802);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 803);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 804);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 805);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 806);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 807);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 808);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 809);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 810);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 811);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 812);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 813);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 814);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 815);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 816);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 817);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 818);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 819);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 820);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 821);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 822);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 823);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 824);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 825);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 826);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 827);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 828);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 829);

            migrationBuilder.DeleteData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 830);

            migrationBuilder.DeleteData(
                table: "DataSeries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DataSeries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DataSeries",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataSeriesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataSeriesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataSeriesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataSeriesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataSeriesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataSeriesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataSeriesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataSeriesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataSeriesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataSeriesId",
                value: null);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 1,
                column: "DataSeriesId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 2,
                column: "DataSeriesId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 3,
                column: "DataSeriesId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 4,
                column: "DataSeriesId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 5,
                column: "DataSeriesId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 6,
                column: "DataSeriesId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 7,
                column: "DataSeriesId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 8,
                column: "DataSeriesId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 9,
                column: "DataSeriesId",
                value: -1);

            migrationBuilder.UpdateData(
                table: "DataPoints",
                keyColumn: "Id",
                keyValue: 10,
                column: "DataSeriesId",
                value: -1);
        }
    }
}
