using System;
using System.Diagnostics.CodeAnalysis;

namespace _03._Calculations
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            if (command == "add")
            {
                Add(n1, n2);
            }
            else if (command == "multiply")
            {
                Multiply(n1, n2);
            }
            else if (command == "subtract")
            {
                Subtract(n1, n2);
            }
            else if (command == "divide")
            {
                Divide(n1, n2);
            }
        }

        static void Add(int n1,int n2)
        {
            Console.WriteLine(n1 + n2);
        }

        static void Multiply(int n1, int n2)
        {
            Console.WriteLine(n1 * n2);
        }

        static void Subtract(int n1, int n2)
        {
            Console.WriteLine(n1 - n2);
        }

        static void Divide(int n1, int n2)
        {
            Console.WriteLine(n1 / n2);
        }
    }
}
