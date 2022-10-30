import { DataRange } from "./DataRange";
import { IDataPoint } from 'src/classes/Data/IDataPoint';

export class ChartData {
    series: DataRange[];

    public static fromDataPoints(datapoints: IDataPoint[], withBattery: boolean = false): DataRange[] {

        const temperatureData = new DataRange("Temperature");
        const gravityData = new DataRange("Gravity");
        const alcoholData = new DataRange("Alcohol"); 
        const chartData = new ChartData();
        chartData.series = [temperatureData, gravityData, alcoholData];

        if ( withBattery == true ){
            const batteryData = new DataRange("Battery");
            chartData.series.push(batteryData);

        }

        let firstGravity = datapoints.indexOf[0].gravity;

        datapoints.map(datapoint => {
            var timestamp = new Date(datapoint.recordTime);

            if (withBattery) {
                chartData.series[2].series.push({ name : timestamp, value : datapoint.battery});
            }
            temperatureData.series.push({ name : timestamp, value : datapoint.temperature });
            gravityData.series.push({ name : timestamp, value : datapoint.gravity });
            alcoholData.series.push({ name: timestamp, value : this.alcoholByVolume(firstGravity, datapoint.gravity)})
        })

        return chartData.series;
    }

    public static alcoholByVolume(firstGravity: number, currentGravity: number) : number {
    /*
    p = gravity anfangswert
    es = scheinbarer vergärungsgrad = aktuelle gravity
    alcoholByVolume = ( p - es ) / 1.86
    */
        return (firstGravity - currentGravity) / 1.86;
    }


}
