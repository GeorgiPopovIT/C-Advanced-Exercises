using System;
using System.Collections.Generic;
using System.Linq;

namespace SoftUniParking
{
    public class Parking
    {
        private List<Car> cars;
        private int capacity;
        public Parking(int capacity)
        {
            cars = new List<Car>();
            this.capacity = capacity;
        }

        public int Count
        {
            get { return cars.Count; }
            set { }
        }

        public string AddCar(Car car)
        {
            if (cars.Any(c => c.RegistrationNumber == car.RegistrationNumber))
            {
                return "Car with that registration number, already exists!";
            }

            if (cars.Count == capacity)
            {
                return "Parking is full!";
            }
            cars.Add(car);
            return $"Successfully added new car {car.Make} {car.RegistrationNumber}";



        }
        public string RemoveCar(string regNum)
        {
            Car car = cars.FirstOrDefault(x => x.RegistrationNumber == regNum);
            if (car != null)
            {
                cars.Remove(car);
                return $"Successfully removed {regNum}";
            }
            else
            {
                return "Car with that registration number, doesn't exist!";
            }
        }

        public Car GetCar(string regNum)
        {
            return cars.FirstOrDefault(c => c.RegistrationNumber == regNum);
        }
        public void RemoveSetOfRegistrationNumber(List<string> regNums)
        {
            foreach (var regNum in regNums)
            {
                var car = cars.FirstOrDefault(x => x.RegistrationNumber == regNum);
                cars.Remove(car);
            }
        }
    }
}
