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
    public class CursusDetailsController : ControllerBase
    {
        private readonly CursusContext _context;

        public CursusDetailsController(CursusContext context)
        {
            _context = context;
        }

        // GET: api/CursusDetails
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CursusDetail>>> GetCursusDetails()
        {
            return await _context.CursusDetails.ToListAsync();
        }

        // GET: api/CursusDetails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CursusDetail>> GetCursusDetail(int id)
        {
            var cursusDetail = await _context.CursusDetails.FindAsync(id);

            if (cursusDetail == null)
            {
                return NotFound();
            }

            return cursusDetail;
        }

        // PUT: api/CursusDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCursusDetail(int id, CursusDetail cursusDetail)
        {
            if (id != cursusDetail.Id)
            {
                return BadRequest();
            }

            _context.Entry(cursusDetail).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CursusDetailExists(id))
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

        // POST: api/CursusDetails
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CursusDetail>> PostCursusDetail(CursusDetail cursusDetail)
        {
            _context.CursusDetails.Add(cursusDetail);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCursusDetail", new { id = cursusDetail.Id }, cursusDetail);
        }

        // DELETE: api/CursusDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCursusDetail(int id)
        {
            var cursusDetail = await _context.CursusDetails.FindAsync(id);
            if (cursusDetail == null)
            {
                return NotFound();
            }

            _context.CursusDetails.Remove(cursusDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CursusDetailExists(int id)
        {
            return _context.CursusDetails.Any(e => e.Id == id);
        }
    }
}
