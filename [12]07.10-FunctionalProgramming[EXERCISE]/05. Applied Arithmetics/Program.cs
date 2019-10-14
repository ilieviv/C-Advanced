using System;
using System.Linq;

namespace _05._Applied_Arithmetics
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int> addFunc = x => x += 1;
            Func<int, int> multuplyFunc = x => x *= 2;
            Func<int, int> subtractFunc = x => x -= 1;
            Action<int[]> printNumbers = x => Console.WriteLine(string.Join(" ", x));
            var numbers = Console.ReadLine()
                            .Split()
                            .Select(int.Parse)
                            .ToArray();

            var command = Console.ReadLine();

            while (true)
            {
                if (command == "end")
                {
                    break;
                }

                if (command == "add")
                {
                    numbers = numbers.Select(addFunc).ToArray();
                }
                else if (command == "multiply")
                {
                    numbers = numbers.Select(multuplyFunc).ToArray();
                }
                else if (command == "subtract")
                {
                    numbers = numbers.Select(subtractFunc).ToArray();
                }
                else if (command == "print")
                {
                    printNumbers(numbers);
                }

                command = Console.ReadLine();
            }
        }
    }
}
