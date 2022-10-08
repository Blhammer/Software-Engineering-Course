using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace Test
{
    public class Edge
    {
        public int From { get; set; }

        public int To { get; set; }

        public int Weight { get; set; }
    }
    public class Program
    {
        public static void MainSecond()
        {
            var nodes = int.Parse(Console.ReadLine());
            var edges = int.Parse(Console.ReadLine());
            var startNode = int.Parse(Console.ReadLine());

            var graph = new List<Edge>[nodes];

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

                var from = edgeData[0];

                graph[from].Add(new Edge
                {
                    From = from,
                    To = edgeData[1],
                    Weight = edgeData[2]
                });
            }

            var distance = new double[graph.Length];
            for (int i = 0; i < distance.Length; i++)
            {
                distance[i] = double.PositiveInfinity;
            }

            var bag = new OrderedBag<int>(
                Comparer<int>
                    .Create((f, s) =>
                        distance[f].CompareTo(distance[s])));

            foreach (var edge in graph[startNode])
            {
                distance[edge.To] = edge.Weight;
                bag.Add(edge.To);
            }

            while (bag.Count > 0)
            {
                var minNode = bag.RemoveFirst();

                if (minNode == startNode)
                {
                    break;
                }

                foreach (var edge in graph[minNode])
                {
                    if (double.IsPositiveInfinity(distance[edge.To]))
                    {
                        bag.Add(edge.To);
                    }

                    var newDistance = edge.Weight + distance[minNode];

                    if (newDistance < distance[edge.To])
                    {
                        distance[edge.To] = newDistance;

                        bag = new OrderedBag<int>(
                            bag,
                            Comparer<int>
                                .Create((f, s) =>
                                    distance[f].CompareTo(distance[s])));
                    }
                }
            }

            if (double.IsPositiveInfinity(distance[startNode]))
            {
                Console.WriteLine(distance.Count(x => !double.IsPositiveInfinity(x)) + 1);
            }
            else
            {
                Console.WriteLine(distance[startNode]);
            }
        }
    }
}