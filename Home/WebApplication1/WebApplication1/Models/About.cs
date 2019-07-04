using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class About
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Picture { get; set; }

        [Required]
        [StringLength(100)]
        public string Title { get; set; }

        [Required]
        [StringLength(5000)]
        public string Text { get; set; }
    }
}
