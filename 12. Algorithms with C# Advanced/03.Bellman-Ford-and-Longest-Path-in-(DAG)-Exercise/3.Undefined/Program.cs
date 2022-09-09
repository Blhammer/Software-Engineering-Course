using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace MyApp
{
    public class Program
    {
        public static void Main()
        {
            int nodes = int.Parse(Console.ReadLine()) + 1;
            int edges = int.Parse(Console.ReadLine());

            var graph = new List<Edge>();

            for (int i = 0; i < edges; i++)
            {
                var edgeData = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                graph.Add(new Edge
                {
                    From = edgeData[0],
                    To = edgeData[1],
                    Weight = edgeData[2]
                });
            }

            var source = int.Parse(Console.ReadLine());
            var destination = int.Parse(Console.ReadLine());

            var distance = new double[nodes];
            var prev = new int[nodes];

            for (int node = 0; node < nodes; node++)
            {
                distance[node] = double.PositiveInfinity;
                prev[node] = -1;
            }

            distance[source] = 0;

            for (int i = 0; i < nodes - 2; i++)
            {
                var updated = false;

                foreach (var edge in graph)
                {
                    if (double.IsPositiveInfinity(distance[edge.From]))
                    {
                        continue;
                    }

                    double newDistance = distance[edge.From] + edge.Weight;

                    if (newDistance < distance[edge.To])
                    {
                        distance[edge.To] = newDistance;
                        prev[edge.To] = edge.From;
                        updated = true;
                    }
                }

                if (!updated)
                {
                    break;
                }
            }

            foreach (var edge in graph)
            {
                double newDistance = distance[edge.From] + edge.Weight;

                if (newDistance < distance[edge.To])
                {
                    Console.WriteLine("Undefined");
                    return;
                }
            }

            var path = new Stack<int>();

            var currentNode = destination;

            while (currentNode != -1)
            {
                path.Push(currentNode);
                currentNode = prev[currentNode];
            }

            Console.WriteLine(string.Join(" ", path));
            Console.WriteLine(distance[destination]);
        }
    }

    public class Edge
    {
        public int From { get; set; }
        public int To { get; set; }
        public int Weight { get; set; }
    }
}