﻿using iSpindel.SharedKernel;

namespace iSpindel.Core.BrewBatchAggregate;

public class DataSeries : EntityBase<int>
{
  public DataSeries(int id) : base(id)
  {
  }
  public virtual ICollection<DataPoint> DataPoints { get; set; }
  public DateTime? Start { get; set; }
  public DateTime? End { get; set; }

  public SpindelDevice iSpindelInUse { get; set; }
}
