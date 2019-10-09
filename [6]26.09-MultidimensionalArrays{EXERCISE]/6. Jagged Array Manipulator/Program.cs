using System;
using System.Linq;

namespace _6._Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var jagArr = new double[n][];

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().Select(double.Parse).ToArray();

                jagArr[i] = new double[input.Length];

                for (int j = 0; j < input.Length; j++)
                {
                    jagArr[i][j] = input[j];
                }
            }



            for (int i = 0; i < jagArr.GetLength(0) - 1; i++) //or n
            {
                if (jagArr[i].GetLength(0) == jagArr[i + 1].GetLength(0))
                {
                    for (int j = 0; j < jagArr[i].GetLength(0); j++)
                    {
                        jagArr[i][j] = jagArr[i][j] * 2;
                    }

                    for (int k = 0; k < jagArr[i + 1].GetLength(0); k++)
                    {
                        jagArr[i + 1][k] = jagArr[i + 1][k] * 2;
                    }
                }
                else
                {
                    for (int j = 0; j < jagArr[i].GetLength(0); j++)
                    {
                        jagArr[i][j] = jagArr[i][j] / 2;
                    }

                    for (int k = 0; k < jagArr[i + 1].GetLength(0); k++)
                    {
                        jagArr[i + 1][k] = jagArr[i + 1][k] / 2;
                    }
                }
            }

            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();

                if (input[0] == "End")
                {
                    break;
                }

                int row = int.Parse(input[1]);
                int col = int.Parse(input[2]);
                int value = int.Parse(input[3]);

                if (IsInside(jagArr, row, col))
                {
                    if (input[0] == "Add")
                    {
                        jagArr[row][col] += value;
                    }

                    if (input[0] == "Subtract")
                    {
                        jagArr[row][col] -= value;
                    }
                }


            }

            PrintMatrix(jagArr);


        }

        private static void PrintMatrix(double[][] jagArr)
        {
            for (int rows = 0; rows < jagArr.GetLength(0); rows++)
            {
                foreach (var element in jagArr[rows])
                {
                    Console.Write(element + " ");
                }
                Console.WriteLine();
            }
        }

        private static bool IsInside(double[][] jagArr, int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < jagArr.Length && targetCol >= 0 && targetCol < jagArr[targetRow].Length;
        }
    }
}
