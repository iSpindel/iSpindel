import { BeerCharacteristics } from "./BeerCharacteristics";
import { IDataPoint } from "./IDataPoint";
import { IDataSeries } from "./IDataSeries";

export class DataSeries {
    id: number;
    name: string;
    description: string;
    datapoints: IDataPoint[];
    beerCharacteristics: BeerCharacteristics;
    start: Date;
    end: Date;

    public getFirstGravity() : number {
        if (this.datapoints === null || this.datapoints === undefined){
            return null;
        }
        return this.datapoints[0].gravity;
    }

    public getMeanTemperature() : number {
        if (this.datapoints === null || this.datapoints === undefined){
            return null;
        }

        let sumTemp : number = 0;

        this.datapoints.forEach(dp => sumTemp += dp.temperature);

        return sumTemp/this.datapoints.length;
    }

    public getStart() : string {
        if (this.start === null) {
            return "tbd";
        }
        return this.start.getDate().toString().padStart(2,"0") + "." + this.start.getMonth().toString().padStart(2,"0") + "." + this.start.getFullYear();
    }

    public getEnd() : string {
        if ( this.end === null) {
            return "tbd";
        }
        return this.end.getDate().toString().padStart(2,"0") + "." + this.end.getMonth().toString().padStart(2,"0") + "." + this.end.getFullYear();
    }



}