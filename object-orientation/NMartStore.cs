using System;

namespace object_orientation
{
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
}