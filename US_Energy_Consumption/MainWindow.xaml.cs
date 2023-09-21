using Microsoft.UI;
using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;

using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace US_Energy_Consumption
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        private void SfCartesianChart_ManipulationCompleted(object sender, ManipulationCompletedRoutedEventArgs e)
        {
            var count = chart.Series.Count;
            for (int i = 0; i < count; i++)
            {
                var series = chart.Series[i];
                series.EnableTooltip = true;
            }
        }

        private void SfCartesianChart_ManipulationStarted(object sender, ManipulationStartedRoutedEventArgs e)
        {
            var count = chart.Series.Count;
            for (int i = 0; i < count; i++)
            {
                var series = chart.Series[i];
                series.EnableTooltip = false;
            }
        }
    }
}
