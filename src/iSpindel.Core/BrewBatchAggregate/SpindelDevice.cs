using iSpindel.SharedKernel;

namespace iSpindel.Core.BrewBatchAggregate;

public class SpindelDevice : EntityBase<Guid>
{
  public SpindelDevice(Guid id) : base(id)
  {
  }

  public string Name { get; set; }
  public string BatteryTopic { get; set; }
  public string TemperatureTopic { get; set; }
  public string GravityTopic { get; set; }
  public string TopicBasePath { get; set; }
}
