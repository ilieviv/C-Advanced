using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            var orders = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var queue = new Queue<int>(orders);
            int maxValue = queue.Max();

            while (foodQuantity > 0 && queue.Count != 0)
            {

                if (foodQuantity - queue.Peek() >= 0)
                {
                    foodQuantity -= queue.Peek();
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine(maxValue);
            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.Write("Orders left: ");
                foreach (var el in queue)
                {
                    Console.Write(el + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
