import { Component, OnInit } from '@angular/core';
import { Observable, Subscription } from 'rxjs';
import { Router, ActivatedRoute, ParamMap } from '@angular/router';
import { DataSeries } from 'src/classes/Data/DataSeries';
import { DataseriesService } from 'src/services/dataseries.service';
import { switchMap } from 'rxjs/operators';
import { BeerCharacteristics } from 'src/classes/Data/BeerCharacteristics';
import { ChartData } from 'src/classes/Chart/ChartData';
import { DataRange } from 'src/classes/Chart/DataRange';

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


  chartData: DataRange[];
  //view: any[] = [700, 700];

  // options
  legend: boolean = true;
  showLabels: boolean = true;
  animations: boolean = true;
  xAxis: boolean = true;
  yAxis: boolean = true;
  showYAxisLabel: boolean = true;
  showXAxisLabel: boolean = true;
  //xAxisLabel: string = 'Time';
  //yAxisLabel: string = 'Value';
  timeline: boolean = false;
  autoscale : boolean = true;

  colorScheme = {
    domain: ['#121CD1', '#D1121C', '#CFC0BB', '#7aa3e5', '#a8385d', '#aae3f5']
  };

  constructor(private _dataseriesService: DataseriesService,
    private route: ActivatedRoute,
    private router: Router) {
    }

  getDate(date: Date){
    return date.getHours().toString().padStart(2,"0") + ":" 
		  + date.getMinutes().toString().padStart(2,"0") + " "
		  + date.getDay().toString().padStart(2,"0") + "."
		  + date.getMonth().toString().padStart(2,"0") + "."
		  + date.getFullYear();
  }

  onSelect(data): void {
    console.log('Item clicked', JSON.parse(JSON.stringify(data)));
  }

  onActivate(data): void {
    console.log('Activate', JSON.parse(JSON.stringify(data)));
  }

  onDeactivate(data): void {
    console.log('Deactivate', JSON.parse(JSON.stringify(data)));
  }

  public goToItems(dataSeries: DataSeries) {
    const dataSeriesId = dataSeries ? dataSeries.id : null;
    this.router.navigate(['/beerDetails', { id: dataSeriesId }]);
  }

  public getData(){
    console.log(this.dataSeries.datapoints);
    console.log(this.chartData);
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
      this.chartData = ChartData.fromDataPoints(this.dataSeries.datapoints);
      if (x.beerCharacteristics == null || x.beerCharacteristics == undefined){
        this.dataSeries.beerCharacteristics = new BeerCharacteristics();
      }});
  }

  ngOnDestroy(): void {
    this.dataSeriesSubscription.unsubscribe();
  }

}
