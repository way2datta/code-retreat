using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment
{
    internal class Program
    {
        private static Dictionary<string, int> CGR = new Dictionary<string, int>();
        private static Dictionary<string, string> iCat = new Dictionary<string, string>();

        private static void Main(string[] args)
        {
            CGR.Add("Food-grains", 0);
            CGR.Add("Furniture", 5);
            CGR.Add("Electronics", 18);
            CGR.Add("Cosmetics", 28);

            iCat.Add("Rice", "Food-grains");
            iCat.Add("Wheat", "Food-grains");
            iCat.Add("Sofa", "Furniture");
            iCat.Add("Chairs", "Furniture");
            iCat.Add("TV", "Electronics");
            iCat.Add("Mobile", "Electronics");
            iCat.Add("Shampoo", "Cosmetics");
            iCat.Add("Perfume", "Cosmetics");

            Console.WriteLine("Welcome to NMart store");
            Console.WriteLine("***************************");

            Console.Write("Enter name of item: ");
            string iName = Console.ReadLine();
            Console.Write("Enter quantity of item: ");
            int iQnt = int.Parse(Console.ReadLine());
            Console.Write("Enter rate per product item: ");
            int iRate = int.Parse(Console.ReadLine());

            string cName = "";

            foreach (var cat in iCat)
            {
                if (cat.Key == iName)
                {
                    cName = cat.Value;
                    break;
                }
            }

            int cPercentage = 0;

            foreach (var c in CGR)
            {
                if (c.Key == cName)
                {
                    cPercentage = c.Value;
                    break;
                }
            }

            double fPrice = iQnt * (iRate + iRate * cPercentage / 100.0);

            string output = "*******************************************\n" +
                "Billing Details for " + iName + ":\n" +
                "*******************************************\n" +
                "Quantity: " + iQnt +
                "\nPrice per unit: " + iRate +
                "\nFinal rate: " + fPrice;
            Console.WriteLine(output);

            Console.WriteLine("\n*********************************\n");
        }
    }
}
