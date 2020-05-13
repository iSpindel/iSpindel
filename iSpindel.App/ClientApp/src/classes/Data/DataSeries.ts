import { IDataSeries } from './IDataSeries';
import { IDataPoint } from './IDataPoint';

export abstract class DataSeries implements IDataSeries {
    type: string;    
    name?: string;
    color?: string;
    axisYIndex?: number;
    axisYType?: string;
    showInLegend?: boolean;
    dataPoints: IDataPoint[]

    constructor (color: string, index: number) {
        this.type = "line";
        this.showInLegend = true;
        this.color = color;
        this.axisYIndex = index;
    }


};