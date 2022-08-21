using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using u21589276_HW04.Models;

namespace u21589276_HW04.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private List<TGLDonors> allPartners = new List<TGLDonors>();
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
            allPartners.Add(new Organisation {Name = "Jay Holdings (pty) ltd", RegistrationNum = "2015/05474/475"});
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
        public IActionResult Partners()
        {
            return View(allPartners);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
