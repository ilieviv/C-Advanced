using System;
using System.Linq;

namespace _07._Truck_Tour
{
    class Program
    {
        static void Main(string[] args)
        {
            int petrolPumps = int.Parse(Console.ReadLine());

            for (int i = 0; i < petrolPumps; i++)
            {
                var input = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                int petrolAmount = input[0];
                int distance = input[1];
                

            }
        }
    }
}
