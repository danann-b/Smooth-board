using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard_Stylers.Models
{
    public class Materiaal
    {
        [key]
        [Required]
        public int Materiaal_Id { get; set; }

        [Required]
        public int Naam { get; set; }
    }
}
