using System;

namespace _4._Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var matrix = new char[n, n];

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine().ToCharArray(); ;
                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];
                }
            }

            char findChar = char.Parse(Console.ReadLine());
            bool occur = false;

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == findChar)
                    {
                        occur = true;
                        Console.WriteLine($"({i}, {j})");
                        return;
                    }
                }
            }

            if (!occur)
            {
                Console.WriteLine($"{findChar} does not occur in the matrix");
            }
        }
    }
}
