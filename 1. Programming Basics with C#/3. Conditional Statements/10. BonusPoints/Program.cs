using System;

namespace _10._BonusPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            double bonus = 0.0;

            if (number <= 100)
            {
                bonus = 5;
            }
            else if (number > 1000)
            {
                bonus = number * 0.1;
            }
            else 
            {
                bonus = number * 0.2;
            }

            //Extra points:
            //1. If number is even => + 1 point
            //2. If number's end equals to 5 => + 2 points 
            if (number % 2 == 0)
            {
                bonus += 1; 
            }
            else if (number % 10 == 5)
            {
                bonus += 2;
            }

            Console.WriteLine(bonus);
            Console.WriteLine(number + bonus);
        }
    }
}
