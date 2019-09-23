using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine()
               .Split(", ")
               .ToArray();

            var songs = new Queue<string>(input);

            while (songs.Count > 0)
            {
                var curInput = Console.ReadLine();
                var command = curInput.Split();

                if (command[0] == "Play")
                {
                    songs.Dequeue();
                    if (songs.Count == 0)
                    {
                        Console.WriteLine("No more songs!");
                        break;
                    }
                }
                else if (command[0] == "Add")
                {
                    string song = curInput.Substring(4);

                    if (songs.Contains(song))
                    {
                        Console.WriteLine(song + " is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }
                else if (command[0] == "Show")
                {
                    Console.WriteLine(string.Join(", ", songs));
                }
            }
        }
    }
}
