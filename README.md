# Creating-a-Stacked-Area-Chart-for-U.S.-Primary-Energy-Consumption
This sample demonstrates how to create a Stacked Area Chart for U.S. Primary Energy Consumption.

The [StackedAreaSeries](https://help.syncfusion.com/cr/winui/Syncfusion.UI.Xaml.Charts.StackedAreaSeries.html) is representing the multiple of area series are stacked vertically one above the other.

### Introduction

Here, we will explain about stacked area chart to visualize the energy utility consumption of Coal, PetroleumLiquid, PetroleumCoke, Conventional HydroElectric, Nuclear and NaturalGas using WinUI cartesian chart.

Primary energy utility consumption in the United States refers to the amount of energy consumed by various sectors of the economy, such as residential, commercial, industrial, and transportation, before any conversion or transformation. This energy consumption is measured in terms of the raw energy sources used, including fossil fuels (such as coal, natural gas, and petroleum), renewable sources (such as hydroelectric, solar, wind), and nuclear energy.

### Customize chart tooltip behavior

We can customize the tooltip value using the TooltipBehavior in the SfCartesianChart by initializing the ChartTooltipBehavior class. 
By using the Duration property, we can set how long the tooltip value is displayed while hovering the mouse over the series, and we can animate the tooltip value using the EnableAnimation property. 
Additionally, we can customize the appearance of the tooltip using the Style property in the ChartTooltipBehavior.


### Configure chart zoom pan behavior

We can display the chart area while zoomed in by enabling panning using the EnablePanning property. To prevent pinch zooming and mouse wheel zooming actions, we can disable them using the EnablePinchZooming and EnableMouseWheelZooming properties, respectively.

### Output

![Updated_Output](https://github.com/SyncfusionExamples/Creating-a-Stacked-Area-Chart-for-U.S.-Primary-Energy-Consumption/assets/105482474/24d4b788-9964-4e82-9cc6-84f0b8aa271e)