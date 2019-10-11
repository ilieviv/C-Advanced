using System;
using System.Collections.Generic;

namespace _04._Even_Times
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var numbers = new HashSet<int>();

            bool exit = false;
            int result = 0;
            for (int i = 0; i < n; i++)
            {
                int input = int.Parse(Console.ReadLine());

                if (!exit)
                {
                    if (numbers.Contains(input))
                    {
                        result = input;
                        exit = true;
                    }
                }
             
                numbers.Add(input);
            }

            if (result!=0)
            {

            Console.WriteLine(result);
            }
        }
    }
}
