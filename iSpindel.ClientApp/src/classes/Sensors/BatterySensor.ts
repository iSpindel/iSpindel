import { NumericalSensor } from './NumericalSensor';
import { SENSOR_TYPE } from './SensorTypes';

export class BatterySensor extends NumericalSensor {
    type: SENSOR_TYPE.BATT;

    constructor(name: string, topic: string, _icon: string) {
      super(name, topic);
    }

}