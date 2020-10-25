import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IDataSeries } from 'src/classes/Data/IDataSeries';

@Injectable({
  providedIn: 'root'
})
export class DataseriesService {

  public _baseUrl: string;

  constructor(private _http: HttpClient) {
    this._baseUrl = 'api/DataSeries/';
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
