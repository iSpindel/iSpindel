import { IDataEntry } from "./DataEntry";

export class DataRange {
    name: string;
    series: IDataEntry[];

    constructor(name: string){
        this.name = name;
        this.series = new Array();
    }
}