using iSpindel.SharedKernel;

namespace iSpindel.Core.BrewBatchAggregate;

public class DataPoint : EntityBase<int>
{
  public DataPoint(int id) : base(id)
  {
  }
  public int Id { get; set; }
  public int? DataSeriesId { get; set; }
  public virtual DataSeries DataSeries { get; set; }
  public double Temperature { get; set; }
  public double Battery { get; set; }
  public double Gravity { get; set; }
  public DateTime RecordTime { get; set; }
}
