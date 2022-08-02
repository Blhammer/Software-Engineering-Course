using System;
using System.Runtime.Serialization;

namespace _05._Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int num = 1; num <= n; num++)
            {
                int sum = 0;
                int check = num;

                while (check > 0)
                {
                    sum += check % 10;
                    check /= 10;
                }

                bool isSpecial = (sum == 5) ||
                    (sum == 7) ||
                    (sum == 11);

                Console.WriteLine($"{num} -> {isSpecial}");
            }
        }
    }
}
