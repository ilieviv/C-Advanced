using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Wardrobe
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var wardrobe = new Dictionary<string, Dictionary<string, int>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split(new string[] { " -> ", "," }, StringSplitOptions.RemoveEmptyEntries).ToArray();

                string color = input[0];

                if (!wardrobe.ContainsKey(color))
                {
                    wardrobe[color] = new Dictionary<string, int>();
                }

                for (int clothes = 1; clothes < input.Length; clothes++)
                {
                    string currentItem = input[clothes];

                    if (!wardrobe[color].ContainsKey(currentItem))
                    {
                        wardrobe[color].Add(currentItem, 0);

                    }
                    wardrobe[color][currentItem]++;
                }
            }

            var desiredDress = Console.ReadLine().Split().ToArray();

            var desiredColor = desiredDress[0];
            var desiredItem = desiredDress[1];


            foreach (var color in wardrobe)
            {
                Console.WriteLine($"{color.Key} clothes:");

                foreach (var dress in color.Value)
                {
                    Console.Write($"* {dress.Key} - {dress.Value}");
                    if (desiredColor == color.Key && desiredItem == dress.Key)
                    {
                        Console.Write(" (found!)");
                    }
                    Console.WriteLine();
                }
            }

        }
    }
}
