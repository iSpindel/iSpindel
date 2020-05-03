
using System.Threading.Tasks;

namespace iSpindel.Database.Job
{
    public class iSpindelClient : ISpindelService
    {
        public Task<StatusCode> GetStatusAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> StartAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> StopAsync()
        {
            throw new System.NotImplementedException();
        }
    }
}