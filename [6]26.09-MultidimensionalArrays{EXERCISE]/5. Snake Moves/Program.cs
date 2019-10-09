using System;
using System.Linq;

namespace _5._Snake_Moves
{
    class Program
    {
        static void Main(string[] args)
        {
            var dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            string snake = Console.ReadLine();

            var matrix = new char[rows, cols];

            var snakeChars = snake.ToCharArray();

            int snakeIndex = snakeChars.Length;//??>
            int currIndex = 0;

            int row = 0;
            int col = 0;

            int test = rows * cols;
            int stopTest = 0;
            while (stopTest < test)
            {


                matrix[row, col] = snakeChars[currIndex];

                currIndex++;

                if (currIndex >= snakeIndex)
                {
                    currIndex = 0;
                }

                if (row % 2 == 0)
                {
                    col++;
                }
                else
                {
                    col--;
                }

                if (col >= matrix.GetLength(1))
                {
                    row++;
                    col--;
                }
                if (col < 0)
                {
                    row++;
                    col++;
                }

                if (row >= matrix.GetLength(0))
                {
                    break;
                }
                stopTest++;

            }

            for (int rowN = 0; rowN < matrix.GetLength(0); rowN++)
            {
                for (int colN = 0; colN < matrix.GetLength(1); colN++)
                {
                    Console.Write(matrix[rowN, colN]);
                }
                Console.WriteLine();
            }
        }
    }
}
