using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Bellman_Ford
{
    public class Program
    {
        private static List<Edge> graph;
        static void Main()
        {
            int nodes = int.Parse(Console.ReadLine());
            int edges = int.Parse(Console.ReadLine());

            graph = new List<Edge>();

            for (int i = 0; i < edges; i++)
            {
                int[] edgeData = Console.ReadLine()
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

            int source = int.Parse(Console.ReadLine());
            int destination = int.Parse(Console.ReadLine());

            double[] distance = new double[nodes + 1];

            Array.Fill(distance, double.PositiveInfinity);

            distance[source] = 0;

            var prev = new int[nodes + 1];
            Array.Fill(prev, -1);

            for (int i = 0; i < nodes - 1; i++)
            {
                bool updated = false;

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
                    Console.WriteLine("Negative Cycle Detected");
                    return;
                }
            }

            var path = new Stack<int>();
            int node = destination;
            
            while (node != -1)
            {
                path.Push(node);
                node = prev[node];
            }

            Console.WriteLine();
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