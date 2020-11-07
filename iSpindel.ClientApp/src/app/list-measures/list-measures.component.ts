import { Component, ViewChild, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { DataseriesService } from 'src/services/dataseries.service';
import { IDataPoint } from 'src/classes/Data/IDataPoint';
import { IDataSeries } from 'src/classes/Data/IDataSeries';
//import {MatSort, MatTableDataSource} from '@angular/material';


@Component({
  selector: 'app-list-measures',
  templateUrl: './list-measures.component.html',
  styleUrls: ['./list-measures.component.css']
})
export class ListMeasuresComponent implements OnInit {
  public AllDataSeries$: Observable<IDataSeries[]> = this._dataseriesService.AllDataSeries$;
  public AllDataSeries: IDataSeries[];
  //displayedColumns: string[] = ['position', 'name', 'weight', 'symbol'];
  // dataSource = new MatTableDataSource(this.AllDataSeries$);
  
  //@ViewChild(MatSort) sort: MatSort;

  constructor(private _dataseriesService: DataseriesService) { }

  public getEvg(dataSeries: IDataSeries): string {
    if (dataSeries === null || dataSeries.beerCharacteristics === null ){
      return "";
    }

    return dataSeries.beerCharacteristics.evg + "%";
  }

  /**
   * getDatestring date : Date
   * 
   */
  public getDate(date: string) : string {
    if (date === null) {
      return "tbd"
    }

     var theDate = new Date(date); 
     return theDate.getDate() + "." + theDate.getMonth() + "." + theDate.getFullYear();

    
  }

  ngOnInit(): void {
    //this.dataSource.sort = this.sort;
    /*
    this.AllDataSeries$.subscribe( x => {
      this.AllDataSeries = x;
      console.log(this.AllDataSeries);
      this.AllDataSeries.forEach(
        (value, idx, array) => {
          var date = new Date(value.start);
          console.log(date.getDate() + "." + date.getMonth() + "." + date.getFullYear());
           }
        );
    })
    */
  }

}
