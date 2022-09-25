import { Component, OnInit } from '@angular/core';
import { GraphService } from 'src/services/graph.service';
import { Subject, Observable, Subscription } from 'rxjs';
import { IDataPoint } from 'src/classes/Data/IDataPoint';
import { RecordingService } from 'src/services/recording.service';
import { RecordingStatus } from 'src/services/notify.service';
//import { MultilineChart } from 'src/classes/Chart/Chart';
import * as d3 from 'd3';
import { DataRange } from 'src/classes/Chart/DataRange';
import { DataSeries } from 'src/classes/Data/DataSeries';
import { switchMap } from 'rxjs/operators';
import { DataseriesService } from 'src/services/dataseries.service';
import { ChartData } from 'src/classes/Chart/ChartData';

export class Range {
  public Name: string;
  public Class: string;
  public Min: number;
  public Max: number;

  public Scale(value: number): number
  public Scale(value: IDataPoint): number
  public Scale(value: number | IDataPoint): number {
    if (typeof (value) == 'number')
      return (value - this.Min) / (this.Max - this.Min);
    return this.Scale(this.Accessor(value));
  }
  public Accessor: (point: IDataPoint) => number;
}

@Component({
  selector: 'app-current-measure',
  templateUrl: './current-measure.component.html',
  styleUrls: ['./current-measure.component.css']
})
export class CurrentMeasureComponent implements OnInit {

  public recordingId: number;
  public recordingId$: Observable<number>;
  protected dataGenerator: Subject<IDataPoint> = new Subject<IDataPoint>();

  public BatteryStream: Observable<number> = this._graphService.BatteryStream$;
  public TemperatureStream: Observable<number> = this._graphService.TemperatureStream$;
  public GravityStream: Observable<number> = this._graphService.GravityStream$;

  public CurrentData$: Observable<IDataPoint[]> = this._graphService.CurrentData$;
  public CurrentData: IDataPoint[];

  public dataSeries$: Observable<DataSeries>;
  public dataSeries: DataSeries;
  public dataSeriesSubscription: Subscription;

  public currentRecordingStatus: RecordingStatus;
  public currentRecordingStatus$: Observable<RecordingStatus>;

  public SvgWidth: number = 600;
  public SvgHeight: number = 300;
  public Ranges: Array<Range> = new Array<Range>();

  public selectedDataSeriesId: number;
  // Chart options
  legend: boolean = true;
  showLabels: boolean = true;
  animations: boolean = true;
  xAxis: boolean = true;
  yAxis: boolean = true;
  showYAxisLabel: boolean = true;
  showXAxisLabel: boolean = true;
  //xAxisLabel: string = 'Time';
  //yAxisLabel: string = 'Value';
  timeline: boolean = false;
  autoscale: boolean = true;
  //view: any = [700, 700];

  chartData: DataRange[];
  colorScheme = {
    domain: ['#121CD1', '#D1121C', '#CFC0BB', '#7aa3e5', '#a8385d', '#aae3f5']
  };


  // eslint-disable-next-line no-unused-vars
  constructor(private _graphService: GraphService, private _dataseriesService: DataseriesService, public _recordingService: RecordingService) {
  }

  private createScale(name: string, classes: string, min: number, max: number, acc: (x: IDataPoint) => number): Range {
    const range = new Range();
    range.Name = name;
    range.Min = min;
    range.Max = max;
    range.Class = classes;
    range.Accessor = acc;

    return range;
  }

  ngOnInit() {
    this.CurrentData$.subscribe(x => {
      this.CurrentData = x;
    });

    this._recordingService.GetRecordingId().subscribe(id => {

      console.log("Current Dataseries Id: " + id);
      if (id == null || this.selectedDataSeriesId != null) {
        return;
      }

      this.selectedDataSeriesId = id;
      this.dataSeries$ = this._dataseriesService.loadFullDataSeries(this.selectedDataSeriesId);
      this.dataSeriesSubscription = this.dataSeries$.subscribe(x => {
        this.dataSeries = x;
        console.log("Generating Chart datapoints from DB");
        this.chartData = ChartData.fromDataPoints(this.dataSeries.datapoints, true);
        console.log("Chart data ", this.chartData);
      });
    });

    this.currentRecordingStatus$ = this._recordingService.GetRecordingStatus();
    this.currentRecordingStatus$.subscribe(x => this.currentRecordingStatus = x);

    this.recordingId$ = this._recordingService.GetRecordingId();
    this.recordingId$.subscribe(
      dataseriesId => {
        if (dataseriesId != null && dataseriesId != undefined) {
          this.recordingId = dataseriesId;
          this._graphService.loadData(dataseriesId);
        }
      }
    );

    const width = window.innerWidth - 25;
    const height = window.innerHeight - 25;

  }
  ngAfterViewInit() {
 
  }
  getDate(date: Date) {
    return date.getHours().toString().padStart(2, "0") + ":"
      + date.getMinutes().toString().padStart(2, "0") + " "
      + date.getDay().toString().padStart(2, "0") + "."
      + date.getMonth().toString().padStart(2, "0") + "."
      + date.getFullYear();
  }

  onSelect(data): void {
    //console.log('Item clicked', JSON.parse(JSON.stringify(data)));
  }

  onActivate(data): void {
   // console.log('Activate', JSON.parse(JSON.stringify(data)));
  }

  onDeactivate(data): void {
    //console.log('Deactivate', JSON.parse(JSON.stringify(data)));
  }

  public calculateX(index: number): number {
    if (index == 0) return 0;
    const scaleRatio = index / (this.CurrentData.length - 1);
    return this.SvgWidth * scaleRatio;
  }
  public calculateY(range: Range, point: IDataPoint): number {
    const value = range.Accessor(point);
    const relativePos = range.Scale(value);
    return this.SvgHeight * relativePos;
  }

  public isRecordingStopPossible(): boolean {
    if (this.recordingId == null || this.recordingId == undefined) {
      return false;
    }
    return true;
  }

  public StopRecording(): void {
    this._recordingService.StopRecording().subscribe(result => {
    });
  }

  public isRecordingActive(): boolean {
    if (this.currentRecordingStatus == RecordingStatus.RECORDING)
      return true;

    return false;
  }

}