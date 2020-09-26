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
      tap(_ =>
        //reset current accumulator
        this._resetChannel$.next(null)
      ));

    const nullFilter = filter<IDataPoint>(f => f != null);
    const initialPoints = this.CurrentSeries$.pipe(mergeMap(x => from(x.dataPoints)), nullFilter);

    this.DataStream$ = merge(
      this._resetChannel$,
      this._signalrPoints$.pipe(nullFilter),
      initialPoints);

    this.BatteryStream$ = this.DataStream$.pipe(map(x => x.battery));
    this.TemperatureStream$ = this.DataStream$.pipe(map(x => x.temperature));
    this.GravityStream$ = this.DataStream$.pipe(map(x => x.gravity));

    this.CurrentData$ = this.DataStream$.pipe(
      scan((acc, val, _) => {
        if (val == null) //reset signal
          acc = new Array<IDataPoint>();
        acc.push(val);
        return acc;
      }, new Array<IDataPoint>()),
    );
  }

  public loadData(seriesId: number): void {
    this._seriesId.next(seriesId);
    //this.httpClient.get('/api/DataSeries/' + seriesId).pipe();
  }

  /*private _getAjaxRequest(urlPart: string): any {
    return {
      url: '/v1/'+urlPart,
      method: 'GET',
    };
  }

  private _responseValidator(response: AjaxResponse): AjaxResponse {
    if (!response.response) {
      throw new Error('request not successful');
    }
    if (response.responseType !== 'json') {
      throw new Error('wrong request type');
    }
    return response;
  }

  private _createDataPoints(response: AjaxResponse): Array<IDataPoint> {
    return response.response
      .map((rawData: IRawData) => {
        const dataPoint = new NumericalData();
        dataPoint.x = new Date(rawData.timestamp);
        dataPoint.y = parseFloat(rawData.value);
        return dataPoint;
      });
  }


  private _getValueList(start: number, end: number, type: string): Observable<IDataPoint[]> {
    const validateResponse = (response: AjaxResponse) => this._responseValidator(response);
    const dataResponse = ajax(this._getAjaxRequest(type));

    const rawData$ = dataResponse.pipe(
      map(validateResponse),
      map(this._createDataPoints)
    );

    return rawData$;

  }

  private _fakeTemperatureData(): Observable<IDataPoint[]> {
    return of(tempPoints);
  }

  private _fakeBatteryData(): Observable<IDataPoint[]> {
    return of(batteryPoints);
  }

  private _fakeGravityData(): Observable<IDataPoint[]> {
    return of(gravityPoints);
  }

  public getTemperatureList(start: number, end: number): Observable<IDataPoint[]> {
    if(!environment.production)
      return this._fakeTemperatureData();
    return this._getValueList(start, end, 'temperature');
  }

  public getBatteryList(start: number, end: number): Observable<IDataPoint[]> {
    if(!environment.production)
      return this._fakeBatteryData();
    return this._getValueList(start, end, 'battery');
  }

  public getGravityList(start: number, end: number): Observable<IDataPoint[]> {
    if(!environment.production)
      return this._fakeGravityData();
    return this._getValueList(start, end, 'gravity');
  }*/
}
