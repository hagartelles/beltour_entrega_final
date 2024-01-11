using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using beltour.Context;
using beltour.Model;

namespace beltour.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DestiniesController : ControllerBase
    {
        private readonly DbContextDestiny _context;

        public DestiniesController(DbContextDestiny context)
        {
            _context = context;
        }

        // GET: api/Destinies
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Destiny>>> GetDestinies()
        {
            return await _context.Destinies.ToListAsync();
        }

        // GET: api/Destinies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Destiny>> GetDestiny(int id)
        {
            var destiny = await _context.Destinies.FindAsync(id);

            if (destiny == null)
            {
                return NotFound();
            }

            return destiny;
        }

        // PUT: api/Destinies/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDestiny(int id, Destiny destiny)
        {
            if (id != destiny.Id)
            {
                return BadRequest();
            }

            _context.Entry(destiny).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DestinyExists(id))
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

        // POST: api/Destinies
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Destiny>> PostDestiny(Destiny destiny)
        {
            _context.Destinies.Add(destiny);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetDestiny", new { id = destiny.Id }, destiny);
        }

        // DELETE: api/Destinies/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDestiny(int id)
        {
            var destiny = await _context.Destinies.FindAsync(id);
            if (destiny == null)
            {
                return NotFound();
            }

            _context.Destinies.Remove(destiny);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DestinyExists(int id)
        {
            return _context.Destinies.Any(e => e.Id == id);
        }
    }
}
