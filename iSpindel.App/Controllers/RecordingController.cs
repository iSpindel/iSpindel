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

namespace iSpindel.App.Controllers
{
    [Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class RecordingController : ControllerBase
	{
        private readonly iSpindelClient _iSpindelClient;

		public RecordingController(IOptions<MqttConnectionSettings> settings){
            //iSpindelClientOptions options) {
             var options = BuildISpindelClientOpts(settings.Value);   
            _iSpindelClient = new iSpindelClient(options);
		}

        private iSpindelClientOptions BuildISpindelClientOpts(MqttConnectionSettings options){

            var mqttClientOpts = new MqttClientOptionsBuilder()
            .WithTcpServer(options.Host, options.Port)
            .WithCredentials(options.Username, options.Password)
            .Build();

            var managedMqttClientOpts = new ManagedMqttClientOptionsBuilder()
            .WithAutoReconnectDelay(TimeSpan.FromSeconds(5))
            .WithClientOptions(mqttClientOpts)
            .Build();
            
            Func<Task<IManagedMqttClient>> managedMqttClientFactory = async () =>
                {
                    var factory = new MqttFactory();
                    var client = factory.CreateManagedMqttClient();
                    Console.WriteLine($"Starting mqtt client");
                    await client.StartAsync(managedMqttClientOpts);
                    return client;
                };

            var iSpindelOpts = new iSpindelClientOptions(){
                MqttClientFactory = managedMqttClientFactory,
                TopicBasePath = options.iSpindelTopicBasePath ,
                TopicServerRequest = options.ServerRequest,
                TopicServerResponse = options.ServerResponse

            };

            return iSpindelOpts;

        }

		// GET: api/Recording
		[HttpGet]
		public async Task<string> GetRecording() {
             var status = await _iSpindelClient.GetStatusAsync();
             return status.ToString();
		}

		// POST: api/Recording
		[HttpPost("{id}")]
		public async Task<bool> PostRecording(int id) {
            
            return await _iSpindelClient.StartAsync(id);

		}

		// PUT: api/Recording
		[HttpPut]
		public async Task<bool> PutRecording() {
            return await _iSpindelClient.StopAsync();
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