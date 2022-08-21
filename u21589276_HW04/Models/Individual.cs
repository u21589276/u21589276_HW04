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
            return Name.Substring(0, 4) + "TGL22";
        }

    }
}
