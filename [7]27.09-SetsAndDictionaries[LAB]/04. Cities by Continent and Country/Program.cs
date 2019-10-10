using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Cities_by_Continent_and_Country
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var continentsList = new Dictionary<string, Dictionary<string, List<string>>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                string continent = input[0];
                string country = input[1];
                string city = input[2];

                if (!continentsList.ContainsKey(continent))
                {
                    continentsList.Add(continent, new Dictionary<string, List<string>>());

                    if (!continentsList[continent].ContainsKey(country))
                    {
                        continentsList[continent].Add(country, new List<string>());
                    }

                    continentsList[continent][country].Add(city);
                }
                else
                {
                    if (!continentsList[continent].ContainsKey(country))
                    {
                        continentsList[continent].Add(country, new List<string>());
                    }

                    continentsList[continent][country].Add(city);
                }

            }
            foreach (var cont in continentsList)
            {
                Console.WriteLine($"{cont.Key}:");

                foreach (var kvp in cont.Value)
                {
                    Console.WriteLine($"  {kvp.Key} -> {string.Join(", ", kvp.Value)}");
                }
            }
        }
    }
}
