using System;

namespace SpeedRacing
{
    public class Car
    {
        public Car(string model)
        {
            Model = model;
        }
        public Car(string model,double fuelAmount,
            double fuelConsumptionPerKilometer): this(model)
        {
            FuelAmount = fuelAmount;
            FuelConsumptionPerKilometer = fuelConsumptionPerKilometer;
        }
        public string Model { get; set; }
        public double FuelAmount { get; set; }
        public double FuelConsumptionPerKilometer { get; set; }
        public double TravelledDistance { get; set; }

        public void Drive(double amountKm)
        {
            var neededFuel = FuelConsumptionPerKilometer * amountKm;
            if (FuelAmount < neededFuel)
            {
                Console.WriteLine("Insufficient fuel for the drive");
            }
            else
            {
                TravelledDistance += amountKm;
                FuelAmount -= neededFuel;
            }
        }

        public override string ToString()
        {
            return $"{Model} {FuelAmount:F2} {TravelledDistance}";
        }
    }
}
