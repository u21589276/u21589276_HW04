using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u21589276_HW04.Models
{
    public class Organisation : TGLDonors
    {
        public string RegistrationNum { get; set; }

        public Organisation()
        {   
   
        }
        public override string getDonorID()
        {
            return RegistrationNum.Substring(3,8) + "TGL22";
        }

    }
}
