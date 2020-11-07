import { IBeerCharacteristics } from "./IBeerCharacteristics";
import { IDataPoint } from "./IDataPoint";
import { IDataSeries } from "./IDataSeries";

export class DataSeries {
    id: number;
    name: string;
    description: string;
    datapoints: IDataPoint[];
    beerCharacteristics: IBeerCharacteristics;
    start: Date;
    end: Date;

    public getStart() : string {
        if (this.start === null) {
            return "";
        }
        return this.start.getDate().toString().padStart(2) + "." + this.start.getMonth().toString().padStart(2) + "." + this.start.getFullYear();
    }

    public getEnd() : string {
        if ( this.end === null) {
            return "";
        }
        return this.end.getDate().toString().padStart(2) + "." + this.end.getMonth().toString().padStart(2) + "." + this.end.getFullYear();
    }



}