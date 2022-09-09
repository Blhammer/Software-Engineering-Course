using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Cheap_Town_Tour
{
    public class Program
    {
        public static void Main()
        {
            var nodes = int.Parse(Console.ReadLine());
            var edges = int.Parse(Console.ReadLine());

            var graph = new List<Edge>();

            for (int i = 0; i < edges; i++)
            {
                var edgeData = Console.ReadLine()
                    .Split(" - ")
                    .Select(int.Parse)
                    .ToArray();

                graph.Add(new Edge
                {
                    First = edgeData[0],
                    Second = edgeData[1],
                    Weight = edgeData[2]
                });
            }

            var parent = new int[nodes];
            for (int node = 0; node < parent.Length; node++)
            {
                parent[node] = node;
            }

            var totalCost = 0;

            foreach (var edge in graph.OrderBy(e => e.Weight))
            {
                var firstNodeRoot = FindRoot(edge.First, parent);
                var secondNodeRoot = FindRoot(edge.Second, parent);

                if (firstNodeRoot == secondNodeRoot)
                {
                    continue;
                }

                parent[firstNodeRoot] = secondNodeRoot;

                totalCost += edge.Weight;
            }

            Console.WriteLine($"Total cost: {totalCost}");
        }

        private static int FindRoot(int node, int[] parent)
        {
            while (node != parent[node])
            {
                node = parent[node];
            }

            return node;
        }
    }

    public class Edge
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Weight { get; set; }
    }
}