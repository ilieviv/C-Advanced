using System;
using System.Linq;

namespace _3._Maximal_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            var matrix = new int[rows, cols];

            InitializeMatrix(matrix);

            int maxSum = int.MinValue;
            int[] coordinates = new int[] { 0, 0 };

            for (int row = 0; row < matrix.GetLength(0) - 2; row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 2; col++)
                {
                    int currSum =
                          matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2]
                        + matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2]
                        + matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                    bool isMax = currSum > maxSum;

                    if (isMax)
                    {
                        maxSum = currSum;
                        coordinates[0] = row;
                        coordinates[1] = col;
                    }
                }
            }

            Console.WriteLine("Sum = " + maxSum);

            int startRow = coordinates[0];
            int startCol = coordinates[1];

            for (int row = startRow; row < startRow + 3; row++)
            {
                for (int col = startCol; col < startCol + 3; col++)
                {

                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }

        }

        private static void InitializeMatrix(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
    }
}
