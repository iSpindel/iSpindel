import { Component, ViewChild, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { DataseriesService } from 'src/services/dataseries.service';
import { IDataPoint } from 'src/classes/Data/IDataPoint';
import { IDataSeries } from 'src/classes/Data/IDataSeries';
import { DataSeries } from 'src/classes/Data/DataSeries';
//import {MatSort, MatTableDataSource} from '@angular/material';


@Component({
  selector: 'app-list-measures',
  templateUrl: './list-measures.component.html',
  styleUrls: ['./list-measures.component.css']
})
export class ListMeasuresComponent implements OnInit {
  public AllDataSeries$: Observable<DataSeries[]>; 
  public ServerIsRecording: Boolean = false;
  //displayedColumns: string[] = ['position', 'name', 'weight', 'symbol'];
  // dataSource = new MatTableDataSource(this.AllDataSeries$);
  
  //@ViewChild(MatSort) sort: MatSort;

  constructor(private _dataseriesService: DataseriesService) { }

  public isRecordingStartPossible (dataseries: IDataSeries): boolean {
    if (this.ServerIsRecording == true ) {
      return false;
    } 

    if (dataseries.name === "Default Data Series"){
      return false;
    }
    
    if (dataseries.end != null ) {
      return false;
    }

    return true;
  }

  ngOnInit(): void {
    this.AllDataSeries$ = this._dataseriesService.loadAllDataSeries();
  }

}
