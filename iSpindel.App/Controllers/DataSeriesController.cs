using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using iSpindel.Database;

namespace iSpindel.App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataSeriesController : ControllerBase
    {
        private readonly iSpindelContext _context;

        public DataSeriesController(iSpindelContext context)
        {
            _context = context;
        }

        // GET: api/DataSeries
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DataSeries>>> GetDataSeries()
        {
            return await _context.DataSeries.ToListAsync();
        }

        // GET: api/DataSeries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DataSeries>> GetDataSeries(int id)
        {
            var dataSeries = await _context.DataSeries.FindAsync(id);

            if (dataSeries == null)
            {
                return NotFound();
            }

            return dataSeries;
        }

        // PUT: api/DataSeries/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDataSeries(int id, DataSeries dataSeries)
        {
            if (id != dataSeries.Id)
            {
                return BadRequest();
            }

            _context.Entry(dataSeries).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DataSeriesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/DataSeries
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<DataSeries>> PostDataSeries(DataSeries dataSeries)
        {
            _context.DataSeries.Add(dataSeries);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDataSeries", new { id = dataSeries.Id }, dataSeries);
        }

        // DELETE: api/DataSeries/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<DataSeries>> DeleteDataSeries(int id)
        {
            var dataSeries = await _context.DataSeries.FindAsync(id);
            if (dataSeries == null)
            {
                return NotFound();
            }

            _context.DataSeries.Remove(dataSeries);
            await _context.SaveChangesAsync();

            return dataSeries;
        }

        private bool DataSeriesExists(int id)
        {
            return _context.DataSeries.Any(e => e.Id == id);
        }
    }
}
