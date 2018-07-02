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