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
            CategoryGstRatesMapping.Add("Food-grains", 0);
            CategoryGstRatesMapping.Add("Furniture", 5);
            CategoryGstRatesMapping.Add("Electronics", 18);
            CategoryGstRatesMapping.Add("Cosmetics", 28);
        }
    }
}