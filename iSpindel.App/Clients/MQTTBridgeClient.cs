using System.Threading.Tasks;

namespace iSpindel.App.Clients
{
    public interface IMqttBridgeClient
    {
        Task ReceiveMessage(string message);
    }
}
