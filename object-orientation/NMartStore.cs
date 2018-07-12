using System;

namespace Object.Orientation
{
    internal class NMartStore
    {
        private static void Main()
        {
            var scannedItem = ItemScanner.ScanItem();
            var billingDetails = Billing.GetBillingDetails(scannedItem);
            var formattedContent = FinalBillReport.Format(billingDetails);
            Printer.Print(formattedContent);
        }
    }
}