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
        public async Task<ActionResult<CursusDetail>> GetCursusDetail(string id)
        {
            var CursusDetail = await _context.CursusDetails.FindAsync(id);

            if (CursusDetail == null)
            {
                return NotFound();
            }

            return CursusDetail;
        }

        // PUT: api/CursusDetails/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCursusDetail(string id, CursusDetail CursusDetail)
        {
            if (id != CursusDetail.Code)
            {
                return BadRequest();
            }

            _context.Entry(CursusDetail).State = EntityState.Modified;

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
        public async Task<ActionResult<CursusDetail>> PostCursusDetail(CursusDetail CursusDetail)
        {
            _context.CursusDetails.Add(CursusDetail);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (CursusDetailExists(CursusDetail.Code))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetCursusDetail", new { id = CursusDetail.Code }, CursusDetail);
        }

        // DELETE: api/CursusDetails/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCursusDetail(string id)
        {
            var CursusDetail = await _context.CursusDetails.FindAsync(id);
            if (CursusDetail == null)
            {
                return NotFound();
            }

            _context.CursusDetails.Remove(CursusDetail);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CursusDetailExists(string id)
        {
            return _context.CursusDetails.Any(e => e.Code == id);
        }
    }
}
