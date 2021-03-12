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
        public int     Surfboard_Id { get; set; }

        /// <summary>
        /// Naam van het surfboard
        /// </summary>
        [Required]
        public string  Naam { get; set; }

        /// <summary>
        /// Beschrijving onder het surfboard
        /// </summary>
        [Required]
        public string  Beschrijving { get; set; }

        /// <summary>
        /// Materiaal_Id is de ForeignKey naar Materiaal
        /// </summary>
        [ForeignKey("Materiaal")]
        [Required]
        public int     Materiaal_Id { get; set; }

        /// <summary>
        /// Is het prijs van het surfboard in decimalen
        /// </summary>
        [Required]
        public Decimal Prijs { get; set; }

        /// <summary>
        /// Is de Url van de foto
        /// </summary>
        [Required]
        public string  FotoUrl { get; set; }

    }
}
