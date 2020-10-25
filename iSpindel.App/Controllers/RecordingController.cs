using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using iSpindel.Database.Job;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System;
using MQTTnet;
using MQTTnet.Client;
using MQTTnet.Client.Options;
using MQTTnet.Extensions.ManagedClient;
using System.Threading;

namespace iSpindel.App.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecordingController : ControllerBase
    {
        private readonly iSpindelClientOptions iSpindelClientOptions;

        public RecordingController(IOptions<MqttConnectionSettings> settings)
        {
            iSpindelClientOptions = BuildISpindelClientOpts(settings.Value);
        }

        private iSpindelClientOptions BuildISpindelClientOpts(MqttConnectionSettings options)
        {

            var mqttClientOpts = new MqttClientOptionsBuilder()
            .WithTcpServer(options.Host, options.Port)
            .WithCredentials(options.Username, options.Password)
            .Build();

            var managedMqttClientOpts = new ManagedMqttClientOptionsBuilder()
            .WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
            .WithClientOptions(mqttClientOpts)
            .Build();

            Func<Task<IMqttClient>> mqttClientFactory = async () =>
                {
                    var factory = new MqttFactory();
                    var client = factory.CreateMqttClient();
                    Console.WriteLine($"Starting mqtt client");
                    var authResult = await client.ConnectAsync(mqttClientOpts, CancellationToken.None);
                    return client;
                };

            var iSpindelOpts = new iSpindelClientOptions()
            {
                MqttClientFactory = mqttClientFactory,
                TopicBasePath = options.ControlBridgeTopicBasePath,
                TopicServerRequest = options.ServerRequest,
                TopicServerResponse = options.ServerResponse
            };

            return iSpindelOpts;

        }

        // GET: api/Recording
        [HttpGet("RecordingStatus")]
        public async Task<string> RecordingStatus()
        {
            using var iSpindelClient = new iSpindelClient(iSpindelClientOptions);
            var status = await iSpindelClient.GetStatusAsync();
            return status.ToString();
        }

        // POST: api/Recording
        [HttpPost("{id}")]
        public async Task<bool> PostRecording(int id)
        {

            using var iSpindelClient = new iSpindelClient(iSpindelClientOptions);
            var status = await iSpindelClient.StartAsync(id);
            return status;

        }

        // PUT: api/Recording
        [HttpGet("StopRecording")]
        public async Task<bool> StopRecording()
        {
            using var iSpindelClient = new iSpindelClient(iSpindelClientOptions);
            var status = await iSpindelClient.StopAsync();
            return status;
        }
        /*
		// DELETE: api/DataSeries/5
		[HttpDelete("{id}")]
		public async Task<ActionResult<DataSeries>> DeleteDataSeries(int id) {
			var dataSeries = await _context.DataSeries.FindAsync(id);
			if (dataSeries == null) {
				return NotFound();
			}

			_context.DataSeries.Remove(dataSeries);
			await _context.SaveChangesAsync();

			return dataSeries;
		}
       */
    }
}