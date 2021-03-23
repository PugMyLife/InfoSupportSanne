using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    public class CursusDetail
    {
        public CursusDetail()
        {
            cursusInstanties = new List<CursusInstantie>();
        }
        [Key]
        public int Id { get; set; }
        [Required]
        public int duur { get; set; }
        [Required]
        [MaxLength(300)]
        public string titel { get; set; }
        [Required]
        public string cursusCode { get; set; }

        public List<CursusInstantie> cursusInstanties { get; set; }
    }
}
