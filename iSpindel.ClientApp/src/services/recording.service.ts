import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IDataSeries } from 'src/classes/Data/IDataSeries';
import { asyncScheduler, merge, Observable, of, scheduled } from 'rxjs';
import { NotifyService, RecordingStatus } from './notify.service';
import { catchError, first, map, mergeAll, switchMap } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class RecordingService {

  public _baseUrl: string;

  constructor(private _http: HttpClient, private _notifyService: NotifyService) {
    this._baseUrl = 'api/Recording/';
  }

  private _recordingStatusInternal: Observable<RecordingStatus> = null;
  private _getRecordingStatusInternal(): Observable<RecordingStatus> {
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

  public GetRecordingStatus(): Observable<RecordingStatus> {
    if (this._recordingStatusInternal == null)
      this._recordingStatusInternal = this._getRecordingStatusInternal();
    return this._recordingStatusInternal;
  }

  private _recordingIdInternal: Observable<number> = null;
  private _getRecordingIdInternal(): Observable<number> {
    return scheduled([
      this._http.get<number>(this._baseUrl + 'RecordingId'),
      this._notifyService.RecordingId$]
      , asyncScheduler)
      .pipe(mergeAll());
  }
  public GetRecordingId(): Observable<number> {
    if (this._recordingIdInternal == null)
      this._recordingIdInternal = this._getRecordingIdInternal();
    return this._recordingIdInternal;
  }

  public StopRecording(): Observable<boolean> {
    return this._http.get<boolean>(this._baseUrl + 'StopRecording').pipe(catchError((error, caught) => of(false)));
  }

  public StartRecording(id: number): Observable<boolean> {
    return this._http.post<boolean>(this._baseUrl + id, null).pipe(catchError((error, caught) => of(false)));
  }
}
