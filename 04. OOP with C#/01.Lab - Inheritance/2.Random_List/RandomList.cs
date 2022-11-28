using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        public string RandomString()
        {
            Random random = new Random();

            var index = random.Next(0, Count);

            string str = this[index];

            this.RemoveAt(index);

            return str;
        }
    }
}
