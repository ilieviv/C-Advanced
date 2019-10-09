using System;
using System.Linq;

namespace _4._Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            var matrix = new string[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();

                if (input[0] == "END")
                {
                    break;
                }

                if (input[0] != "swap" || input.Length > 5)
                {
                    Console.WriteLine("Invalid input!");
                }
                else
                {
                    int row1 = int.Parse(input[1]);
                    int col1 = int.Parse(input[2]);
                    int row2 = int.Parse(input[3]);
                    int col2 = int.Parse(input[4]);

                    if (row1 > matrix.GetLength(0) || row2 > matrix.GetLength(0) || col1 > matrix.GetLength(0) || col2 > matrix.GetLength(0))
                    {
                        Console.WriteLine("Invalid input!");
                    }
                    else
                    {
                        var tempTwo = matrix[row1, col1];

                        matrix[row1, col1] = matrix[row2, col2];
                        matrix[row2, col2] = tempTwo;

                        PrintMatrix(matrix);
                    }
                }
            }
        }

        private static void PrintMatrix(string[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
