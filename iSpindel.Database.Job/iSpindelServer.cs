using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;

namespace iSpindel.Database.Job
{
    public class iSpindelServer : ISpindelService
    {
        private iSpindelServerOptions options;

        private IManagedMqttClient mqttClient = null;
        public int? CurrentId { get; set; }
        private RawDataPoint dataBuffer = null;
        private readonly string batteryTopic;
        private readonly string temperatureTopic;
        private readonly string gravityTopic;
        private readonly List<string> sensorTopics = new List<string>();

        public iSpindelServer(iSpindelServerOptions options)
        {
            this.options = options;
            this.batteryTopic = options.TopicBasePath + options.TopicBattery;
            this.temperatureTopic = options.TopicBasePath + options.TopicTemperature;
            this.gravityTopic = options.TopicBasePath + options.TopicGravity;

            this.sensorTopics.Add(batteryTopic);
            this.sensorTopics.Add(temperatureTopic);
            this.sensorTopics.Add(gravityTopic);

            using var dbContext = this.options.DbContextFactory();
            if (!dbContext.Database.CanConnect())
            {
                throw new ArgumentException("Could not validate database connection");
            }
        }

        private async Task SubscribeToSensorTopics()
        {
            foreach (var topic in sensorTopics)
            {
                Console.WriteLine($"subscribe to topic {topic}");
                await mqttClient.SubscribeAsync(topic);
            }

            mqttClient.UseApplicationMessageReceivedHandler(async (e) =>
            {
                Console.WriteLine($"Got message on topic {e.ApplicationMessage.Topic}");
                var payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                Console.WriteLine($"Payload {payload}");
                await HandleSensorData(e.ApplicationMessage.Topic, payload);
            });
        }

        private async Task UnsubscribeFromSensorTopics()
        {
            foreach (var topic in sensorTopics)
            {
                await mqttClient.UnsubscribeAsync(topic);
            }
        }
        private async Task HandleSensorData(string topic, string payload)
        {
            dataBuffer ??= new RawDataPoint();

            if (topic.Equals(batteryTopic) && Double.TryParse(payload, NumberStyles.Any, CultureInfo.InvariantCulture, out var batValue))
            {
                dataBuffer.Battery = batValue;
                dataBuffer.LastRecordTime = DateTime.Now;
                Console.WriteLine($"Got battery {batValue} on {dataBuffer.LastRecordTime}");
            }
            else if (topic.Equals(temperatureTopic) && Double.TryParse(payload, NumberStyles.Any, CultureInfo.InvariantCulture, out var tempValue))
            {
                dataBuffer.Temperature = tempValue;
                dataBuffer.LastRecordTime = DateTime.Now;
                Console.WriteLine($"Got temp {tempValue} on {dataBuffer.LastRecordTime}");
            }
            else if (topic.Equals(gravityTopic) && Double.TryParse(payload, NumberStyles.Any, CultureInfo.InvariantCulture, out var gravValue))
            {
                dataBuffer.Gravity = gravValue;
                dataBuffer.LastRecordTime = DateTime.Now;
                Console.WriteLine($"Got grav {gravValue} on {dataBuffer.LastRecordTime}");
            }
            //TODO check timeframe from lastrecordtime here

            if (dataBuffer.Battery.HasValue && dataBuffer.Gravity.HasValue && dataBuffer.Temperature.HasValue)
            {
                Console.WriteLine("Persisting");
                await this.PersistDataPoint();
                Console.WriteLine("Persisted");
            }
        }

        private async Task PersistDataPoint()
        {
            try
            {
                using var dbContext = options.DbContextFactory();

                var dataPoint = new DataPoint()
                {
                    DataSeriesId = CurrentId ?? -1,
                    Temperature = dataBuffer.Temperature.Value,
                    Battery = dataBuffer.Battery.Value,
                    Gravity = dataBuffer.Gravity.Value,
                    RecordTime = dataBuffer.LastRecordTime
                };
                Console.WriteLine($"DataPoint T:{dataPoint.Temperature} B:{dataPoint.Battery} G:{dataPoint.Gravity}");
                dbContext.DataPoints.Add(dataPoint);
                await dbContext.SaveChangesAsync();

                //clear existing data
                dataBuffer = null;
            }
            catch (Exception ex)
            {
                // TODO - do proper logging
                Console.WriteLine(ex.Message + ex.StackTrace);
                Console.WriteLine(ex.InnerException.Message + ex.InnerException.StackTrace);
            }
        }


        public async Task<bool> StartAsync(int id)
        {
            // TODO - check if connection is successful, otherwise return false
            this.mqttClient = await options.MqttClientFactory();
            // TODO - check if subscribe is successful, otherwise return false
            await SubscribeToSensorTopics();
            // TODO - check if Database is alive
            // TODO - check if id already exists in Database
            CurrentId = id;

            using var dbContext = options.DbContextFactory();
            var currentSeries = dbContext.DataSeries.Single(x => x.Id == id);
            currentSeries.Start = DateTime.Now;

            // TODO - return false if another recording is already in progress
            return true;
        }

        public Task<StatusCode> GetStatusAsync()
        {
            return Task.Run(() => CurrentId.HasValue ? StatusCode.RECORDING : StatusCode.IDLE);
        }

        public Task<int?> GetRecordingIdAsync()
        {
            return Task.Run(() => CurrentId);
        }

        public async Task<bool> StopAsync()
        {
            // TODO - check if all this was successful before returning
            await UnsubscribeFromSensorTopics();
            //await mqttClient.StopAsync();

            using var dbContext = options.DbContextFactory();
            var currentSeries = dbContext.DataSeries.Single(x => x.Id == CurrentId);
            currentSeries.End = DateTime.Now;

            mqttClient = null;
            CurrentId = null;
            return true;
        }
    }
}
