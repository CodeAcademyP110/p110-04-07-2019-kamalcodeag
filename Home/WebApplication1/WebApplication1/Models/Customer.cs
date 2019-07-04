using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Profile { get; set; }

        [Required]
        [StringLength(500)]
        public string Comment { get; set; }

        [Required]
        [StringLength(50)]
        public string Author { get; set; }

    }
}
