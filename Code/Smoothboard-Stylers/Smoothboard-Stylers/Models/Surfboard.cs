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
        public int     Surfboard_Id { get; set; }

        /// <summary>
        /// Naam van het surfboard
        /// </summary>
        public string  Naam { get; set; }

        /// <summary>
        /// Beschrijving onder het surfboard
        /// </summary>
        public string  Beschrijving { get; set; }

        /// <summary>
        /// Materiaal_Id is de ForeignKey naar Materiaal
        /// </summary>
        [ForeignKey("Materiaal")]
        public int     Materiaal_Id { get; set; }

        /// <summary>
        /// Is het prijs van het surfboard in decimalen
        /// </summary>
        public Decimal Prijs { get; set; }

        /// <summary>
        /// Is de Url van de foto
        /// </summary>
        public string  FotoUrl { get; set; }

    }
}
