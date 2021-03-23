using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    public class CursusInstantie
    {
        public DateTime startDatum { get; set; }
        public CursusDetail cursusDetail { get; set; }
    }
}
