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
            allPartners.Add(new Organisation { Name = "Jay Holdings (pty) ltd", RegistrationNum = "2015/95774/475", Phonenumber = "021 5584 212", Address = "234 South Cresent, Oslo, Kwazulu-Natal", DonorType = "Organisation" });
            allPartners.Add(new Organisation { Name = "Smith & Sons (pty) ltd", RegistrationNum = "2002/42368/876", Phonenumber = "039 4661 808", Address = "443 Time Road, Margate, Kwazulu-NAtal", DonorType = "Organisation" });
            allPartners.Add(new Organisation { Name = "Convee (pty) ltd", RegistrationNum = "2022/14894/897", Phonenumber = "011 4856 996", Address = "68 park street, Hillcrest office park, Pretoria", DonorType = "Organisation" });
            allPartners.Add(new Organisation { Name = "Nile Emerg (pty) ltd", RegistrationNum = "2021/35217/221", Phonenumber = "039 6351 808", Address = "22 Lunnon Rd, Hatfield, Pretoria", DonorType = "Organisation" });

            //individuals
            allPartners.Add(new Individual { Name = "Mila Mbopha", Age = 31, Phonenumber = "063 5466 304", DonorType = "Indvidual" });
            allPartners.Add(new Individual { Name = "John Smith", Age = 48, Phonenumber = "083 5786 298", DonorType = "Individual" });
            return allPartners;
        }
    }
}
