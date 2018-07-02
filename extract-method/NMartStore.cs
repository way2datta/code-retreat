using System;
using System.Collections.Generic;

namespace NMart.Billing
{
    internal class NMartStore
    {
        private static Dictionary<string, int> CategoryGstRatesInPercentage = new Dictionary<string, int>();
        private static Dictionary<string, string> ItemsCategoryMapping = new Dictionary<string, string>();

        public static void Main()
        {
            SetupGstRateForCategories();

            SetupItemsPerCategory();

            Console.WriteLine("Welcome to NMart store");
            Console.WriteLine("***************************");

            string itemName;
            int itemQuantity, ratePerUnitItem;

            AcceptUserInput(out itemName, out itemQuantity, out ratePerUnitItem);

            double finalPrice = CalculateFinalRate(itemName, itemQuantity, ratePerUnitItem);

            PrintBillingDetails(itemName, itemQuantity, ratePerUnitItem, finalPrice);
        }

        private static void AcceptUserInput(out string itemName, out int itemQuantity, out int ratePerUnitItem)
        {
            Console.Write("Enter name of item: ");
            itemName = Console.ReadLine();
            Console.Write("Enter quantity of item: ");
            itemQuantity = int.Parse(Console.ReadLine());
            Console.Write("Enter rate per product item: ");
            ratePerUnitItem = int.Parse(Console.ReadLine());
        }

        private static double CalculateFinalRate(string itemName, int itemQuantity, int ratePerUnitItem)
        {
            string categoryName = GetCategory(itemName);

            int gstPercentageForItem = GetGstPercentage(categoryName);

            double gstRatePerItem = ratePerUnitItem * gstPercentageForItem / 100.0;

            double finalPrice = itemQuantity * (ratePerUnitItem + gstRatePerItem);

            return finalPrice;
        }

        private static string GetCategory(string itemName)
        {
            string categoryName = "";

            foreach (var item in ItemsCategoryMapping)
            {
                if (item.Key == itemName)
                {
                    categoryName = item.Value;
                    break;
                }
            }

            return categoryName;
        }

        private static int GetGstPercentage(string categoryName)
        {
            int gstPercentageForItem = 0;

            foreach (var categoryGstRate in CategoryGstRatesInPercentage)
            {
                if (categoryGstRate.Key == categoryName)
                {
                    gstPercentageForItem = categoryGstRate.Value;
                    break;
                }
            }

            return gstPercentageForItem;
        }

        private static void PrintBillingDetails(string itemName, int itemQuantity, int ratePerUnitItem, double finalPrice)
        {
            string output = "*******************************************\n" +
                "Billing Details for " + itemName + ":\n" +
                "*******************************************\n" +
                "Quantity: " + itemQuantity +
                "\nPrice per unit: " + ratePerUnitItem +
                "\nFinal rate: " + finalPrice;
            Console.WriteLine(output);

            Console.WriteLine("\n*********************************\n");
        }

        private static void SetupGstRateForCategories()
        {
            CategoryGstRatesInPercentage.Add("Food-grains", 0);
            CategoryGstRatesInPercentage.Add("Furniture", 5);
            CategoryGstRatesInPercentage.Add("Electronics", 18);
            CategoryGstRatesInPercentage.Add("Cosmetics", 28);
        }

        private static void SetupItemsForCosmetics()
        {
            ItemsCategoryMapping.Add("Shampoo", "Cosmetics");
            ItemsCategoryMapping.Add("Perfume", "Cosmetics");
        }

        private static void SetupItemsForElectronics()
        {
            ItemsCategoryMapping.Add("TV", "Electronics");
            ItemsCategoryMapping.Add("Mobile", "Electronics");
        }

        private static void SetupItemsForFoodGrains()
        {
            ItemsCategoryMapping.Add("Rice", "Food-grains");
            ItemsCategoryMapping.Add("Wheat", "Food-grains");
        }

        private static void SetupItemsForFurniture()
        {
            ItemsCategoryMapping.Add("Sofa", "Furniture");
            ItemsCategoryMapping.Add("Chairs", "Furniture");
        }

        private static void SetupItemsPerCategory()
        {
            SetupItemsForFoodGrains();
            SetupItemsForFurniture();
            SetupItemsForElectronics();
            SetupItemsForCosmetics();
        }
    }
}