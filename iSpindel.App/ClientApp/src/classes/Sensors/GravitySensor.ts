import { SENSOR_TYPE } from './SensorTypes';
import { NumericalSensor } from './NumericalSensor';

export class GravitySensor extends NumericalSensor {
    type: SENSOR_TYPE.GRAV;

    constructor(name: string, topic: string, icon: string) {
        super(name, topic);
    }

}