//Name: WAP
//Autor: Ognjen Letic
//Datei: SaveSlotSelector.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;
using System.IO;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static string SaveSlotSelector()
        {
            // local
            bool loop = true;
            string[] parts = new string[0];
            string selectedSlot = "";

            if (SaveSlotSettingsWAPValid())
            {
                string line = SaveSlotRead();

                if (line != null)
                {
                    parts = line.Split(';');
                }

                while (loop == true)
                {
                    Clear();

                    WriteLine("Run\\Menu\\Load:");
                    WriteLine("If you wish to go back type q and press ENTER");
                    WriteLine("");
                    WriteLine("Please type a file name you want to load and press ENTER,");
                    WriteLine("for example if you want to access file example.csv       ");
                    WriteLine("type example.csv                                         ");
                    WriteLine("");

                    for (int count = 0; count < parts.Length; count++)
                    {
                        WriteLine($"Save slot [{parts[count]}]");
                    }

                    WriteLine("");

                    selectedSlot = Read();

                    if (selectedSlot == "q" || selectedSlot == "")
                    {
                        return selectedSlot;
                    }

                    for (int count = 0; count < parts.Length; count++)
                    {
                        if (selectedSlot == parts[count])
                        {
                            loop = false;
                        }
                    }
                }
            }

            return selectedSlot;
        }
    }
}
