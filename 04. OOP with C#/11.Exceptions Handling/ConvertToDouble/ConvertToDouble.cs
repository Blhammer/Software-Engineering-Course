using System;

namespace ConvertToDouble
{
    class ConvertToDouble
    {
        static void Main(string[] args)
        {
            string[] valuesToConvert = { "6.75", "46.822", "66.abcdef", "abcdef", "-454.456", "54", "675675600000" };

            foreach (var el in valuesToConvert)
            {
                try
                {
                    double forced = Math.Pow(Convert.ToDouble(el), 35);

                    if (double.IsNegativeInfinity(forced) || double.IsPositiveInfinity(forced))
                    {
                        throw new OverflowException("Value is greater than max value or lower than min value");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine(e.Message);
                }
                catch (OverflowException e)
                {
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}
