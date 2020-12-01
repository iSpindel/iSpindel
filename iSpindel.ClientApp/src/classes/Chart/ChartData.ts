import { DataRange } from "./DataRange";
import { IDataPoint } from 'src/classes/Data/IDataPoint';

export class ChartData {
    series: DataRange[];
    dates: Date[];

    public static fromDataPoints(datapoints: IDataPoint[]): ChartData {

        const batteryData = new DataRange("Battery");
        const temperatureData = new DataRange("Temperature");
        const gravityData = new DataRange("Gravity");
        const chartData = new ChartData();
        chartData.series = [batteryData, temperatureData, gravityData];

        datapoints.map(datapoint => {
            chartData.dates.push(new Date(datapoint.recordTime));

            batteryData.values.push(datapoint.battery);
            temperatureData.values.push(datapoint.temperature);
            gravityData.values.push(datapoint.gravity);
        })

        return chartData;


    }
}