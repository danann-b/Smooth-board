using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard_Stylers.Models
{
    public class Surfboard
    {   
        /// <summary>
        /// Primary key is Surrboard_Id
        /// </summary>
        [Key]
        [Required]
        [Range(1, 99)]
        public int Surfboard_Id { get; set; }

        /// <summary>
        /// Naam van het surfboard
        /// </summary>
        [Required, StringLength(30)]
        public string Naam { get; set; }

        /// <summary>
        /// Beschrijving onder het surfboard
        /// </summary>
        [Required, StringLength(255)]
        public string Beschrijving { get; set; }

        /// <summary>
        /// Materiaal_Id is de ForeignKey naar Materiaal
        /// </summary>
        [ForeignKey("Materiaal")]
        [Required, Range(1, 99)]
        public int Materiaal_Id { get; set; }

        /// <summary>
        /// Is het prijs van het surfboard in decimalen van 0,01 tot 9999,99
        /// </summary>
        [Required]
        [Range(0.01, 9999.99)]
        public Decimal Prijs { get; set; }

        /// <summary>
        /// Is de Url van de foto met een maximum lengte van 255 char
        /// </summary>
        [Required]
        [StringLength(255)]
        public string  FotoUrl { get; set; }

    }
}
