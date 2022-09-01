using System;

namespace CarManufacturer
{
    public class Car
    {
        private string make;
        private string model;
        private int year;
        private double fuelQuantity;
        private double fuelConsumption;
        
        public Car()
        {

        }

        public Car(string make, string model, int year) 
            : this()
        {
            this.Make = make;
            this.Model = model;
            this.Year = year;
        }

        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption) 
            : this(make, model, year)
        {
            this.FuelQuantity = fuelQuantity;
            this.FuelConsumption = fuelConsumption;
        }

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }

        public void Drive(double distance)
        {
            double distanceResult = fuelQuantity - (distance * fuelConsumption);

            if (distanceResult > 0)
            {
                fuelQuantity -= distance * fuelConsumption;
            }
            else
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
        }

        public string Report()
        {
            return $"Make: {this.Make} {Environment.NewLine}" +
                   $"Model: {this.Model} {Environment.NewLine}" +
                   $"Year: {this.Year} {Environment.NewLine}" +
                   $"Fuel: {this.FuelQuantity:F2} {Environment.NewLine}";
        }
    }
}
