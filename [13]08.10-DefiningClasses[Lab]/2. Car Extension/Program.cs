using System;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Make = "audi";
            car.Model = "A3";
            car.Year = 2015;
            car.FuelConsumption = 10;
            car.FuelQuantity = 100;
            car.Drive(1000);
            car.Drive(100);
          

            Console.WriteLine(car.WhoAmI()); ;
        }
    }
}
