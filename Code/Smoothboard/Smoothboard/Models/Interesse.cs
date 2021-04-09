using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

namespace Smoothboard.Models
{
    public class Interesse
    {
        public int Id { get; set; }
        public int ContactId { get; set; }
        public Contact Contact { get; set; }
        public int SurfboardId { get; set; }
        public Surfboard Surfboard { get; set; }

        [DefaultValue(false)]
        public bool Behandeld { get; set; }
    }
}
