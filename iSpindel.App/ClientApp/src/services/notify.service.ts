import { Injectable } from '@angular/core';

import * as signalR from '@microsoft/signalr';

@Injectable({
    providedIn: 'root'
})
export class NotifyService {

    protected connection : signalR.HubConnection;

    public StartConnection() {
        this.connection = new signalR.HubConnectionBuilder()
            .withUrl('https://localhost:5001/notify')
            .configureLogging('debug')
            .withAutomaticReconnect()
            .build();
        this.connection.start()
        .then(() => {
            console.log('connection established'); 
            this.connection.invoke("Register", 1)
            .then(() => { console.log('registered for notify'); })
            .catch((err) => console.error(err));
        })
        .catch((err) => console.error(err));
        this.connection.on('notify', (d) => {
            console.log('notify', d);
        })
    }
}