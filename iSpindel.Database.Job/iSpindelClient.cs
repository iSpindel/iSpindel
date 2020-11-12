
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MQTTnet.Client;
using MQTTnet.Exceptions;

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
            try
            {
                var payload = await sendRpcRequest("Status");

                if (statusLookup.TryGetValue(payload, out var statusCode))
                {
                    return statusCode;
                }
            }
            catch (MqttCommunicationTimedOutException)
            {
            }
            return StatusCode.UNKNOWN;
        }

        public async Task<int?> GetRecordingIdAsync()
        {
            try
            {
                var payload = await sendRpcRequest("Id");

                int? id = null;
                if (int.TryParse(payload, out var inId))
                    id = inId;

                return id;
            }
            catch (MqttCommunicationTimedOutException)
            {
            }
            return null;
        }

        public async Task<bool> StartAsync(int id)
        {
            try
            {
                var payload = await sendRpcRequest($"Start|{id}");

                if (payload.Equals("Start Successful"))
                {
                    return true;
                }
            }
            catch (MqttCommunicationTimedOutException)
            {
            }
            return false;
        }

        public async Task<bool> StopAsync()
        {
            try
            {
                var payload = await sendRpcRequest("Stop");

                if (payload.Equals("Stop Successful"))
                {
                    return true;
                }
            }
            catch (MqttCommunicationTimedOutException)
            {
            }

            return false;
        }

        private async Task<string> sendRpcRequest(string payload)
        {
            mqttClient = await options.MqttClientFactory();

            var mqttRpcService = new MqttRpcService(topicServerRequest, topicServerResponse, mqttClient);

            var response = await mqttRpcService.ExecuteAsyncRpcRequest(payload);

            if (response == null)
                return String.Empty;

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