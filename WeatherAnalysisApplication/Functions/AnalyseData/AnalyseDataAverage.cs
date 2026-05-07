//Name: WAP
//Autor: Ognjen Letic
//Datei: AnalyseDataAverage.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: analyse data average

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void AnalyseDataAverage(ref int[] day, ref byte[] humidity, ref float[] temperature, ref ushort[] airPressure, ref int arraySize)
        {
            CalculateDataAverage(ref day, ref humidity, ref temperature, ref airPressure, ref arraySize);

            Clear();
            WriteLine("Run\\Menu\\AnalyseData\\AverageData:");
            WriteLine("Press any key to go back.");
            RepeatWriteLine(4);
            WriteLine("═════════════════════════════════════", 80);
            WriteLine("                      Average of: " + day[367] + " days");
            WriteLine("");
            WriteLine("                      Average humidty: " + humidity[367] + "%");
            WriteLine("                      Average temperature: " + temperature[367] + "°C");
            WriteLine("                      Average air pressure: " + airPressure[367] + "hPa");
            WriteLine("═════════════════════════════════════", 80);

            ReadKey();
        }
    }
}
