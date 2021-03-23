using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI.Models;

namespace RestAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CursusInstantiesController : ControllerBase
    {
        private readonly CursusContext _context;

        public CursusInstantiesController(CursusContext context)
        {
            _context = context;
        }

        // GET: api/CursusInstanties
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CursusInstantie>>> GetCursusInstanties()
        {
            return await _context.CursusInstanties.ToListAsync();
        }

        // GET: api/CursusInstanties/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CursusInstantie>> GetCursusInstantie(int id)
        {
            var cursusInstantie = await _context.CursusInstanties.FindAsync(id);

            if (cursusInstantie == null)
            {
                return NotFound();
            }

            return cursusInstantie;
        }

        // PUT: api/CursusInstanties/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCursusInstantie(int id, CursusInstantie cursusInstantie)
        {
            if (id != cursusInstantie.Id)
            {
                return BadRequest();
            }

            _context.Entry(cursusInstantie).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursusInstantieExists(id))
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

        // POST: api/CursusInstanties
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CursusInstantie>> PostCursusInstantie(CursusInstantie cursusInstantie)
        {
            _context.CursusInstanties.Add(cursusInstantie);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCursusInstantie", new { id = cursusInstantie.Id }, cursusInstantie);
        }

        // DELETE: api/CursusInstanties/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCursusInstantie(int id)
        {
            var cursusInstantie = await _context.CursusInstanties.FindAsync(id);
            if (cursusInstantie == null)
            {
                return NotFound();
            }

            _context.CursusInstanties.Remove(cursusInstantie);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CursusInstantieExists(int id)
        {
            return _context.CursusInstanties.Any(e => e.Id == id);
        }
    }
}
