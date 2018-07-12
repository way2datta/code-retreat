namespace Object.Orientation
{
    internal class FinalBillReportFormatter
    {
        internal static string Format(BillingDetails billingDetails)
        {
            return "*******************************************\n" +
              "Billing Details for '" + billingDetails.Item.Name + "':\n" +
              "*******************************************\n" +
              "Quantity: " + billingDetails.Item.Quantity +
              "\nPrice per unit: " + billingDetails.Item.InitialPrice +
              "\nFinal rate: " + billingDetails.ItemsFinalPrice +
            "\n*********************************\n";
        }
    }
}