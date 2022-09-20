using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    public class Program
    {
        private static int[,] _graph;
        private static int[] _parent;

        public static void Main()
        {
            var nodes = int.Parse(Console.ReadLine());

            _graph = new int[nodes, nodes];

            InitializeGraphMatrix(nodes);

            var source = int.Parse(Console.ReadLine());
            var target = int.Parse(Console.ReadLine());

            _parent = new int[nodes];
            Array.Fill(_parent, -1);

            int maxFlow = 0;

            int result = FindMaxFlowPath(source, target, maxFlow);

            Console.WriteLine($"Max flow = {result}");
        }

        private static int FindMaxFlowPath(int source, int target, int maxFlow)
        {
            while (Bfs(source, target))
            {
                var minFlow = GetMinFlow(target);

                ApplyFlow(target, minFlow);

                maxFlow += minFlow;
            }

            return maxFlow;
        }

        private static void ApplyFlow(int node, int flow)
        {
            while (_parent[node] != -1)
            {
                var prev = _parent[node];

                _graph[prev, node] -= flow;

                node = prev;
            }
        }

        private static int GetMinFlow(int node)
        {
            var minFlow = int.MaxValue;

            while (_parent[node] != -1)
            {
                var prev = _parent[node];
                var flow = _graph[prev, node];

                if (flow < minFlow)
                {
                    minFlow = flow;
                }

                node = prev;
            }

            return minFlow;
        }

        private static void InitializeGraphMatrix(int nodes)
        {
            for (int node = 0; node < nodes; node++)
            {
                var row = Console.ReadLine()
                    .Split(", ")
                    .Select(int.Parse)
                    .ToArray();

                for (int child = 0; child < row.Length; child++)
                {
                    _graph[node, child] = row[child];
                }
            }
        }

        private static bool Bfs(int source, int target)
        {
            var visited = new bool[_graph.GetLength(0)];
            visited[source] = true;

            var queue = new Queue<int>();
            queue.Enqueue(source);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                for (int child = 0; child < _graph.GetLength(1); child++)
                {
                    if (!visited[child] && _graph[node, child] > 0)
                    {
                        visited[child] = true;
                        queue.Enqueue(child);
                        _parent[child] = node;
                    }
                }
            }

            return visited[target];
        }
    }
}