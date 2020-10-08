using System;
using System.Text;

namespace CarManufacturer
{
    public class Car
    {
        private int v;
        private Tire[] tires;

        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double FuelQuantity { get; set; }
        public double FuelConsumption { get; set; }
        public Engine Engine { get; set; }
        public Tire[] Tire { get; set; }

        public Car()
        {
            Make = "Vw";
            Model = "Golf";
            Year = 2025;
            FuelQuantity = 200;
            FuelConsumption = 10;
        }
        public Car(string make, string model, int year) : this()
        {
            Make = make;
            Model = model;
            Year = year;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
            : this(make, model, year)
        {
            FuelQuantity = fuelQuantity;
            FuelConsumption = fuelConsumption;
        }
        public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption,
            Engine engine,Tire[] tires): this(make,model,year,fuelQuantity,fuelConsumption)
        {
            Engine = engine;
            Tire = tires;
        }

        public Car(string make, string model, int year, int v, Engine engine, Tire[] tires) : this(make, model, year)
        {
            this.v = v;
            Engine = engine;
            this.tires = tires;
        }

        public void Drive(double distance)
        {
            var neededFuel = FuelQuantity - FuelConsumption * distance / 100;
            if (neededFuel <= 0)
            {
                Console.WriteLine("Not enough fuel to perform this trip!");
            }
            else
            {
                FuelQuantity -= FuelConsumption * distance / 100;
            }
        }
        public string WhoAmI()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Make: {Make}");
            sb.AppendLine($"Model: {Model}");
            sb.AppendLine($"Year: {Year}");
            sb.AppendLine($"Fuel: {FuelQuantity}");

            return sb.ToString();
        }
    }
}
