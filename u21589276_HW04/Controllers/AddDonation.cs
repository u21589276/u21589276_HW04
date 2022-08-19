using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using u21589276_HW04.Models;

namespace u21589276_HW04.Controllers
{
    public class AddDonation : Controller
    {
        private List<DonorItems> DonorItems = new List<DonorItems>();
        public IActionResult newDonation()
        {
            return View();
        }
    }
}
