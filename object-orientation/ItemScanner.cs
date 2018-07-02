using System;

namespace object_orientation
{
    internal class ItemScanner
    {
        internal static Item ScanItem()
        {
            var item = new Item();

            Console.Write("Enter name of the item: ");
            item.Name = Console.ReadLine();

            Console.Write("Enter quantity of the item: ");
            item.Quantity = int.Parse(Console.ReadLine());

            Console.Write("Enter initial price of the item: ");
            item.InitialPrice = int.Parse(Console.ReadLine());

            return item;
        }
    }
}