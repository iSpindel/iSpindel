import { Component, ViewChild, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { switchMap } from 'rxjs/operators';
import { DataseriesService } from 'src/services/dataseries.service';
import { IDataPoint } from 'src/classes/Data/IDataPoint';
import { IDataSeries } from 'src/classes/Data/IDataSeries';
import { DataSeries } from 'src/classes/Data/DataSeries';
import { ActivatedRoute } from '@angular/router';


@Component({
  selector: 'app-list-measures',
  templateUrl: './list-measures.component.html',
  styleUrls: ['./list-measures.component.css']
})
export class ListMeasuresComponent implements OnInit {
  public AllDataSeries$: Observable<DataSeries[]>; 
  public ServerIsRecording: Boolean = false;

  constructor(private _dataseriesService: DataseriesService, private route: ActivatedRoute) { }

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
