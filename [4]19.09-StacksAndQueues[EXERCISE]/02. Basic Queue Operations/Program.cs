using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            var instructions = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var numbers = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int n = instructions[0]; //enqueue
            int s = instructions[1]; //dequeue
            int x = instructions[2]; //look for

            var queue = new Queue<int>();

            for (int i = 0; i < n; i++)
            {
                queue.Enqueue(numbers[i]);
            }

            for (int i = 0; i < s; i++)
            {
                if (queue.Count != 0)
                {
                    queue.Dequeue();
                }
            }

            int smallest = int.MaxValue;
            bool isTrue = false;
            foreach (var element in queue)
            {
                if (element <= smallest)
                {
                    smallest = element;
                }
                if (element == x)
                {
                    isTrue = true;
                    Console.WriteLine("true");
                    break;
                }
            }

            if (!isTrue)
            {
                if (queue.Count == 0)
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
