using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using RestAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Controllers
{
    [Route("api/overzicht")]
    [ApiController]
    public class OverzichtController : ControllerBase
    {
        private readonly CursusContext _context;

        public OverzichtController(CursusContext context)
        {
            _context = context;
        }
        //GET: api/overzicht
        [HttpGet]
        public async Task<IActionResult> ShowOverzicht()
        {
            var sqlquery = await _context.CursusDetails.Join(
                _context.CursusInstanties, cursus => cursus.Id,
                cursusInstantie => cursusInstantie.Id, (cursus, cursusInstantie) => new
                {
                    Titel = cursus.titel,
                    CursusCode = cursus.cursusCode,
                    Startdatum = cursusInstantie.startDatum,
                    Duur = cursus.duur,
                }).ToArrayAsync();
            return Ok(sqlquery);
        }
    }
}
