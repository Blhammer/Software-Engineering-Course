using System;

namespace _12._ConverterOfLength
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            string inputMeasure = Console.ReadLine();//Possible input measures: mm, cm, m
            string outputMeasure = Console.ReadLine();

            double result = 0.0;

            if (inputMeasure == "mm")
            {
                if (outputMeasure == "cm")
                {
                    result = number * 10;
                }

                if (outputMeasure == "m")
                {
                    result = number / 1000;
                }
            }
            else if (inputMeasure == "cm")
            {
                if (outputMeasure == "mm")
                {
                    result = number * 10;
                }

                if (outputMeasure == "m")
                {
                    result = number / 100;
                }
            }
            else if (inputMeasure == "m")
            {
                if (outputMeasure == "mm")
                {
                    result = number * 1000;
                }

                if (outputMeasure == "cm")
                {
                    result = number * 100;
                }
            }

            Console.WriteLine($"{result:f3}");
        }
    }
}
