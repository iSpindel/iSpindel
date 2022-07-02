using iSpindel.SharedKernel;

namespace iSpindel.Server.Aggregates;

public class DataPoint : EntityBase<int>
{
  public DataPoint(int id) : base(id)
  {
  }
  public int? DataSeriesId { get; set; }
  public DataSeries DataSeries { get; set; }
  public double Temperature { get; set; }
  public double Battery { get; set; }
  public double Gravity { get; set; }
  public DateTime RecordTime { get; set; }
}
