import { IDataPoint } from './IDataPoint'

export interface IDataSeries {
    type : string,
    name? : string,
    color?: string,
    axisYIndex?: number,
    axisYType?: string,
    showInLegend?: boolean,
    dataPoints: IDataPoint[]
}