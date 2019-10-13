using System;
using System.Linq;

namespace _03._Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int[], int> MinValue = x =>
            {
                int minValue = int.MaxValue;

                foreach (var currNumber in x)
                {
                    if (currNumber < minValue)
                    {
                        minValue = currNumber;
                    }
                }
                return minValue;
            };

            var input = Console.ReadLine()
               .Split()
               .Select(int.Parse)
              .ToArray();

            int result = MinValue(input);

            Console.WriteLine(result);
        }
    }
}
