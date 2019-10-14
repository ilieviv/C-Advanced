using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Find_Evens_or_Odds
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> isEvenPredicate = num => num % 2 == 0;
            Action<List<int>> Print = x => Console.Write(string.Join(" ", x));

            var range = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            List<int> numbers = new List<int>();

            int first = range[0];
            int last = range[1];


            for (int i = first; i < last + 1; i++)
            {
                numbers.Add(i);
            }

            var oddOrEven = Console.ReadLine();

            List<int> result = new List<int>();

            if (oddOrEven == "even")
            {
                result = numbers.FindAll(x => isEvenPredicate(x));
            }
            else
            {
                result = numbers.FindAll(x => !isEvenPredicate(x));
            }

            Print(result);
        }
    }
}
