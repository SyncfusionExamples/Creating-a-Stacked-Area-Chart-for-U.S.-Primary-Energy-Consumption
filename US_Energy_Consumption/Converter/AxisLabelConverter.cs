using Microsoft.UI.Xaml.Data;
using Syncfusion.UI.Xaml.Charts;
using System;

namespace US_Energy_Consumption
{
    public class AxisLabelConverter : IValueConverter
    {
        EnergyUtilityConsumption viewModel = new EnergyUtilityConsumption();
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            ChartAxisLabel chartAxisLabel = value as ChartAxisLabel;
            if (viewModel != null && chartAxisLabel != null)
            {
                var label = double.Parse((string)chartAxisLabel.Content);
                return label > 1000 ? (label / 1000).ToString() + "K" : chartAxisLabel.Content;
                      
            }
            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public class ToolTipConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
           if(value != null)
           {
                var segment = value as StackedAreaSegment;
                if (segment != null)
                {
                    var name =segment.Series.Name;
                    return "United States: " + name;
                }
                return value;
           }

           return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public class ToolTipXValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value != null && value is DateTime date)
            {
                var month = date.Date;
                return month.ToString("MMMM-yyyy");
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public class ToolTipYValueConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value != null && value is double val)
            {
                string yValue = val.ToString("###,###");
                return yValue;
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }

    public class FillConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (value != null)
            {
                var segment = value as StackedAreaSegment;
                if (segment != null)
                {
                    return segment.Series.Fill;
                }
                return value;
            }

            return string.Empty;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            throw new NotImplementedException();
        }
    }
}
