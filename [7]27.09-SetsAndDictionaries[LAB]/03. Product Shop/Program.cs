using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Product_Shop
{
    class Program
    {
        static void Main(string[] args)
        {

            var foodShops = new SortedDictionary<string, Dictionary<string, double>>();

            while (true)
            {
                var input = Console.ReadLine().Split(", ").ToArray();
                if (input[0] == "Revision")
                {
                    break;
                }

                string shop = input[0];
                string product = input[1];
                double price = double.Parse(input[2]);

                if (!foodShops.ContainsKey(shop))
                {
                    foodShops.Add(shop, new Dictionary<string, double>());
                    foodShops[shop].Add(product, price);
                }
                else
                {
                    foodShops[shop].Add(product, price);
                }
            }

            foreach (var shop in foodShops)
            {
                Console.WriteLine($"{shop.Key}->");

                foreach (var product in shop.Value)
                {
                    Console.WriteLine($"Product: {product.Key}, Price: {product.Value}");
                }
            }
        }
    }
}
