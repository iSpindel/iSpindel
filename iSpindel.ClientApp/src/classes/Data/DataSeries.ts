import { first } from "rxjs/operators";
import { BeerCharacteristics } from "./BeerCharacteristics";
import { IDataPoint } from "./IDataPoint";
import * as _ from 'lodash';

export class DataSeries {
    id: number;
    name: string;
    description: string;
    datapoints: IDataPoint[];
    beerCharacteristics: BeerCharacteristics;
    firstPlato : number;
    lastPlato: number;
    start: Date;
    end: Date;

    private dataPointsExist() : boolean {
        if (this.datapoints === null || this.datapoints === undefined || this.datapoints.length == 0){
            return false;
        }

        return true;
    }

    public getFirstGravity() : number {
        if (!this.dataPointsExist()){
            return null;
        }
        return _.first(this.datapoints).gravity;
    }

    public getMeanTemperature() : number {
        if (!this.dataPointsExist()){
            return null;
        }

        const sumTemp = _.sum(this.datapoints.map(x => x.temperature));

        return sumTemp/this.datapoints.length;
    }

    public getAlcoholByVolume() : number {
        if (this.firstPlato == null || this.firstPlato == undefined ||
            this.lastPlato == null || this.lastPlato == undefined){
            return null;
        }

        let lastPlato = this.convertPlatoToSG(this.lastPlato);
        const alcoholByVolume = this.firstPlato * (lastPlato/0.794);

        return _.round(alcoholByVolume, 2);

    }
    
    public convertPlatoToSG(plato: number) : number {
         return 1 + (0.082636 + 3.848 * plato + 0.014563 * plato * plato) / 1000;
    }

    public getAlcoholLevel() : number {
        const alcoholByVolume = this.getAlcoholByVolume();
        const adjustedAlcohol = this.beerCharacteristics?.adjustedAlcoholLevel;

        if (alcoholByVolume != null){
            return alcoholByVolume + adjustedAlcohol;
        }

        return null;
    }

    public getStart() : string {
        if (this.start === null) {
            return "tbd";
        }
        return this.start.getDate().toString().padStart(2,"0") + "." + this.start.getMonth().toString().padStart(2,"0") + "." + this.start.getFullYear();
    }

    public getEnd() : string {
        if ( this.end === null) {
            return "tbd";
        }
        return this.end.getDate().toString().padStart(2,"0") + "." + this.end.getMonth().toString().padStart(2,"0") + "." + this.end.getFullYear();
    }



}