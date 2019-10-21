using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Speed_Racing
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfCars = int.Parse(Console.ReadLine());
            Car[] cars = new Car[numberOfCars];

            for (int i = 0; i < numberOfCars; i++)
            {
                var currentCar = Console.ReadLine().Split();

                string model = currentCar[0];
                double fuelAmount = double.Parse(currentCar[1]);
                double fuelCost = double.Parse(currentCar[2]);

                cars[i] = new Car(model, fuelAmount, fuelCost);
            }

            var input = Console.ReadLine();

            while (true)
            {
                if (input == "End")
                {
                    break;
                }

                var splittedInput = input.Split();

                string model = splittedInput[1];
                double distance = double.Parse(splittedInput[2]);

                cars.Where(c => c.model == model).ToList().ForEach(c => c.Drive(distance));

                input = Console.ReadLine();
            }

            foreach (Car car in cars)
            {
                Console.WriteLine("{0} {1:F2} {2}", car.model, car.fuelAmount, car.traveledDistance);
            }
        }
    }
}
