using System;
using System.Linq;

namespace _1._Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();

            int rows = input[0];
            int cols = input[1];

            var matrix = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                var numbersAsRow = Console.ReadLine()
                         .Split(", ")
                         .Select(int.Parse)
                         .ToArray();
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = numbersAsRow[j];
                }
            }

            Console.WriteLine(rows);
            Console.WriteLine(cols);


            int sum = 0;

            foreach (var number in matrix)
            {
                sum += number;
            }

            Console.WriteLine(sum);

        }
    }
}
