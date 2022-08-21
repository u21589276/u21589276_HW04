using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u21589276_HW04.Models
{
    public class Individual : TGLDonors
    {
        public int Age { get; set; }

        public override string getDonorID()
        {
            return Name.Substring(0, 8) + "TGL22";
        }

        public string getAddress()
        {
            return "Sensitive";
        }

        public override int getAge()
        {
            //in the case of individual age means howlong they have been with us
            return Age;
        }

    }
}
