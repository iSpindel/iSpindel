using System;
using System.Collections.Generic;
using System.Text;
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
        private RawDataPoint dataBuffer = null;

        private const string topicBasePath = "ispindel/iSpindel0/";
        private readonly string[] sensorTopics = { "battery", "gravity", "temperature" };
        private readonly Func<iSpindelContext> dbContextFactory;

        public iSpindelServer(IMqttClient mqttDataClient, IMqttClientOptions mqttClientOptions, Func<iSpindelContext> dbContextFactory)
        {
            this.mqttDataClient = mqttDataClient;
            this.mqttClientOptions = mqttClientOptions;
            this.dbContextFactory = dbContextFactory;
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

            dataBuffer = dataBuffer ?? new RawDataPoint();

            if (topic.EndsWith("battery") && Double.TryParse(Encoding.UTF8.GetString(payload),out var batValue) ){
                dataBuffer.Battery = batValue;
                dataBuffer.LastRecordTime = DateTime.Now;
            }
            else if (topic.EndsWith("temperature") && Double.TryParse(Encoding.UTF8.GetString(payload),out var tempValue) ){
                dataBuffer.Temperature = tempValue;
                dataBuffer.LastRecordTime = DateTime.Now;
            }
            else if (topic.EndsWith("gravity") && Double.TryParse(Encoding.UTF8.GetString(payload),out var gravValue)){
                dataBuffer.Gravity = gravValue;
                dataBuffer.LastRecordTime = DateTime.Now;
            }

        }

        private async Task persistDataPoint()
        {
            using var dbContext = this.dbContextFactory();

            var dataPoint = new DataPoint(){
                DataSeriesId = currentId ?? -1,
                Temperature = dataBuffer.Temperature,
                Battery = dataBuffer.Battery,
                Gravity = dataBuffer.Gravity,
                RecordTime = dataBuffer.LastRecordTime
            };
            dbContext.DataPoints.Add(dataPoint);
            await dbContext.SaveChangesAsync();
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
