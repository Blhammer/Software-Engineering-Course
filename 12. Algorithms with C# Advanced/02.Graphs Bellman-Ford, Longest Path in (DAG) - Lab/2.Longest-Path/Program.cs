using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Channels;

namespace Longest_Path
{
    public class Program
    {
        private static Dictionary<int, List<Edge>> edgesByNode;
        public static void Main()
        {
            int nodes = int.Parse(Console.ReadLine());
            int edges = int.Parse(Console.ReadLine());

            edgesByNode = new Dictionary<int, List<Edge>>();

            for (int i = 0; i < edges; i++)
            {
                int[] edgeData = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();

                int from = edgeData[0];
                int to = edgeData[1];

                if (!edgesByNode.ContainsKey(from))
                {
                    edgesByNode.Add(from, new List<Edge>());
                }

                if (!edgesByNode.ContainsKey(to))
                {
                    edgesByNode.Add(to, new List<Edge>());
                }

                edgesByNode[from].Add(new Edge
                {
                    From = from,
                    To = to,
                    Weight = edgeData[2]
                });
            }

            int source = int.Parse(Console.ReadLine());
            int destination = int.Parse(Console.ReadLine());

            double[] distance = new double[nodes + 1];
            Array.Fill(distance, double.NegativeInfinity);

            distance[source] = 0;

            var prev = new int[nodes + 1];
            Array.Fill(prev, -1);

            var sortedNodes = TopologicalSorting();

            while (sortedNodes.Count > 0)
            {
                int node = sortedNodes.Pop();

                foreach (var edge in edgesByNode[node])
                {
                    var newDistance = distance[edge.From] + edge.Weight;

                    if (newDistance > distance[edge.To])
                    {
                        distance[edge.To] = newDistance;

                        prev[edge.To] = edge.From;
                    }
                }
            }

            Console.WriteLine(distance[destination]);

            var path = new Stack<int>();
            int currentNode = destination;

            while (currentNode != -1)
            {
                path.Push(currentNode);
                currentNode = prev[currentNode];
            }

            Console.WriteLine(string.Join(" ", path));
        }

        public static Stack<int> TopologicalSorting()
        {
            var result = new Stack<int>();

            var visited = new HashSet<int>();

            foreach (var node in edgesByNode.Keys)
            {
                DFS(node, visited, result);
            }

            return result;
        }

        public static void DFS(int node, HashSet<int> visited, Stack<int> result)
        {
            if (visited.Contains(node))
            {
                return;
            }

            visited.Add(node);

            foreach (var edge in edgesByNode[node])
            {
                DFS(edge.To, visited, result);
            }

            result.Push(node);
        }
    }

    public class Edge
    {
        public int From { get; set; }
        public int To { get; set; }
        public int Weight { get; set; }
    }
}