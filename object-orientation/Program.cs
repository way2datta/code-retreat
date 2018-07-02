using System;
using System.Collections.Generic;

namespace object_orientation
{
    internal class Billing
    {
        internal static BillingDetails GetBillingDetails(Item scannedItem)
        {
            decimal itemFinalPrice = CalculateFinalPrice(scannedItem);

            BillingDetails billingDetails = new BillingDetails(scannedItem);

            billingDetails.FinalPrice = itemFinalPrice;

            return billingDetails;
        }

        private static decimal CalculateFinalPrice(Item item)
        {
            string category = ItemsCategoryMapping.GetCategoryFor(item.Name);

            int gstRateForItem = GstRateProvider.GetRateFor(category);
        
            decimal gstRatePerItem = item.InitialPrice * gstRateForItem / 100;

            decimal finalPrice = item.Quantity * (item.InitialPrice + gstRatePerItem);

            return finalPrice;
        }
    }

    internal class BillingDetails
    {
        public BillingDetails(Item scannedItem)
        {
            this.Item = scannedItem;
        }

        public decimal FinalPrice { get; set; }
        public Item Item { get; set; }
    }

    internal class GstRateProvider
    {
        private static Dictionary<string, int> CategoryGstRatesInPercentage = new Dictionary<string, int>();

        static GstRateProvider()
        {
            SetupGstRateForCategories();
        }

        internal static int GetRateFor(string categoryName) 
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

        private static void SetupGstRateForCategories()
        {
            CategoryGstRatesInPercentage.Add("Food-grains", 0);
            CategoryGstRatesInPercentage.Add("Furniture", 5);
            CategoryGstRatesInPercentage.Add("Electronics", 18);
            CategoryGstRatesInPercentage.Add("Cosmetics", 28);
        }
    }
    internal class Item
    {
        public decimal InitialPrice { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
    }

    internal class ItemScanner
    {
        internal static Item ScanItem()
        {
            var item = new Item();

            Console.Write("Enter name of the item: ");
            item.Name = Console.ReadLine();

            Console.Write("Enter quantity of the item: ");
            item.Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter initial price of the item: ");
            item.InitialPrice = int.Parse(Console.ReadLine());

            return item;
        }
    }

    internal class ItemsCategoryMapping
    {
        private static Dictionary<string, string> Mapping = new Dictionary<string, string>();

        static ItemsCategoryMapping()
        {
            SetupItemsCategoryMapping();
        }

        internal static string GetCategoryFor(string itemName)
        {
            string categoryName = "";

            foreach (var item in Mapping)
            {
                if (item.Key == itemName)
                {
                    categoryName = item.Value;
                    break;
                }
            }

            return categoryName;
        }

        private static void SetupItemsCategoryMapping()
        {
            SetupItemsForFoodGrains();
            SetupItemsForFurniture();
            SetupItemsForElectronics();
            SetupItemsForCosmetics();
        }

        private static void SetupItemsForCosmetics()
        {
            Mapping.Add("Shampoo", "Cosmetics");
            Mapping.Add("Perfume", "Cosmetics");
        }

        private static void SetupItemsForElectronics()
        {
            Mapping.Add("TV", "Electronics");
            Mapping.Add("Mobile", "Electronics");
        }

        private static void SetupItemsForFoodGrains()
        {
            Mapping.Add("Rice", "Food-grains");
            Mapping.Add("Wheat", "Food-grains");
        }

        private static void SetupItemsForFurniture()
        {
            Mapping.Add("Sofa", "Furniture");
            Mapping.Add("Chairs", "Furniture");
        }
    }
    internal class NMartStore
    {
        private static void Main()
        {
            Console.WriteLine("Welcome to NMart store");
            Console.WriteLine("***************************");

            var scannedItem = ItemScanner.ScanItem();

            var billingDetails = Billing.GetBillingDetails(scannedItem);

            Printer.Print(billingDetails);
        }
    }

    internal class Printer
    {
        internal static void Print(BillingDetails billingDetails)
        {
            string output = "*******************************************\n" +
                "Billing Details for '" + billingDetails.Item.Name + "':\n" +
                "*******************************************\n" +
                "Quantity: " + billingDetails.Item.Quantity +
                "\nPrice per unit: " + billingDetails.Item.InitialPrice +
                "\nFinal rate: " + billingDetails.FinalPrice;
            Console.WriteLine(output);

            Console.WriteLine("\n*********************************\n");
        }
    }
}