import { Component, OnInit } from '@angular/core';
import { GraphService } from 'src/services/graph.service';
import { Subject, Observable } from 'rxjs';
import { IDataPoint } from 'src/classes/Data/IDataPoint';
import { RecordingService } from 'src/services/recording.service';
import { RecordingStatus } from 'src/services/notify.service';
//import { MultilineChart } from 'src/classes/Chart/Chart';
import * as d3 from 'd3';

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

  public currentRecordingStatus: RecordingStatus;
  public currentRecordingStatus$: Observable<RecordingStatus>;

  public SvgWidth: number = 600;
  public SvgHeight: number = 300;
  public Ranges: Array<Range> = new Array<Range>();

  // eslint-disable-next-line no-unused-vars
  constructor(private _graphService: GraphService, public _recordingService: RecordingService) {
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
      console.log(this.CurrentData);
    });

    this.Ranges.push(this.createScale('Battery', 'battery', 3.2, 4.4, x => x.battery));
    this.Ranges.push(this.createScale('Temperature', 'temperature', 0, 45, x => x.temperature));
    this.Ranges.push(this.createScale('Gravity', 'gravity', 0, 10, x => x.gravity));
    this.currentRecordingStatus$ = this._recordingService.GetRecordingStatus();
    this.currentRecordingStatus$.subscribe(x => this.currentRecordingStatus = x);

    this.recordingId$ = this._recordingService.GetRecordingId();
    this.recordingId$.subscribe(
      dataseriesId => {
        if (dataseriesId != null && dataseriesId != undefined) {
          this.recordingId = dataseriesId;
          console.log('loading graph data');
          this._graphService.loadData(dataseriesId);
        }
      }
    );

    const width = window.innerWidth - 25;
    const height = window.innerHeight - 25;

    //const graph = new MultilineChart(this.CurrentData,'#valueGraph', height, width);
    //graph.initialize();
  }
  ngAfterViewInit() {
    //TODO replace with angular way
    //const chartArea = document.getElementById('chartArea');
    //console.log(chartArea);
    //fromEvent(chartArea, 'mouseover').pipe(debounce(() => interval(100))).subscribe(x => {
    //  console.log(x);
    //});
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
    console.log('check if recording Id ' + this.recordingId + ' can be stopped');
    if (this.recordingId == null || this.recordingId == undefined) {
      return false;
    }

    console.log('it can be stopped');
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