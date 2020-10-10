using System;
using System.Collections.Generic;
using System.Linq;

namespace CarSalesman
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Func<string, bool> tryParse = x =>
             {
                 int number;
                 if (Int32.TryParse(x, out number))
                 {
                     return true;
                 }
                 else
                 {
                     return false;
                 }
             };
            List<Engine> engines = new List<Engine>();
            for (int i = 0; i < n; i++)
            {
                var engineInfo = Console.ReadLine().Split().ToArray();
                var model = engineInfo[0];
                var power = engineInfo[1];
                if (engineInfo.Length == 3)
                {
                    if (tryParse(engineInfo[2]))
                    {
                        int displacement = int.Parse(engineInfo[2]);
                        Engine engine = new Engine(model, power, displacement);
                        engines.Add(engine);
                    }
                    else
                    {
                        var efficiency = engineInfo[2];
                        var engine = new Engine(model, power, efficiency);
                        engines.Add(engine);
                    }

                }
                else if (engineInfo.Length == 4)
                {
                    int displacement = int.Parse(engineInfo[2]);
                    var efficiency = engineInfo[3];
                    Engine engine = new Engine(model, power, displacement, efficiency);
                    engines.Add(engine);
                }
                else
                {
                    Engine engine = new Engine(model, power);
                    engines.Add(engine);
                }

            }
            List<Car> cars = new List<Car>();
            int m = int.Parse(Console.ReadLine());
            for (int i = 0; i < m; i++)
            {
                var carInfo = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                var model = carInfo[0];
                var engineModel = carInfo[1];
                var engine = engines.Find(x => x.Model == engineModel);
                if (carInfo.Length == 3)
                {
                    if (tryParse(carInfo[2]))
                    {
                        int weight = int.Parse(carInfo[2]);
                        var car = new Car(model, engine, weight);
                        cars.Add(car);
                    }
                    else
                    {
                        var color = carInfo[2];
                        var car = new Car(model, engine, color);
                        cars.Add(car);
                    }
                }
                else if (carInfo.Length == 4)
                {
                    var weight = int.Parse(carInfo[2]);
                    var color = carInfo[3];
                    var car = new Car(model, engine, weight, color);
                    cars.Add(car);
                }
                else
                {
                    var car = new Car(model, engine);
                    cars.Add(car);
                }
            }

            foreach (Car car1 in cars)
            {
                Console.WriteLine(car1.ToString());
            }
        }
    }
}
