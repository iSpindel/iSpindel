import { IAxisYDefinition } from './IAxisYDefinition';

export abstract class Definition implements IAxisYDefinition {
    title: string;
    lineColor: string;
    tickColor: string;
    labelFontColor: string;
    titleFontColor: string;
    suffix?: string;
    prefix?: string;

    constructor(title: string, color: string) {
        this.title = title;
        this.lineColor = color;
        this.tickColor = color;
        this.labelFontColor = color;
        this.titleFontColor = color;
    }

}