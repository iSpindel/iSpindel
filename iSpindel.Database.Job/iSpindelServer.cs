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
        private iSpindelServerOptions options;
        private int? currentId = null;
        private RawDataPoint dataBuffer = null;
        private readonly string batteryTopic;
        private readonly string temperatureTopic;
        private readonly string gravityTopic;

        public iSpindelServer(iSpindelServerOptions options)
        {
            this.options = options;
            options.SensorTopics.TryGetValue("battery", out var batteryTopic);
            options.SensorTopics.TryGetValue("temperature", out var temperatureTopic);
            options.SensorTopics.TryGetValue("gravity", out var gravityTopic);
            this.batteryTopic = batteryTopic;
            this.temperatureTopic = temperatureTopic;
            this.gravityTopic = gravityTopic;
            
        }


        private async Task subscribeToSensorTopics()
        {
            foreach (var topic in options.SensorTopics.Values)
            {
                await options.MqttClient.SubscribeAsync(topic);

            }

            options.MqttClient.UseApplicationMessageReceivedHandler(e => { handleSensorData(e.ApplicationMessage.Topic, e.ApplicationMessage.Payload); });
        }

        private async Task unsubscribeFromSensorTopics()
        {

            foreach (var topic in options.SensorTopics.Values)
            {
                await options.MqttClient.UnsubscribeAsync(topic);

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
            await options.MqttClient.ConnectAsync(options.MqttClientOptions, CancellationToken.None);
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
            await options.MqttClient.DisconnectAsync();
            currentId = null;
            return true;
        }

        // TODO handle Reconnect
    }

    public class iSpindelServerOptions
    {
        public IMqttClient MqttClient { get; set; }
        public IMqttClientOptions MqttClientOptions { get; set; }
        public Func<iSpindelContext> DbContext { get; set; }
        public Dictionary<string, string> SensorTopics { get; set; }

    }
}
