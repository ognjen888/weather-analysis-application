//Name: WAP
//Autor: Ognjen Letic
//Datei: Load.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;
using System.IO;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void Load(ref int[] day, ref byte[] humidity, ref float[] temperature, ref ushort[] airPressure, ref int arraySize)
        {
            // local

            string selectedSlot = SaveSlotSelector();

            if (selectedSlot != "q")
            {
                SaveSlotLoad(selectedSlot, ref day, ref humidity, ref temperature, ref airPressure, arraySize);
            }
        }
    }
}
