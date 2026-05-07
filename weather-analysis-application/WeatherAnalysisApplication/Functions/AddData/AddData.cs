//Name: WAP
//Autor: Ognjen Letic
//Datei: AddData.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: add data

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void AddData(ref int[] day, ref byte[] humidity, ref float[] temperature, ref ushort[] airPressure, ref int arraySize)
        {
            //local data
            bool loop = true;
            int menuPosition = 0;
            int selectOption = 0;
            string userString = "";
            ConsoleKeyInfo userKeyInput;

            if (CalculateDataSize(airPressure) != 0)
            {
                Clear();
                RepeatWriteLine(8);
                WriteLine("There is allready data do you wish to clear it?", 80);
                WriteLine("1. Yes                                         ", 80);
                WriteLine("2. No                                          ", 80);

                userString = IsDataValid("Input:", 1, 2);

                if (userString == "1")
                {
                    SaveSlotCreate("autosave.csv", day, humidity, temperature, airPressure, arraySize);
                    SaveSlotSettingsWAPUpdate("autosave.csv");
                    Message("Data has been saved to autosave.csv");

                    ClearData(ref day, ref humidity, ref temperature, ref airPressure, arraySize);
                    Message("Data has been cleared.");
                }
            }

            while (loop == true)
            {
                Clear();

                menuPosition = AddDataMenu(menuPosition, 3);
                userKeyInput = ReadKey();

                selectOption = CalculateOption(userKeyInput, ref menuPosition);

                if (selectOption == 1)
                {
                    AddDataKnown(ref day, ref humidity, ref temperature, ref airPressure, ref arraySize);
                }
                else if (selectOption == 2)
                {
                    AddDataUnknown(ref day, ref humidity, ref temperature, ref airPressure, ref arraySize);
                }
                else if (selectOption == 3) 
                {
                    loop = false;
                }
            }
        }
    }
}
