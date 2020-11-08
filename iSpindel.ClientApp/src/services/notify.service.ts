import { Injectable } from '@angular/core';

import * as signalR from '@microsoft/signalr';
import { HubConnectionState } from '@microsoft/signalr';
import { IDataPoint } from 'src/classes/Data/IDataPoint';
import { SignalRService } from './signalr.service';

export const enum RecordState {
    UNKNOWN,
    RECORDING,
    IDLE
}

export interface NotifyServer {
    Register(x: number): void;
    Ping(x: string): number;
}

export interface NotifyClient {
    notify(x: IDataPoint): void;
    recordingStatusUpdate(state: RecordState): void;
}

@Injectable({
    providedIn: 'root'
})
export class NotifyService extends SignalRService<NotifyClient, NotifyServer> {

    constructor() {
        super('notify');
    }

    protected register(): void {
        this.On('notify', this.NotifyReceived);
        this.On('recordingStatusUpdate', this.UpdateRecordState);
    }

    public UpdateRecordState(state: RecordState): void {

    }

    public NotifyReceived(d: IDataPoint): void {
        console.log('notify', d);
    }

    protected onConnected(): void {
        this.Invoke('Register', 1);
        this.Invoke('Register', 10);
        this.Invoke('Ping', 'asdf').then(x => console.log(x));
    }
}