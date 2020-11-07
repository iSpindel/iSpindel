import { Definition } from './Definition';

export class BatteryDefinition extends Definition {

    constructor(title: string, color: string){
        super(title,color);
        this.suffix = "%";
    }

}