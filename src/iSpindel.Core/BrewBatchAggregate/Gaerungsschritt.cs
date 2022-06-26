namespace iSpindel.Core.BrewBatchAggregate;

public class Gaerungsschritt
{

  public string? BeerStyle { get; set; }
  public string? YeastType { get; set; }
  public int? Bitterness { get; set; }
  public double? ColorScale { get; set; }
  public double? BrewhouseEfficency { get; set; }
  public double? EVG { get; set; }
  public double? AmountOfWort { get; set; }
  public double? TargetCarbonation { get; set; }
  public bool IsDone { get; set; }

}
