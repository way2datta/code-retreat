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
}