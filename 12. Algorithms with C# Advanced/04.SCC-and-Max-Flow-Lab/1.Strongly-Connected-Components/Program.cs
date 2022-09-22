using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;

namespace MyApp
{
    public class Program
    {
        public static void Main()
        {
            var nodes = int.Parse(Console.ReadLine());
            var lines = int.Parse(Console.ReadLine());

            var graph = new List<int>[nodes];
            var transposedGraph = new List<int>[nodes];

            SetGraphWithEmptyLists(graph, transposedGraph);

            InitializeGraph(lines, graph, transposedGraph);

            var visited = new bool[graph.Length];
            var sorted = new Stack<int>();

            TopologicalSort(visited, sorted, graph);

            visited = new bool[graph.Length];

            GetStronglyConnectedComponents(graph, visited, sorted, transposedGraph);
        }

        private static void GetStronglyConnectedComponents(List<int>[] graph, bool[] visited, Stack<int> sorted, List<int>[] transposedGraph)
        {
            Console.WriteLine("Strongly Connected Components:");

            while (sorted.Count > 0)
            {
                var node = sorted.Pop();
                var component = new Stack<int>();

                if (visited[node])
                {
                    continue;
                }

                Dfs(node, transposedGraph, visited, component);

                Console.WriteLine($"{{{string.Join(", ", component)}}}");
            }
        }

        private static void TopologicalSort(bool[] visited, Stack<int> sorted, List<int>[] graph)
        {
            for (int node = 0; node < graph.Length; node++)
            {
                Dfs(node, graph, visited, sorted);
            }
        }

        private static void InitializeGraph(int lines, List<int>[] graph, List<int>[] transposedGraph)
        {
            for (int i = 0; i < lines; i++)
            {
                var line = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                var node = line[0];

                for (int j = 1; j < line.Length; j++)
                {
                    var child = line[j];
                    graph[node].Add(child);
                    transposedGraph[child].Add(node);
                }
            }
        }

        private static void SetGraphWithEmptyLists(List<int>[] graph, List<int>[] transposedGraph)
        {
            for (int node = 0; node < graph.Length; node++)
            {
                graph[node] = new List<int>();
                transposedGraph[node] = new List<int>();
            }
        }

        private static void Dfs(int node, List<int>[] graph, bool[] visited, Stack<int> result)
        {
            if (visited[node])
            {
                return;
            }

            visited[node] = true;

            foreach (var child in graph[node])
            {
                Dfs(child, graph, visited, result);
            }

            result.Push(node);
        }
    }
}