import { Component, OnInit } from '@angular/core';
import * as CanvasJS from '../../assets/canvasjs/canvasjs.min';
import { TiltDefinition, RssiDefinition } from 'src/mock/MockAxisYDefinitions';
import { Observable, zip } from 'rxjs';
import { GraphService } from 'src/services/graph.service';
import { IDataPoint } from 'src/classes/Data/IDataPoint';
import { Temperature } from 'src/classes/Data/Temperature';
import { TemperatureDefinition } from 'src/classes/AxisDefinitions/TemperatureDefinition';
import { BatteryDefinition } from 'src/classes/AxisDefinitions/BatteryDefinition';
import { GravityDefinition } from 'src/classes/AxisDefinitions/GravityDefinition';
import { Gravity } from 'src/classes/Data/Gravity';
import { Battery } from 'src/classes/Data/Battery';
import { GraphConfig } from 'src/classes/GraphConfig';
import { map } from 'rxjs/operators';
import { MqttSubscriptionService } from 'src/services/mqtt.service';

@Component({
  selector: 'app-graph',
  templateUrl: './graph.component.html',
  styleUrls: ['./graph.component.scss']
})
export class GraphComponent implements OnInit {

  public chart: CanvasJS.Chart;
  public graphConfig: GraphConfig;
  private _temperatureDataList$: Observable<IDataPoint[]>;
  public temperature: Temperature = new Temperature('red', 0);
  public temperatureDef: TemperatureDefinition = new TemperatureDefinition(this.temperature.name, this.temperature.color);

  private _batteryDataList$: Observable<IDataPoint[]>;
  public battery: Battery = new Battery('#7F6089', 1)
  public batteryDef: BatteryDefinition = new BatteryDefinition(this.battery.name, this.battery.color);

  private _gravityDataList$: Observable<IDataPoint[]>;
  public gravity: Gravity = new Gravity('green', 2)
  public gravityDef: GravityDefinition = new GravityDefinition(this.gravity.name, this.gravity.color);

  multi: any[];
  view: any[] = [700, 300];

  // options
  legend: boolean = true;
  showLabels: boolean = true;
  animations: boolean = true;
  xAxis: boolean = true;
  yAxis: boolean = true;
  showYAxisLabel: boolean = true;
  showXAxisLabel: boolean = true;
  xAxisLabel: string = 'Date';
  yAxisLabel: string = 'Measurement';
  timeline: boolean = true;

  colorScheme = {
    domain: ['#5AA454', '#E44D25', '#CFC0BB', '#7aa3e5', '#a8385d', '#aae3f5']
  };

  constructor(private _graphService: GraphService, private _mqttService: MqttSubscriptionService) {
  }

  ngOnInit() {

    this._temperatureDataList$ = this._graphService.getTemperatureList(1, 2);
    this._batteryDataList$ = this._graphService.getBatteryList(1, 2);
    this._gravityDataList$ = this._graphService.getGravityList(1, 2);

    zip(this._temperatureDataList$, this._batteryDataList$, this._gravityDataList$).pipe(
      map(([tempData, batteryData, gravityData]) => {
        this.temperature.dataPoints = tempData;
        this.gravity.dataPoints = gravityData;
        this.battery.dataPoints = batteryData;
      })
    ).subscribe(() => this.initChart());
  }


  onSelect(data): void {
    console.log('Item clicked', JSON.parse(JSON.stringify(data)));
  }

  onActivate(data): void {
    console.log('Activate', JSON.parse(JSON.stringify(data)));
  }

  onDeactivate(data): void {
    console.log('Deactivate', JSON.parse(JSON.stringify(data)));
  }

  private initChart(): void {
    console.log(this.temperature);
    this.graphConfig = new GraphConfig([this.temperatureDef, this.batteryDef, this.gravityDef], [this.temperature, this.battery, this.gravity]);
    this.chart = new CanvasJS.Chart("chartContainer", this.graphConfig);

    this.chart.render();
  }


}
