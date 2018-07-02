using System.Collections.Generic;

namespace object_orientation
{
    internal class GstRateProvider
    {
        private static readonly Dictionary<string, int> CategoryGstRatesMapping = new Dictionary<string, int>();

        static GstRateProvider() => SetupGstRateForCategories();

        internal static int GetRateFor(string categoryName)
        {
            var gstPercentageForItem = 0;

            foreach (var categoryGstRate in CategoryGstRatesMapping)
            {
                if (categoryGstRate.Key == categoryName)
                {
                    gstPercentageForItem = categoryGstRate.Value;
                    break;
                }
            }

            return gstPercentageForItem;
        }

        private static void SetupGstRateForCategories()
        {
            CategoryGstRatesMapping.Add(Category.FoodGrains, 0);
            CategoryGstRatesMapping.Add(Category.Furniture, 5);
            CategoryGstRatesMapping.Add(Category.Electronics, 18);
            CategoryGstRatesMapping.Add(Category.Cosmetics, 28);
        }
    }
}