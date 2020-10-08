using CarExtension;
using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            Car car = new Car();
            car.Make = "VW";
            car.Model = "gOLF";
            car.Year = 2020;
            car.FuelConsumption = 200;
            car.FuelQuantity = 200;
            car.Drive(2000);
            Console.WriteLine(car.WhoAmI());
        }
    }
}
