using System.Collections.Generic;

namespace object_orientation
{
    internal class ItemsCategoryMapping
    {
        private static Dictionary<string, string> Mapping = new Dictionary<string, string>();

        static ItemsCategoryMapping()
        {
            SetupItemsCategoryMapping();
        }

        internal static string GetCategoryFor(string itemName)
        {
            var categoryName = "";

            foreach (var item in Mapping)
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
            Mapping.Add("Shampoo", "Cosmetics");
            Mapping.Add("Perfume", "Cosmetics");
        }

        private static void SetupItemsForElectronics()
        {
            Mapping.Add("TV", "Electronics");
            Mapping.Add("Mobile", "Electronics");
        }

        private static void SetupItemsForFoodGrains()
        {
            Mapping.Add("Rice", "Food-grains");
            Mapping.Add("Wheat", "Food-grains");
        }

        private static void SetupItemsForFurniture()
        {
            Mapping.Add("Sofa", "Furniture");
            Mapping.Add("Chairs", "Furniture");
        }
    }
}