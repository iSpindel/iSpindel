import { IChartSeries } from "./IChartSeries";
import { ISeries } from "./ISeries";
import { Series } from "./Series";

export class ChartSeries implements IChartSeries {
    name: string;
    series: Array<ISeries>;

    constructor(name: string) {
        this.name = name;
        this.series = new Array<ISeries>();
    }

    public addDatapoint( name: string|number, value: number){
        this.series.push(new Series(name, value));
    }

}