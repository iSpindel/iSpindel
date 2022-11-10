import * as signalR from "@microsoft/signalr";
import { HubConnection } from "@microsoft/signalr";

/*
This class implements type safety for signalR Hubs.
A new service can be created like this:
TService extends SignalRService<TClient, TServer> implements TClient

In a real implementation that may look like this
NotifyService extends SignalRService<NotifyClient, NotifyServer> implements NotifyClient

You must implement a correspondig interface for the typesafty to work, e.g.:
export interface NotifyClient {
    RecordingStatusUpdate(status: RecordingStatus): void;
    RecordingChanged(dataSeriesId: number): void;
    NewDataPoint(point: IDataPoint): void;
}

This class will provide typesaftey and syntax suggestions when writing your hub
https://www.typescriptlang.org/docs/handbook/utility-types.html
*/

/*
this type declaration extracts function names from references interfaces
when typing this.Onself(' the editor suggests one of the function
names defined by the TClient Interface
*/
type FunctionPropertyNames<T> = {
    [K in keyof T]: T[K] extends Function ? K : never;
}[keyof T];

export abstract class SignalRService<TClient, TServer> {

    constructor(protected _hub: string) {
        this._connection = this.createConnection();

        this.startConnection();
    }

    protected _connection?: signalR.HubConnection = undefined;

    /*
    - First parameter must be type TMethod, TMethod is a string from the TServer function names
    - TCall is the signature of the method-call and can be derived from the server methods
    - From the method signature the parameters (TParameters) can be extracted
    - The same goes for the methods return type (TReturn)

    */
   /*
    public Invoke<
        TMethod extends FunctionPropertyNames<TServer>,
        TCall extends TServer[TMethod],
        TParameters extends Parameters<TCall>,
        TReturn extends ReturnType<TCall>
    >(method: TMethod, ...params: TParameters): Promise<TReturn> | undefined

      public testInvoke<
        K extends FunctionPropertyNames<S>,
    >(method: K, ...args: S[K] extends (...args: infer A) => any ? A : never):
        Promise<S[K] extends (...args: any) => infer R ? R : never> {
        return new Promise<S[K] extends (...args: any) => infer R ? R : never>(() => console.log("test"));
    }
    */
    public Invoke<TMethod extends FunctionPropertyNames<TServer>>
        (method: TMethod, ...params: TServer[TMethod] extends (...params: infer TCall) => any ? TCall : never):
        Promise<TServer[TMethod] extends (...params: any) => infer TReturn ? TReturn : never> | undefined
    {
        return this._connection?.invoke(method as string, params as any[]) 
    }

    /*
    public On<
        TMethod extends FunctionPropertyNames<TClient>,
        TCall extends TClient[TMethod],
        TParameters extends Parameters<TCall>
    >(method: TMethod, handler: ((...params: TParameters) => void) ): void {
        this._connection?.on(method as string, handler as (...args: any[]) => void);
    }
    */

    public On<TMethod extends FunctionPropertyNames<TServer>>
        (method: TMethod, ...handler: TServer[TMethod] extends (...handler: infer TCall) => void ? TCall : void): void {
        this._connection?.on(method as string, handler as (...handler: any[]) => void);
    }


    public OnSelf(this: TClient & SignalRService<TClient, TServer>, method: FunctionPropertyNames<TClient>) {
        this._connection?.on(method as string, (this as any)[method].bind(this));
    }

    protected createConnection(): HubConnection {
        return new signalR.HubConnectionBuilder()
            .withUrl('/' + this._hub)
            .configureLogging('debug')
            .withAutomaticReconnect()
            .build();
    }

    protected startConnection(): void {
        this.register();
        this._connection?.start().then(() => {
            this.onConnected();
        });
    }

    protected abstract register(): void;
    protected onConnected(): void { };

    public get ConnectionState() {
        return this._connection?.state;
    }
}
