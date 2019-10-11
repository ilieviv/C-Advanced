using System;
using System.Collections.Generic;

namespace _05._Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var occurencies = new SortedDictionary<char, int>();

            foreach (var ch in input)
            {

                if (!occurencies.ContainsKey(ch))
                {
                    occurencies.Add(ch, 0);
                }
                    occurencies[ch]++; ;
            }

            foreach (var ch in occurencies)
            {
                Console.WriteLine($"{ch.Key}: {ch.Value} time/s");
            }
        }
    }
}
