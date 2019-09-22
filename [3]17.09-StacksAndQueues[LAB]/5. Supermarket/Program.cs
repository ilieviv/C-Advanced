using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new Queue<string>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "End")
                {
                    break;
                }
                else if (input == "Paid")
                {
                    foreach (var name in names)
                    {
                        Console.WriteLine(name);
                    }
                    names.Clear();
                }
                else
                {
                    names.Enqueue(input);
                }
            }

            Console.WriteLine($"{names.Count()} people remaining.");
        }
    }
}
