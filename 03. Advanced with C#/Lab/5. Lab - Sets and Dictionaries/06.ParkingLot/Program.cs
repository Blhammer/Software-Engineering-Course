using System;
using System.Collections.Generic;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> parking = new HashSet<string>();

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                string[] commands = input.Split(", ", StringSplitOptions.RemoveEmptyEntries);
                string command = commands[0];
                string move = commands[1];

                if (command == "in")
                {
                    parking.Add(move);
                }
                else
                {
                    parking.Remove(move);
                }
            }

            if (parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty!");
            }

            foreach (var item in parking)
            {
                Console.WriteLine(item);
            }
        }
    }
}
