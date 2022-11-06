import { Injectable } from '@angular/core';
import { Observable, Subject, from, merge } from 'rxjs';
import { map, scan, tap, mergeMap, filter } from 'rxjs/operators';

import { HttpClient } from '@angular/common/http';
import { IDataSeries } from 'src/classes/Data/IDataSeries';
import { IDataPoint } from 'src/classes/Data/IDataPoint';

@Injectable({
  providedIn: 'root'
})
export class GraphService {
  protected _seriesId: Subject<number> = new Subject<number>();
  public readonly SeriesId$: Observable<number> = this._seriesId.asObservable();
  public readonly CurrentSeries$: Observable<IDataSeries>;

  protected _signalrPoints$: Subject<IDataPoint> = new Subject<IDataPoint>();
  protected _resetChannel$: Subject<IDataPoint> = new Subject<IDataPoint>();
  public readonly DataStream$: Observable<IDataPoint>;
  public readonly CurrentData$: Observable<IDataPoint[]>;

  public readonly BatteryStream$: Observable<number>;
  public readonly TemperatureStream$: Observable<number>;
  public readonly GravityStream$: Observable<number>;

  constructor(protected httpClient: HttpClient) {
    this.CurrentSeries$ = this._seriesId.pipe(
      mergeMap(x =>
        this.httpClient.get(`/api/DataSeries/${x}`) as Observable<IDataSeries>),
      tap(_ => {
        //reset current accumulator
        this._resetChannel$.next(null);
      }
      ));

    const nullFilter = filter<IDataPoint>(f => f != null);
    const initialPoints = this.CurrentSeries$.pipe(mergeMap(x => from(x.datapoints)), nullFilter);

    this.DataStream$ = merge(
      this._resetChannel$,
      this._signalrPoints$.pipe(nullFilter),
      initialPoints);

    this.BatteryStream$ = this.DataStream$.pipe(nullFilter, map(x => x.battery));
    this.TemperatureStream$ = this.DataStream$.pipe(nullFilter, map(x => x.temperature));
    this.GravityStream$ = this.DataStream$.pipe(nullFilter, map(x => x.gravity));

    this.CurrentData$ = this.DataStream$.pipe(
      scan((acc, val, _) => {
        if (val == null) //reset signal
        {
          acc = new Array<IDataPoint>();
        } else {
          acc.push(val);
        }
        return acc;
      }, new Array<IDataPoint>()));
  }

  public loadData(seriesId: number): void {
    this._seriesId.next(seriesId);
    //this.httpClient.get('/api/DataSeries/' + seriesId).pipe();
  }
}
