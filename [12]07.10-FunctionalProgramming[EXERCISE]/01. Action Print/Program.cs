using System;

namespace _01._Action_Print
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();

            Action<string[]> Printer = x => Console.WriteLine(string.Join(Environment.NewLine, x));

            Printer(input);
        }
    }
}
