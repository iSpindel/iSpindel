import { IBeerCharacteristics } from "./IBeerCharacteristics";

export class BeerCharacteristics implements IBeerCharacteristics {
    evg: number;
    bitterness: number;
    colorScale: number;
    brewhouseEfficency: number;
    amountOfWort: number;
    targetCarbonation: number;
    addedSugar: number;
    adjustedAlcoholLevel: number;
    yeastType: string;
    notes: string;
    beerStyle: string;

    public getEvg() : string {
        return this.evg == null ? "" : this.evg.toString() + " %";
    }

    public getBitterness() : string {
        return this.bitterness == null ? "" : this.bitterness.toString() + " IBU";
    }
    
    public getColorScale(): string {
        return this.colorScale == null ? "" : this.colorScale.toString() + " EBC";
        
    }

    public getBrewhouseEfficency() : string {
        return this.brewhouseEfficency == null ? "" : this.brewhouseEfficency.toString() + " %";
    }

    public getAmountOfWort() : string {
        return this.amountOfWort == null ? "" : this.amountOfWort.toString() + " L";
    }

    public getAmountOfWortUnit(): string{
        return "L";
    }

    public getTargetCarbonation() : string {
        return this.targetCarbonation == null ? "" : this.targetCarbonation.toString() + " g/L";
    }

    public getAddedSugar() : string {
        return this.addedSugar == null ? "" : this.addedSugar.toString() + " g/L";
    }

    public getAdjustedAlcoholLevel() : string {
        return this.adjustedAlcoholLevel == null ? "" : this.adjustedAlcoholLevel.toString() + " g/L";
    }

}