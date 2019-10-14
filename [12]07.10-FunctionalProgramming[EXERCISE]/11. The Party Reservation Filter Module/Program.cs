using System;
using System.Linq;

namespace _11._The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, string, bool> StartsWith = (names, pattern) => names.StartsWith(pattern);

            var guests = Console.ReadLine().Split().ToList();

            var command = Console.ReadLine();

            while (command != "Print")
            {
                var input = command.Split(";");

                var operation = input[0];
                var prfm = input[1];
                var param = input[2];

                if (operation == "Add filter")
                {
                    if (prfm == "Starts with")
                    {
                        var temp = guests.Where(name => StartsWith(name, param)).ToList();

                        foreach (var currentName in temp)
                        {
                            int index = guests.IndexOf(currentName);
                            guests.Insert(index, currentName);
                        }

                    }
                    else if (prfm == "Ends with")
                    {

                    }
                    else if (prfm == "Length")
                    {

                    }
                    else if (prfm == "Contains")
                    {

                    }
                }
                else if (operation == "Remove filter")
                {

                }

                command = Console.ReadLine();
            }
        }
    }
}
