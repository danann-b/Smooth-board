using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard_Stylers.Models
{
    public class Materiaal
    {

        /// <summary>
        /// Materiaal id met een maximum hoeveelheid van 99
        /// </summary>
        [key]
        [Required]
        [Range(1, 99)]
        public int Materiaal_Id { get; set; }

        /// <summary>
        /// En een naam van het materiaal met een maximum lengte van 30
        /// </summary>
        [Required, StringLength(30)]
        public string Naam { get; set; }
    }
}
