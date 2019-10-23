using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace SpaceStationRecruitment
{
    public class SpaceStation
    {
        private List<Astronaut> astronauts;

        public SpaceStation(string name, int capacity)
        {
            this.Name = name;
            this.Capacity = capacity;

            this.astronauts = new List<Astronaut>();
        }

        public string Name { get; set; }
        public int Capacity { get; set; }
        // public int Count => this.astronauts.Count;

        public int Count
        {
            get { return this.astronauts.Count; }
        }

        public void Add(Astronaut astronaut)
        {
            if (this.astronauts.Count < this.Capacity)
            {
                this.astronauts.Add(astronaut);
            }
        }

        public bool Remove(string name)
        {
            foreach (var astro in this.astronauts)
            {
                if (astro.Name == name)
                {
                    this.astronauts.Remove(astro);
                    return true;
                }
            }
            return false;
        }

        public Astronaut GetOldestAstronaut()
        {
            return this.astronauts.OrderByDescending(x => x.Age).FirstOrDefault();
        }

        public Astronaut GetAstronaut(string name)
        {
            return this.astronauts.FirstOrDefault(x => x.Name == name);
        }

        public string Report()
        {
            return $"Astronauts working at Space Station {this.Name}:" +
                Environment.NewLine +
                string.Join(Environment.NewLine, this.astronauts.Select(x => x.ToString()));
        }

        //public string Report()
        //{
        //    StringBuilder result = new StringBuilder();
        //    result.AppendLine($"Astronauts working at Space Station {this.Name}:");

        //    foreach (var astronaut in this.astronauts)
        //    {
        //        result.AppendLine(astronaut.ToString());
        //    }

        //    return result.ToString().TrimEnd();
        //}

    }
}
