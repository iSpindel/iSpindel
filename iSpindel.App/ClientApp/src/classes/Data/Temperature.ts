import { DataSeries } from "./DataSeries";

export class Temperature extends DataSeries {

    constructor(color: string, index: number){
        super(color, index);
        this.name = "Temperature";
    }

}