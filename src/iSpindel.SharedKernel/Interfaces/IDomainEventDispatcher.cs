
namespace iSpindel.SharedKernel.Interfaces;

public interface IDomainEventDispatcher
{
  Task DispatchAndClearEvents(IEnumerable<EntityBase<Guid>> entitiesWithEvents);
}
