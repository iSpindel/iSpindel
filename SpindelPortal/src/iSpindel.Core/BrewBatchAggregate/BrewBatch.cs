using iSpindel.SharedKernel;
using iSpindel.SharedKernel.Interfaces;

namespace iSpindel.Core.BrewBatchAggregate;

public class BrewBatch : EntityBase<Guid>, IAggregateRoot
{
  public BrewBatch(Guid brewBatchId, string name, string? description) : base(brewBatchId)
  {
    Name = name;
    Description = description;
  }

  public string Name { get; set; }
  public string? Description { get; set; }
  public string? Notes { get; set; }
  public RezeptSchritt? RezeptSchritt { get; set; }
  public NachBrauenSchritt? NachBrauenSchritt { get; set; }
  public NachGaerungSchritt? NachGaerungSchritt { get; set; }
  public NachAbfuellungSchritt? NachAbfuellSchritt { get; set; }
  public DataSeries? DataSeries { get; set; }
}
