import { Component, OnInit } from '@angular/core';
import { GraphService } from 'src/services/graph.service';
import { Subject, Observable } from 'rxjs';
import { IDataPoint } from 'src/classes/Data/IDataPoint';

export class Range {
  public Name: string;
  public Class: string;
  public Min: number;
  public Max: number;

  public Scale(value: number): number
  public Scale(value: IDataPoint): number
  public Scale(value: number|IDataPoint): number {
    if(typeof(value) == 'number') 
      return (value - this.Min) / (this.Max - this.Min);
    return this.Scale(this.Accessor(value));
  }
  public Accessor: (point: IDataPoint) => number;
}

@Component({
  selector: 'app-graph',
  templateUrl: './graph.component.html',
  styleUrls: ['./graph.component.scss']
})
export class GraphComponent implements OnInit {
  protected dataGenerator: Subject<IDataPoint> = new Subject<IDataPoint>();

  public BatteryStream: Observable<number> = this._graphService.BatteryStream$;
  public TemperatureStream: Observable<number> = this._graphService.TemperatureStream$;
  public GravityStream: Observable<number> = this._graphService.GravityStream$;

  public CurrentData$: Observable<IDataPoint[]> = this._graphService.CurrentData$;
  public CurrentData: IDataPoint[];

  public SvgWidth: number = 600;
  public SvgHeight: number = 300;
  public Ranges: Array<Range> = new Array<Range>();

  // eslint-disable-next-line no-unused-vars
  constructor(private _graphService: GraphService) {
    this.Ranges.push(this.createScale('Battery', 'battery', 3.2, 4.4, x => x.battery));
    this.Ranges.push(this.createScale('Temperature', 'temperature', 0, 45, x => x.temperature));
    this.Ranges.push(this.createScale('Gravity', 'gravity', 0, 10, x => x.gravity));
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
    this.CurrentData$.subscribe(x => this.CurrentData = x);

    this._graphService.loadData(2);
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

}
