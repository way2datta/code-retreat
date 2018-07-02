using System;
using System.Collections.Generic;

namespace NMart.Billing
{
    internal class NMartStore
    {
        private static Dictionary<string, int> CategoryGstRatesInPercentage = new Dictionary<string, int>();
        private static Dictionary<string, string> ItemsCategoryMapping = new Dictionary<string, string>();

        private static void Main()
        {
            CategoryGstRatesInPercentage.Add("Food-grains", 0);
            CategoryGstRatesInPercentage.Add("Furniture", 5);
            CategoryGstRatesInPercentage.Add("Electronics", 18);
            CategoryGstRatesInPercentage.Add("Cosmetics", 28);

            ItemsCategoryMapping.Add("Rice", "Food-grains");
            ItemsCategoryMapping.Add("Wheat", "Food-grains");
            ItemsCategoryMapping.Add("Sofa", "Furniture");
            ItemsCategoryMapping.Add("Chairs", "Furniture");
            ItemsCategoryMapping.Add("TV", "Electronics");
            ItemsCategoryMapping.Add("Mobile", "Electronics");
            ItemsCategoryMapping.Add("Shampoo", "Cosmetics");
            ItemsCategoryMapping.Add("Perfume", "Cosmetics");

            Console.WriteLine("Welcome to NMart store");
            Console.WriteLine("***************************");

            Console.Write("Enter name of item: ");
            string itemName = Console.ReadLine();
            Console.Write("Enter quantity of item: ");
            int itemQuantity = int.Parse(Console.ReadLine());
            Console.Write("Enter rate per product item: ");
            int ratePerUnitItem = int.Parse(Console.ReadLine());

            string categoryName = "";

            foreach (var item in ItemsCategoryMapping)
            {
                if (item.Key == itemName)
                {
                    categoryName = item.Value;
                    break;
                }
            }

            int gstPercentageForItem = 0;

            foreach (var categoryGstRate in CategoryGstRatesInPercentage)
            {
                if (categoryGstRate.Key == categoryName)
                {
                    gstPercentageForItem = categoryGstRate.Value;
                    break;
                }
            }

            double finalPrice = itemQuantity * (ratePerUnitItem + ratePerUnitItem * gstPercentageForItem / 100.0);

            string output = "*******************************************\n" +
                "Billing Details for " + itemName + ":\n" +
                "*******************************************\n" +
                "Quantity: " + itemQuantity +
                "\nPrice per unit: " + ratePerUnitItem +
                "\nFinal rate: " + finalPrice;
            Console.WriteLine(output);

            Console.WriteLine("\n*********************************\n");
        }
    }
}