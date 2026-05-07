//Name: WAP
//Autor: Ognjen Letic
//Datei: CalculateDataAverage.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void CalculateDataAverage(ref int[] day, ref byte[] humidity, ref float[] temperature, ref ushort[] airPressure, ref int arraySize)
        {
            //local data
            int countAverage = 0;
            int averageHumidity = 0;
            float averageTemperature = 0;
            int averageAirPressure = 0;

            if (0 == CalculateDataSize(airPressure))
            {
                return;
            }

            for (int count = 0; count < arraySize; count++)
            {
                if (airPressure[count] != 0 && !(count > 364))
                {
                    averageAirPressure = airPressure[count] + averageAirPressure;
                    averageHumidity = humidity[count] + averageHumidity;
                    averageTemperature = temperature[count] + averageTemperature;

                    countAverage = countAverage + 1;
                }
            }

            averageHumidity = averageHumidity / countAverage;
            averageTemperature = averageTemperature / countAverage;
            averageAirPressure = averageAirPressure / countAverage;

            day[367] = countAverage;
            airPressure[367] = (ushort)averageAirPressure;
            humidity[367] = (byte)averageHumidity;
            temperature[367] = averageTemperature;
        }
    }
}
