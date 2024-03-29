﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace P110_CoreTravelo.Models
{
    public class Destination
    {
        public int Id { get; set; }

        [Required]
        [StringLength(200)]
        public string Image { get; set; }

        [Required]
        [StringLength(200)]
        public string Name { get; set; }

        [Required]
        [StringLength(200)]
        public string City { get; set; }

        public decimal Price { get; set; }
    }
}
