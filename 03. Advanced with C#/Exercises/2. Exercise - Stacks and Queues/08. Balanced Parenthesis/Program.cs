using System;
using System.Collections.Generic;

namespace _08._Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();

            Stack<char> sequence = new Stack<char>();

            bool isTrue = true;

            foreach (char ch in input)
            {
                if (ch == '{' || ch == '(' || ch == '[')
                {
                    sequence.Push(ch);
                }
                else
                {
                    if (sequence.Count == 0)
                    {
                        isTrue = false;
                        break;
                    }

                    if (sequence.Peek() == '{' && ch == '}'|| sequence.Peek() == '(' && ch == ')' || sequence.Peek() == '[' && ch == ']')
                    {
                        sequence.Pop();
                        isTrue = true;
                    }
                    else
                    {
                        isTrue = false;
                        break;
                    }
                }
            }

            if (isTrue)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}
