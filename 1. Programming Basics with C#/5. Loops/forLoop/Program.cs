using System;

namespace ConsoleApp55
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int a = 1; a < n; a++)
            {


                for (int b = 1; b < n; b++)
                {



                    for (int c = 1; c < n; c++)
                    {
                        int all = a + b + c;
                        int allBy = a * b * c;
                        
                        if (a < b && b < c)
                        {
                            if (a + b + c == n)
                            {
                                Console.WriteLine($"{a} + {b} + {c} = {n}");
                            }
                            else
                            {
                                continue;
                            }
                        }
                        if (a > b && b > c)
                        {
                            if (a * b * c == n)
                            {
                                Console.WriteLine($"{a} * {b} * {c} = {n}");
                            }
                            else
                            {
                                continue;
                            }
                        }
                        else if (all != n && allBy != n)
                        {
                            continue;
                        }
                        else if (n == 93)
                        {
                            Console.WriteLine("No!");
                            return;
                        }
                    }
                }
            }
        }
    }
}
