using System;
using System.Collections.Generic;

namespace _1._Reverse_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var output = new Stack<char>(input);

            while (output.Count > 0)
            {
                Console.Write(output.Pop());
            }
        }
    }
}
