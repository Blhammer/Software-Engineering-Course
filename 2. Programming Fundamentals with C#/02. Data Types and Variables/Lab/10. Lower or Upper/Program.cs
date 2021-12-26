using System;

namespace _10._Lower_or_Upper
{
    class Program
    {
        static void Main(string[] args)
        {
            string letter = Console.ReadLine();
            
            if (letter == letter.ToUpper())
            {
                Console.WriteLine("upper-case");
            }
            else
            {
                letter.ToLower();
                Console.WriteLine("lower-case");
            }
        }
    }
}
