import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';
import { DataseriesService } from 'src/services/dataseries.service';
import { IDataPoint } from 'src/classes/Data/IDataPoint';
import { IDataSeries } from 'src/classes/Data/IDataSeries';


@Component({
  selector: 'app-list-measures',
  templateUrl: './list-measures.component.html',
  styleUrls: ['./list-measures.component.css']
})
export class ListMeasuresComponent implements OnInit {
  public AllDataSeries$: Observable<IDataSeries[]> = this._dataseriesService.AllDataSeries$;
  public AllDataSeries: IDataSeries[];
  
  constructor(private _dataseriesService: DataseriesService) { }

  ngOnInit(): void {
    this.AllDataSeries$.subscribe( x => {
      this.AllDataSeries = x;
      console.log(this.AllDataSeries);
    })
  }

}
