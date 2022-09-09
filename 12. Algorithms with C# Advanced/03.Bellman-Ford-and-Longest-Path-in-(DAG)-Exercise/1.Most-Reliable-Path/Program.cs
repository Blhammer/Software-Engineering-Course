using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace Most_Reliable_Path
{
    public class Program
    {
        private const double Percentage = 100;

        public static void Main()
        {
            int nodes = int.Parse(Console.ReadLine());
            int edges = int.Parse(Console.ReadLine());

            var graph = new List<Edge>[nodes];

            for (int node = 0; node < graph.Length; node++)
            {
                graph[node] = new List<Edge>();
            }

            for (int i = 0; i < edges; i++)
            {
                var edgeData = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                var first = edgeData[0];
                var second = edgeData[1];
                var weight = edgeData[2];

                var edge = new Edge
                {
                    First = first,
                    Second = second,
                    Weight = weight
                };

                graph[first].Add(edge);
                graph[second].Add(edge);
            }

            int source = int.Parse(Console.ReadLine());
            int destination = int.Parse(Console.ReadLine());

            double[] reliability = new double[graph.Length];
            int[] prev = new int[graph.Length];

            for (int node = 0; node < graph.Length; node++)
            {
                reliability[node] = double.NegativeInfinity;
                prev[node] = -1;
            }

            reliability[source] = Percentage;

            var bag = new OrderedBag<int>(
                Comparer<int>.Create((f, s) =>
                    reliability[s].CompareTo(reliability[f])));

            bag.Add(source);

            while (bag.Count > 0)
            {
                int node = bag.RemoveFirst();

                if (node == destination)
                {
                    break;
                }

                foreach (var edge in graph[node])
                {
                    var child = edge.First == node
                        ? edge.Second
                        : edge.First;

                    if (double.IsNegativeInfinity(reliability[child]))
                    {
                        bag.Add(child);
                    }

                    var newReliability = (reliability[node] * edge.Weight) / 100.0;

                    if (newReliability > reliability[child])
                    {
                        reliability[child] = newReliability;
                        prev[child] = node;

                        bag = new OrderedBag<int>(
                            bag,
                            Comparer<int>.Create((f, s) =>
                                reliability[s].CompareTo(reliability[f])));
                    }
                }
            }

            Console.WriteLine($"Most reliable path reliability: {reliability[destination]:F2}%");

            var path = new Stack<int>();

            var currentNode = destination;

            while (currentNode != -1)
            {
                path.Push(currentNode);
                currentNode = prev[currentNode];
            }

            Console.WriteLine(string.Join(" -> ", path));
        }
    }
    public class Edge
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Weight { get; set; }
    }
}