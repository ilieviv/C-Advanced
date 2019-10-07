using System;
using System.Linq;

namespace _3._Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var matrix = new int[n, n];
            int diagonal = 0;
            int count = 0;
            for (int rows = 0; rows < n; rows++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int cols = 0; cols < n; cols++)
                {
                    matrix[rows, cols] = input[cols];
                }
                diagonal += matrix[rows, count];
                count++;
            }
            Console.WriteLine(diagonal
                );
        }
    }
}
