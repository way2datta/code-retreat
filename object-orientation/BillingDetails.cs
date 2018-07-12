﻿namespace Object.Orientation
{
    internal class BillingDetails
    {
        public BillingDetails(Item scannedItem)
        {
            Item = scannedItem;
        }

        public decimal ItemsFinalPrice { get; set; }
        public Item Item { get; set; }
    }
}