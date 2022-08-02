using System;
using System.Runtime.ExceptionServices;

namespace _06._Triples_of_Latin_Letters
{
    class Program
    {
        static void Main(string[] args)
        {
            //Write a program to read an integer n and
            //print all triples of the first n small Latin letters, ordered alphabetically

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    for (int t = 0; t < n; t++)
                    {
                        char first = (char)('a' + i);
                        char second = (char)('a' + k);
                        char third = (char)('a' + t);

                        Console.WriteLine($"{first}{second}{third}");
                    }
                }
            }
        }
    }
}
