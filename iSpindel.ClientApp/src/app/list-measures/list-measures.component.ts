import { Component, ViewChild, OnInit } from '@angular/core';
import { Observable, zip } from 'rxjs';
import { map, share, switchMap } from 'rxjs/operators';
import { DataseriesService } from 'src/services/dataseries.service';
import { IDataPoint } from 'src/classes/Data/IDataPoint';
import { IDataSeries } from 'src/classes/Data/IDataSeries';
import { IRecordingDataSeries } from 'src/classes/Data/IRecordingDataSeries';
import { DataSeries } from 'src/classes/Data/DataSeries';
import { ActivatedRoute } from '@angular/router';
import { RecordingService } from 'src/services/recording.service';
import { RecordingStatus } from 'src/services/notify.service';


@Component({
  selector: 'app-list-measures',
  templateUrl: './list-measures.component.html',
  styleUrls: ['./list-measures.component.css']
})
export class ListMeasuresComponent implements OnInit {
  public AllDataSeries$: Observable<IRecordingDataSeries[]>;
  public ServerIsRecording: Boolean = false;

  constructor(private _dataseriesService: DataseriesService,
    private _recordingService: RecordingService,
    private route: ActivatedRoute) { }
  private isIdle$: Observable<boolean>;
  private isRecording$: Observable<boolean>;

  public isRecordingStartPossible(dataSeries: DataSeries): Observable<boolean> {
    return zip(
      this.isIdle$,
    ).pipe(map(([isIdle]) => {
      if (dataSeries.end != null)
        return false;
      if (!isIdle)
        return false;
      if (dataSeries.id == -1)
        return false;
      return true;
    }));
  }

  public isRecordingStopPossible(dataSeries: DataSeries): Observable<boolean> {
    return zip(
      this.isRecording$,
    ).pipe(map(([isRecording]) => {
      if (dataSeries.end != null)
        return false;
      if (!isRecording)
        return false;
      if (dataSeries.id == -1)
        return false;
      return true;
    }));
  }

  public StartRecording(dataSeriesId: number, event: any): void {
    event.stopPropagation();
    this._recordingService.StartRecording(dataSeriesId).subscribe(result => {
    });
    event.target.disabled = true;
  }

  public StopRecording(event: any): void {
    event.stopPropagation();
    this._recordingService.StopRecording().subscribe(result => {
    });
    event.target.disabled = true;
  }

  ngOnInit(): void {
    this.isRecording$ = this._recordingService.GetRecordingStatus().pipe(map(status => status == RecordingStatus.RECORDING), share());
    this.isIdle$ = this._recordingService.GetRecordingStatus().pipe(map(status => status == RecordingStatus.IDLE), share());
    this.AllDataSeries$ = this._dataseriesService.loadAllDataSeries()
      .pipe(
        map<Array<DataSeries>, Array<IRecordingDataSeries>>(ds => {
          return ds.map(d => {
            return <IRecordingDataSeries>{
              dataseries: d,
              isStartable$: this.isRecordingStartPossible(d),
              isStoppable$: this.isRecordingStopPossible(d)
            }
          })
        }
        )
      );
  }

}
