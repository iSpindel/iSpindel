import { Definition } from './Definition';

export class TemperatureDefinition extends Definition {

    constructor(title: string, color: string){
        super(title,color);
        this.suffix = "C";
    }

}