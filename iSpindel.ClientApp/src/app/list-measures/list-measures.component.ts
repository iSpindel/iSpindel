import { Component, ViewChild, OnInit } from '@angular/core';
import { Observable, zip } from 'rxjs';
import { map, switchMap } from 'rxjs/operators';
import { DataseriesService } from 'src/services/dataseries.service';
import { IDataPoint } from 'src/classes/Data/IDataPoint';
import { IDataSeries } from 'src/classes/Data/IDataSeries';
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
  public AllDataSeries$: Observable<DataSeries[]>;
  public ServerIsRecording: Boolean = false;

  constructor(private _dataseriesService: DataseriesService,
    private _recordingService: RecordingService,
    private route: ActivatedRoute) { }

  public isRecordingStartPossible(dataSeries: IDataSeries): Observable<boolean> {
    return zip(
      this._recordingService.GetRecordingId(),
      this._recordingService.GetRecordingStatus().pipe(map(status => status == RecordingStatus.IDLE))
    ).pipe(map(([id, isIdle]) => {
      if (dataSeries.end != null)
        return false;
      if (!isIdle)
        return false;
      if (id == dataSeries.id && !isIdle)
        return false;
      if (dataSeries.id == -1)
        return false;
      return true;
    }));
  }

  public StartRecording(dataSeriesId: number): void {
    this._recordingService.StartRecording(dataSeriesId).subscribe(result => {
    });
  }

  public StopRecording(dataSeriesId: number): void {
    this._recordingService.StopRecording().subscribe(result => {
    });
  }

  ngOnInit(): void {
    this.AllDataSeries$ = this._dataseriesService.loadAllDataSeries();
  }

}
