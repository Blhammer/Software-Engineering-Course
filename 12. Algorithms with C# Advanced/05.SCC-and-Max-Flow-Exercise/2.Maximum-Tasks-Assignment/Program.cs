using System;
using System.Linq;
using System.Text;
using System.Collections;
using System.Collections.Generic;

namespace MyApp
{
    public class Program
    {
        private static bool[,] graph;
        private static int[] parent;

        static void Main(string[] args)
        {
            // 0, 1, 2, 3, 4, 5, 6, 7
            // start, A, B, C, 1, 2, 3, target

            var people = int.Parse(Console.ReadLine());
            var tasks = int.Parse(Console.ReadLine());

            var nodes = people + tasks + 2;
            var start = 0;
            var target = nodes - 1;

            graph = new bool[nodes, nodes];

            ReadGraph(people, tasks, start, target);

            parent = new int[nodes];
            Array.Fill(parent, -1);

            MakeBfsGraph(start, target);

            PrintTasksSolution(people, tasks);
        }

        private static void PrintTasksSolution(int people, int tasks)
        {
            for (int task = people + 1; task <= people + tasks; task++)
            {
                for (int i = 0; i < graph.GetLength(1); i++)
                {
                    if (graph[task, i])
                    {
                        Console.WriteLine($"{(char)(64 + i)}-{task - people}");
                    }
                }
            }
        }

        private static void MakeBfsGraph(int start, int target)
        {
            while (Bfs(start, target))
            {
                var node = target;

                while (parent[node] != -1)
                {
                    var prev = parent[node];

                    graph[prev, node] = false;
                    graph[node, prev] = true;

                    node = prev;
                }
            }
        }

        private static bool Bfs(int start, int target)
        {
            var visited = new bool[graph.GetLength(0)];
            var queue = new Queue<int>();

            visited[start] = true;
            queue.Enqueue(start);

            while (queue.Count > 0)
            {
                var node = queue.Dequeue();

                for (int child = 0; child < graph.GetLength(1); child++)
                {
                    if (!visited[child] &&
                        graph[node, child])
                    {
                        parent[child] = node;
                        visited[child] = true;
                        queue.Enqueue(child);
                    }
                }
            }

            return visited[target];
        }

        private static void ReadGraph(int people, int tasks, int start, int target)
        {
            for (int person = 1; person <= people; person++)
            {
                graph[start, person] = true;
            }

            for (int task = people + 1; task <= people + tasks; task++)
            {
                graph[task, target] = true;
            }

            for (int person = 1; person <= people; person++)
            {
                var personTasks = Console.ReadLine();

                for (int task = 0; task < personTasks.Length; task++)
                {
                    if (personTasks[task] == 'Y')
                    {
                        graph[person, people + task + 1] = true;
                    }
                }
            }
        }
    }
}
