﻿using System;

namespace CarManufacturer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            var tires = new Tire[4]
           {
               new Tire(1,2.5),
               new Tire(1, 2.1),
               new Tire(1, 0.5),
               new Tire(2, 2.3)
           };
            var engine = new Engine(560, 6300);
            Car car = new Car("Lambo", "Urus", 2010, 250, engine, tires);
        }
    }
}