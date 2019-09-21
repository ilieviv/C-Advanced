using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse);
            var numbers = new Stack<int>(input);
            string command = Console.ReadLine();

            while (command != "end")
            {
                var thisCommand = command
                    .Split()
                    .ToList();

                if (thisCommand[0] == "add")
                {
                    numbers.Push(int.Parse(thisCommand[1]));
                    numbers.Push(int.Parse(thisCommand[2]));
                }
                else if (thisCommand[0] == "remove" && numbers.Count > int.Parse(thisCommand[1]))
                {
                    int iterations = int.Parse(thisCommand[1]);

                    for (int i = 0; i < iterations; i++)
                    {
                        numbers.Pop();
                    }
                }
                command = Console.ReadLine();
            }

            int result = 0;

            foreach (var num in numbers)
            {
                result += num;
            }

            Console.WriteLine($"Sum: {result}");
        }
    }
}
