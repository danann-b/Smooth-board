using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard_Stylers.Models
{
    public class Gebruiker : IdentityUser
    {
        [Required, StringLength(30)]
        public string Naam { get; set; }
    }
}
