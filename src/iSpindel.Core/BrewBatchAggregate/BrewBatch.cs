using iSpindel.SharedKernel;
using iSpindel.SharedKernel.Interfaces;

namespace iSpindel.Core.BrewBatchAggregate;

public class BrewBatch : EntityBase<BrewBatchId>, IAggregateRoot
{
  public BrewBatch(BrewBatchId brewBatchId, string name, string? description) : base(brewBatchId)
  {
    Name = name;
    Description = description;
  }

  public string Name { get; set; }
  public string? Description { get; set; }
  public string? Notes { get; set; }
  public Gaerungsschritt? Gaerungsschritt { get; set; }
  public Abfuellschritt? AbfuellSchritt { get; set; }
  public ReifeSchritt? ReifeSchritt { get; set; }
  public DataSeries? DataSeries { get; set; }
}
