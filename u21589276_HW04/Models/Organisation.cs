using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u21589276_HW04.Models
{
    public class Organisation : TGLDonors
    {
        public string RegistrationNum { get; set; }

        public Organisation(string regNum)
        {
           RegistrationNum = regNum;
   
        }
        public override string getDonorID()
        {
            return RegistrationNum.Substring(0,4) + "TGL22";
        }

    }
}
