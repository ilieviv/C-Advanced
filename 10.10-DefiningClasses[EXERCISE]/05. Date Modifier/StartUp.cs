using System;

namespace DefiningClasses
{
    class StartUp
    {
        static void Main(string[] args)
        {
            string firstDate = Console.ReadLine();
            string secondDate = Console.ReadLine();

            double result = DateModifier.GetDifference(firstDate, secondDate); //static class and method on DateModifier

            Console.WriteLine(result);
        }
    }
}
