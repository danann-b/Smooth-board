using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard_Stylers.Models
{
    public class Contact
    {
        [key]
        [Required]
        public int Contact_Id { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public bool Nieuwsbrief { get; set; }
    }
}
