using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Wintellect.PowerCollections;

namespace _2.Chain_Lightning
{
    public class Edge
    {
        public int First { get; set; }

        public int Second { get; set; }

        public int Weight { get; set; }
    }

    public class Program
    {
        public static void MainSecond()
        {
            var nodes = int.Parse(Console.ReadLine());
            var edges = int.Parse(Console.ReadLine());
            var lightnings = int.Parse(Console.ReadLine());

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

                var first = edgeData[0];
                var second = edgeData[1];
                var weight = edgeData[2];

                var edge = new Edge
                {
                    First = first,
                    Second = second,
                    Weight = weight
                };

                graph[first].Add(edge);
                graph[second].Add(edge);
            }

            var damageByNode = new int[nodes];

            for (int i = 0; i < lightnings; i++)
            {
                var lightningData = Console.ReadLine()
                    .Split()
                    .Select(int.Parse)
                    .ToArray();

                var node = lightningData[0];
                var damage = lightningData[1];

                Prim(graph, damageByNode, node, damage);
            }

            Console.WriteLine(damageByNode.Max());
        }

        private static void Prim(List<Edge>[] graph, int[] damageByNode, int startNode, int damage)
        {
            damageByNode[startNode] += damage;

            var tree = new HashSet<int> { startNode };
            var jumps = new int[graph.Length];

            var bag = new OrderedBag<Edge>(
                Comparer<Edge>
                    .Create((f, s) => f.Weight.CompareTo(s.Weight)));

            bag.AddMany(graph[startNode]);

            while (bag.Count > 0)
            {
                var minEdge = bag.RemoveFirst();

                var treeNode = -1;
                var nonTreeNode = -1;

                if (tree.Contains(minEdge.First) &&
                    !tree.Contains(minEdge.Second))
                {
                    treeNode = minEdge.First;
                    nonTreeNode = minEdge.Second;
                }
                else if (tree.Contains(minEdge.Second) &&
                    !tree.Contains(minEdge.First))
                {
                    treeNode = minEdge.Second;
                    nonTreeNode = minEdge.First;
                }

                if (nonTreeNode == -1)
                {
                    continue;
                }

                tree.Add(nonTreeNode);
                bag.AddMany(graph[nonTreeNode]);

                jumps[nonTreeNode] = jumps[treeNode] + 1;
                damageByNode[nonTreeNode] += CalcDamage(damage, jumps[nonTreeNode]);
            }
        }

        private static int CalcDamage(int damage, int jumps)
        {
            for (int i = 0; i < jumps; i++)
            {
                damage /= 2;
            }

            return damage;
        }
    }
}