import { Component, OnInit } from '@angular/core';
import { MqttSubscriptionService } from 'src/services/mqtt.service';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-live-data',
  templateUrl: './live-data.component.html',
  styleUrls: ['./live-data.component.css']
})
export class LiveDataComponent implements OnInit {

  public currentTemperature$: Observable<number>;
  public currentBattery$: Observable<number>;
  public currentGravity$: Observable<number>;

  constructor(private _mqttService: MqttSubscriptionService) { }

  ngOnInit() {
    this.currentTemperature$ = this._mqttService.getTemperature();
    this.currentBattery$ = this._mqttService.getBattery();
    this.currentGravity$ = this._mqttService.getGravity();
  }

}
