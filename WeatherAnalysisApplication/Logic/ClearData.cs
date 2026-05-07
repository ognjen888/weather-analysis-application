//Name: WAP
//Autor: Ognjen Letic
//Datei: ClearData.cs
//day: 4.13.2023
//Klasse: AI122

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void ClearData(ref int[] day, ref byte[] humidity, ref float[] temperature, ref ushort[] airPressure, int arraySize)
        {
            for (int count = 0; count < arraySize; count++)
            {
                day[count] = 0;
                humidity[count] = 0;
                temperature[count] = 0;
                airPressure[count] = 0;
            }
        }
    }
}
