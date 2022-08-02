using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsInput = Console.ReadLine().Split(", ");
            string commandInput = Console.ReadLine();

            Queue<string> sequenceOfSongs = new Queue<string>();

            foreach (var song in songsInput)
            {
                sequenceOfSongs.Enqueue(song);
            }

            while (true)
            {
                if (sequenceOfSongs.Count == 0)
                {
                    Console.WriteLine("No more songs!");
                    break;
                }

                string[] commandSeparated = commandInput.Split(' ');
                string command = commandSeparated[0];

                if (command == "Play")
                {
                    sequenceOfSongs.Dequeue();
                }
                else if (command == "Add")
                {
                    string song = commandInput.Substring(command.Length + 1);

                    if (!sequenceOfSongs.Contains(song))
                    {
                        sequenceOfSongs.Enqueue(song);
                    }
                    else
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(String.Join(", ", sequenceOfSongs));
                }

                commandInput = Console.ReadLine();
            }
        }
    }
}
