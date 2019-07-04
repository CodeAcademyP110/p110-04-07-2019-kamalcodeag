using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Property
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Image { get; set; }

        [Required]
        public decimal Price { get; set; }

        [Required]
        [StringLength(255)]

        public string Info { get; set; }
    }
}
