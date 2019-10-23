using System;
using System.Collections.Generic;
using System.Linq;

namespace _08._Ranking
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var contests = new Dictionary<string, string>();

            while (input != "end of contests")
            {
                var splittedInput = input.Split(":");

                string contest = splittedInput[0];
                string password = splittedInput[1];

                contests.Add(contest, password);
                input = Console.ReadLine();
            }

            string inputSubmissions = Console.ReadLine();

            var participants = new Dictionary<string, Dictionary<string, int>>();

            while (inputSubmissions != "end of submissions")
            {
                var splittedInput = inputSubmissions.Split("=>");

                string contest = splittedInput[0];
                string password = splittedInput[1];
                string username = splittedInput[2];
                int points = int.Parse(splittedInput[3]);

                if (contests.ContainsKey(contest))
                {
                    if (contests[contest] == password)
                    {
                        if (!participants.ContainsKey(username))
                        {
                            participants.Add(username, new Dictionary<string, int>());
                            participants[username].Add(contest, points);
                        }
                        else
                        {
                            if (!participants[username].ContainsKey(contest) && contests[contest] == password)
                            {
                                participants[username].Add(contest, points);
                            }
                            else
                            {
                                if (participants[username][contest] < points && contests[contest] == password)
                                {
                                    participants[username][contest] = points;
                                }
                            }
                        }
                    }
                }

                inputSubmissions = Console.ReadLine();
            }

            //int bestScore = 0;
            //string bestUser = string.Empty;

            //foreach (var person in participants)
            //{

            //    int sum = 0;
            //    foreach (var exam in person.Value)
            //    {
            //        sum += exam.Value;
            //    }

            //    if (sum > bestScore)
            //    {
            //        bestScore = sum;
            //        bestUser = person.Key;
            //    }
            //}

            //Console.WriteLine($"Best candidate is {bestUser} with total {bestScore} points.");
            var topCandidate = participants
                .OrderByDescending(x => x.Value.Sum(s => s.Value))
                .FirstOrDefault();

            Console.WriteLine($"Best candidate is {topCandidate.Key} with total {topCandidate.Value.Sum(x => x.Value)} points.");

            Console.WriteLine("Ranking:");
            foreach (var participant in participants.OrderBy(x => x.Key))
            {
                Console.WriteLine($"{participant.Key}");

                //foreach (var exam in participant.Value.OrderBy(x => x.Key))
                //{
                //    Console.WriteLine($"#  {exam.Key} -> {exam.Value}");
                //}

                foreach (var (exam, point) in participant.Value.OrderBy(x => x.Key))
                {
                    Console.WriteLine($"#  {exam} -> {point}");
                }
            }
        }
    }
}
