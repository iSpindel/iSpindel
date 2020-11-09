import * as signalR from "@microsoft/signalr";
import { HubConnection } from "@microsoft/signalr";

type FunctionPropertyNames<T> = {
    [K in keyof T]: T[K] extends Function ? K : never;
}[keyof T];

export abstract class SignalRService<TClient, TServer> {

    constructor(protected _hub: string) {
        this._connection = this.createConnection();

        this.startConnection();
    }

    protected _connection: signalR.HubConnection = null;

    public Invoke<
        TMethod extends FunctionPropertyNames<TServer>,
        TCall extends TServer[TMethod],
        TParameters extends Parameters<TCall>,
        TReturn extends ReturnType<TCall>
    >(method: TMethod, ...params: TParameters): Promise<TReturn>
    {
        return this._connection.invoke(method as string, params);
    }

    public On<
        TMethod extends FunctionPropertyNames<TClient>,
        TCall extends TClient[TMethod],
        TParameters extends Parameters<TCall>
    >(method: TMethod, handler: ((...params: TParameters) => void) ): void {
        this._connection.on(method as string, handler);
    }

    public OnSelf(this: TClient & SignalRService<TClient, TServer>, method: FunctionPropertyNames<TClient>) {
        this._connection.on(method as string, (this as any)[method].bind(this));
    }

    protected createConnection(): HubConnection {
        return new signalR.HubConnectionBuilder()
            //.withUrl('https://localhost:5001/notify')
            .withUrl('/' + this._hub)
            .configureLogging('debug')
            .withAutomaticReconnect()
            .build();
    }

    protected startConnection(): void {
        this.register();
        this._connection.start().then(() => {
            this.onConnected();
        });
    }

    protected abstract register(): void;
    protected onConnected(): void { };

    public get ConnectionState() {
        return this._connection.state;
    }
}
