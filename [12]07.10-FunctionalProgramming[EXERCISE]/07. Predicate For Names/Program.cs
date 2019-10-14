using System;
using System.Linq;

namespace _07._Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {

            int length = int.Parse(Console.ReadLine());

            Func<string, bool> Names = x => x.Length <= length;

            var input = Console.ReadLine()
                .Split()
                .Where(Names)
                .ToArray();

            Console.WriteLine(string.Join(Environment.NewLine, input));
        }
    }
}
