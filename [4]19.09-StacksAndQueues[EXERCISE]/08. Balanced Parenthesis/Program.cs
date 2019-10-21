using System;
using System.Collections;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .ToCharArray();

            if (input.Length % 2 == 1)
            {
                Console.WriteLine("NO");
                return;
            }

            var openingBrackets = new Stack<char>();

            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];

                if (ch == '[' || ch == '{' || ch == '(')
                {
                    openingBrackets.Push(ch);
                }
                else if (openingBrackets.Count == 0)
                {
                    Console.WriteLine("NO");
                    break;
                }
                else
                {
                    char lastOpenBracket = openingBrackets.Pop();

                    if (lastOpenBracket == '(' && ch != ')')
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    if (lastOpenBracket == '[' && ch != ']')
                    {
                        Console.WriteLine("NO");
                        return;
                    }

                    if (lastOpenBracket == '{' && ch != '}')
                    {
                        Console.WriteLine("NO");
                        return;
                    }
                }
            }

            if (openingBrackets.Count == 0)
            {
                Console.WriteLine("YES");
            }
        }
    }
}
