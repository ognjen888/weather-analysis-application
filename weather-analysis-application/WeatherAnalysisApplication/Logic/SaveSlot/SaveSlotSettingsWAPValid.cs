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
        static bool SaveSlotSettingsWAPValid()
        {
            // local

            if (File.Exists("settings.wap"))
            {
                return true;
            }

            StreamWriter writer = new StreamWriter("settings.wap");

            writer.Close();

            return true;
        }
    }
}
