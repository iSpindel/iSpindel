import { Component, OnInit } from '@angular/core';
import { Observable, Subscription } from 'rxjs';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { DataSeries } from 'src/classes/Data/DataSeries';
import { DataseriesService } from 'src/services/dataseries.service';
import { switchMap } from 'rxjs/operators';
import { BeerCharacteristics } from 'src/classes/Data/BeerCharacteristics';

@Component({
  selector: 'app-beer-details',
  templateUrl: './beer-details.component.html',
  styleUrls: ['./beer-details.component.scss']
})
export class BeerDetailsComponent implements OnInit {
  public dataSeries$: Observable<DataSeries>;
  public dataSeries: DataSeries;
  public dataSeriesSubscription: Subscription;
  public selectedDataSeriesId: number;
  public isFormChanged : boolean = false;

  constructor(private _dataseriesService: DataseriesService,
    private route: ActivatedRoute,
    private router: Router) { }

  public goToItems(dataSeries: DataSeries) {
    const dataSeriesId = dataSeries ? dataSeries.id : null;
    this.router.navigate(['/beerDetails', { id: dataSeriesId }]);
  }

  public onSubmit() {
    console.log(this.dataSeries);
    this._dataseriesService.UpdateDataseries(this.dataSeries);
  }

  ngOnInit(): void {

    this.dataSeries$ = this.route.paramMap.pipe(
      switchMap(params => {
        this.selectedDataSeriesId = Number(params.get('id'));
        return this._dataseriesService.loadFullDataSeries(this.selectedDataSeriesId);
      })
    );

    this.dataSeriesSubscription = this.dataSeries$.subscribe(x => {
      this.dataSeries = x;
      if (x.beerCharacteristics == null || x.beerCharacteristics == undefined){
        this.dataSeries.beerCharacteristics = new BeerCharacteristics();
      }});
  }

  ngOnDestroy(): void {
    this.dataSeriesSubscription.unsubscribe();
  }

}
