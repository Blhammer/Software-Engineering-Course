using System;

namespace _12._Refactor_Special_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int sum = 0;
            int check = 0;
           
            for (int n = 1; n <= num; n++)
            {
                check = n;
                while (n > 0)
                {
                    sum += n % 10;
                    n = n / 10;
                }

                bool isValidNumber = (sum == 5) || 
                    (sum == 7) || 
                    (sum == 11);
                
                Console.WriteLine($"{check} -> {isValidNumber}");
                sum = 0;
                n = check;
            }
        }
    }
}
