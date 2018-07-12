using System.Collections.Generic;
using System.Linq;

namespace Object.Orientation
{
    internal class GstRateProvider
    {
        private static readonly Dictionary<string, int> CategoryGstRatesMapping = new Dictionary<string, int>();

        static GstRateProvider() => SetupGstRateForCategories();

        internal static int GetRateFor(string categoryName)
        {
            return CategoryGstRatesMapping.First(x => x.Key == categoryName).Value;
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