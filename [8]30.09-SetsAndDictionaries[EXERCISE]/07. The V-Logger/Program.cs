using System;
using System.Collections.Generic;
using System.Linq;

namespace _07._The_V_Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            var database = new Dictionary<string, Dictionary<string, HashSet<string>>>();

            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();

                if (input[0] == "Statistics")
                {
                    break;
                }

                string vlogger = input[0];
                string action = input[1];

                if (action == "joined")
                {
                    if (!database.ContainsKey(vlogger))
                    {
                        database.Add(vlogger, new Dictionary<string, HashSet<string>>());
                        database[vlogger].Add("followers", new HashSet<string>());
                        database[vlogger].Add("following", new HashSet<string>());
                    }
                }
                else if (action == "followed")
                {
                    string member = input[2];

                    if (vlogger != member && database.ContainsKey(vlogger) && database.ContainsKey(member))
                    {
                        database[vlogger]["following"].Add(member);
                        database[member]["followers"].Add(vlogger);
                    }
                }
            }

            Console.WriteLine($"The V-Logger has a total of {database.Count} vloggers in its logs.");

            int count = 1;

            foreach (var vlog in database.OrderByDescending(v => v.Value["followers"].Count).ThenBy(v => v.Value["following"].Count))
            {
                Console.WriteLine($"{count}. {vlog.Key} : {vlog.Value["followers"].Count} followers, {vlog.Value["following"].Count} following");

                if (count == 1)
                {
                    foreach (string follower in vlog.Value["followers"].OrderBy(f => f))
                    {
                        Console.WriteLine($"*  {follower}");
                    }
                }

                count++;
            }
        }
    }
}
