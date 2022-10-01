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
            int[] requiredEnergy = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int[] battlePoints = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            int initialEnergyPoints = int.Parse(Console.ReadLine());

            int enemiesSequence = requiredEnergy.Length;

            int[,] maxBattlePoints = new int[enemiesSequence + 1, initialEnergyPoints + 1];

            Battle(maxBattlePoints, requiredEnergy, battlePoints);

            Console.WriteLine(maxBattlePoints[enemiesSequence, initialEnergyPoints]);
        }

        private static void Battle(int[,] maxBattlePoints, int[] requiredEnergy, int[] battlePoints)
        {
            for (int row = 1; row < maxBattlePoints.GetLength(0); row++)
            {
                int enemyIdx = row - 1;
                int enemyEnergy = requiredEnergy[enemyIdx];
                int enemyBattlePoints = battlePoints[enemyIdx];

                for (int energy = 1; energy < maxBattlePoints.GetLength(1); energy++)
                {
                    int skip = maxBattlePoints[row - 1, energy];

                    if (enemyEnergy > energy)
                    {
                        maxBattlePoints[row, energy] = skip;
                        continue;
                    }

                    int take = enemyBattlePoints + maxBattlePoints[row - 1, energy - enemyEnergy];

                    maxBattlePoints[row, energy] = Math.Max(skip, take);
                }
            }
        }
    }
}