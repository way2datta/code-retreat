using System;

namespace object_orientation
{
    internal class Billing
    {
        internal static BillingDetails GetBillingDetails(Item scannedItem)
        {
            BillingDetails billingDetails = new BillingDetails(scannedItem);

            return billingDetails;
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
                "Billing Details for " + billingDetails.Item.Name + ":\n" +
                "*******************************************\n" +
                "Quantity: " + billingDetails.Item.Quantity +
                "\nPrice per unit: " + billingDetails.Item.InitialPrice +
                "\nFinal rate: " + billingDetails.FinalPrice;
            Console.WriteLine(output);

            Console.WriteLine("\n*********************************\n");
        }
    }
}