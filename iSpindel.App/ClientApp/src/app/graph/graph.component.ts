import { Component, OnInit } from '@angular/core';
import { GraphService } from 'src/services/graph.service';
import { Observable, zip, of, Subject } from 'rxjs';
import { map, reduce, scan, delay, concatMap, share, shareReplay } from 'rxjs/operators';

export interface IDataPoint {
  Index?: number;
  Battery: number;
  Temperature: number;
  Gravity: number;
  RecordTime: number;
}

export interface Range {
  Name: string;
  Class: string;
  Min: number;
  Max: number;
  Scale(value: number): number;
  Accessor(point: IDataPoint): number;
}

@Component({
  selector: 'app-graph',
  templateUrl: './graph.component.html',
  styleUrls: ['./graph.component.scss']
})
export class GraphComponent implements OnInit {
  protected dataGenerator: Subject<IDataPoint> = new Subject<IDataPoint>();
  public DataStream: Observable<IDataPoint> = this.dataGenerator.pipe(share());

  public BatteryStream: Observable<number> = this.DataStream.pipe(map(x => x.Battery));
  public TemperatureStream: Observable<number> = this.DataStream.pipe(map(x => x.Temperature));
  public GravityStream: Observable<number> = this.DataStream.pipe(map(x => x.Gravity));

  public CurrentData$: Observable<IDataPoint[]>;
  public CurrentData: IDataPoint[];
  //public CurrentDataAmount: Observable<number>;

  public SvgWidth: number = 600;
  public SvgHeight: number = 300;
  public Ranges: Array<Range> = new Array<Range>();

  constructor(private _graphService: GraphService) {
    this.Ranges.push(this.createScale('Battery', 'battery', 3.2, 4.4, x => x.Battery));
    this.Ranges.push(this.createScale('Temperature', 'temperature', 0, 45, x => x.Temperature));
    this.Ranges.push(this.createScale('Gravity', 'gravity', 0, 10, x => x.Gravity));
  }

  private createScale(name: string, classes: string, min: number, max: number, acc: (x: IDataPoint) => number): Range {
    return {
      Name: name,
      Min: min,
      Max: max,
      Class: classes,
      Accessor: acc,
      Scale: (x) => (x - min) / (max - min)
    };
  }

  public indexFn(point: IDataPoint): number {
    return point.Index;
  }

  private getPoint(t: number, tMax: number): IDataPoint {
    const tRatio = t / tMax;
    return {
      Battery: Math.round((4.2 - 1 * tRatio) * 100) / 100,
      Gravity: Math.round((10 * tRatio) * 100) / 100,
      Temperature: Math.round((20 + Math.sin(Math.PI * 2 * tRatio) * 5) * 100) / 100,
      RecordTime: Date.now()
    };
  }

  ngOnInit() {

    this.CurrentData$ = this.DataStream.pipe(
      scan((acc, val, idx) => {
        val.Index = idx;
        acc.push(val);
        return acc;
      }, new Array<IDataPoint>()),
    );

    this.CurrentData$.subscribe(x => this.CurrentData = x);
    //this.CurrentDataAmount = this.CurrentData.pipe(map(x => x.length));

    const iMax = 100;
    const gen = (i: number = 0) => setTimeout(() => {
      this.dataGenerator.next(this.getPoint(i, iMax));
      if (i < iMax)
        gen(i + 1);
    }, 300);
    gen();
  }

  public calculateX(point: IDataPoint, index: number, arrLength: number): number {
    if (index == 0) return 0;
    const scaleRatio = index / (arrLength - 1);
    return this.SvgWidth * scaleRatio;
  }
  public calculateY(relativePos: number): number {
    return this.SvgHeight * relativePos;
  }

}
