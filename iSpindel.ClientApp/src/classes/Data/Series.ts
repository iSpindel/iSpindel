import { ISeries } from "./ISeries";

export class Series implements ISeries {
    name: string|number;
    value: number;

    constructor(name: string|number, value: number){
        this.name = name;
        this.value = value;
    }
}