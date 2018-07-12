using System.Collections.Generic;
using System.Linq;

namespace Object.Orientation
{
    internal class ItemsInCategory
    {
        private static readonly Dictionary<string, string> ItemsCategoryMapping = new Dictionary<string, string>();

        static ItemsInCategory()
        {
            SetupItemsCategoryMapping();
        }

        internal static string GetCategoryFor(string itemName)
        {
            return ItemsCategoryMapping.First(x => x.Key == itemName).Value;
        }

        private static void SetupItemsCategoryMapping()
        {
            SetupItemsForFoodGrains();
            SetupItemsForFurniture();
            SetupItemsForElectronics();
            SetupItemsForCosmetics();
        }

        private static void SetupItemsForCosmetics()
        {
            ItemsCategoryMapping.Add("Shampoo", Category.Cosmetics);
            ItemsCategoryMapping.Add("Perfume", Category.Cosmetics);
        }

        private static void SetupItemsForElectronics()
        {
            ItemsCategoryMapping.Add("TV", Category.Electronics);
            ItemsCategoryMapping.Add("Mobile", Category.Electronics);
        }

        private static void SetupItemsForFoodGrains()
        {
            ItemsCategoryMapping.Add("Rice", Category.FoodGrains);
            ItemsCategoryMapping.Add("Wheat", Category.FoodGrains);
        }

        private static void SetupItemsForFurniture()
        {
            ItemsCategoryMapping.Add("Sofa", Category.Furniture);
            ItemsCategoryMapping.Add("Chairs", Category.Furniture);
        }
    }
}