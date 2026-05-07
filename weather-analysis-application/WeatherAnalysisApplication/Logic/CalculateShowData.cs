//Name: WAP
//Autor: Ognjen Letic
//Datei: .cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static int CalculateShowData(int currentPage)
        {
            // local
            int showData = 0;

            for (int count = 1; count < currentPage; count++)
            {
                showData = showData + 15;
            }

            return showData;
        }
    }
}
