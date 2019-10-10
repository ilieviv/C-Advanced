using System;
using System.Collections.Generic;
using System.Linq;

namespace _02._Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfStudents = int.Parse(Console.ReadLine());

            var students = new Dictionary<string, List<float>>();

            for (int i = 0; i < numberOfStudents; i++)
            {
                var input = Console.ReadLine().Split().ToArray();

                var name = input[0];
                float grade = float.Parse(input[1]);

                if (students.ContainsKey(name))
                {
                    students[name].Add(grade);
                }
                else
                {
                    students.Add(name, new List<float>() { grade });
                }
            }

            foreach (var kvp in students)
            {
                Console.WriteLine($"{kvp.Key} -> {string.Join(" ", kvp.Value.Select(x => x.ToString("F2")))} (avg: {kvp.Value.Average():f2})");
            }
        }
    }
}
