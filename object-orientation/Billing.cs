namespace object_orientation
{
    internal class Billing
    {
        internal static BillingDetails GetBillingDetails(Item scannedItem)
        {
            var itemFinalPrice = CalculateFinalPrice(scannedItem);

            var billingDetails = new BillingDetails(scannedItem)
            {
                FinalPrice = itemFinalPrice
            };

            return billingDetails;
        }

        private static decimal CalculateFinalPrice(Item item)
        {
            var category = ItemsCategoryMapping.GetCategoryFor(item.Name);

            var gstRateForItem = GstRateProvider.GetRateFor(category);

            var gstRatePerItem = item.InitialPrice * gstRateForItem / 100;

            var finalPrice = item.Quantity * (item.InitialPrice + gstRatePerItem);

            return finalPrice;
        }
    }
}