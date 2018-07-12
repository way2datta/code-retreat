namespace Object.Orientation
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
            var itemFinalPriceWithoutGst = item.Quantity * item.InitialPrice;
            var itemFinalPriceIncludingGst = itemFinalPriceWithoutGst + itemFinalPriceWithoutGst * gstRateApplicableToUnitItem / 100;
            return itemFinalPriceIncludingGst;
        }
    }
}