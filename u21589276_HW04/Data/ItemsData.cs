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
                    Description = "Any color t-shirt in a good or excellent condition",
                    Size = "Small - 2XL",
                    Color = "White",
                    Material = "100% Cotton"

                }
            ); 

            DonationItems.Add(
                new FoodItm
                {
                    Name = "Bread",
                    Description = "White / Brown",
                    Weight = 0.400
                }
            );

            return DonationItems;
        }


    }
}
