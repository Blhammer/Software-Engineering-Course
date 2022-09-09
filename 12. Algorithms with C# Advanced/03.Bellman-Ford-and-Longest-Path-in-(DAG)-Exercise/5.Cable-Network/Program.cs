using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Microsoft.VisualBasic;
using Wintellect.PowerCollections;

namespace MyApp
{
    public class Program
    {
        public static void Main()
        {
            var budget = int.Parse(Console.ReadLine());
            var nodes = int.Parse(Console.ReadLine());
            var edges = int.Parse(Console.ReadLine());

            var graph = new List<Edge>[nodes];
            var spanningTree = new HashSet<int>();

            for (int node = 0; node < graph.Length; node++)
            {
                graph[node] = new List<Edge>();
            }

            for (int i = 0; i < edges; i++)
            {
                var edgeData = Console.ReadLine().Split();

                var edge = new Edge
                {
                    First = int.Parse(edgeData[0]),
                    Second = int.Parse(edgeData[1]),
                    Weight = int.Parse(edgeData[2])
                };

                graph[edge.First].Add(edge);
                graph[edge.Second].Add(edge);

                if (edgeData.Length == 4)
                {
                    spanningTree.Add(edge.First);
                    spanningTree.Add(edge.Second);
                }
            }

            var usedBudget = Prim(graph, spanningTree, budget);

            Console.WriteLine($"Budget used: {usedBudget}");
        }

        private static int Prim(List<Edge>[] graph, HashSet<int> spanningTree, int budget)
        {
            var usedBudget = 0;

            var bag = new OrderedBag<Edge>(
                Comparer<Edge>.Create((f, s) =>
                    f.Weight.CompareTo(s.Weight)));

            foreach (var node in spanningTree)
            {
                bag.AddMany(graph[node]);
            }

            while (bag.Count > 0)
            {
                var minEdge = bag.RemoveFirst();

                var nonTreeNode = -1;

                if (spanningTree.Contains(minEdge.First) &&
                    !spanningTree.Contains(minEdge.Second))
                {
                    nonTreeNode = minEdge.Second;
                }

                if (spanningTree.Contains(minEdge.Second) &&
                    !spanningTree.Contains(minEdge.First))
                {
                    nonTreeNode = minEdge.First;
                }

                if (nonTreeNode == -1)
                {
                    continue;
                }

                if (usedBudget + minEdge.Weight > budget)
                {
                    break;
                }

                spanningTree.Add(nonTreeNode);

                bag.AddMany(graph[nonTreeNode]);

                usedBudget += minEdge.Weight;
            }

            return usedBudget;
        }
    }

    public class Edge
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Weight { get; set; }
    }
}