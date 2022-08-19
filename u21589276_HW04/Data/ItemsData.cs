using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using u21589276_HW04.Models;

namespace u21589276_HW04.Data
{
    public class ItemsData
    {
        public static List<DonorItems> getDonorClothingItem()
        {
            List<DonorItems> DonationItems = new List<DonorItems>();
            List<ClothingItm> clothingItems = new List<ClothingItm>();

            // all clothing items accepted by The Giving Legends
            DonationItems.Add(
                new ClothingItm
                {
                    Name = "T-shirts",
                    Description = "T-shirt. Good or excellent condition",
                    Size = "Small - 2XL",
                    Color = "White",
                    Material = "100% Cotton"
                }
            );
            DonationItems.Add(
                new ClothingItm
                {
                    Name = "Runnig Shoes",
                    Description = "Tekkies Good or excellent condition",
                    Size = "Small - 2XL",
                    Color = "Any",
                    Material = "Cotton & Polyester "
                }
            );

            // all Food items accepted by The Giving Legends
            DonationItems.Add(
               new FoodItm
               {
                   Name = "Flour",
                   Description = "All types of flour",
                   Weight = 2
               }
            );
            DonationItems.Add(
               new FoodItm
               {
                   Name = "sugar",
                   Description = "White or Brown sugar",
                   Weight = 0.400
               }
           );
            DonationItems.Add(
               new FoodItm
               {
                   Name = "Rice",
                   Description = "Any type of rice",
                   Weight = 2
               }
            );
            DonationItems.Add(
                 new FoodItm
                 {
                     Name = "Sphagetti / Macaroni",
                     Description = "Any type of sphagetti or macaroni",
                     Weight = 0.500
                 }
            );
            DonationItems.Add(
               new FoodItm
               {
                   Name = "Beans",
                   Description = "Any type of Canned beans",
                   Weight = 0.410
               }
            );
            DonationItems.Add(
                new FoodItm
                {
                    Name = "Bread",
                    Description = "White or Brown bread",
                    Weight = 0.400
                }   
            );
            DonationItems.Add(
                 new FoodItm
                 {
                     Name = "Magarne",
                     Description = "Any type of margarine",
                     Weight = 0.5
                 }
            );
            DonationItems.Add(
                 new FoodItm
                 {
                     Name = "Butter",
                     Description = "Any type of Butter",
                     Weight = 0.500
                 }
            );

            return DonationItems;
        }


    }
}
