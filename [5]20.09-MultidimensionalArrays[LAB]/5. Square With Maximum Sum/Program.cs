using System;
using System.Linq;

namespace _5._Square_With_Maximum_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            var matrix = new int[rows, cols];

            for (int row = 0; row < rows; row++)
            {
                var rowInput = Console.ReadLine().Split(", ").Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = rowInput[col];
                }
            }

            int currentSum = 0;
            int maxSum = 0;
            int[] leadIndex = { 0, 0 };
            int sumMatrixRows = 2;
            int sumMatrixCols = 2;

            for (int row = 0; row <= matrix.GetLength(0) - sumMatrixRows; row++)
            {
                for (int col = 0; col <= matrix.GetLength(1) - sumMatrixCols; col++)
                {
                    currentSum = matrix[row, col] + matrix[row, col + 1] + matrix[row + 1, col] + matrix[row + 1, col + 1];
                    if (currentSum > maxSum)
                    {
                        maxSum = currentSum;
                        leadIndex[0] = row;
                        leadIndex[1] = col;
                    }
                }
            }

            int newRow = leadIndex[0];
            int newCol = leadIndex[1];

            int firstNumber = matrix[newRow, newCol];
            int secondNumber = matrix[newRow, newCol + 1];
            int thirdNumber = matrix[newRow + 1, newCol];
            int fourthNumber = matrix[newRow + 1, newCol + 1];

            Console.WriteLine($"{firstNumber} {secondNumber}");
            Console.WriteLine($"{thirdNumber} {fourthNumber}");
            Console.WriteLine(maxSum);
        }
    }
}
