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
        [Range(1, 99)]
        [Required]
        public int Filiaal_Id { get; set; }

        [Required, StringLength(30)]
        public string Naam { get; set; }

        [Required, StringLength(50)]
        public string Adres { get; set; }

        [Required, StringLength(50)]
        public string Woonplaats { get; set; }
    }
}
