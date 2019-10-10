using System;
using System.Collections.Generic;

namespace _07._SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            var guest = Console.ReadLine();

            var vipGuests = new HashSet<string>();
            var regularGuests = new HashSet<string>();

            while (guest != "PARTY")
            {

                if (Char.IsDigit(guest[0]))
                {
                    vipGuests.Add(guest);
                }
                else
                {
                    regularGuests.Add(guest);
                }

                guest = Console.ReadLine();
            }

            while (true)
            {
                string partyGuests = Console.ReadLine();

                if (partyGuests == "END")
                {
                    break;
                }

                if (Char.IsDigit(partyGuests[0]))
                {
                    vipGuests.Remove(partyGuests);
                }
                else
                {
                    regularGuests.Remove(partyGuests);
                }
            }

            Console.WriteLine(vipGuests.Count + regularGuests.Count);


            foreach (var gs in vipGuests)
            {
                Console.WriteLine(gs);
            }

            foreach (var gs in regularGuests)
            {
                Console.WriteLine(gs);
            }
        }
    }
}
