using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace RestAPI.Models
{
    public class CursusInstantie
    {
        public int Id { get; set; }
        public DateTime startDatum { get; set; }
        [ForeignKey("CursusDetail")]
        public int cursusDetailId { get; set; }
        [JsonIgnore]
        public CursusDetail cursusDetail { get; set; }
    }
}
