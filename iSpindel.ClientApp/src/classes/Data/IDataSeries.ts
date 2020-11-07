import { IBeerCharacteristics } from './IBeerCharacteristics';
import { IDataPoint } from './IDataPoint'

export interface IDataSeries {
    id: number;
    name: string;
    description: string;
    datapoints: Array<IDataPoint>;
    beerCharacteristics: IBeerCharacteristics;
    start: string;
    end: string;
}