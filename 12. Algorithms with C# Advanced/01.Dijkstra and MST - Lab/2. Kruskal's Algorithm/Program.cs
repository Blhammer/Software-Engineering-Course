using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;

namespace _2._Kruskal_s_Algorithm
{
    class Program
    {
        private static List<Edge> forest;
        private static List<Edge> edges;
        private static int[] parent;
        public static void Main()
        {
            // Minimum Spanning Tree (MST)
            // Minimum Spanning Forest (MSF)

            forest = new List<Edge>();
            edges = new List<Edge>();

            int count = int.Parse(Console.ReadLine());
            var maxNode = -1;

            for (int i = 0; i < count; i++)
            {
                int[] edgeData = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                var firstNode = edgeData[0];
                var secondNode = edgeData[1];

                if (firstNode > maxNode)
                {
                    maxNode = firstNode;
                }

                if (secondNode > maxNode)
                {
                    maxNode = secondNode;
                }

                edges.Add(new Edge
                {
                    First = firstNode,
                    Second = secondNode,
                    Weight = edgeData[2],
                });
            }

            parent = new int[maxNode + 1];
            for (int node = 0; node < parent.Length; node++)
            {
                parent[node] = node;
            }

            var sortedEdges = edges
                .OrderBy(e => e.Weight)
                .ToArray();

            foreach (var edge in sortedEdges)
            {
                var firstNodeRoot = FindRoot(edge.First);
                var secondNodeRoot = FindRoot(edge.Second);

                if (firstNodeRoot == secondNodeRoot)
                {
                    continue;
                }

                parent[firstNodeRoot] = secondNodeRoot;

                forest.Add(edge);
            }

            foreach (var edge in forest)
            {
                Console.WriteLine($"{edge.First} - {edge.Second}");
            }
        }

        private static int FindRoot(int node)
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
