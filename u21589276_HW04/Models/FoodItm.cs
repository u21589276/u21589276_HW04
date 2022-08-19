using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace u21589276_HW04.Models
{
    public class FoodItm : DonorItems
    {
        [Display(Name = "Weight in KGs")]
        public decimal Weight { get; set; }
    }
}
