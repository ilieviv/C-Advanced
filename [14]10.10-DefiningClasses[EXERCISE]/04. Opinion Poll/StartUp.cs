using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split();

                var name = input[0];
                int age = int.Parse(input[1]);
                var person = new Person(name, age);
                people.Add(person);
            }

            foreach (var man in people.OrderBy(x => x.Name).Where(x => x.Age > 30))
            {
                Console.WriteLine($"{man.Name} - {man.Age}");
            }
        }
    }
}
