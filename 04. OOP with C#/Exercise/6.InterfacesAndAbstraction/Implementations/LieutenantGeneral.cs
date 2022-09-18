using MilitaryElite.Interfaces;

using System.Collections.Generic;
using System.Text;

namespace MilitaryElite.Implementations
{
    public class LieutenantGeneral : Private, ILieutenantGeneral
    {
        public LieutenantGeneral(int id, string firstName, string lastName, decimal salary)
            : base(id, firstName, lastName, salary)
        {
            this.Privates = new List<IPrivate>();
        }

        public List<IPrivate> Privates { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            string baseInfo = base.ToString();

            sb.AppendLine(baseInfo);
            sb.AppendLine("Privates:");

            foreach (var item in Privates)
            {
                sb.AppendLine($"  {item}");
            }

            return sb.ToString().TrimEnd();
        }
    }
}
