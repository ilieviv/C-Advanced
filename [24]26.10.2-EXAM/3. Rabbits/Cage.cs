using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Rabbits
{
    public class Cage
    {
        private HashSet<Rabbit> rabbits;

        public Cage(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            this.rabbits = new HashSet<Rabbit>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }

        public void Add(Rabbit rabbits)
        {
            if (this.rabbits.Count < this.Capacity)
            {
                this.rabbits.Add(rabbits);
            }
        }

        public bool RemoveRabbit(string name)
        {
            foreach (var rabit in this.rabbits)
            {
                if (rabit.Name == name)
                {
                    this.rabbits.Remove(rabit);
                    return true;
                }
            }
            return false;
        }

        public void RemoveSpecies(string species)
        {
            foreach (var rabit in this.rabbits)
            {
                if (rabit.Species == species)
                {
                    this.rabbits.Remove(rabit);
                }
            }
        }

        public Rabbit SellRabbit(string name)
        {
            this.rabbits.FirstOrDefault(x => x.Name == name).Available = false;
            return this.rabbits.FirstOrDefault(x => x.Name == name);
        }

        public Rabbit[] SellRabbitsBySpecies(string species)
        {
            int soldCounter = 0;
            foreach (var rabbit in this.rabbits)
            {
                if (rabbit.Species == species && rabbit.Available == true) // add  
                {
                    rabbit.Available = false;

                    soldCounter++;
                }
            }

            Rabbit[] soldRabbits = new Rabbit[soldCounter];
            soldCounter = 0;

            foreach (var rabbit in this.rabbits)
            {
                if (rabbit.Species == species)
                {
                    soldRabbits[soldCounter] = rabbit;
                    soldCounter++;
                }
            }

            return soldRabbits;
        }

        public int Count
        {
            get { return this.rabbits.Count; }
        }

        public string Report()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine($"Rabbits available at {this.Name}:");

            foreach (var rabbit in this.rabbits)
            {
                if (rabbit.Available == true)
                {
                    result.AppendLine(rabbit.ToString());
                }
            }

            return result.ToString().TrimEnd();
        }
    }
}
