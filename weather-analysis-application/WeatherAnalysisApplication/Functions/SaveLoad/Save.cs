//Name: WAP
//Autor: Ognjen Letic
//Datei: Save.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: main

using System;
using System.IO;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void Save(int[] day, byte[] humidity, float[] temperature, ushort[] airPressure, int arraySize)
        {
            // local
            bool loop = true;
            bool encrypt = false;
            string userInput = "";
            string fileName = "";
            int dataSize = 0;

            dataSize = CalculateDataSize(airPressure);

            if (dataSize == 0)
            {
                Clear();
                Console.WriteLine("Run\\Menu\\Save:");
                Console.WriteLine("Press any key to go back.");
                RepeatWriteLine(4);
                WriteLine("╔═══════════════════════════════════╗", 80);
                WriteLine("║ There is no data                  ║", 80);
                WriteLine("╚═══════════════════════════════════╝", 80);

                ReadKey();

                return;
            }

            while (loop == true)
            {
                Clear();
                WriteLine("Run\\Menu\\SaveLoadSave:");
                WriteLine("If you wish to go back type q and press ENTER");
                RepeatWriteLine(3);
                WriteLine("Please write the name you wish to save your file as", 80);
                WriteLine("note that application will apply .csv automatically", 80);

                userInput = Read();

                if (userInput == "q" || userInput == "")
                {
                    return;
                }

                fileName = userInput;

                Clear();
                RepeatWriteLine(5);
                WriteLine($"Please write the name [{userInput}] again to confirm it", 80);
                WriteLine($"as [{userInput + ".csv"}] otherwise press ENTER to go back", 80);

                userInput = Read();

                if (userInput == fileName)
                {
                    Clear();
                    RepeatWriteLine(5);
                    WriteLine("Do you wish to encrypt this file?", 80);
                    WriteLine("1. Yes                           ", 80);
                    WriteLine("2. No                            ", 80);

                    userInput = IsDataValid("Input:", 1, 2);

                    if (userInput == "1")
                    {
                        encrypt = true;
                    }

                    fileName = fileName + ".csv";
                    
                    SaveSlotCreate(fileName, day, humidity, temperature, airPressure, arraySize, encrypt);
                    SaveSlotSettingsWAPUpdate(fileName);
                    Message("Succesfully saved data.");

                    loop = false;
                }
            }

            return;
        }
    }
}
