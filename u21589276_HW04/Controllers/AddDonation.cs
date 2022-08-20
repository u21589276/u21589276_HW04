using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using u21589276_HW04.Models;
using u21589276_HW04.Data;

namespace u21589276_HW04.Controllers
{
    public class AddDonation : Controller
    {
        
        public IActionResult newDonation()
        {
            List<DonorItems> DonorAllItems = ItemsData.getDonorClothingItem();
            //List<DonorItems> DonorFoodItems = ItemsData.getDonorFoodItem();
            return View(DonorAllItems);
        }

    }
}
