import { Injectable, OnDestroy } from '@angular/core';
import { Observable, generate } from 'rxjs';
import { MqttService } from 'ngx-mqtt';
import { TemperatureSensor } from 'src/classes/Sensors/TemperaturSensor';
import { BatterySensor } from 'src/classes/Sensors/BatterySensor';
import { GravitySensor } from 'src/classes/Sensors/GravitySensor';
import { ISensor } from 'src/classes/Sensors/ISensor';
import { map, tap } from 'rxjs/operators';
import { SENSOR_DATA_TYPE } from 'src/classes/Sensors/SensorTypes'
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})


export class MqttSubscriptionService implements OnDestroy {

  private _iSpindelBasePath = 'ispindel/iSpindel0/';
  public temperatureSensor: TemperatureSensor = new TemperatureSensor('Temperatur', this._iSpindelBasePath + 'temperature', 'temperature-celcius');
  public batterySensor: BatterySensor = new BatterySensor('Battery', this._iSpindelBasePath + 'battery', 'battery-charging-high');
  public gravitySensor: GravitySensor = new GravitySensor('Gravity', this._iSpindelBasePath + 'gravity', 'chart-sankey');

  constructor(private _mqttService: MqttService) {
    this._subscribeAllSensors();
  }

  private _subscribeAllSensors() {
    this._subscribeSensor(this.temperatureSensor);
    this._subscribeSensor(this.batterySensor);
    this._subscribeSensor(this.gravitySensor);
  }

  private _unsubscribeAllSensors() {
    this._unsubscribeSensor(this.temperatureSensor);
    this._unsubscribeSensor(this.batterySensor);
    this._unsubscribeSensor(this.gravitySensor);
  }

  private _subscribeSensor(sensor: ISensor) {
    sensor.subscription = this._mqttService
      .observe(sensor.topic)
      .pipe(
        map(msg => msg.payload.toString()),
        tap((msg: string) => {
          switch (sensor.data_type) {
            case SENSOR_DATA_TYPE.NUMBER:
              sensor.value.next(Number(msg))
              break;
            case SENSOR_DATA_TYPE.BOOL:
              if (msg == 'on') {
                sensor.value.next(true)
              } else {
                sensor.value.next(false)
              }
              break;
            case SENSOR_DATA_TYPE.STRING:
            default:
              sensor.value.next(msg);
              break;
          }
        })
      ).subscribe();
  }

  private _unsubscribeSensor(sensor: ISensor) {
    sensor.subscription.unsubscribe();
  }

  public getTemperature(): Observable<number> {
    if (!environment.production)
      return generate(0, x => x < 30, x => x = this._randomInt(0, 30));
    return this.temperatureSensor.value.asObservable();
  }

  private _randomInt(min: number, max: number): number {
    return Math.floor(Math.random() * (max - min + 1)) + min;
  }

  public getBattery(): Observable<number> {
    if (!environment.production)
      return generate(0, x => x < 100, x => x = this._randomInt(0, 100));
    return this.batterySensor.value.asObservable();
  }

  public getGravity(): Observable<number> {
    if (!environment.production)
      return generate(0, x => x < 20, x => x = this._randomInt(0, 20));
    return this.gravitySensor.value.asObservable();
  }

  public ngOnDestroy() {
    this._unsubscribeAllSensors();
  }
}
