﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _05._Fashion_Boutique
{
    class Program
    {
        static void Main(string[] args)
        {
            var clothes = Console.ReadLine()
                        .Split()
                        .Select(int.Parse)
                        .ToArray();

            int capacity = int.Parse(Console.ReadLine());

            var stack = new Stack<int>(clothes);

            int racks = 1;

            int sum = 0;

            while (stack.Count > 0)
            {
                sum += stack.Peek();

                if (sum <= capacity)
                {
                    stack.Pop();
                }
                else
                {
                    racks++;
                    sum = 0;
                }
            }

            Console.WriteLine(racks);
        }
    }
}
