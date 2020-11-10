import { first } from "rxjs/operators";
import { BeerCharacteristics } from "./BeerCharacteristics";
import { IDataPoint } from "./IDataPoint";
import * as _ from 'lodash';
import { mean } from "lodash";

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

    public getFirstPlato() : number {
        return _.round(this.firstPlato,2);
    }

    public getFirstGravity() : number {
        
        if (this.firstPlato != null || this.firstPlato != undefined){
            return _.round(this.firstPlato,2);
        }
        if ( (this.firstPlato == null || this.firstPlato == undefined ) && this.dataPointsExist()){
           const gravity = _.first(this.datapoints).gravity;
           return _.round(gravity,2);
        }

        return undefined;
    }

    public getMeanTemperature() : number {
        if (!this.dataPointsExist()){
            return null;
        }

        const sumTemp = _.sum(this.datapoints.map(x => x.temperature));
        
        let meanTemp = sumTemp/this.datapoints.length;

        return _.round(meanTemp,2);
    }

    private getFirstAndLastPlato() {
        if (this.firstPlato != null && this.lastPlato != null &&
            this.firstPlato != undefined && this.lastPlato != undefined) {
                return {first: this.firstPlato, last: this.lastPlato};
            }
        
        if (this.dataPointsExist() && this.datapoints.length > 1){
            const firstPlato = _.first(this.datapoints).gravity;
            const lastPlato = _.last(this.datapoints).gravity;
                return {first: firstPlato, last: lastPlato};
        }

        return null;
    }

    public getAlcoholByVolume() : number {
        let platoValues = this.getFirstAndLastPlato();

        if (platoValues == null){
            return undefined;
        }

        let lastPlato = this.convertPlatoToSG(platoValues.last);
        const alcoholByVolume = platoValues.first * (lastPlato/0.794);

        return _.round(alcoholByVolume, 2);

    }
    
    public convertPlatoToSG(plato: number) : number {
         return 1 + (0.082636 + 3.848 * plato + 0.014563 * plato * plato) / 1000;
    }

    public getAlcoholLevel() : number {
        const alcoholByVolume = this.getAlcoholByVolume();
        const adjustedAlcohol = this.beerCharacteristics?.adjustedAlcoholLevel;

        if (alcoholByVolume != null){
            return adjustedAlcohol != null ? alcoholByVolume + adjustedAlcohol : alcoholByVolume;
        }

        return undefined;
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