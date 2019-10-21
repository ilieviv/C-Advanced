﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _12._Cups_and_Bottles
{
    class Program
    {
        static void Main(string[] args)
        {
            var cups = new Queue<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            var bottles = new Stack<int>(Console.ReadLine()
                .Split()
                .Select(int.Parse));

            int wastedWater = 0;

            int cup = cups.Peek();

            while (cups.Count > 0 && bottles.Count > 0)
            {
                int bottle = bottles.Pop();

                if (bottle >= cup)
                {
                    bottle -= cup;
                    wastedWater += bottle;

                    cup = cups.Dequeue();

                    if (cups.Count > 0)
                    {
                        cup = cups.Peek();
                    }
                }
                else
                {
                    cup -= bottle;
                }
            }

            if (bottles.Count > 0)
            {
                Console.WriteLine($"Bottles: {string.Join(" ", bottles)}");
            }
            else
            {
                Console.WriteLine($"Cups: {string.Join(" ", cups)}");
            }

            Console.WriteLine($"Wasted litters of water: {wastedWater}");
        }
    }
}
