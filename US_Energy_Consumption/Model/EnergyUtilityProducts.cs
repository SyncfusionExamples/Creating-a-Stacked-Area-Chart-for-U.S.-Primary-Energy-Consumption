using System;

namespace US_Energy_Consumption
{
    public class EnergyUtilityProducts
    {
        public DateTime Month { get; set; }
        public double Coal { get; set; }
        public double PetroleumLiquid { get; set; }
        public double PetroleumCoke { get; set; }
        public double NaturalGas { get; set; }
        public double Nuclear { get; set; }
        public double HydroElectric { get; set; }
    }
}
