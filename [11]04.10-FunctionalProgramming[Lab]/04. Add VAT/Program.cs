using System;
using System.Linq;

namespace _04._Add_VAT
{
    class Program
    {

        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(", ")
                .Select(x=> double.Parse(x)*1.2);

            foreach (var price in input)
            {
                Console.WriteLine($"{price:f2}");
            }
        }
    }
}
