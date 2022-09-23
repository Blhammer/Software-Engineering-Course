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
        private static int[] depth;
        private static int[] lowpoint;
        private static bool[] visited;
        private static int[] parent;
        private static Stack<int> stack;
        private static List<HashSet<int>> components;

        public static void Main()
        {
            var nodes = int.Parse(Console.ReadLine());
            var edges = int.Parse(Console.ReadLine());

            graph = new List<int>[nodes];
            depth = new int[graph.Length];
            lowpoint = new int[graph.Length];
            visited = new bool[graph.Length];
            parent = new int[graph.Length];
            stack = new Stack<int>();
            components = new List<HashSet<int>>();

            SetNewListsGraph();

            ReadGraph(edges);

            StartLookingForTheArticulationPoints();
        }

        private static void StartLookingForTheArticulationPoints()
        {
            for (int node = 0; node < graph.Length; node++)
            {
                if (visited[node])
                {
                    continue;
                }

                FindArticulationPoints(node, 1);

                var lastComponent = stack.ToHashSet();

                Console.WriteLine(string.Join(" ", lastComponent));

                components.Add(lastComponent);
            }

            Console.WriteLine($"Number of bi-connected components: {components.Count}");
        }

        private static void FindArticulationPoints(int node, int currentDepth)
        {
            visited[node] = true;
            depth[node] = currentDepth;
            lowpoint[node] = currentDepth;

            var childCount = 0;

            foreach (var child in graph[node])
            {
                if (!visited[child])
                {
                    stack.Push(node);
                    stack.Push(child);

                    parent[child] = node;

                    FindArticulationPoints(child, currentDepth + 1);

                    childCount += 1;

                    if (parent[node] != -1 && lowpoint[child] >= depth[node] ||
                        parent[node] == -1 && childCount > 1)
                    {
                        var component = new HashSet<int>();

                        while (true)
                        {
                            var stackChild = stack.Pop();
                            var stackNode = stack.Pop();

                            component.Add(stackNode);
                            component.Add(stackChild);

                            if (stackNode == node &&
                                stackChild == child)
                            {
                                break;
                            }
                        }

                        components.Add(component);
                    }

                    lowpoint[node] = Math.Min(lowpoint[node], lowpoint[child]);
                }
                else if (parent[node] != child &&
                         depth[child] < lowpoint[node])
                {
                    lowpoint[node] = depth[child];

                    stack.Push(node);
                    stack.Push(child);
                }
            }
        }

        private static void ReadGraph(int edges)
        {
            for (int i = 0; i < edges; i++)
            {
                var edgeData = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                var firstNode = edgeData[0];
                var secondNode = edgeData[1];

                graph[firstNode].Add(secondNode);
                graph[secondNode].Add(firstNode);
            }
        }

        private static void SetNewListsGraph()
        {
            for (int node = 0; node < graph.Length; node++)
            {
                graph[node] = new List<int>();
                parent[node] = -1;
            }
        }
    }
}