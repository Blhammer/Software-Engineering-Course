using System;

namespace Add15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int sumMinutes = hours * 60 + minutes;

            int timePlusFifteen = sumMinutes + 15;

            int finalhours = timePlusFifteen / 60;
            int finalMinutes = timePlusFifteen % 60;

            if (finalhours >= 24)
            {
                finalhours -= 24;
            }

            if (finalMinutes < 10)
            {
                Console.WriteLine($"{finalhours}:0{finalMinutes}");
            }
            else
            {
                Console.WriteLine($"{finalhours}:{finalMinutes}");
            }
        }
    }
}
