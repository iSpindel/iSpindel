import { Component, OnInit } from '@angular/core';
import { Observable, Subscription } from 'rxjs';
import { DataSeries } from 'src/classes/Data/DataSeries';
import { DataseriesService } from 'src/services/dataseries.service';

@Component({
  selector: 'app-beer-details',
  templateUrl: './beer-details.component.html',
  styleUrls: ['./beer-details.component.css']
})
export class BeerDetailsComponent implements OnInit {
  public dataSeries$: Observable<DataSeries>; 
  public dataSeriesSubscription: Subscription;
  public dataSeries: DataSeries; 

  constructor(private _dataseriesService: DataseriesService) { }

  ngOnInit(): void {
    this.dataSeries$ = this._dataseriesService.loadFullDataSeries(1);
    this.dataSeriesSubscription = this.dataSeries$.subscribe( x => this.dataSeries = x);
  }

  ngOnDestroy(): void {
    this.dataSeriesSubscription.unsubscribe();
  }

}
