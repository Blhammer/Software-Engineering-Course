using System;
using System.Collections.Generic;
using System.Text;

namespace _3._CarConstructors
{
    public class Tire
    {
        private int year;
        private double pressure;

        public Tire(int year, double pressure)
        {
            this.Year = year;
            this.Pressure = pressure;
        }
        
        public int Year { get; set; }
        public double Pressure { get; set; }
    }
}
