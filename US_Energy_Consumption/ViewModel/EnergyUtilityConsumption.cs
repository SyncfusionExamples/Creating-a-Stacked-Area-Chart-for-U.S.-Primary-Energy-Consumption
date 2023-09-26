using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Reflection;

namespace US_Energy_Consumption
{
    public class EnergyUtilityConsumption
    {
        public ObservableCollection<EnergyUtilityProducts> CollectionOfData { get; set; }

        public EnergyUtilityConsumption() 
        {
            CollectionOfData = new ObservableCollection<EnergyUtilityProducts>();
            ReadCSV("US_Energy_Consumption.Resources.us_energy_consumption_data.csv");
        }


        private void ReadCSV(string resourceStream)
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
            
            foreach(var dataPoint in lines)
            {
                string[] data = dataPoint.Split(',');
                DateTime date = DateTime.ParseExact(data[0], "MMM-yy", CultureInfo.InvariantCulture);
                CollectionOfData.Add(new EnergyUtilityProducts() { Month = date, Coal = Convert.ToDouble(data[1]), PetroleumLiquid = Convert.ToDouble(data[2]), PetroleumCoke = Convert.ToDouble(data[3]), NaturalGas = Convert.ToDouble(data[4]),Nuclear = Convert.ToDouble(data[5]), HydroElectric = Convert.ToDouble(data[6]) });
              
            }
        }
    }
}
