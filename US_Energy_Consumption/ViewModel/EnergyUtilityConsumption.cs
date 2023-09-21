using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace US_Energy_Consumption
{
    public class EnergyUtilityConsumption
    {
        public ObservableCollection<EnergyUtilityProducts> Coal { get; set; }

        public ObservableCollection<EnergyUtilityProducts> PetroleumLiquid { get; set; }

        public ObservableCollection<EnergyUtilityProducts> PetroleumCoke { get; set; }

        public ObservableCollection<EnergyUtilityProducts> NaturalGas { get; set; }

        public ObservableCollection<EnergyUtilityProducts> Nuclear { get; set; }

        public ObservableCollection<EnergyUtilityProducts> HydroElectric { get; set; }

        public EnergyUtilityConsumption() 
        {
        
            Coal = new ObservableCollection<EnergyUtilityProducts>(ReadCSV("US_Energy_Consumption.Resources.us_energy_consumption_data.csv"));
            PetroleumLiquid = new ObservableCollection<EnergyUtilityProducts>(ReadCSV("US_Energy_Consumption.Resources.us_energy_consumption_data.csv"));
            PetroleumCoke = new ObservableCollection<EnergyUtilityProducts>(ReadCSV("US_Energy_Consumption.Resources.us_energy_consumption_data.csv"));
            NaturalGas = new ObservableCollection<EnergyUtilityProducts>(ReadCSV("US_Energy_Consumption.Resources.us_energy_consumption_data.csv"));
            Nuclear = new ObservableCollection<EnergyUtilityProducts>(ReadCSV("US_Energy_Consumption.Resources.us_energy_consumption_data.csv"));
            HydroElectric = new ObservableCollection<EnergyUtilityProducts>(ReadCSV("US_Energy_Consumption.Resources.us_energy_consumption_data.csv"));
            
        }


        private IEnumerable<EnergyUtilityProducts> ReadCSV(string resourceStream)
        {
            Assembly executingAssembly = typeof(App).GetTypeInfo().Assembly;
            Stream inputStream = executingAssembly.GetManifestResourceStream(resourceStream);

            string? line;
            List<string> lines = new List<string>();
            using StreamReader reader = new StreamReader(inputStream);
            while ((line = reader.ReadLine()) != null)
            {
                lines.Add(line);
            }
            lines.RemoveAt(0);
            return lines.Select(line =>
            {
                string[] data = line.Split(',');
                DateTime date = DateTime.ParseExact(data[0], "MMM-yy", CultureInfo.InvariantCulture);
                return new EnergyUtilityProducts(date, Convert.ToDouble(data[1]), Convert.ToDouble(data[2]), Convert.ToDouble(data[3]), Convert.ToDouble(data[4]), Convert.ToDouble(data[5]), Convert.ToDouble(data[6]));
            });
        }
    }
}
