

namespace RowData
{
    public class Cargo
    {
        public Cargo(string cargoType, int weightCargo)
        {
            TypeCargo = cargoType;
            WeightCargo = weightCargo;
        }
        public string TypeCargo { get; set; }
        public int WeightCargo { get; set; }
    }
}
