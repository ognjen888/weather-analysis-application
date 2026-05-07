//Name: WAP
//Autor: Ognjen Letic
//Datei: SaveLoadSave.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;
using System.IO;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void SaveLoad(ref int[] day, ref byte[] humidity, ref float[] temperature, ref ushort[] airPressure, ref int arraySize)
        {
            // local
            bool loop = true;
            int menuPosition = 0;
            int selectOption = 0;
            ConsoleKeyInfo userKeyInput;

            while (loop == true)
            {
                Clear();

                menuPosition = SaveLoadMenu(menuPosition, 3);
                userKeyInput = ReadKey();

                selectOption = CalculateOption(userKeyInput, ref menuPosition);

                if (selectOption == 1)
                {
                    Save(day, humidity, temperature, airPressure, arraySize);
                }
                else if (selectOption == 2)
                {
                    Load(ref day, ref humidity, ref temperature, ref airPressure, ref arraySize);
                }
                else if (selectOption == 3) 
                {
                    loop = false;
                }
            }
        }
    }
}
