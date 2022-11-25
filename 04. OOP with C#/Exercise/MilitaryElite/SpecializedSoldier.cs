﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MilitaryElite
{
    public class SpecializedSoldier : Private, ISpecializedSoldier
    {
        private string corps;
        public SpecializedSoldier(string id, string firstName, string lastName, decimal salary, string corps)
            : base(id, firstName, lastName, salary)
        {
            Corps = corps;
        }

        public string Corps
        {
            get => corps;
            set
            {
                if (value != "Airforces" && value != "Marines")
                {
                    throw new ArgumentException("Invalid Corps!");
                }

                corps = value;
            }
        }

        public override string ToString()
            => $"{base.ToString()}{Environment.NewLine}Corps: {Corps}";
    }
}
