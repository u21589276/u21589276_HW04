using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace u21589276_HW04.Models
{
    public class TGLDonors
    {
        public string Name { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
        public string DonorType { get; set; }

        public TGLDonors()
        {
           
        }
        public virtual string getDonorID()
        {
            return Name.Substring(0, 3) + "TGL22";
        }

        public virtual int getAge()
        {
            return getAge();
        }
    }
}
