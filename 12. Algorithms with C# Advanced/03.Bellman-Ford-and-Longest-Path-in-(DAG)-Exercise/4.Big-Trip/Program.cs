using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    public class Program
    {
        public static void Main()
        {
            var nodes = int.Parse(Console.ReadLine());
            var edges = int.Parse(Console.ReadLine());

            var graph = new List<Edge>[nodes + 1];

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

                var edge = new Edge
                {
                    From = edgeData[0],
                    To = edgeData[1],
                    Weight = edgeData[2]
                };

                graph[edge.From].Add(edge);
            }

            var source = int.Parse(Console.ReadLine());
            var destination = int.Parse(Console.ReadLine());

            var distance = new double[graph.Length];
            var prev = new int[graph.Length];

            for (int node = 1; node < graph.Length; node++)
            {
                distance[node] = double.NegativeInfinity;
                prev[node] = -1;
            }

            distance[source] = 0;

            var sorted = TopologicalSort(graph);

            while (sorted.Count > 0)
            {
                var node = sorted.Pop();

                foreach (var edge in graph[node])
                {
                    var newDistance = distance[node] + edge.Weight;

                    if (newDistance > distance[edge.To])
                    {
                        distance[edge.To] = newDistance;
                        prev[edge.To] = node;
                    }
                }
            }

            Console.WriteLine(distance[destination]);

            var path = FindPath(prev, destination);

            Console.WriteLine(string.Join(" ", path));
        }

        private static Stack<int> FindPath(int[] prev, int node)
        {
            var path = new Stack<int>();

            while (node != -1)
            {
                path.Push(node);
                node = prev[node];
            }

            return path;
        }

        private static Stack<int> TopologicalSort(List<Edge>[] graph)
        {
            var result = new Stack<int>();
            var visited = new bool[graph.Length];

            for (int node = 1; node < graph.Length; node++)
            {
                Dfs(node, graph, result, visited);
            }

            return result;
        }

        private static void Dfs(int node, List<Edge>[] graph, Stack<int> result, bool[] visited)
        {
            if (visited[node])
            {
                return;
            }

            visited[node] = true;

            foreach (var edge in graph[node])
            {
                Dfs(edge.To, graph, result, visited);
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