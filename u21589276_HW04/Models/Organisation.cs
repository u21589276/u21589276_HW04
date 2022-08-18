using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u21589276_HW04.Models
{
    public class Organisation : Donor
    {
        public string OrganisationName { get; set; }
        public int RegistrationNum { get; set; }
    }
}
