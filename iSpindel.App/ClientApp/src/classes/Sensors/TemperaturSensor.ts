import { SENSOR_TYPE } from './SensorTypes';
import { NumericalSensor } from './NumericalSensor';

export class TemperatureSensor extends NumericalSensor {
    type: SENSOR_TYPE.TEMP;

    constructor(name: string, topic: string, icon: string) {
        super(name, topic);
    }

}