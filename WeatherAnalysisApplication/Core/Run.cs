//Name: WAP
//Autor: Ognjen Letic
//Datei: Run.cs
//day: 4.13.2023
//Klasse: AI122
//Beschreibung: run

using System;

namespace WeatherAnalysisApplication
{
    partial class main
    {
        static void Run(ref int[] day, ref byte[] humidity, ref float[] temperature, ref ushort[] airPressure, ref int arraySize)
        {
            //local
            bool mainLoop = true;
            int menuPosition = 0;
            int selectOption = 0;
            ConsoleKeyInfo userKeyInput;

            while(mainLoop == true)
            {
                menuPosition = RunMenu(menuPosition, 5);
                userKeyInput = ReadKey();

                //menu options
                selectOption = CalculateOption(userKeyInput, ref menuPosition);

                if (selectOption == 1)
                {
                    AddData(ref day, ref humidity, ref temperature, ref airPressure, ref arraySize);
                }
                else if (selectOption == 2)
                {
                    AnalyseData(ref day, ref humidity, ref temperature, ref airPressure, ref arraySize);
                }
                else if (selectOption == 3)
                {
                    ShowData(ref day, ref humidity, ref temperature, ref airPressure, ref arraySize);
                }
                else if (selectOption == 4)
                {
                    SaveLoad(ref day, ref humidity, ref temperature, ref airPressure, ref arraySize);
                }
                else if (selectOption == 5) 
                {
                    mainLoop = false;
                }
                else
                {
                    //
                }

                Clear();
            }

            SaveSlotCreate("autosave.csv", day, humidity, temperature, airPressure, arraySize);
            SaveSlotSettingsWAPUpdate("autosave.csv");
        }
    }
}
