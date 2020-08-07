import { IDataPoint } from './IDataPoint'

export interface IDataSeries {
    id: number;
    name: string;
    description: string;
    dataPoints: Array<IDataPoint>;
    //TODO replace with real dates
    start: string;
    end: string;
}