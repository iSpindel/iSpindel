import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IDataSeries } from 'src/classes/Data/IDataSeries';
import { Observable } from 'rxjs';
import { threadId } from 'worker_threads';

@Injectable({
  providedIn: 'root'
})
export class DataseriesService {

  public _baseUrl: string;

  public readonly AllDataSeries$: Observable<IDataSeries[]>;

  constructor(private _http: HttpClient) {
    this._baseUrl = 'api/DataSeries/';
    this.AllDataSeries$ = this._http.get(`/api/DataSeries`) as Observable<IDataSeries[]>;
  }

  /**
   * CreateDataseries
 newDataSeries: IDataSeries : void  */
  public CreateDataseries( newDataSeries: IDataSeries): void {
    this._http.post<any>(this._baseUrl, newDataSeries).subscribe(result => {
      console.log('result of http post!', result);
    }, error => console.error(error));
  }


}
