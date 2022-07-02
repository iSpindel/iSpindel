using iSpindel.SharedKernel;

namespace iSpindel.Core.BrewBatchAggregate;

public class NachAbfuellungSchritt : ValueObject
{
  public double? AddedSugar { get; set; }
  public double? AdjustedAlcoholLevel { get; set; }


}
