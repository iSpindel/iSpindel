import { Injectable } from '@angular/core';

import * as signalR from '@microsoft/signalr';
import { HubConnectionState } from '@microsoft/signalr';
//import { timeHours } from 'd3';
import { BehaviorSubject, Observable, ReplaySubject, Subject } from 'rxjs';
import { IDataPoint } from 'src/classes/Data/IDataPoint';
import { SignalRService } from './signalr.service';

export const enum RecordingStatus {
    UNKNOWN = "UNKNOWN",
    RECORDING = "RECORDING",
    IDLE = "IDLE"
}

export interface NotifyServer {
    Register(channel: number): boolean;
}

export interface NotifyClient {
    RecordingStatusUpdate(status: RecordingStatus): void;
    RecordingChanged(dataSeriesId: number): void;
    NewDataPoint(point: IDataPoint): void;
}

@Injectable({
    providedIn: 'root'
})
export class NotifyService extends SignalRService<NotifyClient, NotifyServer> implements NotifyClient {

    constructor() {
        super('notify');
    }

    private _dataPointsSubject: Subject<IDataPoint> = new ReplaySubject(1);
    public DataPoints$: Observable<IDataPoint> = this._dataPointsSubject.asObservable();

    private _lastStatus: RecordingStatus = RecordingStatus.UNKNOWN;
    private _recordingStatusSubject: Subject<RecordingStatus> = new BehaviorSubject(this._lastStatus);
    public RecordingStatus$: Observable<RecordingStatus> = this._recordingStatusSubject.asObservable();

    private _lastId: number = -1;
    private _recordingIdSubject: Subject<number> = new BehaviorSubject<number>(this._lastId);
    public RecordingId$: Observable<number> = this._recordingIdSubject.asObservable();

    protected register(): void {
        this.OnSelf('RecordingStatusUpdate');
        this.OnSelf('RecordingChanged');
        this.OnSelf('NewDataPoint');
    }

    public NewDataPoint(x: IDataPoint): void {
        console.log('NewDataPoint', x);
        this._dataPointsSubject.next(x);
    }

    public RecordingStatusUpdate(state: RecordingStatus): void {
        console.log('RecordingStatusUpdate', state);
        if (this._lastStatus !== state)
            this._recordingStatusSubject.next(state);
        this._lastStatus = state;
    }

    public RecordingChanged(dataSeriesId: number): void {
        console.log('RecordingChanged', dataSeriesId);
        if (this._lastId !== dataSeriesId)
            this._recordingIdSubject.next(dataSeriesId);
        this._lastId = dataSeriesId;
    }

    protected override onConnected(): void {
        console.log("Notify Service connected");
    }
}