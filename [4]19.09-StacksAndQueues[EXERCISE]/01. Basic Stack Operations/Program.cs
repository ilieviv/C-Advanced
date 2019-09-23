using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _01._Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

            var stack = new Stack<int>();

            int n = numbers[0];
            int s = numbers[1];
            int x = numbers[2];

            for (int i = 0; i < n; i++)
            {
                stack.Push(input[i]);
            }

            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }

            bool isTrue = false;
            int smallest = int.MaxValue;
            foreach (var element in stack)
            {
                if (element < smallest)
                {
                    smallest = element;
                }

                if (element == x)
                {
                    isTrue = true;
                    break;
                }
            }

            if (isTrue)
            {
                Console.WriteLine("true");
            }
            else
            {
                if (stack.Count == 0)
                {
                    Console.WriteLine(0);
                }
                else
                {
                    Console.WriteLine(smallest);
                }
            }
        }
    }
}
