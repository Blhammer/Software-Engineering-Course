using System;

namespace numbers

{
    class Program
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            string password = Console.ReadLine();
            
            string entryPass = Console.ReadLine();

            if (entryPass == password)
            {
                Console.WriteLine($"Welcome: {username}!");
            }
            else
            {
                Console.WriteLine($"Wrong password!");
            }
        }
    }
}
