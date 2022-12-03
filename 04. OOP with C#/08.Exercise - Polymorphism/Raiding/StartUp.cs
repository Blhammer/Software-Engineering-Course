using System;
using System.Collections.Generic;
using System.Linq;

namespace Raiding
{
    public class StartUp
    {
        /// <summary>
        /// This project has been solved with Factory Design Pattern  
        /// </summary>
        /// <returns></returns>
        static void Main(string[] args)
        {
            List<BaseHero> raidGroup = new List<BaseHero>();

            int countOfHeroes = int.Parse(Console.ReadLine());

            while (raidGroup.Count < countOfHeroes)
            {
                HeroCreator heroCreator = null;

                string heroName = Console.ReadLine();
                string heroType = Console.ReadLine();

                switch (heroType.ToLower())
                {
                    case "druid":
                        heroCreator = new DruidCreator(heroName);
                        break;

                    case "paladin":
                        heroCreator = new PaladinCreator(heroName);
                        break;

                    case "rogue":
                        heroCreator = new RogueCreator(heroName);
                        break;

                    case "warrior":
                        heroCreator = new WarriorCreator(heroName);
                        break;

                    default:
                        Console.WriteLine("Invalid hero!");
                        break;
                }

                if (heroCreator != null)
                {
                    BaseHero currentHero = heroCreator.GetHero();
                    raidGroup.Add(currentHero);
                }
            }

            int bossPower = int.Parse(Console.ReadLine());

            foreach (var hero in raidGroup)
            {
                Console.WriteLine(hero.CastAbility());
            }

            Console.WriteLine(raidGroup.Sum(h => h.Power) >= bossPower ? "Victory!" : "Defeat...");
        }
    }
}
