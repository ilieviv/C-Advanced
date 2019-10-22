using System;
using System.Linq;

namespace _8._Bombs
{
    class Program
    {
        static int matrixRow;
        static int matrixCol;
        static int[,] matrix;
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            matrix = new int[n, n];

            PopulateMatrix();

            var coordinates = Console.ReadLine().Split().ToArray();

            for (int i = 0; i < coordinates.Length; i++)
            {
                var currentCordinates = coordinates[i].Split(',').Select(int.Parse).ToArray();
                matrixRow = currentCordinates[0];
                matrixCol = currentCordinates[1];

                int bomb = matrix[matrixRow, matrixCol];

                if (matrix[matrixRow, matrixCol] == 0)
                {
                    bomb = 0;
                }


                if (IsInside(matrixRow - 1, matrixCol - 1) && (matrix[matrixRow - 1, matrixCol - 1] > 0))
                {
                    matrix[matrixRow - 1, matrixCol - 1] -= bomb;
                }

                if (IsInside(matrixRow - 1, matrixCol) && (matrix[matrixRow - 1, matrixCol] > 0))
                {
                    matrix[matrixRow - 1, matrixCol] -= bomb;
                }
                if (IsInside(matrixRow - 1, matrixCol + 1) && (matrix[matrixRow - 1, matrixCol + 1] > 0))
                {
                    matrix[matrixRow - 1, matrixCol + 1] -= bomb;
                }

                if (IsInside(matrixRow, matrixCol + 1) && (matrix[matrixRow, matrixCol + 1] > 0))
                {
                    matrix[matrixRow, matrixCol + 1] -= bomb;
                }

                if (IsInside(matrixRow + 1, matrixCol + 1) && (matrix[matrixRow + 1, matrixCol + 1] > 0))
                {
                    matrix[matrixRow + 1, matrixCol + 1] -= bomb;
                }

                if (IsInside(matrixRow + 1, matrixCol) && (matrix[matrixRow + 1, matrixCol] > 0))
                {
                    matrix[matrixRow + 1, matrixCol] -= bomb; //
                }

                if (IsInside(matrixRow + 1, matrixCol - 1) && (matrix[matrixRow + 1, matrixCol - 1] > 0))
                {
                    matrix[matrixRow + 1, matrixCol - 1] -= bomb;
                }

                if (IsInside(matrixRow, matrixCol - 1) && (matrix[matrixRow, matrixCol - 1] > 0))
                {
                    matrix[matrixRow, matrixCol - 1] -= bomb;
                }
            }

            for (int i = 0; i < coordinates.Length; i++)
            {
                var currentCordinates = coordinates[i].Split(',').Select(int.Parse).ToArray();
                matrixRow = currentCordinates[0];
                matrixCol = currentCordinates[1];

                matrix[matrixRow, matrixCol] = 0;
            }

            int aliveCells = 0;
            int sumCells = 0;

            foreach (var element in matrix)
            {
                if (element > 0)
                {
                    aliveCells++;
                    sumCells += element;
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sumCells}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }


        static void PopulateMatrix()
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                var input = Console.ReadLine().Split().Select(int.Parse).ToArray();

                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = input[col];
                }
            }
        }
        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }
    }
}
