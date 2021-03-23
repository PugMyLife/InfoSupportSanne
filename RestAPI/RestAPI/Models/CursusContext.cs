using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestAPI.Models;

namespace RestAPI.Models
{
    public class CursusContext:DbContext
    {
        public CursusContext(DbContextOptions<CursusContext> options) : base(options) { }

        public virtual DbSet<CursusDetail>CursusDetails { get; set; }
        public virtual DbSet<CursusInstantie> CursusInstanties { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
        }
    }
}
