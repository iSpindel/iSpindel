namespace iSpindel.Core.BrewBatchAggregate;

public class BrewBatchId
{
  public Guid Id { get; set; }
  public BrewBatchId(Guid guid)
  {
    Id = guid;
  }

  public static implicit operator BrewBatchId(Guid value)
  {
    return new BrewBatchId(value);
  }

  public override bool Equals(object? obj)
  {
    return obj is BrewBatchId id &&
      Id.Equals(id);
  }

  public override int GetHashCode()
  {
    return HashCode.Combine(Id);
  }

  public override string? ToString()
  {
    return Id.ToString();
  }
}
