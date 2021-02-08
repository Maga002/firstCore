using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using firstCore.Models;
using firstCore.Data;
using firstCore.ViewModels;

namespace firstCore.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private AgencyContext _context;
        public HomeController(ILogger<HomeController> logger, AgencyContext context)
        {

            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            HomeVM vm = new HomeVM();
            vm.Section1= _context.Section1s.First();
            vm.About = _context.Abouts.First();
            vm.Services = _context.Services.ToList();
            vm.Testimonials = _context.Testimonials.ToList();
            vm.Blogs = _context.Blogs.ToList();
            return View(vm);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
