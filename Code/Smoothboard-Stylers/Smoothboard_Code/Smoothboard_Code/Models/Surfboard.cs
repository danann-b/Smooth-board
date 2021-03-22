using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Smoothboard_Code.Models
{
    public class Surfboard
    {
        public int Id { get; set; }
        public string Naam { get; set; }
        public string Beschrijving { get; set; }
        
        [Column(TypeName = "Decimal(18,2)")]

        public decimal Prijs{ get; set; }
        public string FotoUrl { get; set; }

        [ForeignKey("Materiaal")]
        public int MateriaalId { get; set; }
        public Materiaal Materiaal { get; set; }
    }
}
