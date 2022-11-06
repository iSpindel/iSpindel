import { Injectable } from '@angular/core';
import { ICarbonationMeasurements } from 'src/classes/DTOs/ICarbonationMeasurements';
import { ICo2Balance } from 'src/classes/DTOs/ICo2Balance';
import { ISugarSolutionBottles as ISugarSolutionValues } from 'src/classes/DTOs/ISugarSolutionInBottles';
import { CarbonationResult } from 'src/classes/DTOs/CarbonationResult';
import { ICarbonationResult } from 'src/classes/DTOs/ICarbonationResult';

@Injectable({
  providedIn: 'root'
})
export class CalculatorService {

  constructor() { }

  /**
   * calculate saturation value of co2 at given temperature
   */
  public calculateCo2Saturation(temperature: number) : number {
    return (10.13 * Math.exp(-10.73797 + 2617.25 / (temperature) + 273.5));
  }

  /**
 * Return the resulting tempareture of a mix
 *
 * @param  {float} amountComponent1  amount of component 1
 * @param  {float} temperatureComponent1  temperature of component 1
 * @param  {float} amountComponent2  amount of component 2
 * @param  {float} temperatureComponent2  temperature of component 2
 * @return {float}     mix temperature
 */
  public getMixTemperature(amountComponent1, temperatureComponent1, amountComponent2, temperatureComponent2) {
    const mixTemperature = (amountComponent1 * temperatureComponent1 + amountComponent2 * temperatureComponent2) / (amountComponent1 + amountComponent2);
    return mixTemperature;
  }

  /**
   * Calculate the Alcohol by volume
   * from alcohol by weight and final gravity
   *
   * @param  {float} alcoholByWeight    original gravity in Â°P
   * @param  {float} finalGravityInSg  apparent final gravity in SG
   * @return {float}        alcohol by volume in %vol
   */
  public calculateAlcoholByVolume(alcoholByWeight, finalGravityInSg) {
    return alcoholByWeight * (finalGravityInSg / 0.794);
  }

  public calculateBaseCarbonation(measurements: ICarbonationMeasurements) : ICo2Balance {
    var presentCo2 = this.calculateCo2Saturation(measurements.wortTemperatur);
    var missingCo2 = measurements.carbonationGoal - presentCo2;
    return { present : presentCo2, missing: missingCo2};
  }
  /**
 * Calculate the carbonation procedure
 *
 * @param  {object} vars  input parameters
 * @return {object}       results
 */
  public calcCarb(measurements: ICarbonationMeasurements, solutionValues: ISugarSolutionValues) : ICarbonationResult {

    var co2Balance = this.calculateBaseCarbonation(measurements);
    var result = new CarbonationResult(co2Balance);
  
    // Zucker und Zuckerlösung
    let solutionAlcoholByVolume = 0;
    let solutionAlcoholByWeigth = 0;

    // Zuckerlösung pro Flasche
    if (result.sugarPerLiter && solutionValues.bottleVolume && solutionValues.amountOfSolutionPerBottle) {
      // Zuckermenge pro Flasche
      const sugarPerBottle = result.sugarPerLiter * solutionValues.bottleVolume;

      // Extraktgehalt der Lösung
      const solutionExtract = sugarPerBottle / solutionValues.amountOfSolutionPerBottle;

      if (solutionValues.amountOfBeer) {
        // Lösungsmenge
        result.amountOfSolutionPerBottle = solutionValues.amountOfSolutionPerBottle;

        const solutionMinimum =
          ((solutionValues.amountOfSolutionPerBottle / 1000) * solutionValues.amountOfBeer) /
          solutionValues.bottleVolume;

        if (result.amountOfSolutionPerBottle < solutionMinimum) {
          result.amountOfSolutionPerBottle =
            Math.round((solutionMinimum + 0.05) * 10) / 10;
        }
        // Gesamt-Zuckermenge
        result.totalAmountOfSugar =
          solutionExtract * solutionValues.amountOfSolutionPerBottle * 1000;
        // AlkoholgehaltserhÃ¶hung
        // Alkoholgehalt %vol der ZuckerlÃ¶sung
        solutionAlcoholByWeigth = sugarPerBottle / 20 / (solutionValues.amountOfSolutionPerBottle / 1000);
        solutionAlcoholByVolume = this.calculateAlcoholByVolume(solutionAlcoholByWeigth, 1.012);
        result.abvPlusBottle = this.getMixTemperature(
          solutionValues.bottleVolume - solutionValues.amountOfSolutionPerBottle / 1000,
          solutionValues.alcoholByVolumePreCarbonation,
          solutionValues.amountOfSolutionPerBottle / 1000,
          solutionAlcoholByVolume,
        ); // Alkoholgehalt %vol nach Karbonisierung
      }
    }
    return result;
  }
}
