using System;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
    }

    public class StartUp
    {
        static void Main(string[] args)
        {
            var car = new Car();
            car.Model = "F40";
            car.Make = "Ferrari";
            car.Year = 2015;


        }
    }
}
