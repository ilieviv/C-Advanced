using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Cargo
    {
        public int cargoWeight;
        public string cargoType;

        public Cargo(int cargoWeight, string cargoType)
        {
            CargoWeight = cargoWeight;
            CargoType = cargoType;
        }

        public int CargoWeight
        {
            get
            {
                return this.cargoWeight;
            }
            set
            {
                this.cargoWeight = value;
            }
        }

        public string CargoType
        {
            get
            {
                return this.cargoType;
            }
            set
            {
                this.cargoType = value;
            }
        }
    }
}
