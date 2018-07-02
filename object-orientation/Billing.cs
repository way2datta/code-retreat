namespace object_orientation
{
    internal class Billing
    {
        internal static BillingDetails GetBillingDetails(Item scannedItem)
        {
            var itemFinalPrice = CalculateFinalPrice(scannedItem);

            var billingDetails = new BillingDetails(scannedItem)
            {
                ItemsFinalPrice = itemFinalPrice
            };

            return billingDetails;
        }

        private static decimal CalculateFinalPrice(Item item)
        {
            var categoryName = ItemsInCategory.GetCategoryFor(item.Name);

            var gstRateApplicableToUnitItem = GstRateProvider.GetRateFor(categoryName);

            var gstRatePerItem = item.InitialPrice * gstRateApplicableToUnitItem / 100;

            var finalPrice = item.Quantity * (item.InitialPrice + gstRatePerItem);

            return finalPrice;
        }
    }
}