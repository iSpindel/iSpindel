import { Injectable, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { IDataSeries } from 'src/classes/Data/IDataSeries';
import { DataSeries } from 'src/classes/Data/DataSeries';
import { Observable } from 'rxjs';
import { map } from 'rxjs/operators';
import { BeerCharacteristics } from 'src/classes/Data/BeerCharacteristics';

@Injectable({
  providedIn: 'root'
})
export class DataseriesService {

  public _baseUrl: string;

  constructor(private _http: HttpClient) {
    this._baseUrl = 'api/DataSeries';
  }

  public CreateDataseries(newDataSeries: IDataSeries): void {
    this._http.post<any>(this._baseUrl, newDataSeries).subscribe(result => {
      console.log('result of http post!', result);
    }, error => console.error(error));
  }

  public loadFullDataSeries(dataSeriesId: number): Observable<DataSeries> {
    let dataSeries = this._http.get<IDataSeries>(this._baseUrl + "/" + dataSeriesId).pipe(
      map(dataSeries => this.mapDataSeries(dataSeries))
    )

    return dataSeries;
  }

  public loadAllDataSeries(): Observable<DataSeries[]> {
    let allDataSeries = this._http.get<IDataSeries[]>(this._baseUrl).pipe(
      map(iDataSeriesList =>
        iDataSeriesList.map(dataSeries => this.mapDataSeries(dataSeries))
      )
    );
    return allDataSeries;
  }

  private mapDataSeries(dataSeries: IDataSeries): DataSeries {
          const ds = new DataSeries();
          Object.assign(ds, dataSeries);
          ds.start = dataSeries.start === null ? null : new Date(dataSeries.start);
          ds.end = dataSeries.end === null ? null : new Date(dataSeries.end);

          if (ds.beerCharacteristics != null) {
            ds.beerCharacteristics = new BeerCharacteristics();
            Object.assign(ds.beerCharacteristics, dataSeries.beerCharacteristics);
          }
          console.log(ds);
          return ds;


  }

}
