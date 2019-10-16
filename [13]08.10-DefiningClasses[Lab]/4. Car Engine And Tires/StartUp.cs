using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new Tire[4]
            {
                new Tire(1, 2.5),
                new Tire(2, 0.5),
                new Tire(2, 2.3),
                new Tire(1, 2.1),
        };

            var engine = new Engine(200, 3000);
            var car = new Car("Mercedes", "E200", 1990, 70, 10, engine, tires);
        }
    }
}

