using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split();
            var expression = new Stack<string>(input.Reverse());


            int result = 0;

            while (expression.Count > 0)
            {
                var operation = expression.Pop();

                if (operation == "+")
                {
                    result += int.Parse(expression.Pop());
                }
                else if (operation == "-")
                {
                    result -= int.Parse(expression.Pop());
                }
                else
                {
                    result = int.Parse(operation);
                }
            }

            Console.WriteLine(result);
        }
    }
}
