using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _03._Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var stack = new Stack<int>();

            for (int i = 0; i < n; i++)
            {
                var operation = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                if (operation[0] == 1)
                {
                    int numb = operation[1];
                    stack.Push(numb);
                }
                else if (operation[0] == 2)
                {
                    if (stack.Count != 0)
                    {
                        stack.Pop();
                    }
                }
                else if (operation[0] == 3)
                {
                    if (stack.Count != 0)
                    {
                        Console.WriteLine(stack.Max());
                    }
                }
                else if (operation[0] == 4)
                {
                    if (stack.Count != 0)
                    {
                        Console.WriteLine(stack.Min());
                    }
                }
            }

            if (stack.Count != 0)
            {
                var output = new StringBuilder();

                foreach (var element in stack)
                {
                    output.Append(element + ", ");
                }
                int length = output.Length;
                output = output.Remove(length - 2, 1);
                Console.WriteLine(output);
            }
        }
    }
}
