using System;

namespace _04._Printing_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine()); ;
            
            Triangle(n);
        }
        static void PrintLine(int start, int end)
        {
            for (int i = start; i <= end; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
        
        static void Triangle(int n) 
        {
            for (int i = 1; i <= n; i++)
            {
                PrintLine(1, i);
            }
        
            for (int i = n - 1; i >= 1; i--)
            {
                PrintLine(1, i);
            }
        }
    }
}
