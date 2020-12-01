import { Observable } from "rxjs";
import { DataSeries } from "./DataSeries";

export interface IRecordingDataSeries {
    dataseries: DataSeries;
    isStartable$: Observable<boolean>;
    isStoppable$: Observable<boolean>;
}