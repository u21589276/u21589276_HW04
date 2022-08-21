using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u21589276_HW04.Models
{
    public class Organisation : TGLDonors
    {
        public string RegistrationNum { get; set; }
        public int Age { get; set; }
        public Organisation()
        { 

        }
        public override string getDonorID()
        {
            return RegistrationNum.Substring(3,8) + "TGL22";
        }

        public override int getAge()
        {
            Age = 2022 - Convert.ToInt32(RegistrationNum.Substring(0, 4));
            return Age;
        }

    }
}
