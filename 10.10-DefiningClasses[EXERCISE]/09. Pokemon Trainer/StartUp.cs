using System;
using System.Collections.Generic;
using System.Linq;

namespace _09._Pokemon_Trainer
{
    class StartUp
    {
        static void Main(string[] args)
        {
            Dictionary<string, Trainer> collectionOftrainers = new Dictionary<string, Trainer>();

            string command = Console.ReadLine();

            while (command != "Tournament")
            {
                var commandInfo = command.Split();

                string trainerName = commandInfo[0];
                string pokemonName = commandInfo[1];
                string pokemonElement = commandInfo[2];
                int health = int.Parse(commandInfo[3]);

                if (!collectionOftrainers.ContainsKey(trainerName))
                {
                    collectionOftrainers.Add(trainerName, new Trainer(trainerName));
                }

                Trainer currentTrainer = collectionOftrainers[trainerName];

                Pokemon pokemon = new Pokemon(pokemonName, pokemonElement, health);

                currentTrainer.Pokemons.Add(pokemon);

                command = Console.ReadLine();
            }


            while ((command = Console.ReadLine()) != "End")
            {
                string element = command;

                foreach (var trainer in collectionOftrainers)
                {
                    if (trainer.Value.Pokemons.Any(p => p.Element == element))
                    {
                        trainer.Value.Badges++;
                    }
                    else
                    {
                        foreach (var pkmn in trainer.Value.Pokemons)
                        {
                            pkmn.Health -= 10;
                        }

                        trainer.Value.Pokemons.RemoveAll(x => x.Health <= 0);
                    }
                }
            }

            var result = collectionOftrainers
                .OrderByDescending(x => x.Value.Badges)
                .ToDictionary(k => k.Key, v => v.Value);

            foreach (var item in result)
            {
                Console.WriteLine($"{item.Key} {item.Value.Badges} {item.Value.Pokemons.Count}");
            }
        }
    }
}
