import { IDataPoint } from './IDataPoint'

export interface IDataSeries {
    id: number;
    name: string;
    description: string;
    datapoints: Array<IDataPoint>;
    //TODO replace with real dates
    start: string;
    end: string;
}