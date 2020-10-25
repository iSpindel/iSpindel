import { Component, OnInit } from '@angular/core';
import { IDataSeries } from 'src/classes/Data/IDataSeries';
import { DataseriesService } from 'src/services/dataseries.service';

@Component({
  selector: 'app-new-measure',
  templateUrl: './new-measure.component.html',
  styleUrls: ['./new-measure.component.css']
})
export class NewMeasureComponent implements OnInit {

  constructor(private _dataSeriesService: DataseriesService) { }

  public newDataSeries: IDataSeries = { name: '', description: '', id: null, datapoints: null, start: null, end: null };

  public CreateNewDataSeries(): void {

    console.log(this.newDataSeries);
    this._dataSeriesService.CreateDataseries(this.newDataSeries);


  }

  ngOnInit() {
  }

}
