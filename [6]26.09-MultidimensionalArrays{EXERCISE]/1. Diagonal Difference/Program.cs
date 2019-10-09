using System;
using System.Linq;

namespace _1._Diagonal_Difference
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new int[n, n];

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            int primaryDiagonal = 0;
            int secondaryDiagonal = 0;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                primaryDiagonal += matrix[i, i];
                secondaryDiagonal += matrix[i, n - i - 1];
            }

            int difference = Math.Abs(primaryDiagonal - secondaryDiagonal);

            Console.WriteLine(difference);
        }
    }
}
