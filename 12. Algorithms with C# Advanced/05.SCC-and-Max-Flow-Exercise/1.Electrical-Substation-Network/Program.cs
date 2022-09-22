using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    public class Program
    {
        private static List<int>[] graph;
        private static List<int>[] transposedGraph;
        public static void Main()
        {
            var nodes = int.Parse(Console.ReadLine());
            var lines = int.Parse(Console.ReadLine());

            graph = new List<int>[nodes];
            transposedGraph = new List<int>[nodes];

            SetNewListsGraph();

            ReadGraph(lines);

            var sorted = new Stack<int>();
            var visited = new bool[graph.Length];

            TopologicalOrder(sorted, visited);

            visited = new bool[graph.Length];

            var resultComponents = DfsForEveryNodeByTheGraph(sorted, visited);

            Console.WriteLine(resultComponents);
        }

        private static string DfsForEveryNodeByTheGraph(Stack<int> sorted, bool[] visited)
        {
            StringBuilder sb = new StringBuilder();

            while (sorted.Count > 0)
            {
                var node = sorted.Pop();

                if (visited[node])
                {
                    continue;
                }

                var component = new Stack<int>();

                Dfs(node, transposedGraph, visited, component);

                sb.AppendLine(String.Join(", ", component));
            }

            return sb.ToString();
        }

        private static void TopologicalOrder(Stack<int> sorted, bool[] visited)
        {
            for (int node = 0; node < graph.Length; node++)
            {
                Dfs(node, graph, visited, sorted);
            }
        }

        private static void Dfs(int node, List<int>[] targetGraph, bool[] visited, Stack<int> stackResult)
        {
            if (visited[node])
            {
                return;
            }

            visited[node] = true;

            foreach (var child in targetGraph[node])
            {
                Dfs(child, targetGraph, visited, stackResult);
            }

            stackResult.Push(node);
        }

        private static void ReadGraph(int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                var lineElements = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                var node = lineElements[0];

                for (int j = 1; j < lineElements.Length; j++)
                {
                    var child = lineElements[j];

                    graph[node].Add(child);
                    transposedGraph[child].Add(node);
                }
            }
        }

        private static void SetNewListsGraph()
        {
            for (int node = 0; node < graph.Length; node++)
            {
                graph[node] = new List<int>();
                transposedGraph[node] = new List<int>();
            }
        }
    }
}