using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard_Stylers.Models
{
    public class Filiaal
    {
        [Key]
        [Range(1, 11)]

        public int Filiaal_Id { get; set; }
        public string Naam { get; set; }
        public string Adres { get; set; }
        public string Woonplaats { get; set; }
    }
}
