using System;
using System.Linq;

namespace _6._Jagged_Array_Modification
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var arr = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < n; col++)
                {
                    arr[row, col] = numbers[col];
                }
            }

            var input = Console.ReadLine();

            while (input != "END")
            {
                var commands = input.Split();
                var operation = commands[0];
                int row = int.Parse(commands[1]);
                int col = int.Parse(commands[2]);
                int value = int.Parse(commands[3]);

                if (operation == "Add")
                {
                    if (row < arr.GetLength(0) && col < arr.GetLength(1) && row >= 0 && col >= 0)
                    {
                        arr[row, col] += value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }
                else if (operation == "Subtract")
                {
                    if (row < arr.GetLength(0) && col < arr.GetLength(1) && row >= 0 && col >= 0)
                    {
                        arr[row, col] -= value;
                    }
                    else
                    {
                        Console.WriteLine("Invalid coordinates");
                    }
                }

                input = Console.ReadLine();
            }

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write(arr[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
