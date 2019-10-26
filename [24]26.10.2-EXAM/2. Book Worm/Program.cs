using System;
using System.Text;

namespace _2._Book_Worm
{
    class Program
    {
        static char[,] matrix = new char[1, 1];
        static void Main(string[] args)
        {
            var inputText = Console.ReadLine();
            var text = new StringBuilder(string.Empty);
            text.Append(inputText);

            int n = int.Parse(Console.ReadLine());

            matrix = new char[n, n];
            int pRow = 0;
            int pCol = 0;

            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string matrixInput = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = matrixInput[col];
                    if (matrixInput[col] == 'P')
                    {
                        pRow = row;
                        pCol = col;
                    }
                }
            }
            //END of matrix INPUT

            string inputCommand = Console.ReadLine();
            int currentPRow = pRow;
            int currentPCol = pCol;

            int tempRow = currentPRow;
            int tempCol = currentPCol;


            int lastIndexRow = currentPRow;
            int lastIndexCol = currentPCol;

            while (true)
            {
                if (inputCommand == "end")
                {
                    matrix[tempRow, tempCol] = '-';
                    matrix[lastIndexRow, lastIndexCol] = 'P';
                    break;
                }

                if (inputCommand == "left") //0 -1
                {
                    int iterationRow = currentPRow;
                    int iterationCol = currentPCol - 1;


                    if (IsInside(iterationRow, iterationCol))
                    {
                        char currChar = matrix[iterationRow, iterationCol];
                        if (currChar == '-')
                        {
                            currentPRow = iterationRow;
                            currentPCol = iterationCol;

                            if (IsInside(currentPRow, currentPCol))
                            {
                                lastIndexRow = currentPRow;
                                lastIndexCol = currentPCol;
                            }
                        }
                        if (currChar >= 65 && matrix[iterationRow, iterationCol] <= 122) //CHECK ASCI small letters 
                        {
                            text.Append(currChar);
                            matrix[iterationRow, iterationCol] = '-';
                            currentPRow = iterationRow;
                            currentPCol = iterationCol;

                            if (IsInside(currentPRow, currentPCol))
                            {
                                lastIndexRow = currentPRow;
                                lastIndexCol = currentPCol;
                            }
                        }
                    }
                    else
                    {
                        if (text.Length > 0) //TODO check problem with 0-length text
                        {
                            text.Remove(text.Length - 1, 1);//Remove last ch
                        }

                        currentPRow = iterationRow;
                        currentPCol = iterationCol;

                        if (IsInside(currentPRow, currentPCol))
                        {
                            lastIndexRow = currentPRow;
                            lastIndexCol = currentPCol;
                        }
                    }
                }
                else if (inputCommand == "up") //-1 0
                {
                    int iterationRow = currentPRow - 1;
                    int iterationCol = currentPCol;


                    if (IsInside(iterationRow, iterationCol))
                    {
                        char currChar = matrix[iterationRow, iterationCol];
                        if (currChar == '-')
                        {
                            currentPRow = iterationRow;
                            currentPCol = iterationCol;

                            if (IsInside(currentPRow, currentPCol))
                            {
                                lastIndexRow = currentPRow;
                                lastIndexCol = currentPCol;
                            }
                        }
                        if (currChar >= 65 && matrix[iterationRow, iterationCol] <= 122) //CHECK ASCI small letters 
                        {
                            text.Append(currChar);
                            matrix[iterationRow, iterationCol] = '-';
                            currentPRow = iterationRow;
                            currentPCol = iterationCol;

                            if (IsInside(currentPRow, currentPCol))
                            {
                                lastIndexRow = currentPRow;
                                lastIndexCol = currentPCol;
                            }
                        }
                    }
                    else
                    {
                        if (text.Length > 0) //TODO check problem with 0-length text
                        {
                            text.Remove(text.Length - 1, 1);//Remove last ch
                        }

                        currentPRow = iterationRow;
                        currentPCol = iterationCol;

                        if (IsInside(currentPRow, currentPCol))
                        {
                            lastIndexRow = currentPRow;
                            lastIndexCol = currentPCol;
                        }
                    }
                }
                else if (inputCommand == "right") //0 +1
                {
                    int iterationRow = currentPRow;
                    int iterationCol = currentPCol + 1;


                    if (IsInside(iterationRow, iterationCol))
                    {
                        char currChar = matrix[iterationRow, iterationCol];
                        if (currChar == '-')
                        {
                            currentPRow = iterationRow;
                            currentPCol = iterationCol;

                            if (IsInside(currentPRow, currentPCol))
                            {
                                lastIndexRow = currentPRow;
                                lastIndexCol = currentPCol;
                            }
                        }
                        if (currChar >= 65 && matrix[iterationRow, iterationCol] <= 122) //CHECK ASCI small letters 
                        {
                            text.Append(currChar);
                            matrix[iterationRow, iterationCol] = '-';
                            currentPRow = iterationRow;
                            currentPCol = iterationCol;

                            if (IsInside(currentPRow, currentPCol))
                            {
                                lastIndexRow = currentPRow;
                                lastIndexCol = currentPCol;
                            }
                        }
                    }
                    else
                    {
                        if (text.Length > 0) //TODO check problem with 0-length text
                        {
                            text.Remove(text.Length - 1, 1);//Remove last ch
                        }

                        currentPRow = iterationRow;
                        currentPCol = iterationCol;

                        if (IsInside(currentPRow, currentPCol))
                        {
                            lastIndexRow = currentPRow;
                            lastIndexCol = currentPCol;
                        }
                    }
                }
                else if (inputCommand == "down") //+1 0
                {
                    int iterationRow = currentPRow + 1;
                    int iterationCol = currentPCol;


                    if (IsInside(iterationRow, iterationCol))
                    {
                        char currChar = matrix[iterationRow, iterationCol];
                        if (currChar == '-')
                        {
                            currentPRow = iterationRow;
                            currentPCol = iterationCol;

                            if (IsInside(currentPRow, currentPCol))
                            {
                                lastIndexRow = currentPRow;
                                lastIndexCol = currentPCol;
                            }
                        }
                        if (currChar >= 65 && matrix[iterationRow, iterationCol] <= 122) //CHECK ASCI small letters 
                        {
                            text.Append(currChar);
                            matrix[iterationRow, iterationCol] = '-';
                            currentPRow = iterationRow;
                            currentPCol = iterationCol;

                            if (IsInside(currentPRow, currentPCol))
                            {
                                lastIndexRow = currentPRow;
                                lastIndexCol = currentPCol;
                            }
                        }
                    }
                    else
                    {
                        if (text.Length > 0) //TODO check problem with 0-length text
                        {
                            text.Remove(text.Length - 1, 1);//Remove last ch
                        }

                        currentPRow = iterationRow;
                        currentPCol = iterationCol;

                        if (IsInside(currentPRow, currentPCol))
                        {
                            lastIndexRow = currentPRow;
                            lastIndexCol = currentPCol;
                        }
                    }
                }
                inputCommand = Console.ReadLine();
            }

            //OUTPUT
            if (text.Length != 0) //SHOULD REMOVED?
            {
                Console.WriteLine(text);
            }

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
