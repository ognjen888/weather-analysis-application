//Name: WAP
//Autor: Ognjen Letic
//Datei: SaveSlotSettingsWAPUpdate.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;
using System.IO;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void SaveSlotSettingsWAPUpdate(string fileName)
        {
            // local
            string line = "";
            string[] parts = new string[0];
            StreamWriter writer;
            StreamReader reader;

            if (!SaveSlotSettingsWAPValid())
            {
                return;
            }

            reader = new StreamReader("settings.wap");
            line = reader.ReadLine();
            reader.Close();

            if (line == null)
            {
                writer = new StreamWriter("settings.wap");
                writer.WriteLine(fileName);
                writer.Close();

                return;
            }

            parts = line.Split(';');

            for (int count = 0; count < parts.Length; count++)
            {
                if (fileName == parts[count])
                {
                    return;
                }
            }

            writer = new StreamWriter("settings.wap");
            writer.WriteLine(fileName + ";" + line);
            writer.Close();
        }
    }
}
