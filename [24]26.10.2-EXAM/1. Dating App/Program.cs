using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _1._Dating_App
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack<int> males = new Stack<int>(Console.ReadLine().Split().Select(int.Parse));
            Queue<int> females = new Queue<int>(Console.ReadLine().Split().Select(int.Parse).ToArray());

            int matches = 0;

            while (males.Count > 0 && females.Count > 0)
            {
                if (females.Peek() <= 0)
                {
                    females.Dequeue();
                    continue;
                }

                if (males.Peek() <= 0)
                {
                    males.Pop();
                    continue;
                }

                int currentFemale = females.Peek();
                int currentMale = males.Peek();

                if (currentFemale % 25 == 0)
                {
                    females.Dequeue();

                    if (females.Count == 0)
                    {
                        break;
                    }
                    females.Dequeue();
                    continue;
                }

                if (currentMale % 25 == 0)
                {
                    males.Pop();

                    if (males.Count == 0)
                    {
                        break;
                    }
                    males.Pop();
                    continue;
                }

                if (currentFemale == currentMale)
                {
                    males.Pop();
                    females.Dequeue();
                    matches++;
                }
                else
                {
                    females.Dequeue();
                    males.Pop();
                    males.Push(currentMale - 2);
                }
            }

            Console.WriteLine($"Matches: {matches}");

            if (males.Count <= 0)
            {
                Console.WriteLine("Males left: none");
            }
            else
            {
                Console.WriteLine($"Males left: {string.Join(", ", males)}");
            }

            if (females.Count <= 0)
            {
                Console.WriteLine("Females left: none");
            }
            else
            {
                Console.WriteLine($"Females left: {string.Join(", ", females)}");
            }
        }
    }
}
