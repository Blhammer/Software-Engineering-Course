using System;
using System.Collections.Generic;
using System.Linq;

namespace BorderControl
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<Citizen> citizenBuyers = new List<Citizen>();
            List<Rebel> rebelBuyers = new List<Rebel>();

            for (int i = 0; i < n; i++)
            {
                string[] iBuyableInfo = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string name = iBuyableInfo[0];
                int age = int.Parse(iBuyableInfo[1]);

                switch (iBuyableInfo.Length)
                {
                    case 4:
                        string id = iBuyableInfo[2];
                        string birthdate = iBuyableInfo[3];
                        Citizen currCitizen = new Citizen(name, age, id, birthdate);
                        citizenBuyers.Add(currCitizen);

                        break;
                    case 3:
                        string group = iBuyableInfo[2];
                        Rebel currRebel = new Rebel(name, age, group);
                        rebelBuyers.Add(currRebel);

                        break;
                }
            }

            string input = string.Empty;

            while ((input = Console.ReadLine()) != "End")
            {
                Citizen currCitizen = citizenBuyers.FirstOrDefault(b => b.Name == input);
                Rebel currRebel = rebelBuyers.FirstOrDefault(r => r.Name == input);

                if (currCitizen != null)
                {
                    currCitizen.BuyFood();
                }
                else if (currRebel != null)
                {
                    currRebel.BuyFood();
                }
            }

            Console.WriteLine(citizenBuyers.Sum(f => f.Food) + rebelBuyers.Sum(f => f.Food));
        }
    }
}
