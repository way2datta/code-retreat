namespace object_orientation
{
    internal class BillingDetails
    {
        public BillingDetails(Item scannedItem)
        {
            this.Item = scannedItem;
        }

        public decimal FinalPrice { get; set; }
        public Item Item { get; set; }
    }
}