using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    public class CursusDetail
    {
        [Required]
        public int Duur { get; set; }
        [MaxLength(300)]
        public string Titel { get; set; }
        [Key]
        public string Code { get; set; }
    }
}
