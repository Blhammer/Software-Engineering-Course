using MilitaryElite.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MilitaryElite.Implementations
{
    public class Commando : SpecialisedSoldier, ICommando
    {
        public Commando(int id, string firstName, string lastName, decimal salary, Corps corps)
            : base(id, firstName, lastName, salary, corps)
        {
            this.Missions = new List<IMission>();
        }

        public List<IMission> Missions { get; set; }

        public void CompleteMission(string codeName)
        {
            var mission = this.Missions
                .FirstOrDefault(x => x.CodeName == codeName);
            //check if mission exists
            mission.Status = Status.Finished;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string baseInfo = base.ToString();

            sb.AppendLine(baseInfo);
            sb.AppendLine($"Corps: {Corps}");
            sb.AppendLine("Missions:");

            foreach (var item in Missions)
            {
                sb.AppendLine($"  {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
