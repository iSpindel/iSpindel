
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MQTTnet.Client;

namespace iSpindel.Database.Job
{
    public class iSpindelClient : ISpindelService, IDisposable
    {
        private readonly iSpindelClientOptions options;
        private readonly string topicServerResponse;
        private readonly string topicServerRequest;
        private IMqttClient mqttClient;
        private Dictionary<string, StatusCode> statusLookup;

        public iSpindelClient(iSpindelClientOptions options)
        {
            this.options = options;
            this.topicServerResponse = options.TopicBasePath + options.TopicServerResponse;
            this.topicServerRequest = options.TopicBasePath + options.TopicServerRequest;

            this.statusLookup = Enum.GetValues(typeof(StatusCode))
              .Cast<StatusCode>()
              .ToDictionary(t => t.ToString(), t => t);
        }

        public async Task<StatusCode> GetStatusAsync()
        {
            var payload = await sendRpcRequest("Status");

            if (statusLookup.TryGetValue(payload, out var statusCode))
            {
                return statusCode;
            }
            else
            {
                return StatusCode.UNKNOWN;
            }

        }

        public async Task<bool> StartAsync(int id)
        {
            var payload = await sendRpcRequest($"Start|{id}");

            if (payload.Equals("Start Successful"))
            {
                return true;
            }

            return false;

        }

        public async Task<bool> StopAsync()
        {
            var payload = await sendRpcRequest("Stop");

            if (payload.Equals("Stop Successful"))
            {
                return true;
            }

            return false;
        }

        private async Task<string> sendRpcRequest(string payload)
        {
            mqttClient = await options.MqttClientFactory();

            var mqttRpcService = new MqttRpcService(topicServerRequest, topicServerResponse, mqttClient);

            var response = await mqttRpcService.ExecuteAsyncRpcRequest(payload);
            var responsePayload = Encoding.UTF8.GetString(response);
            Console.WriteLine($"Payload {responsePayload}");

            return responsePayload;

        }

        public void Dispose()
        {
            mqttClient?.DisconnectAsync().Wait();
            mqttClient?.Dispose();
        }
    }
}