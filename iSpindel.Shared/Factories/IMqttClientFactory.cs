using MQTTnet.Client;
using MQTTnet.Client.Options;
using MQTTnet.Extensions.ManagedClient;
using System;
using System.Threading.Tasks;

namespace iSpindel.Shared.Factories
{
    public interface IMqttClientFactory
    {
        Func<Task<IMqttClient>> CreateClient(string clientId);
        Func<Task<IManagedMqttClient>> CreateManagedClient(IMqttClientOptions clientOpts);
        (IManagedMqttClient client, ManagedMqttClientOptions options) CreateManagedClient(string clientId);
    }
}