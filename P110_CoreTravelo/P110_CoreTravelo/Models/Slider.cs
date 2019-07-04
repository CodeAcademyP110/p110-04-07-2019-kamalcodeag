using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace P110_CoreTravelo.Models
{
    public class Slider
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Image { get; set; }
    }
}
