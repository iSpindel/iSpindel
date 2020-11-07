using System.Threading.Tasks;
using iSpindel.App.Messages.MQTTBridge;

namespace iSpindel.App.Clients
{
    public interface IMqttBridgeClient
    {
        Task ReceiveMessage(string message);
    }
}
