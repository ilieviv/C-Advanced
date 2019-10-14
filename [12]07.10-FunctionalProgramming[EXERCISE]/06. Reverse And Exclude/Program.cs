using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Reverse_And_Exclude
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<List<int>> Print = x => Console.WriteLine(string.Join(" ", x));

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();

            int divider = int.Parse(Console.ReadLine());
            Predicate<int> divideByNumber = x => x % divider == 0;

            numbers.RemoveAll(divideByNumber);
            numbers.Reverse();
            Print(numbers);
        }
    }
}
