using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard_Stylers.Models
{
    public class Voorraad
    {

        /// <summary>
        /// Surfboard_Id met een range van 1 tot 11
        /// </summary>
        [Range(1, 11)]
        public int Surfboard_Id { get; set; }

        /// <summary>
        /// Filiaal_Id met een range van 1 tot 11
        /// </summary>
        [Range(1, 11)]
        public int Filiaal_Id { get; set; }

        /// <summary>
        /// Aantal  _Id met een range van 1 tot 11
        /// </summary>
        [Range(1, 999)]
        public int Aantal { get; set; }

    }
}
