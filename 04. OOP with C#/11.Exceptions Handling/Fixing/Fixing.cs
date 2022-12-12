using System;

namespace Fixing
{
    class Fixing
    {
        static void Main(string[] args)
        {
            string[] weekdays = new string[7];

            weekdays[0] = "Monday";
            weekdays[1] = "Tuesday";
            weekdays[2] = "Wednesday";
            weekdays[3] = "Thursday";
            weekdays[4] = "Friday";
            weekdays[5] = "Saturday";
            weekdays[6] = "Sunday";

            for (int i = 0; i <= 7; i++)
            {
                try
                {
                    Console.WriteLine(weekdays[i]);
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.ReadLine();
        }
    }
}
