using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.ViewModels
{
    public class HomeIndexVM
    {
        public MainPart MainPart { get; set; }
        public IEnumerable<Property> Properties { get; set; }
        public IEnumerable<Customer> Customers { get; set; }
        public About About { get; set; }
        public IEnumerable<Post> Posts { get; set; }
        public IEnumerable<Advantage> Advantages { get; set; }
    }
}
