using IT3045C_Final.Controllers.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace IT3045C_Final.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NHLTeamsController : ControllerBase
    {
        private readonly DbContext _context;

        public NHLTeamsController(DbContext context)
        {
            _context = context;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<NHLTeams>>> GetNHLTeams()
        {
            return await _context.Set<NHLTeams>().ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<NHLTeams>> PostNHLTeams(NHLTeams team)
        {
            _context.Set<NHLTeams>().Add(team);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetNHLTeams", new { id = team.Id }, team);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutNHLTeams(int id, NHLTeams team)
        {
            if (id != team.Id)
            {
                return BadRequest();
            }

            _context.Entry(team).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!_context.Set<NHLTeams>().Any(e => e.Id == id))
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
        public async Task<IActionResult> DeleteNHLTeams(int id)
        {
            var team = await _context.Set<NHLTeams>().FindAsync(id);
            if (team == null)
            {
                return NotFound();
            }

            _context.Set<NHLTeams>().Remove(team);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
