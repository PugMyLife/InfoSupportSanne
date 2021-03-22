using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    public class CursusDetailContext:DbContext
    {
        public CursusDetailContext(DbContextOptions<CursusDetailContext> options) : base(options) { }

        public DbSet<CursusDetail>CursusDetails { get; set; }
    }
}
