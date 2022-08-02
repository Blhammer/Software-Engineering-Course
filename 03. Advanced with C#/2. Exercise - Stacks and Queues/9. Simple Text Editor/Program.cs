using System;
using System.Collections.Generic;
using System.Text;

namespace _9._Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();
            Stack<string> sequence = new Stack<string>();

            for (int i = 0; i < n; i++)
            {
                string[] commands = Console.ReadLine().Split();

                string command = commands[0];

                if (command == "1")
                {
                    sequence.Push(sb.ToString());
                    string someString = commands[1];
                    sb.Append(someString);
                }
                if (command == "2")
                {
                    sequence.Push(sb.ToString());
                    int count = int.Parse(commands[1]);

                    while (count > 0)
                    {
                        sb.Remove(sb.Length - 1, 1);
                        count--;
                    }
                }
                if (command == "3")
                {
                    int index = int.Parse(commands[1]);
                    Console.WriteLine(sb[index - 1]);
                }
                if (command == "4")
                {
                    sb.Clear();
                    sb.Append(sequence.Pop());
                }
            }
        }
    }
}
