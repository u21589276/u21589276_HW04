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
      
            // all clothing items accepted by The Giving Legends
            DonationItems.Add(
                new ClothingItm
                {
                    Name = "T-shirts",
                    Description = "T-shirt. Good or excellent condition",
                    Size = "Small - 2XL",
                    Color = "Any",
                    Material = "100% Cotton"
                }
            );
            DonationItems.Add(
                new ClothingItm
                {
                    Name = "Shirts",
                    Description = "Shirt. Good or excellent condition",
                    Size = "Small - 2XL",
                    Color = "Any",
                    Material = "100% Cotton or Polyester"
                }
            );
            DonationItems.Add(
                new ClothingItm
                {
                    Name = "Golf T-Shirts",
                    Description = "Golfer T-Shirt. Good or excellent condition",
                    Size = "Small - 2XL",
                    Color = "Any",
                    Material = "100% Cotton or Polyester"
                }
            );
            DonationItems.Add(
                new ClothingItm
                {
                    Name = "Jeans",
                    Description = "For ladies and Men. Good or excellent condition",
                    Size = "30 - 45",
                    Color = "Any",
                    Material = "cotton"
                }
            );
            DonationItems.Add(
                new ClothingItm
                {
                    Name = "Pants",
                    Description = "Pants for Men & ladies. Good or excellent condition",
                    Size = "UK2-13",
                    Color = "Any",
                    Material = "Cotton & Polyester"
                }
            );
            DonationItems.Add(
                new ClothingItm
                {
                    Name = "Tracksuits",
                    Description = "Tracksuits for Men & ladies. Good or excellent condition",
                    Size = "Small - 2XL",
                    Color = "Any",
                    Material = "100 Cotton or Polyester"
                }
            );
            DonationItems.Add(
                new ClothingItm
                {
                    Name = "Runnig Shoes",
                    Description = "Tekkies Good or excellent condition",
                    Size = "UK2-13",
                    Color = "Any",
                    Material = "Cotton & Polyester"
                }
            );
            DonationItems.Add(
               new ClothingItm
               {
                   Name = "Sandals ",
                   Description = "Sandals for ladies and Men. Good or excellent condition",
                   Size = "Small - 2XL",
                   Color = "Any",
                   Material = "Any"
               }
           );
            DonationItems.Add(
               new ClothingItm
               {
                   Name = "Slops ",
                   Description = "Slops for ladies and Men. Good or excellent condition",
                   Size = "UK2-13",
                   Color = "Any",
                   Material = "Any"
               }
           );

            // all Food items accepted by The Giving Legends
            DonationItems.Add(
               new FoodItm
               {
                   Name = "Flour",
                   Description = "All types of flour.",
                   Weight = 2
               }
            );
            DonationItems.Add(
               new FoodItm
               {
                   Name = "sugar",
                   Description = "White or Brown sugar.",
                   Weight = 0.400
               }
           );
            DonationItems.Add(
               new FoodItm
               {
                   Name = "Rice",
                   Description = "Any type of rice.",
                   Weight = 2
               }
            );
            DonationItems.Add(
                 new FoodItm
                 {
                     Name = "Sphagetti / Macaroni",
                     Description = "Any type of sphagetti, macaroni or pasta.",
                     Weight = 0.500
                 }
            );
            DonationItems.Add(
               new FoodItm
               {
                   Name = "Beans",
                   Description = "Any type of Canned beans.",
                   Weight = 0.410
               }
            );
            DonationItems.Add(
                new FoodItm
                {
                    Name = "Bread",
                    Description = "White or Brown bread.",
                    Weight = 0.400
                }   
            );
            DonationItems.Add(
                 new FoodItm
                 {
                     Name = "Magarine",
                     Description = "Any type of margarine.",
                     Weight = 0.5
                 }
            );
            DonationItems.Add(
                 new FoodItm
                 {
                     Name = "Butter",
                     Description = "Any type of Butter.",
                     Weight = 0.500
                 }
            );
            DonationItems.Add(
                new FoodItm
                {
                    Name = "Maize Meal",
                    Description = "Any type of Maize Meal.",
                    Weight = 5
                }
           );
            DonationItems.Add(
              new FoodItm
              {
                  Name = "Organic Garden Vegetables",
                  Description = "Any type of vegetables.",
                  Weight = 10
              }
           );
            DonationItems.Add(
              new FoodItm
              {
                  Name = "Canned Food",
                  Description = "Any type of Canned Food for human consumption.",
                  Weight = 0.500
              }
           );
            return DonationItems;
        }


    }
}
