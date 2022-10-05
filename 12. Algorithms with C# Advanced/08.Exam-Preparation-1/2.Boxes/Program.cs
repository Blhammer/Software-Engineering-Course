using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    class Box
    {
        public Box(string box)
        {
            var args = box.Split()
                .Select(int.Parse)
                .ToArray();

            this.Width = args[0];
            this.Depth = args[1];
            this.Height = args[2];
        }

        public int Width { get; set; }
        public int Depth { get; set; }
        public int Height { get; set; }

        public override string ToString()
        {
            return $"{this.Width} {this.Depth} {this.Height}";
        }

        public bool IsBigger(Box currentBox)
        {
            return this.Width > currentBox.Width && this.Depth > currentBox.Depth && this.Height > currentBox.Height;
        }
    }

    public class Program
    {
        public static void Main()
        {
            var boxesCount = int.Parse(Console.ReadLine());
            var boxes = new List<Box>();

            for (int i = 0; i < boxesCount; i++)
            {
                boxes.Add(new Box(Console.ReadLine()));
            }

            foreach (var box in FindLis(boxes))
            {
                Console.WriteLine(box);
            }
        }

        private static IEnumerable<Box> FindLis(List<Box> boxes)
        {
            var prevIndex = new int[boxes.Count];
            var length = new int[boxes.Count];

            var bestLength = 0;
            var startingIndex = 0;

            for (int currentIndex = 0; currentIndex < boxes.Count; currentIndex++)
            {
                var currentBox = boxes[currentIndex];
                var currentBoxLength = 1;
                var currentParent = -1;

                for (int previousIndex = currentIndex - 1; previousIndex >= 0; previousIndex--)
                {
                    var previousBox = boxes[previousIndex];
                    var previousBoxLength = length[previousIndex];

                    if (currentBox.IsBigger(previousBox)
                        && currentBoxLength <= previousBoxLength + 1)
                    {
                        currentBoxLength = previousBoxLength + 1;
                        currentParent = previousIndex;
                    }
                }

                prevIndex[currentIndex] = currentParent;
                length[currentIndex] = currentBoxLength;

                if (currentBoxLength > bestLength)
                {
                    bestLength = currentBoxLength;
                    startingIndex = currentIndex;
                }
            }

            return ReconstructLis(startingIndex, boxes, prevIndex);
        }

        private static IEnumerable<Box> ReconstructLis(int startingIndex, List<Box> boxes, int[] prevIndex)
        {
            var lis = new Stack<Box>();

            while (startingIndex != -1)
            {
                lis.Push(boxes[startingIndex]);
                startingIndex = prevIndex[startingIndex];
            }

            return lis;
        }
    }
}