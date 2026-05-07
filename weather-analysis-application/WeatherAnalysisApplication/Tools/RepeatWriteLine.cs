//Name: WAP
//Autor: Ognjen Letic
//Datei: RepeatWriteLine.cs
//day: 4.13.2023
//Klasse: AI122

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void RepeatWriteLine(int amount)
        {
            for (int count = 0; count < amount; count++)
            {
                Console.WriteLine("");  
            }
        }
    }
}
