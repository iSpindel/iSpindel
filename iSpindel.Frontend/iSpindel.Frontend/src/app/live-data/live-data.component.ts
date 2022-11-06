import { Component, OnInit } from '@angular/core';
import { Observable, Subscription } from 'rxjs';
import { RecordingStatus } from 'src/services/notify.service';
import { RecordingService } from 'src/services/recording.service';

@Component({
  selector: 'app-live-data',
  templateUrl: './live-data.component.html',
  styleUrls: ['./live-data.component.css']
})
export class LiveDataComponent implements OnInit {

  public currentTemperature$: Observable<number>;
  public currentBattery$: Observable<number>;
  public currentGravity$: Observable<number>;

  public currentRecordingId$: Observable<number>;
  public currentRecordingStatus$: Observable<RecordingStatus>;

  constructor(public recordingService: RecordingService) {
    //this.currentRecordingId$ = this.recordingService.GetRecordingId();
    this.currentRecordingStatus$ = this.recordingService.GetRecordingStatus();
  }

  ngOnInit() {

  }

}
