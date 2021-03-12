using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard_Stylers.Models
{
    public class FAQs
    {
        [Required]
        public int FAQ_Id { get; set; }

        [Required]
        public string Vraag { get; set; }

        [Required]
        public string Antwoord { get; set; }
    }
}
