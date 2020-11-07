import { BehaviorSubject, Subscription } from 'rxjs';
import { SENSOR_TYPE, SENSOR_DATA_TYPE } from './SensorTypes';

export interface ISensor {
    name: string;
    icon: string;
    topic: string;
    type: SENSOR_TYPE;
    data_type: SENSOR_DATA_TYPE;
    value: BehaviorSubject<any>;
    subscription: Subscription;
}