using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using iSpindel.Database;
using iSpindel.App.DTO;
using System.Linq.Expressions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.SignalR;
using iSpindel.App.Realtime;

namespace iSpindel.App.Controllers
{
	//TODO fix auth
	//[Authorize]
	[Route("api/[controller]")]
	[ApiController]
	public class DataSeriesController : ControllerBase
	{
		private readonly iSpindelContext _context;
		private readonly IHubContext<NotifyHub, IClientSpindelDataHub> hubContext;

		public DataSeriesController(iSpindelContext context, IHubContext<NotifyHub, IClientSpindelDataHub> hubContext)
		{
			_context = context;
			this.hubContext = hubContext;
		}

		// GET: api/DataSeries
		[HttpGet]
		public async Task<ActionResult<IEnumerable<DataSeriesDTO>>> GetDataSeries()
		{
			return await _context.DataSeries
				.OrderByDescending(x => x.Id)
				.Select(SeriesToDTO)
				.ToListAsync();
		}

		[HttpGet("doTest")]
		public async Task<IActionResult> DoTest(int target)
		{
			await this.hubContext.Clients.Group($"grp{target}").Notify(new DataPointDTO() {
				Battery = 1,
				Gravity = 2,
				Temperature = 3,
				RecordTime = DateTime.Now
			});
			return Ok();
		}

		// GET: api/DataSeries/5
		[HttpGet("{id}")]
		public async Task<ActionResult<DataSeriesWithDataPointsDTO>> GetDataSeries(int id)
		{
			var dataSeries = await _context.DataSeries
				.Include(x => x.DataPoints)
				.SingleOrDefaultAsync(x => x.Id == id);

			if (dataSeries == null)
			{
				return NotFound();
			}
			return new DataSeriesWithDataPointsDTO()
			{
				Id = dataSeries.Id,
				Name = dataSeries.Name,
				Description = dataSeries.Description,
				Start = dataSeries.Start,
				End = dataSeries.End,
				Datapoints = dataSeries.DataPoints.Select(x => new DataPointDTO()
				{
					Id = x.Id,
					Battery = x.Battery,
					Gravity = x.Gravity,
					Temperature = x.Temperature,
					RecordTime = x.RecordTime
				})
			};
		}


		// PUT: api/DataSeries/5
		[HttpPut("{id}")]
		public async Task<IActionResult> PutDataSeries(int id, DataSeriesDTO dataSeries)
		{
			if (id != dataSeries.Id)
			{
				return BadRequest();
			}

			var dbDataSeries = await _context.DataSeries.FindAsync(id);

			if (dataSeries == null)
			{
				return NotFound();
			}

			dbDataSeries.Name = dataSeries.Name;
			dbDataSeries.Description = dataSeries.Description;

			try
			{
				await _context.SaveChangesAsync();
			}
			catch (DbUpdateConcurrencyException) when (!DataSeriesExists(id))
			{
				return NotFound();
			}

			return NoContent();
		}

		// POST: api/DataSeries
		// To protect from overposting attacks, enable the specific properties you want to bind to, for
		// more details, see https://go.microsoft.com/fwlink/?linkid=2123754.

		//TODO: Validation!
		[HttpPost]
		public async Task<ActionResult<DataSeriesDTO>> PostDataSeries(CreateDataSeriesDTO dataSeries)
		{
			var newDataSeries = new DataSeries{
				Name = dataSeries.Name,
				Description = dataSeries.Description
			};
			_context.DataSeries.Add(newDataSeries);
			await _context.SaveChangesAsync();

			return CreatedAtAction("GetDataSeries", new { id = newDataSeries.Id }, null);
		}

		// DELETE: api/DataSeries/5
		[HttpDelete("{id}")]
		public async Task<ActionResult<DataSeriesDTO>> DeleteDataSeries(int id)
		{
			var dataSeries = await _context.DataSeries.FindAsync(id);
			if (dataSeries == null)
			{
				return NotFound();
			}

			_context.DataSeries.Remove(dataSeries);
			await _context.SaveChangesAsync();

			return SeriesToDTO.Compile()(dataSeries);
		}

		private bool DataSeriesExists(int id)
		{
			return _context.DataSeries.Any(e => e.Id == id);
		}

		private static readonly Expression<Func<DataSeries, DataSeriesDTO>> SeriesToDTO =
			(DataSeries dataSeries) => new DataSeriesDTO()
			{
				Id = dataSeries.Id,
				Name = dataSeries.Name,
				Description = dataSeries.Description,
				Start = dataSeries.Start,
				End = dataSeries.End
			};
	}
}
