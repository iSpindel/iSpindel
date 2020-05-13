import { NumericalSensor } from "./NumericalSensor";
import { BehaviorSubject, Subscription } from 'rxjs';
import { SENSOR_TYPE } from './SensorTypes';

export class BatterySensor extends NumericalSensor {
    type: SENSOR_TYPE.BATT;

    constructor(name: string, topic: string, icon: string) {
        super(name, topic);
    }

}