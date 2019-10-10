using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Parking_Lot
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var parking = new HashSet<string>();

            while (input != "END")
            {
                var splittedInput = input.Split(", ").ToArray();

                string action = splittedInput[0];
                string plate = splittedInput[1];

                if (action == "IN")
                {
                    parking.Add(plate);
                }
                else if (action == "OUT")
                {
                    parking.Remove(plate);
                }

                input = Console.ReadLine();
            }

            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            else
            {
                foreach (var car in parking)
                {
                    Console.WriteLine(car);
                }
            }
        }
    }
}
