using System;

namespace object_orientation
{
    internal class Printer
    {
        internal static void Print(BillingDetails billingDetails)
        {
            var output = "*******************************************\n" +
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