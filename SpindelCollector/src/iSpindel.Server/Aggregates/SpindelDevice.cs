using iSpindel.SharedKernel;
using iSpindel.SharedKernel.Interfaces;

namespace iSpindel.Core.BrewBatchAggregate;

public class SpindelDevice : EntityBase<Guid>, IAggregateRoot
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
