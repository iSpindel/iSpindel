using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using iSpindel.Database.Job;
using Microsoft.AspNetCore.Authorization;

namespace iSpindel.App.Controllers
{
    [Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class RecordingController : ControllerBase
	{
        private readonly iSpindelClient _iSpindelClient;

		public RecordingController(iSpindelClientOptions options) {
            _iSpindelClient = new iSpindelClient(options);
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