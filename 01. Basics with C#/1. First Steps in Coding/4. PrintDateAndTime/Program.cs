using System;

namespace printDateAndTime
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime timeNow = DateTime.Now;

            Console.WriteLine($"Current Date and time: {timeNow}");
        }
    }
}
