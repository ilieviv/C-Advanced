using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                string model = input[0];
                int engineSpeed = int.Parse(input[1]);
                int enginePower = int.Parse(input[2]);

                int cargoWeight = int.Parse(input[3]);
                string cargoType = input[4];

                Tire[] tires = new Tire[4];
                int counter = 0;

                for (int tireIndex = 5; tireIndex < input.Length; tireIndex += 2)
                {
                    double currentPressure = double.Parse(input[tireIndex]);
                    int currentAge = int.Parse(input[tireIndex + 1]);

                    Tire tire = new Tire(currentPressure, currentAge);
                    tires[counter++] = tire;
                }
                Engine engine = new Engine(engineSpeed, enginePower);
                Cargo cargo = new Cargo(cargoWeight, cargoType);
                Car car = new Car(model, engine, cargo, tires);

                cars.Add(car);
            }

            var command = Console.ReadLine();

            if (command == "flamable")
            {
                cars
                    .Where(x => x.Engine.EnginePower > 250 && x.Cargo.CargoType == "flamable")
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.Model));
            }
            else if (command == "fragile")
            {
                cars.Where(x => x.Tires.Any(p => p.TirePressure < 1) && x.Cargo.CargoType == "fragile")
                    .ToList()
                    .ForEach(x => Console.WriteLine(x.Model));
            }
        }
    }
}
