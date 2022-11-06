import { ICarbonationResult } from "./ICarbonationResult";
import { ICo2Balance } from "./ICo2Balance";

export class CarbonationResult implements ICarbonationResult {
    co2Balance: ICo2Balance;
    sugarPerLiter: number;
    amountOfSolutionPerBottle: number;
    totalAmountOfSugar: number;
    abvPlusBottle: number;

    constructor(co2Balance: ICo2Balance){
        this.co2Balance = co2Balance;
        this.sugarPerLiter = 2 * co2Balance.missing;
    }

}