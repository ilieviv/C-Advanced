using System;
using System.Linq;

namespace _2._Sum_Matrix_Columns
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
                var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = numbers[col];
                }
            }

            for (int i = 0; i < cols; i++)
            {
                int sum = 0;
                for (int j = 0; j < rows; j++)
                {
                    int currentNumber = matrix[j, i];
                    sum += currentNumber;
                }
                Console.WriteLine(sum);
                sum = 0;
            }
        }
    }
}
