using System;
using System.Collections.Generic;
using System.Text;

namespace _06._Speed_Racing
{
    public class Car
    {
        public string model;
        public double fuelAmount;
        public double fuelConsumptionPerKilometer;
        public double traveledDistance;

        public Car(string model, double fuelAmount, double fuelConsumptionPerKilometer)
        {
            this.Model = model;
            this.FuelAmount = fuelAmount;
            this.FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
            this.TraveledDistance = 0;
        }

        public string Model
        {
            get { return model; }
            set { model = value; }
        }

        public double FuelAmount
        {
            get { return fuelAmount; }
            set { fuelAmount = value; }
        }

        public double FuelConsumptionPerKilometer
        {
            get { return fuelConsumptionPerKilometer; }
            set { fuelConsumptionPerKilometer = value; }
        }

        public double TraveledDistance
        {
            get { return traveledDistance; }
            set { traveledDistance = value; }
        }

        public void Drive(double distance)
        {
            if (this.fuelAmount < distance * fuelConsumptionPerKilometer)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                this.fuelAmount -= distance * this.fuelConsumptionPerKilometer;
                this.traveledDistance += distance;
            }
        }
    }
}
