using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class MainPart
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string BackgroundImage { get; set; }

        [Required]
        [StringLength(100)]
        public string Heading { get; set; }

        [Required]
        [StringLength(150)]
        public string SubHeading { get; set; }


    }
}
