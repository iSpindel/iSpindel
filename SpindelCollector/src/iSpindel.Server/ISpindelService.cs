using iSpindel.Shared;
using System.Threading.Tasks;

namespace iSpindel.Database.Job;

public interface ISpindelService
{
  Task<bool> StartAsync(int id);
  Task<bool> StopAsync();
  Task<StatusCode> GetStatusAsync();
  Task<int?> GetRecordingIdAsync();
}
