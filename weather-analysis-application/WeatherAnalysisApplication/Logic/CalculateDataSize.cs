//Name: WAP
//Autor: Ognjen Letic
//Datei: CalculateOption.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static int CalculateDataSize(ushort[] airPressure)
        {
            // local
            int dataSize = 0;

            for (int count = 0; count < 365; count++)
            {
                if (airPressure[count] != 0)
                {
                    dataSize += 1;
                }
            }

            return dataSize;
        }
    }
}
