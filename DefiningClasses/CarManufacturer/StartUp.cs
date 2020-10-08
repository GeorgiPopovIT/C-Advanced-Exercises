using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            List<Tire[]> tires = new List<Tire[]>();
            while (true)
            {
                var input = Console.ReadLine();
                Tire[] currTires = new Tire[4];
                if (input == "No more tires")
                {
                    break;
                }
                var parts = input.Split();
                for (int i = 0; i < parts.Length; i += 2)
                {
                    var year = int.Parse(parts[i]);
                    var cubicCapacity = double.Parse(parts[i + 1]);
                    currTires[i / 2] = new Tire(year, cubicCapacity);
                }
                tires.Add(currTires);
            }

            List<Engine> engines = new List<Engine>();
            while (true)
            {
                var input = Console.ReadLine();

                if (input == "Engines done")
                {
                    break;
                }
                var parts = input.Split();
                var horsePower = int.Parse(parts[0]);
                var cubicCapacity = double.Parse(parts[1]);
                var currEngine = new Engine(horsePower, cubicCapacity);

                engines.Add(currEngine);
            }

            List<Car> cars = new List<Car>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input.Contains("Show special"))
                {
                    break;
                }
                var parts = input.Split();
                var make = parts[0];
                var model = parts[1];
                var year = int.Parse(parts[2]);
                var fuelQuantity = double.Parse(parts[3]);
                var fuelConsumption = double.Parse(parts[4]);
                var engineIndex = int.Parse(parts[5]);
                var tiresIndex = int.Parse(parts[6]);

                Engine engine = engines[engineIndex];
                Tire[] currTires = tires[tiresIndex];
                Car car = new Car(make, model, year, fuelQuantity, fuelConsumption, engine, currTires);
                cars.Add(car);
            }

            List<Car> special = new List<Car>();
            foreach (var car in cars)
            {
                var currPressure = new List<double>();
                foreach (Tire tire in car.Tire)
                {
                    currPressure.Add(tire.Pressure);
                }
                double tireSum = currPressure.Sum();
                if ((tireSum >= 9&& tireSum <= 10) && car.Year >= 2017 && car.Engine.HorsePower > 330)
                {
                    special.Add(car);
                }
            }

            foreach (Car car in special)
            {
                car.Drive(20);
                Console.WriteLine(car.WhoAmI());
            }
        }
    }
}
