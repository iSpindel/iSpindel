using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using MQTTnet.Client;

namespace iSpindel.Database.Job
{
    public class iSpindelServer : ISpindelService
    {
        private iSpindelServerOptions options;

        private IMqttClient mqttClient = null;
        private int? currentId = null;
        private RawDataPoint dataBuffer = null;
        private readonly string batteryTopic;
        private readonly string temperatureTopic;
        private readonly string gravityTopic;
        private readonly List<string> sensorTopics = new List<string>();

        public iSpindelServer(iSpindelServerOptions options)
        {
            this.options = options;
            this.batteryTopic = options.TopicBasePath+options.TopicBattery;
            this.temperatureTopic = options.TopicBasePath+options.TopicTemperature;
            this.gravityTopic = options.TopicBasePath+options.TopicGravity;

            this.sensorTopics.Add(batteryTopic);
            this.sensorTopics.Add(temperatureTopic);
            this.sensorTopics.Add(gravityTopic);
            
        }


        private async Task subscribeToSensorTopics()
        {
            foreach (var topic in sensorTopics)
            {
                await mqttClient.SubscribeAsync(topic);

            }

            mqttClient.UseApplicationMessageReceivedHandler(e => { handleSensorData(e.ApplicationMessage.Topic, e.ApplicationMessage.Payload); });
        }

        private async Task unsubscribeFromSensorTopics()
        {

            foreach (var topic in sensorTopics)
            {
                await mqttClient.UnsubscribeAsync(topic);

            }

        }
        private void handleSensorData(string topic, byte[] payload)
        {

            dataBuffer = dataBuffer ?? new RawDataPoint();

            if (topic.Equals(batteryTopic) && Double.TryParse(Encoding.UTF8.GetString(payload), out var batValue))
            {
                dataBuffer.Battery = batValue;
                dataBuffer.LastRecordTime = DateTime.Now;
            }
            else if (topic.Equals(temperatureTopic) && Double.TryParse(Encoding.UTF8.GetString(payload), out var tempValue))
            {
                dataBuffer.Temperature = tempValue;
                dataBuffer.LastRecordTime = DateTime.Now;
            }
            else if (topic.Equals(gravityTopic) && Double.TryParse(Encoding.UTF8.GetString(payload), out var gravValue))
            {
                dataBuffer.Gravity = gravValue;
                dataBuffer.LastRecordTime = DateTime.Now;
            }

        }

        private async Task persistDataPoint()
        {
            using var dbContext = options.DbContext();

            var dataPoint = new DataPoint()
            {
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
            this.mqttClient = await options.MqttClientFactory();
            // TODO - check if subscribe is successful, otherwise return false
            await subscribeToSensorTopics();
            // TODO - check if Database is alive
            // TODO - check if id already exists in Database 
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
            await mqttClient.DisconnectAsync();
            mqttClient = null;
            currentId = null;
            return true;
        }
    }
}
