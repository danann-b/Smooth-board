using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard_Stylers.Models
{
    [Keyless]
    public class FAQs
    { 
        [Required, Range(1, 99)]
        public int FAQ_Id { get; set; }

        [Required, StringLength(255)]
        public string Vraag { get; set; }

        [Required, StringLength(255)]
        public string Antwoord { get; set; }
    }
}
