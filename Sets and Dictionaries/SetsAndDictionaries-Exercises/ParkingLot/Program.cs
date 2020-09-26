using System;
using System.Collections.Generic;
using System.Linq;

namespace ParkingLot
{
    class Program
    {
        static void Main(string[] args)
        {
            var parking = new HashSet<string>();
            while (true)
            {
                string[] command = Console.ReadLine().Split(", ").ToArray();
                if (command[0] == "END")
                {
                    break;
                }
                if (command[0] == "IN")
                {
                    parking.Add(command[1]);
                }
                else if (command[0] == "OUT")
                {
                    parking.Remove(command[1]);
                }
            }
            if(parking.Count == 0)
            {
                Console.WriteLine("Parking Lot is Empty");
            }
            foreach (var car in parking)
            {
                Console.WriteLine(car);
            }
        }
    }
}
