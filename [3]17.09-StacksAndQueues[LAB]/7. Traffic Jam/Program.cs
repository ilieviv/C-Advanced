using System;
using System.Collections.Generic;

namespace _7._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string command = Console.ReadLine();
            var traficQueue = new Queue<string>();
            int carPassed = 0;

            while (command != "end")
            {
                if (command != "green")
                {
                    traficQueue.Enqueue(command);
                }
                else
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (traficQueue.Count==0)
                        {
                            break;
                        }
                        Console.WriteLine($"{traficQueue.Dequeue()} passed!");
                        carPassed++;
                    }
                }

                command = Console.ReadLine();
            }
            Console.WriteLine($"{carPassed} cars passed the crossroads.");
        }
    }
}
