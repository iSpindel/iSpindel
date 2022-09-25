import { DataRange } from "./DataRange";
import { IDataPoint } from 'src/classes/Data/IDataPoint';

export class ChartData {
    series: DataRange[];

    public static fromDataPoints(datapoints: IDataPoint[], withBattery: boolean = false): DataRange[] {

        const temperatureData = new DataRange("Temperature");
        const gravityData = new DataRange("Gravity");
        const chartData = new ChartData();
        chartData.series = [temperatureData, gravityData];

        if ( withBattery == true ){
            const batteryData = new DataRange("Battery");
            chartData.series.push(batteryData);

        }

        datapoints.map(datapoint => {
            var timestamp = new Date(datapoint.recordTime);

            if (withBattery) {
                chartData.series[2].series.push({ name : timestamp, value : datapoint.battery});
            }
            temperatureData.series.push({ name : timestamp, value : datapoint.temperature });
            gravityData.series.push({ name : timestamp, value : datapoint.gravity });
        })

        return chartData.series;
    }
}