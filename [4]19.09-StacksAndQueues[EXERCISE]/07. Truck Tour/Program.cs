using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());
            Queue<int[]> pumps = new Queue<int[]>();

            for (int i = 0; i < petrolPumps; i++)
            {
                pumps.Enqueue(Console.ReadLine()
                     .Split()
                     .Select(int.Parse)
                     .ToArray());
            }

            var startIndex = 0;
            var truckFuel = 0;
            var loopBottom = pumps.Count;

            for (int i = 0; i <= loopBottom && startIndex < pumps.Count; i++)
            {
                var currentPump = pumps.Dequeue();
                pumps.Enqueue(currentPump);
                truckFuel += currentPump[0] - currentPump[1];

                if (truckFuel < 0)
                {
                    startIndex = i + 1;
                    loopBottom += pumps.Count;
                    truckFuel = 0;
                }
            }

            Console.WriteLine(startIndex);
        }
    }
}
