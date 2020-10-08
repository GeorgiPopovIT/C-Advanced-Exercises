

namespace RowData
{
    public class Tire
    {
        public Tire(double pressureTire,int ageTire)
        {
            AgeTire = ageTire;
            PressureTire = pressureTire;
        }
        public int AgeTire { get; set; }
        public double PressureTire { get; set; }
    }
}
