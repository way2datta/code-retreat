namespace object_orientation
{
    internal class BillingDetails
    {
        public BillingDetails(Item scannedItem) => Item = scannedItem;

        public decimal FinalPrice { get; private set; }
        public Item Item { get; private set; }
    }
}