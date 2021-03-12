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
        [Required]
        public int Filiaal_Id { get; set; }

        [Required]
        public string Naam { get; set; }

        [Required]
        public string Adres { get; set; }

        [Required]
        public string Woonplaats { get; set; }
    }
}
