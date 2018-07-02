using System.Collections.Generic;

namespace object_orientation
{
    internal class ItemsInCategory
    {
        private static Dictionary<string, string> ItemsCategoryMapping = new Dictionary<string, string>();

        static ItemsInCategory()
        {
            SetupItemsCategoryMapping();
        }

        internal static string GetCategoryFor(string itemName)
        {
            var categoryName = "";

            foreach (var item in ItemsCategoryMapping)
            {
                if (item.Key == itemName)
                {
                    categoryName = item.Value;
                    break;
                }
            }

            return categoryName;
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
            ItemsCategoryMapping.Add("Shampoo", "Cosmetics");
            ItemsCategoryMapping.Add("Perfume", "Cosmetics");
        }

        private static void SetupItemsForElectronics()
        {
            ItemsCategoryMapping.Add("TV", "Electronics");
            ItemsCategoryMapping.Add("Mobile", "Electronics");
        }

        private static void SetupItemsForFoodGrains()
        {
            ItemsCategoryMapping.Add("Rice", "Food-grains");
            ItemsCategoryMapping.Add("Wheat", "Food-grains");
        }

        private static void SetupItemsForFurniture()
        {
            ItemsCategoryMapping.Add("Sofa", "Furniture");
            ItemsCategoryMapping.Add("Chairs", "Furniture");
        }
    }
}