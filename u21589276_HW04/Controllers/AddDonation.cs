﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u21589276_HW04.Controllers
{
    public class AddDonation : Controller
    {
        public IActionResult newDonation()
        {
            return View();
        }
    }
}
