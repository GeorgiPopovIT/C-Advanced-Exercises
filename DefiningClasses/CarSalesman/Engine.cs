using System;
using System.Collections.Generic;
using System.Text;

namespace CarSalesman
{
    public class Engine
    {
        public Engine(string model,string power)
        {
            Model = model;
            Power = power;
        }
        public Engine(string model, string power, int displacement) : this(model,power)
        {
            Displacement = displacement;
        }
        public Engine(string model, string power,string efficiency) : this(model,power)
        {
            Efficiency = efficiency;
        }
        public Engine(string model, string power, int displacement,string efficiency)
            : this(model,power,displacement)
        {
            Efficiency = efficiency;
        }
        public string Model { get; set; }
        public string Power { get; set; }
        public int Displacement { get; set; } 
        public string Efficiency { get; set; } = "n/a";

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            string strDisplacement = Displacement == 0 ? "n/a" : Displacement.ToString();
            sb.AppendLine($"{Model}:");
            sb.AppendLine($"Power: {Power}");
            sb.AppendLine($"Displacement: {strDisplacement}");
            sb.Append($"Efficiency: {Efficiency}");

            return sb.ToString();
        }
    }
}
