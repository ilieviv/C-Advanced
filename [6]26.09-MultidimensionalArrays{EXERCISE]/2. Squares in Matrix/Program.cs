using System;
using System.Collections.Generic;
using System.Linq;

namespace _2._Squares_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = input[0];
            int cols = input[1];

            var matrix = new char[rows, cols];

            InitializeMatrix(matrix);

            int counter = 0;
            for (int row = 0; row < rows - 1; row++)
            {
                for (int col = 0; col < cols - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1] && matrix[row + 1, col] == matrix[row + 1, col + 1] && matrix[row, col] == matrix[row + 1, col])
                    {
                        counter++;
                    }
                }
            }

            Console.WriteLine(counter);
        }

        private static void InitializeMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var symbols = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(char.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = symbols[col];
                }
            }
        }
    }
}
