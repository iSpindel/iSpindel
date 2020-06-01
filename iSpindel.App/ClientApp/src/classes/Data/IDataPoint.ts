export interface IDataPoint {
    id: number;
    battery: number;
    temperature: number;
    gravity: number;
    //TODO replace with real datetime
    recordTime: string;
  }