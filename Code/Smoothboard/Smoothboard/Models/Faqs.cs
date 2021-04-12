using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard.Models
{
    public class Faqs
    { 
        public int Id { get; set; }
        public string Vraag { get; set; }
        public string Antwoord { get; set; }
    }
}
