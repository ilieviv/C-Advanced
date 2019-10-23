using System;
using System.Linq;

namespace _03._Space_Station_Establishment
{
    class Program
    {
        static char[,] matrix = new char[1, 1];
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            matrix = new char[n, n];
            int startRow = 0;
            int startCol = 0;

            int firstHoleRow = int.MinValue;
            int firstHoleCol = int.MinValue;
            int secondHoleRow = int.MinValue;
            int secondHoleCol = int.MinValue;
            bool secondHole = false;

            for (int row = 0; row < n; row++)
            {
                var input = Console.ReadLine();

                for (int col = 0; col < n; col++)
                {
                    matrix[row, col] = input[col];

                    if (input[col] == 'S')
                    {
                        startRow = row;
                        startCol = col;
                    }

                    if (input[col] == 'O')
                    {
                        if (!secondHole)
                        {
                            firstHoleRow = row;
                            firstHoleCol = col;
                            secondHole = true;
                        }
                        else
                        {
                            secondHoleRow = row;
                            secondHoleCol = col;
                        }

                    }
                }
            }

            int currentRow = startRow;
            int currentCol = startCol;
            int energy = 0;
            bool exit = false;
            matrix[currentRow, currentCol] = '-';

            while (true)
            {
                string command = Console.ReadLine();

                if (exit)
                {
                    break;
                }

                if (energy >= 50)
                {
                    Console.WriteLine("Good news! Stephen succeeded in collecting enough star power!");
                    matrix[currentRow, currentCol] = 'S';
                    break;
                }

                if (command == "right")
                {
                    if (IsInside(currentRow, currentCol + 1))
                    {
                        var symbol = matrix[currentRow, currentCol + 1];

                        if (symbol == 'O')
                        {
                            matrix[firstHoleRow, firstHoleCol] = '-';
                            matrix[secondHoleRow, secondHoleCol] = '-';

                            if (currentRow == firstHoleRow && currentCol + 1 == firstHoleCol)
                            {
                                currentRow = secondHoleRow;
                                currentCol = secondHoleCol;
                            }
                            else if (currentRow == secondHoleRow && currentCol + 1 == secondHoleCol)
                            {
                                currentRow = firstHoleRow;
                                currentCol = firstHoleCol;
                            }
                        }

                        if (symbol >= 48 && symbol <= 57)
                        {
                            var movement = int.Parse(symbol.ToString());
                            energy += movement;
                            matrix[currentRow, currentCol + 1] = '-';
                            currentCol += 1;
                        }

                        if (symbol == '-')
                        {
                            currentCol += 1;
                        }
                    }
                    else if (!IsInside(currentRow, currentCol + 1))
                    {
                        exit = true;
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        matrix[currentRow, currentCol] = '-';
                        break;
                    }
                }
                else if (command == "down")
                {
                    if (IsInside(currentRow + 1, currentCol))
                    {
                        var symbol = matrix[currentRow + 1, currentCol];

                        if (symbol == 'O')
                        {
                            matrix[firstHoleRow, firstHoleCol] = '-';
                            matrix[secondHoleRow, secondHoleCol] = '-';

                            if (currentRow + 1 == firstHoleRow && currentCol == firstHoleCol)
                            {
                                currentRow = secondHoleRow;
                                currentCol = secondHoleCol;
                                Console.WriteLine("asd");
                            }
                            else if (currentRow + 1 == secondHoleRow && currentCol == secondHoleCol)
                            {
                                currentRow = firstHoleRow;
                                currentCol = firstHoleCol;
                            }
                        }

                        if (symbol >= 48 && symbol <= 57)
                        {
                            var movement = int.Parse(symbol.ToString());
                            energy += movement;
                            matrix[currentRow + 1, currentCol] = '-';
                            currentRow += 1;
                        }

                        if (symbol == '-')
                        {
                            currentRow += 1;
                        }
                    }
                    else if (!IsInside(currentRow + 1, currentCol))
                    {
                        exit = true;
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        break;
                    }

                }
                else if (command == "left")
                {
                    if (IsInside(currentRow, currentCol - 1))
                    {
                        var symbol = matrix[currentRow, currentCol - 1];

                        if (symbol == 'O')
                        {
                            matrix[firstHoleRow, firstHoleCol] = '-';
                            matrix[secondHoleRow, secondHoleCol] = '-';

                            if (currentRow == firstHoleRow && currentCol - 1 == firstHoleCol)
                            {
                                currentRow = secondHoleRow;
                                currentCol = secondHoleCol;
                                Console.WriteLine("asd");
                            }
                            else if (currentRow == secondHoleRow && currentCol - 1 == secondHoleCol)
                            {
                                currentRow = firstHoleRow;
                                currentCol = firstHoleCol;
                                Console.WriteLine("ds");
                            }
                        }

                        if (symbol >= 48 && symbol <= 57)
                        {
                            var movement = int.Parse(symbol.ToString());
                            energy += movement;
                            matrix[currentRow, currentCol - 1] = '-';
                            currentCol--;
                        }

                        if (symbol == '-')
                        {
                            currentCol--;
                        }

                    }
                    else if (!IsInside(currentRow, currentCol - 1))
                    {
                        exit = true;
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        break;
                    }
                }
                else if (command == "up")
                {
                    if (IsInside(currentRow - 1, currentCol))
                    {
                        var symbol = matrix[currentRow - 1, currentCol];

                        if (symbol == 'O')
                        {
                            matrix[firstHoleRow, firstHoleCol] = '-';
                            matrix[secondHoleRow, secondHoleCol] = '-';

                            if (currentRow - 1 == firstHoleRow && currentCol == firstHoleCol)
                            {
                                currentRow = secondHoleRow;
                                currentCol = secondHoleCol;
                            }
                            else if (currentRow - 1 == secondHoleRow && currentCol == secondHoleCol)
                            {
                                currentRow = firstHoleRow;
                                currentCol = firstHoleCol;
                            }
                        }

                        if (symbol >= 48 && symbol <= 57)
                        {
                            var movement = int.Parse(symbol.ToString());
                            energy += movement;
                            matrix[currentRow - 1, currentCol] = '-';
                            currentRow--;
                        }

                        if (symbol == '-')
                        {
                            currentRow--;
                        }
                    }
                    else if (!IsInside(currentRow - 1, currentCol))
                    {
                        exit = true;
                        Console.WriteLine("Bad news, the spaceship went to the void.");
                        break;
                    }
                }
            }


            Console.WriteLine($"Star power collected: {energy}");

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        private static bool IsInside(int row, int col)
        {
            return row >= 0 && row < matrix.GetLength(0) && col >= 0 && col < matrix.GetLength(1);
        }

    }
}
