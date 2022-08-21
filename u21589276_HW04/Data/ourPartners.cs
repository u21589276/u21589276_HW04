using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using u21589276_HW04.Models;

namespace u21589276_HW04.Data
{
    public class ourPartners
    {
        public static List<TGLDonors> getAllPartners()
        {
            List<TGLDonors> allPartners = new List<TGLDonors>();

            //companies
            allPartners.Add(new Organisation { Name = "Jay Holdings (pty) ltd", RegistrationNum = "2015/05474/475", Phonenumber = "021 5584 2121" });

            //individuals
            allPartners.Add(new Individual { Name = "Mila Mbopha", Age = 21, Phonenumber = "063 5466 304" });

            return allPartners;
        }
    }
}
