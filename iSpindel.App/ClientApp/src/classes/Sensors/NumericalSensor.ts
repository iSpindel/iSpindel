import { ISensor } from "./ISensor";
import { BehaviorSubject, Subscription } from 'rxjs';
import { SENSOR_TYPE, SENSOR_DATA_TYPE } from './SensorTypes';

export abstract class NumericalSensor implements ISensor {
    icon: string;
    data_type: SENSOR_DATA_TYPE.NUMBER;
    subscription: Subscription;
    type: SENSOR_TYPE;
    name: string;
    topic: string;
    value: BehaviorSubject<number>;

    constructor(name: string, topic: string) {
        this.name = name;
        this.topic = topic;
        this.value = new BehaviorSubject<number>(0);
    }

}