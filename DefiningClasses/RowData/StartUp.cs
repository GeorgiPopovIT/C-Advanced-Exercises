using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace RowData
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            List<Car> cars = new List<Car>();
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine().Split().ToArray();
                var model = input[0];
                var engineSpeed = int.Parse(input[1]);
                var enginePower = int.Parse(input[2]);
                var cargoWeight = int.Parse(input[3]);
                var cargoType = input[4];
                var engine = new Engine(engineSpeed, enginePower);
                var cargo = new Cargo(cargoType, cargoWeight);
                var tires = new List<Tire>();
                var tiresSkip = input.Skip(5).ToArray();
                for (int j = 0; j < tiresSkip.Length; j += 2)
                {
                    var pressure = double.Parse(tiresSkip[j]);
                    var age = int.Parse(tiresSkip[j + 1]);
                    var tire = new Tire(pressure, age);
                    tires.Add(tire);
                }
                var currCar = new Car(model, engine, cargo, tires);
                cars.Add(currCar);
            }
            string command = Console.ReadLine();

            Func<List<Car>, string, List<Car>> func = (cars, command) =>
              {
                  if (command == "fragile")
                  {
                      return cars.Where(c => c.Cargo.TypeCargo == command &&
                      c.Tires.Any(t => t.PressureTire < 1)).ToList();
                  }
                  else
                  {
                      return cars.Where(c => c.Cargo.TypeCargo == command && c.Engine.EnginePower > 250).ToList();
                  }

              };

            foreach (Car car in func(cars, command))
            {
                Console.WriteLine(car.ToString());
            }
        }
    }
}
