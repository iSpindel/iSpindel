import { Observable } from "rxjs";
import { DataSeries } from "./DataSeries";

export interface IRecordingDataSeries {
    dataSeries: DataSeries;
    isStartable$: Observable<boolean>;
    isStoppable$: Observable<boolean>;
}