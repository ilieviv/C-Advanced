using System;
using System.Linq;

namespace _12._TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> isEqualOrLargerFunc = (word, criteria) => word.Sum(x => x) >= criteria;

            int targetSum = int.Parse(Console.ReadLine());
            var inputNames = Console.ReadLine().Split().ToArray();

            Func<string[], Func<string, int, bool>, int, string> myFunc = (names, isLargerFunc, totalSum) =>
                   names.FirstOrDefault(x => isLargerFunc(x, totalSum));

            string targetName = myFunc(inputNames, isEqualOrLargerFunc, targetSum);

            Console.WriteLine(targetName);
        }
    }
}
