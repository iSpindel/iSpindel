import { ICo2Balance } from "./ICo2Balance";

export interface ICarbonationResult {
    co2Balance : ICo2Balance;
    sugarPerLiter: number;
    amountOfSolutionPerBottle: number;
    totalAmountOfSugar: number;
    abvPlusBottle: number;

}