using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;
using Wintellect.PowerCollections;

namespace FirstTask
{
    public class Edge
    {
        public int First { get; set; }
        public int Second { get; set; }
        public int Weight { get; set; }
    }

    public class Program
    {
        private static Dictionary<int, List<Edge>> _edgesByNode;
        private static double[] _distance;
        private static int[] _parent;
        public static void Main()
        {
            int depotsCount = int.Parse(Console.ReadLine());
            int trainTracksCount = int.Parse(Console.ReadLine());

            _edgesByNode = new Dictionary<int, List<Edge>>(depotsCount);

            int[] depotData = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int start = depotData[0];
            int end = depotData[1];

            ReadGraph(trainTracksCount);

            InitializeDistanceAndParent();

            Dijkstra(start, end);

            Print(end);
        }

        private static void ReadGraph(int trainTracksCount)
        {
            for (int i = 0; i < trainTracksCount; i++)
            {
                int[] edgeArgs = Console.ReadLine()
                    .Split(new[] { " " }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int firstNode = edgeArgs[0];
                int secondNode = edgeArgs[1];

                Edge edge = new Edge
                {
                    First = firstNode,
                    Second = secondNode,
                    Weight = edgeArgs[2],
                };

                if (!_edgesByNode.ContainsKey(firstNode))
                {
                    _edgesByNode.Add(firstNode, new List<Edge>());
                }

                if (!_edgesByNode.ContainsKey(secondNode))
                {
                    _edgesByNode.Add(secondNode, new List<Edge>());
                }

                _edgesByNode[firstNode].Add(edge);
                _edgesByNode[secondNode].Add(edge);
            }
        }

        private static void InitializeDistanceAndParent()
        {
            int biggestNode = _edgesByNode.Keys.Max();

            _distance = new double[biggestNode + 1];

            for (int node = 0; node < _distance.Length; node++)
            {
                _distance[node] = double.PositiveInfinity;
            }

            _parent = new int[biggestNode + 1];

            for (int i = 0; i < _parent.Length; i++)
            {
                _parent[i] = -1;
            }
        }

        private static void Dijkstra(int startNode, int endNode)
        {
            _distance[startNode] = 0;

            var bag = new OrderedBag<int>(Comparer<int>.Create((f, s) => (int)(_distance[f] - _distance[s])));
            bag.Add(startNode);

            while (bag.Count > 0)
            {
                int minNode = bag.RemoveFirst();

                if (double.IsPositiveInfinity(minNode))
                {
                    break;
                }

                if (minNode == endNode)
                {
                    break;
                }

                foreach (var edge in _edgesByNode[minNode])
                {
                    int otherNode = edge.First == minNode
                        ? edge.Second
                        : edge.First;

                    if (double.IsPositiveInfinity(_distance[otherNode]))
                    {
                        bag.Add(otherNode);
                    }

                    double newDistance = _distance[minNode] + edge.Weight;

                    if (newDistance < _distance[otherNode])
                    {
                        _parent[otherNode] = minNode;

                        _distance[otherNode] = newDistance;

                        bag = new OrderedBag<int>(
                            bag,
                            Comparer<int>.Create(
                                (f, s) => (int)(_distance[f] - _distance[s])));
                    }
                }
            }
        }

        private static void Print(int endNode)
        {
            int currentNode = endNode;

            Stack<int> path = new Stack<int>();

            while (currentNode != -1)
            {
                path.Push(currentNode);
                currentNode = _parent[currentNode];
            }

            Console.WriteLine(string.Join(" ", path));
            Console.WriteLine(_distance[endNode]);
        }
    }
}