using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    public class CursusInstantie
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-mm-yyyy}")]
        public DateTime startDatum { get; set; }
        [ForeignKey("CursusDetail")]
        public int cursusDetailId { get; set; }
        public CursusDetail cursusDetail { get; set; }
    }
}
