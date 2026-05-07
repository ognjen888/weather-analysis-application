//Name: WAP
//Autor: Ognjen Letic
//Datei: AnalyseDataMinMax.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: analyse data min max

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void AnalyseDataMinMax(ref int[] day, ref byte[] humidity, ref float[] temperature, ref ushort[] airPressure, ref int arraySize)
        {
            //local data
            int[] minMaxDayHumidity = new int[4] { 101, 0, 0, 0 }; // 0 is min, 1 is max, 2 is min day and 3 is max day
            int[] minMaxDayTemperature = new int[4] { 61, -90, 0, 0 };
            int[] minMaxDayAirPressure = new int[4] { 1061, 0, 0, 0 };

            for (int count = 0; count < arraySize; count++)
            {
                if (airPressure[count] != 0 && !(count > 364))
                {
                    if (humidity[count] < minMaxDayHumidity[0])
                    {
                        minMaxDayHumidity[0] = humidity[count];
                        minMaxDayHumidity[2] = count + 1;
                    }
                    if (humidity[count] > minMaxDayHumidity[1])
                    {
                        minMaxDayHumidity[1] = humidity[count];
                        minMaxDayHumidity[3] = count + 1;
                    }

                    if (temperature[count] < minMaxDayTemperature[0])
                    {
                        minMaxDayTemperature[0] = (int) temperature[count];
                        minMaxDayTemperature[2] = count + 1;
                    }
                    if (temperature[count] > minMaxDayTemperature[1])
                    {
                        minMaxDayTemperature[1] = (int) temperature[count];
                        minMaxDayTemperature[3] = count + 1;
                    }

                    if (airPressure[count] < minMaxDayAirPressure[0])
                    {
                        minMaxDayAirPressure[0] = (int)airPressure[count];
                        minMaxDayAirPressure[2] = count + 1;
                    }
                    if (airPressure[count] > minMaxDayAirPressure[1])
                    {
                        minMaxDayAirPressure[1] = (int)airPressure[count];
                        minMaxDayAirPressure[3] = count + 1;
                    }
                }
            }

            Clear();

            WriteLine("Run\\Menu\\AnalyseData\\MaximalMinimalData:");
            WriteLine("Press any key to go back.");
            RepeatWriteLine(4);
            WriteLine("══════════════════════════════════════════════════════", 80);
            WriteLine("              Minimal humidty: " + minMaxDayHumidity[0] + "% was recorded on day " + minMaxDayHumidity[2]);
            WriteLine("              Maximal humidty: " + minMaxDayHumidity[1] + "% was recorded on day " + minMaxDayHumidity[3]);
            WriteLine("");
            WriteLine("              Minimal temperature: " + minMaxDayTemperature[0] + "°C was recorded on day " + minMaxDayTemperature[2]);
            WriteLine("              Maximal temperature: " + minMaxDayTemperature[1] + "°C was recorded on day " + minMaxDayTemperature[3]);
            WriteLine("");
            WriteLine("              Minimal airPressure: " + minMaxDayAirPressure[0] + "hPa was recorded on day " + minMaxDayAirPressure[2]);
            WriteLine("              Maximal airPressure: " + minMaxDayAirPressure[1] + "hPa was recorded on day " + minMaxDayAirPressure[3]);
            WriteLine("══════════════════════════════════════════════════════", 80);

            ReadKey();
        }
    }
}
