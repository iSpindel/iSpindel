using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.SignalR;
using iSpindel.App.Hubs;
using iSpindel.Database;
using iSpindel.Shared;
using iSpindel.App.Services;

namespace iSpindel.App.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecordingController : ControllerBase
    {
        private readonly iSpindelContext _context;
        private readonly ISpindelClient _spindelClient;
        private readonly IHubContext<NotifyHub, IClientSpindelDataHub> _notifyHub;

        public RecordingController(
            ISpindelClient spindelClient,
            IHubContext<NotifyHub, IClientSpindelDataHub> notifyHub,
            iSpindelContext context)
        {
            _context = context;
            this._spindelClient = spindelClient;
            this._notifyHub = notifyHub;
        }

        // GET: api/Recording
        [HttpGet("RecordingStatus")]
        public async Task<string> RecordingStatus()
        {

            var rc = await _spindelClient.GetStatusAsync();
            await this._notifyHub.Clients.All.RecordingStatusUpdate(rc.ToString());

            return rc.ToString();
        }

        // GET: api/Recording
        [HttpGet("RecordingId")]
        public async Task<int?> RecordingId()
        {

            var rc = await _spindelClient.GetRecordingIdAsync();
            await this._notifyHub.Clients.All.RecordingChanged(rc.Value);

            return rc;
        }

        // POST: api/Recording
        [HttpPost("{id}")]
        public async Task<bool> PostRecording(int id)
        {
            var dbDataSeries = await _context.DataSeries.FindAsync(id);
            if (dbDataSeries == null)
                return false;

            var rc = await _spindelClient.StartAsync(id);

            if (rc)
            {
                await this._notifyHub.Clients.All.RecordingChanged(id);
                await this._notifyHub.Clients.All.RecordingStatusUpdate(Shared.StatusCode.RECORDING.ToString());

                dbDataSeries.Start = DateTime.Now;
                _context.SaveChanges();
            }

            return rc;
        }

        // PUT: api/Recording
        [HttpGet("StopRecording")]
        public async Task<bool> StopRecording()
        {
            var recStatus = await _spindelClient.GetStatusAsync();

            if (recStatus != Shared.StatusCode.RECORDING)
                return false;

            var recId = await _spindelClient.GetRecordingIdAsync();
            if (!recId.HasValue)
                return false;

            var dbDataSeries = await _context.DataSeries.FindAsync(recId);
            if (dbDataSeries == null)
                return false;

            var rc = await _spindelClient.StopAsync();

            if (rc)
            {

                await this._notifyHub.Clients.All.RecordingStatusUpdate(Shared.StatusCode.RECORDING.ToString());
                await this._notifyHub.Clients.All.RecordingChanged(null);

                dbDataSeries.End = DateTime.Now;
                _context.SaveChanges();
            }

            return rc;
        }
    }
}