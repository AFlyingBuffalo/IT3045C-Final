using IT3045C_Final.Controllers.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IT3045C_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MetroCityController : ControllerBase
    {
        private readonly DbContext _context;

        public MetroCityController(DbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<MetroCity>>> GetMetroCity()
        {
            return await _context.Set<MetroCity>().ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<MetroCity>> PostMetroCity(MetroCity metroCity)
        {
            _context.Set<MetroCity>().Add(metroCity);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMetroCity", new { id = metroCity.Id }, metroCity);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutMetroCity(int id, MetroCity metroCity)
        {
            if (id != metroCity.Id)
            {
                return BadRequest();
            }

            _context.Entry(metroCity).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Set<MetroCity>().Any(e => e.Id == id))
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

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMetroCity(int id)
        {
            var metroCity = await _context.Set<MetroCity>().FindAsync(id);
            if (metroCity == null)
            {
                return NotFound();
            }

            _context.Set<MetroCity>().Remove(metroCity);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
