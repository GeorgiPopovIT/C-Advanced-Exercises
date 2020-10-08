using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;

namespace SpeedRacing
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
                var carInfo = Console.ReadLine().Split().ToArray();
                var carModel = carInfo[0];
                var fuelAmount = int.Parse(carInfo[1]);
                var fuelConsumption = double.Parse(carInfo[2]);
                Car car = new Car(carModel, fuelAmount, fuelConsumption);
                cars.Add(car);
            }
            while (true)
            {
                var commandDrive = Console.ReadLine();
                if (commandDrive == "End")
                {
                    break;
                }
                var parts = commandDrive.Split();
                var model = parts[1];
                var amountKm = int.Parse(parts[2]);
                var car = cars.Find(car => car.Model == model);
                car.Drive(amountKm);
            }

            foreach (Car car1 in cars)
            {
                Console.WriteLine(car1.ToString());
            }
        }
    }
}
