using System;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;
using MQTTnet.Client;
using MQTTnet.Extensions.ManagedClient;
using Microsoft.Extensions.Options;

using iSpindel.Shared.Options;
using iSpindel.Shared.Factories;
using iSpindel.Shared;

namespace iSpindel.Database.Job
{
    public class iSpindelServer : ISpindelService
    {
        private IManagedMqttClient _mqttClient = null;
        private IDbContextFactory _dbContextFactory = null;
        private Shared.Factories.IMqttClientFactory _mqttClientFactory = null;
        public int? CurrentId { get; set; }
        private RawDataPoint _dataBuffer = null;
        private readonly string _batteryTopic;
        private readonly string _temperatureTopic;
        private readonly string _gravityTopic;
        private readonly List<string> _sensorTopics = new List<string>();

        public iSpindelServer(IOptions<SpindelServerOptions> options, Shared.Factories.IMqttClientFactory mqttClientFactory, IDbContextFactory dbContextFactory)
        {
            this._batteryTopic = options.Value.TopicBasePath + options.Value.TopicBattery;
            this._temperatureTopic = options.Value.TopicBasePath + options.Value.TopicTemperature;
            this._gravityTopic = options.Value.TopicBasePath + options.Value.TopicGravity;

            this._sensorTopics.Add(_batteryTopic);
            this._sensorTopics.Add(_temperatureTopic);
            this._sensorTopics.Add(_gravityTopic);

            using var dbContext = dbContextFactory.CreateContext();
            if (!dbContext.Database.CanConnect())
            {
                throw new ArgumentException("Could not validate database connection");
            }

            this._mqttClientFactory = mqttClientFactory;
            this._dbContextFactory = dbContextFactory;
        }

        private async Task SubscribeToSensorTopics()
        {
            foreach (var topic in _sensorTopics)
            {
                Console.WriteLine($"subscribe to topic {topic}");
                await _mqttClient.SubscribeAsync(topic);
            }

            _mqttClient.UseApplicationMessageReceivedHandler(async (e) =>
            {
                Console.WriteLine($"Got message on topic {e.ApplicationMessage.Topic}");
                var payload = Encoding.UTF8.GetString(e.ApplicationMessage.Payload);
                Console.WriteLine($"Payload {payload}");
                await HandleSensorData(e.ApplicationMessage.Topic, payload);
            });
        }

        private async Task UnsubscribeFromSensorTopics()
        {
            foreach (var topic in _sensorTopics)
            {
                await _mqttClient.UnsubscribeAsync(topic);
            }
        }
        private async Task HandleSensorData(string topic, string payload)
        {
            _dataBuffer ??= new RawDataPoint();

            if (topic.Equals(_batteryTopic) && Double.TryParse(payload, NumberStyles.Any, CultureInfo.InvariantCulture, out var batValue))
            {
                _dataBuffer.Battery = batValue;
                _dataBuffer.LastRecordTime = DateTime.Now;
                Console.WriteLine($"Got battery {batValue} on {_dataBuffer.LastRecordTime}");
            }
            else if (topic.Equals(_temperatureTopic) && Double.TryParse(payload, NumberStyles.Any, CultureInfo.InvariantCulture, out var tempValue))
            {
                _dataBuffer.Temperature = tempValue;
                _dataBuffer.LastRecordTime = DateTime.Now;
                Console.WriteLine($"Got temp {tempValue} on {_dataBuffer.LastRecordTime}");
            }
            else if (topic.Equals(_gravityTopic) && Double.TryParse(payload, NumberStyles.Any, CultureInfo.InvariantCulture, out var gravValue))
            {
                _dataBuffer.Gravity = gravValue;
                _dataBuffer.LastRecordTime = DateTime.Now;
                Console.WriteLine($"Got grav {gravValue} on {_dataBuffer.LastRecordTime}");
            }
            //TODO check timeframe from lastrecordtime here

            if (_dataBuffer.Battery.HasValue && _dataBuffer.Gravity.HasValue && _dataBuffer.Temperature.HasValue)
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
                using var dbContext = _dbContextFactory.CreateContext();

                var dataPoint = new DataPoint()
                {
                    DataSeriesId = CurrentId ?? -1,
                    Temperature = _dataBuffer.Temperature.Value,
                    Battery = _dataBuffer.Battery.Value,
                    Gravity = _dataBuffer.Gravity.Value,
                    RecordTime = _dataBuffer.LastRecordTime
                };
                Console.WriteLine($"DataPoint T:{dataPoint.Temperature} B:{dataPoint.Battery} G:{dataPoint.Gravity}");
                dbContext.DataPoints.Add(dataPoint);
                await dbContext.SaveChangesAsync();

                //clear existing data
                _dataBuffer = null;
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
            var mqtt = _mqttClientFactory.CreateManagedClient("iSpindel-Server");
            _mqttClient = mqtt.client;
            await _mqttClient.StartAsync(mqtt.options);
            // TODO - check if subscribe is successful, otherwise return false
            await SubscribeToSensorTopics();
            // TODO - check if Database is alive
            // TODO - check if id already exists in Database
            CurrentId = id;

            using var dbContext = _dbContextFactory.CreateContext();
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

            using var dbContext = _dbContextFactory.CreateContext();
            var currentSeries = dbContext.DataSeries.Single(x => x.Id == CurrentId);
            currentSeries.End = DateTime.Now;

            _mqttClient = null;
            CurrentId = null;
            return true;
        }
    }
}
