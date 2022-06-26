using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace iSpindel.SharedKernel;

// This can be modified to EntityBase<TId> to support multiple key types (e.g. Guid)
public abstract class EntityBase<TId>
{
  [JsonPropertyName("id")]
  public TId Id { get; set; }

  protected EntityBase(TId id)
  {
    Id = id;
  }

  private List<DomainEventBase> _domainEvents = new();
  [NotMapped]
  public IEnumerable<DomainEventBase> DomainEvents => _domainEvents.AsReadOnly();

  protected void RegisterDomainEvent(DomainEventBase domainEvent) => _domainEvents.Add(domainEvent);
  internal void ClearDomainEvents() => _domainEvents.Clear();
}
