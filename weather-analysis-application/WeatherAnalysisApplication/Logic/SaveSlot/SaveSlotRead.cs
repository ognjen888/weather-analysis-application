//Name: WAP
//Autor: Ognjen Letic
//Datei: SaveSlotRead.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;
using System.IO;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static string SaveSlotRead()
        {
            // local

            StreamReader reader = new StreamReader("settings.wap");

            string line = reader.ReadLine();

            reader.Close();

            return line;
        }
    }
}
