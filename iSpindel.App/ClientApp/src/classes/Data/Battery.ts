import { DataSeries } from "./DataSeries";

export class Battery extends DataSeries {

    constructor(color: string, index: number){
        super(color, index);
        this.name = "Battery";
    }

}