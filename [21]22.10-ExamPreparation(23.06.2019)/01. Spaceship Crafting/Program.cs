using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Spaceship_Crafting
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> liquids = new Queue<int>(Console.ReadLine().Split().Select(int.Parse)); //chemical liquids
            Stack<int> materials = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));  //physical items

            var list = new Dictionary<string, int>();
            list.Add("Glass", 0);
            list.Add("Aluminium", 0);
            list.Add("Lithium", 0);
            list.Add("Carbon fiber", 0);

            int glassRequired = 25;
            int aluminiumRequired = 50;
            int lithiumRequired = 75;
            int carbonRequired = 100;

            while (liquids.Count > 0 && materials.Count > 0)
            {
                var currentLiquid = liquids.Dequeue();
                var currentItem = materials.Peek();

                int mix = currentLiquid + currentItem;

                if (mix == glassRequired)
                {
                    list["Glass"]++;
                    materials.Pop();
                }
                else if (mix == aluminiumRequired)
                {
                    list["Aluminium"]++;
                    materials.Pop();
                }
                else if (mix == lithiumRequired)
                {
                    list["Lithium"]++;
                    materials.Pop();
                }
                else if (mix == carbonRequired)
                {
                    list["Carbon fiber"]++;
                    materials.Pop();
                }
                else
                {
                    var temp = materials.Pop();
                    materials.Push(temp + 3);
                }
            }

            if (!list.ContainsValue(0))
            {
                Console.WriteLine("Wohoo! You succeeded in building the spaceship!");
            }
            else
            {
                Console.WriteLine("Ugh, what a pity! You didn't have enough materials to build the spaceship.");
            }

            if (liquids.Count > 0)
            {
                Console.WriteLine($"Liquids left: {string.Join(", ", liquids)}");
            }
            else
            {
                Console.WriteLine("Liquids left: none");
            }

            if (materials.Count > 0)
            {
                Console.WriteLine($"Physical items left: {string.Join(", ", materials)}");
            }
            else
            {
                Console.WriteLine("Physical items left: none");
            }

            foreach (var material in list.OrderBy(m => m.Key))
            {
                Console.WriteLine($"{material.Key}: {material.Value}");
            }
        }
    }
}
