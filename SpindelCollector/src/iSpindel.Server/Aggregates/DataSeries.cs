using iSpindel.Core.BrewBatchAggregate;
using iSpindel.SharedKernel;
using iSpindel.SharedKernel.Interfaces;

namespace iSpindel.Server.Aggregates;

public class DataSeries : EntityBase<int>, IAggregateRoot
{
  public DataSeries(int id) : base(id)
  {
  }

  public virtual ICollection<DataPoint> DataPoints { get; set; }
  public DateTime? Start { get; set; }
  public DateTime? End { get; set; }

  public SpindelDevice iSpindelInUse { get; set; }
}
