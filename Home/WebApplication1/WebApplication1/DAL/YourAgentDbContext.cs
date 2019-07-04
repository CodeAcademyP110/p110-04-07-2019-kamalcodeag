using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.DAL
{
    public class YourAgentDbContext : DbContext
    {
        public YourAgentDbContext(DbContextOptions<YourAgentDbContext> options) : base(options)
        {

        }

        public DbSet<MainPart> MainParts { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Advantage> Advantages { get; set; }
    }
}
