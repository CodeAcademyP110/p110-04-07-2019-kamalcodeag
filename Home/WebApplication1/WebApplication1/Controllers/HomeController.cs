using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DAL;
using WebApplication1.ViewModels;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        private readonly YourAgentDbContext context;
        public HomeController(YourAgentDbContext _context)
        {
            context = _context;
        }
        public IActionResult Index()
        {
            HomeIndexVM viewmodel = new HomeIndexVM()
            {
                MainPart = context.MainParts.First(),
                Properties = context.Properties,
                Customers = context.Customers,
                About = context.Abouts.First(),
                Posts = context.Posts,
                Advantages = context.Advantages
            };
            return View(viewmodel);
        }
    }
}