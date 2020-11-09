import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IDataSeries } from 'src/classes/Data/IDataSeries';
import { asyncScheduler, merge, Observable, scheduled } from 'rxjs';
import { NotifyService, RecordingStatus } from './notify.service';
import { map, mergeAll } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class RecordingService {

  public _baseUrl: string;

  constructor(private _http: HttpClient, private _notifyService: NotifyService) {
    this._baseUrl = 'api/Recording/';
  }

  public GetRecordingStatus(): Observable<RecordingStatus> {
    const httpGet = this._http.get(this._baseUrl + 'RecordingStatus', { responseType: 'text' }).pipe(map<unknown, RecordingStatus>(x => {
      if (x === 'RECORDING')
        return RecordingStatus.RECORDING;
      if (x === 'IDLE')
        return RecordingStatus.IDLE;
      return RecordingStatus.UNKNOWN;
    }));

    return scheduled([
      httpGet,
      this._notifyService.RecordingStatus$]
      , asyncScheduler)
      .pipe(mergeAll());
  }

  public GetRecordingId(): Observable<number> {
    return scheduled([
      this._http.get<number>(this._baseUrl + 'RecordingId'),
      this._notifyService.RecordingId$]
      , asyncScheduler)
      .pipe(mergeAll());
  }

  public StopRecording(): Observable<boolean> {
    return this._http.get<boolean>(this._baseUrl + 'StopRecording');
  }

  public StartRecording(id: number): Observable<boolean> {
    return this._http.post<boolean>(this._baseUrl + 'RecordingStatus/' + id, null);
  }
}
