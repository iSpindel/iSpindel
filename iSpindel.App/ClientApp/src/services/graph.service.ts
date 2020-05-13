import { Injectable } from '@angular/core';
import { Observable, of } from 'rxjs';
import { ajax, AjaxResponse } from 'rxjs/ajax';
import { map } from 'rxjs/operators';

import { IDataPoint } from 'src/classes/Data/IDataPoint';
import { NumericalData } from 'src/classes/Data/NumericalData';
import { IRawData } from 'src/classes/Data/IRawData';

import { environment } from 'src/environments/environment';

import { tempSeries, tiltSeries, batterySeries, gravitySeries, rssiSeries, tempPoints, batteryPoints, gravityPoints } from 'src/mock/MockDataSeries';

@Injectable({
  providedIn: 'root'
})
export class GraphService {

  constructor() { }

  private _getAjaxRequest(urlPart: string): any {
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
  }
}
