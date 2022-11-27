using System;
using System.Collections.Generic;
using System.Text;

namespace Animals
{
    public class Cat : Animal
    {
        public Cat(string name, string favoriteFood)
            : base(name, favoriteFood)
        {
        }

        public override string ExplainSelf()
            => $"{base.ExplainSelf()}{Environment.NewLine}Meow Meow";
    }
}
