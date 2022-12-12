using System;

namespace FixingSecond
{
    class FixingSecond
    {
        static void Main(string[] args)
        {
            int firstNumber, secondNumber;
            byte result;

            firstNumber = 5;
            secondNumber = 80;

            try
            {
                result = Convert.ToByte(firstNumber * secondNumber);
                Console.WriteLine($"{firstNumber} x {secondNumber} = {result}");
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
