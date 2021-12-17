using iSpindel.Shared;
using System.Threading.Tasks;

namespace iSpindel.App.Services
{
    public interface ISpindelClient
    {
        Task<int?> GetRecordingIdAsync();
        Task<StatusCode> GetStatusAsync();
        Task<bool> StartAsync(int id);
        Task<bool> StopAsync();
    }
}