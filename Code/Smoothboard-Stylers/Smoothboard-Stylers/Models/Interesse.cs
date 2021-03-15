using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard_Stylers.Models
{
    public class Interesse
    {
        
        
        [Key, Required, Range(1, 99)]
        public int Surfboard_Id { get; set; }

        [ForeignKey("Contact"), Required, Range(1, 99)]
        public int Contact_Id { get; set; }
    }
}
