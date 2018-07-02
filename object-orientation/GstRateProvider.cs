using System.Collections.Generic;

namespace object_orientation
{
    internal class GstRateProvider
    {
        private static readonly Dictionary<string, int> CategoryGstRatesInPercentage = new Dictionary<string, int>();

        static GstRateProvider() => SetupGstRateForCategories();

        internal static int GetRateFor(string categoryName)
        {
            var gstPercentageForItem = 0;

            foreach (var categoryGstRate in CategoryGstRatesInPercentage)
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
            CategoryGstRatesInPercentage.Add("Food-grains", 0);
            CategoryGstRatesInPercentage.Add("Furniture", 5);
            CategoryGstRatesInPercentage.Add("Electronics", 18);
            CategoryGstRatesInPercentage.Add("Cosmetics", 28);
        }
    }
}