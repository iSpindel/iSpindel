using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MQTTnet.Client;
using MQTTnet.Client.Connecting;
using MQTTnet.Client.Options;

namespace iSpindel.Database.Job
{
    public class iSpindelServer : ISpindelService
    {
        private IMqttClient mqttDataClient;
        private IMqttClientOptions mqttClientOptions;
        private int? currentId = null;

        private const string topicBasePath = "ispindel/iSpindel0/";
        private readonly string[] sensorTopics = { "battery", "gravity", "temperature" };

        public iSpindelServer(IMqttClient mqttDataClient, IMqttClientOptions mqttClientOptions)
        {
            this.mqttDataClient = mqttDataClient;
            this.mqttClientOptions = mqttClientOptions;
        }


        private async Task subscribeToSensorTopics()
        {
            foreach (var topic in sensorTopics)
            {
                await mqttDataClient.SubscribeAsync(topicBasePath + topic);

            }

            mqttDataClient.UseApplicationMessageReceivedHandler(e => { handleSensorData(e.ApplicationMessage.Topic, e.ApplicationMessage.Payload); });
        }

        private async Task unsubscribeFromSensorTopics()
        {

            foreach (var topic in sensorTopics)
            {
                await mqttDataClient.UnsubscribeAsync(topicBasePath + topic);

            }

        }
        private void handleSensorData(string topic, byte[] payload)
        {
            // TODO implement magic
            // a database entry consist of a data point, which is an entry of temp, grav and batt
            // ispindel sends this information in seperate topics
            // magic happens here!
        }

        private void persistDataPoint()
        {
            // TODO implement context factory
            /*
            using var dbContext = DbContextFactory.Create();
            dbContext.Set(dataPoint);
            dbContext.SaveChangesAsync();
            */
        }


        public async Task<bool> StartAsync(int id)
        {
            // TODO - check if connection is successful, otherwise return false
            await mqttDataClient.ConnectAsync(mqttClientOptions, CancellationToken.None);
            // TODO - check if subscribe is successful, otherwise return false
            await subscribeToSensorTopics();
            // TODO - check if Database is alive
            currentId = id;

            // TODO - return false if another recording is already in progress
            return true;
        }

        public Task<StatusCode> GetStatusAsync()
        {
            return Task.Run(() => currentId.HasValue ? StatusCode.RECORDING : StatusCode.IDLE);
        }

        public async Task<bool> StopAsync()
        {
            // TODO - check if all this was successful before returning
            await unsubscribeFromSensorTopics();
            await mqttDataClient.DisconnectAsync();
            currentId = null;
            return true;
        }

        // TODO handle Reconnect
    }
}
