import { Component, OnInit } from '@angular/core';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-live-data',
  templateUrl: './live-data.component.html',
  styleUrls: ['./live-data.component.css']
})
export class LiveDataComponent implements OnInit {

  public currentTemperature$: Observable<number>;
  public currentBattery$: Observable<number>;
  public currentGravity$: Observable<number>;

  constructor() { }

  ngOnInit() {

  }

}
